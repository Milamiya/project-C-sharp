using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
using QLKTX.BusinessObject;

namespace QLKTX
{
    public partial class frmDanhGia : Form
    {
        bool Adding = false;
        bool Updating = false;
        DanhGiaCtrl ctrl = new DanhGiaCtrl();
        public frmDanhGia()
        {
            InitializeComponent();
        }

        private void dataDSDanhGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDSDanhGia.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataDSDanhGia.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Adding = true;
            Updating = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            btnCapNhat.Enabled = true;
            btnBoQua.Visible = true;


            txtTen.Enabled = true;
            txtTen.Text = "";
            txtTen.Focus();
            txtMa.Enabled = false;

            dataDSDanhGia.Enabled = false;

            txtMa.Text = ctrl.LayMaMax().ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataDSDanhGia.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn xóa quốc tịch \"" + txtTen.Text + " Chứ?", "Quốc tịch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IEnumerator ie = (IEnumerator)dataDSDanhGia.SelectedRows.GetEnumerator();
                    if (ie.MoveNext())
                    {
                        DataGridViewRow row = (DataGridViewRow)ie.Current;
                        QLKTX.BusinessObject.DanhGiaInfo info = new QLKTX.BusinessObject.DanhGiaInfo();
                        info.MaDanhGia = Convert.ToInt32(row.Cells[0].Value.ToString());
                        ctrl.Xoa(info);
                    }
                    ctrl.LayDSDanhGia(dataDSDanhGia);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Adding = false;
            Updating = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            btnCapNhat.Enabled = true;
            btnBoQua.Visible = true;

            dataDSDanhGia.Enabled = false;

            txtTen.Enabled = true;
            txtTen.Focus();
            txtMa.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ctrl.KiemTra(txtMa, txtTen))
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;

                btnCapNhat.Enabled = false;
                btnBoQua.Visible = false;

                dataDSDanhGia.Enabled = true;

                DanhGiaInfo tg = new DanhGiaInfo();
                tg.MaDanhGia = Convert.ToInt32(txtMa.Text);
                tg.TenDanhGia = txtTen.Text;

                if (Updating)
                    ctrl.Sua(tg);
                else
                    if (Adding)
                        ctrl.Them(tg);

                ctrl.LayDSDanhGia(dataDSDanhGia);

                txtMa.Enabled = false;
                txtTen.Enabled = false;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            btnCapNhat.Enabled = false;
            btnBoQua.Visible = false;

            dataDSDanhGia.Enabled = true;

            Adding = Updating = false;

            txtMa.Enabled = false;
            txtTen.Enabled = false;


            if (dataDSDanhGia.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSDanhGia.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSDanhGia.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void frmDanhGia_Load(object sender, EventArgs e)
        {
            ctrl.LayDSDanhGia(dataDSDanhGia);
        }

        private void txtTen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnCapNhat_Click(sender, e);
            }
            else
                if (e.KeyCode.Equals(Keys.Escape))
                {
                    btnBoQua_Click(sender, e);
                }
        }
    }
}