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
    public partial class frmXuatHang : Form
    {
        public frmXuatHang()
        {
            InitializeComponent();
        }

        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            pckNgayXuat.Text = DateTime.Today.TimeOfDay.ToString();
            txtMaHD.Text = "";
            cboMaNhanVien.Text = "";
            txtGhiChu.Text = "";
            txtMaHD.Select();

            groupChiTietHDX.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = false;
            btnInHD.Enabled = false;
            btnHoan.Enabled = false;

            string select1 = "select* from tblMatHang";
            string select2 = "select* from tblNhanVien";
            DataSet ds = DataConn.GrdSource(select1);
            cboMaMatH.DataSource = ds.Tables[0];
            cboMaMatH.DisplayMember = "TenMatH";
            cboMaMatH.ValueMember = "MaMatH";
            if (cboMaMatH.ValueMember != null)
                values1 = ds.Tables[0].Rows[cboMaMatH.SelectedIndex][0].ToString();

            ds = DataConn.GrdSource(select2);
            cboMaNhanVien.DataSource = ds.Tables[0];
            cboMaNhanVien.DisplayMember = "TenNhanVien";
            cboMaNhanVien.ValueMember = "MaNhanVien";
            if (cboMaNhanVien.ValueMember != null)
                values2 = ds.Tables[0].Rows[cboMaNhanVien.SelectedIndex][0].ToString();
            HienThi();
            //btnXuatHang_Click(sender, e);
            //string s = "SELECT SoLuong FROM tblMatHang WHERE MaMatH='"+values1+"'";
            //DataSet ds1 = DataConn.GrdSource(s);
            //label4.Text = ds1.Tables[0].Rows[0].ToString();
        }

        string values1 = "";
        private void cboMaMatH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMatH.ValueMember != null)
            {
                values1 = cboMaMatH.SelectedValue.ToString();
                
            }
            //string s = "SELECT SoLuong FROM tblMatHang WHERE MaMatH='" + values1 + "'";
            //SqlDataReader dr 
        }

        string values2 = "";
        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNhanVien.ValueMember != null)
            {
                values2 = cboMaNhanVien.SelectedValue.ToString();
            }
        }

        private void HienThi()
        {
            string select = "SELECT tblHoaDonXuat.MaHD [Mã hóa đơn],tblNhanVien.TenNhanVien [Nhân viên],tblChiTietHDX.MaMatH [Mã hàng],tblMatHang.TenMatH [Mặt hàng],tblChiTietHDX.SoLuong [Số lượng],tblHoaDonXuat.NgayXuat [Ngày xuất],tblChiTietHDX.DonGia [Đơn giá],Thue [Thuế],DonViTinh [Đơn vị tính],tblHoaDonXuat.GhiChu [Ghi chú]"+
                            " FROM tblHoaDonXuat INNER JOIN tblChiTietHDX ON tblHoaDonXuat.MaHD=tblChiTietHDX.MaHD"+
                            " INNER JOIN tblMatHang ON tblMatHang.MaMatH=tblChiTietHDX.MaMatH"+
                            " INNER JOIN tblNhanVien ON tblNhanVien.MaNhanVien=tblHoaDonXuat.MaNhanVien"+
                            " WHERE tblHoaDonXuat.MaHD='"+txtMaHD.Text+"'";
            DataSet ds = DataConn.GrdSource(select);
            grdXuatHang.DataSource = ds.Tables[0];
            grdXuatHang.Refresh();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            //btnGhi.Enabled = true;
            //btnHoan.Enabled = true;
            //btnXuatHang.Enabled = false;
            //btnThoat.Enabled = true;
            //btnInHD.Enabled = false;

            //txtDonGia.ReadOnly = false;
            //txtDonViTinh.ReadOnly = false;
            //txtGhiChu.ReadOnly = false;
            //txtMaHD.ReadOnly = false;
            //txtThue.ReadOnly = false;
            //txtSoLuong.ReadOnly = false;
            //cboMaMatH.Enabled = true;
            //cboMaNhanVien.Enabled = true;
            //pckNgayXuat.Enabled = true;

            //txtSoLuong.Text = "";
            //txtMaHD.Text = "";
            //txtGhiChu.Text = "";
            //txtDonViTinh.Text = "";
            //txtDonGia.Text = "";
            //cboMaMatH.Text = "";
            //cboMaNhanVien.Text = "";
            //txtThue.Text = "0";
            
            //txtMaHD.Select();
            try
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã hóa đơn!", "Chú ý!");
                    txtMaHD.Select();
                    return;
                }
                if (cboMaNhanVien.Text == "")
                {
                    MessageBox.Show("Hãy chọn tên nhân viên xuất hàng!", "Chú ý!");
                    cboMaNhanVien.Select();
                    return;
                }
                if (pckNgayXuat.Text == "")
                {
                    MessageBox.Show("Hãy chọn ngày xuất!", "Chú ý!");
                    pckNgayXuat.Select();
                    return;
                }
                
                string select1 = "select MaHD FROM tblHoaDonXuat";
                SqlDataReader dr = DataConn.ThucHienReader(select1);
               

                if (dr != null)
                {
                    //MessageBox.Show("1");
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaHD.Text)
                        {
                            //MessageBox.Show("2");
                            dr.Close();
                            dr.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                
                string select = "insert into tblHoaDonXuat(MaHD,MaNhanVien,NgayXuat,GhiChu) values(N'" + txtMaHD.Text + "',N'" + values2 + "',N'" + pckNgayXuat.Text + "',N'"+txtGhiChu.Text+"')";
                DataConn.ThucHienCmd(select);
                
                HienThi();

                groupChiTietHDX.Enabled = true;
                //groupHoaDonXuat.Enabled = false;
                btnThem_Click(sender, e);
                cboMaMatH.Select();
            }
            catch (SameKeyException)
            {
                MessageBox.Show("Đã có hóa đơn với mã này!","Chú ý!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Không đúng định dạng dữ liệu!", "Thông báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool kt;
        private void btnGhi_Click(object sender, EventArgs e)
        {
            string select;
            if (kt == true)
            {
                try
                {
                    //Exception khi không đủ thông tin

                    if (cboMaMatH.Text == "")
                    {
                        MessageBox.Show("Hãy chọn mặt hàng xuất!", "Chú ý!");
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
                    try
                    {
                        string select3 = "SELECT SoLuong FROM tblMatHang WHERE MaMatH='" + values1 + "'";
                        SqlDataReader dr1 = DataConn.ThucHienReader(select3);
                        if (dr1 != null)
                        {
                            while (dr1.Read())
                            {
                                if (dr1.GetDouble(0) < double.Parse(txtSoLuong.Text))
                                {
                                    dr1.Close();
                                    dr1.Dispose();
                                    throw new OutOfQuantityException();
                                }
                            }
                        }
                        dr1.Close();
                        dr1.Dispose();
                    }
                    catch (OutOfQuantityException)
                    {
                        MessageBox.Show("Số lượng hàng trong kho không đủ để xuất!");
                        return;
                    }

                    string select1 = "select MaMatH from tblChiTietHDX WHERE MaHD='"+txtMaHD.Text+"'";
                    SqlDataReader dr = DataConn.ThucHienReader(select1);

                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            if (dr.GetString(0) == values1)
                            {
                                dr.Close();
                                dr.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();

                    //Thêm vào bảng tblChiTietHDX
                    select = "insert into tblChiTietHDX(MaMatH,MaHD,SoLuong,DonViTinh,DonGia,Thue) values(N'" + values1 + "',N'" + txtMaHD.Text + "'," + txtSoLuong.Text + ",N'" + txtDonViTinh.Text + "'," + txtDonGia.Text + "," + txtThue.Text + ")";
                    DataConn.ThucHienCmd(select);

                    //Cập nhật lại Số Lượng cho bảng tblMatHang (bớt số lượng mặt hàng)
                    select = "update tblMatHang set SoLuong=SoLuong-" + txtSoLuong.Text + " where MaMatH=N'" + values1 + "'";
                    DataConn.ThucHienCmd(select);
                    btnTinhTien_Click(sender, e);

                    HienThi();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Không đúng định dạng dữ liệu cần thiết! Hãy xem trợ giúp!");
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Hãy nhập đủ các dữ liệu trước khi nhấn nút ghi!");
                }
                catch (SameKeyException)
                {
                    MessageBox.Show("Đã xuất mặt hàng này! ", "Thông báo!");
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
                    if (cboMaMatH.Text == "" && txtSoLuong.Text == "" && txtDonGia.Text == "" && txtDonViTinh.Text == "")
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
                    string select1 = "select MaMatH from tblChiTietHDX WHERE MaHD='"+txtMaHD.Text+"'";
                    SqlDataReader dr = DataConn.ThucHienReader(select1);

                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            if (dr.GetString(0) == values1)
                            {
                                dr.Close();
                                dr.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();

                    try
                    {
                        string select3 = "SELECT SoLuong FROM tblMatHang WHERE MaMatH='" + values1 + "'";
                        SqlDataReader dr1 = DataConn.ThucHienReader(select3);
                        if (dr1 != null)
                        {
                            while (dr1.Read())
                            {
                                if (dr1.GetDouble(0) < double.Parse(txtSoLuong.Text))
                                {
                                    dr1.Close();
                                    dr1.Dispose();
                                    throw new OutOfQuantityException();
                                }
                            }
                        }
                        dr1.Close();
                        dr1.Dispose();
                    }
                    catch (OutOfQuantityException)
                    {
                        MessageBox.Show("Số lượng hàng trong kho không đủ để xuất!");
                        return;
                    }

                    update = "UPDATE tblChiTietHDX SET MaMatH='" + values1 + "' WHERE MaHD='" + txtMaHD.Text + "' AND MaMatH='" + txtMaH.Text + "'";
                    DataConn.ThucHienCmd(update);

                    
                    HienThi();
                    btnTinhTien_Click(sender, e);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Không đúng định dạng dữ liệu!", "Thông báo!");
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Hãy nhập dữ liệu để sửa!", "Thông báo!");
                }
                catch (SameKeyException)
                {
                    update = "UPDATE tblChiTietHDX SET SoLuong=" + txtSoLuong.Text + ",DonViTinh=N'" + txtDonViTinh.Text + "',DonGia=" + txtDonGia.Text + ",Thue=" + txtThue.Text + " WHERE MaHD='" + txtMaHD.Text + "' AND MaMatH='" + values1 + "'";
                    DataConn.ThucHienCmd(update);
                    HienThi();
                    //MessageBox.Show("Đã xuất mặt hàng này! ", "Thông báo!");
                    btnTinhTien_Click(sender, e);
                }
            }
        }

        private void btnHoan_Click(object sender, EventArgs e)
        {
            btnGhi.Enabled = false;
            btnHoan.Enabled = false;
            //btnXuatHang.Enabled = true;
            //btnThoat.Enabled = true;
            btnInHD.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            groupHoaDonXuat.Enabled = true;

            txtDonGia.ReadOnly = true;
            txtDonViTinh.ReadOnly = true;
            //txtGhiChu.ReadOnly = true;
            //txtMaHD.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtThue.ReadOnly = true;
            cboMaMatH.Enabled = false;
            //cboMaNhanVien.Enabled = false;
            //pckNgayXuat.Enabled = false;
        }

        private void grdXuatHang_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grdXuatHang.RowCount > 0)
            {
                if (grdXuatHang.CurrentCell == null)
                    return;
                if (grdXuatHang.CurrentCell.RowIndex < grdXuatHang.RowCount)
                {
                    try
                    {
                        int hang = grdXuatHang.CurrentCell.RowIndex;
                        string select = "SELECT tblHoaDonXuat.MaHD,tblNhanVien.TenNhanVien,tblChiTietHDX.MaMatH,tblMatHang.TenMatH,tblChiTietHDX.SoLuong,tblHoaDonXuat.NgayXuat,tblChiTietHDX.DonGia,Thue,DonViTinh,tblHoaDonXuat.GhiChu" +
                            " FROM tblHoaDonXuat INNER JOIN tblChiTietHDX ON tblHoaDonXuat.MaHD=tblChiTietHDX.MaHD" +
                            " INNER JOIN tblMatHang ON tblMatHang.MaMatH=tblChiTietHDX.MaMatH" +
                            " INNER JOIN tblNhanVien ON tblNhanVien.MaNhanVien=tblHoaDonXuat.MaNhanVien" +
                            " WHERE tblHoaDonXuat.MaHD=N'" + grdXuatHang.Rows[hang].Cells[0].Value.ToString() + "'" +
                            " AND tblChiTietHDX.MaMatH=N'" + grdXuatHang.Rows[hang].Cells[2].Value.ToString() + "'";
                        DataSet ds = DataConn.GrdSource(select);

                        cboMaNhanVien.Text = ds.Tables[0].Rows[0]["TenNhanVien"].ToString();
                        cboMaMatH.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                        txtMaHD.Text = ds.Tables[0].Rows[0]["MaHD"].ToString();
                        txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                        pckNgayXuat.Text = ds.Tables[0].Rows[0]["NgayXuat"].ToString();
                        txtDonGia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString();
                        txtThue.Text = ds.Tables[0].Rows[0]["Thue"].ToString();
                        txtDonViTinh.Text = ds.Tables[0].Rows[0]["DonViTinh"].ToString();
                        txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                        txtMaH.Text = ds.Tables[0].Rows[0]["MaMatH"].ToString();
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

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHD.Text == "")
                    throw new NotEnoughInfoException();

                string sql = "SELECT MaHD FROM tblChiTietHDX";
                SqlDataReader dr = DataConn.ThucHienReader(sql);
                int c = 0;
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaHD.Text)
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

                    string select = "SELECT SoLuong,DonGia,Thue FROM tblChiTietHDX WHERE MaHD='" + txtMaHD.Text + "'";

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
                            tong += gia * soluong + thue * gia;
                        }
                    }
                    dr1.Close();
                    dr1.Dispose();
                    txtTongTien.Text = tong.ToString();
                    string update = "UPDATE tblHoaDonXuat SET TongTien=" + txtTongTien.Text + " WHERE MaHD='" + txtMaHD.Text + "'";
                    DataConn.ThucHienCmd(update);
                }
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn hoặc chưa có hóa đơn với mã này!", "Thông báo");
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se.Message);
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Hãy nhập mã hóa đơn để in!","Thông báo!");
                txtMaHD.Select();
                return;
            }
            frmInHDX inhdx = new frmInHDX(txtMaHD.Text);
            inhdx.ShowDialog();
        }

        private void lblDonGia_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            //btnXuatHang.Enabled = false;
            //btnThoat.Enabled = true;
            btnInHD.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;

            txtDonGia.ReadOnly = false;
            txtDonViTinh.ReadOnly = false;
            //txtGhiChu.ReadOnly = false;
            //txtMaHD.ReadOnly = false;
            txtThue.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            cboMaMatH.Enabled = true;
            //cboMaNhanVien.Enabled = true;
            //pckNgayXuat.Enabled = true;

            txtSoLuong.Text = "";
            //txtMaHD.Text = "";
            //txtGhiChu.Text = "";
            txtDonViTinh.Text = "";
            txtDonGia.Text = "";
            cboMaMatH.Text = "";
            //cboMaNhanVien.Text = "";
            txtThue.Text = "0";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            //btnXuatHang.Enabled = false;
            //btnThoat.Enabled = true;
            btnInHD.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;

            txtDonGia.ReadOnly = false;
            txtDonViTinh.ReadOnly = false;
            //txtGhiChu.ReadOnly = false;
            //txtMaHD.ReadOnly = false;
            txtThue.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            cboMaMatH.Enabled = true;
            //cboMaNhanVien.Enabled = true;
            //pckNgayXuat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "DELETE tblChiTietHDX WHERE MaHD='" + txtMaHD.Text + "' AND MaMatH='" + values1 + "'";
                DataConn.ThucHienCmd(delete);
                HienThi();
                btnTinhTien_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}