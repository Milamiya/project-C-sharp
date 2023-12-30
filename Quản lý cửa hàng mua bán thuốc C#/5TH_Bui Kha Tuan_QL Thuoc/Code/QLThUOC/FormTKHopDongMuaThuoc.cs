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
    public partial class FormTKHopDongMuaThuoc : Form
    {
        LapHopDongMuaThuocCTRL ct = new LapHopDongMuaThuocCTRL();
        public FormTKHopDongMuaThuoc()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemHopDong(TBoxTKMaPhieuHDMT, CBoxTKNgayLap, DateTimePickerTKNgayBD, DateTimePickerTKNgayKT, dataGridView1);
        }
    }
}