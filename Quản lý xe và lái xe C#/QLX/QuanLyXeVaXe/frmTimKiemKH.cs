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
    public partial class frmTimKiemKH : Form
    {
        public frmTimKiemKH()
        {
            InitializeComponent();
        }

        private void cmdTimKiemKH_Click(object sender, EventArgs e)
        {
            if (rbTimKiemTheoMaKH.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as [Bằng cấp] from tb_KhachHang where MaKhachHang like '%" + txtTimKiemKH.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_KhachHang");
                dgvTimKiemKH.DataSource = ds.Tables["tb_KhachHang"].DefaultView;
            }
                        
            if (rbTimKiemTheoTenKH.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as[Bằng cấp] from tb_KhachHang where TenKhachHang like '%" + txtTimKiemKH.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_KhachHang");
                dgvTimKiemKH.DataSource = ds.Tables["tb_KhachHang"].DefaultView;
            }
                        
            if (rbTimKiemTheoDiaChiKH.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaKhachHang as [Mã khách hàng], TenKhachHang as [Tên khách hàng], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, BangCap as[Bằng cấp] from tb_KhachHang where DiaChi like '%" + txtTimKiemKH.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_KhachHang");
                dgvTimKiemKH.DataSource = ds.Tables["tb_KhachHang"].DefaultView;
            }
            
            if (rbTimKiemTheoMaHopDong.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select tb_KhachHang.MaKhachHang as [Mã khách hàng], tb_HopDong.MaHopDong as [Mã hợp đồng], tb_KhachHang.TenKhachHang as [Tên khách hàng], tb_KhachHang.NgaySinh as [Ngày sinh], tb_KhachHang.GioiTinh as [Giới tính], tb_KhachHang.DiaChi as [ Địa chỉ], tb_KhachHang.DienThoai as [Điện thoại], tb_KhachHang.CMND, tb_KhachHang.Email, tb_KhachHang.BangCap as[Bằng cấp] from tb_KhachHang, tb_HopDong where tb_HopDong.MaKhachHang = tb_KhachHang.MaKhachHang And tb_HopDong.MaHopDong like '%" + txtTimKiemKH.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_KhachHang");
                dgvTimKiemKH.DataSource = ds.Tables["tb_KhachHang"].DefaultView;
            }
        }

        private void frmTimKiemKH_Load(object sender, EventArgs e)
        {

        }
    }
}
