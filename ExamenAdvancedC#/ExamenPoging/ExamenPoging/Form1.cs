namespace ExamenPoging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        ToDo_Items<ToDo> items = new ToDo_Items<ToDo>();

        private void Btn_CreateToDo_Click(object sender, EventArgs e)
        {
            AddToDo addToDo = new AddToDo();
            addToDo.OnToDoCreated += CreateToDo;
            addToDo.ShowDialog();
            PopulateListView();
        }

        public void PopulateListView()
        {
            LV_ToDo.Items.Clear();
            foreach(var item in items.ToDoItems)
            {
                LV_ToDo.Items.Add(item.ToString());
            }
        }

        public void CreateToDo(object sender, ToDoItemEventArgs e)
        {
            items.AddTodo(e.todo);
            Logger.Log("ToDo created");
            PopulateListView();
        }
    }
}