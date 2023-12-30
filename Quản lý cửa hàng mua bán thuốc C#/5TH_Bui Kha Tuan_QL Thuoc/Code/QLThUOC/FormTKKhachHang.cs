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
    public partial class FormTKKhachHang : Form
    {
        KhachHangCTRL ct = new KhachHangCTRL();
        public FormTKKhachHang()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemKH(TBoxTKMaKH, CBoxTKChonHoTen, TBoxTKHoTenKH, CBoxTKChonDiaChi, TBoxTKDiaChiKH, dataGridView1);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            ct.Update();
        }

    }
}