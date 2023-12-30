using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BLL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_1DataSet6.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.cNPM_1DataSet_Lop.Lop);
            dgvSinhVien.DataSource = business.ShowData("SinhVien");
        }
        int dong;
        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
            txtTenSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            cmbMaLop.SelectedValue = dgvSinhVien.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text!="")
            {
                if(business.Proc_Insert("Insert_SinhVien",txtMaSV.Text))
                {
                    string sql = "'"+txtMaSV.Text+"','"+txtTenSV.Text+"','"+dtpNgaySinh.Text+"','"+txtDiaChi.Text+"','"+cmbMaLop.SelectedValue.ToString()+"'";
                    business.Insert("SinhVien",sql);
                    FormSinhVien_Load(sender,e);
                }
                else
	            {
                    MessageBox.Show("Mã SV đã tồn tại");
	            }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaSV='" + txtMaSV.Text + "'";
                business.Delete("SinhVien", sql);
                FormSinhVien_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenSV='" + txtTenSV.Text + "',NgaySinh='" + dtpNgaySinh.Text + "',DiaChi='" + txtDiaChi.Text + "',MaLop='" + cmbMaLop.SelectedValue.ToString() +"' where MaSV='" + txtMaSV.Text + "'";
            business.Update("SinhVien", sql);
            FormSinhVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
