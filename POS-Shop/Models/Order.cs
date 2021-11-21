using POS_Shop.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    class Order
    {
        private int id;
        private double discount;
        private double subTotal;

        string exchangeRiel = new Exchange().SelectFirstExchange().Riel;

        public Order() { }
        public Order(int id, double discount, double subTotal)
        {
            this.id = id;
            this.discount = discount;
            this.subTotal = subTotal;
        }

        public int Id { get => id; set => id = value; }
        public string Exchange { get => exchangeRiel; }
        public DateTime DateOrder { get => DateTime.Now; }
        public double Discount { get => discount; set => discount = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        public double Amount { get => subTotal - discount; }

    }
}
