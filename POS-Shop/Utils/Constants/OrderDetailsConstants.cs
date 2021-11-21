using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils.Constants
{
    static class OrderDetailsConstants
    {
        public const string ProductId = "@ProductId";
        public const string OrderId = "OrderId";
        public const string Qty = "@Qty";
        public const string Amount = "@Amount";
        public const string UnitPrice = "@UnitPrice";

        public const string CreateOrderDetailsStoreProcedure = "CreateOrderDetails";

    }
}
