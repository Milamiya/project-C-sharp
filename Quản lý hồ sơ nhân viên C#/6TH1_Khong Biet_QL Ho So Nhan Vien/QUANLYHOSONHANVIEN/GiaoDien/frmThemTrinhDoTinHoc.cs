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
    public partial class frmThemTrinhDoTinHoc : DevComponents .DotNetBar .Office2007Form
    {
        public frmThemTrinhDoTinHoc()
        {
            InitializeComponent();
        }
        TrinhDoTinHocCtr ctr = new TrinhDoTinHocCtr();
        TrinhDoTinHocData data = new TrinhDoTinHocData();
        private void frmThemTrinhDoTinHoc_Load(object sender, EventArgs e)
        {

            loadData();
        }

        private void loadData()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiTRINHDOTINHOCDataGridview(dataGridViewTrinhDoTinHoc);
            if (dataGridViewTrinhDoTinHoc.Rows.Count > 0)
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
            long ma = ThamSo.TaoMaTDTH;
            ThamSo.TaoMaTDTH = ma + 1;
            string maso = "TDTH" + ma.ToString();
            txtmangoai.Text = maso;
            txttenngoai.Text = "";
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemTRINHDOTINHOC(txtmangoai.Text, txttenngoai.Text.ToString());
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
            DataGridViewRow row = dataGridViewTrinhDoTinHoc.CurrentRow;
            string matdth = row.Cells["colmatdth"].Value.ToString();
            if (kiemtra())
            {
                data.UpdateTRINHDOTINHOC(txttenngoai.Text, matdth);
                loadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewTrinhDoTinHoc.CurrentRow;
            string matdth = row.Cells["colmatdth"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Trình độ tin học này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteTRINHDOTINHOC(matdth);
                loadData();
            }
        }

        private void dataGridViewTrinhDoTinHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewTrinhDoTinHoc.Rows[e.RowIndex];
            //Thong tin chính
            txtmangoai.Text = row.Cells["colmatdth"].Value.ToString();
            txttenngoai.Text = row.Cells["coltentdth"].Value.ToString();
        }
    }
}
