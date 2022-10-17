using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Classes
{
    internal class TxtFileReader
    {
        public string[] Lines { get; set; }

        public TxtFileReader()
        {

        }

        public void ReadFile(string location)
        {
            Lines = (string[])File.ReadAllLines($@"{location}");
        }

    }
}
