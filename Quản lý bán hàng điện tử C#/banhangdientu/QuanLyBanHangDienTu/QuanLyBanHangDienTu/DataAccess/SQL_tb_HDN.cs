using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_HDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDN(string mahdn)
        {
            return cn.kiemtra("select count(*) from [tb_HDN] where sohdn=N'" + mahdn + "'");
        }
        public void themmoiHDN(EC_tb_HDN hdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_HDN
                      (sohdn, manv,ngaynhap,mancc,tongtien) VALUES   (N'" + hdn.SOHDN + "',N'" + hdn.MANV + "',N'" + hdn.NGAYNHAN + "',N'" + hdn.MANCC + "',N'" + hdn.TONGTIEN + "')");
        }
        public void xoaHDN(EC_tb_HDN hdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDN] WHERE [sohdn] = N'" + hdn.SOHDN + "'");
        }

        public void suaHDN(EC_tb_HDN hdn)
        {
            string sql = (@"UPDATE tb_HDN
            SET manv =N'" + hdn.MANV + "',ngaynhap =N'" + hdn.NGAYNHAN + "',mancc =N'" + hdn.MANCC + "' where  sohdn =N'" + hdn.SOHDN + "'");
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
        //load mã nhà cung cấp
        public void loadmancc(ComboBox macc)
        {
            cn.LoadLenCombobox(macc, "SELECT     mancc FROM tb_NCC", 0);
        }
        public string Loadtenncc(string tencc, string macc)
        {
            tencc = cn.LoadLable("SELECT [tenncc] From [tb_NCC] where mancc= N'" + macc + "'");
            return tencc;
        }
    }
}
