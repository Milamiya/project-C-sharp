using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_HangSX
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHSX(string mahsx)
        {
            return cn.kiemtra("select count(*) from [tb_Hangsx] where mahang=N'" + mahsx + "'");
        }
        public void themmoiHSX(EC_tb_Hangsx hsx)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Hangsx
                      (mahang, tenhang) VALUES   (N'" + hsx.MAHANG + "',N'" + hsx.TENHANG + "')");
        }
        public void xoaHSX(EC_tb_Hangsx hsx)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Hangsx] WHERE [mahang] = N'" + hsx.MAHANG + "'");
        }

        public void suaHSX(EC_tb_Hangsx hsx)
        {
            string sql = (@"UPDATE tb_Hangsx
            SET tenhang =N'" +hsx.TENHANG + "' where  mahang =N'" + hsx.MAHANG + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
