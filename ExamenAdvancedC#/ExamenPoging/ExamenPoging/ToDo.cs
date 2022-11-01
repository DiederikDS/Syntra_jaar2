using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoging
{
    public abstract class ToDo 
    {
        public ToDo(string name, DateTime duedate)
        {
            Name = name;
            DueDate = duedate;
        }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string ExecutorName { get; set; }
        public string Location { get; set; }
        public DateTime DateExecuted { get; set; }

        public override string ToString()
        {
            return $"{Name} - by {ExecutorName} - due {DueDate}";
        }



    }
}
