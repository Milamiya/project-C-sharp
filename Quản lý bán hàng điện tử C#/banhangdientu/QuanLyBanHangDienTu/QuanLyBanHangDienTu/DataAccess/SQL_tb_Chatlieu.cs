using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_Chatlieu
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Chatlieu] where machatlieu=N'" + loai + "'");
        }
        public void themmoil(EC_tb_Chatlieu l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Chatlieu
                      (machatlieu, tenchatlieu) VALUES   (N'" + l.MACHATLIEU + "',N'" + l.TENCHATLIEU + "')");
        }
        public void xoal(EC_tb_Chatlieu l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Chatlieu] WHERE [machatlieu] = N'" + l.MACHATLIEU + "'");
        }

        public void sual(EC_tb_Chatlieu l)
        {
            string sql = (@"UPDATE tb_Chatlieu
            SET tenchatlieu =N'" + l.TENCHATLIEU + "' where  machatlieu =N'" + l.MACHATLIEU + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
