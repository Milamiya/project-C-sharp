using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX.Dialog
{
    public partial class DiaLog_ThemKyLuat : Form
    {
        QLKTX.Controller.KyLuatCtrl ctl = new QLKTX.Controller.KyLuatCtrl();
        public DiaLog_ThemKyLuat()
        {
            InitializeComponent();
        }
        public string TenTG
        {
            get
            {
                return txtTen.Text;
            }
        }
        private void DiaLog_ThemKyLuat_Load(object sender, EventArgs e)
        {
            txtMa.Text = ctl.LayMaMax().ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                QLKTX.BusinessObject.KyLuatInfo tg = new QLKTX.BusinessObject.KyLuatInfo();
                tg.MaKyLuat = Convert.ToInt32(txtMa.Text);
                tg.TenKyLuat= txtTen.Text.ToString();
                ctl.Them(tg);

                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Chưa nhập Tên!","Kỹ Luật",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}