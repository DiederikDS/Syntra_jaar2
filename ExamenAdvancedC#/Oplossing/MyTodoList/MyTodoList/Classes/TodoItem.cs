using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodoList
{
    public abstract class TodoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExecuterName { get; set; }
        public string Location { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ExecutedDate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
