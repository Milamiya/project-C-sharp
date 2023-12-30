using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_Nuocsx
    {
        SQL_tb_Nuocsx nccsql = new SQL_tb_Nuocsx();
        public void themoincc(EC_tb_Nuocsx ncc)
        {
            if (!nccsql.kiemtral(ncc.MANUOC))
            {
                nccsql.themmoil(ncc);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suancc(EC_tb_Nuocsx ncc)
        {
            nccsql.sual(ncc);
        }
        public void xoancc(EC_tb_Nuocsx ncc)
        {
            nccsql.xoal(ncc);
        }
    }
}
