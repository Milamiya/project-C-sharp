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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        private bool kt;
        private void frmMatHang_Load(object sender, EventArgs e)
        {
            chkListBox.Items.Insert(0, "Mã mặt hàng");
            chkListBox.Items.Insert(1, "Tên mặt hàng");
            chkListBox.Items.Insert(2, "Số lượng");
            chkListBox.Items.Insert(3, "Đơn giá");

            HienThi();

            btnGhi.Enabled = false;
            btnHoan.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            txtDonGia.ReadOnly = true;
            txtMaHang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtTenHang.ReadOnly = true;

            btnThem_Click(sender, e);
        }

        //Load từ Grid lên các textbox
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
                        string select = "select MaMatH,TenMatH,SoLuong,DonGia from tblMatHang WHERE MaMatH=N'" + ma + "'";
                        DataSet ds = DataConn.GrdSource(select);

                        txtMaHang.Text = ds.Tables[0].Rows[0]["MaMatH"].ToString();
                        txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                        txtDonGia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString();
                        txtTenHang.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
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
            kt = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            btnThoat.Enabled = true;
            txtDonGia.ReadOnly = false;
            txtMaHang.ReadOnly = true;
            txtSoLuong.ReadOnly = false;
            txtTenHang.ReadOnly = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HienThi()
        {
            string select = "select MaMatH [Mã hàng],TenMatH [Tên hàng],SoLuong [Số lượng],DonGia [Đơn giá] from tblMatHang";
            DataSet ds = DataConn.GrdSource(select);
            grdKq.DataSource = ds.Tables[0];
            grdKq.Refresh();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (kt == true)
            {
                try
                {
                    //Exception khi không đủ dữ liệu
                    if (txtMaHang.Text == "")
                    {
                        MessageBox.Show("Hãy nhập mã hàng!","Chú ý");
                        txtMaHang.Select();
                        return;
                    }
                    if (txtTenHang.Text == "")
                    {
                        MessageBox.Show("Hãy nhập tên hàng!", "Chú ý");
                        txtTenHang.Select();
                        return;
                    }
                    if (txtSoLuong.Text == "")
                    {
                        MessageBox.Show("Hãy nhập số lượng hàng!", "Chú ý");
                        txtSoLuong.Select();
                        return;
                    }
                    if (txtDonGia.Text == "")
                    {
                        MessageBox.Show("Hãy nhập đơn giá hàng!", "Chú ý");
                        txtDonGia.Select();
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

                    //Exception khi trùng Mã mặt hàng (trùng khóa chính)
                    string select1 = "select MaMatH from tblMatHang";
                    SqlDataReader dr = DataConn.ThucHienReader(select1);
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            //MessageBox.Show(dr.GetString(0));
                            //MessageBox.Show(txtMaHang.Text);

                            //MessageBox.Show(dr.GetString(1));
                            //MessageBox.Show(txtTenHang.Text);
                            if (dr.GetString(0) == txtMaHang.Text)
                            {
                                dr.Close();
                                dr.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();

                    select1 = "select TenMatH from tblMatHang";
                    SqlDataReader dr1 = DataConn.ThucHienReader(select1);
                    if (dr1 != null)
                    {
                        while (dr1.Read())
                        {
                            //MessageBox.Show(dr.GetString(0));
                            //MessageBox.Show(txtMaHang.Text);

                            //MessageBox.Show(dr.GetString(1));
                            //MessageBox.Show(txtTenHang.Text);
                            if (dr1.GetString(0) == txtTenHang.Text)
                            {
                                dr1.Close();
                                dr1.Dispose();
                                throw new SameKeyException();
                            }
                        }
                    }
                    dr1.Close();
                    dr1.Dispose();
                    string select = "insert into tblMatHang values(N'" + txtMaHang.Text + "',N'" + txtTenHang.Text + "'," + txtSoLuong.Text + "," + txtDonGia.Text + "," + (float.Parse(txtDonGia.Text) + 20000) + ")";
                    DataConn.ThucHienCmd(select);

                    HienThi();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Không đúng định dạng cần thiết! Hãy xem trợ giúp!");
                }
                catch (SameKeyException)
                {
                    MessageBox.Show("Đã có mặt hàng với mã hoặc tên này! Hãy nhập mặt hàng khác!");
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Không có đủ dữ liệu để thêm!");
                }
            }
            else
            {
                try
                {
                    if (txtMaHang.Text == "" && txtSoLuong.Text == "" && txtDonGia.Text == ""&&txtTenHang.Text=="")
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
                    string update = "UPDATE tblMatHang SET TenMatH=N'"+txtTenHang.Text+"',SoLuong='" + txtSoLuong.Text + "',DonGia='" + txtDonGia.Text + "' WHERE MaMatH=N'" + txtMaHang.Text + "'";
                    DataConn.ThucHienCmd(update);

                    HienThi();
                }
                catch (NotEnoughInfoException)
                {
                    MessageBox.Show("Không có đủ dữ liệu để sửa!");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = true;
            txtDonGia.ReadOnly = false;
            txtMaHang.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtTenHang.ReadOnly = false;
            txtDonGia.Text = "";
            txtMaHang.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHoan.Enabled = true;
            btnThoat.Enabled = true;
            txtMaHang.Select();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string select1 = "select MaMatH from tblChiTietHDN";
                SqlDataReader dr = DataConn.ThucHienReader(select1);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtMaHang.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();

                select1 = "select MaMatH from tblChiTietHDX";
                SqlDataReader dr1 = DataConn.ThucHienReader(select1);
                if (dr1 != null)
                {
                    while (dr1.Read())
                    {
                        if (dr1.GetString(0) == txtMaHang.Text)
                        {
                            dr1.Close();
                            dr1.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr1.Close();
                dr1.Dispose();

                select1 = "select MaMatH from tblNhaCungCap";
                SqlDataReader dr2 = DataConn.ThucHienReader(select1);
                if (dr2 != null)
                {
                    while (dr2.Read())
                    {
                        if (dr2.GetString(0) == txtMaHang.Text)
                        {
                            dr2.Close();
                            dr2.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr2.Close();
                dr2.Dispose();

                select1 = "select MaMatH from tblDatHangCT";
                SqlDataReader dr3 = DataConn.ThucHienReader(select1);
                if (dr3 != null)
                {
                    while (dr3.Read())
                    {
                        if (dr3.GetString(0) == txtMaHang.Text)
                        {
                            dr3.Close();
                            dr3.Dispose();
                            throw new SameKeyException();
                        }
                    }
                }
                dr3.Close();
                dr3.Dispose();

                string delete = "DELETE tblMatHang WHERE MaMatH=N'" + txtMaHang.Text + "'";
                DataConn.ThucHienCmd(delete);
                HienThi();
            }
            catch (SameKeyException)
            {
                MessageBox.Show("Có thể có hóa đơn, nhà cung cấp hoặc phiếu đặt hàng liên quan đến mặt hàng này! Bạn hãy xóa hóa đơn, nhà cung cấp hoặc phiếu đặt hàng liên quan!", "Chú ý!");
            }
        }

        private void btnHoan_Click(object sender, EventArgs e)
        {
            btnGhi.Enabled = false;
            btnHoan.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            txtDonGia.ReadOnly = true;
            txtMaHang.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtTenHang.ReadOnly = true;
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
        }
    }
}