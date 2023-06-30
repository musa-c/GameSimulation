using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Abstract
{
    public interface IDbManager<T>
    {
        T Create(T t);
        T Update(int id, T t);
        void Delete(int id);

    }
}
