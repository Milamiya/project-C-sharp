using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_CTHDN
    {
        SQL_tb_CTHDN cthdnsql = new SQL_tb_CTHDN();
        public void themoicthdn(EC_tb_CTHDN cthdn)
        {
            if (!cthdnsql.kiemtracthdn(cthdn.SOHDN, cthdn.MAHANG))
            {
                cthdnsql.themmoicthdn(cthdn);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacthdn(EC_tb_CTHDN cthdn)
        {
            cthdnsql.suacthdn(cthdn);
        }
        public void xoacthdn(EC_tb_CTHDN cthdn)
        {
            cthdnsql.xoacthdn(cthdn);
        }
        //load hóa đơn
        public void loadmahd(ComboBox cbhd)
        {
            cthdnsql.loadmahdn(cbhd);
        }
        //load hóa đơn
        public void loadmasp(ComboBox cbsp)
        {
            cthdnsql.loadmasp(cbsp);
        }
        public string loadtensp(string Tensp, string Masp)
        {
            Tensp = cthdnsql.Loadtenhang(Tensp, Masp);
            return Tensp;
        }
    }
}
