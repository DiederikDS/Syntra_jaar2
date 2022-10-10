namespace VoorbeelExamen
{
    public partial class Form1 : Form
    {

        PhoneNetwork<Phone> phoneNetwork;
        public Form1()
        {
            InitializeComponent();
            phoneNetwork = new PhoneNetwork<Phone>();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            var phone = new Samsung() { ID = 1, Name = TxtB_Name.Text, Version = TxtB_Version.Text, Number = TxtB_Number.Text };

            phoneNetwork.AddPhone(phone);

            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            CBox_Phone.Items.Clear();

            foreach (Phone phone in phoneNetwork.Phones)
            {
                CBox_Phone.Items.Add(phone);
            }
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            if (CBox_Phone.SelectedItem != null)
            {
                var selectedPhone = CBox_Phone.SelectedItem as Phone;
                var phoneWindow = new PhoneWindow(selectedPhone, phoneNetwork);
                phoneWindow.Show();
            }
            
        }
    }
}