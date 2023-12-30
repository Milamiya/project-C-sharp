using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Tier;
using System.Data;

namespace Business_Tier
{
    public class B_DangNhap
    {
        General_Data obj = new General_Data();
        public DataTable getThongtindangnhap()
        {
            return obj.getAllTable("taikhoan").Tables["taikhoan"];
        }
    }
}
