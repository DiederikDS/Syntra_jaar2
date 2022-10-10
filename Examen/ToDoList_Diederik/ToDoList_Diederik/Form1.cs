using ToDoList_Diederik.Classes;

namespace ToDoList_Diederik
{
    public partial class Form1 : Form
    {
        private ToDoItemList<ToDoItem> _items;

        public void AddCreatedItemToList(object? sender, ToDoCreatedArgs e)
        {
            _items.AddItem(e.ToDo);
        }

        public Form1()
        {
            InitializeComponent();
            _items = new ToDoItemList<ToDoItem>();
        }

        public void PopulateLiBx_ToDoItems()
        {
            LiBx_ToDoItems.Items.Clear();
            foreach (var item in _items.TodoItems)
            {
                LiBx_ToDoItems.Items.Add(item);
            }
        }

        private void Btn_ToDoAanmaken_Click(object sender, EventArgs e)
        {
            var aanmaakVenster = new ToDo_Aanmaken(_items);
            aanmaakVenster.ShowDialog();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            PopulateLiBx_ToDoItems();
        }
    }
}