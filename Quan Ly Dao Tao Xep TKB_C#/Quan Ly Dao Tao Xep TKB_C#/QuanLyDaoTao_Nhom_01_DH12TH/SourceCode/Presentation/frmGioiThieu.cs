using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmGioiThieu : XtraForm
    {
        public frmGioiThieu()
        {
            InitializeComponent();
            labelControl1.Text = string.Format("{0}{1}", labelControl1.Text, GetYearString());
        }

        int GetYearString()
        {
            int ret = DateTime.Now.Year;
            return (ret < 2012 ? 2012 : ret);
        }

        private void frmGioiThieu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                this.Close();
        }
    }
}