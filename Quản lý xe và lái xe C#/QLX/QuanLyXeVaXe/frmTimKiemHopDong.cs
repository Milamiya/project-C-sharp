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
    public partial class frmTimKiemHopDong : Form
    {
        public frmTimKiemHopDong()
        {
            InitializeComponent();
        }

        private void cmdTimKiemHopDong_Click(object sender, EventArgs e)
        {
            if (rbTimKiemTheoMaHD.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_HopDong where MaHopDong like '%" + txtTimKiemHopDong.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_HopDong");
                dgvTimKiemHopDong.DataSource = ds.Tables["tb_HopDong"].DefaultView;

            }



            if (rbTimKiemTheoTenHD.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_HopDong where TenHopDong like '%" + txtTimKiemHopDong.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_HopDong");
                dgvTimKiemHopDong.DataSource = ds.Tables["tb_HopDong"].DefaultView;
            }




            if (rbTimKiemHDTheoMaLX.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaHopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng], HanThanhToan as [Ngày hết hạn], tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaNhanVien as [Mã nhân viên],  TinhTrangThanhToan as [Tình trạng thanh toán], tb_ChiTietHopDong.Malaixe as [Mã lái xe] from tb_HopDong, tb_ChiTietHopDong where tb_HopDong.MaHopDong = tb_ChiTietHopDong.MaHopDong And tb_ChiTietHopDong.MaLaiXe like '%" + txtTimKiemHopDong.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_HopDong");
                dgvTimKiemHopDong.DataSource = ds.Tables["tb_HopDong"].DefaultView;
            }



            if (rbTimKiemHDTheoMaKH.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select tb_HopDong.MaHopDong as [Mã hợp đồng], TenHopDong as [Tên hợp đồng], NgayLapHopDong as [Ngày lập hợp đồng],  HanThanhToan, tb_HopDong.MaKhachHang as [Mã khách hàng], tb_HopDong.MaNhanVien as [Mã nhân viên],  TinhTrangThanhToan as [Tình trạng thanh toán] from tb_HopDong where  tb_HopDong.MaKhachHang like '%" + txtTimKiemHopDong.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tb_HopDong");
                dgvTimKiemHopDong.DataSource = ds.Tables["tb_HopDong"].DefaultView;
            }
        }
    }
}
