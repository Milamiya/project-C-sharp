using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Security.Principal;
//using System.DirectoryServices;
using System.Runtime.InteropServices;

namespace ShutdownManager
{
    public partial class frmSetAccount : Form
    {
        public frmSetAccount()
        {
            InitializeComponent();
        }

        public static string strUserName = null;
        public static string strPassWord = null;

        //Kiểm tra xem người dùng OK hay Cancel
        public static bool boolTestAction=false;

        #region Function

        //Kiểm tra PassWord có chính xác không 
        [DllImport("Netapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int NetUserChangePassword(
            string domainname,
            string username,
            string oldpassword,
            string newpassword
            );
        public static bool CheckPassWord(string username, string domain, string oldpassword, string newpassword)
        {
            bool boolCheck = true;
            int result = NetUserChangePassword(
                domain,
                username,
                oldpassword,
                newpassword
                );
            if (result != 0)
            {
                boolCheck = false;
                //throw new Win32Exception();     
            }
            return boolCheck;
        }
        #endregion

        #region Event

        private void frmSetAccount_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Environment.UserName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            strUserName = txtUserName.Text.Trim();
            strPassWord = txtPassWord.Text.Trim();
            if (CheckPassWord(strUserName, Environment.UserDomainName, strPassWord, strPassWord))
            {
                this.Close();
                boolTestAction = true;
            }
            else
            {
                MessageBox.Show("Bạn Hãy Kiểm Tra Lại Thông Tin Về Tài Khoản Của Mình", "Time Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            boolTestAction = false;
        }

        private void frmSetAccount_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(260, 189);
        }
        #endregion
    }
}