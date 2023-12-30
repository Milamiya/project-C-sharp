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
    public partial class frmQuanLyXe : Form
    {
        public frmQuanLyXe()
        {
            InitializeComponent();
        }
        public void Load_maxe()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaXe from tb_Xe", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            txtMaXe.DataSource = dt1;
            txtMaXe.DisplayMember = "MaXe";
            txtMaXe.ValueMember = "MaXe";
            con.Close();
            da1.Dispose();
        }
        private void cmdTHem_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_Xe (MaXe, TenXe, NgaySanXuat, HangXe, BienKiemSoat, SucChua, LoaiXe, NgayMuaXe, TinhTrangXe) values ('" + txtMaXe.Text + "', '" + txtTenXe.Text + "', '" + dtpNgaySanXuat.Text + "', '" + txtHangXe.Text + "', '" + txtBienKiemSoat.Text + "', '" + txtSucChua.Text + "', '" + txtLoaiXe.Text + "', '" + dtpNgayMuaXe.Text + "',  '" + txtTinhTrangXe.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe], TinhTrangXe as [Tình trạng xe] from tb_Xe ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dgvQuanLyXe.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Thêm thành công", "Quản lý Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch  
            {
              MessageBox.Show("Thêm thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmQuanLyXe_Load(object sender, EventArgs e)
        {
            Load_maxe();
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe], TinhTrangXe as [Tình trạng xe] from tb_Xe ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvQuanLyXe.DataSource = dt;
            con.Close();
            da.Dispose();
            
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe], TinhTrangXe as [Tình trạng xe] from tb_Xe ", con);
            SqlCommand cmd = new SqlCommand("insert into tb_Xe (MaXe, TenXe, NgaySanXuat, HangXe, BienKiemSoat, SucChua, LoaiXe, NgayMuaXe, TinhTrangXe) values ('" + txtMaXe.Text + "', '" + txtTenXe.Text + "', '" + dtpNgaySanXuat.Text + "', '" + txtHangXe.Text + "', '" + txtBienKiemSoat.Text + "', '" + txtSucChua.Text + "', '" + txtLoaiXe.Text + "', '" + dtpNgayMuaXe.Text + "', '" + txtTinhTrangXe.Text + "')", con);
            DataSet dt = new DataSet();
            da.Fill(dt, "tb_Xe");
            dgvQuanLyXe.DataSource = dt.Tables["tb_Xe"].DefaultView;
            da.Dispose();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("update  tb_Xe set TenXe = '" + txtTenXe.Text + "', NgaySanXuat = '" + dtpNgaySanXuat.Text + "', HangXe = '" + txtHangXe.Text + "', BienKiemSoat = '" + txtBienKiemSoat.Text + "', SucChua = '" + txtSucChua.Text + "', LoaiXe = '" + txtLoaiXe.Text + "', NgayMuaXe = '" + dtpNgayMuaXe.Text + "', TinhTrangXe = '"+txtTinhTrangXe.Text+"' Where  MaXe = '" + txtMaXe.Text +"' ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] , TinhTrangXe as [Tình trạng xe] from tb_Xe ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dgvQuanLyXe.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Sửa thành công", "Quản lý  Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] , TinhTrangXe as [Tình trạng xe] from tb_Xe Where MaXe = ('" + txtMaXe.Text + "') ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvQuanLyXe.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlCommand cmd = new SqlCommand("delete tb_ChiTietHopDong where MaXe = '" + txtMaXe.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("delete tb_ChiTietPhieuTra where MaXe = '" + txtMaXe.Text + "' ", con);
            cmd1.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("delete tb_Xe where MaXe = '" + txtMaXe.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] , TinhTrangXe as [Tình trạng xe] from tb_Xe Where MaXe = ('" + txtMaXe.Text + "') ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgvQuanLyXe.DataSource = dt;
            con.Close();
            da.Dispose();
            MessageBox.Show("Xóa xe thành công", "Quản lý xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

       
    }
}
