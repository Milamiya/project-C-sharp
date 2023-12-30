using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.InteropServices;

namespace Client
{
    public partial class frmMain : Form
    {
        #region Các biến
        private  static String recieveMess;
        private static String sendMess;
        private const int SizeBuff = 1024;
        private TcpClient khach = new TcpClient();
        private bool exit = false;
        private bool disconnect = false;
        public int group = 0;
        Thread nhan;
        
        #endregion
        #region Các Delegate
        
        //Delegate Form
        private delegate void FormCallback(frmMain f);
        private delegate void GetMultilineListBoxAddItem(MultilineListBox lb, String s, Color color);
        private delegate void GetImageListBoxChangeItem(ImageListBox imglb, String s, bool Online);
        private delegate void GetImageListBoxAddItem(ImageListBox imglb, String s, bool Online);
        private delegate void GetImageListBoxRemoveItem(ImageListBox imglb, String s);
        private delegate void GetListBoxCallback(ListBox lb, String s);
        private delegate void GetTabCallback(TabControl tab, int index, TabPage newPage);
        private delegate void GetTabItemCallback(TabControl tab, String s);
        private delegate void GetGroupTabChat(TabControl tab, String groupName, String name, short action);
        private delegate void GetTabControl(TabControl tab);
        private delegate void GetGroupTabItemCallback(TabControl tab, String groupMess, int index);
        private delegate string GetGroupImageListBox(TabControl tab, int index, String s);

        //Load lại giao diện Chat cho form
        private static void FormChatLoadBack(frmMain f)
        {
            if (f.InvokeRequired)
            {
                FormCallback brao = new FormCallback(FormChatLoadBack);
                f.Invoke(brao, new object[] { f });
                return;
            }
            else
            {
                f.LoadChat();
                f.VisibleLogin(false);
                return;
            }
        }
        //Load lại giao diện Log in cho form
        private static void FormLoginLoadBack(frmMain f)
        {
            if (f.InvokeRequired)
            {
                FormCallback brao = new FormCallback(FormLoginLoadBack);
                f.Invoke(brao, new object[] { f });
                return;
            }
            else
            {
            	f.LoadLogin();
            	f.VisibleChat(false);
              return;
            }
        }

        private static void getImageListBoxAddItem(ImageListBox imglb, String s, bool Online)
        {
            if (imglb.InvokeRequired)
            {
                GetImageListBoxAddItem brao = new GetImageListBoxAddItem(getImageListBoxAddItem);
                imglb.Invoke(brao, new object[] { imglb, s, Online });
                return;
            }
            else
            {
                if (Online)
                {
                    imglb.Items.Add(new ImageListBoxItem(s, 1, Color.Red));
                }
                else
                {
                    imglb.Items.Add(new ImageListBoxItem(s, 0, Color.Blue));
                }
            }
        }

        private static void getImageListBoxChangeItem(ImageListBox imglb, String s, bool Online)
        {
            if (imglb.InvokeRequired)
            {
                GetImageListBoxChangeItem brao = new GetImageListBoxChangeItem(getImageListBoxChangeItem);
                imglb.Invoke(brao, new object[] { imglb, s, Online });
                return;
            }
            else
            {
                int i = SearchImageListBox(imglb, s);
                if (i != -1)
                {
                    if (Online)
                    {
                        imglb.SetImageIndex(i, 1);
                        imglb.SetTextColor(i, Color.Red);
                    }
                    else
                    {
                        imglb.SetImageIndex(i, 0);
                        imglb.SetTextColor(i, Color.Blue);
                    }
                }
                else
                {
                    if (Online)
                    {
                        imglb.Items.Add(new ImageListBoxItem(s, 1, Color.Red));
                    }
                    else
                    {
                        imglb.Items.Add(new ImageListBoxItem(s, 0, Color.Blue));
                    }
                }
            }
        }

        private static void getImageListBoxRemoveItem(ImageListBox imglb, String s)
        {
            if (imglb.InvokeRequired)
            {
                GetImageListBoxRemoveItem brao = new GetImageListBoxRemoveItem(getImageListBoxRemoveItem);
                imglb.Invoke(brao, new object[] { imglb, s});
                return;
            }
            else
            {
                int i = SearchImageListBox(imglb, s);
                if (i != -1)
                {
                    imglb.Items.RemoveAt(i);
                }
            }
        }

        public static int SearchImageListBox(ImageListBox imglb, String s)
        {
            for (int i = 0; i < imglb.Items.Count; i++)
            {
                if (s == ((ImageListBoxItem)imglb.Items[i]).Text)
                {
                    return i;
                }
            }
            return -1;
        }

        private static void getMultilineListBoxAddItem(MultilineListBox lb, String s, Color color)
        {
            if (lb.InvokeRequired)
            {
                GetMultilineListBoxAddItem brao = new GetMultilineListBoxAddItem(getMultilineListBoxAddItem);
                lb.Invoke(brao, new object[] { lb, s, color });
                return;
            }
            else
            {
                lb.Items.Add(new MultilineListBoxItem(s, color));
            }
        }

        private static void getListBoxAddItem(ListBox lb, String s)
        {
            if (lb.InvokeRequired)
            {
                GetListBoxCallback brao = new GetListBoxCallback(getListBoxAddItem);
                lb.Invoke(brao, new object[] { lb, s });
                return;
            }
            else
            {
                lb.Items.Add(s);
            }
        }
        //Remove item ra khỏi ListBox
        private static void getListBoxRemoveItem(ListBox lb, String s)
        {
            if (lb.InvokeRequired)
            {
                GetListBoxCallback brao = new GetListBoxCallback(getListBoxRemoveItem);
                lb.Invoke(brao, new object[] { lb, s });
                return;
            }
            else
            {
                lb.Items.Remove(s);
            }
        }        
        //Thêm 1 Tab Page vào Tab Control
        private static void getTabControlCallback(TabControl tab, int index, TabPage newPage)
        {
            if (tab.InvokeRequired)
            {
                GetTabCallback brao = new GetTabCallback(getTabControlCallback);
                tab.Invoke(brao, new object[] { tab, index, newPage });
                return;
            }
            else
            {
                if (index == -1)
                {
                    tab.Controls.Add(newPage);
                    tab.SelectedIndex = tab.Controls.Count - 1;
                }
                else
                {
                    tab.SelectedIndex = index;
                }
            }
        }
        //Thêm Message vào lbMess
        private static void getTabItemCallback(TabControl tab, String s)
        {
            if (tab.InvokeRequired)
            {
                GetTabItemCallback brao = new GetTabItemCallback(getTabItemCallback);
                tab.Invoke(brao, new object[] { tab, s });
                return;
            }
            else
            {
                ((MultilineListBox)tab.Controls[tab.SelectedIndex].Controls[2]).Items.Add(new MultilineListBoxItem(s,Color.Blue));
            }
        }
        //Thêm Message vào tab Page Offline Message
        private static void getOfflineMessage(TabControl tab, String s)
        {
            if (tab.InvokeRequired)
            {
                GetTabItemCallback brao = new GetTabItemCallback(getOfflineMessage);
                tab.Invoke(brao, new object[] { tab, s });
                return;
            }
            else
            {
                ((MultilineListBox)tab.Controls[tab.SelectedIndex].Controls[0]).Items.Add(new MultilineListBoxItem(s, Color.Blue));
            }
        }
        //Thêm và xóa User ra khỏi các Group Chat
        private static void getGroupTabChat(TabControl tab, String groupName, String name, short action)
        {
            if (tab.InvokeRequired)
            {
                GetGroupTabChat brao = new GetGroupTabChat(getGroupTabChat);
                tab.Invoke(brao, new object[] { tab, groupName, name, action });
                return;
            }
            else
            {
                int index = CheckGroupTab(tab, groupName);
                if (index == -1)
                	return;
                //Thêm item vào lbFriend trong Group Chat
                if (action == 0)
                {
                    ((ImageListBox)tab.Controls[index].Controls[3]).Items.Add(new ImageListBoxItem(name, 1, Color.Red));
                }
                else
                {
                    //Xóa item ra khỏi lbFriend trong Group Chat
                    if (action == 1)
                    {
                        ImageListBox ilb = (ImageListBox)tab.Controls[index].Controls[3];
                        int i = SearchImageListBox(ilb, name);
                        if ( i != -1)
                        {
                        	ilb.Items.RemoveAt(i);
                        }
                    }
                    else
                    {
                        tab.Controls.RemoveAt(index);
                    }

                }
            }
        }

        private static void getGroupTabItemCallback(TabControl tab, String groupMess, int index)
        {
            if (tab.InvokeRequired)
            {
                GetGroupTabItemCallback brao = new GetGroupTabItemCallback(getGroupTabItemCallback);
                tab.Invoke(brao, new object[] { tab, groupMess, index });
                return;
            }
            else
            {
                ((MultilineListBox)tab.Controls[index].Controls[2]).Items.Add(new MultilineListBoxItem(groupMess, Color.Blue));
            }
        }
        
        private static string getGroupImageListBox(TabControl tab, int index, String s)
        {
        	if (tab.InvokeRequired)
        	{
        		GetGroupImageListBox brao = new GetGroupImageListBox(getGroupImageListBox);
        		tab.Invoke(brao, new object[] { tab, index, s });
        		return s;
        	}
        	else
        	{
            		ImageListBox lb = (ImageListBox)tab.Controls[index].Controls[3];
            		for (int i = 0; i < lb.Items.Count; i++)
            		{
            			s += lb.Items[i].ToString() + "-";
            		}
            		return s;
        	}
        }

        #endregion       
        #region Các thành phần xử lý Login

        //Load các thành phần Login
        private void LoadLogin()
        {
            btnSignIn = new Button();
            btnExit = new Button();
            label1 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtIP = new TextBox();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(12, 125);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(97, 36);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += new EventHandler(btnSignIn_Click);
            // 
            // btnExit
            // 
            btnExit.Location = new Point(137, 125);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 36);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += new System.EventHandler(btnExit_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F,
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = Color.Red;
            label1.Location = new Point(9, 54);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(105, 53);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(129, 20);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(105, 79);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(129, 20);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            txtPass.KeyDown += new KeyEventHandler(txtPass_KeyDown);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F,
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = Color.Red;
            label2.Location = new Point(9, 83);
            label2.Name = "label2";
            label2.Size = new Size(68, 16);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F,
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = Color.Red;
            label3.Location = new Point(9, 28);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 2;
            label3.Text = "Server IP";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(105, 27);
            txtIP.Name = "txtIP";
            txtIP.Text = "127.0.0.1";
            txtIP.Size = new Size(129, 20);
            txtIP.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 186);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(txtIP);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnSignIn);
            this.FormClosing += new FormClosingEventHandler(frmMainLogin_FormClosing);
            ResumeLayout(false);
            PerformLayout();
        }
        //Nhấn nút Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
        	Application.Exit();
        }
        //Nhấn button Signin
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            GuiKetNoi();
        }        
        //Gởi yêu cầu đăng nhập lên Server
        public void GuiKetNoi()
        {
            try
            {
                //MessageBox.Show(txtUser.Text);
                khach = new TcpClient();
                khach.Connect(txtIP.Text, 8080);
                StreamWriter guiSW = new StreamWriter(khach.GetStream());
                guiSW.WriteLine("Dangnhap$" + txtUser.Text.TrimEnd() + "$" + txtPass.Text.TrimEnd() + "$");
                guiSW.Flush();
                guiSW = null;
                if (khach.Client.Connected)
                {
                    Thread listener = new Thread(new ThreadStart(Langnghe));
                    listener.Start();
                }
            }
            catch
            {
                MessageBox.Show("Không kết nối được với Server");
            }
        }
        //Sự kiện nhấn phím trong txtPass
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GuiKetNoi();
            }
        }        
        //Hide hoặc Show cac thành phần Login
        private void VisibleLogin(bool b)
        {
            btnSignIn.Visible = b;
            btnExit.Visible = b;
            label1.Visible = b;
            txtUser.Visible = b;
            txtPass.Visible = b;
            label2.Visible = b;
            label3.Visible = b;
            txtIP.Visible = b;
        }
        //Sự kiện form close
        private void frmMainLogin_FormClosing(object sender, EventArgs e)
        {
        	exit = true;
        	if (khach.Connected)
        	{
        		khach.Close();
        	}
        	
        }

        #endregion
        #region Các thành phần xử lý Chat
        //Load các thành phần Chat
        private void LoadChat()
        {
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            miSignOut = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            mainTab = new TabControlEx();
            tpServer = new TabPage();
            tbMess = new TextBox();
            btnSend = new Button();
            lbMess = new MultilineListBox();
            miActions = new ToolStripMenuItem();
            miAdd = new ToolStripMenuItem();
            miDelete = new ToolStripMenuItem();
            miChat = new ToolStripMenuItem();
            miInvite = new ToolStripMenuItem();
            gbFriendList = new GroupBox();
            lbOnline = new ListBox();            
            lbOffline = new ListBox();
            lbFriendList = new ImageListBox();
            mainMenu.SuspendLayout();
            mainTab.SuspendLayout();
            tpServer.SuspendLayout();
            gbFriendList.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, miActions });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(652, 24);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new
                ToolStripItem[] { miSignOut, miExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // miSignOut
            // 
            miSignOut.Name = "miSignOut";
            miSignOut.Size = new Size(152, 22);
            miSignOut.Text = "Sign Out";
            miSignOut.Click += new EventHandler(miSignOut_Click);
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(152, 22);
            miExit.Text = "Exit";
            miExit.Click += new EventHandler(miExit_Click);
            // 
            // mainTab
            // 
            mainTab.Controls.Add(tpServer);
            mainTab.Location = new Point(12, 36);
            mainTab.Name = "mainTab";
            mainTab.SelectedIndex = 0;
            mainTab.Size = new Size(499, 352);
            mainTab.TabIndex = 1;
            // 
            // tpServer
            // 
            tpServer.Controls.Add(tbMess);
            tpServer.Controls.Add(btnSend);
            tpServer.Controls.Add(lbMess);
            tpServer.Location = new Point(4, 22);
            tpServer.Name = "tpServer";
            tpServer.Padding = new Padding(3);
            tpServer.Size = new Size(491, 326);
            tpServer.TabIndex = 0;
            tpServer.Text = "Server";
            tpServer.UseVisualStyleBackColor = true;
            // 
            // tbMess
            // 
            tbMess.Location = new Point(18, 242);
            tbMess.Multiline = true;
            tbMess.Name = "tbMess";
            tbMess.Size = new Size(308, 61);
            tbMess.TabIndex = 0;
            tbMess.KeyDown += new KeyEventHandler(tbMess_KeyDown);
            // 
            // btnSend
            // 
            btnSend.Location = new Point(379, 267);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(91, 36);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += new EventHandler(btnSend_Click);
            // 
            // lbMess
            // 
            lbMess.FormattingEnabled = true;
            lbMess.Location = new Point(18, 18);
            lbMess.Name = "lbMess";
            lbMess.Size = new Size(452, 199);
            lbMess.TabIndex = 2;
            lbMess.DrawMode = DrawMode.OwnerDrawVariable;
            // 
            // actionsToolStripMenuItem
            // 
            miActions.DropDownItems.AddRange(new 
                ToolStripItem[]{ miAdd, miDelete, miChat, miInvite });
            miActions.Name = "actionsToolStripMenuItem";
            miActions.Size = new Size(59, 20);
            miActions.Text = "Actions";
            // 
            // addFriendToolStripMenuItem
            // 
            miAdd.Name = "addFriendToolStripMenuItem";
            miAdd.Size = new Size(152, 22);
            miAdd.Text = "Add Friend";
            miAdd.Click += new EventHandler(miAdd_Click);
            // 
            // deleteFriendToolStripMenuItem
            // 
            miDelete.Name = "deleteFriendToolStripMenuItem";
            miDelete.Size = new Size(152, 22);
            miDelete.Text = "Delete Friend";
            miDelete.Click += new EventHandler(miDelete_Click);
            // 
            // chatToolStripMenuItem
            // 
            miChat.Name = "chatToolStripMenuItem";
            miChat.Size = new Size(152, 22);
            miChat.Text = "Chat";
            miChat.Click += new EventHandler(miChat_Click);
            // 
            // inviteToolStripMenuItem
            // 
            miInvite.Name = "invateToolStripMenuItem";
            miInvite.Size = new Size(152, 22);
            miInvite.Text = "Invite to Group Chat...";
            miInvite.Click += new EventHandler(miInvite_Click);
            // 
            // gbFriendList
            // 
            gbFriendList.Controls.Add(lbOffline);
            gbFriendList.Controls.Add(lbOnline);
            gbFriendList.Controls.Add(lbFriendList);
            gbFriendList.Location = new System.Drawing.Point(517, 50);
            gbFriendList.Name = "gbFriendList";
            gbFriendList.Size = new System.Drawing.Size(205, 340);
            gbFriendList.TabIndex = 8;
            gbFriendList.TabStop = false;
            gbFriendList.Text = "Friends List";            
            // 
            // lbOffline
            // 
            lbOffline.FormattingEnabled = true;
            lbOffline.Location = new System.Drawing.Point(21, 19);
            lbOffline.Name = "lbOffline";
            lbOffline.Size = new System.Drawing.Size(142, 121);
            lbOffline.TabIndex = 0;
            lbOffline.Visible = false;
            // 
            // lbOnline
            // 
            lbOnline.FormattingEnabled = true;
            lbOnline.Location = new System.Drawing.Point(21, 145);
            lbOnline.Name = "lbOnline";
            lbOnline.Size = new System.Drawing.Size(142, 121);
            lbOnline.TabIndex = 0;
            lbOnline.Visible = false;
            //
            // lbFriendList
            //
            lbFriendList.FormattingEnabled = true;
            lbFriendList.Location = new System.Drawing.Point(21, 19);
            lbFriendList.Name = "lbFriendList";
            lbFriendList.Size = new System.Drawing.Size(163, 310);
            lbFriendList.TabIndex = 0;
            lbFriendList.ImageList = imageList;
            lbFriendList.DoubleClick += new EventHandler(lbFriendList_DoubleClick);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(734, 415);
            Controls.Add(gbFriendList);
            Controls.Add(mainTab);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "frmMain";
            Text = "Chat with me";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            mainTab.ResumeLayout(false);
            tpServer.ResumeLayout(false);
            tpServer.PerformLayout();
            gbFriendList.ResumeLayout(false);          
            ResumeLayout(true);
            PerformLayout();
            this.FormClosing += new FormClosingEventHandler(frmMainChat_FormClosing);
        }
        //Hide hoặc Show cac thành phần Chat
        private void VisibleChat(bool b)
        {
            mainMenu.Visible = b;
            mainTab.Visible = b;
            gbFriendList.Visible = b;
        }        
        //Nhấn Menu SignOut
        private void miSignOut_Click(object sender, EventArgs e)
        {
            lbOnline.Items.Clear();
            lbOffline.Items.Clear();
            //lbFriendList.Items.Clear();
            Disconnect("Bye$" + txtUser.Text);
        }
        //Nhấn Menu Exit
        private void miExit_Click(object sender, EventArgs e)
        {
            Disconnect("Bye$" + txtUser.Text);
            Close();
        }
        //Sự kiện Form Closing
        private void frmMainChat_FormClosing(object sender, EventArgs e)
        {
            //Gởi thông báo disconnect tới Server
           Disconnect("Bye$" + txtUser.Text);
           exit = true;
           Application.Exit();
        }
        //Sự kiến nhấn nút Send
        private void btnSend_Click(object sender, EventArgs e)
        {
            int index = mainTab.SelectedIndex;
            String tmp = mainTab.Controls[index].Controls[0].Text;
            recieveMess = txtUser.Text + ": " + tmp;
            getMultilineListBoxAddItem((MultilineListBox)mainTab.Controls[index].Controls[2],recieveMess, Color.Red);
            if (mainTab.Controls[index].Text == "Server")
            {
                sendMess = "Chat$" + txtUser.Text + "$Server$" + tmp + "$";
                SendMessage(sendMess);
            }
            else
            {
            	if (mainTab.Controls[index].Text == "Group Chat")
            	{
            		sendMess = "Group$Chat$";
            		ImageListBox lb = (ImageListBox)mainTab.Controls[index].Controls[3];
            		for (int i = 0; i < lb.Items.Count; i++)
            		{
            			sendMess += lb.Items[i].ToString() + "-";
            		}
            		sendMess += "$" + mainTab.Controls[index].Controls[4].Text +
            			"$" + tmp;
            		SendMessage(sendMess);
            	}
            	else
            	{
            		String[] name = mainTab.Controls[index].Text.Split('-');
            		sendMess = "Chat$" + txtUser.Text + "$Private$" + name[0].TrimEnd() +
            			"$" + tmp;
            		SendMessage(sendMess);
            	}                
            }
            mainTab.Controls[index].Controls[0].Text = "";
            ((TextBox)(mainTab.Controls[index].Controls[0])).Focus();
        }
        //Sự kiện Key Press trong tbMess
        private void tbMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = mainTab.SelectedIndex;
                String tmp = mainTab.Controls[index].Controls[0].Text;
                recieveMess = txtUser.Text + ": " + tmp;
                getMultilineListBoxAddItem((MultilineListBox)mainTab.Controls[index].Controls[2], recieveMess, Color.Red);
                if (mainTab.Controls[index].Text == "Server")
                {
                    sendMess = "Chat$" + txtUser.Text + "$Server$" + tmp + "$";
                    SendMessage(sendMess);
                }
                else
                {
                	if (mainTab.Controls[index].Text == "Group Chat")
	            	{
	            		String strMess = "Group$Chat$";
	            		/*ImageListBox lb = (ImageListBox)mainTab.Controls[index].Controls[3];
	            		for (int i = 0; i < lb.Items.Count; i++)
	            		{
	            			sendMess += lb.Items[i].ToString() + "-";
	            		}*/
	            		strMess += getGroupImageListBox(mainTab, index, "");
	            		strMess += "$" + mainTab.Controls[index].Controls[4].Text +
	            			"$" + tmp;
	            		SendMessage(strMess);
	            	}
	            	else
	            	{
	            		String[] name = mainTab.Controls[index].Text.Split('-');
	            		sendMess = "Chat$" + txtUser.Text + "$Private$" + name[0].TrimEnd() +
	            			"$" + tmp;
	            		SendMessage(sendMess);
	            	}
                }
                mainTab.Controls[index].Controls[0].Text = "";
                ((TextBox)(mainTab.Controls[index].Controls[0])).Focus();
            }
        }
        //Sự kiện click menu Action -> Add friend
        private void miAdd_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd();
            f.Frm = this;
            f.Username = txtUser.Text;
            f.ShowDialog();
        }
        //Sự kiện click menu Actions -> Delete friend
        private void miDelete_Click(object sender, EventArgs e)
        {
            frmDelete f = new frmDelete();
            f.Frm = this;
            f.Username = txtUser.Text;
            f.ShowDialog();
        }
        //Sự kiện click menu Actions -> Chat
        private void miChat_Click(object sender, EventArgs e)
        {
            frmChat f = new frmChat();
            f.Frm = this;
            f.Username = txtUser.Text;
            f.ShowDialog();
        }
        //Sự kiện click menu Actions -> Invite to Cofference...
        private void miInvite_Click(object sender, EventArgs e)
        {
            frmInvite f = new frmInvite();
            f.Frm = this;
            f.Username = txtUser.Text;
            f.ShowDialog();
        }
        //Gởi chuổi Disconnect cho Server
        private void Disconnect(String dis)
        {
            try
            {
                StreamWriter guiSW = new StreamWriter(khach.GetStream());
                guiSW.WriteLine(dis);
                guiSW.Flush();
                disconnect = true;
                khach.Close();
            }
            catch
            {
            }
        }
        //Thêm một tab Group Chat
        private TabPage NewPrivateTabChat(String name)
        {           
            TextBox tbMessNew = new TextBox();
            Button btnSendNew = new Button();
            MultilineListBox lbMessNew = new MultilineListBox();
            TabPage newTab = new TabPage();            
            //
            //New Tab
            //
            newTab.Controls.Add(tbMessNew);
            newTab.Controls.Add(btnSendNew);
            newTab.Controls.Add(lbMessNew);
            newTab.Location = new Point(4, 22);
            newTab.Name = "newTab";
            newTab.Padding = new Padding(3);
            newTab.Size = new Size(491, 326);
            newTab.Text = name;
            newTab.UseVisualStyleBackColor = true;
            //
            //tbMess
            //
            tbMessNew.Location = new Point(18, 242);
            tbMessNew.Multiline = true;
            tbMessNew.Name = "tbMess";
            tbMessNew.Size = new Size(308, 61);
            tbMessNew.TabIndex = 0;
            tbMessNew.KeyDown += new KeyEventHandler(tbMess_KeyDown);
            // 
            // btnSend
            // 
            btnSendNew.Location = new Point(379, 267);
            btnSendNew.Name = "btnSend";
            btnSendNew.Size = new Size(91, 36);
            btnSendNew.TabIndex = 1;
            btnSendNew.Text = "Send";
            btnSendNew.UseVisualStyleBackColor = true;
            btnSendNew.Click += new EventHandler(btnSend_Click);
            // 
            // lbMess
            // 
            lbMessNew.FormattingEnabled = true;
            lbMessNew.Location = new Point(18, 18);
            lbMessNew.Name = "lbMess";
            lbMessNew.Size = new Size(452, 199);
            lbMessNew.TabIndex = 2;
            lbMess.DrawMode = DrawMode.OwnerDrawVariable;
            //Trả về newTab
            return newTab;            
        }
        //Thêm tab Offline Message
        private TabPage NewOfflineTab()
        {
            MultilineListBox lbOfflineMess = new MultilineListBox();
            TabPage newTab = new TabPage();
            //New Tab
            //
            newTab.Controls.Add(lbOfflineMess);
            newTab.Location = new Point(4, 22);
            newTab.Name = "newTab";
            newTab.Padding = new Padding(3);
            newTab.Size = new Size(491, 326);
            newTab.Text = "Offline Messages";
            newTab.UseVisualStyleBackColor = true;
            // 
            // lbOfflineMess
            // 
            lbOfflineMess.FormattingEnabled = true;
            lbOfflineMess.Location = new System.Drawing.Point(18, 22);
            lbOfflineMess.Name = "lbOfflineMess";
            lbOfflineMess.Size = new System.Drawing.Size(456, 264);
            lbOfflineMess.TabIndex = 0;

            return newTab;
        }
        //Thêm một tab Group Chat
        private TabPage NewGroupTabChat(String groupName)
        {
            MultilineListBox lbMessNew = new MultilineListBox();
            ImageListBox ilbFriend = new ImageListBox();
            TextBox tbMessNew = new TextBox();
            Button btnSendNew = new Button();
            Label lblName = new Label();
            TabPage newTab = new TabPage();
            // 
            // newTab
            // 
            newTab.Controls.Add(tbMessNew);
            newTab.Controls.Add(btnSendNew);
            newTab.Controls.Add(lbMessNew);
            newTab.Controls.Add(ilbFriend);
            newTab.Controls.Add(lblName);
            newTab.Location = new System.Drawing.Point(4, 22);
            newTab.Name = "tabGroupChat";
            newTab.Padding = new System.Windows.Forms.Padding(3);
            newTab.Size = new System.Drawing.Size(491, 326);
            newTab.TabIndex = 2;
            newTab.Text = "Group Chat";
            newTab.UseVisualStyleBackColor = true;
            // 
            // ilbFriend
            // 
            ilbFriend.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            ilbFriend.FormattingEnabled = true;
            ilbFriend.ImageList = null;
            ilbFriend.Location = new System.Drawing.Point(330, 22);
            ilbFriend.Name = "lbFriend";
            ilbFriend.Size = new System.Drawing.Size(120, 225);
            ilbFriend.TabIndex = 3;
            ilbFriend.ImageList = imageList;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(415, 265);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(35, 13);
            lblName.TabIndex = 4;
            lblName.Text = groupName;
            // 
            // lbMessNew
            // 
            lbMessNew.FormattingEnabled = true;
            lbMessNew.Location = new System.Drawing.Point(18, 22);
            lbMessNew.Name = "lbMess";
            lbMessNew.Size = new System.Drawing.Size(287, 225);
            lbMessNew.TabIndex = 2;
            // 
            // btnSendNew
            // 
            btnSendNew.Location = new System.Drawing.Point(330, 281);
            btnSendNew.Name = "btnSend";
            btnSendNew.Size = new System.Drawing.Size(70, 31);
            btnSendNew.TabIndex = 1;
            btnSendNew.Text = "Send";
            btnSendNew.UseVisualStyleBackColor = true;
            btnSendNew.Click += new EventHandler(btnSend_Click);
            // 
            // tbMess
            // 
            tbMessNew.Location = new System.Drawing.Point(18, 265);
            tbMessNew.Multiline = true;
            tbMessNew.Name = "tbMess";
            tbMessNew.Size = new System.Drawing.Size(287, 47);
            tbMessNew.TabIndex = 0;
            tbMessNew.KeyDown += new KeyEventHandler(tbMess_KeyDown);

            return newTab;
        }
        //Khi double click vào lbFriendList
        private void lbFriendList_DoubleClick(object sender, EventArgs e)
        {
            int i = lbFriendList.SelectedIndex;
            if (i != -1)
            {
                ImageListBoxItem item = (ImageListBoxItem)lbFriendList.Items[i];
                String name = item.ToString() + " - " + txtUser.Text;
                int index = CheckTabChat(name);
                if (index == -1)
                {
                    TabPage newTab = NewPrivateTabChat(name);
                    mainTab.Controls.Add(newTab);
                    mainTab.SelectedIndex = mainTab.Controls.Count - 1;
                }
                else
                {
                    mainTab.SelectedIndex = index;
                }                
            }
        }
        //Kiểm tra Tab Chat đã mở hay chưa
        private int CheckTabChat(string name)
        {
            for (int i = 0; i < mainTab.Controls.Count; i++)
            {
                if (mainTab.Controls[i].Text == name)
                {
                    return i;
                }
            }
            return -1;
        }
        //Lấy vị trí của Group Chat trong mainTab
        private static int CheckGroupTab(TabControl tab, String groupName)
        {
            for (int i = 0; i < tab.Controls.Count; i++)
            {
                if (tab.Controls[i].Text == "Group Chat")
                {
                    if (tab.Controls[i].Controls[4].Text == groupName)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        //Hàm thêm 1 Group Tab Chat
        public void AddGroupChat(string groupName)
        {
            int index = CheckGroupTab(mainTab, groupName);
            TabPage newPage = NewGroupTabChat(groupName);
            getTabControlCallback(mainTab, index, newPage);
        }
        //Show chuổi Mess lên lbMess
        private void ShowGroupChat(String fname, String groupName, String groupMess)
        {
            int index = CheckGroupTab(mainTab, groupName);
            groupMess = fname + ": " + groupMess;
            getGroupTabItemCallback(mainTab, groupMess, index);
        }

        #endregion

        //Hàm khởi tạo form
        public frmMain()
        {
            InitializeComponent();
            LoadLogin();
        }
        //Tạo thread để nhận dữ liệu
        private void Langnghe()
        {
            nhan = new Thread(new ThreadStart(Nhandulieu));
            nhan.Start();
        }
        //Hàm nhận dữ liệu
        private void Nhandulieu()
        {
            try
            {
                byte[] data = new byte[1024];
                int receiv = 0;
                String Stringdata;
                NetworkStream stream = new NetworkStream(khach.Client);
                while (true)
                {
                    receiv = khach.Client.Receive(data);
                    Stringdata = Encoding.UTF8.GetString(data, 0, receiv).TrimEnd();
                    String[] catchuoi = Stringdata.Split('@');
                    //Các thông tin liên quan đến đăng nhập
                    #region catchuoi[0] == "Dangnhap"
                    if (catchuoi[0] == "Dangnhap")
                    {
                        if (catchuoi[1] == "TB")
                        {
                            if (catchuoi[2] == "1")
                            {
                                MessageBox.Show("User này đã đăng nhập", "Alert");
                            }
                            else
                            {
                                MessageBox.Show("Sai Username hoặc Password", "Alert");
                            }
                        }
                        if (catchuoi[1] == "TC")
                        {
                            FormChatLoadBack(this);
                            //Danh sách các Friend Online và Offline được gởi khi User mới đang nhập
                            if (catchuoi[2] == "Friend")
                            {
                                String fname = catchuoi[3];
                                if (fname != "")
                                {
                                    String[] user = fname.Split('^');
                                    String[] onUsers = user[0].Split('_');
                                    for (int i = 0; i < onUsers.Length; i++)
                                    {
                                        if (onUsers[i] != "")
                                        {
                                            getListBoxAddItem(lbOnline, onUsers[i]);
                                            getImageListBoxAddItem(lbFriendList, onUsers[i], true);
                                        }
                                    }
                                    String[] offUsers = user[1].Split('_');
                                    for (int i = 0; i < offUsers.Length; i++)
                                    {
                                        if (offUsers[i] != "")
                                        {
                                            getListBoxAddItem(lbOffline, offUsers[i]);
                                            getImageListBoxAddItem(lbFriendList, offUsers[i], false);
                                        }
                                    }
                                }
                            }
                            //In Các tin nhắn Offline nếu có
                            if (catchuoi.Length > 5)
                            {
                            	if (catchuoi[4] == "Offline" && catchuoi[5].Trim() != "")
		                        {
		                            TabPage newPage = NewOfflineTab();
		                            getTabControlCallback(mainTab, -1, newPage);
		                            int count = catchuoi.Length;
		                            int i = 5;
		                            while (i < count - 1)
		                            {
		                            	String strMess;
		                               	strMess = catchuoi[i] + " (" + catchuoi[i + 1] + "): " +
		                               		catchuoi[i + 2];
		                               	getOfflineMessage(mainTab, strMess);
		                               	i += 3;
		                            }
	                        	}	
                            }
                            
                        }
                    }
                    #endregion
                    //Các thông báo từ Server
                    #region catchuoi[0] == "Server"
                    if (catchuoi[0] == "Server")
                    {
                        //Server ngắt kết nối
                        if (catchuoi[1] == "Bye")
                        {
                        	disconnect = true;
                            break;
                        }
                        else
                        {                            
                            recieveMess = "Server: " + catchuoi[1];
                            getMultilineListBoxAddItem((MultilineListBox)mainTab.Controls[0].Controls[2], recieveMess, Color.Blue);
                        }
                    }
                    #endregion
                    //Các thông báo về Friend List
                    #region catchuoi[0] == "Friend"
                    if (catchuoi[0] == "Friend")
                    {
                        String fname = catchuoi[1];
                        //Khi Add Friend
                        if (catchuoi[2] == "Add")
                        {
                            switch (catchuoi[3])
                            {
                                case "-1":
                                    MessageBox.Show("Không tồn tại User này");
                            	    break;
                                case "0":
                                    MessageBox.Show("User này đã có trong Friend List");
                                    break;
                                case "1":
                                    MessageBox.Show("Đã Add User " + fname + " vào Friend List");
                                    getListBoxAddItem(lbOnline, fname);
                                    getImageListBoxAddItem(lbFriendList, fname, true);
                                    break;
                                case "2":
                                    MessageBox.Show("Đã Add User " + fname + " vào Friend List");
                                    getListBoxAddItem(lbOffline, fname);
                                    getImageListBoxAddItem(lbFriendList, fname, false);
                                    break;
                            }
                        }                        
                        if (catchuoi[2] == "Del")
                        {
                            switch (catchuoi[3])
                            {
                                case "0":
                                    MessageBox.Show("User này không có trong Friend List");
                                    break;
                                case "1":
                                    MessageBox.Show("Đã Del User " + fname + " khỏi Friend List");
                                    getListBoxRemoveItem(lbOnline, fname);
                                    getImageListBoxRemoveItem(lbFriendList, fname);
                                    break;
                                case "2":
                                    MessageBox.Show("Đã Del User " + fname + " khỏi Friend List");
                                    getListBoxRemoveItem(lbOffline, fname);
                                    getImageListBoxRemoveItem(lbFriendList, fname);
                                    break;
                            }
                        }
                        if (catchuoi[2] == "In")
                        {
                            getListBoxRemoveItem(lbOffline, catchuoi[1].ToString());
                            getListBoxAddItem(lbOnline, catchuoi[1].ToString());
                            getImageListBoxChangeItem(lbFriendList, catchuoi[1].ToString(), true);
                        }
                        if (catchuoi[2] == "Out")
                        {
                            getListBoxRemoveItem(lbOnline, catchuoi[1].ToString());
                            getListBoxAddItem(lbOffline, catchuoi[1].ToString());
                            getImageListBoxChangeItem(lbFriendList, catchuoi[1].ToString(), false);
                        }
                    }
                    #endregion
                    //Các thông báo về Chat
                    #region catchuoi[0] == "Chat"
                    if (catchuoi[0] == "Chat")
                    {
                        if (catchuoi[1] == "With")
                        {
                            if (catchuoi[3] == "0")
                            {
                                MessageBox.Show("User " + catchuoi[2].ToString() + " không tồn tại");
                            }
                            else
                            {
                                String name = catchuoi[2] + " - " + txtUser.Text;
                                int index = CheckTabChat(name);
                                TabPage newPage = NewPrivateTabChat(name);
                                getTabControlCallback(mainTab, index, newPage);
                            }
                        }
                        if (catchuoi[1] == "Private")
                        {
                            String fname = catchuoi[2];
                            String name = fname + " - " + txtUser.Text;
                            int index = CheckTabChat(name);
                            TabPage newPage = NewPrivateTabChat(name);
                            getTabControlCallback(mainTab, index, newPage);
                            recieveMess = fname + ": " + catchuoi[3];
                            getTabItemCallback(mainTab, recieveMess);
                        }
                    }
                    #endregion
                    //Các thông báo về Group
                    #region catchuoi[0] == "Group"
                    if (catchuoi[0] == "Group")
                    {
                    	if (catchuoi[1] == "Invite")
                    	{
                    		if (MessageBox.Show(catchuoi[2] + " invite you to join the Group chat: \"" +
                                catchuoi[3]+"\"", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    		{
                                //Thêm Group Chat
                                AddGroupChat(catchuoi[4]);
                                //Thêm User vào Group Chat
                                getGroupTabChat(mainTab, catchuoi[4], catchuoi[2], 0);
                                string s = "Group$Allow$" + catchuoi[2] + "$" + catchuoi[4];
                                StreamWriter gui = new StreamWriter(khach.GetStream());
                                gui.WriteLine(s);
                                gui.Flush();
                    		}
                    	}
                        if (catchuoi[1] == "Add")
                        {
                            //Add thêm User vào Group Chat
                            String[] Users = catchuoi[2].Split('-');
                            for (int i = 0; i < Users.Length ; i++)
                            {
                            	if (Users[i] != "")
                            	{
                            		getGroupTabChat(mainTab, catchuoi[3], Users[i], 0);
                            	}
                            }
                        }
                        if (catchuoi[1] == "Remove")
                        {
                            getGroupTabChat(mainTab, catchuoi[3], catchuoi[2], 1);
                        }
                        if (catchuoi[1] == "Destroy")
                        {
                            MessageBox.Show(catchuoi[2] + " đã hủy group chat " + catchuoi[3], "Thông báo");
                            getGroupTabChat(mainTab, catchuoi[3], catchuoi[2], 2);
                        }
                        if (catchuoi[1] == "Chat")
                        {
                            String fname = catchuoi[2];
                        	String groupName = catchuoi[3];
                        	String groupMess = catchuoi[4];
                            ShowGroupChat(fname, groupName, groupMess);
                        }
                    }
                    #endregion
                    Stringdata = "";
                }
            }
            catch (Exception ex)
            {
            	if (khach.Connected)
            	{
            		khach.Close();
            	}
            }            
            //Đăng nhập thành công
            //Ẩn phần Login, hiện các thành phần chat
            if (exit)
            {
            	nhan.Abort();
            }
            if (disconnect)
            {
            	FormLoginLoadBack(this);
            }
        }
        //Hàm gởi thông điệp tới Server (có thể được gọi từ các form khác)
        public void SendMessage(string s)
        {
            if (khach.Connected)
            {
                StreamWriter gui = new StreamWriter(khach.GetStream());
                gui.WriteLine(s);
                gui.Flush();
            }
        }        
    }        
}
