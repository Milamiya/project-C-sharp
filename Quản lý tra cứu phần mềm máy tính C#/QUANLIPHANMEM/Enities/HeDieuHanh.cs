using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Enities
{
   public class HeDieuHanh
    {
       public string MaHDH { get; set; }
       public string TenHDH{get;set;}
       public HeDieuHanh(){}
       public HeDieuHanh(string mahdh,string tenhdh)
       {
           MaHDH = mahdh;
           TenHDH = tenhdh;
       }
    }
}
