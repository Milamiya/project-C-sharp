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
    public partial class FormPhanCongDiaBan : Form
    {
        PhanCongCTRL ct = new PhanCongCTRL();
        public FormPhanCongDiaBan()
        {
            InitializeComponent();
        }

        private void FormPhanCongDiaBan_Load(object sender, EventArgs e)
        {
            ct.HienThiPhanCong(CBoxMaTDV,CBoxMaDB,CBoxMaThuoc,dataGridView1, bindingNavigator1);
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