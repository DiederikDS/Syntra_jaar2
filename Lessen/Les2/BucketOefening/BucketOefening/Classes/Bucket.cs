using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketOefening.Classes
{
    public class Bucket
    {
        public delegate void BucketEventHandler(object sender, BucketEventArgs e);

        public Bucket(int max, int current)
        {
            MaxAmount = max;
            CurrentAmount = current;
        }

        //Properties
        public int MaxAmount { get; set; }

        public int CurrentAmount { get; set; }

        //Events:
        public event BucketEventHandler BucketIsAlmostFull;
        public event BucketEventHandler BucketIsFull;

        //Methods/
        public void Fill(int amount)
        { 
            
            if (MaxAmount - (CurrentAmount + amount) == 0)
            {
                BucketIsFull?.Invoke(this, new BucketEventArgs(MaxAmount, CurrentAmount));
            }
            else
            {
                CurrentAmount += amount;
                if ( CurrentAmount * (100/MaxAmount) >= 80)
                {
                    BucketIsAlmostFull?.Invoke(this, new BucketEventArgs(MaxAmount, CurrentAmount));
                }
            }
        }

    }
}
