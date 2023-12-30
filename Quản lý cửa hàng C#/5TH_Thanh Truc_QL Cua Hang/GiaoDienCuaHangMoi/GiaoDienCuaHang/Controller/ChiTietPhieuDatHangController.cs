using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using GiaoDienCuaHang.DataLayer;

namespace GiaoDienCuaHang.Controller
{
   public class ChiTietPhieuDatHangController
    {
       ChiTietPhieuDatHangData data = new ChiTietPhieuDatHangData();
       HangHoaController CTRLHH = new HangHoaController();
       public void HienThiListView(ListView listview,string strMaPDH)
       {
           listview.Items.Clear();
           DataTable dataTB = data.LayDS_CT_PDH(strMaPDH);
           dataTB.Rows.Clear();
           dataTB = data.LayDS_CT_PDH(strMaPDH);
           int n = 0;
           foreach (DataRow row in dataTB.Rows)
           {
               ListViewItem item = new ListViewItem();
               n++;
               item.Text = n.ToString();
               item.SubItems.Add(row["MAPHIEUDATHANG"].ToString());
               item.SubItems.Add(CTRLHH.LoadListViewSubItemHangHoa(row["MASP"].ToString()));
               item.SubItems.Add(row["SOLUONG"].ToString());
               item.Tag = row;

               listview.Items.Add(item);
           }
       }
    }
}
