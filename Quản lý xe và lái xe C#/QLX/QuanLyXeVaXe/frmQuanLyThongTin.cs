using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmQuanLyThongTin : Form
    {
        public frmQuanLyThongTin()
        {
            InitializeComponent();
        }

        private void cmdQuanLyHopDong_Click(object sender, EventArgs e)
        {
            frmXoaHD f = new frmXoaHD();
            f.TopLevel = false;
            f.Show();
            pnQuanLyThongTin.Controls.Clear();
            pnQuanLyThongTin.Controls.Add(f);
        }

        private void cmdQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien f = new frmQuanLyNhanVien();
            f.TopLevel = false;
            f.Show();
            pnQuanLyThongTin.Controls.Clear();
            pnQuanLyThongTin.Controls.Add(f);
        }

        private void cmdQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang f = new frmQuanLyKhachHang();
            f.TopLevel = false;
            f.Show();
            pnQuanLyThongTin.Controls.Clear();
            pnQuanLyThongTin.Controls.Add(f);
        }

        private void cmdQuanLyXe_Click(object sender, EventArgs e)
        {
            frmQuanLyXe f = new frmQuanLyXe();
            f.TopLevel = false;
            f.Show();
            pnQuanLyThongTin.Controls.Clear();
            pnQuanLyThongTin.Controls.Add(f);
        }

        private void cmdQuanLyLaiXe_Click(object sender, EventArgs e)
        {
            frmQuanLyLaiXe f = new frmQuanLyLaiXe();
            f.TopLevel = false;
            f.Show();
            pnQuanLyThongTin.Controls.Clear();
            pnQuanLyThongTin.Controls.Add(f);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
