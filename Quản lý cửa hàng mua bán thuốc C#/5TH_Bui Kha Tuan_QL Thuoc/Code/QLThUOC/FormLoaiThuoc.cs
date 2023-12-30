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
    public partial class FormLoaiThuoc : Form
    {
        LoaiThuocCTRL ct = new LoaiThuocCTRL();
        public FormLoaiThuoc()
        {
            InitializeComponent();
        }

        private void FormLoaiThuoc_Load(object sender, EventArgs e)
        {
            ct.HienThiLoaiThuoc(TBoxMaLoaiThuoc,TBoxTenLoai,TBoxHeSoLuong,dataGridView1, bindingNavigator1);
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