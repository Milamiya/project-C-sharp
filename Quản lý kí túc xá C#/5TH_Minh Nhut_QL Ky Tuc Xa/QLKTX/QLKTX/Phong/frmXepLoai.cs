using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
namespace QLKTX.Phong
{
    public partial class frmXepLoai : Form
    {
        bool Adding = false;
        bool Updating = false;
        XepLoaiCtrl ctrl = new XepLoaiCtrl();
        public frmXepLoai()
        {
            InitializeComponent();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void frmXepLoai_Load(object sender, EventArgs e)
        {
            ctrl.LayDSXepLoai(dataDSXepLoai);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Adding = true;
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtDiemCanTren.Enabled = true;
            txtDiemCanDuoi.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Visible = true;

            txtTen.Focus();

            txtTen.Text = "";
            txtDiemCanTren.Text = "";
            txtDiemCanDuoi.Text = "";
            txtMa.Text = ctrl.LayMaMax().ToString();

            dataDSXepLoai.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataDSXepLoai.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSXepLoai.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSXepLoai.SelectedRows[0].Cells[1].Value.ToString();
                txtDiemCanTren.Text = dataDSXepLoai.SelectedRows[0].Cells[2].Value.ToString();
                txtDiemCanDuoi.Text = dataDSXepLoai.SelectedRows[0].Cells[3].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa cán bộ: \"" + txtTen.Text + "\" Không?", "Cán bộ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QLKTX.BusinessObject.XepLoaiInfo info = new QLKTX.BusinessObject.XepLoaiInfo();
                    info.MaXepLoai = Convert.ToInt32(txtMa.Text);
                    info.TenXepLoai = txtTen.Text;
                    info.DiemCanTren = Convert.ToInt32(txtDiemCanTren.Text);
                    info.DiemCanDuoi = Convert.ToInt32(txtDiemCanDuoi.Text);
                    ctrl.Xoa(info);
                    ctrl.LayDSXepLoai(dataDSXepLoai);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Updating = true;

            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtDiemCanTren.Enabled = true;
            txtDiemCanDuoi.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Visible = true;

            txtTen.Focus();

            dataDSXepLoai.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (ctrl.KiemTra(txtMa, txtTen, txtDiemCanTren,txtDiemCanDuoi))
            {
                QLKTX.BusinessObject.XepLoaiInfo xeploai=new QLKTX.BusinessObject.XepLoaiInfo();
                xeploai.MaXepLoai = Convert.ToInt32(txtMa.Text);
                xeploai.TenXepLoai = txtTen.Text;
                xeploai.DiemCanTren =Convert.ToDecimal(txtDiemCanTren.Text);
                xeploai.DiemCanDuoi = Convert.ToDecimal(txtDiemCanDuoi.Text);


                if (Adding)
                {
                    ctrl.Them(xeploai);
                }
                else
                {
                    if (Updating)
                        ctrl.Sua(xeploai);
                }
                ctrl.LayDSXepLoai(dataDSXepLoai);

                Updating = Adding = false;
                txtMa.Enabled = false;
                txtTen.Enabled = false;
                txtDiemCanTren.Enabled = false;
                txtDiemCanDuoi.Enabled = false;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnBoQua.Visible = false;

                dataDSXepLoai.Enabled = true;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Updating = Adding = false;

            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDiemCanTren.Enabled = false;
            txtDiemCanDuoi.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Visible = false;

            dataDSXepLoai.Enabled = true;
            if (dataDSXepLoai.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSXepLoai.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSXepLoai.SelectedRows[0].Cells[1].Value.ToString();
                txtDiemCanTren.Text = dataDSXepLoai.SelectedRows[0].Cells[2].Value.ToString();
                txtDiemCanDuoi.Text = dataDSXepLoai.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void dataDSXepLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dataDSXepLoai.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSXepLoai.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSXepLoai.SelectedRows[0].Cells[1].Value.ToString();
                txtDiemCanTren.Text = dataDSXepLoai.SelectedRows[0].Cells[2].Value.ToString();
                txtDiemCanDuoi.Text = dataDSXepLoai.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void txtDiemCanDuoi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnLuu_Click(sender, e);
            }
            else
                if (e.KeyCode.Equals(Keys.Escape))
                {
                    btnBoQua_Click(sender, e);
                }
        }

        
    }
}

