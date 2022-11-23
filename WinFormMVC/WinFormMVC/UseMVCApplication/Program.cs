using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Collections;
using  WinFormMVC.Model;
using  WinFormMVC.View;
using  WinFormMVC.Controller;


namespace UseMVCApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsersView view = new UsersView();
            view.Visible = false;

            // Add some dummy data
            IList users = new ArrayList();
            users.Add(new User("Grote",   "Smurf",         "122",    "Smurfenland"));
            users.Add(new User("Lees",     "Smurf",         "123",    "Smurfenland"));
            users.Add(new User("Iron",    "Man",        "124",    "Avenger"));
            users.Add(new User("C#",       "Programmer",       "125",    "Elite"));
            users.Add(new User("Clark",      "Kent",       "126",    "Superman"));
            users.Add(new User("Spider",     "Man",        "127",    "Avenger"));
            
            

            UsersController controller = new UsersController(view, users);
            controller.LoadView();
            view.ShowDialog();
        }
    }
}
