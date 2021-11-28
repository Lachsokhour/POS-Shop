using POS_Shop.Models;
using POS_Shop.Products;
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
    public partial class Dashboard : Form
    {
        POSButton myBtn = new POSButton();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnStartSale_MouseHover(object sender, EventArgs e)
        {
            myBtn.onMouseHover(btnStartSale);
        }

        private void btnStartSale_MouseLeave(object sender, EventArgs e)
        {
            myBtn.onMouseLeave(btnStartSale);
        }

        private void btnDetailSale_MouseHover(object sender, EventArgs e)
        {
            myBtn.onMouseHover(btnDetailSale);
        }

        private void btnDetailSale_MouseLeave(object sender, EventArgs e)
        {
            myBtn.onMouseLeave(btnDetailSale);
        }

        private void btnStartSale_Click(object sender, EventArgs e)
        {
            ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
            if(form != null)
                form.openChildFormInPanel(new SaleForm());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelCountProduct.Text = new Product().CountAllProduct().ToString();
            labelCountSale.Text = new StockIn().CountCurrentSale().ToString();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
            if (form != null)
                form.openChildFormInPanel(new FormListProduct());
        }
    }
}
