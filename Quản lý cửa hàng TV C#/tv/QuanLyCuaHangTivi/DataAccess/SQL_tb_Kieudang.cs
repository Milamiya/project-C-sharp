using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_Kieudang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraKD(string makd)
        {
            return cn.kiemtra("select count(*) from [tb_Kieudang] where makieu=N'" + makd + "'");
        }
        public void themmoiKD(EC_tb_Kieudang kd)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Kieudang
                      (makieu, tenkieu) VALUES   (N'" + kd.MAKIEU + "',N'" + kd.TENKIEU + "')");
        }
        public void xoaKD(EC_tb_Kieudang kd)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Kieudang] WHERE [makieu] = N'" + kd.MAKIEU + "'");
        }

        public void suaKD(EC_tb_Kieudang kd)
        {
            string sql = (@"UPDATE tb_Kieudang
            SET tenkieu =N'" + kd.TENKIEU + "' where  makieu =N'" + kd.MAKIEU + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
