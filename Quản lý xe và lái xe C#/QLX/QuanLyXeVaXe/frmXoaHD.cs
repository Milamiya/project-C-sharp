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
    public partial class frmXoaHD : Form
    {
        public frmXoaHD()
        {
            InitializeComponent();
        }

        private void frmXoaHD_Load(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], MahopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong where MahopDong = ('" + textBox1.Text + "')", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("delete tb_ChiTietPhieuTra where MaHopDong = '" + textBox1.Text + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                //con.Open();
                //SqlCommand cmd8 = new SqlCommand("update tb_Xe set tb_Xe.TinhTrangXe = 'NOT BUSY' where MaXe = '" + txtMaXe.Text + "'", con);
                //cmd8.ExecuteNonQuery();
                //con.Close();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("delete tb_PhieuTra where MaHopDong = '" + textBox1.Text + "'  ", con);
                cmd2.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd3 = new SqlCommand("delete tb_ChiTietHopDong where MaHopDong = '" + textBox1.Text + "'  ", con);
                cmd3.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd4 = new SqlCommand("delete tb_HopDong where MaHopDOng = '" + textBox1.Text + "'  ", con);
                cmd4.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_HopDong.TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], tb_HopDong.MaNhanVien as [Mã nhân viên] , HanThanhToan as [Hạn thanh toán] ,TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Xóa hợp đồng thành công", "Quản lý hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
