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
    public partial class frmQuanLy_Admin : Form
    {
        public frmQuanLy_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCapNhat CN = new frmCapNhat();
            CN.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien qlsv = new frmQuanLySinhVien();
            qlsv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLichsuthi ls = new frmLichsuthi();
            ls.ShowDialog();
        }

    }
}
