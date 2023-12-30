using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class CTPhieuNhapKhoCTRL
    {
        CTPhieuNhapKhoDATA data = new CTPhieuNhapKhoDATA();
        public void HienThiListViewCTPhieuNhapKho(ListView lvw, String ctPhieuNhapKho)
        {
            lvw.Items.Clear();
            DataTable tbl = data.LayDSCTPhieuNhapKho(ctPhieuNhapKho);
            tbl.Clear();
            tbl = data.LayDSCTPhieuNhapKho(ctPhieuNhapKho);
            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUNK"].ToString());
                item.SubItems.Add(row["MATHUOC"].ToString());     
                
                item.Tag = row;

                lvw.Items.Add(item);
            }


        }
        public void Luu_CTPhieuNhapKho(ListView list)
        {
            DataTable tb = data.LayDSCTPhieuNhapKho();
            for (int i = 0; i < list.Items.Count; i++)
            {
                ListViewItem li = list.Items[i];
                DataRow row = tb.NewRow();
                row[0] = li.SubItems[1].Text;
                row[1] = li.SubItems[2].Text;               
               
                tb.Rows.Add(row);
            }
            data.Update();
        }
    }
}
