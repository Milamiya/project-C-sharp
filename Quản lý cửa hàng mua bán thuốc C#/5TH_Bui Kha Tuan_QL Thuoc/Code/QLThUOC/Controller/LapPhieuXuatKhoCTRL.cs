using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LapPhieuXuatKhoCTRL
    {
        LapPhieuXuatKhoDATA data = new LapPhieuXuatKhoDATA();
        public void HienThiListViewLapPhieuXuatKho(ListView lvw)
        {
            lvw.Items.Clear();

            DataTable tbl = data.LayDSPhieuXuatKho();

            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUXK"].ToString());
                item.SubItems.Add(row["MAKH"].ToString());
                item.SubItems.Add(row["MAKHO"].ToString());
                item.SubItems.Add(row["NGAYXUAT"].ToString());
                item.SubItems.Add(row["MANV"].ToString());
               

                lvw.Items.Add(item);
            }
        }
        public void Update()
        {
            data.Update();
        }
        public void Luu_PhieuXuatKho(TextBox txtMaPhieuXK,ComboBox ctxMaKH, ComboBox ctxMaKho,DateTimePicker timeNgayXuat,ComboBox ctxMaNV)
        {
            if (data == null)
                data = new LapPhieuXuatKhoDATA();
            DataTable dt = data.LayDSPhieuXuatKho();
            DataRow row = dt.NewRow();
            row[0] = txtMaPhieuXK.Text;
            row[1] = ctxMaKH.Text;
            row[2] = ctxMaKho.Text;
            row[3] = timeNgayXuat.Value;
            row[4] = ctxMaNV.Text;
            dt.Rows.Add(row);

            data.Update();
        }
        public void TimKiemPhieuXuatKho(TextBox txtMaPhieuXK, ComboBox ctxChonXK, DateTimePicker timeNgayBD, DateTimePicker timeNgayKT, DataGridView dg)
        {
            DataTable table = data.TimKiemPhieuXuatKho(txtMaPhieuXK.Text, ctxChonXK.Text, timeNgayBD.Text, timeNgayKT.Text);
            dg.DataSource = table;
        }
    }
}
