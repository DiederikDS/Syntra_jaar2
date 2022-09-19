using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PhoneBook.Classes;


namespace PhoneBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Phonebook Book = new Phonebook();

        //Populate the dropdown with items from the PhoneBook.phones list
        public void AddNumbersToCB()
        {
            CBPhoneNumbers.Items.Clear();

            foreach (Phone phone in Book.Phones)
            {
                CBPhoneNumbers.Items.Add(phone.Number);
            }
        }

        private void BtnAddNumber_Click(object sender, RoutedEventArgs e)
        {
            
            bool duplicate = false;

            //Check if new number textbox is not empty.
            if (TxtBNewNumber.Text != "")
            {
                //Check if value in textbox is unique.
                foreach (Phone p in Book.Phones)
                {
                    if (p.Number == TxtBNewNumber.Text)
                    {
                        duplicate = true;
                    }
                }
                
                if (duplicate == false)
                {
                    Phone phone = new Phone(TxtBNewNumber.Text);
                    Book.Phones.Add(phone);
                    AddNumbersToCB();
                } else
                {
                    MessageBox.Show("Phonenumber must be unique");
                }
            }
            else
            {
                MessageBox.Show("New number textbox cannot be empyt");
            }


        }

        private void BtnCall_Click(object sender, RoutedEventArgs e)
        {
            foreach (Phone p in Book.Phones)
            {
                if (p.Number == CBPhoneNumbers.SelectedItem)
                {
                    Book.Called += p.Call;
                }
            }

            Book.CallPhone((string)CBPhoneNumbers.Text);
        }

    }
}
