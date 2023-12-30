using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX.Dialog
{
    public partial class DiaLog_ThemDanToc : Form
    {
        QLKTX.Controller.DanTocCtrl ctl = new QLKTX.Controller.DanTocCtrl();
        public DiaLog_ThemDanToc()
        {
            InitializeComponent();
        }
        public string TenDT
        {
            get
            {
                return txtTen.Text;
            }
        }
        private void DiaLog_ThemDanToc_Load(object sender, EventArgs e)
        {
            txtMa.Text = ctl.LayMaMax().ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                QLKTX.BusinessObject.DanTocInfo dt = new QLKTX.BusinessObject.DanTocInfo();
                dt.MaDanToc =Convert.ToInt32(txtMa.Text);
                dt.TenDanToc = txtTen.Text.ToString();
                ctl.Them(dt);

                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Chưa nhập Tên!", "Dân Tộc", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
                
    }
}