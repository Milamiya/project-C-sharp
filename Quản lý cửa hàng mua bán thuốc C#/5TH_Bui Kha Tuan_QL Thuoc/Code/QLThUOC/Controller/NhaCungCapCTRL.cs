using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLThUOC.DataLayer;
using System.Data;


namespace QLThUOC.Controller
{
    public class NhaCungCapCTRL
    {
        NhaCungCapDATA data = new NhaCungCapDATA();
        public void HienThiNhaCungCap(TextBox txtMaNCC,TextBox txtTenNCC,TextBox txtDiaChiNCC,TextBox txtDienThoaiNCC,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSNhaCungCap();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            txtMaNCC.DataBindings.Add("Text", bs, "MANCC");
            txtTenNCC.DataBindings.Add("Text", bs, "TENNCC");
            txtDiaChiNCC.DataBindings.Add("Text", bs, "DIACHINCC");
            txtDienThoaiNCC.DataBindings.Add("Text", bs, "DIENTHOAINCC");
        }
        public void HienThiComboBoxMaNCC(ComboBox cmd)
        {
            NhaCungCapDATA dataNhaCungCap = new NhaCungCapDATA();
            cmd.DataSource = dataNhaCungCap.LayDSNhaCungCap();
            cmd.DisplayMember = "TENNCC";
            cmd.ValueMember = "MANCC";
            cmd.SelectedValue = "MANCC";
        }
        public void TimKiemNCC(TextBox txtMaNCC, ComboBox ctxChonTenNCC, TextBox txtTenNCC, ComboBox ctxChonDiaChi, TextBox txtDiaChi,DataGridView dg)
        {
            DataTable table = data.TimKiemNCC(txtMaNCC.Text, ctxChonTenNCC.Text, txtTenNCC.Text, ctxChonDiaChi.Text, txtDiaChi.Text);
            dg.DataSource = table;

        }
        public void Update()
        {
            data.Update();
        }
      
    }
}
