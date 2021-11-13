using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    class OrderDetails
    {
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public double UnitPrice { get; set; }
        public double Amount { get => Qty * UnitPrice; }

        public OrderDetails() { }

        public OrderDetails(string barcode, string productName, int qty, double unitPrice)
        {
            Barcode = barcode;
            ProductName = productName;
            Qty = qty;
            UnitPrice = unitPrice;
        }
    }
}
