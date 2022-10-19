using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonOefenening
{
    internal class SingletonClass
    {
        private static string AangemaaktOp;
        private static SingletonClass Instance = null;

        private SingletonClass()
        {
            AangemaaktOp = DateTime.Now.ToString();
        }

        public static SingletonClass GetInstance {
            get
            {
                if (Instance == null)
                {
                    Instance = new SingletonClass();
                }

                return Instance;
            } 
        }
        
        public string Tijd()
        {
            return AangemaaktOp.ToString();
        }
    }
}
