using System.Media;

namespace Oefening_ADO.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBMSSQL db = new DBMSSQL();
            db.ConnectionString = "Server=localhost\\sqlexpress; Database=testdb;Trusted_Connection=True; User Id=tester;Password=test; TrustServerCertificate=True";
            db.Connect();

            System.Data.DataTable dt =   db.GetDT("SELECT * FROM tbl_test;");
            MessageBox.Show("Aantal rijen: " + dt.Rows.Count);
            MessageBox.Show("waarde: " + dt.Rows[0].ItemArray[1]);
            db.Close();
        }
    }
}