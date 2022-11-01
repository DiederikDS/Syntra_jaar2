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
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (CBB_Type.Text != null && TxtB_Name.Text != null && DTP_DueDate.Value != default)
            {
                if (CBB_Type.Text == "Professional work")
                {
                    ProfessionalWork pwTodo = new ProfessionalWork(TxtB_Name.Text, DTP_DueDate.Value) {ExecutorName = TxTB_Executor.Text, Description = RTB_Description.Text, Location = TxTB_Location.Text };
                }
                else
                {
                    HomeWork hwTodo = new HomeWork(TxtB_Name.Text, DTP_DueDate.Value) { ExecutorName = TxTB_Executor.Text, Description = RTB_Description.Text, Location = TxTB_Location.Text };
                }
            }
            else
            {
                MessageBox.Show("Type, Name and Duedate should be filled in");
            }
        }
    }
}
