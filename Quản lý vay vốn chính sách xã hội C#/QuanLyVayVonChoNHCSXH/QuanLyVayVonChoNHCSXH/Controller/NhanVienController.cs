using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class NhanVienController
    {
        NhanVienPlayer NVplayer = new NhanVienPlayer();
        BindingSource bs = new BindingSource();
        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "HoTenNV";
            cmb.ValueMember = "MaNhanVien";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "HoTenNV";
            cmb.ValueMember = "MaNhanVien";
            cmb.DataPropertyName = "Ma_NhanVien";
            cmb.HeaderText = "NhanVien";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn,TextBox txtMaNV,TextBox txtHoTenNV,DateTimePicker dtpNgaySinh,TextBox txtDiaChi,ComboBox cmbMaPhong,ComboBox cmbMaChucVu,TextBox txtGhiChu)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = NVplayer.DanhSachNhanVien();
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", bs, "MaNV");

            txtHoTenNV.DataBindings.Clear();
            txtHoTenNV.DataBindings.Add("Text", bs, "HoTenNV");

     
            try
            {
                dtpNgaySinh.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
            }
            catch { }

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");


            cmbMaPhong.DataBindings.Clear();
            cmbMaPhong.DataBindings.Add("SelectedValue", bs, "MaPhongBan");

            cmbMaChucVu.DataBindings.Clear();
            cmbMaChucVu.DataBindings.Add("SelectedValue", bs, "MaChucVu");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bs, "GhiChu");

           
        }

        public NhanVien LayNhanVien(String ma)
        {
            DataTable tbl = new DataTable();
            tbl = NVplayer.LayNhanVien(ma);
            NhanVien nv = null;

            if (tbl.Rows.Count > 0)
            {
                nv = new NhanVien();
                nv.MANV = Convert.ToString(tbl.Rows[0]["MaNV"]);
                nv.HOTENNV = Convert.ToString(tbl.Rows[0]["HoTenNV"]);
                nv.NGAYSINH = Convert.ToDateTime(tbl.Rows[0]["NgaySinh"]);
                nv.DIACHI = Convert.ToString(tbl.Rows[0]["DiaChi"]);
                nv.MAPHONGBAN = Convert.ToString(tbl.Rows[0]["MaPhongBan"]);
                nv.MACHUCVU = Convert.ToString(tbl.Rows[0]["MaChucVu"]);
                nv.GHICHU = Convert.ToString(tbl.Rows[0]["GhiChu"]);
            }
            return nv;
        }

       public void TimMaNhanVien(DataGridView dg, BindingNavigator bn, TextBox txtMaNV, TextBox txtHoTenNV, DateTimePicker dtpNgaySinh, TextBox txtDiaChi, ComboBox cmbMaPhong, ComboBox cmbMaChucVu, TextBox txtGhiChu, String manhanvien)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = NVplayer.TimNhanVienTheoMa(manhanvien);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", bs, "MaNV");

            txtHoTenNV.DataBindings.Clear();
            txtHoTenNV.DataBindings.Add("Text", bs, "HoTenNV");


            try
            {
                dtpNgaySinh.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
            }
            catch { }

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");


            cmbMaPhong.DataBindings.Clear();
            cmbMaPhong.DataBindings.Add("SelectedValue", bs, "MaPhongBan");

            cmbMaChucVu.DataBindings.Clear();
            cmbMaChucVu.DataBindings.Add("SelectedValue", bs, "MaChucVu");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bs, "GhiChu");
        }

       public void TimTenNhanVien(DataGridView dg, BindingNavigator bn, TextBox txtMaNV, TextBox txtHoTenNV, DateTimePicker dtpNgaySinh, TextBox txtDiaChi, ComboBox cmbMaPhong, ComboBox cmbMaChucVu, TextBox txtGhiChu, String tennhanvien)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = NVplayer.TimNhanVienTheoTen(tennhanvien);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", bs, "MaNV");

            txtHoTenNV.DataBindings.Clear();
            txtHoTenNV.DataBindings.Add("Text", bs, "HoTenNV");


            try
            {
                dtpNgaySinh.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
            }
            catch { }

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");


            cmbMaPhong.DataBindings.Clear();
            cmbMaPhong.DataBindings.Add("SelectedValue", bs, "MaPhongBan");

            cmbMaChucVu.DataBindings.Clear();
            cmbMaChucVu.DataBindings.Add("SelectedValue", bs, "MaChucVu");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bs, "GhiChu");
        }


       public void TimMaPhongBan(DataGridView dg, BindingNavigator bn, TextBox txtMaNV, TextBox txtHoTenNV, DateTimePicker dtpNgaySinh, TextBox txtDiaChi, ComboBox cmbMaPhong, ComboBox cmbMaChucVu, TextBox txtGhiChu, String maphongban)
       {

           BindingSource bs = new BindingSource();
           bs.DataSource = NVplayer.TimNhanVienTheoMaPB(maphongban);
           bn.BindingSource = bs;
           dg.DataSource = bs;


           txtMaNV.DataBindings.Clear();
           txtMaNV.DataBindings.Add("Text", bs, "MaNV");

           txtHoTenNV.DataBindings.Clear();
           txtHoTenNV.DataBindings.Add("Text", bs, "HoTenNV");


           try
           {
               dtpNgaySinh.DataBindings.Clear();
               dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
           }
           catch { }

           txtDiaChi.DataBindings.Clear();
           txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");


           cmbMaPhong.DataBindings.Clear();
           cmbMaPhong.DataBindings.Add("SelectedValue", bs, "MaPhongBan");

           cmbMaChucVu.DataBindings.Clear();
           cmbMaChucVu.DataBindings.Add("SelectedValue", bs, "MaChucVu");

           txtGhiChu.DataBindings.Clear();
           txtGhiChu.DataBindings.Add("Text", bs, "GhiChu");
       }

       public void TimMaChucVu(DataGridView dg, BindingNavigator bn, TextBox txtMaNV, TextBox txtHoTenNV, DateTimePicker dtpNgaySinh, TextBox txtDiaChi, ComboBox cmbMaPhong, ComboBox cmbMaChucVu, TextBox txtGhiChu,String machucvu)
       {

           BindingSource bs = new BindingSource();
           bs.DataSource = NVplayer.TimNhanVienTheoMaCV(machucvu);
           bn.BindingSource = bs;
           dg.DataSource = bs;


           txtMaNV.DataBindings.Clear();
           txtMaNV.DataBindings.Add("Text", bs, "MaNV");

           txtHoTenNV.DataBindings.Clear();
           txtHoTenNV.DataBindings.Add("Text", bs, "HoTenNV");


           try
           {
               dtpNgaySinh.DataBindings.Clear();
               dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
           }
           catch { }

           txtDiaChi.DataBindings.Clear();
           txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");


           cmbMaPhong.DataBindings.Clear();
           cmbMaPhong.DataBindings.Add("SelectedValue", bs, "MaPhongBan");

           cmbMaChucVu.DataBindings.Clear();
           cmbMaChucVu.DataBindings.Add("SelectedValue", bs, "MaChucVu");

           txtGhiChu.DataBindings.Clear();
           txtGhiChu.DataBindings.Add("Text", bs, "GhiChu");
       }

        

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = NVplayer.DanhSachNhanVien();
            cmb.DisplayMember = "HoTenNV";
            cmb.ValueMember = "MaNV";

        }

       public void Update()
       {

           bs.MoveNext();
           NVplayer.Save();
       }

        public DataRow NewRow()
        {
            return NVplayer.NewRow();
        }
        public void Add(DataRow row)
        {
            NVplayer.Add(row);
        }
        public bool Save()
        {
            return NVplayer.Save();
        }
    }
}
