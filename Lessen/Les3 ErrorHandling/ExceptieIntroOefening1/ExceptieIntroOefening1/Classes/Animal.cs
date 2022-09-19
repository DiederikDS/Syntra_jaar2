using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ExceptieIntroOefening1.Classes
{
    internal class Animal
    {
        public string Name { get; set; }
        public DateTime? DayOfBirth { get; set; }
        private int _legCount;

        public int LegCount
        {
            get { return _legCount; }
            set {

                if (value <= 1)
                {
                    throw new Exception("Legcount must be higher than 1");
                }

                _legCount = value; 
            }
        }

        public Color Color { get; set; }

        public int GetAge()
        {
            if (DayOfBirth.HasValue)
            {
                return (int)Math.Floor((decimal)(DateTime.Now - DayOfBirth.Value).TotalDays/356);
            }
            else
            {
                throw new Exception("Animal does not have a day of birth!");
            }
        }
    }
}
