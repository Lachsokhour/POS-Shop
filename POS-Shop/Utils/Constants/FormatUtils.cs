using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils
{
    static class FormatUtils
    {
        public const string dollar = "$#,##0.00";
        public const string dateTime = "dd-MM-yyyy hh:mm:ss";
        public const string DateTimeWithoutHour = "dd-MM-yyyy";
        public const string DateTimetHour = "hh:mm:ss";
        public const string FileFilter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

        public static string ConvertStringToCurrency(string value)
        {
            return string.Format("${0:#.00}", Convert.ToDecimal(value));
        }
    }
}
