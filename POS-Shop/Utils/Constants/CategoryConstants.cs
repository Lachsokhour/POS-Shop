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
        public const string CreatedBy = "@CreatedBy";

        public const string CreateCategoryStoreProcedure = "CreateCategory";
        public const string SelectAllCategoryStoreProcedure = "SelectAllCategory";
        public const string DeleteCategoryStoreProcedure = "DeleteCategoryById";
        public const string UpdateCategoryStoreProcedure = "UpdateCategory";
        public const string ValidateCategoryNameStoreProcedure = "ValidateCategoryName";
    }
}
