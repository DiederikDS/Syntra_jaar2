using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptieOefening3_Door.Classes
{
    internal class DoorIsUnlockedException : Exception
    {
        public DoorIsUnlockedException(string? message) : base(message)
        {

        }
    }
}
