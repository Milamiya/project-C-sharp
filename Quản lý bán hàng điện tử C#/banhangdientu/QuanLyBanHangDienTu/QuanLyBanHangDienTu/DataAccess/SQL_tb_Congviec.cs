using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_Congviec
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Congviec] where macv=N'" + loai + "'");
        }
        public void themmoil(EC_tb_Congviec l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Congviec
                      (macv, tencv) VALUES   (N'" + l.MACV + "',N'" + l.TENCV + "')");
        }
        public void xoal(EC_tb_Congviec l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Congviec] WHERE [macv] = N'" + l.MACV + "'");
        }

        public void sual(EC_tb_Congviec l)
        {
            string sql = (@"UPDATE tb_Congviec
            SET tencv =N'" + l.TENCV + "' where  macv =N'" + l.MACV + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
