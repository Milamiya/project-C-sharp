using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20_BanHangSieuThi
{
    public partial class DMTheLoai : Form
    {
        DataTable tblTL;
        public DMTheLoai()
        {
            InitializeComponent();
        }

            private void DMTheLoai_Load(object sender, EventArgs e)
            {
                txtMaloai.Enabled = false;
                btnLuu.Enabled = false;
                btnboqua.Enabled = false;
                Load_DataGridView();
                Data.FillCombo("SELECT Manhom,Tennhom FROM tblNhomHang", cboManhom, "Manhom","Tennhom");
                cboManhom.SelectedIndex = -1;
                ResetValues();
            }

            private void ResetValues()
            {
                txtMaloai.Text = "";
                txtTenloai.Text="";
                cboManhom.Text="";
            }

            private void Load_DataGridView()
            {
                string sql;
                sql = "SELECT Manhom,Maloai,Tenloai FROM tblTheLoai";
                tblTL = Data.GetDataToTable(sql);
                DgvTheLoai.DataSource = tblTL;
                DgvTheLoai.Columns[0].HeaderText = "Nhóm hàng";
                DgvTheLoai.Columns[1].HeaderText = "Mã loại";
                DgvTheLoai.Columns[2].HeaderText = "Tên loại";
                DgvTheLoai.Columns[0].Width = 200;
                DgvTheLoai.Columns[1].Width = 200;
                DgvTheLoai.Columns[2].Width = 260;
                DgvTheLoai.AllowUserToAddRows = false;
                DgvTheLoai.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

            private void DgvTheLoai_Click(object sender, EventArgs e)
            {
                string ma;
                if (btnThem.Enabled == false)
                {
                    MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaloai.Focus();
                    return;
                }
                if (tblTL.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                txtMaloai.Text = DgvTheLoai.CurrentRow.Cells["Maloai"].Value.ToString();
                txtTenloai.Text = DgvTheLoai.CurrentRow.Cells["Tenloai"].Value.ToString();
                ma = DgvTheLoai.CurrentRow.Cells["Manhom"].Value.ToString();
                cboManhom.Text = Data.GetFieldValues("SELECT Tennhom FROM tblNhomHang WHERE Manhom=N'" + ma + "'");
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnboqua.Enabled = true;
            }

            private void btnThem_Click(object sender, EventArgs e)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnboqua.Enabled = true;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                ResetValues();
                txtMaloai.Enabled = true;
                txtMaloai.Focus();
            }

            private void btnLuu_Click(object sender, EventArgs e)
            {
                string sql;
                if(txtMaloai.Text.Trim().Length==0)
                {
                    MessageBox.Show("Bạn phải nhập mã loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenloai.Focus();
                    return;
                }
                if (txtTenloai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenloai.Focus();
                    return;
                }

                if(cboManhom.Text.Trim().Length==0)
                {
                    MessageBox.Show("Bạn phải nhập nhóm hàng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    cboManhom.Focus();
                    return;
                }

                sql = "SELECT Maloai FROM tblTheLoai WHERE Maloai=N'" + txtMaloai.Text.Trim() + "'";
                if (Data.Checkey(sql))
                {
                    MessageBox.Show("Mã loại này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaloai.Focus();
                    txtMaloai.Text = "";
                    return;
                }
                sql = "INSERT INTO tblTheLoai(Maloai,Manhom,Tenloai) VALUES (N'" + txtMaloai.Text.Trim() + "',N'" + cboManhom.SelectedValue.ToString()+"',N'"+ txtTenloai.Text.Trim() + "')";
                Data.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnboqua.Enabled = false;
                btnLuu.Enabled = false;
                txtMaloai.Enabled = false;
            }

            private void btnSua_Click(object sender, EventArgs e)
            {
                string sql;
                if (tblTL.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(cboManhom.Text=="")
                {
                    MessageBox.Show("Bạn chưa chọn nhóm hàng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    cboManhom.Focus();
                }
                if (txtMaloai.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtTenloai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhóm hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenloai.Focus();
                    return;
                }
                sql = "UPDATE tblTheLoai SET Tenloai=N'" + txtTenloai.Text.ToString() + "'WHERE Maloai=N'" + txtMaloai.Text + "'";
                Data.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnboqua.Enabled = false;
            }

            

            private void btnboqua_Click(object sender, EventArgs e)
            {

                ResetValues();
                btnboqua.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                txtMaloai.Enabled = false;

            }

            private void btnXoa_Click_1(object sender, EventArgs e)
            {
                string sql;
                if (tblTL.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMaloai.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sql = "DELETE tblTheLoai WHERE Maloai=N'" + txtMaloai.Text + "'";
                    Data.RunSqlDel(sql);
                    Load_DataGridView();
                    ResetValues();
                }
            }
        }
    }
