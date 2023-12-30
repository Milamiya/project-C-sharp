namespace Server
{
    partial class frmServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbMessage = new Server.MultilineListBox();
            this.lbOffline = new System.Windows.Forms.ListBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbUsers = new Server.ImageListBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lbOnline = new System.Windows.Forms.ListBox();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(708, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(92, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 398);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(374, 78);
            this.txtMess.TabIndex = 1;
            this.txtMess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMess_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(408, 418);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 38);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.Location = new System.Drawing.Point(6, 32);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.ScrollAlwaysVisible = true;
            this.lbMessage.Size = new System.Drawing.Size(355, 303);
            this.lbMessage.TabIndex = 3;
            // 
            // lbOffline
            // 
            this.lbOffline.FormattingEnabled = true;
            this.lbOffline.Location = new System.Drawing.Point(18, 32);
            this.lbOffline.Name = "lbOffline";
            this.lbOffline.Size = new System.Drawing.Size(229, 121);
            this.lbOffline.TabIndex = 4;
            this.lbOffline.Visible = false;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCount});
            this.ssMain.Location = new System.Drawing.Point(0, 491);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(708, 22);
            this.ssMain.TabIndex = 5;
            this.ssMain.Text = "statusStrip1";
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(175, 17);
            this.lblCount.Text = "Không có User nào đang Online";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMessage);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 349);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Messages";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbUsers);
            this.groupBox2.Controls.Add(this.lbOnline);
            this.groupBox2.Controls.Add(this.lbOffline);
            this.groupBox2.Location = new System.Drawing.Point(408, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 349);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users List";
            // 
            // imageListBox
            // 
            this.lbUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ImageList = this.imageList;
            this.lbUsers.Location = new System.Drawing.Point(18, 19);
            this.lbUsers.Name = "imageListBox";
            this.lbUsers.Size = new System.Drawing.Size(238, 316);
            this.lbUsers.TabIndex = 8;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "0");
            this.imageList.Images.SetKeyName(1, "1");
            // 
            // lbOnline
            // 
            this.lbOnline.FormattingEnabled = true;
            this.lbOnline.Location = new System.Drawing.Point(18, 169);
            this.lbOnline.Name = "lbOnline";
            this.lbOnline.Size = new System.Drawing.Size(229, 121);
            this.lbOnline.TabIndex = 0;
            this.lbOnline.Visible = false;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmServer";
            this.Text = "Chat Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button btnSend;
        //private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox lbOffline;
        public System.Windows.Forms.ListBox lbOnline;
        private System.Windows.Forms.ImageList imageList;
        public ImageListBox lbUsers;
        private MultilineListBox lbMessage;
    }
}

