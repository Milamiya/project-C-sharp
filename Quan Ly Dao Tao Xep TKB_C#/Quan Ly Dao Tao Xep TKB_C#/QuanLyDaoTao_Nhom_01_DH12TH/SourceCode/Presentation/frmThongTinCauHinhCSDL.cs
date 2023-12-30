using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using Settings = QuanLyDaoTao.Properties.Settings;
using System.Drawing;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThongTinCauHinhCSDL : XtraForm
    {
        public frmThongTinCauHinhCSDL()
        {
            InitializeComponent();
        }

        private void frmThongTinCauHinhCSDL_Load(object sender, EventArgs e)
        {
            try
            {
                txtMayChu.Text = Settings.Default.Server;
                txtCSDL.Text = Settings.Default.DatabaseName;
                if (Settings.Default.SQLAuthenticationMode)
                {
                    radioGroup1.SelectedIndex = 1;
                    txtTaiKhoan.Text = Settings.Default.UserName;
                    if (Settings.Default.SavePassword)
                    {
                        ckbNhoMatKhau.Checked = true;
                        txtMatKhau.Text = "matkhaudangnhapsqlserver";
                    }
                }
                else
                {
                    radioGroup1.SelectedIndex = 0;
                    txtTaiKhoan.BackColor = Color.FromArgb(235, 236, 239);
                    txtMatKhau.BackColor = Color.FromArgb(235, 236, 239);
                    ckbNhoMatKhau.BackColor = Color.FromArgb(235, 236, 239); ;
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}