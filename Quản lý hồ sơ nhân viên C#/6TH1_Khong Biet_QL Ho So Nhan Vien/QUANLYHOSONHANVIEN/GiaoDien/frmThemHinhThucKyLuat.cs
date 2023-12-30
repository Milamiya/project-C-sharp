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
    public partial class frmThemHinhThucKyLuat : DevComponents .DotNetBar .Office2007Form
    {
        public frmThemHinhThucKyLuat()
        {
            InitializeComponent();
        }
        HinhThucKyLuatCtr ctr = new HinhThucKyLuatCtr();
        HinhThucKyLuatData data = new HinhThucKyLuatData();
        private void frmThemHinhThucKyLuat_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiKYLUATDataGridview(dataGridViewHTkyluat);
            if (dataGridViewHTkyluat.Rows.Count > 0)
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
            long ma = ThamSo.TaoMaHINHTHUCKL;
            ThamSo.TaoMaHINHTHUCKL = ma + 1;
            string maso = "KL" + ma.ToString();
            txtmangoai.Text = maso;
            txttenngoai.Text = "";
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemHINHTHUCKYLUAT(txtmangoai.Text, txttenngoai.Text.ToString());
                loadData();
                btnThemMoi.Enabled = false;
            }
        }
        private bool kiemtra()
        {
            if (txttenngoai.Text == "")
            {
                txttenngoai.BackColor = Color.White;
                txttenngoai.Focus();
                return false;
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewHTkyluat.CurrentRow;
            string makl = row.Cells["colmakl"].Value.ToString();
            if (kiemtra())
            {
                data.UpdateHINHTHUCKYLUAT(txttenngoai.Text, makl);
                loadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewHTkyluat.CurrentRow;
            string makl = row.Cells["colmakl"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Hình thức kỷ luật này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteHINHTHUCKYLUAT(makl);
                loadData();
            }
        }

        private void dataGridViewHTkyluat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewHTkyluat.Rows[e.RowIndex];
            //Thong tin chính
            txtmangoai.Text = row.Cells["colmakl"].Value.ToString();
            txttenngoai.Text = row.Cells["coltenkl"].Value.ToString();
        }
    }
}
