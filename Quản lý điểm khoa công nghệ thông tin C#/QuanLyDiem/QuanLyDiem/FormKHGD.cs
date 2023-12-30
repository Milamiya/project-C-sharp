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
    public partial class FormKHGD : Form
    {
        public FormKHGD()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormKHGD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_1DataSet5.KhoiLop' table. You can move, or remove it, as needed.
            this.khoiLopTableAdapter.Fill(this.cNPM_1DataSet_KhoiLop.KhoiLop);
            // TODO: This line of code loads data into the 'cNPM_1DataSet4.HocKy' table. You can move, or remove it, as needed.
            this.hocKyTableAdapter.Fill(this.cNPM_1DataSet_HocKy.HocKy);
            dgvKHGD.DataSource = business.ShowData("KeHoachGiangDay");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKHGD.Text != "")
            {
                if (business.Proc_Insert("Insert_KHGD",txtMaKHGD.Text))
                {
                    string sql = "'"+txtMaKHGD.Text+"','"+cmbMahocKy.SelectedValue.ToString()+"','"+cmbMaKhoiLop.SelectedValue.ToString()+"'";
                    business.Insert("KeHoachGiangDay",sql);
                    FormKHGD_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã KHGD đã tồn tại rồi");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaKHGD='" + txtMaKHGD.Text + "'";
                business.Delete("KeHoachGiangDay", sql);
                FormKHGD_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "MaHK='"+cmbMahocKy.SelectedValue.ToString()+"',MaKhoiLop='"+cmbMaKhoiLop.SelectedValue.ToString()+"' where MaKHGD='"+txtMaKHGD.Text+"'";
            business.Update("KeHoachGiangDay",sql);
            FormKHGD_Load(sender, e);
        }
        int dong;
        private void dgvKHGD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaKHGD.Text = dgvKHGD.Rows[dong].Cells[0].Value.ToString();
            cmbMahocKy.SelectedValue = dgvKHGD.Rows[dong].Cells[1].Value.ToString();
            cmbMaKhoiLop.SelectedValue = dgvKHGD.Rows[dong].Cells[2].Value.ToString();
        }

        private void txtMaKHGD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

    }
}
