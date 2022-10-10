using BucketOefening.Classes;
using System.Net.Sockets;

namespace BucketOefening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bucket.BucketIsAlmostFull += GetBucketAmount;
            bucket.BucketIsFull += BucketIsFull;
        }

        Bucket bucket = new Bucket(10);

        private void Btn_Fill_Click(object sender, EventArgs e)
        {
            if (TxtB_FillAmount.Text != null)
            {
                bucket.Fill(Convert.ToInt32(TxtB_FillAmount.Text));
            }
        }

        public void GetBucketAmount(object? sender, BucketEventArgs e)
        {
            MessageBox.Show($"The bucket is more than 80% filled, currently {e.CurrentBucketValue} of {e.MaxBucketValue} is used");
        }

        public void BucketIsFull(object? sender, BucketEventArgs e)
        {
            MessageBox.Show($"The bucket is full all {e.MaxBucketValue} spaces are used");
        }
    }
}