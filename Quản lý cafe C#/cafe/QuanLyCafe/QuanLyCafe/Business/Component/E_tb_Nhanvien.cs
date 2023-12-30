using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System.Windows.Forms;

namespace QuanLyCafe.Business.Component
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
        //load quê
        public void loadmaq(ComboBox cbq)
        {
            nvsql.loadmaque(cbq);
        }
        public string loadtenq(string Tenq, string Maq)
        {
            Tenq = nvsql.Loadtenq(Tenq, Maq);
            return Tenq;
        }
    }
}
