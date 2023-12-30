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
    public partial class frmThemDotDanhGia : DevComponents.DotNetBar.Office2007Form
    {
        public frmThemDotDanhGia()
        {
            InitializeComponent();
        }
        DotDanhGiaCtr ctr = new DotDanhGiaCtr();
        DotDanhGiaData data = new DotDanhGiaData();

        private void frmThemDotDanhGia_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            btnThemmoidg.Enabled = false;
            ctr.HienthiDOTDANHGIADataGridview(dataGridViewDanhsachdotdanhgia);
            if (dataGridViewDanhsachdotdanhgia.Rows.Count > 0)
            {
                btnCapnhatdg.Enabled = true;
                btnXoadg.Enabled = true;
            }
            else
            {
                btnCapnhatdg.Enabled = false;
                btnXoadg.Enabled = false;
            }
        }

        private void btnLammoidg_Click(object sender, EventArgs e)
        {
            btnThemmoidg.Enabled = true;
            txtTen.Text = "";
            dtiNgaybatdau.Value = DateTime.Now;
            dtiNgayketthuc.Value = DateTime.Now;
            txtNhanxet.Text = "";

        }

        private void btnThemmoidg_Click(object sender, EventArgs e)
        {
            if (KIEMTRA())
            {
                data.ThemDOTDANHGIA(txtTen.Text, dtiNgaybatdau.Value.ToString(), dtiNgayketthuc.Value.ToString(), txtNhanxet.Text);
                loadData();
            }
        }


        private bool KIEMTRA()
        {
            if (txtTen.Text == "")
            {
                txtTen.BackColor = Color.Yellow;
                txtTen.Focus();
                return false;
            }
            return true;
        }

        private void btnCapnhatdg_Click(object sender, EventArgs e)
        {
            if (KIEMTRA())
            {
                DataGridViewRow row = dataGridViewDanhsachdotdanhgia.CurrentRow;
                string maddg = row.Cells["colmaddg"].Value.ToString();
                data.UpdateDOTDANHGIA(txtTen.Text, dtiNgaybatdau.Value.ToString(), dtiNgayketthuc.Value.ToString(), txtNhanxet.Text,maddg);
                loadData();
            }
        }

        private void btnXoadg_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhsachdotdanhgia.CurrentRow;
            string maddg = row.Cells["colmaddg"].Value.ToString();
            data.DeleteDOTDANHGIA(maddg);
            loadData();
        }

        private void dataGridViewDanhsachdotdanhgia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhsachdotdanhgia.Rows[e.RowIndex];

            txtTen.Text = row.Cells["coltenddg"].Value.ToString();
            dtiNgaybatdau.Value = Convert.ToDateTime(row.Cells["colngaybatdau"].Value.ToString());
            dtiNgayketthuc.Value = Convert.ToDateTime(row.Cells["colngayketthuc"].Value.ToString());
            txtNhanxet.Text = row.Cells["colnhanxet"].Value.ToString();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtTen.BackColor = Color.White;
        }

        private void dataGridViewDanhsachdotdanhgia_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
