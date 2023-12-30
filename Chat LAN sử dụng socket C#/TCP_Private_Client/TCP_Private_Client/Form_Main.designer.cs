namespace TCP_Private_Client
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.button_Send = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_UserName = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_PublicChat = new System.Windows.Forms.Button();
            this.button_CapNhatDanhSach = new System.Windows.Forms.Button();
            this.listBox_UserOnline = new System.Windows.Forms.ListBox();
            this.label_Private = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Send
            // 
            resources.ApplyResources(this.button_Send, "button_Send");
            this.button_Send.Name = "button_Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label_UserName
            // 
            resources.ApplyResources(this.label_UserName, "label_UserName");
            this.label_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_UserName.Name = "label_UserName";
            // 
            // lblInstructions
            // 
            resources.ApplyResources(this.lblInstructions, "lblInstructions");
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblInstructions.Name = "lblInstructions";
            // 
            // textBox_Send
            // 
            resources.ApplyResources(this.textBox_Send, "textBox_Send");
            this.textBox_Send.Name = "textBox_Send";
            // 
            // textBox_Status
            // 
            resources.ApplyResources(this.textBox_Status, "textBox_Status");
            this.textBox_Status.Name = "textBox_Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_PublicChat);
            this.groupBox1.Controls.Add(this.button_CapNhatDanhSach);
            this.groupBox1.Controls.Add(this.listBox_UserOnline);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button_PublicChat
            // 
            resources.ApplyResources(this.button_PublicChat, "button_PublicChat");
            this.button_PublicChat.Name = "button_PublicChat";
            this.button_PublicChat.UseVisualStyleBackColor = true;
            this.button_PublicChat.Click += new System.EventHandler(this.button_PublicChat_Click);
            // 
            // button_CapNhatDanhSach
            // 
            resources.ApplyResources(this.button_CapNhatDanhSach, "button_CapNhatDanhSach");
            this.button_CapNhatDanhSach.Name = "button_CapNhatDanhSach";
            this.button_CapNhatDanhSach.UseVisualStyleBackColor = true;
            this.button_CapNhatDanhSach.Click += new System.EventHandler(this.button_CapNhatDanhSach_Click);
            // 
            // listBox_UserOnline
            // 
            this.listBox_UserOnline.FormattingEnabled = true;
            resources.ApplyResources(this.listBox_UserOnline, "listBox_UserOnline");
            this.listBox_UserOnline.Name = "listBox_UserOnline";
            this.listBox_UserOnline.SelectedIndexChanged += new System.EventHandler(this.listBox_UserOnline_SelectedIndexChanged);
            // 
            // label_Private
            // 
            resources.ApplyResources(this.label_Private, "label_Private");
            this.label_Private.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_Private.Name = "label_Private";
            // 
            // Form_Main
            // 
            this.AcceptButton = this.button_Send;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.label_Private);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.textBox_Send);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_UserOnline;
        private System.Windows.Forms.Button button_PublicChat;
        private System.Windows.Forms.Button button_CapNhatDanhSach;
        private System.Windows.Forms.Label label_Private;
    }
}

