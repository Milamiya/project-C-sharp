using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmHDN : Form
    {
        public frmHDN()
        {
            InitializeComponent();
        }

        private void frmHDN_Load(object sender, EventArgs e)
        {
            string select = "select* from tblMatHang";
            DataSet ds = DataConn.GrdSource(select);
            cboMaMatH.DataSource = ds.Tables[0];
            cboMaMatH.DisplayMember = "TenMatH";
            cboMaMatH.ValueMember = "MaMatH";

            //select = "select tblNhaCungCap.TenNCC,tblNhaCungCap.MaNCC from tblNhaCungCap inner join tblMatHang on tblNhaCungCap.MaMatH=tblMatHang.MaMatH and tblNhaCungCap.MaMatH=N'" + cboMaMatH.SelectedValue.ToString() + "'";
            select = "select* from tblNhaCungCap";
            ds = DataConn.GrdSource(select);
            cboMaNCC.DataSource = ds.Tables[0];
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";

            txtMaMatH.Text = "";
            txtMaNCC.Text = "";
        }

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNCC.ValueMember != null)
            {
                txtMaNCC.Text = cboMaNCC.SelectedValue.ToString();
            }
        }

        private void cboMaMatH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMatH.ValueMember != null)
            {
                txtMaMatH.Text = cboMaMatH.SelectedValue.ToString();
            }
        }

        //Load from grid
        private void grdKq_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grdKq.RowCount > 0)
            {
                if (grdKq.CurrentCell == null)
                    return;
                if (grdKq.CurrentCell.RowIndex < grdKq.RowCount)
                {
                    try
                    {
                        int hang = grdKq.CurrentCell.RowIndex;
                        string ma = grdKq.Rows[hang].Cells[0].Value.ToString();
                        string ma2 = grdKq.Rows[hang].Cells[1].Value.ToString();
                        string select = "select tblHoaDonNhap.MaHD,tblMatHang.TenMatH,tblMatHang.MaMatH,tblNhaCungCap.TenNCC,tblNhaCungCap.MaNCC,tblHoaDonNhap.NgayNhap,tblChiTietHDN.SoLuong,tblChiTietHDN.DonGia" +
                    " from (((tblNhaCungCap inner join tblHoaDonNhap on tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC)" +
                    " inner join tblChiTietHDN on tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD)" +
                    " inner join tblMatHang on tblChiTietHDN.MaMatH=tblMatHang.MaMatH)"
                        + "WHERE tblHoaDonNhap.MaHD=N'" + ma + "' AND tblMatHang.TenMatH=N'"+ma2+"'";

                        DataSet ds = DataConn.GrdSource(select);
                        txtMaHD.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
                        cboMaMatH.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                        txtMaMatH.Text = ds.Tables[0].Rows[0]["MaMatH"].ToString();
                        txtMaNCC.Text = ds.Tables[0].Rows[0]["MaNCC"].ToString();
                        cboMaNCC.Text = ds.Tables[0].Rows[0]["TenNCC"].ToString();
                        pckNgayNhap.Text = ds.Tables[0].Rows[0]["NgayNhap"].ToString();
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

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string select="";
            try
            {
                //Tìm kiếm khi không có bất kỳ dữ liệu nào (liệt kê toàn bộ các hóa đơn)
                if (txtMaMatH.Text == "" && txtMaNCC.Text == "" && pckNgayNhap.Text!="")
                    select = "select tblHoaDonNhap.MaHD Mã_hóa_đơn,tblMatHang.TenMatH Tên_mặt_hàng,tblNhaCungCap.TenNCC Tên_nhà_cung_cấp,tblChiTietHDN.SoLuong Số_lượng,tblChiTietHDN.DonGia Đơn_giá,tblHoaDonNhap.NgayNhap Ngày_nhập,tblHoaDonNhap.DonViTinh Đơn_vị_tính" +
                    " from (((tblNhaCungCap inner join tblHoaDonNhap on tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC)" +
                    " inner join tblChiTietHDN on tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD)" +
                    " inner join tblMatHang on tblChiTietHDN.MaMatH=tblMatHang.MaMatH)";

                //Tìm kiếm theo mã mặt hàng
                else if (txtMaMatH.Text != "" && txtMaNCC.Text == "" && pckNgayNhap.Text!="")
                    select = "select tblHoaDonNhap.MaHD Mã_hóa_đơn,tblMatHang.TenMatH Tên_mặt_hàng,tblNhaCungCap.TenNCC Tên_nhà_cung_cấp,tblChiTietHDN.SoLuong Số_lượng,tblChiTietHDN.DonGia Đơn_giá,tblHoaDonNhap.NgayNhap Ngày_nhập,tblHoaDonNhap.DonViTinh Đơn_vị_tính" +
                    " from (((tblNhaCungCap inner join tblHoaDonNhap on tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC)" +
                    " inner join tblChiTietHDN on tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD)" +
                    " inner join tblMatHang on tblChiTietHDN.MaMatH=tblMatHang.MaMatH)" +
                    " where tblChiTietHDN.MaMatH=N'" + txtMaMatH.Text + "'";

                //Tìm kiếm theo mã nhà cung cấp
                else if (txtMaMatH.Text == "" && txtMaNCC.Text != "" && pckNgayNhap.Text!="")
                    select = "select tblHoaDonNhap.MaHD Mã_hóa_đơn,tblMatHang.TenMatH Tên_mặt_hàng,tblNhaCungCap.TenNCC Tên_nhà_cung_cấp,tblChiTietHDN.SoLuong Số_lượng,tblChiTietHDN.DonGia Đơn_giá,tblHoaDonNhap.NgayNhap Ngày_nhập,tblHoaDonNhap.DonViTinh Đơn_vị_tính" +
                    " from (((tblNhaCungCap inner join tblHoaDonNhap on tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC)" +
                    " inner join tblChiTietHDN on tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD)" +
                    " inner join tblMatHang on tblChiTietHDN.MaMatH=tblMatHang.MaMatH)" +
                    " where tblNhaCungCap.MaNCC=N'" + txtMaNCC.Text + "'";

                //Tìm kiếm theo tất cả các dữ liệu nếu có đủ
                else if (txtMaMatH.Text != "" && txtMaNCC.Text != "" && pckNgayNhap.Text!="")
                    select = "select tblHoaDonNhap.MaHD Mã_hóa_đơn,tblMatHang.TenMatH Tên_mặt_hàng,tblNhaCungCap.TenNCC Tên_nhà_cung_cấp,tblChiTietHDN.SoLuong Số_lượng,tblChiTietHDN.DonGia Đơn_giá,tblHoaDonNhap.NgayNhap Ngày_nhập,tblHoaDonNhap.DonViTinh Đơn_vị_tính" +
                    " from (((tblNhaCungCap inner join tblHoaDonNhap on tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC)" +
                    " inner join tblChiTietHDN on tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD)" +
                    " inner join tblMatHang on tblChiTietHDN.MaMatH=tblMatHang.MaMatH)" +
                    " where tblHoaDonNhap.NgayNhap=N'" + pckNgayNhap.Text + "'" +
                    " and tblMatHang.MaMatH=N'" + txtMaMatH.Text + "' and tblNhaCungCap.MaNCC=N'" + txtMaNCC.Text + "'";
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
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập chưa đúng định dạng dữ liệu của một trường dữ liệu nào đó! Hãy vào trợ giúp hoặc nhấn F1!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //try 
            //{
            //    if (txtSoLuong.Text == "" || txtDonGia.Text == "")
            //        throw new NotEnoughInfoException();
            //    string update = "UPDATE tblChiTietHDN SET SoLuong='"+txtSoLuong.Text+"',tblChiTietHDN.DonGia='"+txtDonGia.Text+"' WHERE MaMatH=N'"+txtMaMatH.Text+"'";
            //    DataConn.ThucHienCmd(update);

            //    string select = "select tblMatHang.TenMatH Tên_mặt_hàng,tblNhaCungCap.TenNCC Tên_nhà_cung_cấp,tblChiTietHDN.SoLuong Số_lượng,tblChiTietHDN.DonGia Đơn_giá,tblHoaDonNhap.NgayNhap Ngày_nhập,tblHoaDonNhap.DonViTinh Đơn_vị_tính" +
            //        " from (((tblNhaCungCap inner join tblHoaDonNhap on tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC)" +
            //        " inner join tblChiTietHDN on tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD)" +
            //        " inner join tblMatHang on tblChiTietHDN.MaMatH=tblMatHang.MaMatH)";
            //    DataSet ds = DataConn.GrdSource(select);
            //    grdKq.DataSource = ds.Tables[0];
            //    grdKq.Refresh();
            //}
            //catch (NotEnoughInfoException)
            //{
            //    MessageBox.Show("Không đủ dữ liệu để sửa!");
            //}
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong.Text == "" || txtDonGia.Text == "")
                    throw new NotEnoughInfoException();
                string update = "UPDATE tblChiTietHDN SET SoLuong='" + txtSoLuong.Text + "',tblChiTietHDN.DonGia='" + txtDonGia.Text + "' WHERE MaMatH=N'" + txtMaMatH.Text + "' AND MaHD=N'"+txtMaHD.Text+"'";
                string update2 = "UPDATE tblHoaDonNhap SET NgayNhap=N'"+pckNgayNhap.Text+"' WHERE MaHD=N'"+txtMaHD.Text+"'";
                DataConn.ThucHienCmd(update);
                DataConn.ThucHienCmd(update2);
                MessageBox.Show("Đã sửa hóa đơn nhập!");

                string select = "select tblHoaDonNhap.MaHD Mã_hóa_đơn,tblMatHang.TenMatH Tên_mặt_hàng,tblNhaCungCap.TenNCC Tên_nhà_cung_cấp,tblChiTietHDN.SoLuong Số_lượng,tblChiTietHDN.DonGia Đơn_giá,tblHoaDonNhap.NgayNhap Ngày_nhập,tblHoaDonNhap.DonViTinh Đơn_vị_tính" +
                    " from (((tblNhaCungCap inner join tblHoaDonNhap on tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC)" +
                    " inner join tblChiTietHDN on tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD)" +
                    " inner join tblMatHang on tblChiTietHDN.MaMatH=tblMatHang.MaMatH)";
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