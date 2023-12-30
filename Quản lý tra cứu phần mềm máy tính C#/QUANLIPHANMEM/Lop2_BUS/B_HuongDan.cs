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
   public class B_HuongDan
    {
       D_HuongDan objHD= new D_HuongDan();
        public DataTable gettb_HuongDan() // hình như dư
        {
            return objHD.getAllTable("HUONGDAN").Tables["HUONGDAN"];
        }
        public DataTable gettbHuongDan_Theo_maHD(string strmaHD)
        {
            return objHD.getHuongDan_theo_maHD(strmaHD).Tables["HUONGDAN"];
        }
        public DataTable gettbHuongDan_Theo_maphanmem(string strmapm)
        {
            return objHD.getHuongDan_theo_maphanmem(strmapm).Tables["HUONGDAN"];
        }

        public void CapNhattb_HUONGDAN(DataTable tbTable)
        {
            objHD.CapNhatDuLieu(tbTable, "HUONGDAN");
        }
    }
}
