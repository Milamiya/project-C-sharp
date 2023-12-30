using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_Hanghoa
    {
        SQL_tb_Hanghoa spsql = new SQL_tb_Hanghoa();
        public void themoisp(EC_tb_Hanghoa sp)
        {
            if (!spsql.kiemtrasp(sp.MAHANG))
            {
                spsql.themmoisp(sp);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suasp(EC_tb_Hanghoa sp)
        {
            spsql.suasp(sp);
        }
        public void xoasp(EC_tb_Hanghoa sp)
        {
            spsql.xoasp(sp);
        }
        //load nhóm
        public void loadmanh(ComboBox cbnh)
        {
            spsql.loadmanh(cbnh);
        }
        public string loadtennh(string Tennh, string Manh)
        {
            Tennh = spsql.Loadtennh(Tennh, Manh);
            return Tennh;
        }
        //load loại
        public void loadmal(ComboBox cbl)
        {
            spsql.loadmal(cbl);
        }
        public string loadtenl(string Tenl, string Mal)
        {
            Tenl = spsql.Loadtenloai(Tenl, Mal);
            return Tenl;
        }
        //load dvt
        public void loadmadv(ComboBox cbdv)
        {
            spsql.loadmadv(cbdv);
        }
        public string loadtendv(string Tendv, string Madv)
        {
            Tendv = spsql.Loadtendv(Tendv, Madv);
            return Tendv;
        }
        //load cl
        public void loadmacl(ComboBox cbcl)
        {
            spsql.loadmacl(cbcl);
        }
        public string loadtencl(string Tencl, string Macl)
        {
            Tencl= spsql.Loadtencl(Tencl, Macl);
            return Tencl;
        }
        //load sx
        public void loadmasx(ComboBox cbsx)
        {
            spsql.loadmansx(cbsx);
        }
        public string loadtensx(string Tensx, string Masx)
        {
            Tensx = spsql.Loadtensx(Tensx, Masx);
            return Tensx;
        }
    }
}
