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
    public partial class frmQuanLyLaiXe : Form
    {
        public frmQuanLyLaiXe()
        {
            InitializeComponent();
        }
        private void Load_MaLaiXe()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe from tb_LaiXe", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txtMaLaiXe.DataSource = dt;
            txtMaLaiXe.DisplayMember = "MaLaiXe";
            txtMaLaiXe.ValueMember = "MaLaiXe";
            con.Close();
            da.Dispose();
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {
            //try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_LaiXe (MaLaiXe, TenLaiXe, NgaySinh, GioiTinh, DiaChi, DienThoai, CMND,Email, NgayNhanViec,TinhTrangLaiXe) values ('" + txtMaLaiXe.Text + "', '" + txtTenLaiXe.Text + "', '" + dtpNgaySinh.Text + "','" + txtGioiTinh.Text + "', '" + txtDiaChi.Text + "', '" + txtDienThoai.Text + "', '" + txtCMND.Text + "', '" + txtEmail.Text + "', '" + dtpNgayNhanViec.Text + "', '"+txtTinhTrangLaiXe.Text+"')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dgvQuanLyLaiXe.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Thêm thành công", "Quản lý lái xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           // catch
           // {
             //   MessageBox.Show("Thêm thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe ", con);
            DataSet dt = new DataSet();
            da.Fill(dt, "tb_LaiXe");
            dgvQuanLyLaiXe.DataSource = dt.Tables["tb_LaiXe"].DefaultView;
            con.Close();
            da.Dispose();
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe Where MaLaiXe = ('"+txtMaLaiXe.Text+"')", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvQuanLyLaiXe.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void frmQuanLyLaiXe_Load(object sender, EventArgs e)
        {
            Load_MaLaiXe();
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvQuanLyLaiXe.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("update  tb_LaiXe set TenLaiXe = '" + txtTenLaiXe.Text + "', NgaySinh = '" + dtpNgaySinh.Text + "', GioiTinh = '" + txtGioiTinh.Text + "', DiaChi = '" + txtDiaChi.Text + "', DienThoai = '" + txtDienThoai.Text + "', CMND = '" + txtCMND.Text + "', Email = '" + txtEmail.Text + "', NgayNhanViec = '" +dtpNgayNhanViec.Text+ "', TinhTrangLaiXe = '"+txtTinhTrangLaiXe.Text+"' where MaLaiXe = '" + txtMaLaiXe.Text + "' ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dgvQuanLyLaiXe.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Sửa thành công", "Quản lý lái xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlCommand cmd = new SqlCommand("delete tb_ChiTietHopDong where Malaixe = '" + txtMaLaiXe.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("delete tb_ChiTietPhieuTra where Malaixe = '" + txtMaLaiXe.Text + "' ", con);
            cmd1.ExecuteNonQuery();
            con.Close();

            //con.Open();
            //SqlCommand cmd3 = new SqlCommand("delete tb_KyLuatLai where Malaixe = '" + txtMaLaiXe.Text + "' ", con);
            //cmd3.ExecuteNonQuery();
            //con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("delete tb_LaiXe where Malaixe = '" + txtMaLaiXe.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvQuanLyLaiXe.DataSource = dt;
            con.Close();
            da.Dispose();
            MessageBox.Show("Xóa lái xe thành công", "Quản lý lái xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
