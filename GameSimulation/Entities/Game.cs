using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Entities
{
    public class Game
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public double Price { get; set; }

    }
}
