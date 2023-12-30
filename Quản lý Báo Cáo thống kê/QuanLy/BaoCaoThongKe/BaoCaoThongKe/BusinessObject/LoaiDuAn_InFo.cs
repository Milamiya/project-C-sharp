using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
     public class LoaiDuAn_InFo
    {
         //public LoaiDuAn_InFo() { }
         //public LoaiDuAn_InFo(int MaLoaiDuAn, string TenLoaiDuAn)
         //{
         //    MaLoaiDuAn = M_MaLoaiDuAn;
         //    TenLoaiDuAn = M_TenLoaiDuAn;
         //}
         private int M_MaLoaiDuAn;

         public int MaLoaiDuAn
         {
             get { return M_MaLoaiDuAn; }
             set { M_MaLoaiDuAn = value; }
         }

         private string M_TenLoaiDuAn;

         public string TenLoaiDuAn
         {
             get { return M_TenLoaiDuAn; }
             set { M_TenLoaiDuAn = value; }
         }
	
	
    }
}
