using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_Manhinh
    {
        SQL_tb_Manhinh mhsql = new SQL_tb_Manhinh();
        public void themoimh(EC_tb_Manhinh mh)
        {
            if (!mhsql.kiemtraMH(mh.MAMANHINH))
            {
                mhsql.themmoiMH(mh);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suamh(EC_tb_Manhinh mh)
        {
            mhsql.suaMH(mh);
        }
        public void xoamh(EC_tb_Manhinh mh)
        {
            mhsql.xoaMH(mh);
        }
    }
}
