using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils.Constants
{
    static class ProductConstants
    {
        public const string Id = "@Id";
        public const string NameEn = "@NameEn";
        public const string NameKh = "@NameKh";
        public const string Filename = "@Filename";
        public const string FilePath = "@FilePath";
        public const string Note = "@Note";
        public const string CategoryId = "@CategoryId";
        public const string PriceOut = "@PriceOut";
        public const string Barcode = "@Barcode";
        public const string Filter = "@Filter";
        public const string CreatedBy = "@CreatedBy";

        public const string CreateProductStoreProcedure = "CreateProduct";
        public const string UpdateProductStoreProcedure = "UpdateProduct";
        public const string SelectAllProductStoreProcedure = "SelectAllProduct";
        public const string DeleteProductStoreProcedure = "DeleteProduct";
        public const string CountAllProductStoreProcedure = "CountAllProduct";
        public const string ValidateBarcodeProductStoreProcedure = "ValidateBarcodeProduct";
        public const string SelectAllProductsByCategoryIdAndFilterStoreProcedure = "SelectAllProductsByCategoryIdAndFilter";

    }
}
