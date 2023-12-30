namespace QuanLyDaoTao.Presentation
{
    partial class frmThongTinCauHinhCSDL
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.txtMayChu = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbNhoMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCSDL = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayChu.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbNhoMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCSDL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(153, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Máy chủ:";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.databaseInfo128_copy;
            this.reflectionImage1.Location = new System.Drawing.Point(3, -2);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(144, 252);
            this.reflectionImage1.TabIndex = 0;
            // 
            // txtMayChu
            // 
            this.txtMayChu.EnterMoveNextControl = true;
            this.txtMayChu.Location = new System.Drawing.Point(248, 18);
            this.txtMayChu.Name = "txtMayChu";
            this.txtMayChu.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMayChu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMayChu.Properties.Appearance.Options.UseBackColor = true;
            this.txtMayChu.Properties.Appearance.Options.UseFont = true;
            this.txtMayChu.Properties.ReadOnly = true;
            this.txtMayChu.Size = new System.Drawing.Size(223, 24);
            this.txtMayChu.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ckbNhoMatKhau);
            this.groupBox1.Controls.Add(this.radioGroup1);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox1.Location = new System.Drawing.Point(153, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 190);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập máy chủ";
            // 
            // ckbNhoMatKhau
            // 
            this.ckbNhoMatKhau.Location = new System.Drawing.Point(93, 156);
            this.ckbNhoMatKhau.Name = "ckbNhoMatKhau";
            this.ckbNhoMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ckbNhoMatKhau.Properties.Appearance.Options.UseFont = true;
            this.ckbNhoMatKhau.Properties.Caption = "Nhớ mật khẩu";
            this.ckbNhoMatKhau.Properties.ReadOnly = true;
            this.ckbNhoMatKhau.Size = new System.Drawing.Size(127, 22);
            this.ckbNhoMatKhau.TabIndex = 5;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(49, 24);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Sử dụng chứng thực quyền Window"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Sử dụng chứng thực quyền Server")});
            this.radioGroup1.Properties.ReadOnly = true;
            this.radioGroup1.Size = new System.Drawing.Size(269, 68);
            this.radioGroup1.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EnterMoveNextControl = true;
            this.txtMatKhau.Location = new System.Drawing.Point(95, 128);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMatKhau.Properties.Appearance.Options.UseBackColor = true;
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Properties.ReadOnly = true;
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(223, 22);
            this.txtMatKhau.TabIndex = 4;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.EnterMoveNextControl = true;
            this.txtTaiKhoan.Location = new System.Drawing.Point(95, 98);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTaiKhoan.Properties.Appearance.Options.UseBackColor = true;
            this.txtTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txtTaiKhoan.Properties.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(223, 22);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(25, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mật khẩu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(25, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tài khoản:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Location = new System.Drawing.Point(153, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Cơ sở dữ liệu:";
            // 
            // txtCSDL
            // 
            this.txtCSDL.EnterMoveNextControl = true;
            this.txtCSDL.Location = new System.Drawing.Point(248, 59);
            this.txtCSDL.Name = "txtCSDL";
            this.txtCSDL.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCSDL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCSDL.Properties.Appearance.Options.UseBackColor = true;
            this.txtCSDL.Properties.Appearance.Options.UseFont = true;
            this.txtCSDL.Properties.ReadOnly = true;
            this.txtCSDL.Size = new System.Drawing.Size(223, 24);
            this.txtCSDL.TabIndex = 4;
            // 
            // frmThongTinCauHinhCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCSDL);
            this.Controls.Add(this.txtMayChu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.reflectionImage1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(518, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(518, 340);
            this.Name = "frmThongTinCauHinhCSDL";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin kết nối CSDL";
            this.Load += new System.EventHandler(this.frmThongTinCauHinhCSDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMayChu.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbNhoMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCSDL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.TextEdit txtMayChu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit ckbNhoMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCSDL;
    }
}