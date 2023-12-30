using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LapPhieuNhanHangCTRL
    {
        LapPhieuNhanHangDATA data = new LapPhieuNhanHangDATA();
        public void HienThiListViewLapPhieuNhanHang(ListView lvw)
        {
            lvw.Items.Clear();

            DataTable tbl = data.LayDSPhieuNhanHang();

            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUNH"].ToString());
                item.SubItems.Add(row["MAHD"].ToString());
                item.SubItems.Add(row["NGAYGIAO"].ToString());              
                item.SubItems.Add(row["TONGTIEN"].ToString());                
                item.SubItems.Add(row["MANV"].ToString());

                lvw.Items.Add(item);
            }
        }
        public void Update()
        {
            data.Update();
        }
         public void Luu_PhieuNhanHang(TextBox txtMaPhieuNH,ComboBox ctxMaHD, DateTimePicker timeNgayGiao, TextBox txtTongTien, ComboBox ctxMaNV)
        {
            if (data == null)
                data = new LapPhieuNhanHangDATA();
            DataTable dt = data.LayDSPhieuNhanHang();
            DataRow row = dt.NewRow();
            row[0] = txtMaPhieuNH.Text;
            row[1] = ctxMaHD.Text;
            row[2] = timeNgayGiao.Value;          
            row[3] = txtTongTien.Text;          
            row[4] = ctxMaNV.Text;
            dt.Rows.Add(row);

            data.Update();
        }
        public void TimKiemPhieuNhanHang(TextBox txtMaPhieuNH, ComboBox ctxChonNG, DateTimePicker timeNgayBD,DateTimePicker timeNgayKT, DataGridView dg)
        {
            DataTable table = data.TimKiemPhieuNhanHang(txtMaPhieuNH.Text, ctxChonNG.Text, timeNgayBD.Text, timeNgayKT.Text);
            dg.DataSource = table;
        }
    }
}
