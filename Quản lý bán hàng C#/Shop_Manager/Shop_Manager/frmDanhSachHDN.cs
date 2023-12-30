using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmDanhSachHDN : Form
    {
        public frmDanhSachHDN()
        {
            InitializeComponent();
        }

        private void frmDanhSachHDN_Load(object sender, EventArgs e)
        {
            chkListBox.Items.Insert(0, "Mã hóa đơn");
            chkListBox.Items.Insert(1, "Tên nhà cung cấp");
            chkListBox.Items.Insert(2, "Mã mặt hàng");
            chkListBox.Items.Insert(3, "Tên mặt hàng");
            chkListBox.Items.Insert(4, "Số lượng");
            chkListBox.Items.Insert(5, "Ngày nhập");
            chkListBox.Items.Insert(6, "Đơn giá");
            chkListBox.Items.Insert(7, "Thuế");
            chkListBox.Items.Insert(8, "Đơn vị tính");
            chkListBox.Items.Insert(9, "Ghi chú");
            HienThi();
        }

        private void HienThi()
        {
            string select = "SELECT tblHoaDonNhap.MaHD [Mã hóa đơn],TenNCC [Nhà cung cấp],tblChiTietHDN.MaMatH [Mã mặt hàng],TenMatH [Mặt hàng],tblChiTietHDN.SoLuong [Số lượng],NgayNhap [Ngày nhập],tblChiTietHDN.DonGia [Đơn giá],Thue [Thuế],tblChiTietHDN.DonViTinh [Đơn vị tính],tblHoaDonNhap.GhiChu [Ghi chú]" +
                " FROM tblHoaDonNhap INNER JOIN tblChiTietHDN ON tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD" +
                " INNER JOIN tblMatHang ON tblChiTietHDN.MaMatH=tblMatHang.MaMatH" +
                " INNER JOIN tblNhaCungCap ON tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC";
            DataSet ds = DataConn.GrdSource(select);
            grdView.DataSource = ds.Tables[0];
            grdView.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "";
                delete = "DELETE tblChiTietHDN WHERE MaHD='"+txtMa.Text+"'";
                DataConn.ThucHienCmd(delete);
                delete = "DELETE tblHoaDonNhap WHERE MaHD='"+txtMa.Text+"'";
                DataConn.ThucHienCmd(delete);
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grdView.RowCount > 0)
            {
                if (grdView.CurrentCell == null)
                    return;
                if (grdView.CurrentCell.RowIndex < grdView.RowCount)
                {
                    try
                    {
                        int hang = grdView.CurrentCell.RowIndex;
                        string select = "SELECT tblHoaDonNhap.MaHD,TenNCC,tblChiTietHDN.MaMatH,TenMatH,tblChiTietHDN.SoLuong,NgayNhap,tblChiTietHDN.DonGia,Thue,tblChiTietHDN.DonViTinh,tblHoaDonNhap.GhiChu" +
                                        " FROM tblHoaDonNhap INNER JOIN tblChiTietHDN ON tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD" +
                                        " INNER JOIN tblMatHang ON tblChiTietHDN.MaMatH=tblMatHang.MaMatH" +
                                        " INNER JOIN tblNhaCungCap ON tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC" +
                                        " WHERE tblHoaDonNhap.MaHD=N'" + grdView.Rows[hang].Cells[0].Value.ToString() + "'" +
                                        " AND tblChiTietHDN.MaMatH=N'" + grdView.Rows[hang].Cells[2].Value.ToString() + "'";
                        DataSet ds = DataConn.GrdSource(select);
                        txtMa.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
                        //cboMaNCC.Text = ds.Tables[0].Rows[0]["TenNCC"].ToString();
                        //txtMaH.Text = ds.Tables[0].Rows[0]["MaMatH"].ToString();
                        //cboMaMatH.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                        //txtMaHoaDon.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
                        //txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                        //pckNgayNhap.Text = ds.Tables[0].Rows[0]["NgayNhap"].ToString();
                        //txtDonGia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString();
                        //txtThue.Text = ds.Tables[0].Rows[0]["Thue"].ToString();
                        //txtDonViTinh.Text = ds.Tables[0].Rows[0]["DonViTinh"].ToString();
                        //txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                        //MessageBox.Show(txtMaH.Text);
                        //v = ds.Tables[0].Rows[0]["MaMatH"].ToString();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Định dạng dữ liệu không đúng!", "Thông báo!");
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

        private void chkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkListBox.GetItemChecked(0) == true)
                grdView.Columns[0].Visible = true;
            else
                grdView.Columns[0].Visible = false;

            if (chkListBox.GetItemChecked(1) == true)
                grdView.Columns[1].Visible = true;
            else
                grdView.Columns[1].Visible = false;

            if (chkListBox.GetItemChecked(2) == true)
                grdView.Columns[2].Visible = true;
            else
                grdView.Columns[2].Visible = false;

            if (chkListBox.GetItemChecked(3) == true)
                grdView.Columns[3].Visible = true;
            else
                grdView.Columns[3].Visible = false;

            if (chkListBox.GetItemChecked(4) == true)
                grdView.Columns[4].Visible = true;
            else
                grdView.Columns[4].Visible = false;

            if (chkListBox.GetItemChecked(5) == true)
                grdView.Columns[5].Visible = true;
            else
                grdView.Columns[5].Visible = false;

            if (chkListBox.GetItemChecked(6) == true)
                grdView.Columns[6].Visible = true;
            else
                grdView.Columns[6].Visible = false;

            if (chkListBox.GetItemChecked(7) == true)
                grdView.Columns[7].Visible = true;
            else
                grdView.Columns[7].Visible = false;

            if (chkListBox.GetItemChecked(8) == true)
                grdView.Columns[8].Visible = true;
            else
                grdView.Columns[8].Visible = false;

            if (chkListBox.GetItemChecked(9) == true)
                grdView.Columns[9].Visible = true;
            else
                grdView.Columns[9].Visible = false;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Hóa đơn nhập này chưa có hoặc bạn chưa chọn hóa đơn!");
                return;
            }
            frmInHDN inhdn = new frmInHDN(txtMa.Text);
            inhdn.ShowDialog();
        }
    }
}