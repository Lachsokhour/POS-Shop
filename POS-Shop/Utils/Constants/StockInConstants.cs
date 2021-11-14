using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils.Constants
{
    static class StockInConstants
    {
        public const string Id = "@Id";
        public const string ProductId = "@ProductId";
        public const string PriceIn = "@PriceIn";
        public const string DateIn = "@DateIn";
        public const string DateExpired = "@DateExpired";
        public const string Note = "@Note";
        public const string Qty = "@Qty";
        public const string IsDefindDateExpired = "@IsDefindDateExpired";

        public const string CreateUpdateStockInStoreProcedure = "CreateUpdateStockIn";
        public const string SelectStockInStoreProcedure = "SelectAllStockIn";
        public const string DeleteStockInByIdStoreProcedure = "DeleteStockInById";
    }
}
