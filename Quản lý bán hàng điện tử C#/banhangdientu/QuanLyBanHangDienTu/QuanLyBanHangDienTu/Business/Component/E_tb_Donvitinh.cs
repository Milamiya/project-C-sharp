using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_Donvitinh
    {
        SQL_tb_Donvitinh Lsql = new SQL_tb_Donvitinh();
        public void themoil(EC_tb_Donvitinh l)
        {
            if (!Lsql.kiemtral(l.MADONVI))
            {
                Lsql.themmoil(l);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sual(EC_tb_Donvitinh l)
        {
            Lsql.sual(l);
        }
        public void xoal(EC_tb_Donvitinh l)
        {
            Lsql.xoal(l);
        }
    }
}
