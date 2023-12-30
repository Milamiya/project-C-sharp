namespace prPhamMemHoTroTimViecLam
{
    partial class DangKy
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhaplaiMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblHienthongbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đăng ký tài khoản";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(158, 106);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(240, 29);
            this.txtMatkhau.TabIndex = 1;
            this.txtMatkhau.TextChanged += new System.EventHandler(this.txtMatkhau_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu :";
            // 
            // txtTenDangnhap
            // 
            this.txtTenDangnhap.Location = new System.Drawing.Point(158, 71);
            this.txtTenDangnhap.Multiline = true;
            this.txtTenDangnhap.Name = "txtTenDangnhap";
            this.txtTenDangnhap.Size = new System.Drawing.Size(240, 29);
            this.txtTenDangnhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // txtnhaplaiMK
            // 
            this.txtnhaplaiMK.Location = new System.Drawing.Point(158, 141);
            this.txtnhaplaiMK.Multiline = true;
            this.txtnhaplaiMK.Name = "txtnhaplaiMK";
            this.txtnhaplaiMK.PasswordChar = '*';
            this.txtnhaplaiMK.Size = new System.Drawing.Size(240, 29);
            this.txtnhaplaiMK.TabIndex = 2;
            this.txtnhaplaiMK.TextChanged += new System.EventHandler(this.txtnhaplaiMK_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập lại mật khẩu :";
            // 
            // btnDangky
            // 
            this.btnDangky.Location = new System.Drawing.Point(71, 210);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(127, 44);
            this.btnDangky.TabIndex = 3;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(234, 210);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblHienthongbao
            // 
            this.lblHienthongbao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHienthongbao.Location = new System.Drawing.Point(158, 173);
            this.lblHienthongbao.Name = "lblHienthongbao";
            this.lblHienthongbao.Size = new System.Drawing.Size(165, 26);
            this.lblHienthongbao.TabIndex = 18;
            this.lblHienthongbao.Text = "Mật khẩu hợp lệ";
            this.lblHienthongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHienthongbao.Visible = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 264);
            this.Controls.Add(this.lblHienthongbao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.txtnhaplaiMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDangnhap);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhaplaiMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblHienthongbao;
    }
}