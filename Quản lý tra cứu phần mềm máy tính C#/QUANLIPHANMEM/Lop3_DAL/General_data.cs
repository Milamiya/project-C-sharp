using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using Enities;

namespace Lop3_DAL
{
    public class General_data
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=QLSP.accdb");

        public DataSet getAllTable(string strTableName)
        {
            OleDbCommand cmd = new OleDbCommand("select * from " + strTableName, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, strTableName);
            return ds;
        }
        public DataSet get_timkiem(string strtable, string strtencot, string strtimkiem)  //Tìm Kiếm
        {

            OleDbCommand cmd = new OleDbCommand("select * from " + strtable + " where " + strtencot + " like '%" + strtimkiem + "%'", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, strtable);
            return ds;
        }
        public int CapNhatDuLieu(DataTable tbTable, string strTablename) //cập nhật dữ liệu
        {
            OleDbCommand cmd = new OleDbCommand("select * from " + strTablename + " where 1=7", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, strTablename);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
           return da.Update(tbTable);

        }
      
    }
}

    