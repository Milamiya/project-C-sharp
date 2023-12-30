using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class CTHopDongMuaThuocCTRL
    {
        CTHopDongMuaThuocDATA data = new CTHopDongMuaThuocDATA();
        public void HienThiListViewCTHopDong(ListView lvw,String ctHDMT)
        {
            lvw.Items.Clear();
            DataTable tbl = data.LayDSCTHopDongMuaThuoc(ctHDMT);
            tbl.Clear();
            tbl = data.LayDSCTHopDongMuaThuoc(ctHDMT);
            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAHD"].ToString());
                item.SubItems.Add(row["MATHUOC"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());
                item.SubItems.Add(row["DONGIA"].ToString());
                item.SubItems.Add(row["THANHTIEN"].ToString());

                item.Tag = row;

                lvw.Items.Add(item);
            }
            

        }
        public void Luu_CTHDMT(ListView list)
        {
            DataTable tb = data.LayDSCTHopDongMuaThuoc();
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
