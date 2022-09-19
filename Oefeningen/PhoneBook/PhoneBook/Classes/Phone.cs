using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PhoneBook.Classes
{
    public class Phone
    {
        public Phone(string number)
        {
            Number = number;
        }
        public string Number { get; set; }

        public void Call(object sender, EventArgs e)
        {
            MessageBox.Show($"{Number} is calling you...");
        }
    }
}
