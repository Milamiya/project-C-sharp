using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using Enities;

namespace Lop3_DAL
{
    public class D_PhanMem : General_data
    {
        private OleDbConnection cnn;
        private General_data objGeneral_data = new General_data();

        public DataSet getPhanMem_theo_maPL(string strPL)
        {
            OleDbCommand cmd = new OleDbCommand("select * from PHANMEM where MaPL = @MaPL", con);
            cmd.Parameters.Add("@MaPL", OleDbType.BSTR).Value = strPL;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "PHANMEM");
            return ds;
        }
        public DataSet getPhanMem_theo_maPM(string strPM)
        {
            OleDbCommand cmd = new OleDbCommand("select * from PHANMEM where MaPhanMem= @MaPhanMem", con);
            cmd.Parameters.Add("@MaPhanMem", OleDbType.BSTR).Value = strPM;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "PHANMEM");
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