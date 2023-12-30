using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.BusinessObject;
using QLKTX.Controller;
namespace QLKTX
{

    public partial class frmDanToc : Form
    {
        DanTocCtrl ctrl = new DanTocCtrl();
        bool Adding = false;
        bool Updating = false;
        public frmDanToc()
        {
            InitializeComponent();
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            ctrl.LayDSDanToc(dataDSDanToc);
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

            dataDSDanToc.Enabled = false;

            txtMa.Text = ctrl.LayMaMax().ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataDSDanToc.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn xóa quốc tịch \"" + txtTen.Text + " Chứ?", "Quốc tịch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IEnumerator ie = (IEnumerator)dataDSDanToc.SelectedRows.GetEnumerator();
                    if (ie.MoveNext())
                    {
                        DataGridViewRow row = (DataGridViewRow)ie.Current;
                        QLKTX.BusinessObject.DanTocInfo info = new QLKTX.BusinessObject.DanTocInfo();
                        info.MaDanToc = Convert.ToInt32(row.Cells[0].Value.ToString());
                        ctrl.Xoa(info);
                    }
                    ctrl.LayDSDanToc(dataDSDanToc);
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

            dataDSDanToc.Enabled = false;

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

                dataDSDanToc.Enabled = true;

                DanTocInfo dt = new DanTocInfo();
                dt.MaDanToc = Convert.ToInt32(txtMa.Text);
                dt.TenDanToc = txtTen.Text;

                if (Updating)
                    ctrl.Sua(dt);
                else
                    if (Adding)
                        ctrl.Them(dt);

                ctrl.LayDSDanToc(dataDSDanToc);

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

            dataDSDanToc.Enabled = true;

            Adding = Updating = false;

            txtMa.Enabled = false;
            txtTen.Enabled = false;

            if (dataDSDanToc.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSDanToc.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSDanToc.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void dataDSQuocTich_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDSDanToc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataDSDanToc.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
            }
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