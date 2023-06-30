using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Percentage { get; set; }
    }
}
