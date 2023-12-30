using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_HangSX
    { 
        SQL_tb_HangSX hsxsql = new SQL_tb_HangSX();
        public void themoihsx(EC_tb_Hangsx hsx)
        {
            if (!hsxsql.kiemtraHSX(hsx.MAHANG))
            {
                hsxsql.themmoiHSX(hsx);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suahsx(EC_tb_Hangsx hsx)
        {
            hsxsql.suaHSX(hsx);
        }
        public void xoahsx(EC_tb_Hangsx hsx)
        {
            hsxsql.xoaHSX(hsx);
        }
    }
}
