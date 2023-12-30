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
    public partial class FormKhoiLop : Form
    {
        public FormKhoiLop()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormKhoiLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_1DataSet3.TrinhDoDaoTao' table. You can move, or remove it, as needed.
            this.trinhDoDaoTaoTableAdapter.Fill(this.cNPM_1DataSet_TrinhDoDaoTao.TrinhDoDaoTao);
            // TODO: This line of code loads data into the 'cNPM_1DataSet2.HeDaoTao' table. You can move, or remove it, as needed.
            this.heDaoTaoTableAdapter.Fill(this.cNPM_1DataSet_HeDaoTao.HeDaoTao);
            dgvKhoiLop.DataSource = business.ShowData("KhoiLop");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dong;
        private void dgvKhoiLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaKhoiLop.Text = dgvKhoiLop.Rows[dong].Cells[0].Value.ToString();
            txtTenKhoiLop.Text = dgvKhoiLop.Rows[dong].Cells[1].Value.ToString();
            cmbMaHeDT.SelectedValue = dgvKhoiLop.Rows[dong].Cells[2].Value.ToString();
            cmbMaTDDT.SelectedValue = dgvKhoiLop.Rows[dong].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaKhoiLop.Text!="")
            {
                if(business.Proc_Insert("Insert_KhoiLop",txtMaKhoiLop.Text))
                {
                    string sql = "'" + txtMaKhoiLop.Text + "','" + txtTenKhoiLop.Text + "','" + cmbMaHeDT.SelectedValue.ToString() + "','" + cmbMaHeDT.SelectedValue.ToString() + "'";
                    business.Insert("KhoiLop", sql);
                    FormKhoiLop_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã Khối Lớp đã tồn tại rồi");
                }
            }      
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?","Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaKhoiLop='" + txtMaKhoiLop.Text + "'";
                business.Delete("KhoiLop", sql);
                FormKhoiLop_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenKhoiLop='" + txtTenKhoiLop.Text + "',MaHeDT='" + cmbMaHeDT.SelectedValue.ToString() + "',MaTDDT='" + cmbMaTDDT.SelectedValue.ToString() + "' where MaKhoiLop='" + txtMaKhoiLop.Text + "'";
            business.Update("KhoiLop",sql);
            FormKhoiLop_Load(sender, e);
        }

        private void txtMaKhoiLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
