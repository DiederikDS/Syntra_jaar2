using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPhone.Classes
{
    internal class Iphone : Phone
    {
        public Iphone(string i) : base(i)
        {
        }

        public string? FactoryNumber { get; set; }
    }
}
