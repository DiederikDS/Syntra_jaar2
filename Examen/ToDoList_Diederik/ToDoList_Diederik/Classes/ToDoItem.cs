using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_Diederik.Classes
{
    public abstract class ToDoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string ExecutionerName { get; set; }
        public string Location { get; set; }
        public DateTime DateExecuted { get; set; }

        public override string ToString()
        {
            return $"{Name} deadline: {DueDate} door {ExecutionerName}";
        }

        public delegate void ToDoItemCreatedEventHandler(object? sender, ToDoCreatedArgs e);

        public event ToDoItemCreatedEventHandler ToDoItemCreated;

        public void OnItemCreated(object? sender, ToDoCreatedArgs e)
        {
            ToDoItemCreated?.Invoke(sender, e);
        }
    }
}
