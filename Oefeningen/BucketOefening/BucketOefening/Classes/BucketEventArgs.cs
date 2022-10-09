using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketOefening.Classes
{
    public class BucketEventArgs : EventArgs
    {
        public int CurrentBucketValue { get; set; }

        public int MaxBucketValue { get; set; }

        public BucketEventArgs(int currentBucketValue, int maxBucketValue)
        {
            CurrentBucketValue = currentBucketValue;
            MaxBucketValue = maxBucketValue;
        }
    }
}
