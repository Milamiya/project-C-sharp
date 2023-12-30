using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmKhoiDong : XtraForm
    {
        int dotCount = 0;
        int thoiGian = 0;
        public frmKhoiDong()
        {
            InitializeComponent();
            labelControl1.Text = string.Format("{0}{1}", labelControl1.Text, GetYearString());
            Timer tmr = new Timer();
            tmr.Interval = 400;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }

        void tmr_Tick(object sender, EventArgs e) 
        {
            if(++dotCount > 3) dotCount = 0;
            labelControl2.Text = string.Format("{1}{0}", GetDots(dotCount), "Đang khởi động");
            thoiGian += 400;
            if (thoiGian >= 7000)
            {
                this.Close();
                ((Timer)sender).Enabled = false;
            }
        }

        string GetDots(int count) 
        {
            string ret = string.Empty;
            for(int i = 0; i < count; i++) ret += ".";
            return ret;
        }
        int GetYearString() {
            int ret = DateTime.Now.Year;
            return (ret < 2012 ? 2012 : ret);
        }
    }
}