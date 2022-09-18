using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Classes
{
    internal class Phonebook
    {
        public delegate void CalledEventHandler(object sender, EventArgs e);

        public List<Phone> Phones { get; set; } = new List<Phone>();

        public event CalledEventHandler Called;

        protected virtual void OnCalled()
        {
            if (Called != null)
            {
                Called.Invoke(this, EventArgs.Empty);
            }
        }

        public void CallPhone(string number)
        {
            foreach (Phone p in Phones)
            {
                if (p.Number == number)
                {
                    OnCalled();
                }
            }
        }

        public void SendMessageToPhone(string number, string message)
        {
            foreach (Phone p in Phones)
            {
                if (p.Number == number)
                {
                    //trigger message event
                }
            }
        }
    }

}
