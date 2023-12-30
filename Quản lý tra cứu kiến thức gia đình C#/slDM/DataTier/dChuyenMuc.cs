using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Data;
using System.Data.OleDb;
namespace DataTier
{
    public class dChuyenMuc:General_Data
    {
        public int ThemChuyenMuc(string Tencm)
        {
            openCn();
            OleDbCommand cm = new OleDbCommand("insert into ChuyenMuc(Tencm) values(@tencm)",cn);
            cm.Parameters.Add("@tencm", OleDbType.BSTR).Value = Tencm;
            int n = cm.ExecuteNonQuery();
            closeCn();
            return n;
        }
    }
}
