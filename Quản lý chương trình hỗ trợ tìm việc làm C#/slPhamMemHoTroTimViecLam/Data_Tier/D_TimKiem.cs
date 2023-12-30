using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Entities;

namespace Data_Tier
{
    public class D_TimKiem : General_Data
    {
        public DataSet TimKiem_TheoMaNganh(string ma)
        {

            conn.Open();
            string strSQL = "Select * From doanhnghiep Where manganhnghe =@manganhnghe";
            OleDbCommand cmd = new OleDbCommand(strSQL, conn);
            cmd.Parameters.Add("@manganhnghe", OleDbType.BSTR).Value = ma;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "doanhnghiep");
            conn.Close();
            return ds;

        }
        
    }
}
