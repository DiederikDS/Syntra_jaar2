using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPhone.Classes
{
    internal class Samsung : Phone
    {
        public Samsung(string i) : base(i)
        {
        }

        public int FactoryNumber { get; set; }
    }
}
