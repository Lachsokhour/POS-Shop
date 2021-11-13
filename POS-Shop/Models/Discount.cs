using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    class Discount
    {
        public double Value { get; set; }
        public string Text { get; set; }

        public Discount()
        {

        }

        public Discount(double value, string text)
        {
            this.Value = value;
            this.Text = text;
        }

        public List<Discount> GetDiscounts()
        {
            return new List<Discount> {
                new Discount(0, "0%"),
                new Discount(0.5, "5%"),
                new Discount(1, "10%"),
                new Discount(1.5, "15%"),
                new Discount(2, "20%")
            };
        }


    }
}
