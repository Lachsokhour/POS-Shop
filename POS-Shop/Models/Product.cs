using POS_Shop.DB;
using POS_Shop.Utils;
using POS_Shop.Utils.Constants;
using POS_Shop.Utils.MyUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private string cateName;
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
            string cateName,
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
            this.cateName = cateName;
        }

        public int Id { get => id; set => id = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        [Display(Name = "Price Out")]
        public float PriceOut { get => priceOut; set => priceOut = value; }
        public string NameEn { get => nameEn; set => nameEn = value; }
        public string NameKh { get => nameKh; set => nameKh = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string Note { get => note; set => note = value; }
        public string Filename { get => filename; set => filename = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public Image ProImage { get => proImage; set => proImage = value; }
        public string CateName { get => cateName; set => cateName = value; }

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
                sqlCmd.Parameters.AddWithValue(ProductConstants.PriceOut, priceOut);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                conn.Close();
                ShowAlert("Created successfully.", FormAlertNotification.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public override bool update()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ProductConstants.UpdateProductStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(ProductConstants.Id, id);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Barcode, barcode);
                sqlCmd.Parameters.AddWithValue(ProductConstants.NameEn, nameEn);
                sqlCmd.Parameters.AddWithValue(ProductConstants.NameKh, nameKh);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Filename, filename);
                sqlCmd.Parameters.AddWithValue(ProductConstants.FilePath, filePath);
                sqlCmd.Parameters.AddWithValue(ProductConstants.CategoryId, categoryId);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Note, note);
                sqlCmd.Parameters.AddWithValue(ProductConstants.PriceOut, priceOut);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                conn.Close();
                ShowAlert("Updated successfully.", FormAlertNotification.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                sqlCmd.Dispose();
                conn.Close();
                ShowAlert("Deleted successfully.", FormAlertNotification.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public override List<Product> readAll()
        {
            try
            {
                List<Product> products = new List<Product>();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ProductConstants.SelectAllProductStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    proImage = new FileStorageUtils().LoadImage(reader["file_path"].ToString());
                    products.Add(
                        new Product(
                            int.Parse(reader["id"].ToString()),
                            reader["barcode"].ToString(),
                            float.Parse(reader["price_out"].ToString()),
                            reader["name_en"].ToString(),
                            reader["name_kh"].ToString(),
                            reader["filename"].ToString(),
                            reader["file_path"].ToString(),
                            int.Parse(reader["cate_id"].ToString()),
                            reader["cate_name"].ToString(),
                            proImage,
                            reader["note"].ToString()
                            )
                        );
                }
                reader.Close();
                sqlCmd.Dispose();
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

        public int CountAllProduct()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ProductConstants.CountAllProductStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                int count = (Int32)sqlCmd.ExecuteScalar();
                sqlCmd.Dispose();
                conn.Close();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public bool ValidateBarcodeProduct(string barcode)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ProductConstants.ValidateBarcodeProductStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(ProductConstants.Barcode, barcode);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Id, id);
                int count = (Int32)sqlCmd.ExecuteScalar();
                sqlCmd.Dispose();
                conn.Close();
                return count > 0 ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<ItemProductControl> readAllByCategoryId(int categoryId, string filter)
        {
            try
            {
                List<ItemProductControl> itemProducts = new List<ItemProductControl>();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ProductConstants.SelectAllProductsByCategoryIdAndFilterStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(ProductConstants.CategoryId, categoryId);
                sqlCmd.Parameters.AddWithValue(ProductConstants.Filter, filter);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    proImage = new FileStorageUtils().LoadImage(reader["file_path"].ToString());
                    var proName = string.IsNullOrEmpty(reader["name_en"].ToString()) ? reader["name_kh"].ToString() : reader["name_en"].ToString();
                    var itemProduct = new ItemProductControl();
                    itemProduct.ProImage = proImage;
                    itemProduct.LabelBarcode = reader["barcode"].ToString();
                    itemProduct.LabelProductName = proName;
                    itemProduct.ProductId = int.Parse(reader["cate_id"].ToString());
                    itemProduct.LabelPrice = reader["price_out"].ToString();
                    itemProducts.Add(itemProduct);
                }
                reader.Close();
                sqlCmd.Dispose();
                conn.Close();
                return itemProducts;
            }
            catch (Exception ex)
            {
                //ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                MessageBox.Show(ex.Message);
                return new List<ItemProductControl>();
            }
        }
    }
}
