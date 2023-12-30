using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
	class E_tb_Tivi
	{
        SQL_tb_Tivi tvsql = new SQL_tb_Tivi();
        public void themoitv(EC_tb_Tivi tv)
        {
            if (!tvsql.kiemtraTV(tv.MATIVI))
            {
                tvsql.themmoiTV(tv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suatv(EC_tb_Tivi tv)
        {
            tvsql.suatv(tv);
        }
        public void xoatv(EC_tb_Tivi tv)
        {
            tvsql.xoaTV(tv);
        }


        //load hsx
        public void loadmahsx(ComboBox cbhsx)
        {
            tvsql.loadmaHSX(cbhsx);
        }
        public string loadtenhsx(string Tenhsx, string Mahsx)
        {
            Tenhsx = tvsql.LoadtenHSX(Tenhsx, Mahsx);
            return Tenhsx;
        }
        //load kiểu
        public void loadkieu(ComboBox cbmk)
        {
            tvsql.loadmaK(cbmk);
        }
        public string loadtenk(string Tenmk, string Mamk)
        {
            Tenmk = tvsql.Loadtenk(Tenmk, Mamk);
            return Tenmk;
        }
        //load màu
        public void loadmam(ComboBox cbm)
        {
            tvsql.loadmam(cbm);
        }
        public string loadtenm(string Tenmau, string Mamau)
        {
            Tenmau = tvsql.Loadtenm(Tenmau,Mamau);
            return Tenmau;
        }

        //load nơi sản xuất
        public void loadmasx(ComboBox cbsx)
        {
            tvsql.loadmasx(cbsx);
        }
        public string loadtensx(string Tensx, string Masx)
        {
            Tensx = tvsql.Loadtensx(Tensx, Masx);
            return Tensx;
        }
        //load mã màn hinh
        public void loadmaMH(ComboBox cbmh)
        {
            tvsql.loadmaMH(cbmh);
        }
        public string loadtenMH(string Tenmh, string Mamh)
        {
            Tenmh = tvsql.LoadtenMH(Tenmh, Mamh);
            return Tenmh;
        }
        //load co man hinh
        public void loadcmh(ComboBox cbcmh)
        {
            tvsql.loadmaC(cbcmh);
        }
	}
}
