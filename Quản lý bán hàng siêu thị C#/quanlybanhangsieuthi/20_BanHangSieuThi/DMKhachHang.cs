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
    public partial class DMKhachHang : Form
    {
        public DMKhachHang()
        {
            InitializeComponent();
        }
        DataTable tblKH;
        private void DMKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaKhach,TenKhach,DiaChi,DienThoai FROM tblKhach";
            tblKH = Data.GetDataToTable(sql);
            DataGridView.DataSource = tblKH;
            DataGridView.Columns[0].HeaderText = "Mã khách";
            DataGridView.Columns[1].HeaderText = "Tên khách";
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
                txtMaKhach.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKhach.Text = DataGridView.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtTenKhach.Text = DataGridView.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtDiaChi.Text = DataGridView.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienThoai.Text = DataGridView.CurrentRow.Cells["DienThoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtDiaChi.Text = "";
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            mskDienThoai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaKhach.Enabled = true;
            txtMaKhach.Focus();
            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienThoai.Focus();
                return;
            }
            sql = "UPDATE tblKhach SET TenKhach=N'" + txtTenKhach.Text.ToString() + "',DiaChi=N'" + txtDiaChi.Text.ToString() + "' WHERE MaKhach=N'" + txtMaKhach.Text + "'";
            Data.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhach WHERE MaKhach=N'" + txtMaKhach.Text + "'";
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
            txtMaKhach.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mskDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienThoai.Focus();
                return;
            }
            sql = "SELECT MaKhach FROM tblKhach WHERE MaKhach=N'" + txtMaKhach.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhach.Focus();
                txtMaKhach.Text = "";
                return;

            }
            sql = "INSERT INTO tblKhach(MaKhach,TenKhach,DiaChi,DienThoai) VALUES(N'" + txtMaKhach.Text.Trim() + "',N'" + txtTenKhach.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "','" + mskDienThoai.Text + "')";
            Data.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKhach.Enabled = false;

        }
    }
}
