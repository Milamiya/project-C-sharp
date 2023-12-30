using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmHoatDongSinhVien : Form
    {
        public frmHoatDongSinhVien()
        {
            InitializeComponent();
        }

        private void chkTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTatCa.Checked == true)
            {
                dtDanhSach.SelectAll();
            }
            else
            {
                dtDanhSach.ClearSelection();
            }
        }

        private void frmHoatDongSinhVien_Load(object sender, EventArgs e)
        {
            dtDanhSach.Rows.Add(20);
            
        }

        
    }
}