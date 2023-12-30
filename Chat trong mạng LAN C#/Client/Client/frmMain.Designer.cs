namespace Client
{
    partial class frmMain
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        	this.imageList = new System.Windows.Forms.ImageList(this.components);
        	this.SuspendLayout();
        	// 
        	// imageList
        	// 
        	this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
        	this.imageList.TransparentColor = System.Drawing.Color.Transparent;
        	this.imageList.Images.SetKeyName(0, "Online");
        	this.imageList.Images.SetKeyName(1, "Offline");
        	// 
        	// frmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(284, 264);
        	this.Name = "frmMain";
        	this.Text = "Chat with me";
        	this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSignOut;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private TabControlEx mainTab;
        private System.Windows.Forms.TabPage tpServer;
        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.Button btnSend;
        private MultilineListBox lbMess;
        private System.Windows.Forms.ToolStripMenuItem miActions;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miInvite;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripMenuItem miChat;
        private System.Windows.Forms.GroupBox gbFriendList;
        private System.Windows.Forms.ListBox lbOnline;        
        private System.Windows.Forms.ListBox lbOffline;
        private System.Windows.Forms.ImageList imageList;
        public ImageListBox lbFriendList;
    }
}

