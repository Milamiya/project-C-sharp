using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.DataLayer;

namespace GiaoDienCuaHang.Controller
{
   public class KhachHangContronller
    {
       KhachHangData data = new KhachHangData();
       public void HienThi(TextBox txtMKH, TextBox txtHT, TextBox txtDC, TextBox txtDT, DataGridView dg, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.LayDSKhachHang();
           dg.DataSource = bs;
           bn.BindingSource = bs;
           txtMKH.DataBindings.Add("Text", bs,"MAKH");
           txtHT.DataBindings.Add("Text", bs, "HOTEN");
           txtDC.DataBindings.Add("Text", bs, "DIACHI");
           txtDT.DataBindings.Add("Text", bs, "DIENTHOAI");
       }
       string strTenKhachHang;

       public ListViewItem.ListViewSubItem LoadListViewSubItemKhachHang(string str)
       {
           ListViewItem.ListViewSubItem subI = new ListViewItem.ListViewSubItem();
           DataTable dt = data.LayDSKhachHang();
           subI.Tag = dt;
           foreach (DataRow dr in dt.Rows)
           {
               if (dr["MAKH"].ToString() == str)
                   strTenKhachHang = dr["HOTEN"].ToString();
                   
           }
           subI.Text = strTenKhachHang;
           return subI;
       }

       public void LoadComboBoxKhachHang(ComboBox cmb)
       {
           cmb.DataSource = data.LayDSKhachHang();
           cmb.DisplayMember = "HOTEN";
           cmb.ValueMember = "MAKH";
           cmb.SelectedValue = "MAKH";
       }
       public void TimKiemKH(TextBox txttenKH, ComboBox cmbchonDCHI,TextBox txtDC, ComboBox cmbchonDT, TextBox txtDT, DataGridView dg)
       {
           DataTable tbl = data.TKKhachHang(txttenKH.Text, cmbchonDCHI.Text, txtDC.Text, cmbchonDT.Text, txtDT.Text);
           if (tbl.Rows.Count == 0)
           {
               MessageBox.Show("Tìm không thấy trong danh sách KHÁCH HÀNG.Vui lòng kiểm tra lại các thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           dg.DataSource = tbl;

       }
       public void Update()
       {
           data.Update();
       }
    }
}
