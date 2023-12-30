using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Windows.Forms;


namespace QuanLyCafe.DataAccess
{
    class SQL_tb_CTHDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtratb_CTHDN(string mahdn, string masp)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDN] where mahdn=N'" + mahdn + "'and masp=N'" + masp + "'");
        }
        public void themmoicthdb(EC_tb_CTHDN cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDN
                      (mahdn, masp, soluong, dongia, thanhtien, khuyenmai) VALUES   (N'" + cthdb.MAHDN + "',N'" + cthdb.MASP + "',N'" + cthdb.SOLUONG + "',N'" + cthdb.DONGIA + "',N'" + cthdb.THANHTIEN + "',N'" + cthdb.KHUYENMAI + "')");
        }
        public void xoacthdb(EC_tb_CTHDN cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDN] WHERE  mahdn=N'" + cthdb.MAHDN + "' and masp=N'" + cthdb.MASP + "' ");
        }

        public void suacthdb(EC_tb_CTHDN cthdb)
        {
            string sql = (@"UPDATE tb_CTHDN
            SET soluong =N'" + cthdb.SOLUONG + "', khuyenmai = N'" + cthdb.KHUYENMAI + "', thanhtien = N'" + cthdb.THANHTIEN + "' where  mhdb=N'" + cthdb.MAHDN + "' and masp=N'" + cthdb.MASP + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void loadmasp(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT     masp FROM tb_Sanpham", 0);
        }
        public string Loadtenhang(string tenhang, string masp)
        {
            tenhang = cn.LoadLable("SELECT [masp] From [tb_Sanpham] where masp= N'" + masp + "'");
            return tenhang;
        }
        //load THD
        public void loadmahd(ComboBox mahdn)
        {
            cn.LoadLenCombobox(mahdn, "SELECT     mahdn FROM tb_HDN", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [gianhap] From [tb_Sanpham] where masp= N'" + masp + "'");
            return dg;
        }
    }
}
