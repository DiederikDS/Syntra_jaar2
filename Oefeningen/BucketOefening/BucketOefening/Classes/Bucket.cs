using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketOefening.Classes
{
    internal class Bucket
    {
        public int MaxAmount { get; set; }
        public int CurentAmount { get; set; }

        public Bucket(int maxamount)
        {
            MaxAmount = maxamount;
        }

        public void Fill(int amount)
        {
            CurentAmount += amount;
            OnBucketFilled();
        }

        public EventHandler<BucketEventArgs> BucketIsAlmostFull;

        public EventHandler<BucketEventArgs> BucketIsFull;

        public void OnBucketFilled()
        {
            double maxamount = MaxAmount;
            double currentamount = CurentAmount;
            BucketEventArgs e = new BucketEventArgs(CurentAmount, MaxAmount);

            if (maxamount <= currentamount)
            {
                BucketIsFull?.Invoke(this, e);

            } else if ((currentamount / maxamount) * 100 >= 80)
            {
                BucketIsAlmostFull?.Invoke(this, e);
            }
        }

    }
}
