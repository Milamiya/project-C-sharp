using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class CTPhieuNhanHangCTRL
    {
        CTPhieuNhanHangDATA data = new CTPhieuNhanHangDATA();
        public void HienThiListViewCTPhieuNhanHang(ListView lvw, String ctPhieuNhanHang)
        {
            lvw.Items.Clear();
            DataTable tbl = data.LayDSCTPhieuNhanHang(ctPhieuNhanHang);
            //tbl.Clear();
            //tbl = data.LayDSCTPhieuNhanHang(ctPhieuNhanHang);
            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUNH"].ToString());
                item.SubItems.Add(row["MATHUOC"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());
                item.SubItems.Add(row["DONGIA"].ToString());
                item.SubItems.Add(row["THANHTIEN"].ToString());
                item.Tag = row;

                lvw.Items.Add(item);
            }


        }
        public void Luu_CTPhieuNhanHang(ListView list)
        {
            DataTable tb = data.LayDSCTPhieuNhanHang();
            for (int i = 0; i < list.Items.Count; i++)
            {
                ListViewItem li = list.Items[i];
                DataRow row = tb.NewRow();
                row[0] = li.SubItems[1].Text;
                row[1] = li.SubItems[2].Text;
                row[2] = li.SubItems[3].Text;
                row[3] = li.SubItems[4].Text;
                row[4] = li.SubItems[5].Text;
              
                tb.Rows.Add(row);
            }
            data.Update();
        }
    }
}
