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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void cmdTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            if (rbTimKiemNhanVienTheoMa.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayVaoLam as [Ngày vào làm], BangCap as [Bằng cấp] from tb_NhanVirn where MaNhanVien like '%" + txtTimKiemNhanVien.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_NhanVirn");
                dgvTimKiemNhanVien.DataSource = ds.Tables["tb_NhanVirn"].DefaultView;

            }



            if (rbTimKiemNhanVienTheoTen.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayVaoLam as [Ngày vào làm], BangCap as [Bằng cấp] from tb_NhanVirn where TenNhanVien like '%" + txtTimKiemNhanVien.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_NhanVirn");
                dgvTimKiemNhanVien.DataSource = ds.Tables["tb_NhanVirn"].DefaultView;
            }




            if (rbTimKiemNhanVienTheoDiaChi.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayVaoLam as [Ngày vào làm], BangCap as [Bằng cấp] from tb_NhanVirn where DiaChi like '%" + txtTimKiemNhanVien.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_NhanVirn");
                dgvTimKiemNhanVien.DataSource = ds.Tables["tb_NhanVirn"].DefaultView;
            }



            if (rbTimKiemNhanVienTheoNgayVaoLam.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaNhanVien as [Mã nhân viên], TenNhanVien as [Tên nhân viên], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayVaoLam as [Ngày vào làm], BangCap as [Bằng cấp] from tb_NhanVirn where NgayVaoLam like '%" + txtTimKiemNhanVien.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_NhanVirn");
                dgvTimKiemNhanVien.DataSource = ds.Tables["tb_NhanVirn"].DefaultView;
            }
        }
    }
}
