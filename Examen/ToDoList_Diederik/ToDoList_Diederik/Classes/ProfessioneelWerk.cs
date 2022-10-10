using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_Diederik.Classes
{
    internal class ProfessioneelWerk : ToDoItem
    {

        public ProfessioneelWerk(string name, string description, DateTime duedate, string executionerName, string location)
        {
            this.Name = name;
            this.Description = description;
            this.DueDate = duedate;
            this.ExecutionerName = executionerName;
            this.Location = location;
        }
    }
}
