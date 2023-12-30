using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX.Dialog
{
    public partial class DiaLog_ThemTonGiao : Form
    {
        QLKTX.Controller.TonGiaoCtrl ctl = new QLKTX.Controller.TonGiaoCtrl();
        public DiaLog_ThemTonGiao()
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
        private void DiaLog_ThemTonGiao_Load(object sender, EventArgs e)
        {
            txtMa.Text = ctl.LayMaMax().ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                QLKTX.BusinessObject.TonGiaoInfo tg = new QLKTX.BusinessObject.TonGiaoInfo();
                tg.MaTonGiao = Convert.ToInt32(txtMa.Text);
                tg.TenTonGiao= txtTen.Text.ToString();
                ctl.Them(tg);

                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Chưa nhập Tên!","Tôn Giáo",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}