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
        private Product currentPro = new Product();
        public AddNewProduct()
        {
            InitializeComponent();
        }

        public AddNewProduct(bool isAddMode, BindingSource source)
        {
            InitializeComponent();
            this.isAddMode = isAddMode;
            
            SetLabelTitle();
            if (source != null)
            {
                currentPro = (Product)source.Current;
                SetValueToFieldWhenEditMode();
            }
        }

        public void ClearValue()
        {
            id = 0;
            txtNameEn.Text = "";
            txtNameKh.Text = "";
            txtNote.Text = "";
            txtBarcode.Text = "";
            txtPriceOut.Text = "";
            uploadImageControl.FileName = "";
            uploadImageControl.FilePath = "";
            uploadImageControl.PicImage = null;
            uploadImageControl.IsAddMode = true;
            comboBoxCategory.SelectedIndex = 0;
            isAddMode = true;
            SetLabelTitle();
        }

        public void LoadValue()
        {
            throw new NotImplementedException();
        }

        public void SetLabelTitle()
        {
            groupBoxProduct.Text = isAddMode ? "Add Product" : "Edit Product";
        }

        private Product SetValue()
        {
            if (txtNameEn.Text == "")
            {
                ShowAlert("Please enter product name.", FormAlertNotification.Type.Warning);
                txtNameEn.Focus();
                return null;
            }
            else if (txtBarcode.Text == "")
            {
                ShowAlert("Please enter barcode.", FormAlertNotification.Type.Warning);
                txtBarcode.Focus();
                return null;
            }
            else if (txtPriceOut.Text == "")
            {
                ShowAlert("Please enter price out.", FormAlertNotification.Type.Warning);
                txtPriceOut.Focus();
                return null;
            }else if(currentPro.ValidateBarcodeProduct(txtBarcode.Text))
            {
                ShowAlert("Barcode's already exist.", FormAlertNotification.Type.Warning);
                txtBarcode.Focus();
                return null;
            }
            else
            {
                Category category = (Category)comboBoxCategory.SelectedItem;
                var product = new Product();
                product.NameEn = txtNameEn.Text.Trim();
                product.NameKh = txtNameKh.Text.Trim();
                product.PriceOut = float.Parse(txtPriceOut.Text.Trim());
                product.Note = txtNote.Text.Trim();
                product.Barcode = txtBarcode.Text.Trim();
                product.Filename = uploadImageControl.FileName;
                product.FilePath = uploadImageControl.FilePath;
                product.CategoryId = category.Id;
                product.Id = id;
                return product;
            }
        }

        public void SetValueToFieldWhenEditMode()
        {
            if(!isAddMode)
            {
                uploadImageControl.IsAddMode = false;
                txtBarcode.Text = currentPro.Barcode;
                txtNameEn.Text = currentPro.NameEn;
                txtNameKh.Text = currentPro.NameKh;
                txtPriceOut.Text = currentPro.PriceOut.ToString();
                txtNote.Text = currentPro.Note;
                id = currentPro.Id;
                comboBoxCategory.SelectedValue = currentPro.CategoryId;
                uploadImageControl.FileName = currentPro.Filename;
                uploadImageControl.FilePath = currentPro.FilePath;
                uploadImageControl.PicImage = currentPro.ProImage;
            }
        }

        public void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            var formAlert = new FormAlertNotification();
            formAlert.ShowAlert(msg, type);
        }

        private void LoadCategory()
        {
            comboBoxCategory.DataSource = new Category().GetCategories();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }

        /// <summary>
        /// On click button save.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = SetValue();
            if (product != null)
            {
                if (isAddMode)
                {
                    if (product.create())
                    {
                        ClearValue();
                    }
                }else
                {
                    if(product.update())
                    {
                        BackToList();
                    }
                }
            }
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValue();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToList();
        }

        private void BackToList()
        {
            ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
            if (form != null)
                form.openChildFormInPanel(new FormListProduct());
        }
    }
}
