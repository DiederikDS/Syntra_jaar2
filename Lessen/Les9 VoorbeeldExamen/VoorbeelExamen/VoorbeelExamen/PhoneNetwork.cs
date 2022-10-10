using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeelExamen
{
    internal class PhoneNetwork<T> where T : Phone
    {
        public List<T> Phones { get; set; }

        public PhoneNetwork()
        {
            Phones = new List<T>();
        }

        public void AddPhone(T phone)
        {
            Phones.Add(phone);
        }

        public void CallPhone(string number)
        {
            var phone = Phones.FirstOrDefault(e => e.Number == number);

            if (phone != null)
            {
                phone.Call();
            }
        }
    }
}
