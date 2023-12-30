using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmDangNhap : Form
    {
        int dem = 0;    
        public frmDangNhap()
        {
            InitializeComponent();
        }        
        private void navigationBar1_Click(object sender, EventArgs e)
        {

        }     


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            txtPass.Text = txtTen.Text = "";
            this.Dispose();
        }

       

        
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            QLKTX.Controller.DangNhapCtrl ctrl = new QLKTX.Controller.DangNhapCtrl();
            if (ctrl.KiemTra(txtTen, txtPass))
            {
                bool ql = ctrl.DangNhap(txtTen, txtPass);
                if (ql)
                {
                    //MessageBox.Show("Bạn đăng nhập thành công!", "Dang nhap");
                    txtPass.Text = txtTen.Text = "";
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    
                    dem++;
                    if (dem >= 3)
                    {
                        MessageBox.Show("Bạn đăng nhập " + dem + " lần không thành công!", "Dang nhap");
                        txtPass.Text = txtTen.Text = "";
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        MessageBox.Show("Bạn đăng nhập không thành công!", "Dang nhap");
                        
                    }
                }
            }
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btnChapNhan_Click(sender, e);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btnChapNhan_Click(sender, e);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = txtTen.Text = "";
        }
             

       
    }
}