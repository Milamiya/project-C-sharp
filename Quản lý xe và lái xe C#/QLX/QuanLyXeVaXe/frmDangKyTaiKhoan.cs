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
    public partial class frmDangKyTaiKhoan : Form
    {
        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tb_Login (userid, pass, role) values ('" + txtID.Text + "', '" + txtPass.Text + "', '" +txtNguoiDung.Text +"')", con);
                cmd.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], GioiTinh as [Giới tính], NgaySinh as [Ngày sinh], DiaChi as  [Địa chỉ], DienThoai as [Điện thoại], Email, BangCap as [Bằng cấp], CMND, NgayVaoLam as [Ngày vào làm] from tb_NhanVirn ", con);
                //DataTable dt = new DataTable();
                //dt.Clear();
                //da.Fill(dt);
                //dtgQuanLyNhanVien.DataSource = dt;
                con.Close();
                //da.Dispose();
                MessageBox.Show("Đăng kí thành công", "Đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Đăng kí thất bại, vui lòng kiểm tra lại thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
