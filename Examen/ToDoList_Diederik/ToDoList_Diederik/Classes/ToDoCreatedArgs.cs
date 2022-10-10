using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_Diederik.Classes
{
    public class ToDoCreatedArgs : EventArgs
    {
        public ToDoItem ToDo { get; set; }

        public ToDoCreatedArgs(ToDoItem item)
        {
            ToDo = item;
        }
    }
}
