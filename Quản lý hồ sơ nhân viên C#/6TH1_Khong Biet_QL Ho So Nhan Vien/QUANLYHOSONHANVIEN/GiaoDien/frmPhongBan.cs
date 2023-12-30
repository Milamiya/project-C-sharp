using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.Controller;
using QUANLYHOSONHANVIEN.DataLayer;
using QUANLYHOSONHANVIEN.GiaoDien;

namespace QUANLYHOSONHANVIEN
{
    public partial class frmPhongBan : DevComponents.DotNetBar.Office2007Form 
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        PhongBanCtr ctr = new PhongBanCtr();
        PhongBanData data = new PhongBanData();

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            ctr.HienthiPhongBnDataGridview(dataGridViewDanhSachPhongBan);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDanhSachPhongBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhSachPhongBan.Rows[e.RowIndex];
            //MessageBox.Show(e.RowIndex.ToString());

            //Thong tin nhan vien
            txtTenphong.Text = row.Cells["coltenpb"].Value.ToString();
            txtMaphong.Text = row.Cells["colmapb"].Value.ToString();
            txtMota.Text = row.Cells["colmota"].Value.ToString();
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                DataGridViewRow row = dataGridViewDanhSachPhongBan.CurrentRow;
                string mapb = row.Cells["colmapb"].Value.ToString();
                data.CapNhatPhongBan(txtTenphong.Text.ToString(), txtMota.Text.ToString(), mapb.ToString());
                loadData();
            }
        }

        private bool KiemTra()
        {
            if (txtTenphong.Text == "")
            {
                txtTenphong.BackColor = Color.Yellow;
                txtTenphong.Focus();
                return false;
            }
            return true;
        }

        private void txtTenphong_TextChanged(object sender, EventArgs e)
        {
            txtTenphong.BackColor = Color.White;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmThemPhongBan fthempb = new frmThemPhongBan();
            fthempb.ShowDialog();
            loadData();
        }
    }
}
