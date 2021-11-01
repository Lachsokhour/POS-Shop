using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils
{
    abstract class AbstractCrud<T> : ICrud<T>
    {
        public virtual bool create() { throw new NotImplementedException(); }

        public virtual bool delete(int id) { throw new NotImplementedException(); }

        public virtual List<T> readAll() { throw new NotImplementedException(); }

        public virtual T readById(int id) { throw new NotImplementedException(); }

        public virtual  bool update() { throw new NotImplementedException(); }
    }
}
