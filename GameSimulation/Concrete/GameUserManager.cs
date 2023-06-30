using InterfaceAbstractExample.Abstract;
using InterfaceAbstractExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Concrete
{
    public class GameUserManager : IDbManager<User>
    {
        private ICheckUser _checkUser;
        private IGameSaleManager _gameSaleManager;
        List<User> users = new();
        public GameUserManager(ICheckUser checkUser, IGameSaleManager gameItemManager, User user)
        {
            _gameSaleManager = gameItemManager;
            _checkUser = checkUser;
            Create(user);
        }
        public GameUserManager(ICheckUser checkUser, IGameSaleManager gameItemManager)
        {
            _gameSaleManager = gameItemManager;
            _checkUser = checkUser;
        }

        public User Create(User user)
        {
            if (_checkUser.CheckifUser(user))
            {
                if(!users.Any(x => x.Id == user.Id))
                {
                    users.Add(user);
                    Console.WriteLine("Başarılı bir şekilde eklendi.");
                    return user;
                }
                else
                {
                    throw new Exception("Kullanıcı zaten ekli.");
                }
                

            }else throw new Exception("Kullanıcı bilgileri hatalı.");
        }

        public void Delete(int userId)
        {

            if (users.Any(x => x.Id == userId))
            {
                var user = users.Find(x => x.Id == userId);
                if (users.Remove(user!))
                {
                    Console.WriteLine("Kullanıcı başarılı bir şekilde silindi.");
                    foreach (var item in users)
                    {
                        Console.WriteLine("----user-------");
                        Console.WriteLine(item.Id);
                        Console.WriteLine(item.FirstName);
                        Console.WriteLine(item.LastName);
                        Console.WriteLine(item.BirthDay);
                        Console.WriteLine(item.TcNo);

                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı bulunamadı.");
                }
                
            }
            else
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }
        }

        public User Update(int userId, User user)
        {
            var updateUser = users.FirstOrDefault(x => x.Id == userId);

            if (updateUser != null)
            {
                updateUser.FirstName = user.FirstName;
                updateUser.LastName = user.LastName;
                updateUser.BirthDay = user.BirthDay;
                updateUser.TcNo = user.TcNo;

                foreach (var item in users)
                {
                    Console.WriteLine("----user-------");
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.FirstName);
                    Console.WriteLine(item.LastName);
                    Console.WriteLine(item.BirthDay);
                    Console.WriteLine(item.TcNo);

                }

                Console.WriteLine("başarılı bir şekilde güncellendi.");
                return updateUser;
            }
            else
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }
        }

        public void GameSale(User user, List<Game> game)
        {
            User _user = _gameSaleManager.GameSale(users, user.Id, game);
            Console.WriteLine("--------USER------");

            Console.WriteLine("User Id: " + _user.Id);
            Console.WriteLine("User TcNo: " + _user.TcNo);
            Console.WriteLine("User First Name: "+ _user.FirstName);
            Console.WriteLine("User Last Name: "+ _user.LastName);
            Console.WriteLine("User BirthDay: "+ _user.BirthDay);

            Console.WriteLine("GAME SALES");
            foreach (var item in _user.GameSale)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Game Id: " + item.Id);
                Console.WriteLine("Game Name: "+ item.Name);
                Console.WriteLine("Game Price: "+ item.Price);
            }
         
         
        }
    }
}
