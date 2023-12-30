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
    public partial class FormNhanVien : Form
    {
        NhanVienCTRL ct = new NhanVienCTRL();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ct.HienThiNhanVien(TBoxMaNhanVien,TBoxHoTen,TBoxGioiTinh,DateTimePickerNgaySinh,TBoxDiaChi,TBoxDienThoai,TBoxTenLoaiNV,TBoxTenDangNhap,TBoxMatKhau,dataGridView1, bindingNavigator1);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            ct.Update();
        }

        private void ItemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}