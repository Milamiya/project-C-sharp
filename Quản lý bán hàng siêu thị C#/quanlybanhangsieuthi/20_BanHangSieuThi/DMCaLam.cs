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
    public partial class DMCaLam : Form
    {
        public DMCaLam()
        {
            InitializeComponent();
        }
        DataTable tblCaLam;

        private void DMCaLam_Load(object sender, EventArgs e)
        {
            txtMaca.Enabled = false;
            btnLuu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql = "SELECT Maca,Tenca FROM tblCaLam";
            tblCaLam = Data.GetDataToTable(sql);
            DgvCaLam.DataSource = tblCaLam;
            DgvCaLam.Columns[0].HeaderText = "Mã ca làm";
            DgvCaLam.Columns[1].HeaderText = "Tên ca làm";
            DgvCaLam.Columns[0].Width = 200;
            DgvCaLam.Columns[1].Width = 350;
            DgvCaLam.AllowUserToAddRows = false;
            DgvCaLam.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
          

        private void DgvCaLam_Click(object sender, EventArgs e)
        {
              if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaca.Focus();
                return;
            }
             if (tblCaLam.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
             txtMaca.Text = DgvCaLam.CurrentRow.Cells["Maca"].Value.ToString();
             txtTenca.Text = DgvCaLam.CurrentRow.Cells["Tenca"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtMaca.Text = "";
            txtTenca.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnboqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaca.Enabled = true;
            txtMaca.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCaLam.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaca.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblCaLam WHERE Maca=N'" + txtMaca.Text + "'";
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
            txtMaca.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if(txtMaca.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập mã ca làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaca.Focus();
                return;
            }
            if (txtTenca.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ca làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenca.Focus();
                return;
            }
            sql = "SELECT Maca FROM tblCaLam WHERE Maca=N'" + txtMaca.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã ca làm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaca.Focus();
                txtMaca.Text = "";
                return;
            }
            sql = "INSERT INTO tblCaLam(Maca,Tenca) VALUES (N'" + txtMaca.Text + "',N'" + txtTenca.Text + "')";
            Data.RunSql(sql);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaca.Enabled = false;
        }

        private void txtMaca_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCaLam.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaca.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenca.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ca làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenca.Focus();
                return;
            }
            sql = "UPDATE tblCaLam SET Tenca=N'" + txtTenca.Text.ToString() + "'WHERE Maca=N'" + txtMaca.Text + "'";
            Data.RunSql(sql);
            ResetValues();
            Load_DataGridView();
            btnboqua.Enabled = false;
            btnLuu.Enabled = true;
        }
    }
}


      

