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
    public partial class FormTKNhaCungCap : Form
    {
        NhaCungCapCTRL ct = new NhaCungCapCTRL();
        public FormTKNhaCungCap()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemNCC(TBoxTKMaNCC, CBoxChonTenNCC, TBoxTKTenNCC, CBoxChonDiaChi, TBoxTKDiaChi, dataGridView1);
        }
    }
}