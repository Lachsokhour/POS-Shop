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

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void LoadProducts()
        {
            var category = (Category)comboBoxCategory.SelectedItem;
            var itemProducts = new Product().readAllByCategoryId(category.Id, txtSearch.Text);
            int c = 1, r = 0;
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowStyles.Clear(); ;
            tableLayoutPanel.ColumnStyles.Clear();

            for (int i = 0; i < itemProducts.Count; i++)
            {
                tableLayoutPanel.Controls.Add(itemProducts[i], c, r);
                itemProducts[i].PicOrder.Click += new EventHandler(UserControl_Click);

                c++;
                if (c > 3)
                {
                    c = 1;
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

                if(ItemProductControl.LableItemsStatic == 0)
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

        private List<RowDataViewItemControl> rowDataViewItemControls()
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
            
        }

        private bool FindProductByIdList(RowDataViewItemControl rowData)
        {
            var items = rowDataViewItemControls();
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
            var items = rowDataViewItemControls();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ItemDetails.Qty == 0)
                {
                    panelDataView.Controls.Remove(items[i]);
                }
            }
        }
        
        private void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            new FormAlertNotification().ShowAlert(msg, type);
        }
    }
}
