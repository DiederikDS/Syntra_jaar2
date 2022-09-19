using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptieOefening2_TextChecker.Classes
{
    internal class ContainsLetterFException : Exception
    {
        public ContainsLetterFException(string message) : base(message)
        {
        
        }

        public ContainsLetterFException() : base()
        {

        }

        public string Error { get; } = @"Input may not contain the letter 'f'";

    }
}
