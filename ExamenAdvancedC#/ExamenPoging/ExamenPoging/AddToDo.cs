using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPoging
{
    public partial class AddToDo : Form
    {
        public AddToDo()
        {
            InitializeComponent();
            CBB_Type.Items.Add("Professional work");
            CBB_Type.Items.Add("Home work");
        }

        public delegate void ToDoCreated(object sender, ToDoItemEventArgs e);
        public event ToDoCreated OnToDoCreated;

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (CBB_Type.SelectedItem != null && TxtB_Name.Text != "")
            {
                if (Convert.ToString(CBB_Type.SelectedItem)  == "Professional work")
                {
                    ProfessionalWork pwTodo = new ProfessionalWork(TxtB_Name.Text, DTP_DueDate.Value) {ExecutorName = TxTB_Executor.Text, Description = RTB_Description.Text, Location = TxTB_Location.Text };
                    OnToDoCreated.Invoke(this, new ToDoItemEventArgs(pwTodo));
                }
                else
                {
                    HomeWork hwTodo = new HomeWork(TxtB_Name.Text, DTP_DueDate.Value) { ExecutorName = TxTB_Executor.Text, Description = RTB_Description.Text, Location = TxTB_Location.Text };
                    OnToDoCreated.Invoke(this, new ToDoItemEventArgs(hwTodo));
                }
            }
            else
            {
                MessageBox.Show("Type and Name should be filled in");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CBB_Type.SelectedItem != null && TxtB_Name.Text != "")
            {
                if (Convert.ToString(CBB_Type.SelectedItem) == "Professional work")
                {
                    ProfessionalWork pwTodo = new ProfessionalWork(TxtB_Name.Text, DTP_DueDate.Value) { ExecutorName = TxTB_Executor.Text, Description = RTB_Description.Text, Location = TxTB_Location.Text };
                    OnToDoCreated.Invoke(this, new ToDoItemEventArgs(pwTodo));
                }
                else
                {
                    HomeWork hwTodo = new HomeWork(TxtB_Name.Text, DTP_DueDate.Value) { ExecutorName = TxTB_Executor.Text, Description = RTB_Description.Text, Location = TxTB_Location.Text };
                    OnToDoCreated.Invoke(this, new ToDoItemEventArgs(hwTodo));
                }
            }
            else
            {
                MessageBox.Show("Type and Name should be filled in");
            }

            this.Close();
        }
    }
}
