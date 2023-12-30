using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class CTPhieuDatHangCTRL
    {
        CTPhieuDatHangDATA data = new CTPhieuDatHangDATA();
        public void HienThiListViewCTPhieuDatHang(ListView lvw, String ctPhieuDatHang)
        {
            lvw.Items.Clear();
            DataTable tbl = data.LayDSCTPhieuDatHang(ctPhieuDatHang);
            tbl.Clear();
            tbl = data.LayDSCTPhieuDatHang(ctPhieuDatHang);
            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUDH"].ToString());
                item.SubItems.Add(row["MATHUOC"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());
               

                item.Tag = row;

                lvw.Items.Add(item);
            }


        }
        public void Luu_CTPhieuDatHang(ListView list)
        {
            DataTable tb = data.LayDSCTPhieuDatHang();
            for (int i = 0; i < list.Items.Count; i++)
            {
                ListViewItem li = list.Items[i];
                DataRow row = tb.NewRow();
                row[0] = li.SubItems[1].Text;
                row[1] = li.SubItems[2].Text;
                row[2] = li.SubItems[3].Text;                

                tb.Rows.Add(row);
            }
            data.Update();
        }
    }
}
