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
    public partial class FormTKLoThuoc : Form
    {
        LoThuocCTRL ct = new LoThuocCTRL();
        public FormTKLoThuoc()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemLoThuoc(TBoxTKMaLo, CBoxChonTenLo, TBoxTKTenLo, CBoxChonMaThuoc, TBoxTKMaThuoc, dataGridView1);
        }
    }
}