using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Business.Component
{
    class E_tb_Nhanvien
    {
        SQL_tb_Nhanvien nvsql = new SQL_tb_Nhanvien();
        public void themoinv(EC_tb_Nhanvien nv)
        {
            if (!nvsql.kiemtranv(nv.MANV))
            {
                nvsql.themmoinv(nv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suanv(EC_tb_Nhanvien nv)
        {
            nvsql.suanv(nv);
        }
        public void xoanv(EC_tb_Nhanvien nv)
        {
            nvsql.xoanv(nv);
        }
        //load công việc
        public void loadmacv(ComboBox cbcv)
        {
            nvsql.loadmacv(cbcv);
        }
        public string loadtencv(string Tencv, string Macv)
        {
            Tencv = nvsql.Loadtencv(Tencv, Macv);
            return Tencv;
        }
        //load ca
        public void loadmac(ComboBox cbc)
        {
            nvsql.loadmac(cbc);
        }
        public string loadtenc(string Tenc, string Mac)
        {
            Tenc = nvsql.Loadtenc(Tenc, Mac);
            return Tenc;
        }
    }
}
