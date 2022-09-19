using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketOefening.Classes
{
    public class BucketEventArgs : EventArgs
    {
        public int MaxAmount { get; set; }
        public int CurrentAmount { get; set; }

        public BucketEventArgs(int max, int current)
        {
            MaxAmount = max;
            CurrentAmount = current;
        }
    }
}
