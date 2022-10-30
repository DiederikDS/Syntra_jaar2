using MyTodoList.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTodoList
{
    public partial class AddTodoForm : Form
    {
        public delegate void TodoItemEventHandler(object sender, TodoItemEventArgs e);
        public event TodoItemEventHandler TodoItemCreated;

        public AddTodoForm()
        {
            InitializeComponent();
        }

        private void SendTodo()
        {
            if (dtpDueDate.Value <= DateTime.Now)
            {
                throw new Exception("DueDate must be set later than today.");
            }

            TodoItem item;
            if (cmbType.SelectedIndex == 0)
            {
                item = new HomeWork();
            }
            else
            {
                item = new OutdoorWork();
            }

            item.Description = txtDescription.Text;
            item.Location = txtLocation.Text;
            item.ExecuterName = txtExecuter.Text;
            item.DueDate = dtpDueDate.Value;
            item.Name = txtName.Text;

            TodoItemCreated?.Invoke(this, new TodoItemEventArgs(item));
        }

        private void btnAddAndClose_Click(object sender, EventArgs e)
        {
            SendTodo();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SendTodo();
        }
    }
}
