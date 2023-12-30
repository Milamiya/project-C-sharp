using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_HDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDB(string mahdb)
        {
            return cn.kiemtra("select count(*) from [tb_HDB] where sohdb=N'" + mahdb + "'");
        }
        public void themmoiHDB(EC_tb_HDB hdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_HDB
                      (sohdb, manv, ngayban, makh, tongtien) VALUES   (N'" + hdb.SOHDB + "',N'" + hdb.MANV + "',N'" + hdb.NGAYBAN + "',N'" + hdb.MAKH + "',N'" + hdb.TONGTIEN + "')");
        }
        public void xoaHDB(EC_tb_HDB hdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDB] WHERE [sohdb] = N'" + hdb.SOHDB + "'");
        }

        public void suaHDB(EC_tb_HDB hdb)
        {
            string sql = (@"UPDATE tb_HDB
            SET sohdb =N'" + hdb.MANV + "',ngayban =N'" + hdb.NGAYBAN + "',tongtien =N'" + hdb.TONGTIEN + "',makh =N'" + hdb.MAKH + "' where  mahdb =N'" + hdb.SOHDB + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load nhân viên
        public void loadmanv(ComboBox manv)
        {
            cn.LoadLenCombobox(manv, "SELECT     manv FROM tb_Nhanvien", 0);
        }
        public string Loadtennv(string tennv, string manv)
        {
            tennv = cn.LoadLable("SELECT [tennv] From [tb_Nhanvien] where manv= N'" + manv + "'");
            return tennv;
        }
        //load mã khách hàng
        public void loadmakhach(ComboBox mak)
        {
            cn.LoadLenCombobox(mak, "SELECT     makh FROM tb_Khachhang", 0);
        }
        public string Loadtenkhach(string tenk, string mak)
        {
            tenk = cn.LoadLable("SELECT [tenkh] From [tb_Khachhang] where makh= N'" + mak + "'");
            return tenk;
        }
    }
}
