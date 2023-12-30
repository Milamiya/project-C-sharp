namespace Doan
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.btLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btReg = new System.Windows.Forms.Button();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(260, 44);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(492, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Luyện Thi Trắc Nghiệm";
            // 
            // btLog
            // 
            this.btLog.AutoSize = true;
            this.btLog.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btLog.BackgroundImage = global::Doan.Properties.Resources.bt;
            this.btLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLog.Location = new System.Drawing.Point(319, 330);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(135, 58);
            this.btLog.TabIndex = 2;
            this.btLog.Text = "Đăng nhập";
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đăng Nhập Tài Khoản";
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btThoat.BackgroundImage = global::Doan.Properties.Resources.bt;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(554, 330);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(136, 58);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đăng nhập :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(231, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(231, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.BackColor = System.Drawing.SystemColors.Menu;
            this.txtdangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdangnhap.Location = new System.Drawing.Point(411, 205);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(289, 20);
            this.txtdangnhap.TabIndex = 0;
            this.ttHelp.SetToolTip(this.txtdangnhap, "Tên đăng nhập không được để trống");
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.SystemColors.Menu;
            this.txtmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmatkhau.Location = new System.Drawing.Point(411, 242);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(289, 20);
            this.txtmatkhau.TabIndex = 1;
            this.ttHelp.SetToolTip(this.txtmatkhau, "Mật khẩu không được quá 20 ký tự");
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatkhau_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nếu bạn chưa có tài khoản hãy đăng ký ngay?";
            // 
            // btReg
            // 
            this.btReg.AutoSize = true;
            this.btReg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btReg.BackgroundImage = global::Doan.Properties.Resources.bt;
            this.btReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReg.Location = new System.Drawing.Point(463, 543);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(95, 36);
            this.btReg.TabIndex = 4;
            this.btReg.Text = "Đăng ký";
            this.btReg.UseVisualStyleBackColor = false;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // ttHelp
            // 
            this.ttHelp.AutomaticDelay = 100;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Doan.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 614);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtdangnhap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Activated += new System.EventHandler(this.frmLogin_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.ToolTip ttHelp;

    }
}

