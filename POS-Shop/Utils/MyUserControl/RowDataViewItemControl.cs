﻿using System;
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
            Qty = 0;
            labelQty.Text = Qty.ToString();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            Qty++;
            labelQty.Text = Qty.ToString();
        }

        private void picRemove_Click(object sender, EventArgs e)
        {
            
            if(Qty != 0)
            {
                Qty--;
                labelQty.Text = Qty.ToString();
            }
        }
    }
}
