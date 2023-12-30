using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.DataLayer ;
using QUANLYHOSONHANVIEN.Controller ;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmThemNgheghiep : DevComponents .DotNetBar.Office2007Form
    {
        public frmThemNgheghiep()
        {
            InitializeComponent();
        }
        NgheNghiepCtr ctr = new NgheNghiepCtr();
        NgheNghiepData data = new NgheNghiepData();

        private void frmThemNgheghiep_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemNGHENGHIEP(txtmanghe.Text , txttennghenghiep.Text.ToString(), txtghichu.Text.ToString());
                loaddata();
                btnThemMoi.Enabled = false;
            }
        }

        private bool kiemtra()
        {
            if (txttennghenghiep.Text == "")
            {
                txttennghenghiep.BackColor = Color.White;
                txttennghenghiep.Focus();
                return false;
            }
            if (txtghichu.Text == "")
            {
                txtghichu.Text = "Chưa có ";
            }
            return true;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNgheNghiep.CurrentRow;
            string manghenghiep = row.Cells["colmannNghenghiep"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá nghề nghiệp này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteNGHENGHIEP(manghenghiep);
                loaddata();
            }
        }

        private void loaddata()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiNgheNghiepDataGridview(dataGridViewNgheNghiep);
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
            long ma = ThamSo.TaoMaNgheNghiep;
            ThamSo.TaoMaNgheNghiep = ma + 1;
            string maso = "NN" + ma.ToString();
            txtmanghe.Text = maso;
            txttennghenghiep.Text = "";
            txtghichu.Text = "";
            btnThemMoi.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNgheNghiep.CurrentRow;
            string manghenghiep = row.Cells["colmannNghenghiep"].Value.ToString();
            if (kiemtra())
            {
                data.UpdateNGHENGHIEP(txttennghenghiep.Text, txtghichu.Text, manghenghiep);
                loaddata();
            }
        }

        private void dataGridViewNgheNghiep_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNgheNghiep.Rows[e.RowIndex];
            //Thong tin chính
            txtmanghe.Text = row.Cells["colmannNghenghiep"].Value.ToString();
            txttennghenghiep.Text = row.Cells["coltenNNnghenghiep"].Value.ToString();
            txtghichu.Text = row.Cells["colghichunn"].Value.ToString();
        }
    }
}
