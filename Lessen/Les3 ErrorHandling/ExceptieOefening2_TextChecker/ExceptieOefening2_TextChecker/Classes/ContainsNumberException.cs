using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptieOefening2_TextChecker.Classes
{
    internal class ContainsNumberException : Exception
    {
        public ContainsNumberException(string message) : base(message)
        {

        }

        public ContainsNumberException() : base()
        {

        }

        public string Error { get; } = "The input may not contain a number";
    }
}
