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
    public partial class DMCongViec : Form
    {
        public DMCongViec()
        {
            InitializeComponent();
        }
        DataTable tblCV;

        private void DMCongViec_Load(object sender, EventArgs e)
        {
            txtMacongviec.Enabled = false;
            btnLuu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Macongviec,Tencongviec FROM tblCongViec";
            tblCV = Data.GetDataToTable(sql);
            DgvCV.DataSource = tblCV;
            DgvCV.Columns[0].HeaderText = "Mã công việc";
            DgvCV.Columns[1].HeaderText = "Tên công việc";
            DgvCV.Columns[0].Width = 250;
            DgvCV.Columns[1].Width = 300;
            DgvCV.AllowUserToAddRows = false;
            DgvCV.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void DgvCV_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMacongviec.Focus();
                return;
            }
            if (tblCV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtMacongviec.Text = DgvCV.CurrentRow.Cells["Macongviec"].Value.ToString();
            txtTencongviec.Text = DgvCV.CurrentRow.Cells["Tencongviec"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled=false;
            btnXoa.Enabled=false;
            btnThem.Enabled=false;
            btnboqua.Enabled=true;
            btnLuu.Enabled=true;
            txtMacongviec.Enabled=true;
            txtMacongviec.Focus();
        }

        private void ResetValues()
        {
            txtMacongviec.Text="";
            txtTencongviec.Text="";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblCV.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtMacongviec.Text=="")
            {
                MessageBox.Show("Bạn phải nhập mã công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtTencongviec.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập tên công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql= "UPDATE tblCongViec SET Tencongviec=N'" +txtTencongviec.Text.ToString()+"' WHERE Macongviec=N'"+txtMacongviec.Text+"'";
            Data.RunSql(sql);
            Load_DataGridView();
            btnboqua.Enabled=false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           string sql;
            if(tblCV.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtMacongviec.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                sql = "DELETE tblCongViec WHERE Macongviec=N'" + txtMacongviec.Text + "'";
                Data.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();

        }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMacongviec.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMacongviec.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMacongviec.Focus();
                return;
            }

            if (txtTencongviec.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTencongviec.Focus();
                return;
            }
            sql = "SELECT Macongviec FROM tblCongViec WHERE Macongviec=N'" + txtMacongviec.Text.Trim() + "'";
            if(Data.Checkey(sql))
            {
                MessageBox.Show("Mã công việc này đã có, bạn phải nhập mã khác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtMacongviec.Focus();
                txtMacongviec.Text = "";
                return;
            }
            sql="INSERT INTO tblCongViec(Macongviec,Tencongviec) VALUES (N'"+txtMacongviec.Text+"',N'"+txtTencongviec.Text+"')";
            Data.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMacongviec.Enabled = false;
        }

        private void txtMaCV_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                SendKeys.Send("{TAB}");
        }          
    }
}
