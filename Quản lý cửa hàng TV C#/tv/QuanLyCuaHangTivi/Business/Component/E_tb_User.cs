﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCuaHangTivi.Business.EntitiesClass;
using QuanLyCuaHangTivi.DataAccess;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Business.Component
{
    class E_tb_User
    {
        EC_tb_User ck = new EC_tb_User();
        SQL_tb_User sql = new SQL_tb_User();
        public bool kiemtrauser(string user, string pass)
        {
            ck.USERNAME = user;
            ck.PASSWORD = pass;
            return sql.Kiemtrauser(ck);
        }
    }
}
