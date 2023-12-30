using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Chess_Programming
{
    public partial class frmFeedBack : DevComponents.DotNetBar.Office2007Form
    {
        public frmFeedBack()
        {
            InitializeComponent();
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtContent.Text == "")
            {
                MessageBox.Show("Bạn Chưa Điền Đủ Thông Tin");
                return;
            }
            if(clsSendMail .SendMail (txtTitle .Text ,txtContent .Text ,ratingStar1 .Rating .ToString ())== true )
            {
                MessageBox.Show("Ý Kiến Của Bạn Đã Được Gửi!");
                this.Close ();
            }
            else
            {
                MessageBox.Show("Gửi Thất Bại!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}