using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmDanhSachHDX : Form
    {
        public frmDanhSachHDX()
        {
            InitializeComponent();
        }

        private void frmDanhSachHDX_Load(object sender, EventArgs e)
        {
            chkListBox.Items.Insert(0, "Mã hóa đơn");
            chkListBox.Items.Insert(1, "Tên nhân viên");
            chkListBox.Items.Insert(2, "Mã mặt hàng");
            chkListBox.Items.Insert(3, "Tên mặt hàng");
            chkListBox.Items.Insert(4, "Số lượng");
            chkListBox.Items.Insert(5, "Ngày xuất");
            chkListBox.Items.Insert(6, "Đơn giá");
            chkListBox.Items.Insert(7, "Thuế");
            chkListBox.Items.Insert(8, "Đơn vị tính");
            chkListBox.Items.Insert(9, "Ghi chú");
            HienThi();
        }

        private void HienThi()
        {
            string select = "SELECT tblHoaDonXuat.MaHD [Mã hóa đơn],tblNhanVien.TenNhanVien [Nhân viên],tblChiTietHDX.MaMatH [Mã hàng],tblMatHang.TenMatH [Mặt hàng],tblChiTietHDX.SoLuong [Số lượng],tblHoaDonXuat.NgayXuat [Ngày xuất],tblChiTietHDX.DonGia [Đơn giá],Thue [Thuế],DonViTinh [Đơn vị tính],tblHoaDonXuat.GhiChu [Ghi chú]" +
                            " FROM tblHoaDonXuat INNER JOIN tblChiTietHDX ON tblHoaDonXuat.MaHD=tblChiTietHDX.MaHD" +
                            " INNER JOIN tblMatHang ON tblMatHang.MaMatH=tblChiTietHDX.MaMatH" +
                            " INNER JOIN tblNhanVien ON tblNhanVien.MaNhanVien=tblHoaDonXuat.MaNhanVien";
            DataSet ds = DataConn.GrdSource(select);
            grdView.DataSource = ds.Tables[0];
            grdView.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "";
                delete = "DELETE tblChiTietHDX WHERE MaHD='" + txtMa.Text + "'";
                DataConn.ThucHienCmd(delete);
                delete = "DELETE tblHoaDonXuat WHERE MaHD='" + txtMa.Text + "'";
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
                        string select = "SELECT tblHoaDonXuat.MaHD,tblNhanVien.TenNhanVien,tblChiTietHDX.MaMatH,tblMatHang.TenMatH,tblChiTietHDX.SoLuong,tblHoaDonXuat.NgayXuat,tblChiTietHDX.DonGia,Thue,DonViTinh,tblHoaDonXuat.GhiChu" +
                            " FROM tblHoaDonXuat INNER JOIN tblChiTietHDX ON tblHoaDonXuat.MaHD=tblChiTietHDX.MaHD" +
                            " INNER JOIN tblMatHang ON tblMatHang.MaMatH=tblChiTietHDX.MaMatH" +
                            " INNER JOIN tblNhanVien ON tblNhanVien.MaNhanVien=tblHoaDonXuat.MaNhanVien" +
                            " WHERE tblHoaDonXuat.MaHD=N'" + grdView.Rows[hang].Cells[0].Value.ToString() + "'" +
                            " AND tblChiTietHDX.MaMatH=N'" + grdView.Rows[hang].Cells[2].Value.ToString() + "'";
                        DataSet ds = DataConn.GrdSource(select);

                        //cboMaNhanVien.Text = ds.Tables[0].Rows[0]["TenNhanVien"].ToString();
                        //cboMaMatH.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                        //txtMaHD.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
                        //txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                        //pckNgayXuat.Text = ds.Tables[0].Rows[0]["NgayXuat"].ToString();
                        //txtDonGia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString();
                        //txtThue.Text = ds.Tables[0].Rows[0]["Thue"].ToString();
                        //txtDonViTinh.Text = ds.Tables[0].Rows[0]["DonViTinh"].ToString();
                        //txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                        txtMa.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
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
                MessageBox.Show("Hóa đơn xuất này chưa có hoặc bạn chưa chọn hóa đơn!");
                return;
            }
            frmInHDX inhdx = new frmInHDX(txtMa.Text);
            inhdx.ShowDialog();
        }

    }
}