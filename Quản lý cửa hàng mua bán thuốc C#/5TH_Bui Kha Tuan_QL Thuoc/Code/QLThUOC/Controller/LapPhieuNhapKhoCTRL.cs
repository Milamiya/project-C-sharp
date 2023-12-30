using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LapPhieuNhapKhoCTRL
    {
        LapPhieuNhapKhoDATA data = new LapPhieuNhapKhoDATA();
        public void HienThiListViewLapPhieuNhapKho(ListView lvw)
        {
            lvw.Items.Clear();

            DataTable tbl = data.LayDSPhieuNhapKho();

            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUNK"].ToString());              
                item.SubItems.Add(row["NGAYNK"].ToString());       
                item.SubItems.Add(row["MANV"].ToString());
                item.SubItems.Add(row["MAKHO"].ToString());   

                lvw.Items.Add(item);
            }
        }
        public void Update()
        {
            data.Update();
        }
         public void Luu_PhieuNhapKho(TextBox txtMaPhieuNK,DateTimePicker timeNgayXK,ComboBox ctxMaNV,ComboBox ctxMaKho)
        {
            if (data == null)
                data = new LapPhieuNhapKhoDATA();
            DataTable dt = data.LayDSPhieuNhapKho();
            DataRow row = dt.NewRow();
            row[0] = txtMaPhieuNK.Text;
            row[1] = timeNgayXK.Value;
            row[2] = ctxMaNV.Text;
            row[3] = ctxMaKho.Text;
            dt.Rows.Add(row);

            data.Update();
        }
        public void TimKiemPhieuNhapKho(TextBox txtMaPhieuNK, ComboBox ctxChonNK, DateTimePicker timeNgayBD, DateTimePicker timeNgayKT, DataGridView dg)
        {
            DataTable table = data.TimKiemPhieuNhapKho(txtMaPhieuNK.Text, ctxChonNK.Text, timeNgayBD.Text, timeNgayKT.Text);
            dg.DataSource = table;
        }
    }
}
