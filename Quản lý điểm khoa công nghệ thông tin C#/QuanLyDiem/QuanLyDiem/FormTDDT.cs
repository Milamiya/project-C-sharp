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
    public partial class FormTDDT : Form
    {
        public FormTDDT()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormTDDT_Load(object sender, EventArgs e)
        {
            dgvTDDT.DataSource = business.ShowData("TrinhDoDaoTao");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dong;
        private void dgvTDDT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaTDDT.Text = dgvTDDT.Rows[dong].Cells[0].Value.ToString();
            txtTenTDDT.Text = dgvTDDT.Rows[dong].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?","Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaTDDT='" + txtMaTDDT.Text + "'";
                business.Delete("TrinhDoDaoTao", sql);
                FormTDDT_Load(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaTDDT.Text!="")
            {
                if (business.Proc_Insert("Insert_TrinhDoDaoTao",txtMaTDDT.Text))
                {
                    string sql = "'" + txtMaTDDT.Text + "','" + txtTenTDDT.Text + "'";
                    business.Insert("TrinhDoDaoTao", sql);
                    FormTDDT_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã TĐĐT đã tồn tại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenTDDT='"+txtTenTDDT.Text+"' where MaTDDT='"+txtMaTDDT.Text+"'";
            business.Update("TrinhDoDaoTao",sql);
            FormTDDT_Load(sender,e);
        }

        private void txtMaTDDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

    }
}
