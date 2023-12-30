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
    public partial class DMNhaCC : Form
    {
        public DMNhaCC()
        {
            InitializeComponent();
        }
        DataTable tblNhaCungCap;


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboManhacungcap.Text == "")
            {
                MessageBox.Show("Nhập mã nhà cung cấp để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblNhacungcap WHERE 1=1";
            if (cboManhacungcap.Text != "")

                sql = sql + "AND Manhacungcap Like N'%" + cboManhacungcap.SelectedValue + "%'";
            tblNhaCungCap = Data.GetDataToTable(sql);
            if (tblNhaCungCap.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblNhaCungCap.Rows.Count + "bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridView.DataSource = tblNhaCungCap;
            ResetValues();
        }

        private void txtManhacungcap_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void DMNhaCC_Load(object sender, EventArgs e)
        {
            txtManhacungcap.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Data.FillCombo("SELECT Manhacungcap,Tennhacungcap FROM NhaCungCap", cboManhacungcap, "Manhacungcap", "Tennhacungcap"); cboManhacungcap.SelectedValue = -1;
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Manhacungcap,Tennhacungcap,Diachi,Dienthoai FROM NhaCungCap";
            tblNhaCungCap = Data.GetDataToTable(sql);
            DataGridView.DataSource = tblNhaCungCap;
            DataGridView.Columns[0].HeaderText = "Mã nhà cung cấp";
            DataGridView.Columns[1].HeaderText = "Tên nhà cung cấp";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Điện thoại";
            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 200;
            DataGridView.Columns[2].Width = 150;
            DataGridView.Columns[3].Width = 150;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ chờ để thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhacungcap.Focus();
                return;
            }
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhacungcap.Text = DataGridView.CurrentRow.Cells["Manhacungcap"].Value.ToString();
            txtTennhacungcap.Text = DataGridView.CurrentRow.Cells["Tennhacungcap"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtDiachi.Text = "";
            txtManhacungcap.Text = "";
            txtTennhacungcap.Text = "";
            mskDienthoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManhacungcap.Enabled = true;
            txtManhacungcap.Focus();
            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhacungcap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhacungcap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennhacungcap.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            sql = "UPDATE NhaCungCap SET Tennhacungcap=N'" + txtTennhacungcap.Text.ToString() + "',Diachi=N'" + txtDiachi.Text.ToString() + "' WHERE Manhacungcap=N'" + txtManhacungcap.Text + "'";
            Data.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhacungcap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhaCungCap WHERE Manhacungcap=N'" + txtManhacungcap.Text + "'";
                Data.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhacungcap.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtManhacungcap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhacungcap.Focus();
                return;
            }
            if (txtTennhacungcap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhacungcap.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            sql = "SELECT Manhacungcap FROM NhaCungCap WHERE Manhacungcap=N'" + txtManhacungcap.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhacungcap.Focus();
                txtManhacungcap.Text = "";
                return;

            }
            sql = "INSERT INTO NhaCungCap(Manhacungcap,Tennhacungcap,Diachi,Dienthoai) VALUES(N'" + txtManhacungcap.Text.Trim() + "',N'" + txtTennhacungcap.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "')";
            Data.RunSql(sql); ;
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhacungcap.Enabled = false;
            Load_DataGridView();
        }
    }
}
