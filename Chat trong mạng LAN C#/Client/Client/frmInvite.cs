using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class frmInvite : Form
    {
        private frmMain frm = null;
        public String Username;
        //Property Frm
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
        //
        public frmInvite()
        {
        	InitializeComponent();
        }
        private void FrmInviteLoad(object sender, EventArgs e)
        {
        	GetUser();
        }
        //Lấy dữ liệu từ lbFriendList của frm vào lbFriend
        private void GetUser()
        {
            if (frm.lbFriendList.Items.Count != 0)
            {
                for (int i = 0; i < frm.lbFriendList.Items.Count; i++)
                {
                    String s = frm.lbFriendList.Items[i].ToString();
                    lbFriend.Items.Add(s);
                }
            }
        }
        //Nhấn nút Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Nhấn nút Invite
        private void btnInviteClick(object sender, EventArgs e)
        {
        	if (lbInvite.Items.Count == 0)
        	{
        		MessageBox.Show("Không thể để Invite List rỗng","Thông báo");
        		return;
        	}
        	String s;
        	String strMess = tbInviteMessage.Text.Trim();
        	if (strMess == "")
        	{
        		strMess = "Join with me!";
        	}
        	s = "Group$Invite$";
        	for (int i = 0; i < lbInvite.Items.Count; i++)
        	{
        		s += lbInvite.Items[i].ToString() + "-";
        	}
        	s += "$" + strMess;
        	frm.group++;
        	String groupName = Username + "Group"+ frm.group.ToString();
        	s += "$" + groupName;
        	frm.SendMessage(s);
        	frm.AddGroupChat(groupName);
        	Close();
        }
        //Nhấn nút Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbFriend.SelectedItems.Count != 0)
            {
                for (int i = 0; i < lbFriend.SelectedItems.Count; i++ )
                {
                    String s = lbFriend.SelectedItems[i].ToString();
                    AddUser(s);                   
                }
            }
        }
        //Kiểm tra xem 1 User đã được Add vào lbInvite hay chưa
        private bool CheckItems(string s)
        {
            if (lbInvite.Items.Count != 0)
            {
                for (int i = 0; i < lbInvite.Items.Count; i++ )
                {
                    if (lbInvite.Items[i].ToString() == s)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //Nhấn nút Remove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (lbInvite.SelectedItems.Count != 0)
            {
                string s = lbInvite.SelectedItems[0].ToString();
                lbInvite.Items.Remove(s);
            }
        }
        //Hàm thêm 1 User vào lbInvite
        public void AddUser(string s)
        {
            if (CheckItems(s) && s != Username)
            {
                lbInvite.Items.Add(s);
            }
        }
        //Nhấn nút Invite Another (cho hiện form InviteAnother)
        private void btnInviteAnother_Click(object sender, EventArgs e)
        {
            frmInviteAnother f = new frmInviteAnother();
            f.Frm = this;
            f.Show();
        }
    }
}