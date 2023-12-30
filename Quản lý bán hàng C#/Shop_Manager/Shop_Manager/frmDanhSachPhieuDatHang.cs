using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmDanhSachPhieuDatHang : Form
    {
        public frmDanhSachPhieuDatHang()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhieuDatHang_Load(object sender, EventArgs e)
        {

            //Đưa dữ liệu vào listbox
            chkListBox.Items.Insert(0, "Mã phiếu");
            chkListBox.Items.Insert(1, "Mã hàng");
            chkListBox.Items.Insert(2, "Tên hàng");
            chkListBox.Items.Insert(3, "Khách hàng");
            chkListBox.Items.Insert(4, "Số lượng");
            chkListBox.Items.Insert(5, "Ngày đặt");
            chkListBox.Items.Insert(6, "Ngày nhận");
            chkListBox.Items.Insert(7, "Điện thoại");
            chkListBox.Items.Insert(8, "Ghi chú");
            //chkListBox.Items.Insert(9, "Ghi chú");
            HienTHi();
        }

        private void HienTHi()
        {
            string select = "select tblDatHangCT.MaPhieu [Mã phiếu],tblDatHangCT.MaMatH [Mã hàng],TenMatH [Tên hàng],TenKhachH [Khách hàng],tblDatHangCT.SoLuong [Số lượng],NgayDat [Ngày đặt],NgayNhan [Ngày nhận],DienThoai [Điện thoại],GhiChu [Ghi chú] from tblDatHangCT inner join tblMatHang on tblDatHangCT.MaMatH=tblMatHang.MaMatH INNER JOIN tblDatHang ON tblDatHang.MaPhieu=tblDatHangCT.MaPhieu";
            DataSet ds = DataConn.GrdSource(select);
            grdKq.DataSource = ds.Tables[0];
            grdKq.Refresh();
        }

        //Load từ grid lên textbox
        private void grdKq_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grdKq.RowCount > 0)
            {
                if (grdKq.CurrentCell == null)
                {
                    return;
                }
                if (grdKq.CurrentCell.RowIndex < grdKq.RowCount)
                {
                    int hang = grdKq.CurrentCell.RowIndex;
                    string select = "SELECT tblDatHangCT.MaPhieu,tblDatHangCT.MaMatH,TenMatH,TenKhachH,tblDatHangCT.SoLuong,NgayDat,NgayNhan,DienThoai,GhiChu from tblDatHangCT inner join tblMatHang on tblDatHangCT.MaMatH=tblMatHang.MaMatH" +
                        " INNER JOIN tblDatHang ON tblDatHang.MaPhieu=tblDatHangCT.MaPhieu" +
                        " where tblDatHangCT.MaPhieu=N'" + grdKq.Rows[hang].Cells[0].Value.ToString() + "'" +
                        " AND tblDatHangCT.MaMatH='" + grdKq.Rows[hang].Cells[1].Value.ToString() + "'";
                    DataSet ds = DataConn.GrdSource(select);

                    txtMa.Text = ds.Tables[0].Rows[0]["MaPhieu"].ToString();
                    //txtTenKhach.Text = ds.Tables[0].Rows[0]["TenKhachH"].ToString();
                    //pckNgayDat.Text = ds.Tables[0].Rows[0]["NgayDat"].ToString();
                    //pckNgayNhan.Text = ds.Tables[0].Rows[0]["NgayNhan"].ToString();
                    //cboMatHang.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                    //txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                    //txtDienThoai.Text = ds.Tables[0].Rows[0]["DienThoai"].ToString();
                    //txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                    //txtMaH.Text = ds.Tables[0].Rows[0]["MaMatH"].ToString();
                }
                else
                    return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "DELETE tblDatHangCT WHERE MaPhieu='"+txtMa.Text+"'";
                DataConn.ThucHienCmd(delete);
                delete = "DELETE tblDatHang WHERE MaPhieu='" + txtMa.Text + "'";
                DataConn.ThucHienCmd(delete);
                HienTHi();
                //txtMa.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bật tắt các cột hiển thị
            if (chkListBox.GetItemChecked(0) == true)
                grdKq.Columns[0].Visible = true;
            else
                grdKq.Columns[0].Visible = false;

            if (chkListBox.GetItemChecked(1) == true)
                grdKq.Columns[1].Visible = true;
            else
                grdKq.Columns[1].Visible = false;

            if (chkListBox.GetItemChecked(2) == true)
                grdKq.Columns[2].Visible = true;
            else
                grdKq.Columns[2].Visible = false;

            if (chkListBox.GetItemChecked(3) == true)
                grdKq.Columns[3].Visible = true;
            else
                grdKq.Columns[3].Visible = false;

            if (chkListBox.GetItemChecked(4) == true)
                grdKq.Columns[4].Visible = true;
            else
                grdKq.Columns[4].Visible = false;

            if (chkListBox.GetItemChecked(5) == true)
                grdKq.Columns[5].Visible = true;
            else
                grdKq.Columns[5].Visible = false;

            if (chkListBox.GetItemChecked(6) == true)
                grdKq.Columns[6].Visible = true;
            else
                grdKq.Columns[6].Visible = false;

            if (chkListBox.GetItemChecked(7) == true)
                grdKq.Columns[7].Visible = true;
            else
                grdKq.Columns[7].Visible = false;

            if (chkListBox.GetItemChecked(8) == true)
                grdKq.Columns[8].Visible = true;
            else
                grdKq.Columns[8].Visible = false;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Phiếu đặt hàng này chưa có hoặc bạn chưa chọn phiếu đặt hàng!");
                return;
            }
            frmInPhieu inphieu = new frmInPhieu(txtMa.Text);
            inphieu.ShowDialog();
        }
    }
}