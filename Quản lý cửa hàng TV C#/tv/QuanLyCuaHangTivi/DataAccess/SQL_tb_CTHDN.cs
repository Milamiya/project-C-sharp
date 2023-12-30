using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_CTHDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtracthdn(string shdn, string mativi)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDN] where sohdn=N'" + shdn + "' and mativi=N'" + mativi + "' ");
        }
        public void themmoicthdn(EC_tb_CTHDN cthdn)
        {
            string sql = (@"INSERT INTO tb_CTHDN
                      (sohdn, mativi, soluong,dongia, giamgia,thanhtien) VALUES   (N'" + cthdn.SOHDN + "',N'" + cthdn.MATIVI + "',N'" + cthdn.SOLUONG + "',N'" + cthdn.DONGIA + "',N'" + cthdn.GIAMGIA + "',N'" + cthdn.THANHTIEN + "')");
            cn.ExcuteNonQuery(sql);
        }
        public void xoacthdn(EC_tb_CTHDN cthdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDN] WHERE sohdn=N'" + cthdn.SOHDN + "' and mativi=N'" + cthdn.MATIVI + "' ");
        }

        public void suacthdn(EC_tb_CTHDN cthdn)
        {
            string sql = (@"UPDATE tb_CTHDN
            SET soluong =N'" + cthdn.SOLUONG + "', giamgia = N'" + cthdn.GIAMGIA + "', dongia = N'" + cthdn.DONGIA + "', thanhtien = N'" + cthdn.THANHTIEN + "' where sohdn=N'" + cthdn.SOHDN + "' and mativi=N'" + cthdn.MATIVI + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void loadmasp(ComboBox mativi)
        {
            cn.LoadLenCombobox(mativi, "SELECT     mativi FROM tb_Tivi", 0);
        }
        public string Loadtenhang(string tenhang, string mativi)
        {
            tenhang = cn.LoadLable("SELECT [tentivi] From [tb_Tivi] where mativi= N'" + mativi + "'");
            return tenhang;
        }
        //load THD
        public void loadmahdn(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT     sohdn FROM tb_HDN", 0);
        }
    }
}
