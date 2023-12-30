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
    public partial class FormDonViTinh : Form
    {
        DonViTinhCTRL ct = new DonViTinhCTRL();
        public FormDonViTinh()
        {
            InitializeComponent();
        }

        private void FormDonViTinh_Load(object sender, EventArgs e)
        {
            ct.HienThiDonViTinh(TBoxMaDVT,TBoxTenDVT,dataGridView1, bindingNavigator1);
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