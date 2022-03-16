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
    class Sale : AbstractCrud<Sale>
    {
        public Order Order { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }


        public Sale() { }
        public Sale(Order order, List<OrderDetails> orderDetails)
        {
            Order = order;
            OrderDetails = orderDetails;
        }

        public override bool create()
        {
            try
            {
                var orderId = createOrder();
                foreach (var details in OrderDetails)
                {
                    createOrderDetails(details, orderId);
                }
                ShowAlert("Order Successfully.", FormAlertNotification.Type.Success);
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int createOrder()
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(OrderConstants.CreateOrderStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(OrderConstants.Amount, Order.Amount);
                sqlCmd.Parameters.AddWithValue(OrderConstants.Discount, Order.Discount);
                sqlCmd.Parameters.AddWithValue(OrderConstants.Exchange, Order.Exchange);
                sqlCmd.Parameters.AddWithValue(OrderConstants.CreatedBy, CreatedBy);
                var result =  (int)sqlCmd.ExecuteScalar();
                conn.Close();
                sqlCmd.Dispose();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public void createOrderDetails(OrderDetails orderDetails, int orderId)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand(OrderDetailsConstants.CreateOrderDetailsStoreProcedure, conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue(OrderDetailsConstants.OrderId, orderId);
                sqlCmd.Parameters.AddWithValue(OrderDetailsConstants.ProductId, orderDetails.ProductId);
                sqlCmd.Parameters.AddWithValue(OrderDetailsConstants.Qty, orderDetails.Qty);
                sqlCmd.Parameters.AddWithValue(OrderDetailsConstants.UnitPrice, orderDetails.UnitPrice);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
