using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_Khachhang
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrakh(string makh)
        {
            return cn.kiemtra("select count(*) from [tb_Khachhang] where makh=N'" + makh + "'");
        }
        public void themmoikh(EC_tb_Khachhang kh)
        {
            string str=(@"INSERT INTO tb_Khachhang ( makh, tenkh, diachi, dienthoai) VALUES   (N'" + kh.MAKH + "',N'" + kh.TENKH + "',N'" + kh.DIACHI + "',N'" + kh.DIENTHOAI + "')");
            cn.ExcuteNonQuery(str);

        }
        public void xoakh(EC_tb_Khachhang kh)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Khachhang] WHERE  makh=N'" + kh.MAKH + "'");
        }

        public void suakh(EC_tb_Khachhang kh)
        {
            string sql = (@"UPDATE    tb_Khachhang
                    SET tenkh =N'" + kh.TENKH + "', diachi =N'" + kh.DIACHI + "', dienthoai =N'" + kh.DIENTHOAI + "' where makh=N'" + kh.MAKH + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
