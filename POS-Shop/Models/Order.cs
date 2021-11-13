using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    class Order
    {
        private int id;
        private string exchange;
        private DateTime dateOrder;
        private float discount;
        private double subTotal;

        public Order() { }
        public Order(int id, string exchange, DateTime dateOrder, float discount, double subTotal)
        {
            this.id = id;
            this.exchange = exchange;
            this.dateOrder = dateOrder;
            this.discount = discount;
            this.subTotal = subTotal;
        }

        public int Id { get => id; set => id = value; }
        public string Exchange { get => exchange; set => exchange = value; }
        public DateTime DateOrder { get => dateOrder; set => dateOrder = value; }
        public float Discount { get => discount; set => discount = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        public double Amount { get => subTotal - subTotal * discount; }

    }
}
