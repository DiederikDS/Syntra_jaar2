using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoging
{
    public class ToDoItemEventArgs : EventArgs
    {
        public ToDo todo { get; set; }

        public ToDoItemEventArgs(ToDo item)
        {
            todo = item;
        }
    }
}
