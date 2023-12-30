using System;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using GiaoDienCuaHang.DataLayer;
using System.Windows.Forms;

namespace GiaoDienCuaHang.Controller
{
   public class PhieuDatHangController
    {
       NhaCungCapController ctrlNCC = new NhaCungCapController();
       NhanVienController ctrlNV = new NhanVienController();
       HangHoaController ctrlHH = new HangHoaController();
       PhieuDatHangData data = new PhieuDatHangData();
       public void HienThiListView(ListView listview)
       {
           listview.Items.Clear();
           PhieuDatHangData datapdh = new PhieuDatHangData();
           DataTable dtb = datapdh.LayPDH();
           int n = 0;
           foreach (DataRow row in dtb.Rows)
           {
               ListViewItem item = new ListViewItem();
               n++;
               item.Text = n.ToString();
               item.SubItems.Add(row["MAPHIEUDATHANG"].ToString());
               item.SubItems.Add(ctrlNCC.LoadListViewSubItemNhaCungCap(row["MANCC"].ToString()));
               item.SubItems.Add(ctrlNV.LoadListViewSubItemNhanVien(row["MANV"].ToString()));
               item.SubItems.Add(row["NGAYLAP"].ToString());
               

               listview.Items.Add(item);

           }
         
      }

       public void LoadComboBoxPhieuDatHang(ComboBox cmb)
       {
           cmb.DataSource = data.LayPDH();
           cmb.DisplayMember = "MAPHIEUDATHANG";
           cmb.ValueMember = "MAPHIEUDATHANG";
           cmb.SelectedValue = "MAPHIEUDATHANG";
           
       }
       public void HienThiComboBox(ComboBox cmbMaNCC, ComboBox cmbMaNV, ComboBox cmbMaSP)
       {
           ctrlNCC.LoadComboBoxNhaCungCap(cmbMaNCC);
           ctrlNV.LoadComboBoxNhanVien(cmbMaNV);
           ctrlHH.LoadComboBoxHangHoa(cmbMaSP);
       }
       public bool KiemTraTTChiTietPhieuDatHang(ListView listview, string strCTMaPhieuDH, string strCTMaSP)
       {
           foreach (ListViewItem item in listview.Items)
           {
              if (item.SubItems[2].Text == strCTMaSP)
               {
                   MessageBox.Show("Mã sản phẩm bị trùng. Không thể thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }
           }
           return true;
       }
       public void Luu_PhieuDatHang(TextBox MaPDH, ComboBox MaNCC,ComboBox MaNV,DateTimePicker NgayLap)
       {
           PhieuDatHangData PDHDATA = new PhieuDatHangData();
           
           DataTable dt = PDHDATA.LayPDH();
           DataRow row = dt.NewRow();
           row[0] = MaPDH.Text;
           row[1] = MaNCC.SelectedValue.ToString();
           row[2] = MaNV.SelectedValue.ToString();
           row[3]= NgayLap.Value.Date;
           
           dt.Rows.Add(row);
           PDHDATA.Update();
          
       }
       public void Luu_CTPhieuDatHang(ListView listview)
       {
           PhieuDatHangData PDHDATA = new PhieuDatHangData();

           DataTable dt = PDHDATA.LayCT_PDH();
           foreach (ListViewItem item in listview.Items)
           {
               DataRow row = dt.NewRow();
               row[0] = item.SubItems[1].Text.ToString();
               row[1] = item.SubItems[4].Text.ToString();
               row[2] = item.SubItems[3].Text.ToString();            
               
               dt.Rows.Add(row);
           }
           PDHDATA.Update();
          

       }
       string strTenPDH;

       public ListViewItem.ListViewSubItem LoadListViewSubItemPHIEUDATHANG(string str)
       {
           ListViewItem.ListViewSubItem subI = new ListViewItem.ListViewSubItem();
           DataTable dt = data.LayPDH();
           subI.Tag = dt;
           foreach (DataRow dr in dt.Rows)
           {
               if (dr["MAPHIEUDATHANG"].ToString() == str)
                   strTenPDH = dr["MAPHIEUDATHANG"].ToString();

           }
           subI.Text = strTenPDH;
           return subI;
       }
       public void TimKiemPDH(ComboBox cmbMNCC, ComboBox cmbchonMNV, ComboBox cmbMNV, ComboBox cmbchonNgayLap, DateTimePicker tungay, DateTimePicker denngay, DataGridView dg)
       {
           DataTable tbl = data.TimKiemPhieuDatHang(cmbMNCC.Text, cmbchonMNV.Text, cmbMNV.Text, cmbchonNgayLap.Text, tungay.Value.Date, denngay.Value.Date);
           if (tbl.Rows.Count == 0)
           {
               MessageBox.Show("Tìm không thấy trong danh sách PHIẾU ĐẶT HÀNG.Vui lòng kiểm tra lại các thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           dg.DataSource = tbl;

       }
    }
}
