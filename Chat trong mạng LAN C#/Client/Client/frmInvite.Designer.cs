namespace Client
{
    partial class frmInvite
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
        	this.lbFriend = new System.Windows.Forms.ListBox();
        	this.lbInvite = new System.Windows.Forms.ListBox();
        	this.btnAdd = new System.Windows.Forms.Button();
        	this.btnInvite = new System.Windows.Forms.Button();
        	this.btnCancel = new System.Windows.Forms.Button();
        	this.btnRemove = new System.Windows.Forms.Button();
        	this.btnInviteAnother = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.tbInviteMessage = new System.Windows.Forms.TextBox();
        	this.SuspendLayout();
        	// 
        	// lbFriend
        	// 
        	this.lbFriend.FormattingEnabled = true;
        	this.lbFriend.Location = new System.Drawing.Point(12, 25);
        	this.lbFriend.Name = "lbFriend";
        	this.lbFriend.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        	this.lbFriend.Size = new System.Drawing.Size(195, 277);
        	this.lbFriend.TabIndex = 0;
        	// 
        	// lbInvite
        	// 
        	this.lbInvite.FormattingEnabled = true;
        	this.lbInvite.Location = new System.Drawing.Point(353, 25);
        	this.lbInvite.Name = "lbInvite";
        	this.lbInvite.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        	this.lbInvite.Size = new System.Drawing.Size(195, 277);
        	this.lbInvite.TabIndex = 1;
        	// 
        	// btnAdd
        	// 
        	this.btnAdd.Location = new System.Drawing.Point(228, 57);
        	this.btnAdd.Name = "btnAdd";
        	this.btnAdd.Size = new System.Drawing.Size(93, 32);
        	this.btnAdd.TabIndex = 2;
        	this.btnAdd.Text = "Add ->";
        	this.btnAdd.UseVisualStyleBackColor = true;
        	this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        	// 
        	// btnInvite
        	// 
        	this.btnInvite.Location = new System.Drawing.Point(353, 333);
        	this.btnInvite.Name = "btnInvite";
        	this.btnInvite.Size = new System.Drawing.Size(88, 32);
        	this.btnInvite.TabIndex = 3;
        	this.btnInvite.Text = "Invite";
        	this.btnInvite.UseVisualStyleBackColor = true;
        	this.btnInvite.Click += new System.EventHandler(this.btnInviteClick);
        	// 
        	// btnCancel
        	// 
        	this.btnCancel.Location = new System.Drawing.Point(460, 333);
        	this.btnCancel.Name = "btnCancel";
        	this.btnCancel.Size = new System.Drawing.Size(88, 32);
        	this.btnCancel.TabIndex = 4;
        	this.btnCancel.Text = "Cancel";
        	this.btnCancel.UseVisualStyleBackColor = true;
        	this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        	// 
        	// btnRemove
        	// 
        	this.btnRemove.Location = new System.Drawing.Point(228, 117);
        	this.btnRemove.Name = "btnRemove";
        	this.btnRemove.Size = new System.Drawing.Size(93, 32);
        	this.btnRemove.TabIndex = 5;
        	this.btnRemove.Text = "<- Remove";
        	this.btnRemove.UseVisualStyleBackColor = true;
        	this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
        	// 
        	// btnInviteAnother
        	// 
        	this.btnInviteAnother.Location = new System.Drawing.Point(228, 177);
        	this.btnInviteAnother.Name = "btnInviteAnother";
        	this.btnInviteAnother.Size = new System.Drawing.Size(93, 32);
        	this.btnInviteAnother.TabIndex = 6;
        	this.btnInviteAnother.Text = "Invite Another...";
        	this.btnInviteAnother.UseVisualStyleBackColor = true;
        	this.btnInviteAnother.Click += new System.EventHandler(this.btnInviteAnother_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(9, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(60, 13);
        	this.label1.TabIndex = 7;
        	this.label1.Text = "Friends List";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(350, 9);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(60, 13);
        	this.label2.TabIndex = 8;
        	this.label2.Text = "Invition List";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(12, 343);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(79, 13);
        	this.label3.TabIndex = 9;
        	this.label3.Text = "Invite Message";
        	// 
        	// tbInviteMessage
        	// 
        	this.tbInviteMessage.Location = new System.Drawing.Point(97, 340);
        	this.tbInviteMessage.Name = "tbInviteMessage";
        	this.tbInviteMessage.Size = new System.Drawing.Size(224, 20);
        	this.tbInviteMessage.TabIndex = 10;
        	// 
        	// frmInvite
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(573, 382);
        	this.Controls.Add(this.tbInviteMessage);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnInviteAnother);
        	this.Controls.Add(this.btnRemove);
        	this.Controls.Add(this.btnCancel);
        	this.Controls.Add(this.btnInvite);
        	this.Controls.Add(this.btnAdd);
        	this.Controls.Add(this.lbInvite);
        	this.Controls.Add(this.lbFriend);
        	this.Name = "frmInvite";
        	this.Text = "Invite People to  Group Chat";
        	this.Load += new System.EventHandler(this.FrmInviteLoad);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbFriend;
        private System.Windows.Forms.ListBox lbInvite;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInviteAnother;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInviteMessage;
    }
}