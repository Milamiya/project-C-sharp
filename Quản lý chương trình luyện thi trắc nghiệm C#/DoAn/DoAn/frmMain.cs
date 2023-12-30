using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tship.Text = "Ngày "+DateTime.Now.Day.ToString() + " Tháng " + DateTime.Now.Month.ToString() + " Năm " + DateTime.Now.Year.ToString();
            tship2.Text = tship2.Text.Substring(tship2.Text.Length - 1, 1) + tship2.Text.Substring(0, tship2.Text.Length - 1);
        
            //frmLogin fLog = new frmLogin();
            //fLog.MdiParent = this;
            //fLog.Show();
            //this.WindowState = FormWindowState.Normal;
        }
        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xemĐápÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReg fReg = new frmReg();
            fReg.MdiParent = this;
            fReg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)

            {
                Application.Exit();
                
            }
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();

            }
        }

        private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin Log = new frmLogin();
            Log.ShowDialog();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReg reg = new frmReg();
            reg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLuaChon Luachon = new frmLuaChon();
            Luachon.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin Log = new frmLogin();
            Log.ShowDialog();
        }

        private void lịchSửThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichsuthi lichsuthi = new frmLichsuthi();
            lichsuthi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDienTenTS DIENTEN = new frmDienTenTS();
            DIENTEN.ShowDialog();
        }

        private void ônThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLuaChon chon = new frmLuaChon();
            chon.ShowDialog();
        }

        private void thiThậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDienTenTS dienten = new frmDienTenTS();
            dienten.ShowDialog();
        }

        private void thoátToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();

            }
        }

        private void lịchSữThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin logg = new frmLogin();
            logg.ShowDialog();
        }

        private void quảnLýCâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin logg = new frmLogin();
            logg.ShowDialog();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin logg = new frmLogin();
            logg.ShowDialog();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNhom thongtin = new frmThongTinNhom();
            thongtin.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmhuongdan huongdan = new Frmhuongdan();
            huongdan.ShowDialog();
        }

        private void giớiThiệuChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgioithieu gioithieu= new frmgioithieu();
            gioithieu.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login1 = new frmLogin();
            login1.ShowDialog();
        }

    }
}
