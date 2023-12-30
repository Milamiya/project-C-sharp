using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class KhachHangCTRL
    {
        KhachHangDATA data = new KhachHangDATA();
        public void HienThiKhachHang(TextBox txtMaKH,TextBox txtHoTen,TextBox txtDiaChi,TextBox txtDienThoai,ComboBox ctxMaLoaiKH,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSKhachHang();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaKH.DataBindings.Add("Text", bs, "MAKH");
            txtHoTen.DataBindings.Add("Text", bs, "HOTENKH");
            txtDiaChi.DataBindings.Add("Text", bs, "DIACHIKH");
            txtDienThoai.DataBindings.Add("Text", bs, "DIENTHOAI");
            ctxMaLoaiKH.DataBindings.Add("SelectedValue", bs, "MALOAIKH");

        //Load ComboBox
            LoaiKhachHangCTRL ctrlLoaiKH = new LoaiKhachHangCTRL();
            ctrlLoaiKH.HienThiComboBoxMaLoaiKH(ctxMaLoaiKH);
            dg.Columns.Add(ctrlLoaiKH.LoadComboBox());
            dg.Columns.Remove("MALOAIKH");
        }
        public void TimKiemKH(TextBox txtMaKH, ComboBox ctxChonHoTen, TextBox txtHoTen, ComboBox ctxChonDiaChi, TextBox txtDiaChi,DataGridView dg)
        {
            DataTable table = data.TimKiemKH(txtMaKH.Text, ctxChonHoTen.Text, txtHoTen.Text, ctxChonDiaChi.Text, txtDiaChi.Text);
            dg.DataSource = table;
        }
        public void Update()
        {
            data.Update();
        }
    }
}
