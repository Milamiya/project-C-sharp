using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using Enities;
using Lop3_DAL; 

namespace Lop2_BUS
{
   public class B_HeDieuHanh
   {
       D_HeDieuHanh objHDH = new D_HeDieuHanh();
      
       public DataTable gettb_HEDIEUHANH()
       {
           return objHDH.getAllTable("HEDIEUHANH").Tables["HEDIEUHANH"];
       }
       public DataTable getHEDIEUHANH_theo_maHEDIEUHANH(string strmaHDH)
       {
           return objHDH.getHeDieuHanh_theo_maHDH(strmaHDH).Tables["HEDIEUHANH"];
       }
       public void capNhattb_HEDIEUHANH(DataTable tb)
       {
           objHDH.CapNhatDuLieu(tb, "HEDIEUHANH");
       }
       public bool kiemtratrung(string strdieukien) //Kiểm Tra Trùng Mã Phần Mềm
       {
           return objHDH.kiemtratrung("HEDIEUHANH", "maHDH", strdieukien);
       }

    
    }
}
