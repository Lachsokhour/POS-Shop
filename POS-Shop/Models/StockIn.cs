using POS_Shop.Utils;
using POS_Shop.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Models
{
    class StockIn : AbstractCrud<StockIn>
    {
        private int id;
        private int productId;
        private float priceIn;
        private DateTime dateIn;
        private DateTime? dateExpired;
        private string note;
        private int qty;
        private string productName;
        private bool isDefindDateExpired;

        public StockIn() { }
        public StockIn(
            int id,
            int proId,
            float priceIn,
            DateTime dateIn,
            DateTime? dateExpired,
            string note,
            int qty, string proName, 
            DateTime createdAt,
            bool isDefindDateExpired)
        {
            this.id = id;
            this.productId = proId;
            this.priceIn = priceIn;
            this.dateExpired = dateExpired;
            this.dateIn = dateIn;
            this.qty = qty;
            this.productName = proName;
            this.note = note;
            base.CreatedAt = createdAt;
            this.isDefindDateExpired = isDefindDateExpired;
        }

        public int Id { get => id; set => id = value; }
        public float PriceIn { get => priceIn; set => priceIn = value; }
        public int ProductId { get => productId; set => productId = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public DateTime? DateExpired { get => dateExpired; set => dateExpired = value; }
        public string Note { get => note; set => note = value; }
        public int Qty { get => qty; set => qty = value; }
        public string ProductName { get => productName; set => productName = value; }

        public bool IsDefindDateExpired { get => isDefindDateExpired; set => isDefindDateExpired = value; }

        public override bool create()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(StockInConstants.CreateUpdateStockInStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(StockInConstants.Id, id);
                sqlCmd.Parameters.AddWithValue(StockInConstants.PriceIn, priceIn);
                sqlCmd.Parameters.AddWithValue(StockInConstants.DateIn, dateIn);
                sqlCmd.Parameters.AddWithValue(StockInConstants.DateExpired, dateExpired);
                sqlCmd.Parameters.AddWithValue(StockInConstants.Qty, qty);
                sqlCmd.Parameters.AddWithValue(StockInConstants.Note, note);
                sqlCmd.Parameters.AddWithValue(StockInConstants.ProductId, productId);
                sqlCmd.Parameters.AddWithValue(StockInConstants.IsDefindDateExpired, isDefindDateExpired);
                sqlCmd.Parameters.AddWithValue(StockInConstants.CreatedBy, CreatedBy);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                if (id == 0)
                {
                    ShowAlert("Created successfully.", FormAlertNotification.Type.Success);
                }
                else
                {
                    ShowAlert("Updated successfully.", FormAlertNotification.Type.Success);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public override List<StockIn> readAll()
        {
            try
            {
                List<StockIn> stockIns = new List<StockIn>();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(StockInConstants.SelectStockInStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    if(string.IsNullOrEmpty(reader["date_expired"].ToString()))
                    {
                        dateExpired = null;
                    }
                    else
                    {
                        dateExpired = DateTime.Parse(reader["date_expired"].ToString());
                    }
                    stockIns.Add(
                        new StockIn(
                            int.Parse(reader["id"].ToString()),
                            int.Parse(reader["pro_id"].ToString()),
                            float.Parse(reader["price_in"].ToString()),
                            DateTime.Parse(reader["date_in"].ToString()),
                             dateExpired,
                            reader["note"].ToString(),
                            int.Parse(reader["qty"].ToString()),
                            reader["pro_name_en"].ToString(),
                            DateTime.Parse(reader["created_at"].ToString()),
                            (bool)reader["is_defind_date_expired"]
                            )
                        );
                }
                reader.Close();
                sqlCmd.Dispose();
                conn.Close();
                return stockIns;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<StockIn>();
            }
        }

        public override bool delete(int id)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(StockInConstants.DeleteStockInByIdStoreProcedure, conn);
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


    }
}
