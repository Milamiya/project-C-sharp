using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.Controller;
using QUANLYHOSONHANVIEN.DataLayer;

using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmTaoNguoiDungMoi : DevComponents .DotNetBar .Office2007Form 
    {
        public frmTaoNguoiDungMoi()
        {
            InitializeComponent();
        }
        LoainguoidungCtr ctr_loainguoidung = new LoainguoidungCtr();
        NguoiDungData data = new NguoiDungData();
        private void frmTaoNguoiDungMoi_Load(object sender, EventArgs e)
        {
            ctr_loainguoidung.HienThiAutoCombobox(cmbLoaitk);
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemNguoiDung(txtUsername.Text, txtPass1.Text, cmbLoaitk.SelectedValue.ToString());
                MessageBox.Show("Thành Công");
                this.Close();
            }
        }

        private bool kiemtra()
        {
            if (txtUsername.Text == "")
            {
                txtUsername.BackColor = Color.Yellow;
                txtUsername.Focus();
                return false;
            }
            if (txtPass1.Text == "")
            {
                txtPass1.BackColor = Color.Yellow;
                txtPass1.Focus();
                return false;
            }
            if (txtpass2.Text == "")
            {
                txtpass2.BackColor = Color.Yellow;
                txtpass2.Focus();
                return false;
            }
            if (cmbLoaitk.Text == "")
            {
                cmbLoaitk.Focus();
                return false;
            }
            if (txtPass1.Text != txtpass2.Text)
            {
                txtpass2.BackColor = Color.Yellow;
                pictureBox1.Visible = true;
                return false;
            }
            else
            {
                pictureBox1.Visible = false;
                return true ;
            }
            return true;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            txtPass1.BackColor = Color.White;
            txtpass2.BackColor = Color.White;
        }

        private void txtpass2_Leave(object sender, EventArgs e)
        {
            kiemtra();
        }
    }
}
