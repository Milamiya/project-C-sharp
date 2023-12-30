using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Enities;
using Lop3_DAL;

namespace Lop2_BUS
{
   public class B_PhanMiem
   {
       D_PhanMem objPM = new D_PhanMem();
       private string Maphanmem;

       public DataTable gettbPhanMem()
       {
           return objPM.getAllTable("PHANMEM").Tables["PHANMEM"];
       }
       public DataTable gettbPhanMem_Theo_maPhanLoai(string strmapl)
       {
           return objPM.getPhanMem_theo_maPL(strmapl).Tables["PHANMEM"];
       }

       public DataTable gettbPhanMem_Theo_maPhanMem(string strmapm)
       {
           return objPM.getPhanMem_theo_maPM(strmapm).Tables["PHANMEM"];
       }
//        public DataTable get_timkiem_PhanMem_THEO_MAPM(string strtimkiem) // kiếm mã phần mềm
//        {
//            return objPM.get_timkiem("PHANMEM", "MaPhanMem", strtimkiem).Tables["PHANMEM"];
//        }
       public DataTable get_timkiem_PhanMem_THEO_TENPHANMEM(string strtimkiem) // kiếm Tên Phần Mềm
       {
           return objPM.get_timkiem("PHANMEM", "TenPhanMem", strtimkiem).Tables["PHANMEM"];
       }
//        public DataTable get_timkiem_PhanMem_THEO_HDH(string strtimkiem) //kiếm hệ điều hành
//        {
//            return objPM.get_timkiem("PHANMEM", "HeDieuHanh", strtimkiem).Tables["PHANMEM"];
//        }
       public bool kiemtratrung(string strdieukien) //Kiểm Tra Trùng Mã Phần Mềm
       {
           return objPM.kiemtratrung("PHANMEM", "MaPhanMem", strdieukien);
       }
       public int CapNhatDULIEU(DataTable tb)
       {
        return objPM.CapNhatDuLieu(tb, "PHANMEM");
       }    
   }
}

