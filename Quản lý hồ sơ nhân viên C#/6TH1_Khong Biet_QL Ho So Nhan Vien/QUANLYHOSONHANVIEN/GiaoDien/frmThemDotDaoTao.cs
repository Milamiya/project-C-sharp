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
    public partial class frmThemDotDaoTao : DevComponents .DotNetBar .Office2007Form
    {
        public frmThemDotDaoTao()
        {
            InitializeComponent();
        }
        DotDaoTaoCtr ctr = new DotDaoTaoCtr();
        DotDaoTaoData data = new DotDaoTaoData();
        private void frmThemDotDaoTao_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        private void loaddata()
        {
            ctr.HienthiDOTDaoTaoDataGridview(dataGridViewDanhsachdotdaotao);
            btnThemmoiTGDT .Enabled =false;
            if (dataGridViewDanhsachdotdaotao.Rows.Count == 0)
            {
                btnCapnhatTGDT.Enabled = false;
                btnXoaTGDT.Enabled = false;
            }
            else
            {
                btnCapnhatTGDT.Enabled = true;
                btnXoaTGDT.Enabled = true;
            }
        }

        private void btnLammoiTGDT_Click(object sender, EventArgs e)
        {
            txtTenddt.Text = "";
            txtNoidt.Text = "";
            txtNganhdt.Text = "";
            txtChuyennganh.Text = "";
            txtHinhthucdt.Text = "";
            btnThemmoiTGDT.Enabled = true;
            dtiNgayketthuc.Value = DateTime.Now;
            dtiNgaybatdau.Value = DateTime.Now;
        }

        private void btnThemmoiTGDT_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemDOTDAOTAO(txtTenddt.Text.ToString(), txtNoidt.Text.ToString(), txtNganhdt.Text.ToString(),txtChuyennganh.Text .ToString(),txtHinhthucdt .Text .ToString(),dtiNgaybatdau.Value .ToString(),dtiNgayketthuc.Value.ToString());
                loaddata();
            }
            
        }

        private bool kiemtra()
        {
            if (txtTenddt.Text == "")
            {
                txtTenddt.BackColor = Color.Yellow;
                txtTenddt.Focus();
                return false;
            }
            if (txtNoidt.Text == "")
            {
                txtNoidt.BackColor = Color.Yellow;
                txtNoidt.Focus();
                return false;
            }
            if (txtNganhdt.Text == "")
            {
                txtNganhdt.BackColor = Color.Yellow;
                txtNganhdt.Focus();
                return false;
            }
            if (txtChuyennganh.Text == "")
            {
                txtChuyennganh.BackColor = Color.Yellow;
                txtChuyennganh.Focus();
                return false;
            }
            if (txtHinhthucdt.Text == "")
            {
                txtHinhthucdt.BackColor = Color.Yellow;
                txtHinhthucdt.Focus();
                return false;
            }
            return true;
        }

        private void txtTenddt_TextChanged(object sender, EventArgs e)
        {
            txtTenddt.BackColor = Color.White;
            txtNoidt.BackColor = Color.White;
            txtNganhdt.BackColor = Color.White;
            txtChuyennganh.BackColor = Color.White;
            txtHinhthucdt.BackColor = Color.White;
        }

        private void btnCapnhatTGDT_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                DataGridViewRow row = dataGridViewDanhsachdotdaotao.CurrentRow;
                string maDDT = row.Cells["colmaDDT"].Value.ToString();
                data.UpdateDOTDAOTAO(txtTenddt.Text.ToString(), txtNoidt.Text.ToString(), txtNganhdt.Text.ToString(), txtChuyennganh.Text.ToString(), txtHinhthucdt.Text.ToString(), dtiNgaybatdau.Value.ToString(), dtiNgayketthuc.Value.ToString(), maDDT.ToString());
                loaddata();
            }
        }

        private void btnXoaTGDT_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhsachdotdaotao.CurrentRow;
            string maddt = row.Cells["colmaDDT"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá đợt đào tạo này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteDOTDAOTAO(maddt.ToString());
                loaddata();
            }
        }

        private void dataGridViewDanhsachdotdaotao_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewDanhsachdotdaotao.Rows[e.RowIndex];

            txtTenddt.Text = row.Cells["coltenddt"].Value.ToString();
            txtNoidt.Text = row.Cells["colnoidt"].Value.ToString();
            txtNganhdt.Text = row.Cells["colnganhdt"].Value.ToString();
            txtChuyennganh.Text = row.Cells["colchuyennganh"].Value.ToString();
            txtHinhthucdt.Text = row.Cells["colhinhthucdaotao"].Value.ToString();
            dtiNgaybatdau.Value = Convert.ToDateTime(row.Cells["colngaybatdau"].Value.ToString());
            dtiNgayketthuc.Value = Convert.ToDateTime(row.Cells["colngayketthuc"].Value.ToString());
        }
    }
}
