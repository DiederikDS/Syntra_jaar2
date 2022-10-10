using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoorbeelExamen
{
    internal abstract class Phone
    {
        public delegate void MessageEventHandler(string);

        public int ID { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string OS { get; set; }
        public string Number { get; set; }

        //EventHandler (standaard)
        public event EventHandler CallReceived;
        public event MessageEventHandler MessageReceived;

        public void Call()
        {
            CallReceived?.Invoke(this, null);
        }

        public void Message(string message, string fromPhone)
        {
            MessageReceived?.Invoke(fromPhone, message);
        }
        public override string ToString()
        {
            return $"{Number} - {Name}";
        }
    }
}
