using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_Khachhang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrakh(string makh)
        {
            return cn.kiemtra("select count(*) from [tb_Khachhang] where makhach=N'" + makh + "'");
        }
        public void themmoikh(EC_tb_Khachhang kh)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Khachhang ( makhach, tenkhach, diachi, dienthoai) 
                        VALUES   (N'" + kh.MAKHACH + "',N'" + kh.TENKHACH + "',N'" + kh.DIACHI + "',N'" + kh.DIENTHOAI + "')");
        }
        public void xoakh(EC_tb_Khachhang kh)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Khachhang] WHERE  makhach=N'" + kh.MAKHACH + "'");
        }

        public void suakh(EC_tb_Khachhang kh)
        {
            string sql = (@"UPDATE    tb_Khachhang
                    SET tenkhach =N'" + kh.TENKHACH + "', diachi =N'" + kh.DIACHI + "', dienthoai =N'" + kh.DIENTHOAI + "' where makhach=N'" + kh.MAKHACH + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
