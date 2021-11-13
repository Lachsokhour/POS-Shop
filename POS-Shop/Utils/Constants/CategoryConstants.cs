using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS_Shop.Utils
{
    static class CategoryConstants
    {
        public const string Id = "@Id";
        public const string Name = "@Name";
        public const string Photo = "@Photo";
        public const string FilePath = "@FilePath";
        public const string Note = "@Note";

        public static string CreateCategoryStoreProcedure = "CreateCategory";
        public static string SelectAllCategoryStoreProcedure = "SelectAllCategory";
        public static string DeleteCategoryStoreProcedure = "DeleteCategoryById";
        public static string UpdateCategoryStoreProcedure = "UpdateCategory";
        public static string ValidateCategoryNameStoreProcedure = "ValidateCategoryName";
    }
}
