using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Entities;


namespace Data_Tier
{
    public class General_Data
    {
        public OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TimViecLam.accdb");
        public void OpenCnn()
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }
        public void CloseCnn()
        {
            if (conn == null || conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

        }
        public DataSet getAllTable(string strTablename)
        {
            OleDbCommand cmd = new OleDbCommand("select * from " + strTablename, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, strTablename);
            return ds;
        }
        public void CapNhatDuLieu(DataTable tbTable, string strTablename)
        {


            OleDbCommand cmd = new OleDbCommand("select * from " + strTablename + " where 1=7", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, strTablename);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            da.Update(tbTable);

        }
    }
}
