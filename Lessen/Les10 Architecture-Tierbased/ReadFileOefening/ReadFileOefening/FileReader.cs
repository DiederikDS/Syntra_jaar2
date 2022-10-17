using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileOefening
{
    internal class FileReader
    {
        public string[] FileContent { get; set; }

        public string DirectoryPath { get; set; }

        public FileReader(string directoryPath)
        {
            DirectoryPath = directoryPath;
        }

        public void ReadFile()
        {
            FileContent = System.IO.File.ReadAllLines(DirectoryPath);
        }

        
    }
}
