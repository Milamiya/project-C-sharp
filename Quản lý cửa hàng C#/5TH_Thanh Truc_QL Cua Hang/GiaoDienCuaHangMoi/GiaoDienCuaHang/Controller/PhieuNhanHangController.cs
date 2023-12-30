using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using GiaoDienCuaHang.DataLayer;

namespace GiaoDienCuaHang.Controller
{
   public class PhieuNhanHangController
    {
       NhaCungCapController ctrlNCC = new NhaCungCapController();
       NhanVienController ctrlNV = new NhanVienController();
       HangHoaController ctrlHH = new HangHoaController();
       PhieuDatHangController ctrl = new PhieuDatHangController();
       PhieuNhanHangData data = new PhieuNhanHangData();
        public void HienThiListView(ListView listview)
        {


            listview.Items.Clear();
            DataTable dtb = data.LayDSPNH();
            int n = 0;
            foreach (DataRow row in dtb.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEU"].ToString());
                item.SubItems.Add(ctrlNCC.LoadListViewSubItemNhaCungCap(row["MANCC"].ToString()));
                item.SubItems.Add(ctrlNV.LoadListViewSubItemNhanVien(row["MANV"].ToString()));
                item.SubItems.Add(row["NGAYLAP"].ToString());
                item.SubItems.Add(row["TONGTIEN"].ToString());

                listview.Items.Add(item);

            }


        }
        public void HienThiComboBox(ComboBox cmbMNCC, ComboBox cmbMNV, ComboBox cmbMSP,ComboBox cmbMPDH)
        {
            ctrlNCC.LoadComboBoxNhaCungCap(cmbMNCC);
            ctrlNV.LoadComboBoxNhanVien(cmbMNV);
            ctrlHH.LoadComboBoxHangHoa(cmbMSP);
            ctrl.LoadComboBoxPhieuDatHang(cmbMPDH);            
        }
       public bool KiemTraTTChiTietPhieuNhanHang(ListView listview, string strMaPhieu, string strMaSP)
       {
           foreach (ListViewItem item in listview.Items)
           {
               //if (item.SubItems[1].Text == strMaPhieu)
               //{
               //    MessageBox.Show("Mã phiếu bị trùng. Không thể thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               //    return false;
               //}
               if (item.SubItems[2].Text == strMaSP)
               {
                   MessageBox.Show("Mã sản phẩm bị trùng. Không thể thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }
           }
           return true;
       }
       public void Luu_PhieuNhanHang(TextBox MaPNH, ComboBox MaNCC, ComboBox MaNV, DateTimePicker NgayLap, TextBox TONGTIEN)
       {
          // PhieuNhanHangData pnhdata = new PhieuNhanHangData();
           
           DataRow row = data.NewRow();
           row[0] = MaPNH.Text;
           row[1] = MaNCC.SelectedValue;
           row[2] = MaNV.SelectedValue;
           row[3] = NgayLap.Value.Date;
           row[4] = TONGTIEN.Text;

           data.Add(row);

           data.Update();

       }
       public void Luu_CTPhieuNhanHang(ListView lview)
       {
           PhieuNhanHangData pnhdata = new PhieuNhanHangData();
           DataTable dt = pnhdata.LayDS_CT_PNH();
           foreach (ListViewItem item in lview.Items)
           {
               DataRow row = dt.NewRow();
               row[0] = item.SubItems[1].Text.ToString();
               row[1] = item.SubItems[7].Text.ToString();
               row[2] = item.SubItems[3].Text.ToString();
               row[3] = item.SubItems[4].Text.ToString();
               row[4] = item.SubItems[5].Text.ToString();
               row[5] = item.SubItems[6].Text.ToString();

               dt.Rows.Add(row);
           }
           pnhdata.Update();

       }
       public void TimKiemPNH(ComboBox cmbMNCC, ComboBox cmbchonMNV, ComboBox cmbMNV, ComboBox cmbchonNgayLap, DateTimePicker tungay, DateTimePicker denngay, DataGridView dg)
       {
           DataTable tbl = data.TimKiemPhieuNhanHang(cmbMNCC.Text, cmbchonMNV.Text, cmbMNV.Text, cmbchonNgayLap.Text, tungay.Value.Date, denngay.Value.Date);
           if (tbl.Rows.Count == 0)
           {
               MessageBox.Show("Tìm không thấy trong danh sách PHIẾU NHẬN HÀNG.Vui lòng kiểm tra lại các thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           dg.DataSource = tbl;

       }
     
    }
}
