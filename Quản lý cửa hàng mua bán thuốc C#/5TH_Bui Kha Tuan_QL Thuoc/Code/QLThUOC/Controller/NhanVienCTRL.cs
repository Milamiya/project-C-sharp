using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class NhanVienCTRL
    {
        NhanVienDATA data = new NhanVienDATA();
        public void HienThiNhanVien(TextBox txtMaNhanVien,TextBox txtTenNhanVien,TextBox txtGioiTinh,DateTimePicker timeNgaySinh,TextBox txtDiaChi,TextBox txtDienThoai,TextBox txtTenLoaiNV,TextBox txtTenDangNhap,TextBox txtMatKhau,DataGridView dg,BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSNhanVien();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            txtMaNhanVien.DataBindings.Add("Text", bs, "MANV");
            txtTenNhanVien.DataBindings.Add("Text", bs, "HOTENNV");
            timeNgaySinh.DataBindings.Add("Text", bs, "NGAYSINH");
            txtDiaChi.DataBindings.Add("Text", bs, "DIACHI");
            txtDienThoai.DataBindings.Add("Text", bs, "DIENTHOAI");
            txtGioiTinh.DataBindings.Add("Text", bs, "GIOITINH");
            txtTenLoaiNV.DataBindings.Add("Text",bs,"TENLOAINV");
            txtTenDangNhap.DataBindings.Add("Text", bs, "TENDN");
            txtMatKhau.DataBindings.Add("Text", bs, "MATKHAU");
        }
        public void HienThiComboBoxMaNV(ComboBox cmd)
        {
            NhanVienDATA dataNhanVien = new NhanVienDATA();
            cmd.DataSource = dataNhanVien.LayDSNhanVien();
            cmd.DisplayMember = "HOTENNV";
            cmd.ValueMember = "MANV";
            cmd.SelectedValue = "MANV";
        }
        public void TimKiemNV(TextBox txtMaNV, ComboBox ctxChonHoTen, TextBox txtHoTen, ComboBox ctxChonNgaySinh, DateTimePicker timeNgaysinh, ComboBox ctxChonDiaChi, TextBox txtDiaChi, ComboBox ctxChonTenLoaiNV, TextBox txtTenLoaiNV, DataGridView dg)
        {
            DataTable table = data.TimKiemNV(txtMaNV.Text, ctxChonHoTen.Text, txtHoTen.Text, ctxChonNgaySinh.Text, timeNgaysinh.Text, ctxChonDiaChi.Text, txtDiaChi.Text, ctxChonTenLoaiNV.Text, txtTenLoaiNV.Text);
            dg.DataSource = table;
        }
        public void Update()
        {
            data.Update();
        }
        public int DangNhap(String tendangnhap, String matkhau)
        {
            DataTable nd = data.LayDSNhanVien(tendangnhap);
            if (nd.Rows.Count == 0)
                return 0;

            String matkhau_hethong = nd.Rows[0]["MATKHAU"].ToString();
            if (matkhau_hethong == matkhau)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

    }
}
