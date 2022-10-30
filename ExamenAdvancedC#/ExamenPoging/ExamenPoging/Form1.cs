namespace ExamenPoging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_CreateToDo_Click(object sender, EventArgs e)
        {
            AddToDo addToDo = new AddToDo();
            addToDo.ShowDialog();
        }
    }
}