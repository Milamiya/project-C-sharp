using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_Calam
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Calam] where maca=N'" + loai + "'");
        }
        public void themmoil(EC_tb_Calam l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Calam
                      (maca, tenca) VALUES   (N'" + l.MACA + "',N'" + l.TENCA + "')");
        }
        public void xoal(EC_tb_Calam l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Calam] WHERE [maca] = N'" + l.MACA + "'");
        }

        public void sual(EC_tb_Calam l)
        {
            string sql = (@"UPDATE tb_Calam
            SET tenca =N'" + l.TENCA + "' where  maca =N'" + l.MACA + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
