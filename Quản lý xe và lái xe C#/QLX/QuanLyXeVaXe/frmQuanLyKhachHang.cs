using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.IO;

namespace QuanLyXeVaXe
{
    public partial class frmQuanLyKhachHang : Form
    {
        
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_KhachHang (MaKhachHang, TenKhachHang, NgaySinh, GioiTinh, DiaChi, CMND, DienThoai, Email, BangCap, TinhTrangKH) values ('" + Ma.Text + "', '" + Ten.Text + "', '" + NgaySinh.Text + "', '" + GioiTinh.Text + "', '" + DiaChi.Text + "', '" + CMND.Text + "', '" + DienThoai.Text + "', '" + Email.Text + "', '" + BangCap.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as [Bằng cấp] from tb_KhachHang ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Thêm thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Load_MaKH()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaKhachHang from tb_KhachHang", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            Ma.DataSource = dt1;
            Ma.DisplayMember = "MaKhachHang";
            Ma.ValueMember = "MaKhachHang";
            con.Close();
            da1.Dispose();
        }
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Load_MaKH();
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as [Bằng cấp] from tb_KhachHang ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
            //Tao combobox
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("update  tb_KhachHang set TenKhachHang = '" + Ten.Text + "', NgaySinh = '" + NgaySinh.Text + "', GioiTinh = '" + GioiTinh.Text + "', DiaChi = '" + DiaChi.Text + "', CMND = '" + CMND.Text + "', DienThoai = '" + DienThoai.Text + "', Email = '" + Email.Text + "',   BangCap = '" + BangCap.Text + "' where MaKhachHang = '" + Ma.Text + "' ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as [Bằng cấp] from tb_KhachHang ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
                //MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Quản lý khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show("Sửa thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as [Bằng cấp] from tb_KhachHang ", con);
            DataSet dt = new DataSet();
            da.Fill(dt, "tb_KhachHang");
            dataGridView1.DataSource = dt.Tables["tb_KhachHang"].DefaultView;
            con.Close();
            da.Dispose();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();


            SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as [Bằng cấp] from tb_KhachHang where MaKhachHang = '" + Ma.Text + "' ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("delete from tb_ChiTietHopDong ", con);
            cmd3.ExecuteNonQuery();
            con.Close();

            
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tb_HopDong ",con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("delete from tb_KhachHang ",con);
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as [Bằng cấp] from tb_KhachHang ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();   
        }

        private void cmdXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("delete tb_HopDong where MaKhachHang = '" + Ma.Text + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();

                //con.Open();
                //SqlCommand cmd1 = new SqlCommand("delete tb_LyLuatKhachHang where MaKhachHang = '" + Ma.Text + "' ", con);
                //cmd1.ExecuteNonQuery();
                //con.Close();

                con.Open();
                SqlCommand cmd3 = new SqlCommand("delete tb_PhieuTra where MaKhachHang = '" + Ma.Text + "' ", con);
                cmd3.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("delete tb_KhachHang where MaKhachHang = '" + Ma.Text + "'", con);
                cmd2.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as [Bằng cấp] from tb_KhachHang ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Xóa thành công","Quản lý khách hàng",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa thất bại","Lỗi cơ sở dữ liệu", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

   
        }

       
    }
}
//     SqlCommand cmd = new SqlCommand("delete tb_HopDong where MaKhachHang = '"+Ma.Text+"' ",con);  
//SqlCommand cmd2 = new SqlCommand("delete tb_KhachHang where MaKhachHang = '"+Ma.Text+"'",con);    