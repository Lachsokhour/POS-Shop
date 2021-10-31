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
        private string filename = "";
        public CategoryForm()
        {
            InitializeComponent();
            //initUploadForm();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Open Image File";
                dialog.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = new Bitmap(dialog.FileName);
                    filename = System.IO.Path.GetFileName(dialog.FileName);
                    labelFilename.Text = filename;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picImage.Image = null;
            labelFilename.Text = "...";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.filename);
            var formAlert = new FormAlertNotification();
            formAlert.ShowAlert("Data not found.", FormAlertNotification.Type.Warning);
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void initUploadForm()
        {
            var childForm = new UploadImageForm(); 
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelUploadImage.Controls.Add(childForm);
            panelUploadImage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
