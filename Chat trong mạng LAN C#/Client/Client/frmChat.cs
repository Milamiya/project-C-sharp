using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class frmChat : Form
    {
        private frmMain frm = null;
        public String Username;
        //Poperty frm
        public frmMain Frm
        {
            get
            {
                return Frm;
            }
            set
            {
                frm = value;
            }
        }
        public frmChat()
        {
            InitializeComponent();
        }
        //Sự kiện nhấn button Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Sự kiện nhấn button Chat
        private void btnChat_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == Username)
            {
                MessageBox.Show("Không thể Chat với chính mình", "Thông báo");
            }
            else
            {
                if (txtUser.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên User", "Thông báo");
                }
                else
                {
                    String sendMess = "Chat$" + Username + "$With$" + txtUser.Text;
                    frm.SendMessage(sendMess);
                    Close();
                }
            }
            txtUser.Clear();
            txtUser.Focus();
        }
        //Sự kiện nhấn Enter trong txtUser
        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text == Username)
                {
                    MessageBox.Show("Không thể Chat với chính mình", "Thông báo");
                }
                else
                {
                    if (txtUser.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập tên User", "Thông báo");
                    }
                    else
                    {
                        String sendMess = "Chat$" + Username + "$With$" + txtUser.Text;
                        frm.SendMessage(sendMess);
                        Close();
                    }
                }
                txtUser.Clear();
                txtUser.Focus();
            }
        }
    }
}