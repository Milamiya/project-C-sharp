using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.DataLayer;
using QUANLYHOSONHANVIEN.Controller;
namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmThemNganhHoc : DevComponents .DotNetBar.Office2007Form
    {
        NganhHocData data = new NganhHocData();
        NganhHocCtr ctr = new NganhHocCtr();
        public frmThemNganhHoc()
        {
            InitializeComponent();
        }

        private void frmThemNganhHoc_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiNganhHocDataGridview(dataGridViewNganhHoc);
            if (dataGridViewNganhHoc.Rows.Count > 0)
            {
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
         
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = true;
            long ma = ThamSo.TaoMaNganhHOC;
            ThamSo.TaoMaNganhHOC = ma + 1;
            string maso = "NH" + ma.ToString();
            txtmangoai.Text = maso;
            txttenngoai.Text = "";
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemNganhHoc(txtmangoai.Text, txttenngoai.Text.ToString());
                loadData();
                btnThemMoi.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNganhHoc.CurrentRow;
            string manh = row.Cells["colmanh"].Value.ToString();
            if (kiemtra())
            {
                data.UpdateNganhNganhHoc(txttenngoai.Text, manh);
                loadData();
            }
        }
        private bool kiemtra()
        {
            if (txttenngoai.Text == "")
            {
                txttenngoai.BackColor = Color.Yellow;
                txttenngoai.Focus();
                return false;
            }
            return true;
        }

        private void dataGridViewNganhHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNganhHoc.Rows[e.RowIndex];
            //Thong tin chính
            txtmangoai.Text = row.Cells["colmanh"].Value.ToString();
            txttenngoai.Text = row.Cells["coltennh"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNganhHoc.CurrentRow;
            string manh = row.Cells["colmanh"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá ngành học này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteNganhNganhHoc(manh);
                loadData();
            }
        }

        private void txttenngoai_TextChanged(object sender, EventArgs e)
        {
            txttenngoai.BackColor = Color.White;
        }
    }
}
