using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_Congviec
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraCV(string macv)
        {
            return cn.kiemtra("select count(*) from [tb_Congviec] where macv=N'" + macv + "'");
        }
        public void themmoiCV(EC_tb_CongViec cv)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Congviec
                      (macv, tencv) VALUES   (N'" + cv.MACV + "',N'" + cv.TENCV + "')");
        }
        public void xoaCV(EC_tb_CongViec cv)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Congviec] WHERE [macv] = N'" + cv.MACV + "'");
        }

        public void suaCV(EC_tb_CongViec cv)
        {
            string sql = (@"UPDATE tb_Congviec
            SET tencv =N'" + cv.TENCV + "' where  macv =N'" + cv.MACV + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
