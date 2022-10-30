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
            if (CBB_Type.Text != null)
            {
                if (CBB_Type.Text == "Professional work")
                {
                    ProfessionalWork pwTodo = new ProfessionalWork(TxtB_Name.Text);
                }
            }
        }
    }
}
