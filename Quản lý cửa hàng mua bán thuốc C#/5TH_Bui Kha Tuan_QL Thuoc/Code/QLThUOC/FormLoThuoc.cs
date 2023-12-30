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
    public partial class FormLoThuoc : Form
    {
        LoThuocCTRL ct = new LoThuocCTRL();
        public FormLoThuoc()
        {
            InitializeComponent();
        }

        private void FormLoThuoc_Load(object sender, EventArgs e)
        {
            ct.HienThiLoThuoc(TBoxMaLo,TBoxTenLo,DateTimePickerNgaySanXuat,DateTimePickerNgayHetHan,TBoxSoLuong,CBoxMaThuoc,TBoxThanhTien,dataGridView1, bindingNavigator1);
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