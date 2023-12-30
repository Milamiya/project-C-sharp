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
    public partial class frmTraXe2 : Form
    {
        public frmTraXe2()
        {
            InitializeComponent();
        }
        private void Load_MaKH()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaKhachHang from tb_KhachHang where TinhTrangKH = 'Chua Thanh Toan'", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            txtMaKH_Search.DataSource = dt1;
            txtMaKH_Search.DisplayMember = "MaKhachHang";
            txtMaKH_Search.ValueMember = "MaKhachHang";
            con.Close();
            da1.Dispose();
        }
        private void Load_MaKL()
        {
            //DBAccess db = new DBAccess();
            //SqlConnection con = db.GetCon();
            //con.Open();
            //SqlDataAdapter da1 = new SqlDataAdapter("select MaKyLuat from tb_LyLuatKhachHang", con);
            //DataTable dt1 = new DataTable();
            //dt1.Clear();
            //da1.Fill(dt1);
            //txtMaKL.DataSource = dt1;
            //txtMaKL.DisplayMember = "MaKyLuat";
            //txtMaKL.ValueMember = "MaKyLuat";
            //con.Close();
            //da1.Dispose();
        }
        private void frmTraXe2_Load(object sender, EventArgs e)
        {
            Load_MaKH();
            //Load_MaKL();

            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            DataTable dt = new DataTable();

            SqlDataAdapter sqlda = new SqlDataAdapter("select tb_LyLuatKhachHang.MaKyLuat from tb_LyLuatKhachHang where tb_LyLuatKhachHang.MaKhachHang = '" + txtMaKH_Search.Text + "' ", con);
            sqlda.Fill(dt);
            txtMaKL.DataSource = dt;
            txtMaKL.DisplayMember = "MaKyLuat";
        }

        private void cmdTim_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], MahopDong as [Mã hợp đồng],  NgayHetHan as [Ngày hết hạn] from tb_HopDong where MaKhachHang = ('" + txtMaKH_Search.Text + "')", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmaKH.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgayHetHan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtKhoiHanh.Text = dataGridViewX1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtKetThuc.Text = dataGridViewX1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dtpNgayTraXeThucTe_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayTraXeThucTe.Value > dtpNgayHetHan.Value)
            {
                MessageBox.Show("Khách hàng trả xe quá hạn quy địnhm, Hãy nhập Kỷ luật cho khách hàng :(", "Vi phạm hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdNhapMaKL_Click(object sender, EventArgs e)
        {
           
        }

        private void txtmaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            DataTable dt = new DataTable();

            SqlDataAdapter sqlda = new SqlDataAdapter("select tb_LyLuatKhachHang.MaKyLuat from tb_LyLuatKhachHang where MaKhachHang = '" + txtMaKH_Search.Text + "' ", con);
            sqlda.Fill(dt);
            txtMaKL.DataSource = dt;
            txtMaKL.DisplayMember = "MaKyLuat";
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tb_PhieuTra (MaHopDong, MaKhachHang, NgayTraXeThucTe, MaKyLuat) values ('"+txtMaHD.Text+"', '"+txtmaKH.Text+"', '"+dtpNgayTraXeThucTe.Text+"', '"+txtMaKL.Text+"')",con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("select MaHopDong as [Mã hợp đồng], MaKhachHang as [Mã khách hàng], MaNhanVien as [Mã nhân viên], NgayTraXeThucTe as [ Ngày trả xe thực tế] from tb_PhieuTra", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            da.Dispose();
            MessageBox.Show("Thêm thành công", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
