namespace QuanLyXeVaXe
{
    partial class frmSuaChiTiet
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
            this.txtMaChiTietHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.dtgChiTietHopDong = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new System.Windows.Forms.ComboBox();
            this.txtTinhTrangHopDong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHanTraXe = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtMaLaiXe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(60, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hợp đồng";
            // 
            // txtMaChiTietHD
            // 
            this.txtMaChiTietHD.Enabled = false;
            this.txtMaChiTietHD.Location = new System.Drawing.Point(171, 40);
            this.txtMaChiTietHD.Name = "txtMaChiTietHD";
            this.txtMaChiTietHD.Size = new System.Drawing.Size(121, 20);
            this.txtMaChiTietHD.TabIndex = 0;
            this.txtMaChiTietHD.TextChanged += new System.EventHandler(this.txtMaChiTietHD_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã chi tiết cần sửa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(335, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã lái xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(96, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã xe";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tiếp...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSua.Location = new System.Drawing.Point(212, 179);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(75, 34);
            this.cmdSua.TabIndex = 3;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // dtgChiTietHopDong
            // 
            this.dtgChiTietHopDong.AllowUserToAddRows = false;
            this.dtgChiTietHopDong.AllowUserToDeleteRows = false;
            this.dtgChiTietHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dtgChiTietHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietHopDong.Location = new System.Drawing.Point(9, 231);
            this.dtgChiTietHopDong.Name = "dtgChiTietHopDong";
            this.dtgChiTietHopDong.ReadOnly = true;
            this.dtgChiTietHopDong.Size = new System.Drawing.Size(551, 239);
            this.dtgChiTietHopDong.TabIndex = 4;
            this.dtgChiTietHopDong.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgChiTietHopDong_RowHeaderMouseDoubleClick);
            // 
            // txtMaHD
            // 
            this.txtMaHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.FormattingEnabled = true;
            this.txtMaHD.Location = new System.Drawing.Point(171, 76);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(121, 20);
            this.txtMaHD.TabIndex = 2;
            // 
            // txtTinhTrangHopDong
            // 
            this.txtTinhTrangHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtTinhTrangHopDong.Enabled = false;
            this.txtTinhTrangHopDong.FormattingEnabled = true;
            this.txtTinhTrangHopDong.Items.AddRange(new object[] {
            "Chua thanh toan"});
            this.txtTinhTrangHopDong.Location = new System.Drawing.Point(424, 74);
            this.txtTinhTrangHopDong.Name = "txtTinhTrangHopDong";
            this.txtTinhTrangHopDong.Size = new System.Drawing.Size(105, 21);
            this.txtTinhTrangHopDong.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(325, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tình trạng HĐ";
            // 
            // dtpHanTraXe
            // 
            this.dtpHanTraXe.Enabled = false;
            this.dtpHanTraXe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTraXe.Location = new System.Drawing.Point(423, 112);
            this.dtpHanTraXe.Name = "dtpHanTraXe";
            this.dtpHanTraXe.Size = new System.Drawing.Size(106, 20);
            this.dtpHanTraXe.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(328, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngày thuê xe";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Enabled = false;
            this.txtMaXe.Location = new System.Drawing.Point(171, 112);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(121, 20);
            this.txtMaXe.TabIndex = 18;
            // 
            // txtMaLaiXe
            // 
            this.txtMaLaiXe.Enabled = false;
            this.txtMaLaiXe.Location = new System.Drawing.Point(423, 37);
            this.txtMaLaiXe.Name = "txtMaLaiXe";
            this.txtMaLaiXe.Size = new System.Drawing.Size(106, 20);
            this.txtMaLaiXe.TabIndex = 18;
            // 
            // frmSuaChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(572, 494);
            this.Controls.Add(this.txtMaLaiXe);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.dtpHanTraXe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTinhTrangHopDong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgChiTietHopDong);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaChiTietHD);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmSuaChiTiet";
            this.Text = "frmSuaChiTiet";
            this.Load += new System.EventHandler(this.frmSuaChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaChiTietHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.DataGridView dtgChiTietHopDong;
        private System.Windows.Forms.ComboBox txtMaHD;
        private System.Windows.Forms.ComboBox txtTinhTrangHopDong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHanTraXe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtMaLaiXe;
    }
}