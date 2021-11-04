using POS_Shop.Models;
using POS_Shop.Utils;
using POS_Shop.Utils.Interface;
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
    public partial class AddNewProduct : Form, IBehaviorForm
    {
        private int id = 0;
        private bool isAddMode = true;
        public AddNewProduct()
        {
            InitializeComponent();
        }

        public AddNewProduct(bool isAddMode, BindingSource source)
        {
            InitializeComponent();
            this.isAddMode = isAddMode;
            SetLabelTitle();
            /*if(source == null)
            {
                this.Close();
            }*/
        }

        public void ClearValue()
        {
            id = 0;
            txtNameEn.Text = "";
            txtNameKh.Text = "";
            txtNote.Text = "";
            txtPriceOut.Text = "";
            uploadImageControl.FileName = "";
            uploadImageControl.FilePath = "";
            uploadImageControl.PicImage = null;
            isAddMode = true;
            uploadImageControl.IsAddMode = true;
            SetLabelTitle();
        }

        public void LoadValue()
        {
            throw new NotImplementedException();
        }

        public void SetLabelTitle()
        {
            labelTitle.Text = isAddMode ? "Add Product" : "Edit Product";
        }

        private Product SetValue()
        {
            return null;
        }

        public void SetValueToFieldWhenEditMode()
        {
            throw new NotImplementedException();
        }

        public void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

       
    }
}
