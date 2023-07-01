using InterfaceAbstractExample.Concrete;
using InterfaceAbstractExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Abstract
{
    public interface IGameSaleManager
    {
        User GameSale(List<User> users, int userId, List<Game> game);
        User GameSale(List<User> users, int userId, List<Game> game, Campaign campaign);
    }
}
