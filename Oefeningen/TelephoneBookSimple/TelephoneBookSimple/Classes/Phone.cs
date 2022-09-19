using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBookSimple.Classes
{
    internal class Phone
    {
        
        public Phone(string number)
        {
            Number = number;
        }
        public string Number { get; set; }

        //EventHandler that will be refered to.
        public void OnCalled(object source, EventArgs e)
        {
            Console.WriteLine($"Calling {Number}...");
        }

        public void OnMessageSent(object source, MessageArgs e)
        {
            Console.WriteLine($"{Number} sends the following message: {e.Message}");
        }

        
    }
}
