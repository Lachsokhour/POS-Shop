using POS_Shop.DB;
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
    class Exchange : AbstractCrud<Exchange>
    {
        private int id;
        private float dollar;
        private string riel;

        public Exchange() { }
        public Exchange(int id, float dollar, string riel)
        {
            this.id = id;
            this.dollar = dollar;
            this.riel = riel;
        }

        public int Id { get => id; set => id = value; }
        public float Dollar { get => dollar; set => dollar = value; }
        public string Riel { get => riel; set => riel = value; }

        public string Info()
        {
            return $"Our currency for today is ${dollar:N2} = {riel} riel";
        }

        public override bool create()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ExchangeConstants.CreateUpdateExchangeStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(ExchangeConstants.Id, id);
                sqlCmd.Parameters.AddWithValue(ExchangeConstants.Dollar, dollar);
                sqlCmd.Parameters.AddWithValue(ExchangeConstants.Riel, riel);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                sqlCmd.Dispose();
                if(id == 0)
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

        public Exchange SelectFirstExchange()
        {
            try
            {
                Exchange exchange = new Exchange();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(ExchangeConstants.SelectFirstExchangeStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    exchange.Dollar = float.Parse(reader["dollar"].ToString());
                    exchange.Id = int.Parse(reader["id"].ToString());
                    exchange.Riel = reader["riel"].ToString();
                }
                reader.Close();
                conn.Close();
                sqlCmd.Dispose();
                return exchange;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public override bool update()
        {
            return base.update();
        }
    }
}
