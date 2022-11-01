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

        private void Btn_ImportToDo_Click(object sender, EventArgs e)
        {
            string[] importfile = File.ReadAllLines(@"C:\Users\Diederik\Documents\GitHub\Syntra_jaar2\ExamenAdvancedC#\ExamenPoging\ExamenPoging\ImportFile.txt");
            foreach(var item in importfile)
            {
                var split = item.Split(',');
                HomeWork todo = new HomeWork();
                todo.Name = split[0];
                todo.Description = split[1];
                todo.DueDate = Convert.ToDateTime(split[2]);
                todo.ExecutorName = split[3];
                todo.Location = split[4];
                items.AddTodo(todo);
            }
            PopulateListView();
            Logger.Log($"{importfile.Length} items imported");
            
            
        }
    }
}