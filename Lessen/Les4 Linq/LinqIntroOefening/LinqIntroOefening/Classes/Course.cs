using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqIntroOefening.Enum;

namespace LinqIntroOefening.Classes
{
    internal class Course
    {
        public string Teacher { get; set; }
        public int Duration { get; set; }
        public string Room { get; set; }
        public int StudentCount { get; set; }
        public EnumPeriod Period { get; set; }

    }
}
