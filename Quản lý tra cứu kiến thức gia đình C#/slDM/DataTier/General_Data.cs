using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Entities;

namespace DataTier
{
    public class General_Data
    {
        //public OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=True");
        public OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DatabaseMV.mdb");
        public void openCn()
        {
            if (cn != null && cn.State == ConnectionState.Closed)
                cn.Open();
        }
        public void closeCn()
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }
        public DataSet GetDataTable(string tblName)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from " + tblName, cn);
            DataSet ds = new DataSet();
            da.Fill(ds,tblName);
            return ds;
        }
    }
}
