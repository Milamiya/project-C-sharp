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
    public partial class DMNoiSX : Form
    {
        public DMNoiSX()
        {
            InitializeComponent();
        }
        DataTable tblNSX;
        private void DMNoiSX_Load(object sender, EventArgs e)
        {
            txtManoiSX.Enabled = false;
            btnLuu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql = "SELECT ManoiSX,TennoiSX FROM tblNoiSanXuat";
            tblNSX = Data.GetDataToTable(sql);
            DgvSX.DataSource = tblNSX;
            DgvSX.Columns[0].HeaderText = "Mã nơi sản xuất";
            DgvSX.Columns[1].HeaderText = "Tên nơi sản xuất";
            DgvSX.Columns[0].Width = 200;
            DgvSX.Columns[1].Width = 350;
            DgvSX.AllowUserToAddRows = false;
            DgvSX.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DgvSX_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManoiSX.Focus();
                return;
            }
             if (tblNSX.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
             txtManoiSX.Text = DgvSX.CurrentRow.Cells["ManoiSX"].Value.ToString();
             txtTennoiSX.Text = DgvSX.CurrentRow.Cells["TennoiSX"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtManoiSX.Text = "";
            txtTennoiSX.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnboqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManoiSX.Enabled = true;
            txtManoiSX.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string sql;
            if (tblNSX.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManoiSX.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennoiSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nơi sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennoiSX.Focus();
                return;
            }
            sql = "UPDATE tblNoiSanXuat SET TennoiSX=N'" + txtTennoiSX.Text.ToString() + "'WHERE ManoiSX=N'" + txtManoiSX.Text + "'";
            Data.RunSql(sql);
            ResetValues();
            Load_DataGridView();
            btnboqua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             string sql;
            if (tblNSX.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManoiSX.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNoiSanXuat WHERE ManoiSX=N'" + txtManoiSX.Text + "'";
                Data.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManoiSX.Enabled = false;
        
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtManoiSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nơi sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManoiSX.Focus();
                return;
            }
            if (txtTennoiSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nơi sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennoiSX.Focus();
                return;
            }
            sql = "SELECT ManoiSX FROM tblNoiSanXuat WHERE ManoiSX=N'" + txtManoiSX.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManoiSX.Focus();
                txtManoiSX.Text = "";
                return;
            }
            sql = "INSERT INTO tblNoiSanXuat(ManoiSX,TennoiSX) VALUES (N'" + txtManoiSX.Text + "',N'" + txtTennoiSX.Text + "')";
            Data.RunSql(sql);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManoiSX.Enabled = false;
        }
        }
}
