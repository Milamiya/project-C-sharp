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
    public partial class FormTKPhieuThanhLi : Form
    {
        LapPhieuThanhLiCTRL ct = new LapPhieuThanhLiCTRL();
        public FormTKPhieuThanhLi()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemPhieuThanhLi(TBoxTKMaPhieuTL, CBoxTKNgayThanh, DateTimePickerTKNgayBD, DateTimePickerTKNgayKT, dataGridView1);
        }
    }
}