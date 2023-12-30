using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_Mau
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtram(string mau)
        {
            return cn.kiemtra("select count(*) from [tb_Mau] where mamau=N'" + mau + "'");
        }
        public void themmoim(EC_tb_Mau m)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Mau
                      (mamau, tenmau) VALUES   (N'" + m.MAMAU + "',N'" + m.TENMAU + "')");
        }
        public void xoam(EC_tb_Mau m)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Mau] WHERE [mamau] = N'" + m.MAMAU + "'");
        }

        public void suam(EC_tb_Mau m)
        {
            string sql = (@"UPDATE tb_Mau
            SET tenmau =N'" + m.TENMAU + "' where  mamau =N'" + m.MAMAU + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
