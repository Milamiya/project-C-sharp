using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BLL;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormGiangVien : Form
    {
        public FormGiangVien()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            dgvGiangVien.DataSource = business.ShowData("GiangVien");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dong;

        private void dgvGiangVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaGV.Text = dgvGiangVien.Rows[dong].Cells[0].Value.ToString();
            txtTenGV.Text = dgvGiangVien.Rows[dong].Cells[1].Value.ToString();
            dtpNamSinh.Text = dgvGiangVien.Rows[dong].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvGiangVien.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text!="")
            {
                if(business.Proc_Insert("Insert_GiangVien",txtMaGV.Text))
                {
                    string sql = "'"+txtMaGV.Text+"','"+txtTenGV.Text+"','"+dtpNamSinh.Text+"','"+txtDiaChi.Text+"'";
                    business.Insert("GiangVien",sql);
                    FormGiangVien_Load(sender,e);
                }
                else
	            {
                    MessageBox.Show("Mã GV đã tồn tại");
	            }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?","Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaGV='" + txtMaGV.Text + "'";
                business.Delete("GiangVien", sql);
                FormGiangVien_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenGV='"+txtTenGV.Text+"',NgaySinh='"+dtpNamSinh.Text+"',DiaChi='"+txtDiaChi.Text+"' where MaGV='"+txtMaGV.Text+"'";
            business.Update("GiangVien",sql);
            FormGiangVien_Load(sender,e);
        }

        private void txtMaGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

    }
}
