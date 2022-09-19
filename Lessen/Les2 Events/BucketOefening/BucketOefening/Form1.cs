using BucketOefening.Classes;

namespace BucketOefening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bucket.BucketIsAlmostFull += DisplayBucketAlmostFull;
            bucket.BucketIsFull += DisplayBucketFull;
        }

        Bucket bucket = new Bucket(5, 0);

        public void DisplayBucketAlmostFull(object sender, BucketEventArgs e)
        {
            MessageBox.Show($"The bucket is almost full! \nCurrent amount is {e.CurrentAmount} \nMaximum amount is {e.MaxAmount}");
        }

        public void DisplayBucketFull(object sender, BucketEventArgs e)
        {
            MessageBox.Show($"The bucket is full, {e.MaxAmount} has been reached.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bucket.Fill(1);
        }
    }
}