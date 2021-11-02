using POS_Shop.DB;
using POS_Shop.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    class Category : AbstractCrud<Category>
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get ; set ; }
        public DateTime ModifiedAt { get; set; }

        /// <summary>
        /// Connect to DB server.
        /// </summary>
        private SqlConnection conn = Connection.getConnection();

        public override bool create()
        {
            return false;
        }

        public override bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Category> readAll()
        {
            conn.Open();
            List<Category> categories = new List<Category>();
            return null;
        }

        public override Category readById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
