using InterfaceAbstractExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Abstract
{
    public interface ICheckUser
    {
        bool CheckifUser(User user);
    }
}
