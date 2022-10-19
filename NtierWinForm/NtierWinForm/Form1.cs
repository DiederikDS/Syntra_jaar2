using LogicTier;

namespace NtierWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_GetDirecotryItems_Click(object sender, EventArgs e)
        {
            DirectoryExplorer de = new DirectoryExplorer();
            de.GetItems(@"C:\Users\Diederik\Desktop");

            foreach (var i in de.Items)
            {
                MessageBox.Show(i);
            }
        }
    }
}