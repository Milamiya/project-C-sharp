using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_Nuocsx
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Nuocsx] where manuoc=N'" + loai + "'");
        }
        public void themmoil(EC_tb_Nuocsx l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Nuocsx
                      (manuoc, tennuoc) VALUES   (N'" + l.MANUOC + "',N'" + l.TENNUOC + "')");
        }
        public void xoal(EC_tb_Nuocsx l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Nuocsx] WHERE [manuoc] = N'" + l.MANUOC + "'");
        }

        public void sual(EC_tb_Nuocsx l)
        {
            string sql = (@"UPDATE tb_Nuocsx
            SET tennuoc =N'" + l.TENNUOC + "' where  manuoc =N'" + l.MANUOC + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
