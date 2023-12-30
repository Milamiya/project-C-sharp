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
    public partial class frmQuocTich : Form
    {
        QuocTichCtrl ctrl = new QuocTichCtrl();
        bool Adding = false;
        bool Updating = false;
        public frmQuocTich()
        {
            InitializeComponent();
        }

        private void frmQuocTich_Load(object sender, EventArgs e)
        {
            ctrl.LayDSQuocTich(dataDSQuocTich);
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

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

                dataDSQuocTich.Enabled = false;

                QuocTichInfo qt = new QuocTichInfo();
                qt.MaQuocTich = Convert.ToInt32(txtMa.Text);
                qt.TenQuocTich = txtTen.Text;

                if (Updating)
                    ctrl.Sua(qt);
                else
                    if (Adding)
                        ctrl.Them(qt);

                ctrl.LayDSQuocTich(dataDSQuocTich);

                txtMa.Enabled = false;
                txtTen.Enabled = false;
            }
        }

       

        private void dataDSQuocTich_Xoa(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xóa không", "Xóa Quốc tịch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                if (MessageBox.Show("Cập nhật vào CSDL không!", "Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes) 
                {
                    ctrl.Update();
                }

            }
            else// Khong chấp nhận xóa
            {
                e.Cancel = true;
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

            dataDSQuocTich.Enabled = false;

            txtTen.Enabled = true;
            txtTen.Focus();
            txtMa.Enabled = false;
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

            dataDSQuocTich.Enabled = false;

            txtMa.Text = ctrl.LayMaMax().ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataDSQuocTich.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn xóa quốc tịch \"" + txtTen.Text + " Chứ?", "Quốc tịch", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IEnumerator ie = (IEnumerator)dataDSQuocTich.SelectedRows.GetEnumerator();
                    if (ie.MoveNext())
                    {
                        DataGridViewRow row = (DataGridViewRow)ie.Current;
                        QLKTX.BusinessObject.QuocTichInfo info = new QLKTX.BusinessObject.QuocTichInfo();
                        info.MaQuocTich = Convert.ToInt32(row.Cells[0].Value.ToString());
                        ctrl.Xoa(info);
                    }
                    ctrl.LayDSQuocTich(dataDSQuocTich);
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            btnCapNhat.Enabled = false;
            btnBoQua.Visible = false;

            dataDSQuocTich.Enabled = true;

            Adding = Updating = false;

            txtMa.Enabled = false;
            txtTen.Enabled = false;

            if (dataDSQuocTich.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSQuocTich.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSQuocTich.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void dataDSQuocTich_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDSQuocTich.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataDSQuocTich.SelectedRows[0];
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