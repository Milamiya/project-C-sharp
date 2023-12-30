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
    public partial class FormKho : Form
    {
        KhoCTRL ct = new KhoCTRL();
        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            ct.HienThiKho(TBoxMaKho,TBoxTenKho,TBoxDiaDiem,dataGridView1, bindingNavigator1);
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