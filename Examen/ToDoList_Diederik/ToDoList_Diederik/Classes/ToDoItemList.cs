using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_Diederik.Classes
{
    public class ToDoItemList<T> where T : ToDoItem
    {
        public List<T> TodoItems { get; set; }

        public ToDoItemList()
        {
            TodoItems = new List<T>();
        }

        public void AddItem(T item)
        {
            TodoItems.Add(item);
        }

       public void AddNewItem(object? sender, ToDoCreatedArgs e)
       {
            TodoItems.Add((T)e.ToDo);
       }

    }
}
