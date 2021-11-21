using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils.Constants
{
    static class OrderConstants
    {
        public const string Id = "@Id";
        public const string Discount = "@Discount";
        public const string Exchange = "@Exchange";
        public const string SubTotal = "@SubTotal";
        public const string Amount = "@Amount";
        public const string CreatedBy = "@CreatedBy";

        public const string CreateOrderStoreProcedure = "CreateOrder";
    }
}
