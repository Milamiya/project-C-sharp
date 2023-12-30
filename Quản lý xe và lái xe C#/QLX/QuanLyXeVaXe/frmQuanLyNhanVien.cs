using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
 
namespace QuanLyXeVaXe
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void Load_MaNV()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaNhanVien from tb_NhanVirn", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            txtMaNhanVien.DataSource = dt1;
            txtMaNhanVien.DisplayMember = "MaNhanVien";
            txtMaNhanVien.ValueMember = "MaNhanVien";
            con.Close();
            da1.Dispose();
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_NhanVirn (MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, DienThoai, Email, BangCap, CMND, NgayVaoLam) values ('" + txtMaNhanVien.Text + "', '" + txtTenNhanVien.Text + "', '" + txtGioiTinh.Text + "', '" + dtpNgaySinh.Text + "', '" + txtDiaChi.Text + "', '" + txtDienThoai.Text + "', '" + txtEmail.Text + "', '" + txtbangCap.Text + "', '" + txtCMND.Text + "', '" + dtpNgayVaoLam.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from tb_NhanVirn ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dtgQuanLyNhanVien.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Thêm thành công", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            Load_MaNV();
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from tb_NhanVirn ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgQuanLyNhanVien.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên],  GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from tb_NhanVirn where MaNhanVien = '"+txtMaNhanVien.Text+"'", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dtgQuanLyNhanVien.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("update tb_NhanVirn set TenNhanVien = '"+txtTenNhanVien.Text+"', GioiTinh = '"+txtGioiTinh.Text+"', NgaySinh = '"+dtpNgaySinh.Text+"', DiaChi = '"+txtDiaChi.Text+"', DienThoai = '"+txtDienThoai.Text+"', Email = '"+txtEmail.Text+"', BangCap = '"+txtbangCap.Text+"', CMND = '"+txtCMND.Text+"', NgayVaoLam = '"+dtpNgayVaoLam.Text+"' where MaNhanVien = '"+txtMaNhanVien.Text+"'  ", con);
                //SqlCommand cmd = new SqlCommand("update tb_NhanVirn set TenNhanVien = '"+txtTenNhanVien.Text+"', GioiTinh = '"+txtGioiTinh.Text+"', NgaySinh = '"+dtpNgaySinh.Text+"', DiaChi = '"+txtDiaChi.Text+"', DienThoai = '"+txtDienThoai.Text+"', Email = '"+txtEmail.Text+", BangCap = '"+txtbangCap.Text+"', CMND = '"+txtCMND.Text+"', NgayVaoLam = '"+dtpNgayVaoLam.Text+"' where MaNhanVien = '"+txtMaNhanVien.Text+"' ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from tb_NhanVirn ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dtgQuanLyNhanVien.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Sửa thành công", "Quản lý  Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("delete tb_HopDong where MaNhanVien = '" + txtMaNhanVien.Text + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("delete tb_PhieuTra where MaNhanVien = '" + txtMaNhanVien.Text + "'  ", con);
                cmd2.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd3 = new SqlCommand("delete tb_NhanVirn where MaNhanVien = '" + txtMaNhanVien.Text + "'  ", con);
                cmd3.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from tb_NhanVirn ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dtgQuanLyNhanVien.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Xóa nhân viên thành công", "Quản lý  Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
       
    }
}
