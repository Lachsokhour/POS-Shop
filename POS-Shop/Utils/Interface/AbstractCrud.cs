using POS_Shop.DB;
using POS_Shop.Utils.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils
{
    abstract class AbstractCrud<T> : BaseEntity, ICrud<T>
    {
        /// <summary>
        /// Connect to DB server.
        /// </summary>
        public SqlConnection conn = SingletonDB.Instance.GetDBConnection();

        public virtual bool create() { throw new NotImplementedException(); }

        public virtual bool delete(int id) { throw new NotImplementedException(); }

        public virtual List<T> readAll() { throw new NotImplementedException(); }

        public virtual T readById(int id) { throw new NotImplementedException(); }

        public virtual  bool update() { throw new NotImplementedException(); }

        /// <summary>
        /// To alert message.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        public virtual void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            FormAlertNotification formAlert = new FormAlertNotification();
            formAlert.ShowAlert(msg, type);
        }
    }
}
