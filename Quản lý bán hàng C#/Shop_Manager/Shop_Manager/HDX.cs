using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmHDX : Form
    {
        public frmHDX()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string select;
            try
            {
                //Tìm kiếm tất cả các hóa đơn xuất
                if (txtMaMatH.Text == "" && pckNgayXuat.Text!="")
                    select = "select tblHoaDonXuat.MaHD Mã_hóa_đơn,tblMatHang.TenMatH Mặt_hàng,tblNhanVien.TenNhanVien Nhân_viên,tblHoaDonXuat.NgayXuat Ngày_xuất,tblChiTietHDX.SoLuong Số_lượng,tblChiTietHDX.DonGia Đơn_giá,tblHoaDonXuat.DonViTinh Đơn_vị_tính" +
                        " from (((tblMatHang inner join tblChiTietHDX on tblMatHang.MaMatH=tblChiTietHDX.MaMatH)" +
                        " inner join tblHoaDonXuat on tblChiTietHDX.MaHD=tblHoaDonXuat.MaHD)" +
                        " inner join tblNhanVien on tblHoaDonXuat.MaNhanVien=tblNhanVien.MaNhanVien)";
                
                //Tìm kiếm khi có đủ tất cả các dữ liệu
                else if (txtMaMatH.Text != "" && pckNgayXuat.Text!="")
                    select = "select tblHoaDonXuat.MaHD Mã_hóa_đơn,tblMatHang.TenMatH Mặt_hàng,tblNhanVien.TenNhanVien Nhân_viên,tblHoaDonXuat.NgayXuat Ngày_xuất,tblChiTietHDX.SoLuong Số_lượng,tblChiTietHDX.DonGia Đơn_giá,tblHoaDonXuat.DonViTinh Đơn_vị_tính" +
                        " from (((tblMatHang inner join tblChiTietHDX on tblMatHang.MaMatH=tblChiTietHDX.MaMatH)" +
                        " inner join tblHoaDonXuat on tblChiTietHDX.MaHD=tblHoaDonXuat.MaHD)" +
                        " inner join tblNhanVien on tblHoaDonXuat.MaNhanVien=tblNhanVien.MaNhanVien)" +
                        " where tblHoaDonXuat.NgayXuat=N'" + pckNgayXuat.Text + "'"+
                        " and tblChiTietHDX.MaMatH=N'" + txtMaMatH.Text + "'";  

                else
                    throw new NotEnoughInfoException();

                DataSet ds = DataConn.GrdSource(select);
                grdKq.DataSource = ds.Tables[0];
                grdKq.Refresh();
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn chưa nhập đúng dữ liệu để hiển thị! Hãy vào trợ giúp hoặc nhấn F1!");
            }
        }

        private void frmHDX_Load(object sender, EventArgs e)
        {
            string select = "select* from tblMatHang";
            DataSet ds = DataConn.GrdSource(select);
            cboMaMatH.DataSource = ds.Tables[0];
            cboMaMatH.DisplayMember = "TenMatH";
            cboMaMatH.ValueMember = "MaMatH";
            txtMaMatH.Text = "";
        }

        private void cboMaMatH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMatH.ValueMember != null)
            {
                txtMaMatH.Text = cboMaMatH.SelectedValue.ToString();
            }
        }

        private void grdKq_CurrentCellChanged(object sender, System.EventArgs e)
        {
            if (grdKq.RowCount > 0)
            {
                if (grdKq.CurrentCell == null)
                {
                    return;
                }
                if (grdKq.CurrentCell.RowIndex < grdKq.RowCount)
                {
                    try
                    {
                        int hang = grdKq.CurrentCell.RowIndex;
                        string ma = grdKq.Rows[hang].Cells[0].Value.ToString();
                        string ma2 = grdKq.Rows[hang].Cells[1].Value.ToString();
                        string select = "select tblHoaDonXuat.MaHD,tblMatHang.MaMatH,tblMatHang.TenMatH,tblHoaDonXuat.NgayXuat,tblChiTietHDX.SoLuong,tblChiTietHDX.DonGia" +
                    " FROM tblHoaDonXuat inner join tblChiTietHDX on tblHoaDonXuat.MaHD=tblChiTietHDX.MaHD" +
                    " inner join tblMatHang on tblChiTietHDX.MaMatH=tblMatHang.MaMatH"
                        + " WHERE tblHoaDonXuat.MaHD=N'" + ma + "' AND tblMatHang.TenMatH=N'"+ma2+"'";
                        DataSet ds = DataConn.GrdSource(select);
                        txtMaHD.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
                        cboMaMatH.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                        txtMaMatH.Text = ds.Tables[0].Rows[0]["MaMatH"].ToString();
                        pckNgayXuat.Text = ds.Tables[0].Rows[0]["NgayXuat"].ToString();
                        txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                        txtDonGia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString();
                    }
                    catch (Exception se)
                    {
                        MessageBox.Show("" + se.Message);
                    }
                }
                else
                    return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDonGia.Text == "" || txtSoLuong.Text == "")
                    throw new NotEnoughInfoException();
                string update = "UPDATE tblChiTietHDX SET SoLuong='"+txtSoLuong.Text+"',DonGia='"+txtDonGia.Text+"' WHERE MaMatH=N'"+txtMaMatH.Text+"' AND MaHD=N'"+txtMaHD.Text+"'";
                string update2 = "UPDATE tblHoaDonXuat SET NgayXuat=N'"+pckNgayXuat.Text+"' WHERE MaHD=N'"+txtMaHD.Text+"'";
                DataConn.ThucHienCmd(update);
                DataConn.ThucHienCmd(update2);
                MessageBox.Show("Đã sửa hóa đơn xuất!");

                string select="select tblHoaDonXuat.MaHD Mã_hóa_đơn,tblMatHang.TenMatH Mặt_hàng,tblNhanVien.TenNhanVien Nhân_viên,tblHoaDonXuat.NgayXuat Ngày_xuất,tblChiTietHDX.SoLuong Số_lượng,tblChiTietHDX.DonGia Đơn_giá,tblHoaDonXuat.DonViTinh Đơn_vị_tính" +
                        " from (((tblMatHang inner join tblChiTietHDX on tblMatHang.MaMatH=tblChiTietHDX.MaMatH)" +
                        " inner join tblHoaDonXuat on tblChiTietHDX.MaHD=tblHoaDonXuat.MaHD)" +
                        " inner join tblNhanVien on tblHoaDonXuat.MaNhanVien=tblNhanVien.MaNhanVien)";
                DataSet ds = DataConn.GrdSource(select);
                grdKq.DataSource = ds.Tables[0];
                grdKq.Refresh();
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Không đủ dữ liệu để sửa!");
            }
        }
    }
}