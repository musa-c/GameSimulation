using InterfaceAbstractExample.Abstract;
using InterfaceAbstractExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Concrete
{
    public class GameItemManager : IGameSaleManager
    {
        public User GameSale(List<User> users, int userId, List<Game> game)
        {
            var user = users.FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                user.GameSale.AddRange(game);
                return user;
            }
            else
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }
        }
    }
}
