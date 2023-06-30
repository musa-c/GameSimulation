using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Entities
{
    public class User
    {
        public int Id { get; set; }
        public long TcNo { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public List<Game> GameSale { get; set; } = new List<Game>();
        public DateTime BirthDay { get; set; }
    }
}
