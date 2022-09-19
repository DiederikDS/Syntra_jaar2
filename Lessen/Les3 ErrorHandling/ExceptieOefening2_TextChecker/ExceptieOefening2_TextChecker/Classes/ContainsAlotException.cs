using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptieOefening2_TextChecker.Classes
{
    internal class ContainsAlotException : Exception
    {
        public ContainsAlotException(string message) : base(message)
        {

        }

        public ContainsAlotException() : base()
        {

        }

        public string Error { get; } = "Input may not contain more than 50 characters";
    }
}
