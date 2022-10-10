namespace AsyncReadFromFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Numbers;

        private async void button1_Click(object sender, EventArgs e)
        {
            Populate();
        }

        public delegate void PopulateCallback();


        private async void Populate()
        {
            await Task.Run(() =>
            {
                if (LiBx_Numbers.InvokeRequired)
                {
                    var d = new PopulateCallback(Populate);
                    this.Invoke(d);
                }
                else
                {
                    Numbers = System.IO.File.ReadAllLines(@"C:\Users\Diederik\Desktop\Oefeningen\AsyncReadFromFile\AsyncReadFromFile\Numbers.txt");
                    foreach (string num in Numbers)
                    {
                        LiBx_Numbers.Items.Add(num);
                    }
                }
            });
        }
    }
}