using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_CTHDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtracthdb(string shdb, string masp)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDB] where sohdb=N'" + shdb + "' and mahang=N'" + masp + "' ");
        }
        public void themmoicthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDB
                      (sohdb, mahang, soluong, giamgia, thanhtien) VALUES   (N'" + cthdb.SOHDB + "',N'" + cthdb.MAHANG + "',N'" + cthdb.SOLUONG + "',N'" + cthdb.GIAMGIA + "',N'" + cthdb.THANHTIEN + "')");
        }
        public void xoacthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDB] WHERE  sohdb=N'" + cthdb.SOHDB + "' and mahang=N'" + cthdb.MAHANG + "' ");
        }

        public void suacthdb(EC_tb_CTHDB cthdb)
        {
            string sql = (@"UPDATE tb_CTHDB
            SET soluong =N'" + cthdb.SOLUONG + "', giamgia = N'" + cthdb.GIAMGIA + "', thanhtien = N'" + cthdb.THANHTIEN + "' where  sohdb=N'" + cthdb.SOHDB + "' and masp=N'" + cthdb.MAHANG + "'");
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
        public void loadmahd(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT     sohdb FROM tb_HDB", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [dongiaban] From [tb_Hanghoa] where mahang= N'" + masp + "'");
            return dg;
        }
    }
}
