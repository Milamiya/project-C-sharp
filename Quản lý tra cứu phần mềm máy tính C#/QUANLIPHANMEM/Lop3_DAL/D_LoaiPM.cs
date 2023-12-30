using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;

using Enities;
namespace Lop3_DAL


{
    public class D_LoaiPM : General_data
    {

        public DataSet getLoaiPM_theo_maHDH(string strHDH)
        {
            OleDbCommand cmd = new OleDbCommand("select * from LOAIPM where maHDH = @maHDH", con);
            cmd.Parameters.Add("@maHDH", OleDbType.BSTR).Value = strHDH;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "LOAIPM");
            return ds;
        }

        public DataSet getLoaiPM_theo_maPL(string strPL)
        {
            OleDbCommand cmd = new OleDbCommand("select * from LOAIPM where MaPL = @MaPL", con);
            cmd.Parameters.Add("@MaPL", OleDbType.BSTR).Value = strPL;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "LOAIPM");
            return ds;
        }
        public bool kiemtratrung(string strtable, string strtencot, string strCondition)
        {
            OleDbCommand cmd = new OleDbCommand("select * from " + strtable + " where " + strtencot + "=@MaPhanMem", con);
            cmd.Parameters.Add("@MaPhanMem", OleDbType.BSTR).Value = strCondition;
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