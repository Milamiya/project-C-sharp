using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_HDB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDB(string mahdb)
        {
            return cn.kiemtra("select count(*) from [tb_HDB] where mahdb=N'" + mahdb + "'");
        }
        public void themmoiHDB(EC_tb_HDB hdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_HDB
                      (mahdb,ngayban, manv, makh, tongtien) VALUES   (N'" + hdb.MAHDB + "',N'" + hdb.NGAYBAN + "',N'" + hdb.MANV + "',N'" + hdb.MAKH + "',N'" + hdb.TONGTIEN + "')");
        }
        public void xoaHDB(EC_tb_HDB hdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDB] WHERE [mahdb] = N'" + hdb.MAHDB + "'");
        }

        public void suaHDB(EC_tb_HDB hdb)
        {
            string sql = (@"UPDATE tb_HDB
            SET manv =N'" + hdb.MANV + "',ngayban =N'" + hdb.NGAYBAN + "',makh =N'" + hdb.MAKH + "' where  mahdb =N'" + hdb.MAHDB + "'");
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
