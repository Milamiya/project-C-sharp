using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Data_Tier;

namespace Business_Tier
{
    public class B_TimKiem
    {
        D_TimKiem obj = new D_TimKiem();
        public DataTable TimKiem_NganhNghe(string ma)
        {
            return obj.TimKiem_TheoMaNganh(ma).Tables["doanhnghiep"];
        }
    }
}
