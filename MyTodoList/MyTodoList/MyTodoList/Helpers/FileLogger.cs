using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodoList
{
    public static class FileLogger
    {
        public static void LogAction(string action)
        {
            Directory.CreateDirectory("C:/Temp/Syntra");
            File.AppendAllText("C:/Temp/Syntra/log.txt", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff") + ": " + action + Environment.NewLine);
        }
    }
}
