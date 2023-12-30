namespace Shop_Manager
{
    partial class frmHDN
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
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.cboMaMatH = new System.Windows.Forms.ComboBox();
            this.txtMaMatH = new System.Windows.Forms.TextBox();
            this.lblMaMatH = new System.Windows.Forms.Label();
            this.grdKq = new System.Windows.Forms.DataGridView();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.pckNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdKq)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(242, 81);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(121, 27);
            this.cboMaNCC.TabIndex = 5;
            this.cboMaNCC.SelectedIndexChanged += new System.EventHandler(this.cboMaNCC_SelectedIndexChanged);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(142, 81);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(100, 26);
            this.txtMaNCC.TabIndex = 4;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(37, 84);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(99, 19);
            this.lblMaNCC.TabIndex = 3;
            this.lblMaNCC.Text = "Nhà cung cấp";
            // 
            // cboMaMatH
            // 
            this.cboMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaMatH.FormattingEnabled = true;
            this.cboMaMatH.Location = new System.Drawing.Point(242, 47);
            this.cboMaMatH.Name = "cboMaMatH";
            this.cboMaMatH.Size = new System.Drawing.Size(121, 27);
            this.cboMaMatH.TabIndex = 8;
            this.cboMaMatH.SelectedIndexChanged += new System.EventHandler(this.cboMaMatH_SelectedIndexChanged);
            // 
            // txtMaMatH
            // 
            this.txtMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMatH.Location = new System.Drawing.Point(142, 47);
            this.txtMaMatH.Name = "txtMaMatH";
            this.txtMaMatH.Size = new System.Drawing.Size(100, 26);
            this.txtMaMatH.TabIndex = 7;
            // 
            // lblMaMatH
            // 
            this.lblMaMatH.AutoSize = true;
            this.lblMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMatH.Location = new System.Drawing.Point(37, 50);
            this.lblMaMatH.Name = "lblMaMatH";
            this.lblMaMatH.Size = new System.Drawing.Size(74, 19);
            this.lblMaMatH.TabIndex = 6;
            this.lblMaMatH.Text = "Mặt hàng";
            // 
            // grdKq
            // 
            this.grdKq.AllowUserToAddRows = false;
            this.grdKq.AllowUserToDeleteRows = false;
            this.grdKq.AllowUserToResizeRows = false;
            this.grdKq.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdKq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKq.Location = new System.Drawing.Point(35, 173);
            this.grdKq.MultiSelect = false;
            this.grdKq.Name = "grdKq";
            this.grdKq.ReadOnly = true;
            this.grdKq.Size = new System.Drawing.Size(586, 169);
            this.grdKq.TabIndex = 9;
            this.grdKq.CurrentCellChanged += new System.EventHandler(this.grdKq_CurrentCellChanged);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(208, 126);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 32);
            this.btnHienThi.TabIndex = 10;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(400, 17);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(81, 19);
            this.lblNgayNhap.TabIndex = 11;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // pckNgayNhap
            // 
            this.pckNgayNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pckNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckNgayNhap.Location = new System.Drawing.Point(490, 16);
            this.pckNgayNhap.Name = "pckNgayNhap";
            this.pckNgayNhap.Size = new System.Drawing.Size(131, 26);
            this.pckNgayNhap.TabIndex = 12;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(142, 12);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(221, 26);
            this.txtMaHD.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(490, 48);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(131, 26);
            this.txtSoLuong.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(490, 80);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(131, 26);
            this.txtDonGia.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Đơn giá";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(341, 126);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // frmHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 354);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pckNgayNhap);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.grdKq);
            this.Controls.Add(this.cboMaMatH);
            this.Controls.Add(this.txtMaMatH);
            this.Controls.Add(this.lblMaMatH);
            this.Controls.Add(this.cboMaNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lblMaNCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmHDN";
            this.Text = "Hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.ComboBox cboMaMatH;
        private System.Windows.Forms.TextBox txtMaMatH;
        private System.Windows.Forms.Label lblMaMatH;
        private System.Windows.Forms.DataGridView grdKq;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker pckNgayNhap;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
    }
}