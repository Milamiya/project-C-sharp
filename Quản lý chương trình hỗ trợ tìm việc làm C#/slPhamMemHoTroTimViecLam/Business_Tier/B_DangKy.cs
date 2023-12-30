using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entities;
using Data_Tier;

namespace Business_Tier
{
    public class B_DangKy
    {
        D_DangKy obj = new D_DangKy();
        public int  Dangkytaikhoan(E_DangKy dk)
        {
            return obj.DangKy(dk);
            
        }
        public int CapnhatTK(E_DangKy dk)
        {
            return obj.CapNhatTK(dk);

        }
    }
}
