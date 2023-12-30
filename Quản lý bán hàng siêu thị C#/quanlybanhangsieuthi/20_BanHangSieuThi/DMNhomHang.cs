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
    public partial class DMNhomHang : Form
    {
        DataTable tblNH;
        public DMNhomHang()
        {
            InitializeComponent();
        }

        private void DMNhomHang_Load(object sender, EventArgs e)
        {
            txtManhom.Enabled=false;
            btnLuu.Enabled=false;
            btnboqua.Enabled=false;
            Load_DataGridView();
        }

         private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Manhom,Tennhom FROM tblNhomHang";
            tblNH = Data.GetDataToTable(sql);
            DgvNhomhang.DataSource = tblNH;
            DgvNhomhang.Columns[0].HeaderText = "Mã nhóm";
            DgvNhomhang.Columns[1].HeaderText = "Tên nhóm";
            DgvNhomhang.Columns[0].Width = 200;
            DgvNhomhang.Columns[1].Width = 350;
            DgvNhomhang.AllowUserToAddRows = false;
            DgvNhomhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DgvNhomHang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang chờ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhom.Focus();
                return;
            }
            if (tblNH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhom.Text = DgvNhomhang.CurrentRow.Cells["Manhom"].Value.ToString();
            txtTennhom.Text = DgvNhomhang.CurrentRow.Cells["Tennhom"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtManhom.Text = "";
            txtTennhom.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnboqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManhom.Enabled = true;
            txtManhom.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
              string sql;
            if (tblNH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhom.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhóm hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtTennhom.Focus();
                return;
            }
            sql = "UPDATE tblNhomHang SET Tennhom=N'" + txtTennhom.Text.ToString() + "'WHERE Manhom=N'" + txtManhom.Text + "'";
            Data.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            txtTennhom.Focus();
            btnboqua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhom.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhomHang WHERE Manhom=N'" + txtManhom.Text + "'";
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
            txtManhom.Enabled = false;
        
        }

        private void txtManhom_KeyUp(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             string sql;
            if(txtManhom.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập mã nhóm hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennhom.Focus();
                return;
            }
            if (txtTennhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhóm hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennhom.Focus();
                return;
            }
            sql = "SELECT Manhom FROM tblNhomHang WHERE Manhom=N'" + txtManhom.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã nhóm hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhom.Focus();
                txtManhom.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhomHang(Manhom,Tennhom) VALUES (N'" + txtManhom.Text + "',N'" + txtTennhom.Text + "')";
            Data.RunSql(sql);
            Load_DataGridView();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhom.Enabled = false;
        }
    }
}





  
       

        

       
        
      
     