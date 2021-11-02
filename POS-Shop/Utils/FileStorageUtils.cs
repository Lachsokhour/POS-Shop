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



        // convert image to byte array
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        //Byte array to photo
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

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
                ShowAlert(ioExp.Message,FormAlertNotification.Type.Error);
                return false;
            }
        }

        public void RemoveFile()
        {
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(dir, fileName)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(dir, fileName));
                    ShowAlert("File deleted.", FormAlertNotification.Type.Success);
                }
                else
                {
                    this.ShowAlert("File not found.", FormAlertNotification.Type.Warning);
                }
            }
            catch (IOException ioExp)
            {
                ShowAlert(ioExp.Message, FormAlertNotification.Type.Error);
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
