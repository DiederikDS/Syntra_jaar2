using ToDoList_Diederik.Classes;

namespace ToDoList_Diederik
{
    public partial class Form1 : Form
    {
        private ToDoItemList<ToDoItem> _items;
        public ToDoItemList<ToDoItem> FilteredList = new ToDoItemList<ToDoItem>();
        private ProfessioneelWerk _selectedItem;

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

        private void LiBx_ToDoItems_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedItem = new ProfessioneelWerk(LiBx_ToDoItems.SelectedItem);
        }

        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            _selectedItem.DateExecuted = DateTime.Now;
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

        //Linq:
        //Per week het aantal todo's
        private void button4_Click(object sender, EventArgs e)
        {
            FilteredList = (ToDoItemList<ToDoItem>)_items.TodoItems.GroupBy(e => (e.DueDate.Day/7)).Select(e => $"{e.Key} - {e.Key * 7} : {e.Count()} tasks");

        }

        //Per executor
        private void button5_Click(object sender, EventArgs e)
        {
            FilteredList = (ToDoItemList<ToDoItem>)_items.TodoItems.GroupBy(e => e.ExecutionerName).Select(e => $"{e.Key} : {e.Count()} tasks");
        }

        //Per uitgevoerde taak
        private void button6_Click(object sender, EventArgs e)
        {
            FilteredList = (ToDoItemList<ToDoItem>)_items.TodoItems.Where(e => e.DateExecuted < DateTime.Now).Select(e => $"Date executed: {e.Name} {e.Description}");
        }

        //Alle taken die de komende 7 dagen moeten worden uitgevoerd: ‘Name, Description’

    }
}