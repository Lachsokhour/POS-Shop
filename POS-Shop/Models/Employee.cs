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
    class Employee : AbstractCrud<Employee>
    {
        protected int id;
        protected string nameEn;
        protected string nameKh;
        protected string phone;
        protected string address;
        protected string password;
        protected int positionId;
        protected string position;

        //private SqlConnection conn = SingletonDB.Instance.GetDBConnection();

        public Employee() { }

        public Employee(int id, string nameEn, string nameKh, string phone, string address, string password, int positionId)
        {
            this.id = id;
            this.nameEn = nameEn;
            this.nameKh = nameKh;
            this.phone = phone;
            this.address = address;
            this.positionId = positionId;
            this.password = password;
        }
        public Employee(int id, string nameEn, string nameKh, string phone, string address, string position, string password, int positionId)
        {
            this.id = id;
            this.nameEn = nameEn;
            this.nameKh = nameKh;
            this.phone = phone;
            this.address = address;
            this.position = position;
            this.password = password;
            this.positionId = positionId;
        }

        public int Id { get => id; set => id = value; }
        public string NameEn { get => nameEn; set => nameEn = value; }
        public string NameKh { get => nameKh; set => nameKh = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Position
        {
            get
            {

                return position;
            }
            set
            {
                new Position().GetPositions().ForEach(action =>
                {
                    if (action.Value == int.Parse(value))
                    {
                        position = action.Text;
                    }
                });
            }
        }
        public string Address { get => address; set => address = value; }
        public string Password { get => password; set => password = value; }
        public int PositionId { get => positionId; set => positionId = value; }
        

        public override bool create()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(EmployeeConstants.CreateEmployeeStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.NameEn, nameEn);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.NameKh, nameKh);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Phone, phone);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Password, password);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Address, address);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.PositionId, positionId);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.CreatedBy, CreatedBy);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                ShowAlert("Created successfully.", FormAlertNotification.Type.Success);
                return true;
            }catch(Exception ex)
            {
                ShowAlert(ex.Message,FormAlertNotification.Type.Error);
                return false;
            }
        }

        public override List<Employee> readAll()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(EmployeeConstants.SelectAllEmployeeStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    this.Position = reader["position_id"].ToString();
                    employees.Add(
                        new Employee(
                            int.Parse(reader["id"].ToString()),
                            reader["name_en"].ToString(),
                            reader["name_kh"].ToString(),
                            reader["phone"].ToString(),
                            reader["address"].ToString(),
                            this.Position,
                            reader["password"].ToString(),
                            int.Parse(reader["position_id"].ToString())
                            )
                        ); ;
                }
                reader.Close();
                conn.Close();
                return employees;
            }catch(Exception ex)
            {
                ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                return new List<Employee>();
            }
        }

        public override bool update()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(EmployeeConstants.UpdateEmployeeStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Id, id);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.NameEn, nameEn);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.NameKh, nameKh);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Phone, phone);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Password, password);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Address, address);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.PositionId, positionId);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.CreatedBy, CreatedBy);
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                ShowAlert("Updated successfully.", FormAlertNotification.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                return false;
            }
        }

        public override bool delete(int id)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(EmployeeConstants.DeleteEmployeeStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Id, id);
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

        public bool ValidateEmployeeName(string nameEn)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(EmployeeConstants.ValidateEmployeeNameStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.NameEn, nameEn);
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.Id, id);
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

        public Employee getEmployeeByUsername(string username)
        {
            try
            {
                var employee = new Employee();
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(EmployeeConstants.GetEmployeeByUsernameStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(EmployeeConstants.NameEn, username);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    Position = reader["position_id"].ToString();

                    employee = new Employee(
                            int.Parse(reader["id"].ToString()),
                            reader["name_en"].ToString(),
                            reader["name_kh"].ToString(),
                            reader["phone"].ToString(),
                            reader["address"].ToString(),
                            Position,
                            reader["password"].ToString(),
                            int.Parse(reader["position_id"].ToString())
                            );
                }
                reader.Close();
                conn.Close();
                return employee;
            }
            catch (Exception ex)
            {
                ShowAlert(ex.Message, FormAlertNotification.Type.Error);
                return null;
            }
        }
    }
}
