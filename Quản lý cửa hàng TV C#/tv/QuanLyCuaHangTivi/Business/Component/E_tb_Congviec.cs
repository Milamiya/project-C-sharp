using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_Congviec
    {
        SQL_tb_Congviec cvsql = new SQL_tb_Congviec();
        public void themoicv(EC_tb_CongViec cv)
        {
            if (!cvsql.kiemtraCV(cv.MACV))
            {
                cvsql.themmoiCV(cv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacv(EC_tb_CongViec cv)
        {
            cvsql.suaCV(cv);
        }
        public void xoacv(EC_tb_CongViec cv)
        {
            cvsql.xoaCV(cv);
        }
    }
}
