using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    class Position
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public Position() { }
        public Position(int value, string text)
        {
            this.Value = value;
            this.Text = text;
        }

        public List<Position> GetPositions()
        {
            return new List<Position>()
            {
                new Position(1, "Admin"),
                new Position(2, "Cashier")
            };
        }

        public override string ToString()
        {
            return $"Value: {Value}, Text: {Text}";
        }
    }
}
