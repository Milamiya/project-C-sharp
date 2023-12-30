using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Tier;
using Entities;
using System.Data;

namespace Business_Tier
{
   public class B_LyLich
    {
       D_LyLich LL = new D_LyLich();
       public DataTable gettblylich() { 
            return LL.getAllTable("LyLichCaNhan").Tables["LyLichCaNhan"];
       }
       public DataTable gettblylich_theoma(string tbmall) {
           return LL.getlylichtheoma(tbmall).Tables["LyLichCaNhan"];
       }
       public void capnhattb_lylich(DataTable tb) 
       {
           LL.CapNhatDuLieu(tb,"LyLichCaNhan");
       }
       public DataTable gettblylich_TheoTaiKhoan(string tentk)
       {
           return LL.getlylich_TheoTaiKhoan(tentk).Tables["LyLichCaNhan"];
       }
       public int Them_LyLich(Ly_Lich ll)
       {
           return LL.ThemLyLich(ll);
       }
       public int XoaLyLich(string ma)
       {
           return LL.XoaLyLich(ma);
       }
       public int CapNhatLyLich(Ly_Lich ll)
       {
           return LL.CapNhatLyLich(ll);
       }
    }
}
