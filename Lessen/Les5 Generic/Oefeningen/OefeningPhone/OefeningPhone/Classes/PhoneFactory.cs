using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPhone.Classes
{
    internal class PhoneFactory<T> where T : Phone
    {
        private List<T> Phones;

        public PhoneFactory()
        {
            Phones = new List<T>();
        }

        public void AddPhone(T i)
        {
            Phones.Add(i);
        }

        public void RemovePhone(string name)
        {
            foreach (T i in Phones)
            {
                if (i.Name == name)
                {
                    Phones.Remove(i);
                }
            }
        }
        public decimal GetAveragePrice()
        {
            decimal price = 0;
            foreach (T i in Phones)
            {
                price += i.Price;
            }

            return (price/Phones.Count);
        }

    }
}
