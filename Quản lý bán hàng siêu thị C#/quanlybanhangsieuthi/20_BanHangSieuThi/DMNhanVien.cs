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
    public partial class DMNhanVien : Form
    {
        public DMNhanVien()
        {
            InitializeComponent();
        }
        DataTable tblNV;
        private void DMNhanVien_Load(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = false;
            btnLuu.Enabled = false;
            btnboqua.Enabled = false;
            Load_dgvNhanVien();
            Data.FillCombo("SELECT Macongviec, Tencongviec FROM tblCongViec", cboMacongviec, "Macongviec", "Tencongviec");
            cboMacongviec.SelectedIndex = -1;
            resetvalues();
        }

        private void Load_dgvNhanVien()
        {
            string sql;
            sql = "SELECT Manhanvien,Tennhanvien,Gioitinh,Diachi,Dienthoai,Ngaysinh,Macongviec FROM tblNhanVien";
            tblNV = Data.GetDataToTable(sql);
            dgvNhanVien.DataSource = tblNV;
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[6].HeaderText = "Mã công việc";
            dgvNhanVien.Columns[0].Width = 100;
            dgvNhanVien.Columns[1].Width = 100;
            dgvNhanVien.Columns[2].Width = 100;
            dgvNhanVien.Columns[3].Width = 100;
            dgvNhanVien.Columns[4].Width = 100;
            dgvNhanVien.Columns[5].Width = 100;
            dgvNhanVien.Columns[6].Width = 100;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnboqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            resetvalues();
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDienthoai.Focus();
                return;
            }
            if (mskNgaysinh.Text == "   /    /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskNgaysinh.Focus();
                return;
            }
            //if (!Data.IsDate(mskNgaysinh.Text))
            //{
            //    MessageBox.Show("Bạn phải nhập lại ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskNgaysinh.Text = "";
            //    mskNgaysinh.Focus();
            //    return;
            //}
            if (chkGioitinh.Checked == true)

                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT Manhanvien FROM tblNhanVien WHERE Manhanvien=N'" + txtManhanvien.Text.Trim() + "'";
            if (Data.Checkey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanVien(Manhanvien,Tennhanvien,Gioitinh,Diachi,Dienthoai,Ngaysinh,Macongviec) VALUES (N'" + txtManhanvien.Text.Trim() + "',N'" + txtTennhanvien.Text.Trim().ToString() + "',N'" + gt + "',N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "','" + Data.ConvertDateTime(mskNgaysinh.Text) + "',N'" + cboMacongviec.Text + "')";
            Data.RunSql(sql);
            Load_dgvNhanVien();
            resetvalues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnboqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
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
            if (mskNgaysinh.Text == "   /   /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            //if (!Data.IsDate(mskNgaysinh.Text))
            //{
            //    MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskNgaysinh.Text = "";
            //    mskNgaysinh.Focus();
            //    return;
            //}
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanVien SET Tennhanvien=N'" + txtTennhanvien.Text.Trim().ToString() + "',Diachi=N'" + txtDiachi.Text.Trim().ToString() + "',Dienthoai=N'" + mskDienthoai.Text.ToString() + "',Gioitinh=N'" + gt + "',Ngaysinh='" + Data.ConvertDateTime(mskNgaysinh.Text) + "'WHERE Manhanvien=N'" + txtManhanvien.Text + "'";
            Data.RunSql(sql);
            Load_dgvNhanVien();
            resetvalues();
            btnboqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không con dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chon bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanVien WHERE Manhanvien=N'" + txtManhanvien.Text + "'";
                Data.RunSql(sql);
                Load_dgvNhanVien();
                resetvalues();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnboqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void txtManhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTennhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskNgaysinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskDienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void resetvalues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            chkGioitinh.Checked = false;
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            mskNgaysinh.Text = "";
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManhanvien.Text = dgvNhanVien.CurrentRow.Cells["Manhanvien"].Value.ToString();
            txtTennhanvien.Text = dgvNhanVien.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
                chkGioitinh.Checked = true;
            else
                chkGioitinh.Checked = false;
            txtDiachi.Text = dgvNhanVien.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = dgvNhanVien.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskNgaysinh.Text = dgvNhanVien.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            cboMacongviec.Text = dgvNhanVien.CurrentRow.Cells["Macongviec"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnboqua.Enabled = true;
        }
    }
}
