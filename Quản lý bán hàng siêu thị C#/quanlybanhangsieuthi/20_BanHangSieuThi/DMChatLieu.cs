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
    public partial class DMChatLieu : Form
    {
        DataTable tblCL;
        public DMChatLieu()
        {
            InitializeComponent();
        }
    
        private void DMChatLieu_Load(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = false;
            btnLuu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Machatlieu,Tenchatlieu FROM tblChatLieu";
            tblCL = Data.GetDataToTable(sql);
            DgvChatLieu.DataSource = tblCL;
            DgvChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            DgvChatLieu.Columns[1].HeaderText = "Tên chất liệu";
            DgvChatLieu.Columns[0].Width = 200;
            DgvChatLieu.Columns[1].Width = 350;
            DgvChatLieu.AllowUserToAddRows = false;
            DgvChatLieu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DgvChatLieu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMachatlieu.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMachatlieu.Text = DgvChatLieu.CurrentRow.Cells["Machatlieu"].Value.ToString();
            txtTenchatlieu.Text = DgvChatLieu.CurrentRow.Cells["Tenchatlieu"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnboqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMachatlieu.Enabled = true;
            txtMachatlieu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenchatlieu.Focus();
                return;
            }
            sql = "UPDATE tblChatLieu SET Tenchatlieu=N'" + txtTenchatlieu.Text.ToString() + "'WHERE Machatlieu=N'" + txtMachatlieu.Text + "'";
            Data.RunSql(sql);
            ResetValues();
            Load_DataGridView();
            btnboqua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblChatLieu WHERE Machatlieu=N'" + txtMachatlieu.Text + "'";
                Data.RunSql(sql);
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
            txtMachatlieu.Enabled = false;
        }

        private void txtMachatlieu_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtMachatlieu.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenchatlieu.Focus();
                return;
            }
            if (txtTenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenchatlieu.Focus();
                return;
            }
            sql = "SELECT Machatlieu FROM tblChatLieu WHERE Machatlieu=N'" + txtMachatlieu.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMachatlieu.Focus();
                txtMachatlieu.Text = "";
                return;
            }
            sql = "INSERT INTO tblChatLieu(Machatlieu,Tenchatlieu) VALUES (N'" + txtMachatlieu.Text + "',N'" + txtTenchatlieu.Text + "')";
            Data.RunSql(sql);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachatlieu.Enabled = false;
        }
    }
}




