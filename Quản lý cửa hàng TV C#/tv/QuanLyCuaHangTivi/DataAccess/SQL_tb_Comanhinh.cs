using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_Comanhinh
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraComh(string mac)
        {
            return cn.kiemtra("select count(*) from [tb_Comanhinh] where maco=N'" + mac + "'");
        }
        public void themmoiComh(EC_tb_Comanhinh c)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Comanhinh
                      (maco) VALUES   (N'" + c.MACO + "')");
        }
        public void xoaComh(EC_tb_Comanhinh c)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Comanhinh] WHERE [maco] = N'" + c.MACO + "'");
        }
    }
}
