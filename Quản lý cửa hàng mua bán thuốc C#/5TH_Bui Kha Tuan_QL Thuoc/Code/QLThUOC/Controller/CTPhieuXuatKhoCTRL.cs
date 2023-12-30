using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class CTPhieuXuatKhoCTRL
    {
        CTPhieuXuatKhoDATA data = new CTPhieuXuatKhoDATA();
        public void HienThiListViewCTPhieuXuatKho(ListView lvw, String ctPhieuXuatKho)
        {
            lvw.Items.Clear();
            DataTable tbl = data.LayDSCTPhieuXuatKho(ctPhieuXuatKho);
            tbl.Clear();
            tbl = data.LayDSCTPhieuXuatKho(ctPhieuXuatKho);
            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUXK"].ToString());
                item.SubItems.Add(row["MATHUOC"].ToString());
                item.SubItems.Add(row["SOLUONG"].ToString());

                item.Tag = row;

                lvw.Items.Add(item);
            }


        }
        public void Luu_CTPhieuXuatKho(ListView list)
        {
            DataTable tb = data.LayDSCTPhieuXuatKho();
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
