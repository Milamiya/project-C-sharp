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
    public partial class frmTraXe : Form
    {
        public frmTraXe()
        {
            InitializeComponent();
        }
        public static TextBox tb1 = new TextBox();
        
        private void Load_NhanVien()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select MaNhanVien from tb_NhanVirn ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtMaNV.DisplayMember = "MaNhanVien";
            txtMaNV.ValueMember = "MaNhanVien";
            txtMaNV.DataSource = dt;
            con.Close();
        }
        private void Load_MaHDTraXe()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select MaHopDong from tb_HopDong ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtMaHD_Search.DisplayMember = "MaHopDong";
            txtMaHD_Search.ValueMember = "MaHopDong";
            txtMaHD_Search.DataSource = dt;
            con.Close();
        }
        private void frmTraXe_Load(object sender, EventArgs e)
        {
            Load_MaHDTraXe();
            Load_NhanVien();

            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaHopDong as [Mã hợp đồng], MaPhieuTra as [Mã Phiếu Trả], MaKhachHang as [Mã khách hàng], MaNhanVien as [Mã nhân viên], NgayTraXeThucTe as [ Ngày trả xe thực tế] from tb_PhieuTra" , con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();

        }
        private void cmdNext_Click(object sender, EventArgs e)
        {
            
            //tb1.Text = txtMaHD.Text;
            
        }

        private void cmdNhapVao_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaHopDong from tb_HopDong where MahopDong = ('" + txtMaKH.Text + "')", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
                SqlCommand cmd = new SqlCommand("insert into tb_PhieuTra (MaHopDong, MaPhieuTra, MaKhachHang, MaNhanVien, NgayTraXeThucTe) values ('" + txtMaHD.Text + "', '" + txtMaPhieuTra.Text + "', '" + txtMaKH.Text + "', '" + txtMaNV.Text + "', '" + dtpNgayTraXeThucTe.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaHopDong as [Mã hợp đồng], MaPhieuTra as [Mã Phiếu Trả], MaKhachHang as [Mã khách hàng], MaNhanVien as [Mã nhân viên], NgayTraXeThucTe as [ Ngày trả xe thực tế] from tb_PhieuTra", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Thêm thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            SqlDataAdapter da = new SqlDataAdapter("select MaHopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], NgayHetHan as [Ngày hết hạn], TinhTrang as [Tình trạng], TienDatCoc as [Tiền đặt cọc], TienThueHopDong as [Tiền thuê hợp đồng] from tb_HopDong where MaHopDong like '%" + txtMaHD_Search.Text + "%'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_HopDong");
            dataGridView2.DataSource = ds.Tables["tb_HopDong"].DefaultView;
        }

        //private SqlCommand sqlcmd;
        //private void txtMaHD_Search_TextChanged(object sender, EventArgs e)
        //{
        //    DBAccess db = new DBAccess();
        //    SqlConnection con = db.GetCon();
        //    con.Open();
        //    sqlcmd = con.CreateCommand();
        //    sqlcmd.CommandText =
        //   // "select MaHopDong, MaKhachHang from tb_HopDong where MaHopDong = '" + txtMaHD_Search.Text + "' ";
        //    "select MaKhachHang from tb_HopDong where MaHopDong = '" + txtMaHD_Search.Text + "' ";
        //    SqlDataReader dr = sqlcmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        //txtMaHD = dr["MaHopDong"].ToString();
        //        //txtMaHD = dr["MaHopDong"].ToString();
        //        txtMaKH = dr["MaKhachHang"].ToString();
        //    }
        //    dr.Close();
        //    con.Close();
        //}

        private void txtMaHD_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("select MaHopDong,MaKhachHang from tb_HopDong where MaHopDong='" + txtMaHD_Search.Text + "'", con);
            sqlda.Fill(dt1);
            //txtMaHD
            txtMaHD.DataSource = dt1;
            txtMaHD.DisplayMember = "MaHopDong";
            con.Close();
        }
        
 
    }
}
