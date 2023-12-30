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
    public partial class frmTraXe1 : Form
    {
        public frmTraXe1()
        {
            InitializeComponent();
        }
        public static TextBox tb1 = new TextBox();
        private void Load_MaHDTraXe()
        {
            //DBAccess db = new DBAccess();
            //SqlConnection con = db.GetCon();
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("Select MaHopDong from tb_HopDong ", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //txtMaHD_Search.DisplayMember = "MaHopDong";
            //txtMaHD_Search.ValueMember = "MaHopDong";
            //txtMaHD_Search.DataSource = dt;
            //con.Close();
        }
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
        private void frmTraXe1_Load(object sender, EventArgs e)
        {
            //Load_MaHDTraXe();
            Load_NhanVien();
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaHopDong as [Mã hợp đồng], MaKhachHang as [Mã khách hàng], MaNhanVien as [Mã nhân viên], NgayTraXeThucTe as [ Ngày trả xe thực tế] from tb_PhieuTra", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();


            SqlDataAdapter da1 = new SqlDataAdapter("select MaHopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], NgayHetHan as [Ngày hết hạn], TinhTrang as [Tình trạng], TienDatCoc as [Tiền đặt cọc], TienThueHopDong as [Tiền thuê hợp đồng] from tb_HopDong", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            con.Close();
            da1.Dispose();

        }

        private void cmdTimKiem_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            SqlDataAdapter da = new SqlDataAdapter("select MaHopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], NgayHetHan as [Ngày hết hạn], TinhTrang as [Tình trạng], TienDatCoc as [Tiền đặt cọc], TienThueHopDong as [Tiền thuê hợp đồng] from tb_HopDong where MaHopDong = '" + txtMaHD_Search.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tb_HopDong");
            dataGridView2.DataSource = ds.Tables["tb_HopDong"].DefaultView;
        }
        //private SqlCommand sqlcmd;
        //private void txtMaHD_Search_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DBAccess db = new DBAccess();
        //    SqlConnection con = db.GetCon();
        //    con.Open();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sqlda = new SqlDataAdapter("select MaKhachHang from tb_HopDong where MaHopDong = '" + txtMaHD_Search.Text + "' ", con);
        //    sqlda.Fill(dt);
        //    txtMaKH.DataSource = dt;
        //    txtMaKH.DisplayMember = "MaKhachHang";

        //    con.Close();

            //DBAccess db = new DBAccess();
            //SqlConnection con = db.GetCon();
            //con.Open();
            //sqlcmd = con.CreateCommand();
            //sqlcmd.CommandText =
            //"select MaKhachHang from tb_HopDong where MaHopDong = '" + txtMaHD_Search.Text + "' ";
            //SqlDataReader dr = sqlcmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    txtMaKH = dr["MaKhachHang"].ToString();
            //    //txtMaKH = dr["MaKhachHang"].ToString();
            //}
            //dr.Close();
            //con.Close();
        //}

        private void txtMaHD_Search_TextChanged(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("select MaKhachHang from tb_HopDong where MaHopDong = '" + txtMaHD_Search.Text + "' ", con);
            sqlda.Fill(dt);
            txtMaKH.DataSource = dt;
            txtMaKH.DisplayMember = "MaKhachHang";

            DataTable dt1 = new DataTable();
            SqlDataAdapter sqlda1 = new SqlDataAdapter("select MaHopDong from tb_HopDong where MaHopDong = '" + txtMaHD_Search.Text + "' ", con);
            sqlda1.Fill(dt1);
            txtMaHD.DataSource = dt1;
            txtMaHD.DisplayMember = "MaHopDong";


            //DataTable dt2 = new DataTable();
            //SqlDataAdapter sqlda2 = new SqlDataAdapter("select MaKyLuat from tb_KyLuatKhacHang where MaKhachHang = '" + txtMaHD_Search.Text + "' ", con);
            //sqlda2.Fill(dt2);
            //txtMaKL.DataSource = dt2;
            //txtMaKL.DisplayMember = "MaKyLuat";


            con.Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                //if (db.CheckThanhToan_HD(txtMaHD.Text) == "Da thanh toan")
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_PhieuTra (MaHopDong, MaKhachHang, MaNhanVien, NgayTraXeThucTe) values ('" + txtMaHD.Text + "', '" + txtMaKH.Text + "', '" + txtMaNV.Text + "', '" + dtpNgayTraXeThucTe.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaHopDong as [Mã hợp đồng], MaKhachHang as [Mã khách hàng], MaNhanVien as [Mã nhân viên], NgayTraXeThucTe as [ Ngày trả xe thực tế] from tb_PhieuTra", con);
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

        private void cmdNext_Click(object sender, EventArgs e)
        {
            
        }
        //private SqlCommand sqlcmd;
        private void txtMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("select tb_LyLuatKhachHang.MaKyLuat from tb_LyLuatKhachHang where tb_LyLuatKhachHang.MaKhachHang = '" + txtMaKH.Text + "' ", con);
            sqlda.Fill(dt);
            txtMaKL.DataSource = dt;
            txtMaKL.DisplayMember = "MaKyLuat";
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
