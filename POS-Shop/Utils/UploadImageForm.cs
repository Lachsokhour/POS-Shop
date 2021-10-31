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

namespace POS_Shop
{
    public partial class UploadImageForm : Form
    {
        private string filename = "";
        public UploadImageForm()
        {
            InitializeComponent();
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
    }
}
