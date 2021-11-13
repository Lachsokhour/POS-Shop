using POS_Shop.Models;
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
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadDicount();
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
    }
}
