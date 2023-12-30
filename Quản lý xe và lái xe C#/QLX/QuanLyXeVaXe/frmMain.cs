using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmMain : Form
    {
        public int quyen;
        //public frmMain (int quyen);
        public frmMain(int quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
        }

        private void cmdQuanLyThongTin_Click(object sender, EventArgs e)
        {
            frmQuanLyHopDong f = new frmQuanLyHopDong();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }
        public void KtrQuyen()
        {
            if (quyen == 1)
            {
                button1.Enabled = true;
                cmdQuanLyThongTin.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                
            }
            if (quyen == 2)
            {
                button1.Enabled = true;
                cmdQuanLyThongTin.Enabled = true;
                button4.Enabled = true;
            }
            if (quyen == 3)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuanLyThongTin f = new frmQuanLyThongTin();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmThanhToanVaTraXe f = new frmThanhToanVaTraXe();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            KtrQuyen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_re_BaoCao f = new frm_re_BaoCao();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_backupAndRestore f = new frm_backupAndRestore();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }
    }
}
