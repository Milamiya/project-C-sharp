namespace QuanLyDaoTao.Presentation
{
    partial class frmDoiMatKhau
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
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMKCu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhapLai = new DevExpress.XtraEditors.TextEdit();
            this.btnDoiMK = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.resetpass;
            this.reflectionImage1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.reflectionImage1.Location = new System.Drawing.Point(3, 3);
            this.reflectionImage1.Margin = new System.Windows.Forms.Padding(4);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(90, 157);
            this.reflectionImage1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(100, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mật khẩu cũ:";
            // 
            // txtMKCu
            // 
            this.txtMKCu.EnterMoveNextControl = true;
            this.txtMKCu.Location = new System.Drawing.Point(192, 9);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMKCu.Properties.Appearance.Options.UseFont = true;
            this.txtMKCu.Properties.PasswordChar = '*';
            this.txtMKCu.Properties.UseSystemPasswordChar = true;
            this.txtMKCu.Size = new System.Drawing.Size(154, 24);
            this.txtMKCu.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(100, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.EnterMoveNextControl = true;
            this.txtMKMoi.Location = new System.Drawing.Point(200, 47);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMKMoi.Properties.Appearance.Options.UseFont = true;
            this.txtMKMoi.Properties.PasswordChar = '*';
            this.txtMKMoi.Properties.UseSystemPasswordChar = true;
            this.txtMKMoi.Size = new System.Drawing.Size(146, 24);
            this.txtMKMoi.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(59, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(151, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(216, 85);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNhapLai.Properties.Appearance.Options.UseFont = true;
            this.txtNhapLai.Properties.PasswordChar = '*';
            this.txtNhapLai.Properties.UseSystemPasswordChar = true;
            this.txtNhapLai.Size = new System.Drawing.Size(130, 24);
            this.txtNhapLai.TabIndex = 6;
            this.txtNhapLai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit3_KeyPress);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDoiMK.Appearance.Options.UseFont = true;
            this.btnDoiMK.Image = global::QuanLyDaoTao.Properties.Resources.resetpass32;
            this.btnDoiMK.Location = new System.Drawing.Point(119, 118);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(101, 35);
            this.btnDoiMK.TabIndex = 7;
            this.btnDoiMK.Text = "Đồng ý";
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QuanLyDaoTao.Properties.Resources.button_cancel_icon2;
            this.btnHuy.Location = new System.Drawing.Point(245, 118);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 35);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 162);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.reflectionImage1);
            this.MaximumSize = new System.Drawing.Size(374, 200);
            this.MinimumSize = new System.Drawing.Size(374, 200);
            this.Name = "frmDoiMatKhau";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMKCu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMKMoi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNhapLai;
        private DevExpress.XtraEditors.SimpleButton btnDoiMK;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}