using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils.Constants
{
    static class EmployeeConstants
    {
        public const string Id = "@Id";
        public const string NameEn = "@NameEn";
        public const string NameKh = "@NameKh";
        public const string Password = "@Password";
        public const string Address = "@Address";
        public const string PositionId = "@PositionId";
        public const string Phone = "@Phone";

        public const string CreateEmployeeStoreProcedure = "CreateEmployee";
        public const string SelectAllEmployeeStoreProcedure = "SelectAllEmployee";
        public const string DeleteEmployeeStoreProcedure = "DelectEmployeeById";
        public const string UpdateEmployeeStoreProcedure = "UpdateEmployee";
    }
}
