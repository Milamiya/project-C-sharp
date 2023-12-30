using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_Mau
    {
        SQL_tb_Mau msql = new SQL_tb_Mau();
        public void themoim(EC_tb_Mau m)
        {
            if (!msql.kiemtram(m.MAMAU))
            {
                msql.themmoim(m);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suam(EC_tb_Mau m)
        {
            msql.suam(m);
        }
        public void xoam(EC_tb_Mau m)
        {
            msql.xoam(m);
        }
    }
}
