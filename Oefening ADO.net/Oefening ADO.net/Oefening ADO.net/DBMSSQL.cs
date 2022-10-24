using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Oefening_ADO.net
{
    public class DBMSSQL
    {
        //This is the data access layer

        private SqlConnection _Connection;
            
        public  DBMSSQL() {
            ConnectionString = "Server=localhost\\sqlexpress";
            _Connection = new SqlConnection();
        }

        public string ConnectionString { get; set; }

        public bool Connect() {
            //_Connection is een instantie van SqlConnection, dit erft van DbConnection, en hier wordt de ConnectionString gedefinieerd.
            _Connection.ConnectionString= ConnectionString;
            _Connection.Open();
            if (_Connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public ConnState Status()
        {
            switch (_Connection.State)
            {
                case System.Data.ConnectionState.Open:
                    return ConnState.IsOpen;
                case System.Data.ConnectionState.Closed:
                    return ConnState.IsClosed;
                default:
                    return ConnState.IsClosed;
            }
        }

        public enum ConnState
        {
            IsOpen,
            IsClosed
        }

        public void Close()
        {
            _Connection.Close();
        }

        public void ExecuteSQL(string sql) {
            //_Connection = new SqlConnection(ConnectionString);
            Microsoft.Data.SqlClient.SqlCommand cmd = _Connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public System.Data.DataTable GetDT(string sql)
        {
            _Connection = new SqlConnection(ConnectionString);
            System.Data.DataTable dt = new System.Data.DataTable();
            Microsoft.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter();
            Microsoft.Data.SqlClient.SqlCommand cmd = _Connection.CreateCommand();
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

    }
}
