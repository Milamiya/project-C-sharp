using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LapPhieuDatHangCTRL
    {
        LapPhieuDatHangDATA data = new LapPhieuDatHangDATA();
        public void HienThiListViewLapPhieuDatHang(ListView lvw)
        {
            lvw.Items.Clear();

            DataTable tbl = data.LayDSPhieuDatHang();

            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUDH"].ToString());
                item.SubItems.Add(row["MAKH"].ToString());
                item.SubItems.Add(row["MAHT"].ToString());
                item.SubItems.Add(row["NGAYGIAO"].ToString());
                item.SubItems.Add(row["NOIGIAO"].ToString());
                item.SubItems.Add(row["NGAYLAP"].ToString());
                item.SubItems.Add(row["TONGTIEN"].ToString());
                item.SubItems.Add(row["MANV"].ToString());
                

                lvw.Items.Add(item);
            }
        }
        public void Update()
        {
            data.Update();
        }
        public void Luu_PhieuDatHang(TextBox txtMaPhieuDH,ComboBox ctxMaKH,ComboBox ctxMaHT,DateTimePicker timeNgayGiao,TextBox txtNoiGiao,DateTimePicker timeNgayLap,TextBox txtTongTien,ComboBox ctxMaNV)
        {
            if (data == null)
                data = new LapPhieuDatHangDATA();

            DataTable dt = data.LayDSPhieuDatHang();
            DataRow row = dt.NewRow();
            row[0] = txtMaPhieuDH.Text;
            row[1] = ctxMaKH.Text;
            row[2] = ctxMaHT.Text;
            row[3] = timeNgayGiao.Value;
            row[4] = txtNoiGiao.Text;
            row[5] = timeNgayLap.Value;
            row[6] = txtTongTien.Text;
            row[7] = ctxMaNV.Text;
            dt.Rows.Add(row);

            data.Update();
        }
        public void TimKiemPhieuDatHang(TextBox txtMaPhieuDH, ComboBox ctxChonNgay, DateTimePicker timeNgayBD, DateTimePicker timeNgayKT, DataGridView dg)
        {
            DataTable table = data.TimKiemPhieuDatHang(txtMaPhieuDH.Text, ctxChonNgay.Text, timeNgayBD.Text, timeNgayKT.Text);
            dg.DataSource = table;
        }
    }
}
