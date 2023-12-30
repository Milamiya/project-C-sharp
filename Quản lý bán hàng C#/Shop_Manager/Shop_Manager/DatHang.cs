using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmDatHang : Form
    {
        public frmDatHang()
        {
            InitializeComponent();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            groupDatHangCT.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = false;
            btnHoan.Enabled = false;
            btnInPhieu.Enabled = false;
            txtMaPhieu.Text = "";
            txtTenKhach.Text = "";
            txtDienThoai.Text = "";
            txtGhiChu.Text = "";
            txtMaPhieu.Select();

            string select = "select* from tblMatHang";
            DataSet ds = DataConn.GrdSource(select);
            cboMatHang.DataSource = ds.Tables[0];
            cboMatHang.DisplayMember = "TenMatH";
            cboMatHang.ValueMember = "MaMatH";
            HienThi();
            //btnDatHang_Click(sender, e);
        }

        private void HienThi()
        {
            string select = "select tblDatHangCT.MaPhieu [Mã phiếu],tblDatHangCT.MaMatH [Mã hàng],TenMatH [Tên hàng],TenKhachH [Khách hàng],tblDatHangCT.SoLuong [Số lượng],NgayDat [Ngày đặt],NgayNhan [Ngày nhận],DienThoai [Điện thoại],GhiChu [Ghi chú] from tblDatHangCT inner join tblMatHang on tblDatHangCT.MaMatH=tblMatHang.MaMatH"+
                " INNER JOIN tblDatHang ON tblDatHang.MaPhieu=tblDatHangCT.MaPhieu WHERE tblDatHang.MaPhieu='"+txtMaPhieu.Text+"'";
            DataSet ds = DataConn.GrdSource(select);
            grdKq.DataSource = ds.Tables[0];
            grdKq.Refresh();
        }

        string values = "";
        private void cboMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMatHang.ValueMember != null)
            {
                values = cboMatHang.SelectedValue.ToString();
            }
        }

        private void mnuDonDat_Click(object sender, EventArgs e)
        {
            //frmThemDonDatH themdon = new frmThemDonDatH();
            //themdon.ShowDialog();
        }

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
                    string select = "SELECT tblDatHangCT.MaPhieu,tblDatHangCT.MaMatH,TenMatH,TenKhachH,tblDatHangCT.SoLuong,NgayDat,NgayNhan,DienThoai,GhiChu from tblDatHangCT inner join tblMatHang on tblDatHangCT.MaMatH=tblMatHang.MaMatH"+ 
                        " INNER JOIN tblDatHang ON tblDatHang.MaPhieu=tblDatHangCT.MaPhieu"+
                        " where tblDatHangCT.MaPhieu=N'" + grdKq.Rows[hang].Cells[0].Value.ToString() + "'"+
                        " AND tblDatHangCT.MaMatH='" + grdKq.Rows[hang].Cells[1].Value.ToString() + "'";
                    DataSet ds = DataConn.GrdSource(select);

                    txtMaPhieu.Text = ds.Tables[0].Rows[0]["MaPhieu"].ToString();
                    txtTenKhach.Text = ds.Tables[0].Rows[0]["TenKhachH"].ToString();
                    pckNgayDat.Text = ds.Tables[0].Rows[0]["NgayDat"].ToString();
                    pckNgayNhan.Text = ds.Tables[0].Rows[0]["NgayNhan"].ToString();
                    cboMatHang.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                    txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                    txtDienThoai.Text = ds.Tables[0].Rows[0]["DienThoai"].ToString();
                    txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                    txtMaH.Text = ds.Tables[0].Rows[0]["MaMatH"].ToString();
                }
                else
                    return;
            }
        }

        private void grdKq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (grdKq.RowCount > 0)
            //{
            //    if (grdKq.CurrentCell == null)
            //    {
            //        return;
            //    }
            //    if (grdKq.CurrentCell.RowIndex < grdKq.RowCount)
            //    {
            //        int hang = grdKq.CurrentCell.RowIndex;
            //        string select = "select tblDatHang.MaMatH,TenMatH,NgayDat,NgayNhan from tblDatHang inner join tblMatHang on tblDatHang.MaMatH=tblMatHang.MaMatH where tblMatHang.TenMatH=N'" + grdKq.Rows[hang].Cells[0].Value.ToString() + "'";
            //        DataSet ds = DataConn.GrdSource(select);
            //        txtMatHang.Text = ds.Tables[0].Rows[0][0].ToString();
            //    }
            //    else
            //        return;
            //}
        }

        private bool kt;
        private void btnDatHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhieu.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã phiếu đặt hàng!", "Chú ý!");
                    txtMaPhieu.Select();
                    return;
                }
                if (txtTenKhach.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên khách hàng!", "Chú ý!");
                    txtTenKhach.Select();
                    return;
                }
                if (txtDienThoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập điện thoại liên hệ của khách hàng!", "Chú ý!");
                    txtDienThoai.Select();
                    return;
                }
                string s = "SELECT MaPhieu FROM tblDatHang";
                SqlDataReader dr = DataConn.ThucHienReader(s);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaPhieu.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                string select = "INSERT INTO tblDatHang(MaPhieu,TenKhachH,DienThoai,GhiChu) VALUES(N'" + txtMaPhieu.Text + "',N'" + txtTenKhach.Text + "','" + txtDienThoai.Text + "',N'" + txtGhiChu.Text + "')";
                DataConn.ThucHienCmd(select);
                groupDatHangCT.Enabled = true;
                btnThem_Click(sender, e);
                cboMatHang.Select();
            }
            catch (SameKeyException)
            {
                MessageBox.Show("Đã có mã phiếu này! Hãy nhập mã phiếu khác!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //kt = true;
            //btnDatHang.Enabled = false;
            //btnGhi.Enabled = true;
            //btnHoan.Enabled = true;
            //btnSua.Enabled = false;
            //btnThoat.Enabled = true;
            //btnXoa.Enabled = false;
            //btnInPhieu.Enabled = false;

            //txtMaPhieu.ReadOnly = false;
            //txtDienThoai.ReadOnly = false;
            //txtGhiChu.ReadOnly = false;
            //txtSoLuong.ReadOnly = false;
            //txtTenKhach.ReadOnly = false;
            //cboMatHang.Enabled = true;
            //pckNgayDat.Enabled = true;
            //pckNgayNhan.Enabled = true;

            //txtDienThoai.Text = "";
            //txtGhiChu.Text = "";
            //txtSoLuong.Text = "";
            //txtTenKhach.Text = "";
            //cboMatHang.Text = "";
            //txtMaPhieu.Text = "";
            //pckNgayDat.Text = DateTime.Today.TimeOfDay.ToString();
            //pckNgayNhan.Text = DateTime.Today.TimeOfDay.ToString();
            //txtMaPhieu.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            btnDatHang.Enabled = false;
            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            btnSua.Enabled = false;
            btnThoat.Enabled = true;
            btnXoa.Enabled = false;
            btnInPhieu.Enabled = false;
            btnThem.Enabled = false;

            txtDienThoai.ReadOnly = false;
            txtMaPhieu.ReadOnly = true;
            txtGhiChu.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtTenKhach.ReadOnly = false;
            cboMatHang.Enabled = true;
            pckNgayDat.Enabled = true;
            pckNgayNhan.Enabled = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (kt == true)//Thêm đơn đặt hàng chi tiết
            {
                string select = "";
                try
                {
                    //Exception khi không đủ dữ liệu
                    
                    if (cboMatHang.Text == "")
                    {
                        MessageBox.Show("Hãy chọn mặt hàng!", "Chú ý!");
                        cboMatHang.Select();
                        return;
                    }
                    if (txtSoLuong.Text == "")
                    {
                        MessageBox.Show("Hãy nhập số lượng mặt hàng!", "Chú ý!");
                        txtSoLuong.Select();
                        return;
                    }
                    if (pckNgayDat.Text == "")
                    {
                        MessageBox.Show("Hãy nhập ngày đặt hàng!", "Chú ý!");
                        pckNgayDat.Select();
                        return;
                    }
                    if (pckNgayNhan.Text == "")
                    {
                        MessageBox.Show("Hãy nhập ngày nhận hàng!", "Chú ý!");
                        pckNgayNhan.Select();
                        return;
                    }

                    if (double.Parse(txtSoLuong.Text) <= 0)
                    {
                        MessageBox.Show("Số lượng không được nhỏ hơn 0!");
                        txtSoLuong.Select();
                        return;
                    }
                    
                    //Exception khi năm nhận nhỏ hơn năm đặt
                    if (pckNgayNhan.Value.Year < pckNgayDat.Value.Year)
                        throw new TimeLogicException();

                    //Exception nếu năm nhận bằng nhau mà tháng nhận lại nhỏ hơn tháng đặt
                    else
                        if ((pckNgayNhan.Value.Year == pckNgayDat.Value.Year) && (pckNgayNhan.Value.Month < pckNgayDat.Value.Month))
                            throw new TimeLogicException();

                    //Exception nếu năm tháng nhận bằng nhau mà ngày nhận lại nhỏ hơn ngày đặt
                        else
                            if ((pckNgayDat.Value.Year == pckNgayNhan.Value.Year) && (pckNgayDat.Value.Month == pckNgayNhan.Value.Month)
                                && (pckNgayDat.Value.Day > pckNgayNhan.Value.Day))
                                throw new TimeLogicException();

                    //Exception khi sai định dạng
                    if (float.Parse(txtSoLuong.Text) < 0)
                        throw new FormatException();

                    string s = "SELECT MaMatH FROM tblDatHangCT WHERE MaPhieu='"+txtMaPhieu.Text+"'";
                    SqlDataReader dr = DataConn.ThucHienReader(s);
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            if (dr.GetString(0) == values)
                            {
                                dr.Close();
                                dr.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();

                    
                    //Thêm vào bảng chi tiết đặt hàng
                    select = "INSERT INTO tblDatHangCT VALUES('"+txtMaPhieu.Text+"','"+values+"',"+txtSoLuong.Text+",'"+pckNgayDat.Text+"','"+pckNgayNhan.Text+"')";
                    DataConn.ThucHienCmd(select);
                    
                    HienThi();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn nhập chưa đúng định dạng của dữ liệu cần thiết! Hãy xem lại hoặc nhấn F1 để vào trợ giúp!");
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Hãy nhập các dữ liệu trước khi nhấn nút ghi!");
                }
                catch (TimeLogicException)
                {
                    MessageBox.Show("Chưa hợp lý về mặt thời gian!");
                }
                catch (SameKeyException)
                {
                    MessageBox.Show("Đã có mặt hàng này trong phiếu đặt hàng!","Thông báo!");
                }
            }
            else
            {
                string update = "";
                try
                {
                    
                    //Exception khi không đủ dữ liệu
                    if (cboMatHang.Text == "" && txtTenKhach.Text == "" && pckNgayDat.Text == "" && pckNgayNhan.Text == "" && txtDienThoai.Text == ""&&txtMaPhieu.Text=="")
                        throw new NotEnoughInfoException();
                    if (double.Parse(txtSoLuong.Text) <= 0)
                    {
                        MessageBox.Show("Số lượng không được nhỏ hơn 0!");
                        txtSoLuong.Select();
                        return;
                    }
                    
                    string s = "SELECT MaMatH FROM tblDatHangCT WHERE MaPhieu='" + txtMaPhieu.Text + "'";
                    SqlDataReader dr = DataConn.ThucHienReader(s);
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            if (dr.GetString(0) == values)
                            {
                                dr.Close();
                                dr.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();
                    //Sửa
                    
                    update = "UPDATE tblDatHangCT SET MaMatH='" + values + "' WHERE MaPhieu='" + txtMaPhieu.Text + "' AND MaMatH='" + txtMaH.Text + "'";
                    DataConn.ThucHienCmd(update);

                    //update = "UPDATE tblDatHangCT SET SoLuong="+txtSoLuong.Text+",NgayDat='"+pckNgayDat.Text+"',NgayNhan='"+pckNgayNhan.Text+"' WHERE MaPhieu='"+txtMaPhieu.Text+"'";
                    //DataConn.ThucHienCmd(update);

                    HienThi();
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Hãy nhập các dữ liệu trước khi nhấn nút ghi!");
                }
                catch (SameKeyException)
                {
                    update = "UPDATE tblDatHangCT SET SoLuong=" + txtSoLuong.Text + ",NgayDat='" + pckNgayDat.Text + "',NgayNhan='" + pckNgayNhan.Text + "' WHERE MaPhieu='" + txtMaPhieu.Text + "' AND MaMatH='"+values+"'";
                    DataConn.ThucHienCmd(update);

                    HienThi();
                    //MessageBox.Show("Đã có mặt hàng này trong phiếu đặt hàng!", "Thông báo!");
                }
            }
        }

        private void btnHoan_Click(object sender, EventArgs e)
        {
            btnDatHang.Enabled = true;
            btnGhi.Enabled = false;
            btnHoan.Enabled = false;
            btnSua.Enabled = true;
            btnThoat.Enabled = true;
            btnXoa.Enabled = true;
            btnInPhieu.Enabled = true;
            btnThem.Enabled = true;
            groupDatHang.Enabled = true;

            txtMaPhieu.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtTenKhach.ReadOnly = true;
            cboMatHang.Enabled = false;
            pckNgayDat.Enabled = false;
            pckNgayNhan.Enabled = false;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhieu.Text == "")
                    throw new NotEnoughInfoException();

                string delete = "DELETE tblDatHangCT WHERE MaPhieu='" + txtMaPhieu.Text + "' AND MaMatH='" + values + "' AND SoLuong=" + txtSoLuong.Text + " AND NgayDat='" + pckNgayDat.Text + "' AND NgayNhan='" + pckNgayNhan.Text + "'";
                DataConn.ThucHienCmd(delete);
                
                HienThi();
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu đặt hàng hoặc chưa có phiếu nào với mã này!", "Thông báo!");
                txtMaPhieu.Select();
            }
        }

        private void btnInPhieu_Click_1(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Hãy nhập mã phiếu để in!","Thông báo!");
                txtMaPhieu.Select();
                return;
            }
            frmInPhieu inphieu = new frmInPhieu(txtMaPhieu.Text);
            inphieu.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            //btnDatHang.Enabled = false;
            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            btnSua.Enabled = false;
            //btnThoat.Enabled = true;
            btnXoa.Enabled = false;
            btnInPhieu.Enabled = false;
            btnThem.Enabled = false;

            //txtMaPhieu.ReadOnly = false;
            //txtDienThoai.ReadOnly = false;
            //txtGhiChu.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            //txtTenKhach.ReadOnly = false;
            cboMatHang.Enabled = true;
            pckNgayDat.Enabled = true;
            pckNgayNhan.Enabled = true;

            //txtDienThoai.Text = "";
            //txtGhiChu.Text = "";
            txtSoLuong.Text = "";
            //txtTenKhach.Text = "";
            cboMatHang.Text = "";
            //txtMaPhieu.Text = "";
            pckNgayDat.Text = DateTime.Today.TimeOfDay.ToString();
            pckNgayNhan.Text = DateTime.Today.TimeOfDay.ToString();
        }
    }
}