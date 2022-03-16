using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.DB
{
    public  class SingletonDB
    {
        private static SingletonDB instance;


        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonDB()
        {
        }

        private SingletonDB()
        {
        }

        public static SingletonDB Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonDB();
                }
                return instance;
            }
        }

        public SqlConnection GetDBConnection()
        {
            return new SqlConnection($"server={DBConfig.SERVER};database={DBConfig.DB_NAME};UID={DBConfig.USERNAME};password={DBConfig.PASSWORD}");
        }

    }
}
