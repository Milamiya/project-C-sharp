using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using GiaoDienCuaHang.DataLayer;

namespace GiaoDienCuaHang.Controller
{
   public class ChiTietPhieuNhanHangController
    {
       PhieuDatHangController CTRPDH = new PhieuDatHangController();
       PhieuNhanHangController ctrlPNH = new PhieuNhanHangController();
       HangHoaController ctrlHH = new HangHoaController();
       ChiTietPhieuNhanHangData data = new ChiTietPhieuNhanHangData();
       public void HienThiListView(ListView listview,string strMaPhieu)
       {
           listview.Items.Clear();
           DataTable dataTB = data.LayDS_CT_PNH(strMaPhieu);
           dataTB.Rows.Clear();
           dataTB = data.LayDS_CT_PNH(strMaPhieu);
           int n = 0;
           foreach (DataRow row in dataTB.Rows)
           {
               ListViewItem item = new ListViewItem();
               n++;
               item.Text = n.ToString();
               item.SubItems.Add(row["MAPHIEU"].ToString());
               item.SubItems.Add(ctrlHH.LoadListViewSubItemHangHoa(row["MASP"].ToString()));
               item.SubItems.Add(row["DONGIA"].ToString());
               item.SubItems.Add(row["SOLUONG"].ToString());
               item.SubItems.Add(row["THANHTIEN"].ToString());
               item.SubItems.Add(CTRPDH.LoadListViewSubItemPHIEUDATHANG(row["MAPHIEUDATHANG"].ToString()));
               item.Tag = row;

               listview.Items.Add(item);
           }
       }
    }
}
