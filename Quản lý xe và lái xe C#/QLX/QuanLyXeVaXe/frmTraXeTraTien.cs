using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmTraXeTraTien : Form
    {
        public frmTraXeTraTien()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKhongLaiXe.Checked == true)
            {
                frmTraTienKhongLaiXe f = new frmTraTienKhongLaiXe();
                f.TopLevel = false;
                f.Show();
                panel1.Controls.Clear();
                panel1.Controls.Add(f);
            }
        }

        private void rbCoLaiXe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCoLaiXe.Checked == true)
            {
                frmTraTien f = new frmTraTien();
                f.TopLevel = false;
                f.Show();
                panel1.Controls.Clear();
                panel1.Controls.Add(f);
            }
        }
    }
}
