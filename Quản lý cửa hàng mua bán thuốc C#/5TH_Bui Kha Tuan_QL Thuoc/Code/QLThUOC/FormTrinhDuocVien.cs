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
    public partial class FormTrinhDuocVien : Form
    {
        TrinhDuocVienCTRL ct = new TrinhDuocVienCTRL();
        public FormTrinhDuocVien()
        {
            InitializeComponent();
        }

        private void FormTrinhDuocVien_Load(object sender, EventArgs e)
        {
            ct.HienThiTDVien(TBoxMaTDV,TBoxHoTenTDV,TBoxDiaChiTDV,TBoxGioTinhTDV,TBoxDienThoai,dataGridView1, bindingNavigator1);
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