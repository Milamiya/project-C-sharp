using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using GiaoDienCuaHang.DataLayer;
using System.Windows.Forms;

namespace GiaoDienCuaHang.Controller
{
    public class ChiTietPhieuBanHangController
    {
        ChiTietPhieuBanHangData data = new ChiTietPhieuBanHangData();
        PhieuBanHangController ctrlPBH = new PhieuBanHangController();
        HangHoaController ctrlHH = new HangHoaController();
        public void HienThiListView(ListView listview,string strMAPHIEU)
        {
            listview.Items.Clear();
            DataTable dataTB = data.LayDS_CT_PBH(strMAPHIEU);
            dataTB.Rows.Clear();
            dataTB = data.LayDS_CT_PBH(strMAPHIEU);
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
                item.Tag = row;

                listview.Items.Add(item);
            }
        }
        
    }
}
