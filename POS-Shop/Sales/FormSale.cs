using POS_Shop.Models;
using POS_Shop.Utils;
using POS_Shop.Utils.MyUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Sales
{
    public partial class SaleForm : Form
    {
        private Order order = new Order();
        public SaleForm()
        {
            InitializeComponent();
            LoadCategory();
            LoadDicount();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadProducts();

            // Exchange
            var exchange = LoadValue();
            if (exchange != null)
            {
                labelInfoExchange.Text = exchange.Info();
            }
        }

        private void LoadDicount()
        {
            var discounts = new Discount().GetDiscounts();
            comboBoxDiscount.DataSource = discounts;
            comboBoxDiscount.ValueMember = "Value";
            comboBoxDiscount.DisplayMember = "Text";
        }


        private void LoadProducts()
        {
            var category = (Category)comboBoxCategory.SelectedItem;
            var itemProducts = new Product().readAllByCategoryId(category.Id, txtSearch.Text);
            int c = 0, r = 0;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear(); ;
            tableLayoutPanel.ColumnStyles.Clear();

            for (int i = 0; i < itemProducts.Count; i++)
            {
                tableLayoutPanel.Controls.Add(itemProducts[i], c, r);
                itemProducts[i].PicOrder.Click += new EventHandler(UserControl_Click);

                c++;
                if (c > 2)
                {
                    c = 0;
                    r++;
                }
            }
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            var itemDetails = ItemProductControl.ItemDetailsStatic;
            if (itemDetails != null)
            {
                var rowDataView = new RowDataViewItemControl(itemDetails);
                rowDataView.Dock = DockStyle.Top;
                rowDataView.No = panelDataView.Controls.Count + 1 + "";
                rowDataView.PicAdd.Click += new EventHandler(IncreseProduct_Click);
                rowDataView.PicRemove.Click += new EventHandler(RemoveProduct_Click);

                if (ItemProductControl.LableItemsStatic == 0)
                {
                    ShowAlert("Item is not avaiable in stock.", FormAlertNotification.Type.Info);
                }
                else
                {
                    if (!FindProductByIdList(rowDataView))
                    {
                        panelDataView.Controls.Add(rowDataView);
                    }

                }
                CalcSale();
            }
        }

        private Exchange LoadValue()
        {
            return new Exchange().SelectFirstExchange();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadCategory()
        {
            comboBoxCategory.DataSource = new Category().GetCategories();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }

        private List<RowDataViewItemControl> RowDataViewItemControls()
        {
            List<RowDataViewItemControl> items = new List<RowDataViewItemControl>();
            foreach (var control in panelDataView.Controls)
            {
                var item = (RowDataViewItemControl)control;
                items.Add(item);

            }
            return items;
        }

        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void IncreseProduct_Click(object sender, EventArgs e)
        {
            CalcSale();
        }

        private bool FindProductByIdList(RowDataViewItemControl rowData)
        {
            var items = RowDataViewItemControls();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemDetails.ProductId == rowData.ItemDetails.ProductId)
                {
                    rowData.No = i + 1 + "";
                    panelDataView.Controls[i].Controls.Add(rowData);
                    return true;
                }
            }
            return false;
        }

        private void RemoveItem()
        {
            var items = RowDataViewItemControls();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemDetails.Qty == 0)
                {
                    panelDataView.Controls.Remove(items[i]);
                }
            }
            CalcSale();
        }

        private void CalcSale()
        {
            var items = RowDataViewItemControls();
            float subTotal = 0;
            var selectedDis = (Discount)comboBoxDiscount.SelectedItem;
            var discount = selectedDis.Value;
            var exchangeRiel = new Exchange().SelectFirstExchange().Riel;
            if (items.Count == 0)
            {
                ClearOrder();
            }
            foreach (var item in items)
            {
                
                var perTotal = (item.ItemDetails.Amount.ToString(FormatUtils.dollar)).TrimStart('$');
                subTotal += float.Parse(perTotal);
                var discounts = subTotal * discount;
                order = new Order(0, discounts, subTotal);
                labelSubTotal.Text = (order.SubTotal).ToString(FormatUtils.dollar);
                labelDiscounts.Text = (order.Discount).ToString(FormatUtils.dollar);
                labelAmount.Text = (order.Amount).ToString(FormatUtils.dollar);
                labelRiel.Text = (order.Amount * int.Parse(order.Exchange)).ToString(FormatUtils.riel);
            }

        }

        private void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            new FormAlertNotification().ShowAlert(msg, type);
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSale();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            List<OrderDetails> details = new List<OrderDetails>();
            if(order.Amount > 0)
            {
                foreach (var item in RowDataViewItemControls())
                {
                    details.Add(item.ItemDetails);
                }

                Sale saleInvoice = new Sale(order, details);
                if(saleInvoice.create())
                {
                    ClearValue();
                }
            }
            else
            {
                ShowAlert("No items.", FormAlertNotification.Type.Warning);
            }
        }

        private void ClearValue()
        {
            panelDataView.Controls.Clear();
            ClearOrder();
        }

        private void ClearOrder()
        {
            labelSubTotal.Text = "$0";
            labelAmount.Text = "$0";
            labelDiscounts.Text = "$0";
            labelRiel.Text = "0 riel";
            order = new Order();
        }
    }
}
