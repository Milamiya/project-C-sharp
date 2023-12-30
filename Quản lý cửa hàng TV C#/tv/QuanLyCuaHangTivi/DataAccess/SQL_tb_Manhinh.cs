using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_Manhinh
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraMH(string mamh)
        {
            return cn.kiemtra("select count(*) from [tb_Manhinh] where mamanhinh=N'" + mamh + "'");
        }
        public void themmoiMH(EC_tb_Manhinh mh)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Manhinh
                      (mamanhinh, tenmanhinh) VALUES   (N'" + mh.MAMANHINH + "',N'" + mh.TENMANHINH + "')");
        }
        public void xoaMH(EC_tb_Manhinh mh)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Manhinh] WHERE [mamanhinh] = N'" + mh.MAMANHINH + "'");
        }

        public void suaMH(EC_tb_Manhinh mh)
        {
            string sql = (@"UPDATE tb_Manhinh
            SET tenmanhinh=N'" + mh.TENMANHINH + "' where  mamanhinh =N'" + mh.MAMANHINH + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
