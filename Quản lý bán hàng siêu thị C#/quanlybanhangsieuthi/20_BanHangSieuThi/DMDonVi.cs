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
    public partial class DMDonVi : Form
    {
        public DMDonVi()
        {
            InitializeComponent();
        }
        DataTable tblDVT;

        private void DMDonVi_Load(object sender, EventArgs e)
        {
            txtMadonvi.Enabled = false;
            btnLuu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql = "SELECT Madonvi,Tendonvi FROM tblDonViTinh";
            tblDVT = Data.GetDataToTable(sql);
            DgvDVT.DataSource = tblDVT;
            DgvDVT.Columns[0].HeaderText = "Mã đơn vị";
            DgvDVT.Columns[1].HeaderText = "Tên đơn vị";
            DgvDVT.Columns[0].Width = 200;
            DgvDVT.Columns[1].Width = 350;
            DgvDVT.AllowUserToAddRows = false;
            DgvDVT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DgvDVT_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadonvi.Focus();
                return;
            }
            if (tblDVT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMadonvi.Text = DgvDVT.CurrentRow.Cells["Madonvi"].Value.ToString();
            txtTendonvi.Text = DgvDVT.CurrentRow.Cells["Tendonvi"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtMadonvi.Text = "";
            txtTendonvi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnboqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMadonvi.Enabled = true;
            txtMadonvi.Focus();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDVT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadonvi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTendonvi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTendonvi.Focus();
                return;
            }
            sql = "UPDATE tblDonViTinh SET Tendonvi=N'" + txtTendonvi.Text.ToString() + "'WHERE Madonvi=N'" + txtMadonvi.Text + "'";
            Data.RunSql(sql);
            ResetValues();
            Load_DataGridView();
            btnboqua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDVT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMadonvi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblDonViTinh WHERE Madonvi=N'" + txtMadonvi.Text + "'";
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
            txtMadonvi.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMadonvi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadonvi.Focus();
                return;
            }
            if (txtTendonvi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đơn vị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTendonvi.Focus();
                return;
            }
            sql = "SELECT Madonvi FROM tblDonVitinh WHERE Madonvi=N'" + txtMadonvi.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã đơn vị này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMadonvi.Focus();
                txtMadonvi.Text = "";
                return;
            }
            sql = "INSERT INTO tblDonViTinh(Madonvi,Tendonvi) VALUES (N'" + txtMadonvi.Text + "',N'" + txtTendonvi.Text + "')";
            Data.RunSql(sql);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMadonvi.Enabled = false;
        }
    }
}
