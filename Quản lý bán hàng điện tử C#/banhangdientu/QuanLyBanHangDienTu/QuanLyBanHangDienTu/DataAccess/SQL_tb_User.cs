using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyBanHangDienTu.Business.EntitiesClass;

namespace QuanLyBanHangDienTu.DataAccess
{
    class SQL_tb_User
    {
        ConnectDB cn = new ConnectDB();

        public bool Kiemtrauser(EC_tb_User user)
        {
            string sql = "select count(*) from tb_User where Username ='" + user.USERNAME + "' and Password = '" + user.PASSWORD + "'";
            return cn.KiemtraUsername(sql);
        }
    }
}
