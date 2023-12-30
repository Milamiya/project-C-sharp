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
  public class B_LoaiPM
  {

      D_LoaiPM objLoaiPM = new D_LoaiPM();
//       public DataTable gettb_LoaiPM() // hình như dư
//       {
//          return objLoaiPM.getAllTable("LOAIPM").Tables["LOAIPM"];
//       }
      public DataTable gettbLoaiPM_Theo_maHDH(string strmaHDH)
      {
          return objLoaiPM.getLoaiPM_theo_maHDH(strmaHDH).Tables["lOAIPM"];
      }
      public DataTable gettbLoaiPM_Theo_maPL(string strmaPL)
      {
          return objLoaiPM.getLoaiPM_theo_maPL(strmaPL).Tables["lOAIPM"];
      }

      public void CapNhattb_LoaiPM(DataTable tbTable)
      {
          objLoaiPM.CapNhatDuLieu(tbTable, "LOAIPM");
      }
      public bool kiemtratrung(string strdieukien) //Kiểm Tra Trùng Mã Phần Mềm
      {
          return objLoaiPM.kiemtratrung("LOAIPM", "MaPL", strdieukien);
      }
  }
}
