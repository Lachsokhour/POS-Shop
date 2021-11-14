using POS_Shop.Models;
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
        private ItemProductControl itemProduct = new ItemProductControl();
        private ItemProductControl[] itemProducts =
        {
           new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),
           new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),
           new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),
           new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),
           new ItemProductControl(),new ItemProductControl(),new ItemProductControl(),new ItemProductControl()
        };
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadDicount();
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

        int c = 1, r = 0;

        private void LoadProducts()
        {
            foreach (var item in itemProducts)
            {
                tableLayoutPanel.Controls.Add(item, c, r);
                c++;
                if (c > 3)
                {
                    c = 1;
                    r++;
                }
            }

        }

        private Exchange LoadValue()
        {
            return new Exchange().SelectFirstExchange();
        }
    }
}
