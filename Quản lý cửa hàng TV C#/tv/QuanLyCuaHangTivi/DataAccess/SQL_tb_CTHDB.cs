using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.DataAccess
{
    class SQL_tb_CTHDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtracthdb(string shdb, string mativi)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDB] where sohdb=N'" + shdb + "' and mativi=N'" + mativi + "' ");
        }
        public void themmoicthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDB
                      (sohdb, mativi, soluong, giamgia,thanhtien) VALUES   (N'" + cthdb.SOHDB + "',N'" + cthdb.MATIVI + "',N'" + cthdb.SOLUONG + "',N'" + cthdb.GIAMGIA + "',N'" + cthdb.THANHTIEN + "')");
        }
        public void xoacthdb(EC_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDB] WHERE  sohdb=N'" + cthdb.SOHDB + "' and mativi=N'" + cthdb.MATIVI + "' ");
        }

        public void suacthdb(EC_tb_CTHDB cthdb)
        {
            string sql = (@"UPDATE tb_CTHDB
            SET soluong =N'" + cthdb.SOLUONG + "', giamgia = N'" + cthdb.GIAMGIA + "', thanhtien = N'" + cthdb.THANHTIEN + "' where  sohdb=N'" + cthdb.SOHDB + "' and mativi=N'" + cthdb.MATIVI + "'");
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
        public void loadmahd(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT     sohdb FROM tb_HDB", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string mativi)
        {
            dg = cn.LoadLable("SELECT [dongiaban] From [tb_Tivi] where mativi= N'" + mativi + "'");
            return dg;
        }
    }
}
