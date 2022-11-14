using Logic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTutorial.Data
{
    public class Token
    {
        public string TokenId { get; set; }
        public List<Door> Doors { get; set; }

        public bool IsActive { get; set; }
    }
}
