namespace EventsIntroOefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random _rand = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(_rand.Next(256), _rand.Next(256), _rand.Next(256));
            this.BackColor = randomColor;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar trackbar = (TrackBar)sender;
            timer1.Interval = trackbar.Value;
        }
    }
}