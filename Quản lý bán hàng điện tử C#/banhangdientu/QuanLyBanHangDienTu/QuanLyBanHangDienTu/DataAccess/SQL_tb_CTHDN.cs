using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_CTHDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtracthdn(string shdn, string masp)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDN] where sohdn=N'" + shdn + "' and mahang=N'" + masp + "' ");
        }
        public void themmoicthdn(EC_tb_CTHDN cthdn)
        {
            string sql = (@"INSERT INTO tb_CTHDN
                      (sohdn, mahang, soluong, dongia, giamgia, thanhtien) VALUES   (N'" + cthdn.SOHDN + "',N'" + cthdn.MAHANG + "',N'" + cthdn.SOLUONG + "',N'" + cthdn.DONGIA + "',N'" + cthdn.GIAMGIA + "',N'" + cthdn.THANHTIEN + "')");
            cn.ExcuteNonQuery(sql);
        }
        public void xoacthdn(EC_tb_CTHDN cthdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDN] WHERE sohdn=N'" + cthdn.SOHDN + "' and mahang=N'" + cthdn.MAHANG + "' ");
        }

        public void suacthdn(EC_tb_CTHDN cthdn)
        {
            string sql = (@"UPDATE tb_CTHDN
            SET soluong =N'" + cthdn.SOLUONG + "', giamgia = N'" + cthdn.GIAMGIA + "', dongia = N'" + cthdn.DONGIA + "', thanhtien = N'" + cthdn.THANHTIEN + "' where sohdn=N'" + cthdn.SOHDN + "' and mahang=N'" + cthdn.MAHANG + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void loadmasp(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT     mahang FROM tb_Hanghoa", 0);
        }
        public string Loadtenhang(string tensp, string masp)
        {
            tensp = cn.LoadLable("SELECT [tenhang] From [tb_Hanghoa] where mahang= N'" + masp + "'");
            return tensp;
        }
        //load THD
        public void loadmahdn(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT     sohdn FROM tb_HDN", 0);
        }
    }
}
