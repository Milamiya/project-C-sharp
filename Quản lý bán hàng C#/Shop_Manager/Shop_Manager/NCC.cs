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
    public partial class frmNhaCungCap : Form
    {
        private bool kt;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            chkListBox.Items.Insert(0, "Mã nhà cung cấp");
            chkListBox.Items.Insert(1, "Tên nhà cung cấp");
            chkListBox.Items.Insert(2, "Tên mặt hàng");
            chkListBox.Items.Insert(3, "Điện thoại");
            chkListBox.Items.Insert(4, "Fax");
            chkListBox.Items.Insert(5, "Email");
            chkListBox.Items.Insert(6, "Địa chỉ");
            chkListBox.Items.Insert(7, "Ghi chú");

            //grdKq.Columns[0].Visible = true;
            //grdKq.Columns[1].Visible = true;
            //grdKq.Columns[2].Visible = true;
            //grdKq.Columns[3].Visible = true;
            //grdKq.Columns[4].Visible = true;
            //grdKq.Columns[5].Visible = true;
            //grdKq.Columns[6].Visible = true;
            
            HienThi();
            string select = "SELECT* FROM tblMatHang";
            DataSet ds = DataConn.GrdSource(select);
            cboMatHang.DataSource = ds.Tables[0];
            cboMatHang.DisplayMember = "TenMatH";
            cboMatHang.ValueMember = "MaMatH";
            btnThem_Click(sender, e);
        }

        string values = "";
        private void cboMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMatHang.ValueMember != null)
            {
                values = cboMatHang.SelectedValue.ToString();
            }
        }

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
                        string select = "select tblNhaCungCap.MaNCC,tblNhaCungCap.TenNCC,tblMatHang.MaMatH,tblMatHang.TenMatH,tblNhaCungCap.DienThoai,tblNhaCungCap.Fax,tblNhaCungCap.Email,tblNhaCungCap.DiaChi,tblNhaCungCap.GhiChu" +
                            " from tblNhaCungCap inner join tblMatHang" +
                            " on tblNhaCungCap.MaMatH=tblMatHang.MaMatH WHERE MaNCC='"+ma+"'";
                        DataSet ds = DataConn.GrdSource(select);

                        txtMaNCC.Text = ds.Tables[0].Rows[0]["MaNCC"].ToString();
                        txtTenNCC.Text = ds.Tables[0].Rows[0]["TenNCC"].ToString();
                        cboMatHang.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                        txtDienThoai.Text = ds.Tables[0].Rows[0]["DienThoai"].ToString();
                        txtFax.Text = ds.Tables[0].Rows[0]["Fax"].ToString();
                        txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                        txtDiaChi.Text = ds.Tables[0].Rows[0]["DiaChi"].ToString();
                        txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                    }
                    catch (Exception se)
                    {
                        MessageBox.Show(""+se.Message);
                    }
                }
                else 
                    return;
            }
        }

        private void HienThi()
        {
            string select = "select tblNhaCungCap.MaNCC [Mã NCC],tblNhaCungCap.TenNCC [Tên NCC],tblMatHang.TenMatH [Mặt hàng],tblNhaCungCap.DienThoai [Điện thoại],tblNhaCungCap.Fax [Fax],tblNhaCungCap.Email [Email],tblNhaCungCap.DiaChi [Địa chỉ],tblNhaCungCap.GhiChu [Ghi chú]" +
                            " from tblNhaCungCap inner join tblMatHang" +
                            " on tblNhaCungCap.MaMatH=tblMatHang.MaMatH";
            DataSet ds = DataConn.GrdSource(select);
            grdKq.DataSource = ds.Tables[0];
            grdKq.Refresh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            btnThoat.Enabled = true;
            txtDiaChi.ReadOnly = false;
            txtDienThoai.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFax.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            txtMaNCC.ReadOnly = true;
            txtTenNCC.ReadOnly = false;
            cboMatHang.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            btnThoat.Enabled = true;
            txtDiaChi.ReadOnly = false;
            txtDienThoai.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtFax.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            txtMaNCC.ReadOnly = false;
            txtTenNCC.ReadOnly = false;
            cboMatHang.Enabled = true;
            txtTenNCC.Text = "";
            txtMaNCC.Text = "";
            txtGhiChu.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            cboMatHang.Text = "";
            txtMaNCC.Select();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFax.Text == "" && txtEmail.Text == "" && txtDiaChi.Text == "" && txtDienThoai.Text == "")
                    throw new NotEnoughInfoException();
                string select1 = "select MaNCC from tblHoaDonNhap";
                SqlDataReader dr = DataConn.ThucHienReader(select1);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaNCC.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();

                string delete = "DELETE tblNhaCungCap WHERE MaNCC=N'" + txtMaNCC.Text + "'";
                DataConn.ThucHienCmd(delete);
                HienThi();
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Hãy nhập đủ dữ liệu trước khi nhấn nút xóa!");
            }
            catch (SameKeyException)
            {
                MessageBox.Show("Đang có hóa đơn nhập của nhà cung cấp này! Bạn hãy xóa hóa đơn trước khi xóa nhà cung cấp!","Chú ý!");
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (kt == true)
            {
                try
                {
                    //Exception khi không đủ dữ liệu để nhập
                    if (txtMaNCC.Text == "")
                    {
                        MessageBox.Show("Hãy nhập mã nhà cung cấp!","Chú ý!");
                        txtMaNCC.Select();
                        return;
                    }
                    if (txtTenNCC.Text == "")
                    {
                        MessageBox.Show("Hãy nhập tên nhà cung cấp!", "Chú ý!");
                        txtTenNCC.Select();
                        return;
                    }
                    if (cboMatHang.Text == "")
                    {
                        MessageBox.Show("Hãy chọn mặt hàng được cung cấp!", "Chú ý!");
                        cboMatHang.Select();
                        return;
                    }
                    
                    if (txtDienThoai.Text == "")
                    {
                        MessageBox.Show("Hãy nhập điện thoại của nhà cung cấp!", "Chú ý!");
                        txtDienThoai.Select();
                        return;
                    }
                    //Exception khi trùng mã nhà cung cấp
                    string select1 = "select MaNCC from tblNhaCungCap";
                    SqlDataReader dr = DataConn.ThucHienReader(select1);
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            if (dr.GetString(0) == txtMaNCC.Text)
                            {
                                dr.Close();
                                dr.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();

                    select1 = "select TenNCC from tblNhaCungCap";
                    SqlDataReader dr1 = DataConn.ThucHienReader(select1);
                    if (dr1 != null)
                    {
                        while (dr1.Read())
                        {
                            if (dr1.GetString(0) == txtTenNCC.Text)
                            {
                                dr1.Close();
                                dr1.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr1.Close();
                    dr1.Dispose();

                    string select = "insert into tblNhaCungCap(MaNCC,MaMatH,TenNCC,DienThoai) values('" + txtMaNCC.Text + "','" + values + "','" + txtTenNCC.Text + "','" + txtDienThoai.Text + "')";
                    DataConn.ThucHienCmd(select);
                    HienThi();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Không đúng định dạng cần thiết! Hãy xem trợ giúp");
                }
                catch (SameKeyException)
                {
                    MessageBox.Show("Đã có nhà cung cấp với mã hoặc tên này! Hãy nhập mã và tên khác!");
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Hãy nhập đủ dữ liệu trước khi nhấn nút ghi!");
                }
            }
            else
            {
                try
                {
                    if (txtFax.Text == "" && txtEmail.Text == "" && txtDiaChi.Text == "" && txtDienThoai.Text == ""&&cboMatHang.Text==""&&txtTenNCC.Text==""&&txtGhiChu.Text=="")
                        throw new NotEnoughInfoException();
                    string update = "UPDATE tblNhaCungCap SET TenNCC=N'"+txtTenNCC.Text+"',MaMatH=N'" + values + "',Fax=N'" + txtFax.Text + "',Email=N'" + txtEmail.Text + "',DiaChi=N'" + txtDiaChi.Text + "',DienThoai=N'" + txtDienThoai.Text + "',GhiChu=N'" + txtGhiChu.Text + "' WHERE MaNCC=N'" + txtMaNCC.Text + "'";
                    DataConn.ThucHienCmd(update);
                    HienThi();
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Không đủ dữ liệu để sửa!");
                }
            }
        }
        private void btnHoan_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHoan.Enabled = false;
            btnThoat.Enabled = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
            txtMaNCC.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            cboMatHang.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
            
    }
}