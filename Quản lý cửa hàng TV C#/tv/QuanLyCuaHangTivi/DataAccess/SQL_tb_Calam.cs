using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_Calam
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraCL(string macl)
        {
            return cn.kiemtra("select count(*) from [tb_Calam] where maca=N'" + macl + "'");
        }
        public void themmoiCL(EC_tb_Calam cl)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Calam
                      (maca, tenca) VALUES   (N'" + cl.MACA + "',N'" + cl.TENCA + "')");
        }
        public void xoaCL(EC_tb_Calam cl)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Calam] WHERE [maca] = N'" + cl.MACA + "'");
        }

        public void suaCL(EC_tb_Calam cl)
        {
            string sql = (@"UPDATE tb_Calam
            SET tenca =N'" + cl.TENCA + "' where  maca =N'" + cl.MACA + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
