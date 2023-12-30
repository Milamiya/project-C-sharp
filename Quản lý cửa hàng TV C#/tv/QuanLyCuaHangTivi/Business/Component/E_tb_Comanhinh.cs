using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_Comanhinh
    {
        SQL_tb_Comanhinh csql = new SQL_tb_Comanhinh();
        public void themoic(EC_tb_Comanhinh mh)
        {
            if (!csql.kiemtraComh(mh.MACO))
            {
                csql.themmoiComh(mh);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void xoac(EC_tb_Comanhinh mh)
        {
            csql.xoaComh(mh);
        }
    }
}
