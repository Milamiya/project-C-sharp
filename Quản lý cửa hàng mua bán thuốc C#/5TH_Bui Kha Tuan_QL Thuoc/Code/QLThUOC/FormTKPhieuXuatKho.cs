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
    public partial class FormTKPhieuXuatKho : Form
    {
        LapPhieuXuatKhoCTRL ct = new LapPhieuXuatKhoCTRL();
        public FormTKPhieuXuatKho()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemPhieuXuatKho(TBoxTKMaPhieuXK, CBoxTKNgayXK, DateTimePickerTKNgayBD, DateTimePickerTKNgayKT, dataGridView1);
        }
    }
}