using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void cmdTimKiemXePN_Click(object sender, EventArgs e)
        {
            frmTimKiemXe f = new frmTimKiemXe();
            f.TopLevel = false;
            f.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(f);
        }

        private void cmdTimKiemLaiXePN_Click(object sender, EventArgs e)
        {
            frmLaiXe f = new frmLaiXe();
            f.TopLevel = false;
            f.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(f);
        }
              
       
        private void cmdTimKiemNhanVienPN_Click_1(object sender, EventArgs e)
        {
            frmTimKiemNhanVien f = new frmTimKiemNhanVien();
            f.TopLevel = false;
            f.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(f);
        }

        private void cmdTimKiemKhachHangPN_Click(object sender, EventArgs e)
        {
            frmTimKiemKH f = new frmTimKiemKH();
            f.TopLevel = false;
            f.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTimKiemHopDong f = new frmTimKiemHopDong();
            f.TopLevel = false;
            f.Show();
            pnTimKiem.Controls.Clear();
            pnTimKiem.Controls.Add(f);
        }

        
    }
}
