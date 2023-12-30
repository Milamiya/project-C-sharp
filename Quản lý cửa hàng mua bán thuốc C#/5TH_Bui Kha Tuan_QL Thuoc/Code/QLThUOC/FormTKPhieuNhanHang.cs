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
    public partial class FormTKPhieuNhanHang : Form
    {
        LapPhieuNhanHangCTRL ct = new LapPhieuNhanHangCTRL();
        public FormTKPhieuNhanHang()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemPhieuNhanHang(TBoxTKMaPhieuNH, CBoxTKNgayGiao, DateTimePickerTKNgayBD, DateTimePickerTKNgayKT, dataGridView1);
        }
    }
}