using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmDanhGiaSinhVien : Form
    {
        public frmDanhGiaSinhVien()
        {
            InitializeComponent();
        }

        private void frmDanhGiaSinhVien_Load(object sender, EventArgs e)
        {
            dtDanhSach.Rows.Add(new Object[] {"Nguyễn Nguyễn Nguyễn Nguyễn","dh5th1","st883"});
            dtDanhSach.Rows.Add(new Object[] {"Nguyễn Nguyễn Nguyễn Nguyễn", "dh6th1", "ssd83" });
            dtDanhSach.Rows.Add(new Object[] {"Nguyễn Nguyễn Nguyễn Nguyễn", "dh7th1", "s2383" });
        }

        private void dtDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtDanhSach.Rows.Count)
            {
                
            }
        }

        
    }
}