using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoging
{
    internal class ProfessionalWork : ToDo
    {
        public ProfessionalWork(string name, DateTime duedate)
            :base(name, duedate)
        {
        }
    }
}
