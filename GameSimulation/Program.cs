using InterfaceAbstractExample.Adapters;
using InterfaceAbstractExample.Concrete;
using InterfaceAbstractExample.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InterfaceAbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataJsonPath = Path.Combine(Environment.CurrentDirectory, "data.json");
            long TcNo = Convert.ToInt64(JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(dataJsonPath))!["TcNo"]);


            User user = new()
            {
                Id = 1,
                FirstName = "Musa",
                LastName = "Civelek",
                BirthDay = new DateTime(2001, 1, 26),
                TcNo = TcNo,
            };

            User user2 = new()
            {
                Id = 2,
                FirstName = "Musa",
                LastName = "Civelek",
                BirthDay = new DateTime(2001, 1, 26),
                TcNo = TcNo,

            };

            User updateUser = new()
            {
                Id = 1,
                FirstName = "Musa",
                LastName = "cvcvvc",
                BirthDay = new DateTime(2001, 1, 26),
                TcNo = TcNo,
            };
            GameUserManager gameUserManager = new(new MernisServiceAdapter(), new GameItemManager() ,user);
            //gameUserManager.Create(user);
            gameUserManager.Create(user2);

            Game game = new()
            {
                Id = 1,
                Name = "Ghost",
                Price = 50
            };

            Game game2 = new()
            {
                Id = 2,
                Name = "Counter Strike 1.6",
                Price = 48
            };

            Game game3 = new()
            {
                Id = 3,
                Name = "The Forest",
                Price = 36
            };

            List<Game> games = new() { game, game2, game3};
            Game game4 = new()
            {
                Id = 4,
                Name = "PUBG",
                Price = 192
            };

            Game game5 = new()
            {
                Id = 5,
                Name = "Metin 2",
                Price = 0
            };

            Game game6 = new()
            {
                Id = 6,
                Name = "Call Of Duty Modern Warfare",
                Price = 36
            };
            List<Game> games2 = new() { game4, game5, game6 };

            CampaignManager campaignManager = new();
            Campaign canpaign1 = campaignManager.Create(new Campaign { Id = 1, Name = "Yaz İndirimi", Percentage=20 });
            Campaign canpaign2 = campaignManager.Create(new Campaign { Id = 2, Name = "İçimden geldi anasını satayım", Percentage = 35 });
            Campaign canpaign3 = campaignManager.Create(new Campaign { Id = 3, Name = "bilmiyorum", Percentage = 2 });

            Console.WriteLine(canpaign1.Name);
            Console.WriteLine(canpaign2.Name);
            Console.WriteLine(canpaign3.Name);

            gameUserManager.GameSale(user, games, canpaign1);
            gameUserManager.GameSale(user2, games2);

            Console.ReadLine();
            
        }
    }
}