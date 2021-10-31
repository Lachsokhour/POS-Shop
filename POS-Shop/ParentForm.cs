using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Shop.Sales;
using POS_Shop.Employees;
using POS_Shop.Categories;
using POS_Shop.Products;
using POS_Shop.Reports;

namespace POS_Shop
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            openChildFormInPanel(new Dashboard());
        }

        public Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {               
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new SaleForm());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Dashboard());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormEmployee());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CategoryForm());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ListProduct());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReportForm());
        }
    }
}
