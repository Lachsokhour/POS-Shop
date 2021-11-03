using POS_Shop.Models;
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

namespace POS_Shop.Categories
{
    public partial class CategoryForm : SubForm
    {
        private int id = 0;
        private BindingSource source;
        private bool isAddMode = true;
        private Category currentCate;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SetValue() != null)
            {
                Category category = SetValue();
                if (category.create())
                {
                    this.ClearValue();
                    LoadCategoryValue();
                }
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategoryValue();
        }

        private Category SetValue()
        {
            if (txtName.Text == "")
            {
                this.ShowAlert("Please enter category name.", FormAlertNotification.Type.Warning);
                txtName.Focus();
                return null;
            }
            else
            {
                Category category = new Category();
                category.Name = txtName.Text.Trim();
                category.Note = txtNote.Text.Trim();
                category.Photo = uploadImageControl.FileName;
                category.FilePath = uploadImageControl.FilePath;
                return category;
            }
        }

        private void ClearValue()
        {
            this.id = 0;
            txtName.Text = "";
            txtNote.Text = "";
            uploadImageControl.FileName = "";
            uploadImageControl.FilePath = "";
            uploadImageControl.PicImage = null;
            isAddMode = true;
        }

        private void LoadCategoryValue()
        {
            var employees = new Category().readAll();
            source = new BindingSource(employees, null);
            gridCategory.DataSource = source;
            source.ResetBindings(false);
            gridCategory.AllowUserToAddRows = false;
            gridCategory.RowTemplate.Height = 80;
            gridCategory.Columns["Id"].Visible = false;
            gridCategory.Columns["FilePath"].Visible = false;
            gridCategory.Columns["Photo"].Visible = false;
            gridCategory.Columns["CateImage"].HeaderText = "Photo";
            gridCategory.Columns["CateImage"].DisplayIndex = 0;
            gridCategory.Refresh();
        }

        private void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            FormAlertNotification formAlert = new FormAlertNotification();
            formAlert.ShowAlert(msg, type);
        }

        private void SetLabelTitle()
        {
            labelTitle.Text = isAddMode ? "Add Category" : "Edit Category";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            isAddMode = true;
            SetLabelTitle();
            ClearValue();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAddMode = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cate = (Category)source.Current;
            this.id = cate.Id;
            var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var result = new Category().delete(id);
                if (result)
                {
                    LoadCategoryValue();
                }
            }
        }
    }
}
