using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class frmInviteAnother : Form
    {
        private frmInvite frm = null;
        //Property Frm
        public frmInvite Frm
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
        //
        public frmInviteAnother()
        {
            InitializeComponent();
        }
        //Nhấn nút Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Nhấn nút Invite
        private void btnInvite_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim() != "")
            {
                frm.AddUser(tbUsername.Text);
            }
            tbUsername.Clear();
            tbUsername.Focus();
        }
        //Khi nhấn Enter trong tbUsername thì Add User
        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbUsername.Text.Trim() != "")
                {
                    frm.AddUser(tbUsername.Text);
                }
                tbUsername.Clear();
                tbUsername.Focus();
            }
        }
    }
}