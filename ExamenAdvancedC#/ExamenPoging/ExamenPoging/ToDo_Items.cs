using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoging
{
    internal class ToDo_Items<T> where T : ToDo
    {
        public ToDo_Items()
        {
            ToDoItems = new List<T>();
        }

        public List<T> ToDoItems { get; set; }

        public void AddTodo(T item)
        {
            ToDoItems.Add(item);
        }

        public void RemoveToDo(T item)
        {
            ToDoItems.Remove(item);
        }
    }
}
