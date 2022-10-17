using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Classes
{
    internal class DirectoryExplorer
    {
        public string[] Items { get; set; }

        public DirectoryExplorer()
        {
            
        }

        public void GetItems(string location)
        {
            string[] empty = new string[0];
            Items = empty;
            Items = Directory.GetFiles(@$"{location}");
        }
    }
}
