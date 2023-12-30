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
    public partial class frmThemPhuCap : DevComponents.DotNetBar.Office2007Form
    {
        public frmThemPhuCap()
        {
            InitializeComponent();
        }
        public frmThemPhuCap(bool d)
            : this()
        {
            if (d == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        PhuCapCtr ctr = new PhuCapCtr();
        PhuCapData data = new PhuCapData();
        private void frmThemPhuCap_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiHINHTHUCKTHUONGDataGridview(dataGridViewNganhHoc);
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
            if (diHeSo .Value  == null)
            {                
                diHeSo.Focus();
                return false;
            }
            return true;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = true;
            long ma = ThamSo.TaoMaPHUCAP;
            ThamSo.TaoMaPHUCAP = ma + 1;
            string maso = "PHUCAP" + ma.ToString();
            txtmangoai.Text = maso;
            txttenngoai.Text = "";
            diHeSo.Value = 0;
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemPHUCAP(txtmangoai.Text, txttenngoai.Text.ToString(), diHeSo.Value.ToString());
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
                data.UpdatePHUCAP(txttenngoai.Text, manh, diHeSo.Value.ToString());
                loadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNganhHoc.CurrentRow;
            string manh = row.Cells["colmanh"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Phụ cấp này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeletePHUCAP(manh);
                loadData();
            }
        }

        private void dataGridViewNganhHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNganhHoc.Rows[e.RowIndex];
            //Thong tin chính
            txtmangoai.Text = row.Cells["colmanh"].Value.ToString();
            txttenngoai.Text = row.Cells["coltennh"].Value.ToString();
            diHeSo.Value = Convert.ToDouble(row.Cells["colheso"].Value.ToString());
        }

        private void diHeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Bạn phải nhập số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txttenngoai_TextChanged(object sender, EventArgs e)
        {
            txttenngoai.BackColor = Color.White;
        }

        private void diHeSo_Click(object sender, EventArgs e)
        {
            diHeSo.Value = 0;
        }        
    }
}
