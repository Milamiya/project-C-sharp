using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using QuanLyHoSoCongChuc.Controller;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class ThamSoData
    {
        //DataService ds = new DataService();
        //public int LayGiaTri(string ten)
        //{
        //    OleDbCommand cmd = new OleDbCommand("select * from THAM_SO where TEN=@ten");
        //    cmd.Parameters.Add("ten", OleDbType.Char).Value = ten;
        //    ds.Load(cmd);
        //    DataTable table = ds;
        //    DataRow row = table.Rows[0];
        //    return Convert.ToInt32(row["GIA_TRI"].ToString());

        //}
        //public void TangGiaTri(string ten)
        //{
        //    OleDbCommand cmd = new OleDbCommand("update THAM_SO SET GIA_TRI = GIA_TRI + 1 where TEN=@ten");
        //    cmd.Parameters.Add("ten", OleDbType.VarChar).Value = ten;
        //    ds.ExecuteNonQuery(cmd);
        //}

    }
}
