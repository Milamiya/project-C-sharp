using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_Donvitinh
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Donvitinh] where madonvi=N'" + loai + "'");
        }
        public void themmoil(EC_tb_Donvitinh l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Donvitinh
                      (madonvi, tendonvi) VALUES   (N'" + l.MADONVI + "',N'" + l.TENDONVI + "')");
        }
        public void xoal(EC_tb_Donvitinh l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Donvitinh] WHERE [madonvi] = N'" + l.MADONVI + "'");
        }

        public void sual(EC_tb_Donvitinh l)
        {
            string sql = (@"UPDATE tb_Donvitinh
            SET tendonvi =N'" + l.TENDONVI + "' where  madonvi =N'" + l.MADONVI + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
