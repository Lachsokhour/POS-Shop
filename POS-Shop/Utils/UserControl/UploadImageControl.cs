using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Utils
{
    public partial class UploadImageControl : UserControl
    {
        FileStorageUtils fileStorage = new FileStorageUtils();

        public UploadImageControl()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Open Image File";
                dialog.Filter = FormatUtils.FileFilter;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = new Bitmap(dialog.FileName);
                    
                    fileStorage.UploadImage(dialog);
                    FilePath = fileStorage.FilePath;
                    FileName = fileStorage.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(fileStorage.RemoveFile(FileName))
            {
                picImage.Image = null;
                FileName = "";
            }
            
        }
    }
}
