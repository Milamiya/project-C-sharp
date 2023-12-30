using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LichCongTac
{
    public partial class frmNoiDungNhacNho : Form
    {
        public frmNoiDungNhacNho()
        {
            InitializeComponent();
        }

        private void frmNoiDungNhacNho_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = frmMain.strNoiDungCongViec;
        }
    }
}