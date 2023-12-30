using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using QLThUOC.Controller;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormTKNhanVien : Form
    {
        NhanVienCTRL ct = new NhanVienCTRL();
        public FormTKNhanVien()
        {
            InitializeComponent();
        }

        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            ct.TimKiemNV(TBoxTKMaNV, CBoxChonHoTen, TBoxTKHoTenNV, CBoxChonNgaySinh, DateTimePickerTKNgaySinh, CBoxChonDiaChi, TBoxTKDiaChi, CBoxChonTenLoaiNV, TBoxTKTenLoaiNV, dataGridView1);
        }
    }
}