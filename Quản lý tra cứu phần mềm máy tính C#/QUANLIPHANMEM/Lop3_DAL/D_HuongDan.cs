using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

using Enities;

namespace Lop3_DAL
{
   public class D_HuongDan :General_data
    {
       public DataSet getHuongDan_theo_maHD(string strHD)
       {
           OleDbCommand cmd = new OleDbCommand("select * from HUONGDAN where maHD = @maHD", con);
           cmd.Parameters.Add("@maHD(", OleDbType.BSTR).Value = strHD;
           OleDbDataAdapter da = new OleDbDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.Fill(ds, "HUONGDAN");
           return ds;
       }

        public DataSet getHuongDan_theo_maphanmem(string strPM)
        {
            OleDbCommand cmd = new OleDbCommand("select * from HUONGDAN where MaPhanMem = @MaPhanMem", con);
            cmd.Parameters.Add("@MaPhanMem", OleDbType.BSTR).Value = strPM;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "HUONGDAN");
            return ds;
        }
    }
}
