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
    public partial class FormKhachHang : Form
    {
        KhachHangCTRL ct = new KhachHangCTRL();
        public FormKhachHang()
        {
            InitializeComponent();
        }  

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            ct.HienThiKhachHang(TBoxMaKH,TBoxHoTenKH,TBoxDiaChi,TBoxDienThoai,CBoxMaLoaiKH,dataGridView1, bindingNavigator1);
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