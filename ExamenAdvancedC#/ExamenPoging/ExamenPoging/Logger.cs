using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPoging
{
    internal static class Logger
    {

        public static void Log(string line)
        {
            File.AppendAllText("C:\\Users\\Diederik\\Documents\\GitHub\\Syntra_jaar2\\ExamenAdvancedC#\\ExamenPoging\\ExamenPoging\\Logs.txt", $"{line} - created on: {DateTime.Now}");
        }
    }
}
