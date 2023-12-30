namespace Shop_Manager
{
    partial class frmHDX
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
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.grdKq = new System.Windows.Forms.DataGridView();
            this.cboMaMatH = new System.Windows.Forms.ComboBox();
            this.txtMaMatH = new System.Windows.Forms.TextBox();
            this.lblMaMatH = new System.Windows.Forms.Label();
            this.pckNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdKq)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(38, 83);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(78, 19);
            this.lblNgayNhap.TabIndex = 25;
            this.lblNgayNhap.Text = "Ngày xuất";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(216, 123);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 32);
            this.btnHienThi.TabIndex = 24;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // grdKq
            // 
            this.grdKq.AllowUserToAddRows = false;
            this.grdKq.AllowUserToDeleteRows = false;
            this.grdKq.AllowUserToResizeRows = false;
            this.grdKq.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdKq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKq.Location = new System.Drawing.Point(42, 168);
            this.grdKq.MultiSelect = false;
            this.grdKq.Name = "grdKq";
            this.grdKq.ReadOnly = true;
            this.grdKq.Size = new System.Drawing.Size(586, 175);
            this.grdKq.TabIndex = 23;
            this.grdKq.CurrentCellChanged += new System.EventHandler(this.grdKq_CurrentCellChanged);
            // 
            // cboMaMatH
            // 
            this.cboMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaMatH.FormattingEnabled = true;
            this.cboMaMatH.Location = new System.Drawing.Point(233, 46);
            this.cboMaMatH.Name = "cboMaMatH";
            this.cboMaMatH.Size = new System.Drawing.Size(121, 27);
            this.cboMaMatH.TabIndex = 22;
            this.cboMaMatH.SelectedIndexChanged += new System.EventHandler(this.cboMaMatH_SelectedIndexChanged);
            // 
            // txtMaMatH
            // 
            this.txtMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMatH.Location = new System.Drawing.Point(133, 46);
            this.txtMaMatH.Name = "txtMaMatH";
            this.txtMaMatH.Size = new System.Drawing.Size(100, 26);
            this.txtMaMatH.TabIndex = 21;
            // 
            // lblMaMatH
            // 
            this.lblMaMatH.AutoSize = true;
            this.lblMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMatH.Location = new System.Drawing.Point(38, 49);
            this.lblMaMatH.Name = "lblMaMatH";
            this.lblMaMatH.Size = new System.Drawing.Size(74, 19);
            this.lblMaMatH.TabIndex = 20;
            this.lblMaMatH.Text = "Mặt hàng";
            // 
            // pckNgayXuat
            // 
            this.pckNgayXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pckNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckNgayXuat.Location = new System.Drawing.Point(133, 83);
            this.pckNgayXuat.Name = "pckNgayXuat";
            this.pckNgayXuat.Size = new System.Drawing.Size(221, 26);
            this.pckNgayXuat.TabIndex = 32;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(481, 6);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(147, 26);
            this.txtSoLuong.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(481, 49);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(147, 26);
            this.txtDonGia.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Đơn giá";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(337, 123);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(133, 6);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(221, 26);
            this.txtMaHD.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã hóa đơn";
            // 
            // frmHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 355);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pckNgayXuat);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.grdKq);
            this.Controls.Add(this.cboMaMatH);
            this.Controls.Add(this.txtMaMatH);
            this.Controls.Add(this.lblMaMatH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmHDX";
            this.Text = "Hóa đon xuât";
            this.Load += new System.EventHandler(this.frmHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataGridView grdKq;
        private System.Windows.Forms.ComboBox cboMaMatH;
        private System.Windows.Forms.TextBox txtMaMatH;
        private System.Windows.Forms.Label lblMaMatH;
        private System.Windows.Forms.DateTimePicker pckNgayXuat;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label3;
    }
}