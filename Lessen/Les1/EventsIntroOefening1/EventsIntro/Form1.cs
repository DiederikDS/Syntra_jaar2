namespace EventsIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random _rand = new Random();

        Color RandomColor
        {
            get
            {
                return Color.FromArgb(_rand.Next(256) + _rand.Next(256) + _rand.Next(256));
            }
        }

        List<Button> modified = new List<Button>();

        private void button_Click(object sender, EventArgs e)
        {   
            Button button = (Button)sender;

            if (button.Text == "" )
            {
                button.Text = "O";
            }
            else
            {
                button.Text = "X";
                button.Enabled = false;
            }

        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color randomColor = Color.FromArgb(_rand.Next(256), _rand.Next(256), _rand.Next(256));
            button.BackColor = randomColor;
            modified.Add(button);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            foreach (Button button in modified)
            {;
                button.BackColor = default;
                button.Text = "";
                button.Enabled = true;
            }
            
        }
    }
}
