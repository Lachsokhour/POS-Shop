using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Utils
{
    class FileStorageUtils
    {
        private string fileName;
        private string filePath;
        private string dir = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\Images\\";

        public FileStorageUtils() { }
        public FileStorageUtils(string fileName, string filePath) {
            this.fileName = fileName;
            this.filePath = filePath;
        }

        public string FileName { get => fileName; set => fileName = value; }
        public string FilePath { get => filePath; set => filePath = value; }

        public void UploadImage(OpenFileDialog fileOpen)
        {
           try
            {
                
                if (fileOpen.CheckFileExists)
                {
                    fileName = this.getUniqueFilename(Path.GetFileName(fileOpen.FileName));
                    filePath = $"{dir}{fileName}";
                    File.Copy(fileOpen.FileName, dir + fileName);
                    ShowAlert("Uploaded successfully.", FormAlertNotification.Type.Success);
                }
            }catch(Exception ex)
            {
                this.ShowAlert(ex.Message, FormAlertNotification.Type.Error);
            }
        }

        public bool RemoveFile(string filename)
        {
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(dir, filename)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(dir, filename));
                    this.ShowAlert("File deleted.", FormAlertNotification.Type.Success);
                    return true;
                }
                else
                {
                    this.ShowAlert("File not found.", FormAlertNotification.Type.Warning);
                    return true;
                }
            }
            catch (IOException ioExp)
            {
                //ShowAlert(ioExp.Message,FormAlertNotification.Type.Error);
                MessageBox.Show(ioExp.Message);
                return false;
            }
        }

        public bool RemoveFile()
        {
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(dir, fileName)))
                {
                    // If file found, delete it
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(Path.Combine(dir, fileName));
                    ShowAlert("File deleted.", FormAlertNotification.Type.Success);
                    return true;
                }
                else
                {
                    this.ShowAlert("File not found.", FormAlertNotification.Type.Warning);
                    return true;
                }
            }
            catch (IOException ioExp)
            {
                ShowAlert(ioExp.Message, FormAlertNotification.Type.Error);
                return false;
            }
        }

        public Image LoadImage(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return Image.FromFile(filePath);
                }
                else
                {
                    ShowAlert("File not exist", FormAlertNotification.Type.Warning);
                    return null;
                }
            }
            catch(Exception ex)
            {
                ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                return null;
            }
        }

        private void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            FormAlertNotification formAlert = new FormAlertNotification();
            formAlert.ShowAlert(msg, type);
        }

        private string getUniqueFilename(string filename)
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_" + filename;
        }
    }
}
