namespace QLHocSinhTHPT
{
    partial class frmAbout
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
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lblTitle = new DevComponents.DotNetBar.LabelX();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lbl05 = new System.Windows.Forms.Label();
            this.lbl07 = new System.Windows.Forms.Label();
            this.lbl09 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl04 = new System.Windows.Forms.Label();
            this.lbl06 = new System.Windows.Forms.Label();
            this.lbl08Email = new System.Windows.Forms.LinkLabel();
            this.lbl10Website = new System.Windows.Forms.LinkLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(284, 169);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(107, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "QUẢN LÝ ĐIỂM HỌC SINH THPT";
            this.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.DimGray;
            this.pnlLine.Location = new System.Drawing.Point(12, 159);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(347, 1);
            this.pnlLine.TabIndex = 4;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Location = new System.Drawing.Point(109, 40);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(45, 13);
            this.lbl01.TabIndex = 2;
            this.lbl01.Text = "Version:";
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Location = new System.Drawing.Point(109, 65);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(53, 13);
            this.lbl03.TabIndex = 3;
            this.lbl03.Text = "Ngày tạo:";
            // 
            // lbl05
            // 
            this.lbl05.AutoSize = true;
            this.lbl05.Location = new System.Drawing.Point(109, 90);
            this.lbl05.Name = "lbl05";
            this.lbl05.Size = new System.Drawing.Size(46, 13);
            this.lbl05.TabIndex = 4;
            this.lbl05.Text = "Tác giả:";
            // 
            // lbl07
            // 
            this.lbl07.AutoSize = true;
            this.lbl07.Location = new System.Drawing.Point(109, 115);
            this.lbl07.Name = "lbl07";
            this.lbl07.Size = new System.Drawing.Size(38, 13);
            this.lbl07.TabIndex = 5;
            this.lbl07.Text = "E-mail:";
            // 
            // lbl09
            // 
            this.lbl09.AutoSize = true;
            this.lbl09.Location = new System.Drawing.Point(109, 140);
            this.lbl09.Name = "lbl09";
            this.lbl09.Size = new System.Drawing.Size(65, 13);
            this.lbl09.TabIndex = 6;
            this.lbl09.Text = "Home-page:";
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Location = new System.Drawing.Point(171, 40);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(22, 13);
            this.lbl02.TabIndex = 2;
            this.lbl02.Text = "3.0";
            // 
            // lbl04
            // 
            this.lbl04.AutoSize = true;
            this.lbl04.Location = new System.Drawing.Point(171, 65);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(65, 13);
            this.lbl04.TabIndex = 3;
            this.lbl04.Text = "16/09/2008";
            // 
            // lbl06
            // 
            this.lbl06.AutoSize = true;
            this.lbl06.Location = new System.Drawing.Point(171, 90);
            this.lbl06.Name = "lbl06";
            this.lbl06.Size = new System.Drawing.Size(159, 13);
            this.lbl06.TabIndex = 4;
            this.lbl06.Text = "Nguyễn Hoàng Tùng - DH6TH2";
            // 
            // lbl08Email
            // 
            this.lbl08Email.AutoSize = true;
            this.lbl08Email.Location = new System.Drawing.Point(171, 115);
            this.lbl08Email.Name = "lbl08Email";
            this.lbl08Email.Size = new System.Drawing.Size(117, 13);
            this.lbl08Email.TabIndex = 5;
            this.lbl08Email.TabStop = true;
            this.lbl08Email.Text = "hoangtung@inbox.com";
            this.lbl08Email.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl08Email_LinkClicked);
            // 
            // lbl10Website
            // 
            this.lbl10Website.AutoSize = true;
            this.lbl10Website.Location = new System.Drawing.Point(171, 140);
            this.lbl10Website.Name = "lbl10Website";
            this.lbl10Website.Size = new System.Drawing.Size(122, 13);
            this.lbl10Website.TabIndex = 6;
            this.lbl10Website.TabStop = true;
            this.lbl10Website.Text = "http://hoangtung.rap.vn";
            this.lbl10Website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl10Website_LinkClicked);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = global::QLHocSinhTHPT.Properties.Resources.hocsinh;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(12, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(90, 146);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 202);
            this.Controls.Add(this.lbl10Website);
            this.Controls.Add(this.lbl08Email);
            this.Controls.Add(this.lbl09);
            this.Controls.Add(this.lbl06);
            this.Controls.Add(this.lbl07);
            this.Controls.Add(this.lbl05);
            this.Controls.Add(this.lbl04);
            this.Controls.Add(this.lbl03);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN PHẦN MỀM";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevComponents.DotNetBar.LabelX lblTitle;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl03;
        private System.Windows.Forms.Label lbl04;
        private System.Windows.Forms.Label lbl05;
        private System.Windows.Forms.Label lbl06;
        private System.Windows.Forms.Label lbl07;
        private System.Windows.Forms.Label lbl09;
        private System.Windows.Forms.LinkLabel lbl08Email; 
        private System.Windows.Forms.LinkLabel lbl10Website;
    }
}