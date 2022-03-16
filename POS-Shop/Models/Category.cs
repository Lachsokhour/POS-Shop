using POS_Shop.DB;
using POS_Shop.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Models
{
    class Category : AbstractCrud<Category>
    {
        private int id;
        private string photo;
        private string filePath;
        private string name;
        private string note;
        private Image cateImage;

        public Category() { }
        public Category(int id, string photo, string filePath, string name, string note)
        {
            this.id = id;
            this.photo = photo;
            this.filePath = filePath;
            this.name = name;
            this.note = note;
        }

        public Category(int id, string photo, string filePath, string name, string note, Image cateImage, DateTime createdAt)
        {
            this.id = id;
            this.photo = photo;
            this.filePath = filePath;
            this.name = name;
            this.note = note;
            this.cateImage = cateImage;
            CreatedAt = createdAt;
        }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Photo { get => photo; set => photo = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public string Name { get => name; set => name = value; }
        public string Note { get => note; set => note = value; }
        public Image CateImage { get => cateImage; set => cateImage = value; }

        public override bool create()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(CategoryConstants.CreateCategoryStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Name, name);
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Photo, photo);
                sqlCmd.Parameters.AddWithValue(CategoryConstants.FilePath, filePath);
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Note, note);
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
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Name, name);
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Photo, photo);
                sqlCmd.Parameters.AddWithValue(CategoryConstants.FilePath, filePath);
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Note, note);
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
                SqlCommand sqlCmd = new SqlCommand(CategoryConstants.DeleteCategoryStoreProcedure, conn);
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

        public override List<Category> readAll()
        {
            try
            {
                List<Category> category = new List<Category>();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(CategoryConstants.SelectAllCategoryStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    cateImage = new FileStorageUtils().LoadImage(reader["file_path"].ToString());
                    category.Add(
                        new Category(
                            int.Parse(reader["id"].ToString()),
                            reader["photo"].ToString(),
                            reader["file_path"].ToString(),
                            reader["name"].ToString(),
                            reader["note"].ToString(),
                            cateImage,
                            DateTime.Parse(reader["created_at"].ToString())
                            )
                        );
                }
                reader.Close();
                conn.Close();
                return category;
            }
            catch (Exception ex)
            {
                //ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                MessageBox.Show(ex.Message);
                return new List<Category>();
            }
        }

        public List<Category> GetCategories()
        {
            try
            {
                List<Category> categories = new List<Category>();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(CategoryConstants.SelectAllCategoryStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(
                        new Category(
                            int.Parse(reader["id"].ToString()),
                            reader["name"].ToString()
                            )
                        );
                }
                reader.Close();
                conn.Close();
                return categories;
            }
            catch (Exception ex)
            {
                //ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                MessageBox.Show(ex.Message);
                return new List<Category>();
            }
        }

        public bool ValidateCategoryName(string name)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(CategoryConstants.ValidateCategoryNameStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Name, name);
                sqlCmd.Parameters.AddWithValue(CategoryConstants.Id, id);
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
    }
}
