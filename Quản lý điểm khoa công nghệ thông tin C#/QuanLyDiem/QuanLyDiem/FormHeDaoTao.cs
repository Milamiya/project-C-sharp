using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using BLL;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormHeDaoTao : Form
    {
        public FormHeDaoTao()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormHeDaoTao_Load(object sender, EventArgs e)
        {
            dgvHeDaoTao.DataSource = business.ShowData("HeDaoTao");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dong;
        private void dgvHeDaoTao_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaHeDT.Text = dgvHeDaoTao.Rows[dong].Cells[0].Value.ToString();
            txtTenHeDT.Text = dgvHeDaoTao.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaHeDT.Text!="")
            {
                if (business.Proc_Insert("Insert_HeDaoTao", txtMaHeDT.Text))
                {
                    string sql = "'" + txtMaHeDT.Text + "','" + txtTenHeDT.Text + "'";
                    business.Insert("HeDaoTao", sql);
                    FormHeDaoTao_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã Hệ Đào Tạo đã tồn tại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?","Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaHeDT = '" + txtMaHeDT.Text + "'";
                business.Delete("HeDaoTao", sql);
                FormHeDaoTao_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenHeDT ='"+txtTenHeDT.Text+"' where MaHeDT='"+txtMaHeDT.Text+"'";
            business.Update("HeDaoTao",sql);
            FormHeDaoTao_Load(sender,e);
        }

        private void txtMaHeDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
