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
    public partial class frmThemTrinhDo : DevComponents.DotNetBar.Office2007Form
    {
        public frmThemTrinhDo()
        {
            InitializeComponent();
        }
        TrinhDoCtr ctr = new TrinhDoCtr();
        TrinhDoData data = new TrinhDoData();
        private void frmThemTrinhDo_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiTRINHDODataGridview(dataGridViewNganhHoc);
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

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = true;
            long ma = ThamSo.TaoMaTRINHDO;
            ThamSo.TaoMaTRINHDO = ma + 1;
            string maso = "TD" + ma.ToString();
            txtmangoai.Text = maso;
            txttenngoai.Text = "";
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemTRINHDO(txtmangoai.Text, txttenngoai.Text.ToString());
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
                data.UpdateTRINHDO(txttenngoai.Text, manh);
                loadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNganhHoc.CurrentRow;
            string manh = row.Cells["colmanh"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Trình độ này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteTRINHDO(manh);
                loadData();
            }
        }

        private void dataGridViewNganhHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNganhHoc.Rows[e.RowIndex];
            //Thong tin chính
            txtmangoai.Text = row.Cells["colmanh"].Value.ToString();
            txttenngoai.Text = row.Cells["coltennh"].Value.ToString();
        }

        private void txttenngoai_TextChanged(object sender, EventArgs e)
        {
            txttenngoai.BackColor = Color.White;
        }
    }
}
