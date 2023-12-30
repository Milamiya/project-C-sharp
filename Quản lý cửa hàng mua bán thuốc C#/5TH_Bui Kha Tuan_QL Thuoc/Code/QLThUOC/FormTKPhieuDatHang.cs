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
    public partial class FormTKPhieuDatHang : Form
    {
        LapPhieuDatHangCTRL ct = new LapPhieuDatHangCTRL();
        public FormTKPhieuDatHang()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemPhieuDatHang(TBoxTKMaPhieuDH, CBoxTKNgayLap, DateTimePickerTKNgayBD, DateTimePickerTKNgayKT, dataGridView1);
        }
    }
}