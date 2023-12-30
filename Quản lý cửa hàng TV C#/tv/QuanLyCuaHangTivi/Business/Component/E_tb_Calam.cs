using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_Calam
    {
        SQL_tb_Calam clsql = new SQL_tb_Calam();
        public void themoicl(EC_tb_Calam cl)
        {
            if (!clsql.kiemtraCL(cl.MACA))
            {
                clsql.themmoiCL(cl);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacl(EC_tb_Calam cl)
        {
            clsql.suaCL(cl);
        }
        public void xoacl(EC_tb_Calam cl)
        {
            clsql.xoaCL(cl);
        }
    }
}
