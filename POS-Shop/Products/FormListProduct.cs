﻿using POS_Shop.Models;
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

namespace POS_Shop.Products
{
    public partial class FormListProduct : Form
    {
        private BindingSource source;
        public FormListProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
            if (form != null)
                form.openChildFormInPanel(new AddNewProduct(true, null));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
            if (form != null)
                form.openChildFormInPanel(new AddNewProduct(false, source));
        }

        private void LoadProduct()
        {
            List<Product> products = new Product().readAll();
            source = new BindingSource(products, null);
            gridProduct.DataSource = source;
            source.ResetBindings(false);
            gridProduct.AllowUserToAddRows = false;
            gridProduct.RowTemplate.Height = 100;
            gridProduct.Columns["Id"].Visible = false;
            gridProduct.Columns["Filename"].Visible = false;
            gridProduct.Columns["FilePath"].Visible = false;
            gridProduct.Columns["CategoryId"].Visible = false;
            gridProduct.Columns["ProImage"].DisplayIndex = 0;
            gridProduct.Columns["Barcode"].DisplayIndex = 1;
            gridProduct.Columns["NameEn"].HeaderText = "Name (En)";
            gridProduct.Columns["NameEn"].DisplayIndex = 2;
            gridProduct.Columns["NameKh"].HeaderText = "Name (Kh)";
            gridProduct.Columns["NameKh"].DisplayIndex = 3;
            gridProduct.Columns["NameKh"].DefaultCellStyle.Font = new Font("Kh Battambang", 10);
            gridProduct.Columns["PriceOut"].HeaderText = "Price out";
            gridProduct.Columns["PriceOut"].DisplayIndex = 4;
            gridProduct.Columns["PriceOut"].DefaultCellStyle.Format = FormatUtils.dollar;
            gridProduct.Columns["CateName"].HeaderText = "Category";
            gridProduct.Columns["CateName"].DisplayIndex = 5;
            gridProduct.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var prod = (Product)source.Current;
            var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var result = new Product().delete(prod.Id);
                if (result)
                {
                    LoadProduct();
                }
            }
        }

        private void FormListProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
