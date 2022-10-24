using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_ADO.net
{
    internal class Repo_Tbl_test : IRepositoryTest
    {

        Array GetItems()
        {
            throw new NotImplementedException();
        }

        string GetItemById(int Id)
        {
            DBMSSQL db = new DBMSSQL();
            db.ConnectionString = "Server=localhost\\sqlexpress; Database=testdb;Trusted_Connection=True; User Id=tester;Password=test; TrustServerCertificate=True";
            db.Connect();

            System.Data.DataTable dt = db.GetDT($"SELECT * FROM tbl_test ZHERE Id = {Id};");
            string result = (string)dt.Rows[0].ItemArray[1];
            db.Close();
            return result;
        }

        void AddItem(string value)
        {
            string SQl = $"INSERT INTO tbl_Test (Col1) VALUES({value})";
            DBMSSQL db = new DBMSSQL();
            db.ConnectionString = "Server=localhost\\sqlexpress; Database=testdb;Trusted_Connection=True; User Id=tester;Password=test; TrustServerCertificate=True";
            if (db.Connect())
            {
                db.ExecuteSQL(SQl);
            }
            db.Close();
        }

        void DeleteItem(int id)
        {
            string SQl = $"DELETE FROM tbl_Test WHERE Id = {id})";
            DBMSSQL db = new DBMSSQL();
            db.ConnectionString = "Server=localhost\\sqlexpress; Database=testdb;Trusted_Connection=True; User Id=tester;Password=test; TrustServerCertificate=True";
            if (db.Connect())
            {
                db.ExecuteSQL(SQl);
            }
            db.Close();
        }

    }
}
