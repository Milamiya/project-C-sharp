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
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_1DataSet8.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.cNPM_1DataSet_GiangVien.GiangVien);
            // TODO: This line of code loads data into the 'cNPM_1DataSet7.KhoiLop' table. You can move, or remove it, as needed.
            this.khoiLopTableAdapter.Fill(this.cNPM_1DataSet_KhoiLop.KhoiLop);
            dgvLop.DataSource = business.ShowData("Lop");

        }
        int dong;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaLop.Text=dgvLop.Rows[dong].Cells[0].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString();
            cmbMaKhoiLop.SelectedValue = dgvLop.Rows[dong].Cells[2].Value.ToString();
            cmbMaGV.SelectedValue = dgvLop.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaLop='" + txtMaLop.Text + "'";
                business.Delete("Lop", sql);
                FormLop_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenLop='"+txtTenLop.Text+"',MaKhoiLop='"+cmbMaKhoiLop.SelectedValue.ToString()+"',MaGV='"+cmbMaGV.SelectedValue.ToString()+"' where MaLop='"+txtMaLop.Text+"'";
            business.Update("Lop",sql);
            FormLop_Load(sender,e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "")
            {
                if (business.Proc_Insert("Insert_Lop", txtMaLop.Text))
                {
                    string sql = "'"+txtMaLop.Text+"','"+txtTenLop.Text+"','"+cmbMaKhoiLop.SelectedValue.ToString()+"','"+cmbMaGV.SelectedValue.ToString()+"'";
                    business.Insert("Lop",sql);
                    FormLop_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("Mã Lớp đã tồn tại");
                }
            }
        }

        private void txtMaLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
