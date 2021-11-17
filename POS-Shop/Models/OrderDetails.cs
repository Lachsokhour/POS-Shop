using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    public class OrderDetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public double UnitPrice { get; set; }
        public double Amount { get => Qty * UnitPrice; }

        public OrderDetails() { }

        public OrderDetails(int prodId, string productName, int qty, double unitPrice)
        {
            ProductId = prodId;
            ProductName = productName;
            Qty = qty;
            UnitPrice = unitPrice;
        }
    }
}
