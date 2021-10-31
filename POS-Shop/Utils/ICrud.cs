using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Utils
{
    interface ICrud<T>
    {
        bool create();
        bool update();
        bool delete(int id);
        List<T> readAll();
        T readById(int id);
    }
}
