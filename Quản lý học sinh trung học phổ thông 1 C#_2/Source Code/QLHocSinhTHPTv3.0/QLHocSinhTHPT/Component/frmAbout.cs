using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;

namespace QLHocSinhTHPT
{
    public partial class frmAbout : Office2007Form
    {
        #region Constructor
        public frmAbout()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.lbl08Email.Links.Add(0, 19, "mailto:hoangtung@inbox.com");
            this.lbl10Website.Links.Add(0, 23, "http://hoangtung.rap.vn");
        }
        #endregion

        #region Click event
        private void lbl08Email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=Hello");
        }

        private void lbl10Website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("http://"))
                Process.Start(strURL);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}