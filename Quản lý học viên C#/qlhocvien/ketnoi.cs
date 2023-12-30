using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace qlhocvien
{
    class ketnoi
    {

        protected static String _connectionString = "Provider = Microsoft.Jet.OLEDB.4.0 ;" + "Data Source =" +
                               Application.StartupPath + @"\qlhocvien.mdb;" +
                               "Jet OLEDB:Database Password =;" +
                               "User ID = admin";

        public OleDbConnection data()
        {
            return new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;data source=.\\qlhocvien.mdb");
        }
        public static DataTable ExecuteQuery(String sql)
        {
            DataTable dt = new DataTable();
            OleDbConnection connect = new OleDbConnection(_connectionString);
            connect.Open();
            OleDbCommand command = connect.CreateCommand();

            command.CommandText = sql;

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        //Sử dụng cho các câu truy vấn dạng INSERT, UPDATE, DELETE
        public static void ExecuteNonQuery(String sql)
        {
            OleDbConnection connect = new OleDbConnection(_connectionString);
            connect.Open();
            OleDbCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

    }
}
