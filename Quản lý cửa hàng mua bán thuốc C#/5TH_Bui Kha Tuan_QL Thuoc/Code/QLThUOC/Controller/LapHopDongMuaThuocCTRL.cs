using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LapHopDongMuaThuocCTRL
    {
        LapHopDongMuaThuocDATA data = new LapHopDongMuaThuocDATA();
        public void HienThiListViewLapHopDong(ListView lvw)
        {
            lvw.Items.Clear();

            DataTable tbl = data.LayDSHopDongMuaThuoc();

            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAHD"].ToString());
                item.SubItems.Add(row["NGAYLAP"].ToString());
                item.SubItems.Add(row["NGAYNHAN"].ToString());
                item.SubItems.Add(row["NOINHAN"].ToString());
                item.SubItems.Add(row["TONGTIEN"].ToString());
                item.SubItems.Add(row["SLGIAO"].ToString());
                item.SubItems.Add(row["MANCC"].ToString());
                item.SubItems.Add(row["MANV"].ToString());

                lvw.Items.Add(item);
            }
        }
        public void Update()
        {
            data.Update();
        }
        public void Luu_HDMT(TextBox txtMaHD, DateTimePicker timeNgayLap, DateTimePicker timeNgayNhan, TextBox txtNoiNhan, TextBox txtTongTien, TextBox txtSLGiao, ComboBox ctxMaNCC, ComboBox ctxMaNV)
        {
            if (data == null)
                data = new LapHopDongMuaThuocDATA();
            DataTable dt = data.LayDSHopDongMuaThuoc();
            DataRow row = dt.NewRow();
            row[0] = txtMaHD.Text;
            row[1] = timeNgayLap.Value;
            row[2] = timeNgayNhan.Value;
            row[3] = txtNoiNhan.Text;
            row[4] = txtTongTien.Text;
            row[5] = txtSLGiao.Text;
            row[6] = ctxMaNCC.Text;
            row[7] = ctxMaNV.Text;
            dt.Rows.Add(row);

            data.Update();
        }
        public void TimKiemHopDong(TextBox txtMaHD, ComboBox ctxChonNgay, DateTimePicker timeNgayBD, DateTimePicker timeNgayKT, DataGridView dg)
        {
            DataTable table = data.TimKiemHopDong(txtMaHD.Text, ctxChonNgay.Text, timeNgayBD.Text, timeNgayKT.Text);
            dg.DataSource = table;
        }

    }
}