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
    public partial class CategoryForm : Form
    {
        private BindingSource source;
        private bool isAddMode = true;
        private Category currentCate = new Category();
        public CategoryForm()
        {
            InitializeComponent();
            SetLabelTitle();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SetValue() != null)
            {
                Category category = SetValue();
                if (isAddMode)
                {
                    if (category.create())
                    {
                        this.ClearValue();
                        LoadCategoryValue();
                    }
                }
                else
                {
                    if (category.update())
                    {
                        ClearValue();
                        LoadCategoryValue();
                    }
                }
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategoryValue();
        }

        private Category SetValue()
        {
            try
            {
                if (txtName.Text == "")
                {
                    this.ShowAlert("Please enter category name.", FormAlertNotification.Type.Warning);
                    txtName.Focus();
                    return null;
                }
                else if (currentCate.ValidateCategoryName(txtName.Text))
                {
                    this.ShowAlert("This category already exist.", FormAlertNotification.Type.Warning);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void SetValueToFieldWhenEditMode()
        {
            if (!isAddMode)
            {
                currentCate = (Category)source.Current;
                txtName.Text = currentCate.Name;
                txtNote.Text = currentCate.Note;
                uploadImageControl.FileName = currentCate.Photo;
                uploadImageControl.FilePath = currentCate.FilePath;
                uploadImageControl.PicImage = currentCate.CateImage;
            }
        }

        private void ClearValue()
        {
            txtName.Text = "";
            txtNote.Text = "";
            uploadImageControl.FileName = "";
            uploadImageControl.FilePath = "";
            uploadImageControl.PicImage = null;
            isAddMode = true;
            uploadImageControl.IsAddMode = true;
            SetLabelTitle();
        }

        private void LoadCategoryValue()
        {
            var employees = new Category().readAll();
            source = new BindingSource(employees, null);
            gridCategory.DataSource = source;
            source.ResetBindings(false);
            gridCategory.AllowUserToAddRows = false;
            gridCategory.RowTemplate.Height = 80;

            // hidden columns
            gridCategory.Columns["Id"].Visible = false;
            gridCategory.Columns["FilePath"].Visible = false;
            gridCategory.Columns["Photo"].Visible = false;
            gridCategory.Columns["UpdatedAt"].Visible = false;

            // change header
            gridCategory.Columns["CateImage"].HeaderText = "Photo";
            gridCategory.Columns["CreatedAt"].HeaderText = "Created At";

            // change size
            gridCategory.Columns["CreatedAt"].Width = 100;
            gridCategory.Columns["CateImage"].Width = 80;
            gridCategory.Columns["Name"].Width = 100;
            gridCategory.Columns["Note"].Width = 150;

            // change format
            gridCategory.Columns["CreatedAt"].DefaultCellStyle.Format = FormatUtils.DateTimeWithoutHour;

            // move index
            gridCategory.Columns["CateImage"].DisplayIndex = 0;
            gridCategory.Columns["Note"].DisplayIndex = gridCategory.Columns.Count - 1;

            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)gridCategory.Columns["CateImage"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

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
            uploadImageControl.IsAddMode = true;
            SetLabelTitle();
            ClearValue();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAddMode = false;
            uploadImageControl.IsAddMode = false;
            SetLabelTitle();
            SetValueToFieldWhenEditMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cate = (Category)source.Current;
            var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (new Category().delete(cate.Id))
                {
                    //new FileStorageUtils().RemoveFile(cate.Photo);
                    LoadCategoryValue();
                }
            }
        }
    }
}
