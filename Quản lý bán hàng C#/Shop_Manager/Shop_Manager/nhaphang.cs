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
    public partial class frmNhap : Form
    {
        public frmNhap()
        {
            InitializeComponent();
        }

        private void frmNhap_Load(object sender, EventArgs e)
        {
            pckNgayNhap.Text = DateTime.Today.TimeOfDay.ToString();
            txtMaHoaDon.Text = "";
            cboMaNCC.Text = "";
            txtGhiChu.Text = "";

            groupChiTietHDN.Enabled = false;
            btnGhi.Enabled = false;
            btnHoan.Enabled = false;
            btnInHD.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnNhap.Enabled = true;
            btnThem.Enabled = false;
            txtMaHoaDon.Select();

            string select1 = "select* from tblNhaCungCap";
            string select2 = "select* from tblMatHang";
            try
            {
                DataSet ds = DataConn.GrdSource(select1);
                cboMaNCC.DataSource = ds.Tables[0];
                cboMaNCC.DisplayMember = "TenNCC";
                cboMaNCC.ValueMember = "MaNCC";
                if (cboMaNCC.ValueMember != null)
                    values1 = ds.Tables[0].Rows[cboMaNCC.SelectedIndex][0].ToString();

                ds = DataConn.GrdSource(select2);
                cboMaMatH.DataSource = ds.Tables[0];
                cboMaMatH.DisplayMember = "TenMatH";
                cboMaMatH.ValueMember = "MaMatH";
                if (cboMaMatH.ValueMember != null)
                    values2 = ds.Tables[0].Rows[cboMaMatH.SelectedIndex][0].ToString();
                HienThi();
                //btnNhap_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Không đúng định dạng dữ liệu cần thiết! Hãy xem trợ giúp!");
            }
        }

        private bool kt;

        string values1 = "";
        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNCC.ValueMember != null)
            {
                values1 = cboMaNCC.SelectedValue.ToString();
            }
        }

        string values2 = "";
        //string v = "";
        private void cboMaMatH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMatH.ValueMember != null)
            {
                values2 = cboMaMatH.SelectedValue.ToString();
                //v = cboMaMatH.SelectedValue.ToString();
                //MessageBox.Show(values2);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHoaDon.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã hóa đơn!", "Chú ý!");
                    txtMaHoaDon.Select();
                    return;
                }
                if (cboMaNCC.Text == "")
                {
                    MessageBox.Show("Hãy chọn nhà cung cấp!", "Chú ý!");
                    cboMaNCC.Select();
                    return;
                }
                if (pckNgayNhap.Text == "")
                {
                    MessageBox.Show("Hãy chọn ngày nhập!", "Chú ý!");
                    pckNgayNhap.Select();
                    return;
                }

                string select1 = "select tblHoaDonNhap.MaHD from tblHoaDonNhap";
                SqlDataReader dr = DataConn.ThucHienReader(select1);

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaHoaDon.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                
                string select="";
                select = "insert into tblHoaDonNhap(MaHD,MaNCC,NgayNhap,GhiChu) values(N'" + txtMaHoaDon.Text + "',N'" + values1 + "',N'" + pckNgayNhap.Text + "',N'"+txtGhiChu.Text+"')";
                DataConn.ThucHienCmd(select);
                HienThi();

                groupChiTietHDN.Enabled = true;
                btnThem_Click(sender, e);
                cboMaMatH.Select();
            }
            
            catch (SameKeyException)
            {
                MessageBox.Show("Đã có mã hóa đơn này!","Thông báo!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng dữ liệu không đúng!", "Thông báo!");
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
            //kt = true;
            //cboMaMatH.Enabled = true;
            //cboMaNCC.Enabled = true;
            //txtDonGia.ReadOnly = false;
            //txtDonViTinh.ReadOnly = false;
            //txtGhiChu.ReadOnly = false;
            //txtMaHoaDon.ReadOnly = false;
            //txtSoLuong.ReadOnly = false;
            //pckNgayNhap.Enabled = true;
            //txtThue.ReadOnly = false;

            //btnGhi.Enabled = true;
            //btnHoan.Enabled = true;
            //btnNhap.Enabled = false;
            //btnThoat.Enabled = true;
            //btnInHD.Enabled = false;

            //cboMaMatH.Text = "";
            //cboMaNCC.Text = "";
            //txtDonGia.Text = "";
            //txtDonViTinh.Text = "";
            //txtGhiChu.Text = "";
            //txtMaHoaDon.Text = "";
            //txtSoLuong.Text = "";
            //pckNgayNhap.Text = DateTime.Today.TimeOfDay.ToString();
            
        }

        private void HienThi()
        {
            string select = "SELECT tblHoaDonNhap.MaHD [Mã hóa đơn],TenNCC [Nhà cung cấp],tblChiTietHDN.MaMatH [Mã mặt hàng],TenMatH [Mặt hàng],tblChiTietHDN.SoLuong [Số lượng],NgayNhap [Ngày nhập],tblChiTietHDN.DonGia [Đơn giá],Thue [Thuế],tblChiTietHDN.DonViTinh [Đơn vị tính],tblHoaDonNhap.GhiChu [Ghi chú]" +
                " FROM tblHoaDonNhap INNER JOIN tblChiTietHDN ON tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD"+
                " INNER JOIN tblMatHang ON tblChiTietHDN.MaMatH=tblMatHang.MaMatH"+
                " INNER JOIN tblNhaCungCap ON tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC"+
                " WHERE tblHoaDonNhap.MaHD='"+txtMaHoaDon.Text+"'";
            DataSet ds = DataConn.GrdSource(select);
            grdNhapHang.DataSource = ds.Tables[0];
            grdNhapHang.Refresh();
        }

        private void mặtHàngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmNewMatH mhm = new frmNewMatH();
            //mhm.ShowDialog();
        }

        private void nhàCungCấpMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmNCC ncc = new frmNCC();
            //ncc.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string select;
            if (kt == true)
            {
                try
                {
                    //Exception khi không đủ dữ liệu

                    if (cboMaMatH.Text == "")
                    {
                        MessageBox.Show("Hãy chọn mặt hàng!", "Chú ý!");
                        cboMaMatH.Select();
                        return;
                    }
                    if (txtSoLuong.Text == "")
                    {
                        MessageBox.Show("Hãy nhập số lượng!", "Chú ý!");
                        txtSoLuong.Select();
                        return;
                    }
                    if (txtDonGia.Text == "")
                    {
                        MessageBox.Show("Hãy nhập đơn giá!", "Chú ý!");
                        txtDonGia.Select();
                        return;
                    }
                    if (txtDonViTinh.Text == "")
                    {
                        MessageBox.Show("Hãy nhập đơn vị tính!", "Chú ý!");
                        txtDonViTinh.Select();
                        return;
                    }
                    
                    
                    
                    if (txtThue.Text == "")
                    {
                        MessageBox.Show("Hãy nhập thuế cho mặt hàng này!", "Chú ý!");
                        txtThue.Select();
                        return;
                    }
                    if (double.Parse(txtSoLuong.Text) <= 0)
                    {
                        MessageBox.Show("Số lượng không được nhỏ hơn 0!");
                        txtSoLuong.Select();
                        return;
                    }
                    if (double.Parse(txtDonGia.Text) <= 0)
                    {
                        MessageBox.Show("Đơn giá không được nhỏ hơn 0!");
                        txtSoLuong.Select();
                        return;
                    }
                    string select1 = "select MaMatH from tblChiTietHDN WHERE MaHD='"+txtMaHoaDon.Text+"'";
                    SqlDataReader dr = DataConn.ThucHienReader(select1);

                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            if (dr.GetString(0) == values2)
                            {
                                dr.Close();
                                dr.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();

                    //Thêm vào bảng tblChiTietHDN
                    select = "insert into tblChiTietHDN(MaHD,MaMatH,SoLuong,DonViTinh,DonGia,Thue) values(N'" + txtMaHoaDon.Text + "',N'" + values2 + "'," + txtSoLuong.Text + ",N'"+txtDonViTinh.Text+"'," + txtDonGia.Text + "," + txtThue.Text + ")";
                    DataConn.ThucHienCmd(select);

                    //Cập nhật lại Số Lượng cho bảng tblMatHang (thêm số lượng mặt hàng)
                    select = "update tblMatHang set SoLuong=SoLuong+" + txtSoLuong.Text + ",DonGia='" + txtDonGia.Text + "' where MaMatH=N'" + values2 + "'";

                    DataConn.ThucHienCmd(select);
                    HienThi();
                    btnTongTien_Click(sender, e);
                    //MessageBox.Show("Nhập hàng thành công!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Không đúng định dạng dữ liệu cần thiết! Hãy xem trợ giúp!");
                }
                catch (SameKeyException)
                {
                    MessageBox.Show("Đã nhập mặt hàng này!", "Thông báo!");
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Hãy nhập đủ các dữ liệu trước khi nhấn nút ghi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string update = "";
                try
                {
                    if (cboMaMatH.Text == "" && txtDonGia.Text == "" && txtSoLuong.Text == "" && txtDonViTinh.Text == "" && txtThue.Text == "")
                        throw new NotEnoughInfoException();
                    if (double.Parse(txtSoLuong.Text) <= 0)
                    {
                        MessageBox.Show("Số lượng không được nhỏ hơn 0!");
                        txtSoLuong.Select();
                        return;
                    }
                    if (double.Parse(txtDonGia.Text) <= 0)
                    {
                        MessageBox.Show("Đơn giá không được nhỏ hơn 0!");
                        txtSoLuong.Select();
                        return;
                    }
                    string select1 = "select MaMatH from tblChiTietHDN WHERE MaHD='" + txtMaHoaDon.Text + "'";
                    SqlDataReader dr = DataConn.ThucHienReader(select1);

                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            if (dr.GetString(0) == values2)
                            {
                                dr.Close();
                                dr.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();
                    //string v = values2;
                    
                    update = "UPDATE tblChiTietHDN SET MaMatH='"+values2+"' WHERE MaHD='"+txtMaHoaDon.Text+"' AND MaMatH='"+txtMaH.Text+"'";
                    DataConn.ThucHienCmd(update);

                    
                    HienThi();
                    btnTongTien_Click(sender, e);
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Hãy nhập dữ liệu để sửa!", "Thông báo!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Định dạng dữ liệu không đúng!", "Thông báo!");
                }
                catch (SameKeyException)
                {
                    update = "UPDATE tblChiTietHDN SET SoLuong=" + txtSoLuong.Text + ",DonViTinh=N'" + txtDonViTinh.Text + "',DonGia=" + txtDonGia.Text + ",Thue=" + txtThue.Text + " WHERE MaHD='" + txtMaHoaDon.Text + "' AND MaMatH='" + values2 + "'";
                    DataConn.ThucHienCmd(update);
                    HienThi();
                    btnTongTien_Click(sender, e);
                }
            }
        }

        private void btnHoan_Click(object sender, EventArgs e)
        {
            cboMaMatH.Enabled = false;
            //cboMaNCC.Enabled = false;
            txtDonGia.ReadOnly = true;
            txtDonViTinh.ReadOnly = true;
            //txtGhiChu.ReadOnly = true;
            //txtMaHoaDon.ReadOnly = true;
            txtThue.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            //pckNgayNhap.Enabled = false;
            //groupChiTietHDN.Enabled = false;
            groupHoaDonNhap.Enabled = true;

            btnGhi.Enabled = false;
            btnHoan.Enabled = false;
            //btnNhap.Enabled = true;
            btnThoat.Enabled = true;
            btnInHD.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            //btnInHoaDon.Enabled = false;
        }
        //string v = "";
        private void grdNhapHang_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grdNhapHang.RowCount > 0)
            {
                if (grdNhapHang.CurrentCell == null)
                    return;
                if (grdNhapHang.CurrentCell.RowIndex < grdNhapHang.RowCount)
                {
                    try
                    {
                        int hang = grdNhapHang.CurrentCell.RowIndex;
                        string select = "SELECT tblHoaDonNhap.MaHD,TenNCC,tblChiTietHDN.MaMatH,TenMatH,tblChiTietHDN.SoLuong,NgayNhap,tblChiTietHDN.DonGia,Thue,tblChiTietHDN.DonViTinh,tblHoaDonNhap.GhiChu" +
                                        " FROM tblHoaDonNhap INNER JOIN tblChiTietHDN ON tblHoaDonNhap.MaHD=tblChiTietHDN.MaHD" +
                                        " INNER JOIN tblMatHang ON tblChiTietHDN.MaMatH=tblMatHang.MaMatH" +
                                        " INNER JOIN tblNhaCungCap ON tblNhaCungCap.MaNCC=tblHoaDonNhap.MaNCC" +
                                        " WHERE tblHoaDonNhap.MaHD=N'" + grdNhapHang.Rows[hang].Cells[0].Value.ToString() + "'"+
                                        " AND tblChiTietHDN.MaMatH=N'"+grdNhapHang.Rows[hang].Cells[2].Value.ToString()+"'";
                        DataSet ds = DataConn.GrdSource(select);

                        cboMaNCC.Text = ds.Tables[0].Rows[0]["TenNCC"].ToString();
                        txtMaH.Text = ds.Tables[0].Rows[0]["MaMatH"].ToString();
                        cboMaMatH.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                        txtMaHoaDon.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
                        txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                        pckNgayNhap.Text = ds.Tables[0].Rows[0]["NgayNhap"].ToString();
                        txtDonGia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString();
                        txtThue.Text = ds.Tables[0].Rows[0]["Thue"].ToString();
                        txtDonViTinh.Text = ds.Tables[0].Rows[0]["DonViTinh"].ToString();
                        txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
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

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHoaDon.Text == "")
                    throw new NotEnoughInfoException();

                string sql = "SELECT MaHD FROM tblChiTietHDN";
                SqlDataReader dr = DataConn.ThucHienReader(sql);
                int c = 0;
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaHoaDon.Text)
                        {
                            c = 1;
                        }
                    }
                }

                if (c == 0)
                {
                    dr.Close();
                    dr.Dispose();
                    throw new NotEnoughInfoException();
                }
                else
                {
                    dr.Close();
                    dr.Dispose();

                    string select = "SELECT SoLuong,DonGia,Thue FROM tblChiTietHDN WHERE MaHD='" + txtMaHoaDon.Text + "'";

                    SqlDataReader dr1 = DataConn.ThucHienReader(select);
                    double gia = 0;
                    double soluong = 0;
                    double thue = 0;
                    double tong = 0;
                    if (dr1 != null)
                    {
                        while (dr1.Read())
                        {
                            soluong = dr1.GetDouble(0);
                            gia = dr1.GetDouble(1);
                            thue = dr1.GetDouble(2);
                            tong += gia * soluong + thue * gia ;
                        }
                    }
                    dr1.Close();
                    dr1.Dispose();
                    txtTongTien.Text = tong.ToString();
                    string update = "UPDATE tblHoaDonNhap SET TongTien=" + txtTongTien.Text + " WHERE MaHD='" + txtMaHoaDon.Text + "'";
                    DataConn.ThucHienCmd(update);
                }
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn hoặc chưa có hóa đơn với mã này!", "Thông báo");
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

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "")
            {
                MessageBox.Show("Hãy nhập mã hóa đơn để in!","Thông báo!");
                txtMaHoaDon.Select();
                return;
            }
            frmInHDN inhdn = new frmInHDN(txtMaHoaDon.Text);
            inhdn.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            cboMaMatH.Enabled = true;
            //cboMaNCC.Enabled = true;
            txtDonGia.ReadOnly = false;
            txtDonViTinh.ReadOnly = false;
            //txtGhiChu.ReadOnly = false;
            //txtMaHoaDon.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            //pckNgayNhap.Enabled = true;
            txtThue.ReadOnly = false;
            groupHoaDonNhap.Enabled = false;

            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            btnThem.Enabled = false;
            btnThoat.Enabled = true;
            btnInHD.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            cboMaMatH.Text = "";
            //cboMaNCC.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            //txtGhiChu.Text = "";
            //txtMaHoaDon.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            cboMaMatH.Enabled = true;
            //cboMaNCC.Enabled = true;
            txtDonGia.ReadOnly = false;
            txtDonViTinh.ReadOnly = false;
            //txtGhiChu.ReadOnly = false;
            //txtMaHoaDon.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            //pckNgayNhap.Enabled = true;
            txtThue.ReadOnly = false;
            groupHoaDonNhap.Enabled = false;

            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            btnThem.Enabled = false;
            btnThoat.Enabled = true;
            btnInHD.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //cboMaMatH.Text = "";
            ////cboMaNCC.Text = "";
            //txtDonGia.Text = "";
            //txtDonViTinh.Text = "";
            ////txtGhiChu.Text = "";
            ////txtMaHoaDon.Text = "";
            //txtSoLuong.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "DELETE tblChiTietHDN WHERE MaHD='" + txtMaHoaDon.Text + "' AND MaMatH='" + values2 + "'";
                DataConn.ThucHienCmd(delete);
                HienThi();
                btnTongTien_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng dữ liệu không đúng!","Thông báo!");
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }
    }
}