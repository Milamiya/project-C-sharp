using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLThUOC.Controller;

namespace QLThUOC
{
    public partial class FormTKThuoc : Form
    {
        ThuocCTRL ct = new ThuocCTRL();
        public FormTKThuoc()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemThuoc(TBoxTKMaThuoc, CBoxChonTenThuoc, TBoxTKTenThuoc, dataGridView1);
        }
    }
}