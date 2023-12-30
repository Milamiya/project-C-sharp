using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
     public class Huyen_Thi_InFo
    {
         public Huyen_Thi_InFo() { }
         public Huyen_Thi_InFo(int MaHuyen,string TenHuyen) 
         {
             MaHuyen = M_MaHuyen;
             TenHuyen = M_TenHuyen;
         }

         private int M_MaHuyen;

         public int MaHuyen
         {
             get { return M_MaHuyen; }
             set { M_MaHuyen = value; }
         }

         private string M_TenHuyen;

         public string TenHuyen
         {
             get { return M_TenHuyen; }
             set { M_TenHuyen = value; }
         }
	
	
    }
}
