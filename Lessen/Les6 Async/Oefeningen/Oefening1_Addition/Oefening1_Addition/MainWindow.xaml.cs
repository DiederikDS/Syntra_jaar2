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

namespace Oefening1_Addition
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

        List<int> numbers = new List<int>();

        

        delegate void SetResultCallback(int value);

        public void populate()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\diede\OneDrive\Bureaublad\Syntra_jaar2\Lessen\Les6 Async\Oefeningen\Oefening1_Addition\Oefening1_Addition\Numbers.txt");

            foreach (string line in lines)
            {
                numbers.Add(int.Parse(line));
            }
        }

        public void SetResult(int res)
        {
            if (!Dispatcher.CheckAccess())
            {
                SetResultCallback d = new SetResultCallback(SetResult);
                this.TxtB_Result.Dispatcher.Invoke(d, res);
            }
            else
            {
                TxtB_Result.Text = res.ToString();
            }

            
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                populate();

                int result = 0;

                foreach (var number in numbers)
                {
                    result += number;
                }

                SetResult(result);
            }); 
        }
    }
}
