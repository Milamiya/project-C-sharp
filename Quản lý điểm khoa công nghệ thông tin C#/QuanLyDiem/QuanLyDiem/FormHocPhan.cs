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
    public partial class FormHocPhan : Form
    {
        public FormHocPhan()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormHocPhan_Load(object sender, EventArgs e)
        {
            dgvHocPhan.DataSource = business.ShowData("HocPhan");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHP.Text != "")
            {
                if (business.Proc_Insert("Insert_HocPhan", txtMaHP.Text))
                {
                    string sql = "'" + txtMaHP.Text + "','" + txtTenHP.Text + "'," + Convert.ToInt32(txtSoTC.Text) + "," + Convert.ToInt32(txtSoTietTH.Text) + "," + Convert.ToInt32(txtSoTietLT.Text) + "," + Convert.ToInt32(txtPhanTramDQT.Text) + "," + Convert.ToInt32(txtPhanTramDT.Text) + "";
                    business.Insert("HocPhan",sql);
                    FormHocPhan_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("Mã Học Phần đã tồn tại");
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?","Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaHP='" + txtMaHP.Text + "'";
                business.Delete("HocPhan", sql);
                FormHocPhan_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenHP='" + txtTenHP.Text + "',SoTC=" + Convert.ToInt32(txtSoTC.Text) + ",SoTietTH=" + Convert.ToInt32(txtSoTietTH.Text) + ",SoTietLT=" + Convert.ToInt32(txtSoTietLT.Text) + ",PhanTramDQT=" + Convert.ToInt32(txtPhanTramDQT.Text) + ",PhanTramDT=" + Convert.ToInt32(txtPhanTramDT.Text) + " where MaHP='"+txtMaHP.Text+"'";
            business.Update("HocPhan", sql);
            FormHocPhan_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dong;
        private void dgvHocPhan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaHP.Text = dgvHocPhan.Rows[dong].Cells[0].Value.ToString();
            txtTenHP.Text = dgvHocPhan.Rows[dong].Cells[1].Value.ToString();
            txtSoTC.Text = dgvHocPhan.Rows[dong].Cells[2].Value.ToString();
            txtSoTietTH.Text=dgvHocPhan.Rows[dong].Cells[3].Value.ToString();
            txtSoTietLT.Text = dgvHocPhan.Rows[dong].Cells[4].Value.ToString();
            txtPhanTramDQT.Text = dgvHocPhan.Rows[dong].Cells[5].Value.ToString();
            txtPhanTramDT.Text = dgvHocPhan.Rows[dong].Cells[6].Value.ToString(); 
        }

        private void txtSoTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar!='\b')
                e.Handled=true;
        }

        private void txtSoTietTH_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoTC_KeyPress(sender, e);
        }

        private void txtSoTietLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoTC_KeyPress(sender, e);
        }

        private void txtPhanTramDQT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoTC_KeyPress(sender, e);
        }

        private void txtPhanTramDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoTC_KeyPress(sender, e);
        }

        private void txtMaHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

    }
}
