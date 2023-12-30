namespace Quanlydoanvien
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.btnthaydoi = new DevComponents.DotNetBar.ButtonX();
            this.txtusercu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtpasscu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtusermoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpassmoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btntaomoi = new DevComponents.DotNetBar.ButtonX();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnthaydoi
            // 
            this.btnthaydoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthaydoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthaydoi.Image = ((System.Drawing.Image)(resources.GetObject("btnthaydoi.Image")));
            this.btnthaydoi.Location = new System.Drawing.Point(48, 118);
            this.btnthaydoi.Name = "btnthaydoi";
            this.btnthaydoi.Size = new System.Drawing.Size(79, 38);
            this.btnthaydoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthaydoi.TabIndex = 8;
            this.btnthaydoi.Text = "Thay đổi";
            this.btnthaydoi.Click += new System.EventHandler(this.btnthaydoi_Click);
            // 
            // txtusercu
            // 
            // 
            // 
            // 
            this.txtusercu.Border.Class = "TextBoxBorder";
            this.txtusercu.Location = new System.Drawing.Point(96, 34);
            this.txtusercu.Name = "txtusercu";
            this.txtusercu.Size = new System.Drawing.Size(100, 20);
            this.txtusercu.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(2, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên đăng nhập cũ";
            // 
            // txtpasscu
            // 
            // 
            // 
            // 
            this.txtpasscu.Border.Class = "TextBoxBorder";
            this.txtpasscu.Location = new System.Drawing.Point(96, 69);
            this.txtpasscu.Name = "txtpasscu";
            this.txtpasscu.Size = new System.Drawing.Size(100, 20);
            this.txtpasscu.TabIndex = 3;
            this.txtpasscu.UseSystemPasswordChar = true;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(4, 69);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Password cũ";
            // 
            // txtusermoi
            // 
            // 
            // 
            // 
            this.txtusermoi.Border.Class = "TextBoxBorder";
            this.txtusermoi.Location = new System.Drawing.Point(319, 35);
            this.txtusermoi.Name = "txtusermoi";
            this.txtusermoi.Size = new System.Drawing.Size(100, 20);
            this.txtusermoi.TabIndex = 5;
            // 
            // txtpassmoi
            // 
            // 
            // 
            // 
            this.txtpassmoi.Border.Class = "TextBoxBorder";
            this.txtpassmoi.Location = new System.Drawing.Point(319, 69);
            this.txtpassmoi.Name = "txtpassmoi";
            this.txtpassmoi.Size = new System.Drawing.Size(100, 20);
            this.txtpassmoi.TabIndex = 7;
            this.txtpassmoi.UseSystemPasswordChar = true;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(216, 33);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(97, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Tên đăng nhập mới";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Location = new System.Drawing.Point(216, 68);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Password mới";
            // 
            // btntaomoi
            // 
            this.btntaomoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntaomoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btntaomoi.Image = ((System.Drawing.Image)(resources.GetObject("btntaomoi.Image")));
            this.btntaomoi.Location = new System.Drawing.Point(174, 118);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(79, 38);
            this.btntaomoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btntaomoi.TabIndex = 9;
            this.btntaomoi.Text = "Nhập mới";
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(299, 118);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(79, 38);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Quay lại";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 174);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtpassmoi);
            this.Controls.Add(this.txtusermoi);
            this.Controls.Add(this.txtpasscu);
            this.Controls.Add(this.txtusercu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.btnthaydoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnthaydoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusercu;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpasscu;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusermoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpassmoi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btntaomoi;
        private DevComponents.DotNetBar.ButtonX btnthoat;
    }
}