using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLTuyenDungPresentation
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }
     
        private void DANGNHAP_Load(object sender, EventArgs e)
        {
            this.lblThoiGian.Text = DateTime.Now.ToString();
            txtTenDangNhap.Focus();
        }
        TaiKhoan_DTO k = new TaiKhoan_DTO();
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            k.UID = txtTenDangNhap.Text;
            k.UPSS = txtMatKhau.Text;
            if (TaiKhoan_BLL.KiemTra1TaiKhoan(k) > 0)
            {
                this.DialogResult = DialogResult.OK;
                frmMain.k.UID = txtTenDangNhap.Text;
            }
            else
            {
                MessageBox.Show("Not Found!", "OK");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }
    }
}
