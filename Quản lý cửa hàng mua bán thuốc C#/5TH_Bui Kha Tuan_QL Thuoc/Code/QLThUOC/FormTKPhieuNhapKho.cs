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
    public partial class FormTKPhieuNhapKho : Form
    {
        LapPhieuNhapKhoCTRL ct = new LapPhieuNhapKhoCTRL();
        public FormTKPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemPhieuNhapKho(TBoxTKMaPhieuNK, CBoxTKNgayNK, DateTimePickerTKNgayBD, DateTimePickerTKNgayKT, dataGridView1);
        }
    }
}