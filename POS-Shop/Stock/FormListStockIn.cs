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
            ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
            if (form != null)
                form.openChildFormInPanel(new FormStockIn(false, null));
        }

        private void LoadValue()
        {
            List<StockIn> stockIns = new StockIn().readAll();
            source = new BindingSource(stockIns, null);
            gridStockIn.DataSource = source;
            source.ResetBindings(false);
            gridStockIn.AllowUserToAddRows = false;
            gridStockIn.RowTemplate.Height = 100;
            gridStockIn.Columns["Id"].Visible = false;
            gridStockIn.Columns["ProductId"].Visible = false;
            gridStockIn.Columns["DateIn"].DefaultCellStyle.Format = FormatUtils.dateTime;
            gridStockIn.Columns["DateIn"].DefaultCellStyle.Format = FormatUtils.dateTime;
            gridStockIn.Columns["PriceIn"].DefaultCellStyle.Format = FormatUtils.dollar;
        }

        private void FormListStockIn_Load(object sender, EventArgs e)
        {
            LoadValue();
        }
    }
}
