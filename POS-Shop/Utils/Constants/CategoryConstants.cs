using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils
{
    static class ConstantsCategory
    {
        public const string Id = "@Id";
        public const string Name = "@Name";
        public const string Photo = "@Photo";
        public const string Note = "@Note";

        public static string CreateCategoryStoreProcedure = "CreateCategory";
        public static string SelectAllCategoryStoreProcedure = "SelectAllCategory";
    }
}
