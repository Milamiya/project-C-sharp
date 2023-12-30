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
    public partial class FormTKTrinhDuocVien : Form
    {
        TrinhDuocVienCTRL ct = new TrinhDuocVienCTRL();
        public FormTKTrinhDuocVien()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemTDV(TBoxTKMaTDV, CBoxChonTenTDV, TBoxTKTenTDV, CBoxChonDiaChi, TBoxTKDiaChi, dataGridView1);
        }
    }
}