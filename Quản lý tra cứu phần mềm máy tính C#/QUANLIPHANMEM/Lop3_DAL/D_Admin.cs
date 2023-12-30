using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using Enities;

namespace Lop3_DAL
{
    public class D_Admin : General_data
    {
        public bool Log_In(String id, String MATKHAU)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select count(*) from ADMIN where id=@id and MATKHAU=@MATKHAU", con);
            cmd.Parameters.Add("@id", OleDbType.Char).Value = id;
            cmd.Parameters.Add("@MATKHAU", OleDbType.Char).Value = MATKHAU;
            if ((int)cmd.ExecuteScalar() > 0)
                return true;
            else
                return false;
        }
    }
}
