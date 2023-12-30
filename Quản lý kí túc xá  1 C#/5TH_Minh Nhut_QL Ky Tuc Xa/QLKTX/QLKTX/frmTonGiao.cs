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
    public partial class frmTonGiao : Form
    {
        bool Adding = false;
        bool Updating = false;
        TonGiaoCtrl ctrl = new TonGiaoCtrl();
        public frmTonGiao()
        {
            InitializeComponent();
        }

        private void dataDSTonGiao_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDSTonGiao.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataDSTonGiao.SelectedRows[0];
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

            dataDSTonGiao.Enabled = false;

            txtMa.Text = ctrl.LayMaMax().ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataDSTonGiao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn xóa quốc tịch \"" + txtTen.Text + " Chứ?", "Quốc tịch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IEnumerator ie = (IEnumerator)dataDSTonGiao.SelectedRows.GetEnumerator();
                    if (ie.MoveNext())
                    {
                        DataGridViewRow row = (DataGridViewRow)ie.Current;
                        QLKTX.BusinessObject.TonGiaoInfo info = new QLKTX.BusinessObject.TonGiaoInfo();
                        info.MaTonGiao = Convert.ToInt32(row.Cells[0].Value.ToString());
                        ctrl.Xoa(info);
                    }
                    ctrl.LayDSTonGiao(dataDSTonGiao);
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

            dataDSTonGiao.Enabled = false;

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

                dataDSTonGiao.Enabled = true;

                TonGiaoInfo tg = new TonGiaoInfo();
                tg.MaTonGiao = Convert.ToInt32(txtMa.Text);
                tg.TenTonGiao = txtTen.Text;

                if (Updating)
                    ctrl.Sua(tg);
                else
                    if (Adding)
                        ctrl.Them(tg);

                ctrl.LayDSTonGiao(dataDSTonGiao);

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

            dataDSTonGiao.Enabled = true;

            Adding = Updating = false;

            txtMa.Enabled = false;
            txtTen.Enabled = false;


            if (dataDSTonGiao.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSTonGiao.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSTonGiao.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            ctrl.LayDSTonGiao(dataDSTonGiao);
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