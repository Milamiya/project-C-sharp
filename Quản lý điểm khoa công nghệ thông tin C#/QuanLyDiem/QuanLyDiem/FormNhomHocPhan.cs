using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormNhomHocPhan : Form
    {
        public FormNhomHocPhan()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormNhomHocPhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_1DataSet11.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.cNPM_1DataSet11.GiangVien);
            // TODO: This line of code loads data into the 'cNPM_1DataSet10.KeHoachGiangDay' table. You can move, or remove it, as needed.
            this.keHoachGiangDayTableAdapter.Fill(this.cNPM_1DataSet10.KeHoachGiangDay);
            // TODO: This line of code loads data into the 'cNPM_1DataSet9.HocPhan' table. You can move, or remove it, as needed.
            this.hocPhanTableAdapter.Fill(this.cNPM_1DataSet9.HocPhan);
            dgvNhomHocPhan.DataSource= business.ShowData("NhomHocPhan");
        }
        int dong;
        private void dgvNhomHocPhan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaNhomHP.Text = dgvNhomHocPhan.Rows[dong].Cells[0].Value.ToString();
            txtTenNhomHP.Text = dgvNhomHocPhan.Rows[dong].Cells[1].Value.ToString();
            cmbMaHP.SelectedValue = dgvNhomHocPhan.Rows[dong].Cells[2].Value.ToString();
            cmbMaKHGD.SelectedValue = dgvNhomHocPhan.Rows[dong].Cells[3].Value.ToString();
            cmbMaGV.SelectedValue = dgvNhomHocPhan.Rows[dong].Cells[4].Value.ToString(); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhomHP.Text != "")
            {
                if (business.Proc_Insert("Insert_NhomHocPhan", txtMaNhomHP.Text))
                {
                    string sql = "'"+txtMaNhomHP.Text+"','"+txtTenNhomHP.Text+"','"+cmbMaHP.SelectedValue.ToString()+"','"+cmbMaKHGD.SelectedValue.ToString()+"','"+cmbMaGV.SelectedValue.ToString()+"'";
                    business.Insert("NhomHocPhan", sql);
                    FormNhomHocPhan_Load(sender, e);
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
                string sql = "MaNhomHP='" + txtMaNhomHP.Text + "'";
                business.Delete("NhomHocPhan", sql);
                FormNhomHocPhan_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenNhomHP='" + txtTenNhomHP.Text + "',MaHP='" + cmbMaHP.SelectedValue.ToString() + "',MaKHGD='" + cmbMaKHGD.SelectedValue.ToString() + "',MaGV='" + cmbMaGV.SelectedValue.ToString() +"' where MaNhomHP='"+txtMaNhomHP.Text+"'";
            business.Update("NhomHocPhan", sql);
            FormNhomHocPhan_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNhomHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
