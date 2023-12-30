using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using Enities;

namespace Lop3_DAL
{
    public class D_HeDieuHanh : General_data
    {

        public DataSet getHeDieuHanh_theo_maHDH(string strPL)
        {
            OleDbCommand cmd = new OleDbCommand("select * from HEDIEUHANH where MaHDH = @MaHDH", con);
            cmd.Parameters.Add("@MaHDH", OleDbType.BSTR).Value = strPL;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "HeDieuHanh");
            return ds;
        }
        public bool kiemtratrung(string strtable, string strtencot, string strCondition)
        {
            OleDbCommand cmd = new OleDbCommand("select * from " + strtable + " where " + strtencot + " =@MaHDH", con);
            cmd.Parameters.Add("@MaHDH", OleDbType.BSTR).Value = strCondition;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, strtable);

            if (ds.Tables[strtable].Rows.Count == 0) // them duoc
            {
                return true;
            }
            return false;
        }

       
    }
}