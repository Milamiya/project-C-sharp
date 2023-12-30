using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLThUOC.Controller;
using QLThUOC.DataLayer;


namespace QLThUOC
{
    public partial class FormNhaCungCap : Form
    {
        NhaCungCapCTRL ct = new NhaCungCapCTRL();
        public FormNhaCungCap()
        {
            InitializeComponent();
        }  

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            ct.HienThiNhaCungCap(TBoxMaNCC,TBoxTenNCC,TBoxDiaChiNCC,TBoxDienThoaiNCC,dataGridView1, bindingNavigator1);
        }

        private void ItemThem_Click(object sender, EventArgs e)
        {
            TBoxMaNCC.Text = "";
            TBoxTenNCC.Text = "";
            TBoxDiaChiNCC.Text = "";
            TBoxDienThoaiNCC.Text = "";
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