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
    public partial class frmThemCongViec : DevComponents .DotNetBar .Office2007Form
    {
        public frmThemCongViec()
        {
            InitializeComponent();
        }
        CongViecCtr ctr = new CongViecCtr();
        CongViecData data = new CongViecData();
        private void frmThemCongViec_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiCONGVIECDataGridview(dataGridViewNgheNghiep);
            if (dataGridViewNgheNghiep.Rows.Count > 0)
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
            long ma = ThamSo.TaoMaCONGVIEC;
            ThamSo.TaoMaCONGVIEC = ma + 1;
            string maso = "CV" + ma.ToString();
            txtmanghe.Text = maso;
            txttennghenghiep.Text = "";
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemCONGVIEC(txtmanghe.Text, txttennghenghiep.Text.ToString());
                loaddata();
                btnThemMoi.Enabled = false;
            }
        }
        private bool kiemtra()
        {
            if (txttennghenghiep.Text == "")
            {
                txttennghenghiep.BackColor = Color.Yellow;
                txttennghenghiep.Focus();
                return false;
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNgheNghiep.CurrentRow;
            string manghenghiep = row.Cells["colmannNghenghiep"].Value.ToString();
            if (kiemtra())
            {
                data.UpdateCONGVIEC(txttennghenghiep.Text, manghenghiep);
                loaddata();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNgheNghiep.CurrentRow;
            string manghenghiep = row.Cells["colmannNghenghiep"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Công việc này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteCONGVIEC(manghenghiep);
                loaddata();
            }
        }

        private void dataGridViewNgheNghiep_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNgheNghiep.Rows[e.RowIndex];
            //Thong tin chính
            txtmanghe.Text = row.Cells["colmannNghenghiep"].Value.ToString();
            txttennghenghiep.Text = row.Cells["coltenNNnghenghiep"].Value.ToString();
        }

        private void txttennghenghiep_TextChanged(object sender, EventArgs e)
        {
            txttennghenghiep.BackColor = Color.White;
        }
    }
}
