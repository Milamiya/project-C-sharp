using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.DataLayer;


namespace GiaoDienCuaHang.Controller
{
   public class NhaCungCapController
    {
       NhaCungCapData data = new NhaCungCapData();
       public void HienThi(TextBox txtMANCC,TextBox txtTNCC,TextBox txtDC,TextBox txtĐT,DataGridView dg,BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.LayDSNhaCungCap();
           bn.BindingSource = bs;
           dg.DataSource = bs;
           txtMANCC.DataBindings.Add("Text", bs, "MANCC");
           txtTNCC.DataBindings.Add("Text", bs, "TENNCC");
           txtDC.DataBindings.Add("Text", bs, "DIACHI");
           txtĐT.DataBindings.Add("Text", bs, "DIENTHOAI");
       }
       string strTenNhaCungCap;
       public ListViewItem.ListViewSubItem LoadListViewSubItemNhaCungCap(string str)
       {
           ListViewItem.ListViewSubItem subI = new ListViewItem.ListViewSubItem();
           DataTable dt = data.LayDSNhaCungCap();
           subI.Tag = dt;
           foreach (DataRow dr in dt.Rows)
           {
               if (dr["MANCC"].ToString() == str)
                   strTenNhaCungCap = dr["TENNCC"].ToString();

           }
           subI.Text = strTenNhaCungCap;
           return subI;
       }
       public void LoadComboBoxNhaCungCap(ComboBox cmb)
       {
           cmb.DataSource = data.LayDSNhaCungCap();
           cmb.DisplayMember = "TENNCC";
           cmb.ValueMember = "MANCC";
           cmb.SelectedValue = "MANCC";
       }
       public void TimKiemNhaCungCap(TextBox txtTenNCC, ComboBox cmbchonDCHI, TextBox txtDC, ComboBox cmbchonDT, TextBox txtDT, DataGridView dg)
       {
           DataTable tbl = data.TKNhaCungCap(txtTenNCC.Text, cmbchonDCHI.Text, txtDC.Text, cmbchonDT.Text, txtDT.Text);
           if (tbl.Rows.Count == 0)
           {
               MessageBox.Show("Tìm không thấy trong danh sách NHÀ CUNG CẤP.Vui lòng kiểm tra lại các thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           dg.DataSource = tbl;

       }
       public void Update()
       {
           data.Update();
       }
    }
}
