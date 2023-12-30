using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.Controller;

namespace GiaoDienCuaHang
{
    public partial class frmTimKiemHangHoa : Form
    {
        HangHoaController ctrl = new HangHoaController();
        public frmTimKiemHangHoa()
        {
            InitializeComponent();
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            ctrl.TimKiemHH(txttenhanghoa, cmbBoxChonmaDVT, comboBoxMaDVt, cmbBoxChonsoluong, txtsoluong, comboBoxchonslgiam, txtSLG, comboBoxchonTLG, txtTLgiam, dataGridView1);
            
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            this.txttenhanghoa.Clear();
            this.txttenhanghoa.Focus();
            this.txtsoluong.Clear();
            this.txtSLG.Clear();
            this.txtTLgiam.Clear();
            
        }

        private void frmTimKiemHangHoa_Load(object sender, EventArgs e)
        {
            this.cmbBoxChonmaDVT.Text = "NONE";
            this.cmbBoxChonsoluong.Text = "NONE";
            this.comboBoxchonslgiam.Text = "NONE";
            this.comboBoxchonTLG.Text = "NONE";
        }

       

        
       

        

       
        
        
       
       

        

        

        

        

       

        

        

        

        

        

        

        

        
        

        

        

       

       

        

       
       
    }
}