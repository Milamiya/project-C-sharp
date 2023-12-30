using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Khachhang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtra(string tenkh)
        {
            return cn.kiemtra("select count(*) from [tb_Khachhang] where tenkh=N'" + tenkh + "'");
        }
        public void themmoi(EC_tb_Khachhang q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Khachhang
                      (makh, tenkh) VALUES   (N'" + q.MAKH + "',N'" + q.TENKH + "')");
        }
        public void xoa(EC_tb_Khachhang q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Khachhang] WHERE [makh] = N'" + q.MAKH + "'");
        }

        public void sua(EC_tb_Khachhang q)
        {
            string sql = (@"UPDATE tb_Khachhang
            SET tenkh =N'" + q.TENKH + "' where  makh =N'" + q.MAKH + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
