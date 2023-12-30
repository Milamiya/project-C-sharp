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
    public partial class FormThuoc : Form
    {
        ThuocCTRL ct = new ThuocCTRL();
        public FormThuoc()
        {
            InitializeComponent();
        }

        private void FormThuoc_Load(object sender, EventArgs e)
        {
            ct.HienThiThuoc(TBoxMaThuoc,TBoxTenThuoc,CBoxMaDVT,TBoxSoLuong,TBoxDonGiaMua,TBoxDonGiaBan,CBoxMaLoaiThuoc,dataGridView1, bindingNavigator1);
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