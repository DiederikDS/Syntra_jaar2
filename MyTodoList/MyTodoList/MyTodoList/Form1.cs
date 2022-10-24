using MyTodoList.Classes;

namespace MyTodoList
{
    public partial class Form1 : Form
    {
        private TodoItemList<TodoItem> _todos;

        public Form1()
        {
            InitializeComponent();
            _todos = new TodoItemList<TodoItem>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new AddTodoForm();
                form.TodoItemCreated += Form_CreateTodoItem;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_CreateTodoItem(object sender, TodoItemEventArgs e)
        {
            _todos.Add(e.TodoItem);
            FileLogger.LogAction("Todo item created");
            RefreshList();
        }

        private void RefreshList()
        {
            lstItems.Items.Clear();
            lstItems.Items.AddRange(_todos.TodoItems.ToArray());
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var selectedTodo = (TodoItem)lstItems.SelectedItem;
            FileLogger.LogAction("Todo item executed");
            selectedTodo.ExecutedDate = DateTime.Now;
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var list = File.ReadAllLines(@"./importfile.txt");

                foreach (var item in list)
                {
                    var split = item.Split(',');
                    var homeWork = new HomeWork();
                    homeWork.Name = split[0];
                    homeWork.Description = split[1];
                    homeWork.DueDate = DateTime.Parse(split[2]);
                    homeWork.ExecuterName = split[3];
                    homeWork.Location = split[4];
                    _todos.Add(homeWork);
                }

                FileLogger.LogAction("Todo items imported (count: " + list.Count() + ")");
            });

            RefreshList();
        }

        private void btnGroupPerWeek_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            lstItems.Items.AddRange(_todos.GetGroupedTodosPerWeek().ToArray());
        }

        private void btnGroupPerExecuter_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            lstItems.Items.AddRange(_todos.GetGroupedPerExecuter().ToArray());
        }

        private void btnShowExecutedTodo_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            lstItems.Items.AddRange(_todos.GetExecutedTodos().ToArray());
        }

        private void btnShowAllTodo_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            lstItems.Items.AddRange(_todos.GetAllTodoUpcomingWeek().ToArray());
        }
    }
}