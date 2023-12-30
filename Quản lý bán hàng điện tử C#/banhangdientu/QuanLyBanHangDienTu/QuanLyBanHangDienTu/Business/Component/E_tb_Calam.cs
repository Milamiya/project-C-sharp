using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_Calam
    {
        SQL_tb_Calam Lsql = new SQL_tb_Calam();
        public void themoil(EC_tb_Calam l)
        {
            if (!Lsql.kiemtral(l.MACA))
            {
                Lsql.themmoil(l);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sual(EC_tb_Calam l)
        {
            Lsql.sual(l);
        }
        public void xoal(EC_tb_Calam l)
        {
            Lsql.xoal(l);
        }
    }
}
