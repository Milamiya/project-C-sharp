using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmDiemDanhSinhVien : Form
    {
        public frmDiemDanhSinhVien()
        {
            InitializeComponent();
        }

        private void frmDiemDanhSinhVien_Load(object sender, EventArgs e)
        {
        
            dtDanhSach.Rows.Add(8);
        }
    }
}