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
namespace QuanLyThuChi.SubForm
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
        }
        TaiKhoan_DTO tk = new TaiKhoan_DTO();
        private void Button6_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                tk.UID = txtid.Text;
                tk.UPSS = txtpss.Text;
                tk.UPSS2 = txtpss2.Text;
                tk.UQUES = ComboBox1.Text;
                tk.UANS = txtans.Text;
                TaiKhoan_BUS.Them1TaiKhoanMoi(tk);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc tài khoản đã tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void xoathongtin()
        {
            txtid.Clear();
            txtpss.Clear();
            txtpss2.Clear();
            txtans.Clear();
        }
        private Boolean check()
        {
            if (txtid.TextLength < 4 || txtpss.TextLength < 4 || txtpss2.TextLength < 4 || txtans.TextLength < 4 || txtid.TextLength > 16 || txtpss.TextLength > 16 || txtpss2.TextLength > 16 || txtans.TextLength > 16)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            xoathongtin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
