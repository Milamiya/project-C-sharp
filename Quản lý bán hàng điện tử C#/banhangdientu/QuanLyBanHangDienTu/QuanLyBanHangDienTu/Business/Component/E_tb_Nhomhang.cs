using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_Nhomhang
    {
        SQL_tb_Nhomhang nccsql = new SQL_tb_Nhomhang();
        public void themoi(EC_tb_Nhomhang n)
        {
            if (!nccsql.kiemtral(n.MANHOM))
            {
                nccsql.themmoi(n);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suan(EC_tb_Nhomhang ncc)
        {
            nccsql.sua(ncc);
        }
        public void xoa(EC_tb_Nhomhang n)
        {
            nccsql.xoa(n);
        }
    }
}
