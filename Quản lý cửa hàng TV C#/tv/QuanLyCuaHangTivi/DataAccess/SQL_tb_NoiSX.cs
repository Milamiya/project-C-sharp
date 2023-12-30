using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_NoiSX
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrasx(string masx)
        {
            return cn.kiemtra("select count(*) from [tb_NoiSX] where manoisx=N'" + masx + "'");
        }
        public void themmoisx(EC_tb_NoiSX sx)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_NoiSX
                      (manoisx, tennoisx) VALUES   (N'" + sx.MANOISX + "',N'" + sx.TENNOISX + "')");
        }
        public void xoasx(EC_tb_NoiSX sx)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_NoiSX] WHERE [manoisx] = N'" + sx.MANOISX + "'");
        }

        public void suasx(EC_tb_NoiSX sx)
        {
            string sql = (@"UPDATE tb_NoiSX
            SET tennoisx =N'" + sx.TENNOISX + "' where  manoisx =N'" + sx.MANOISX + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
