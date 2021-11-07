using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils.Constants
{
    static class ExchangeConstants
    {
        public const string Id = "@Id";
        public const string Dollar = "@Dollar";
        public const string Riel = "@Riel";

        public const string CreateUpdateExchangeStoreProcedure = "CreateUpdateExchange";
        public const string SelectFirstExchangeStoreProcedure = "SelectFirstExchange";
    }
}
