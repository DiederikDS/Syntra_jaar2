using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptieIntroOefening1.Classes
{
    internal class LegCountException : Exception
    {
        public LegCountException(string message) : base ( message)
        {

        }
    }
}
