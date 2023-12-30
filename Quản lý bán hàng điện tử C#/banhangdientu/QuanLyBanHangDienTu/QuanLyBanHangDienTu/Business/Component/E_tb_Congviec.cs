using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_Congviec
    {
        SQL_tb_Congviec Lsql = new SQL_tb_Congviec();
        public void themoil(EC_tb_Congviec l)
        {
            if (!Lsql.kiemtral(l.MACV))
            {
                Lsql.themmoil(l);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sual(EC_tb_Congviec l)
        {
            Lsql.sual(l);
        }
        public void xoal(EC_tb_Congviec l)
        {
            Lsql.xoal(l);
        }
    }
}
