using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LapPhieuThanhLiCTRL
    {
        LapPhieuThanhLiDATA data = new LapPhieuThanhLiDATA();
        public void HienThiListViewLapPhieuThanhLi(ListView lvw)
        {
            lvw.Items.Clear();

            DataTable tbl = data.LayDSPhieuThahLi();

            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUTL"].ToString());
                item.SubItems.Add(row["MAKHO"].ToString());
                item.SubItems.Add(row["NGAYTHANH"].ToString());
                item.SubItems.Add(row["MANV"].ToString());
                

                lvw.Items.Add(item);
            }
        }
        public void Update()
        {
            data.Update();
        }
        public void Luu_PhieuThanhLi(TextBox txtMaPhieuTL, ComboBox ctxMaKho,DateTimePicker timeNgayThanh,ComboBox ctxMaNV)
        {
            if (data == null)
                data = new LapPhieuThanhLiDATA();
            DataTable dt = data.LayDSPhieuThahLi();
            DataRow row = dt.NewRow();
            row[0] = txtMaPhieuTL.Text;
            row[1] = ctxMaKho.Text;
            row[2] = timeNgayThanh.Value;
            row[3] = ctxMaNV.Text;
            
            dt.Rows.Add(row);

            data.Update();
        }
        public void TimKiemPhieuThanhLi(TextBox txtMaPhieuTL, ComboBox ctxChonNgay, DateTimePicker timeNgayBD, DateTimePicker timeNgayKT, DataGridView dg)
        {
            DataTable table = data.TimKiemPhieuThanhLi(txtMaPhieuTL.Text, ctxChonNgay.Text, timeNgayBD.Text, timeNgayKT.Text);
            dg.DataSource = table;
        }
    }
}
