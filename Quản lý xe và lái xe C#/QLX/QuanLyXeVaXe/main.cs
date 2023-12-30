using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class main : Form
    {
        public int quyen;
        public main(int quyen)
        {
           
            InitializeComponent();
            this.quyen = quyen;
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }
        public void KtrQuyen()
        {
            if (quyen == 1)
            {
                this.button2.Enabled = true;
            }
            if(quyen == 2)
            {
                this.button2.Enabled = true;
            }
            if(quyen == 3)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuanLyThongTin f = new frmQuanLyThongTin();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLapHopDong f = new frmLapHopDong();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.TopLevel = false;
            f.Show();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(f);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {
            KtrQuyen();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmTraXeThoi f = new frmTraXeThoi();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //de to cho vao day mo form luon
            frmTraTien f = new frmTraTien();
            f.Show();
        }
    }
}
