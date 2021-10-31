using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils
{
    static class ConstantsCategory
    {
        public const string Id = "@CategoryId";
        public const string Name = "@CategoryName";
        public const string Photo = "@CategoryPhoto";
        public const string Note = "@CategoryNote";
        public const string OperationType = "@OperationType";

        public static string ScriptInsert = $"INSERT INTO category VALUES ({Id},{Name},{Photo}, {Note})";
        //public static string StriptDelete = $"DELETE ";
        public static string ScriptSelect = $"Select * from category";
    }
}
