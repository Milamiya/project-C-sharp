using System;
using System.Collections.Generic;
using QuanLyDaoTao.Utilities;
using DevExpress.XtraEditors;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThongTinNguoiDung : XtraForm
    {
        public frmThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                lblQuyen.Text = StaticClass.User.MoTaQuyen + ":";
                lblTen.Text = StaticClass.User.TenNguoiDung;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }
    }
}