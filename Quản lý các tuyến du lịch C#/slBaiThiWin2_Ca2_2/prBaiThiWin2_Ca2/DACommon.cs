using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace prBaiThiWin2_Ca2
{
    class DACommon
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb;Persist Security Info=True");

        private void thucthiSQL_KhongTraVe(string sql)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private DataSet thucthiSQL_TraVe(string sql)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand(sql, con);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet LayBang(string tenbang)
        {
            return thucthiSQL_TraVe("select * from " + tenbang);
        }

        public void ThemTuyenDL(string matuyen, string tentuyen, string songaydulich, string phipt, string phiano, string loaipt)
        {
            thucthiSQL_KhongTraVe("insert into TuyenDuLich values('" + matuyen + "','" + tentuyen + "'," + songaydulich + "," + phipt + "," + phiano + ",'" + loaipt + "')");
        }

        public DataTable LayThongTinTuyenDL(string matuyen)
        {
            return thucthiSQL_TraVe("select * from TuyenDuLich where MaTuyenDuLich='" + matuyen + "'").Tables[0];
        }
    }
}
