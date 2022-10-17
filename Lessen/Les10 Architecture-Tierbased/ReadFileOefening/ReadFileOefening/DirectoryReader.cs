using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileOefening
{
    internal class DirectoryReader
    {
        public DirectoryReader(string directoryPath)
        {
            DirectoryPath = directoryPath;
        }

        public string[] Files { get; set; }
        public string DirectoryPath { get; set; }

        public void AddFiles()
        {
            Files = Directory.GetFiles($@"{DirectoryPath}");
        }
    }
}
