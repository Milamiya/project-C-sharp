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
    public partial class DMCongDung : Form
    {
        DataTable tblCD;
        public DMCongDung()
        {
            InitializeComponent();
        }

        private void DMCongDung_Load(object sender, EventArgs e)
        {
            txtMacongdung.Enabled = false;
            btnLuu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Macongdung,Tencongdung FROM tblCongDung";
            tblCD= Data.GetDataToTable(sql);
            DgvCongDung.DataSource = tblCD;
            DgvCongDung.Columns[0].HeaderText = "Mã công dụng";
            DgvCongDung.Columns[1].HeaderText = "Tên công dụng";
            DgvCongDung.Columns[0].Width = 200;
            DgvCongDung.Columns[1].Width = 350;
            DgvCongDung.AllowUserToAddRows = false;
            DgvCongDung.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DgvCongDung_Click(object sender, EventArgs e)
        {
             if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMacongdung.Focus();
                return;
            }
             if (tblCD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
             txtMacongdung.Text = DgvCongDung.CurrentRow.Cells["Macongdung"].Value.ToString();
             txtTencongdung.Text = DgvCongDung.CurrentRow.Cells["Tencongdung"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtMacongdung.Text = "";
            txtTencongdung.Text = "";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnboqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMacongdung.Enabled = true;
            txtMacongdung.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
              string sql;
              if (tblCD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMacongdung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTencongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTencongdung.Focus();
                return;
            }
            sql = "UPDATE tblCongDung SET Tencongdung=N'" + txtTencongdung.Text.ToString() + "'WHERE Macongdung=N'" + txtMacongdung.Text + "'";
            Data.RunSql(sql);
            ResetValues();
            txtTencongdung.Focus();
            btnboqua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMacongdung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblCongDung WHERE Macongdung=N'" + txtMacongdung.Text + "'";
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
            txtMacongdung.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
             string sql;
             if (txtMacongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTencongdung.Focus();
                return;
            }
             if (txtTencongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTencongdung.Focus();
                return;
            }
            sql = "SELECT Macongdung FROM tblCongDung WHERE Macongdung=N'" + txtMacongdung.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã công dụng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMacongdung.Focus();
                txtMacongdung.Text = "";
                return;
            }
            sql = "INSERT INTO tblCongDung(Macongdung,Tencongdung) VALUES (N'" + txtMacongdung.Text + "',N'" + txtTencongdung.Text + "')";
            Data.RunSql(sql);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMacongdung.Enabled = false;
        }

        private void txtMaCD_KeyUp(object sender, KeyEventArgs e)
        {
             if(e.KeyCode==Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
