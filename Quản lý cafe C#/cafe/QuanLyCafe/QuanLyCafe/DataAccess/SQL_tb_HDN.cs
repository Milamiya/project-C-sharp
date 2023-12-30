using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using System.Windows.Forms;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_HDN
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDN(string mahdn)
        {
            return cn.kiemtra("select count(*) from [tb_HDN] where mahdn=N'" + mahdn + "'");
        }
        public void themmoiHDN(EC_tb_HDN hdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_HDN
                      (mahdn, ngaynhap, manv, mancc, tongtien) VALUES   (N'" + hdn.MAHDN + "',N'" + hdn.NGAYNHAP + "',N'" + hdn.MANV + "',N'" + hdn.MANCC + "',N'" + hdn.TONGTIEN + "')");
        }
        public void xoaHDN(EC_tb_HDN hdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDN] WHERE [mahdn] = N'" + hdn.MAHDN + "'");
        }

        public void suaHDN(EC_tb_HDN hdn)
        {
            string sql = (@"UPDATE tb_HDN
            SET manv =N'" + hdn.MANV + "',ngaynhap =N'" + hdn.NGAYNHAP + "',mancc =N'" + hdn.MANCC + "' where  mahdn =N'" + hdn.MAHDN + "'");
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
