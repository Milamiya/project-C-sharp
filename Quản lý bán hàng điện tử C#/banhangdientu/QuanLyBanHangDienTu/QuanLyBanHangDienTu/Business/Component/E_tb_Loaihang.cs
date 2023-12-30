using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_Loaihang
    {
        SQL_tb_Loaihang khsql = new SQL_tb_Loaihang();
        public void themoikh(EC_tb_Loaihang kh)
        {
            if (!khsql.kiemtral(kh.MALOAI))
            {
                khsql.themmoil(kh);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suakh(EC_tb_Loaihang kh)
        {
            khsql.sual(kh);
        }
        public void xoakh(EC_tb_Loaihang kh)
        {
            khsql.xoal(kh);
        }
        //load nh
        public void loadman(ComboBox cbcv)
        {
            khsql.loadman(cbcv);
        }
        public string loadtenn(string Tencv, string Macv)
        {
            Tencv = khsql.Loadtenn(Tencv, Macv);
            return Tencv;
        }
    }
}
