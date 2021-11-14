using POS_Shop.Models;
using POS_Shop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Stock
{
    public partial class FormListStockIn : Form
    {
        private BindingSource source;
        public FormListStockIn()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
            if (form != null)
                form.openChildFormInPanel(new FormStockIn(true, null));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(source.Count <= 0)
            {
                ShowAlert("No data for edit.", FormAlertNotification.Type.Warning);
            }
            else
            {
                ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
                if (form != null)
                    form.openChildFormInPanel(new FormStockIn(false, source));
            }
            
        }

        private void LoadValue()
        {
            List<StockIn> stockIns = new StockIn().readAll();
            source = new BindingSource(stockIns, null);
            gridStockIn.DataSource = source;
            source.ResetBindings(false);
            gridStockIn.AllowUserToAddRows = false;
            gridStockIn.RowTemplate.Height = 30;

            // Hidden Column
            gridStockIn.Columns["Id"].Visible = false;
            gridStockIn.Columns["ProductId"].Visible = false;
            gridStockIn.Columns["UpdatedAt"].Visible = false;
            gridStockIn.Columns["IsDefindDateExpired"].Visible = false;

            // Change format
            gridStockIn.Columns["DateIn"].DefaultCellStyle.Format = FormatUtils.dateTime;
            gridStockIn.Columns["DateExpired"].DefaultCellStyle.Format = FormatUtils.dateTime;
            gridStockIn.Columns["PriceIn"].DefaultCellStyle.Format = FormatUtils.dollar;
            gridStockIn.Columns["CreatedAt"].DefaultCellStyle.Format = FormatUtils.dateTime;

            // Change header column name
            gridStockIn.Columns["DateExpired"].HeaderText = "Date Expired";
            gridStockIn.Columns["DateIn"].HeaderText = "Date In";
            gridStockIn.Columns["ProductName"].HeaderText = "Product Name";
            gridStockIn.Columns["PriceIn"].HeaderText = "Price In";
            gridStockIn.Columns["CreatedAt"].HeaderText = "Created At";

            // Move index
            gridStockIn.Columns["ProductName"].DisplayIndex = 0;
            gridStockIn.Columns["PriceIn"].DisplayIndex = 1;
            gridStockIn.Columns["Qty"].DisplayIndex = 2;
            gridStockIn.Columns["Note"].DisplayIndex = gridStockIn.Columns.Count - 1;

            // Change width
            gridStockIn.Columns["Qty"].Width = 50;
            gridStockIn.Columns["PriceIn"].Width = 80;
            gridStockIn.Columns["DateIn"].Width = 135;
            gridStockIn.Columns["DateExpired"].Width = 135;
            gridStockIn.Columns["CreatedAt"].Width = 135;
        }

        private void FormListStockIn_Load(object sender, EventArgs e)
        {
            LoadValue();
            /*int count = new StockIn().readAll().Count;
            if (count <= 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(source.Count <= 0)
            {
                ShowAlert("No data for delete.", FormAlertNotification.Type.Warning);
            }
            else
            {
                var stockin = (StockIn)source.Current;
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (stockin.delete(stockin.Id))
                    {
                        LoadValue();
                    }
                }
            }
            
        }

        private void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            new FormAlertNotification().ShowAlert(msg, type);
        }
    }
}
