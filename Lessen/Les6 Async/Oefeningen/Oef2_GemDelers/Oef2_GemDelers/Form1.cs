namespace Oef2_GemDelers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void AddNumberCallback(int value);

        List<int> numbers = new List<int>();

        async private void Btn_Start_Click(object sender, EventArgs e)
        {


            await Task.Run(() =>
            {
                int Getal1 = Int32.Parse(TxtB_Getal1.Text);
                int Getal2 = Int32.Parse(TxtB_Getal2.Text);
                int Highest;

                if (Getal1 > Getal2)
                {
                    Highest = Getal1;
                }
                else
                {
                    Highest = Getal2;
                }

                for (int i = 1; i < Highest; i++)
                {
                    if (Getal1 % i == 0 && Getal2 % i == 0)
                    {
                        AddNumber(i);
                    }
                }
            });
        }

        private void AddNumber(int value)
        {
            if (this.RTB_Numbers.InvokeRequired)
            {
                //callback
                var d = new AddNumberCallback(AddNumber);
                this.Invoke(d, value);
            }
            else
            {
                numbers.Add(value);
                string[] numbersArray = new string[numbers.Count];
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbersArray[i] = numbers[i].ToString();
                }
                this.RTB_Numbers.Lines = numbersArray;
            }
        }

    }
}