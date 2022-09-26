using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPhone.Classes
{
    internal abstract class Phone
    {
        public string Name { get; set; }
        public string? OS { get; set; }
        public decimal Price { get; set; }
        public int ScreenSize { get; set; }
        public int CameraCount { get; set; }

        public Phone(string i)
        {
            Name = i;
        }
    }
}
