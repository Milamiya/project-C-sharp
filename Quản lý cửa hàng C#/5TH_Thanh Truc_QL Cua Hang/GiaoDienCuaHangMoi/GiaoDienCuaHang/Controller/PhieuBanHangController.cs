using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using GiaoDienCuaHang.BusinessLayer;
using GiaoDienCuaHang.DataLayer;
using System.Windows.Forms;

namespace GiaoDienCuaHang.Controller
{
    
   public class PhieuBanHangController
    {
       
       KhachHangContronller ctrlkh = new KhachHangContronller();
       NhanVienController ctrlnv = new NhanVienController();
       HangHoaController ctrlhh = new HangHoaController();
       PhieuBanHangData data = new PhieuBanHangData();
       
       public void HienThiListView(ListView listview)
       {
           listview.Items.Clear();
           DataTable dtb = data.LayDSPBH();
           int n = 0;
           foreach (DataRow row in dtb.Rows)
           {
               ListViewItem item = new ListViewItem();
               n++;
               item.Text = n.ToString();
               item.SubItems.Add(row["MAPHIEU"].ToString());
               item.SubItems.Add(row["MAKH"].ToString());
               item.SubItems.Add(row["MANV"].ToString());
               item.SubItems.Add(row["NGAYLAP"].ToString());
               item.SubItems.Add(row["TONGTIEN"].ToString());

               listview.Items.Add(item);
               
           }
       }

       public void HienThiComboBox(ComboBox cmbMaKH, ComboBox cmbMaNV,ComboBox cmbMaSP)
       {
           ctrlkh.LoadComboBoxKhachHang(cmbMaKH);
           ctrlnv.LoadComboBoxNhanVien(cmbMaNV);
           ctrlhh.LoadComboBoxHangHoa(cmbMaSP);
           
       }

       public bool KiemTraTTChiTietPhieuBanHang(ListView listview,string strMaPhieu,string strMaSP)
       {
           foreach (ListViewItem item in listview.Items)
           {
              if (item.SubItems[2].Text == strMaSP)
               {
                   MessageBox.Show("Mã sản phẩm bị trùng. Không thể thêm được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }
           }
           return true;
       }
       public void Luu_PhieuBanHang(TextBox MaPBH, ComboBox MaKH, ComboBox MaNV, DateTimePicker NgayLap,TextBox TT)
       {
           PhieuBanHangData pbhdata=new PhieuBanHangData();
           DataTable dt = pbhdata.LayDSPBH(); 
           
           DataRow row = dt.NewRow();
           row[0] = MaPBH.Text;
           row[1] = MaKH.SelectedValue;
           row[2] = MaNV.SelectedValue;
           row[3] = NgayLap.Value.Date;
           row[4] = TT.Text;

           dt.Rows.Add(row);
           pbhdata.Update();

       }
       public void Luu_CTPhieuBanHang(ListView lv)
       {
           PhieuBanHangData pbhdata = new PhieuBanHangData();
           DataTable dt = pbhdata.LayDSCTPBH();
           foreach (ListViewItem item in lv.Items)
           {
               DataRow row = dt.NewRow();
               row[0] = item.SubItems[1].Text.ToString();
               row[1] = item.SubItems[6].Text.ToString();
               row[2] = item.SubItems[3].Text.ToString();
               row[3] = item.SubItems[4].Text.ToString();
               row[4] = item.SubItems[5].Text.ToString();

               dt.Rows.Add(row);
           }
           pbhdata.Update();

       }
       public void TimKiemPBH(ComboBox cmbMKH, ComboBox cmbchonMNV, ComboBox cmbMNV,ComboBox cmbchonNgayLap,DateTimePicker tungay,DateTimePicker denngay, DataGridView dg)
       {
           DataTable tbl = data.TimKiemPhieuBanHang(cmbMKH.Text,cmbchonMNV.Text,cmbMNV.Text,cmbchonNgayLap.Text,tungay.Value.Date,denngay.Value.Date);
           if (tbl.Rows.Count == 0)
           {
               MessageBox.Show("Tìm không thấy trong danh sách PHIẾU BÁN HÀNG.Vui lòng kiểm tra lại các thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           dg.DataSource = tbl;

       }
      

   }
}
