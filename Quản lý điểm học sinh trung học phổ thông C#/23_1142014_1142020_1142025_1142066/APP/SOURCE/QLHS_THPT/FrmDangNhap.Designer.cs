namespace QLHS
{
    partial class FrmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxControlNguoiDung = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTenNguoiDung = new DevExpress.XtraEditors.TextEdit();
            this.textEditMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNguoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tên người dùng:";
            // 
            // listBoxControlNguoiDung
            // 
            this.listBoxControlNguoiDung.Location = new System.Drawing.Point(25, 40);
            this.listBoxControlNguoiDung.Name = "listBoxControlNguoiDung";
            this.listBoxControlNguoiDung.Size = new System.Drawing.Size(187, 154);
            this.listBoxControlNguoiDung.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 200);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tài khoản:";
            // 
            // textEditTenNguoiDung
            // 
            this.textEditTenNguoiDung.EditValue = "";
            this.textEditTenNguoiDung.Location = new System.Drawing.Point(25, 220);
            this.textEditTenNguoiDung.Name = "textEditTenNguoiDung";
            this.textEditTenNguoiDung.Properties.NullText = "Bỏ trống nếu chọn tên người dùng";
            this.textEditTenNguoiDung.Size = new System.Drawing.Size(187, 20);
            this.textEditTenNguoiDung.TabIndex = 3;
            this.textEditTenNguoiDung.ToolTip = "Bỏ trống nếu chọn tên người dùng";
            this.textEditTenNguoiDung.ToolTipTitle = "Hướng dẫn";
            // 
            // textEditMatKhau
            // 
            this.textEditMatKhau.Location = new System.Drawing.Point(25, 260);
            this.textEditMatKhau.Name = "textEditMatKhau";
            this.textEditMatKhau.Properties.UseSystemPasswordChar = true;
            this.textEditMatKhau.Size = new System.Drawing.Size(187, 20);
            this.textEditMatKhau.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 243);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // simpleButtonThoat
            // 
            this.simpleButtonThoat.Image = global::QLHS.Properties.Resources.thoat_small;
            this.simpleButtonThoat.Location = new System.Drawing.Point(237, 257);
            this.simpleButtonThoat.Name = "simpleButtonThoat";
            this.simpleButtonThoat.Size = new System.Drawing.Size(127, 33);
            this.simpleButtonThoat.TabIndex = 8;
            this.simpleButtonThoat.Text = "Thoát (Alt+&X)";
            // 
            // simpleButtonDangNhap
            // 
            this.simpleButtonDangNhap.Image = global::QLHS.Properties.Resources.dangnhap_small;
            this.simpleButtonDangNhap.Location = new System.Drawing.Point(237, 214);
            this.simpleButtonDangNhap.Name = "simpleButtonDangNhap";
            this.simpleButtonDangNhap.Size = new System.Drawing.Size(127, 33);
            this.simpleButtonDangNhap.TabIndex = 7;
            this.simpleButtonDangNhap.Text = "Đăng nhập (Enter)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLHS.Properties.Resources.login2;
            this.pictureBox1.Location = new System.Drawing.Point(237, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 134);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.simpleButtonDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 304);
            this.Controls.Add(this.simpleButtonThoat);
            this.Controls.Add(this.simpleButtonDangNhap);
            this.Controls.Add(this.textEditMatKhau);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditTenNguoiDung);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxControlNguoiDung);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNguoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.ListBoxControl listBoxControlNguoiDung;
        public DevExpress.XtraEditors.TextEdit textEditTenNguoiDung;
        public DevExpress.XtraEditors.TextEdit textEditMatKhau;
        public DevExpress.XtraEditors.SimpleButton simpleButtonThoat;
        public DevExpress.XtraEditors.SimpleButton simpleButtonDangNhap;
    }
}