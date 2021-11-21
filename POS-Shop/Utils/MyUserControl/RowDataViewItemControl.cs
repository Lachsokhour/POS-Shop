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

namespace POS_Shop.Utils.MyUserControl
{
    public partial class RowDataViewItemControl : UserControl
    {
        public RowDataViewItemControl()
        {
            InitializeComponent();
        }

        public RowDataViewItemControl(OrderDetails orderDetails)
        {
            InitializeComponent();
            ItemDetails = orderDetails;
            LoadValue();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            Qty++;
            ItemDetails.Qty++;
            labelQty.Text = Qty.ToString();
            LoadValue();
        }

        private void LoadValue()
        {
            labelProductName.Text = ItemDetails.ProductName;
            labelQty.Text = ItemDetails.Qty.ToString();
            labelUnitPrice.Text = ItemDetails.UnitPrice.ToString(FormatUtils.dollar);
            labelTotalAmount.Text = ItemDetails.Amount.ToString(FormatUtils.dollar);
        }

        private void picRemove_Click(object sender, EventArgs e)
        {
            
            if(Qty != 0)
            {
                Qty--;
                ItemDetails.Qty--;
                labelQty.Text = Qty.ToString();
                LoadValue();
            }
        }
    }
}
