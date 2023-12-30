using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.BusinessObject;

using QLKTX.Controller;
namespace QLKTX.KTX
{
    public partial class frmKTX : Form
    {
        KTXCtrl ctrl = new KTXCtrl();
        bool Updating = false;
        bool Adding = false;
        public KTXInfo ktxInfo = new KTXInfo();
        public frmKTX()
        {
            InitializeComponent();
        }

        private void frmKTX_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(dataKyTucXa, binKyTucXa, txtMa, txtTen, txtSoDay);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ctrl.KiemTra(txtMa, txtTen, txtSoDay))
            {
                dataKyTucXa.Enabled = true;

                txtTen.Enabled = false;
                txtMa.Enabled = false;
                txtSoDay.Enabled = false;
                btnCapNhat.Enabled = false;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnBoQua.Visible = false;

                
                ktxInfo.MaKTX = txtMa.Text;
                ktxInfo.TenKTX = txtTen.Text;
                ktxInfo.SoDay = Convert.ToInt32(txtSoDay.Text);
                if (Updating)
                    ctrl.Sua(ktxInfo);
                else
                    if (Adding)
                        ctrl.Them(ktxInfo);
                Updating = Adding = false;
                ctrl.HienThi(dataKyTucXa, binKyTucXa, txtMa, txtTen, txtSoDay);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Adding = true;
            Updating = false;
            dataKyTucXa.Enabled = false;

            txtTen.Enabled = true;
            txtTen.Clear();
            txtMa.Enabled = true;
            txtMa.Clear();
            txtSoDay.Enabled = true;
            txtSoDay.Clear();
            btnCapNhat.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;


            btnBoQua.Visible = true;            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Xóa KTX", "KTX", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KTXInfo ktx = new KTXInfo();
                ktx.MaKTX = txtMa.Text;
                ktx.TenKTX = txtTen.Text;
                ctrl.Xoa(ktx);

                ctrl.HienThi(dataKyTucXa, binKyTucXa, txtMa, txtTen,txtSoDay);                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataKyTucXa.SelectedRows.Count > 0)
            {
                Updating = true;
                Adding = false;
                dataKyTucXa.Enabled = false;

                txtTen.Enabled = true;
                txtMa.Enabled = false;
                txtSoDay.Enabled = true;
                btnCapNhat.Enabled = true;

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;

                ktxInfo.MaKTX = txtMa.Text;
                ktxInfo.TenKTX = txtTen.Text;
                ktxInfo.SoDay = Convert.ToInt32(txtSoDay.Text);
                btnBoQua.Visible = true;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            dataKyTucXa.Enabled = true;
            Adding = Updating = false;

            txtTen.Enabled = false;
            txtMa.Enabled = false;
            txtSoDay.Enabled = false;
            btnCapNhat.Enabled = false;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;

            btnBoQua.Visible = false;

            //Lay Du lieu lai cho TextBox

            txtMa.Text = ktxInfo.MaKTX;
            txtTen.Text = ktxInfo.TenKTX;
            txtSoDay.Text = ktxInfo.SoDay.ToString();
            
            
        }

    }
}
