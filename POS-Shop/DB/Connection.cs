using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POS_Shop.DB
{
    static class Connection
    {
        static string connetionString = $"server={DBConfig.SERVER};database={DBConfig.DB_NAME};UID={DBConfig.USERNAME};password={DBConfig.PASSWORD}";

        static public SqlConnection getConnection()
        {
            return new SqlConnection(connetionString);
        }
    }
}
