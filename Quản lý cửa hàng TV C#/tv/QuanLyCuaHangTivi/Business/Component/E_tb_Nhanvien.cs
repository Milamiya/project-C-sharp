using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
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
        //load ca làm
        public void loadmaca(ComboBox cbca)
        {
            nvsql.loadmaca(cbca);
        }
        public string loadtenca(string Tenca, string Maca)
        {
            Tenca = nvsql.Loadtenca(Tenca, Maca);
            return Tenca;
        }
    }
}
