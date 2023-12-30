using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_NSX
    {
        SQL_tb_NoiSX nsxql = new SQL_tb_NoiSX();
        public void themoinsx(EC_tb_NoiSX nsx)
        {
            if (!nsxql.kiemtrasx(nsx.MANOISX))
            {
                nsxql.themmoisx(nsx);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suansx(EC_tb_NoiSX nsx)
        {
            nsxql.suasx(nsx);
        }
        public void xoansx(EC_tb_NoiSX nsx)
        {
            nsxql.xoasx(nsx);
        }
    }
}
