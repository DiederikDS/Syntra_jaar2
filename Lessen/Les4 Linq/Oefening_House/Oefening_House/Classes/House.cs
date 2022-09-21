using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oefening_House.Enums;

namespace Oefening_House.Classes
{
    internal class House
    {
        public string? Name { get; set; }
        public string? Region { get; set; }
        public decimal Price { get; set; }
        public int BedroomCount { get; set; }
        public decimal Squaremeter { get; set; }
        public EnumType Type { get; set; }

    }
}
