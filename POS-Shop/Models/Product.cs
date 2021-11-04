using POS_Shop.DB;
using POS_Shop.Utils;
using POS_Shop.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Models
{
    class Product : AbstractCrud<Product>
    {
        private int id;
        private string barcode;
        private float priceOut;
        private string nameEn;
        private string nameKh;
        private int categoryId;
        private string note;
        private string filename;
        private string filePath;
        private Image proImage;
        public Product() { }
        public Product(
            int id, 
            string barcode, 
            float priceOut, 
            string nameEn, 
            string nameKh, 
            string filename,
            string filePath,
            int cateId, 
            Image proImage,
            string note)
        {
            this.id = id;
            this.barcode = barcode;
            this.priceOut = priceOut;
            this.nameEn = nameEn;
            this.nameKh = nameKh;
            this.categoryId = cateId;
            this.note = note;
            this.filename = filename;
            this.filePath = filePath;
            this.proImage = proImage;
        }

        public int Id { get => id; set => id = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public float PriceOut { get => priceOut; set => priceOut = value; }
        public string NameEn { get => nameEn; set => nameEn = value; }
        public string NameKh { get => nameKh; set => nameKh = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string Note { get => note; set => note = value; }
        public string Filename { get => filename; set => filename = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public Image ProImage { get => proImage; set => proImage = value; }


        // <summary>
        /// Connect to DB server.
        /// </summary>
        private SqlConnection conn = Connection.getConnection();

        public override bool create()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ProductConstants.CreateProductStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(ProductConstants.Barcode, barcode);
                sqlCmd.Parameters.AddWithValue(ProductConstants.NameEn, nameEn);
                sqlCmd.Parameters.AddWithValue(ProductConstants.NameKh, nameKh);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Filename, filename);
                sqlCmd.Parameters.AddWithValue(ProductConstants.FilePath, filePath);
                sqlCmd.Parameters.AddWithValue(ProductConstants.CategoryId, categoryId);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Note, note);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                ShowAlert("Created successfully.", FormAlertNotification.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                this.ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                return false;
            }

        }

        public override bool update()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(CategoryConstants.UpdateCategoryStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Id, id);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Barcode, barcode);
                sqlCmd.Parameters.AddWithValue(ProductConstants.NameEn, nameEn);
                sqlCmd.Parameters.AddWithValue(ProductConstants.NameKh, nameKh);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Filename, filename);
                sqlCmd.Parameters.AddWithValue(ProductConstants.FilePath, filePath);
                sqlCmd.Parameters.AddWithValue(ProductConstants.CategoryId, categoryId);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Note, note);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                ShowAlert("Updated successfully.", FormAlertNotification.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                this.ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                return false;
            }
        }

        public override bool delete(int id)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ProductConstants.DeleteProductStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Id, id);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                ShowAlert("Deleted successfully.", FormAlertNotification.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                return false;
            }
        }

        public override List<Product> readAll()
        {
            try
            {
                List<Product> products = new List<Product>();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(CategoryConstants.SelectAllCategoryStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    /*cateImage = new FileStorageUtils().LoadImage(reader["file_path"].ToString());
                    category.Add(
                        new Category(
                            int.Parse(reader["id"].ToString()),
                            reader["photo"].ToString(),
                            reader["file_path"].ToString(),
                            reader["name"].ToString(),
                            reader["note"].ToString(),
                            cateImage
                            )
                        ); ;*/
                }
                reader.Close();
                conn.Close();
                return products;
            }
            catch (Exception ex)
            {
                //ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                MessageBox.Show(ex.Message);
                return new List<Product>();
            }
        }

        private void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            FormAlertNotification formAlert = new FormAlertNotification();
            formAlert.ShowAlert(msg, type);
        }
    }
}
