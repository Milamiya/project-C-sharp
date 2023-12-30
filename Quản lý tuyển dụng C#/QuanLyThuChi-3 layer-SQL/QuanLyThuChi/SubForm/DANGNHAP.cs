using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyThuChi.SubForm
{
    public partial class DANGNHAP : Form
    {
        private void DANGNHAP_Load(object sender, EventArgs e)
        {
            this.lblThoiGian.Text = DateTime.Now.ToString();
            txtTenDangNhap.Focus();
        }
        public DANGNHAP()
        {
            InitializeComponent();
        }
        TaiKhoan_DTO k = new TaiKhoan_DTO();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            k.UID = txtTenDangNhap.Text;
            k.UPSS = txtMatKhau.Text;
            if (TaiKhoan_BUS.KiemTra1TaiKhoan(k) > 0)
            {
                this.DialogResult = DialogResult.OK;
                MAINF.k.UID = txtTenDangNhap.Text;
            }
            else
            {
                MessageBox.Show("Not Found!", "OK");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
