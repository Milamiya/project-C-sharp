using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_Kieudang
    {
        SQL_tb_Kieudang kdsql = new SQL_tb_Kieudang();
        public void themoikd(EC_tb_Kieudang kd)
        {
            if (!kdsql.kiemtraKD(kd.MAKIEU))
            {
                kdsql.themmoiKD(kd);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suakd(EC_tb_Kieudang kd)
        {
            kdsql.suaKD(kd);
        }
        public void xoakd(EC_tb_Kieudang kd)
        {
            kdsql.xoaKD(kd);
        }
    }
}
