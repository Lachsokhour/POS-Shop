using POS_Shop.DB;
using POS_Shop.Utils.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    class UserLogin
    {
        private string username;
        private string password;

        public UserLogin() { }
        public UserLogin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        private SqlConnection conn = SingletonDB.Instance.GetDBConnection();

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public bool Login()
        {
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand(EmployeeConstants.UserLoginStoreProcedure, conn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue(EmployeeConstants.Username, username);
            sqlCmd.Parameters.AddWithValue(EmployeeConstants.Password, password);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                
                /**
                 * TODO: later.

                /*username = reader["name_en"].ToString();
                password = reader["password"].ToString();*/
                return true;
            }

            reader.Close();
            conn.Close();
            return false;
        }
    }
}
