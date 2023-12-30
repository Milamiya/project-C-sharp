using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmThanhToanVaTraXe : Form
    {
        public frmThanhToanVaTraXe()
        {
            InitializeComponent();
        }

        private void cmdTraTien_Click(object sender, EventArgs e)
        {
            frmTraTien f = new frmTraTien();
            f.TopLevel = false;
            f.Show();
            pnThanhToan.Controls.Clear();
            pnThanhToan.Controls.Add(f);
        }

        private void cmdTraXe_Click(object sender, EventArgs e)
        {
            frmTraXeThoi f = new frmTraXeThoi();
            f.TopLevel = false;
            f.Show();
            pnThanhToan.Controls.Clear();
            pnThanhToan.Controls.Add(f);
        }
    }
}
