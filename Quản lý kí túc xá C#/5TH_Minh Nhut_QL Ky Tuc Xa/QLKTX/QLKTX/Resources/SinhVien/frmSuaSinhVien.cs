using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmSuaSinhVien : Form
    {
        public frmSuaSinhVien()
        {
            InitializeComponent();
        }

        private void chkDoanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoanVien.Checked == true)
            {
                chkDangVien.Checked = false;
                chkDangVien.Enabled = false;
            }
            else
            {
                chkDangVien.Enabled = true;
                chkCamTinhDang.Checked = false;
            }
        }

        private void chkDangVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDangVien.Checked == true)
            {
                chkDoanVien.Checked = false;
                chkCamTinhDang.Checked = false;
                chkDoanVien.Enabled = false;
                chkCamTinhDang.Enabled = false;

            }
            else
            {
                chkDoanVien.Enabled = true;
                chkCamTinhDang.Enabled = true;
            }
        }

        private void chkCamTinhDang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCamTinhDang.Checked == true)
            {
                chkDoanVien.Checked = true;
                chkDangVien.Checked = false;
                chkDangVien.Enabled = false;
            }
            else
            {
                chkDangVien.Enabled = true;
                chkDoanVien.Enabled = true;
            }
        }

       
    }
}