using ToDoList_Diederik.Classes;
using System.Linq;

namespace ToDoList_Diederik
{
    public partial class Form1 : Form
    {
        private ToDoItemList<ToDoItem> _items;
        public ToDoItemList<ToDoItem> FilteredList = new ToDoItemList<ToDoItem>();

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

        private void Btn_ToDoImport_Click(object sender, EventArgs e)
        {
            Import();
        }

        public delegate void ImportCallback();

        private async void Import()
        {
            await Task.Run(() =>
            {
                if (LiBx_ToDoItems.InvokeRequired)
                {
                    var d = new ImportCallback(Import);
                    this.Invoke(d);
                }
                else
                {
                    string line;

                    // Read the file and display it line by line.
                    System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\diede\OneDrive\Bureaublad\Syntra_jaar2\Examen\ToDoList_Diederik\ToDoList_Diederik\ToDoList.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] words = line.Split(',');
                        if (words[5] == "ProfessioneelWerk")
                        {
                            _items.TodoItems.Add(new ProfessioneelWerk(words[0], words[1], Convert.ToDateTime(words[2]), words[3], words[4]));
                        }
                        else
                        {
                            _items.TodoItems.Add(new ThuisWerk(words[0], words[1], Convert.ToDateTime(words[2]), words[3], words[4]));
                        }
                    }

                    file.Close();
                    PopulateLiBx_ToDoItems();
                }
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilteredList = _items.Where(e => e) 
        }
    }
}