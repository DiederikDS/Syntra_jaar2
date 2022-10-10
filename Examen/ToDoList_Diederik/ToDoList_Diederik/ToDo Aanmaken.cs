using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList_Diederik.Classes;

namespace ToDoList_Diederik
{
    public partial class ToDo_Aanmaken : Form
    {
        ToDoItemList<ToDoItem> _items;

        public ToDo_Aanmaken(ToDoItemList<ToDoItem> items)
        {
            InitializeComponent();
            _items = items;

            List<string> soortenWerk = new List<string> { "Thuis werk", "Professioneel werk" };
            foreach (string soort in soortenWerk)
            {
                CoBx_Types.Items.Add(soort);
            }
        }





        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (TxtB_Name != null && TxtB_Location != null && TxtB_Executor != null && CoBx_Types.SelectedItem != null && DTP_Due != null && RTB_Description != null)
            {
                if (CoBx_Types.SelectedItem.ToString() == "Thuis werk")
                {
                    ThuisWerk TWToDo = new ThuisWerk(TxtB_Name.Text, RTB_Description.Text,DTP_Due.Value, TxtB_Executor.Text, TxtB_Location.Text);
                    ToDoCreatedArgs ToDoArg = new ToDoCreatedArgs(TWToDo);
                    TWToDo.ToDoItemCreated += _items.AddNewItem;
                    TWToDo.OnItemCreated(this, ToDoArg);

                }
                else
                {
                    ProfessioneelWerk PWToDo = new ProfessioneelWerk(TxtB_Name.Text, RTB_Description.Text, DTP_Due.Value, TxtB_Executor.Text, TxtB_Location.Text);
                    _items.AddItem(PWToDo);
                }
            }
        }

        private void Btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
