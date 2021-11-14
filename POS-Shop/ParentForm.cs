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
using POS_Shop.Settings;
using POS_Shop.Stock;

namespace POS_Shop
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            ManangePermission();
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
            openChildFormInPanel(new FormListProduct());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReportForm());
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ExchangeForm());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormListStockIn());
        }

        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            labelCurrentDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss");
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            timerCurrent.Start();
            labelUsername.Text = Properties.Settings.Default.username;
        }

        // manange permission of users.
        private void ManangePermission()
        {
            btnCustomer.Visible = false;
            btnReport.Visible = false;
            
            // for addmins
            if (Properties.Settings.Default.position.ToLower().Equals("admin"))
            {
                openChildFormInPanel(new Dashboard());
            }
            else
            {
                // for cashiers.
                openChildFormInPanel(new SaleForm());
                btnEmployee.Visible = false;
                btnDashboard.Visible = false;
                btnExchange.Visible = false;
                btnProduct.Visible = false;
                btnStock.Visible = false;
                btnCategory.Visible = false;
            }
        }
    }
}
