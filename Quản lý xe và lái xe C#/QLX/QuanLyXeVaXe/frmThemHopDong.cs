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
    public partial class frmThemHopDong : Form
    {
        public frmThemHopDong()
        {
            InitializeComponent();
        }
        public static TextBox tb1 = new TextBox();
        public static TextBox tb2 = new TextBox();
        public void Load_MaNV()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien from tb_NhanVirn", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txtMaNhanVien.DataSource = dt;
            txtMaNhanVien.DisplayMember = "MaNhanVien";
            txtMaNhanVien.ValueMember = "MaNhanVien";
            con.Close();
            da.Dispose();
        }

        public void Load_MaHopDOng()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaHopDOng from tb_HopDOng", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txtMaHopDong.DataSource = dt;
            txtMaHopDong.DisplayMember = "MaHopDOng";
            txtMaHopDong.ValueMember = "MaHopDOng";
            con.Close();
            da.Dispose();
        }
        private void cmdThem_Click(object sender, EventArgs e)
        {
           try
            {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tb_HopDong (MaHopDong, TenHopDong, NgayLapHopDong, MaKhachHang,MaNhanVien, HanThanhToan, TinhTrangThanhToan) values ('" + txtMaHopDong.Text + "', '" + txtTenHopDong.Text + "', '" + dtpNgaylapHongDong.Text + "', '" + txtMakhachhang.Text + "', '" + txtMaNhanVien.Text + "', '" + dtpHanThanhToan.Text + "', '" + cbTinhTrangThanhToan.Checked + "')   ", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên], HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", con);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dgvThemHopDong.DataSource = dt;
                    con.Close();
                    da.Dispose();
                    MessageBox.Show("Thêm thành công,Chuyển sang bước tiếp theo để tiếp tục việc lập hợp đồng", "Lập hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            tb1.Text = txtMaHopDong.Text;
            tb2.Text = dtpNgaylapHongDong.Text;
            frmChiTietHopDong f1 = new frmChiTietHopDong();
            f1.Show();
        }

        private void frmThemHopDong_Load(object sender, EventArgs e)
        {
            txtMakhachhang.Text = frmQuanLyHopDong.tb.Text;

            Load_MaNV();
            Load_MaHopDOng();

            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvThemHopDong.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], MahopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong where MahopDong = ('" + txtMaHopDong.Text + "')", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dgvThemHopDong.DataSource = dt;
                con.Close();
                da.Dispose();
            }
        }

        private void gbThemHopDong_Enter(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvThemHopDong.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void dtpNgayHetHanHopDong_ValueChanged(object sender, EventArgs e)
        {
            //if(dtpNgayHetHanHopDong.Value <= dtpNgaylapHongDong.Value){
            //    MessageBox.Show("Ngày lập HĐ >= Ngày hết hạn HĐ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dtpNgayHetHanHopDong.Value <= dtpNgaylapHongDong.Value)
                //{
                //    MessageBox.Show("Ngày lập HĐ >= Ngày hết hạn HĐ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("update tb_HopDong set TenHopDong = '" + txtTenHopDong.Text + "', NgayLapHopDong = '" + dtpNgaylapHongDong.Text + "', MaKhachHang = '" + txtMakhachhang.Text + "', MaNhanVien = '" + txtMaNhanVien.Text + "', HanThanhToan = '" + dtpHanThanhToan.Text + "' , TinhTrangThanhToan = '" + cbTinhTrangThanhToan.Checked + "' where MaHopDong = ('" + txtMaHopDong.Text + "')       ", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", con);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dgvThemHopDong.DataSource = dt;
                    con.Close();
                    da.Dispose();
                    MessageBox.Show("Sửa thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaylapHongDong_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpNgayHetHanHopDong.Value <= dtpNgaylapHongDong.Value)
            //{
            //    MessageBox.Show("Ngày lập HĐ >= Ngày hết hạn HĐ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLaiXe f = new frmLaiXe();
            f.Show();
        }
    }
}
