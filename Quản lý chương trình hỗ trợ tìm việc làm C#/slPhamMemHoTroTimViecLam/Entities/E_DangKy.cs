using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class E_DangKy
    {
        public string TenTK{get; set;}
        public string MatKhau{get; set;}
        public E_DangKy()
        {
 
        }
        public E_DangKy(string ten,string matkhau)
        {
            TenTK = ten;
            MatKhau = matkhau;
        }
    }
}
