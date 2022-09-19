using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptieOefening2_TextChecker.Classes
{
    internal static class TextChecker
    {
        public static void CheckText(string input)
        {
            if (input.ToLower().Contains('f'))
            {
                throw new ContainsLetterFException(input);
            }

            if (input.Count() > 50)
            {
                throw new ContainsAlotException(input);
            }

            if (input.Any(Char.IsDigit))
            {
                throw new ContainsNumberException(input);
            }
        }
    }
}
