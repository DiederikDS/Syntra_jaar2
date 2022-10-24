using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodoList.Classes
{
    public class TodoItemEventArgs : EventArgs
    {
        public TodoItem TodoItem { get; set; }

        public TodoItemEventArgs(TodoItem item)
        {
            TodoItem = item;
        }
    }
}
