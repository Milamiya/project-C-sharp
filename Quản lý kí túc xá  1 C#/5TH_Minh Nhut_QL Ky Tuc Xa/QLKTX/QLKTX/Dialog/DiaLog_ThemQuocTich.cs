using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX.Dialog
{
    public partial class DiaLog_ThemQuocTich : Form
    {
        QLKTX.Controller.QuocTichCtrl ctl = new QLKTX.Controller.QuocTichCtrl();
        public DiaLog_ThemQuocTich()
        {
            InitializeComponent();
        }
        public string TenQT 
        {
            get
            {
                return txtTen.Text;
            }
        }

        private void DiaLog_ThemQuocTich_Load(object sender, EventArgs e)
        {
            

            txtMa.Text = ctl.LayMaMax().ToString();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                QLKTX.BusinessObject.QuocTichInfo qt = new QLKTX.BusinessObject.QuocTichInfo();
                qt.MaQuocTich=Convert.ToInt32(txtMa.Text);
                qt.TenQuocTich=txtTen.Text.ToString();
                ctl.Them(qt);

                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Chưa nhập Tên!", "Quốc Tịch", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
       
    }
}