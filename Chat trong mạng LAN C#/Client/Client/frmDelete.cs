using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class frmDelete : Form
    {
        private frmMain frm = null;
        public String Username;
        //
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
        //Hàm khởi tạo mặc định
        public frmDelete()
        {
            InitializeComponent();
        }
        //Khi nhấn phím Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Khi nhấn button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == Username)
            {
                MessageBox.Show("Không thể Delete bản thân vào Friend List", "Thông báo");
            }
            else
            {
                if (txtUser.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên User", "Thông báo");
                }
                else
                {
                    String sendMess = "Friend$" + txtUser.Text + "$Del$";
                    frm.SendMessage(sendMess);
                }
            }            
            txtUser.Clear();
            txtUser.Focus();
        }
        //Khi nhấn phím Enter trong txtUser
        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text == Username)
                {
                    MessageBox.Show("Không thể Delete bản thân vào Friend List");
                }
                else
                {
                    if (txtUser.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhập tên User");
                    }
                    else
                    {
                        String sendMess = "Friend$" + txtUser.Text + "$Del$";
                        frm.SendMessage(sendMess);
                    }
                }
            }
        }
    }
}