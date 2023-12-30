namespace Shop_Manager
{
    partial class frmDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.lblMatHang = new System.Windows.Forms.Label();
            this.cboMatHang = new System.Windows.Forms.ComboBox();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblNgayNhan = new System.Windows.Forms.Label();
            this.grdKq = new System.Windows.Forms.DataGridView();
            this.pckNgayDat = new System.Windows.Forms.DateTimePicker();
            this.pckNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnHoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.groupDatHang = new System.Windows.Forms.GroupBox();
            this.groupDatHangCT = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdKq)).BeginInit();
            this.groupDatHang.SuspendLayout();
            this.groupDatHangCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatHang
            // 
            this.lblMatHang.AutoSize = true;
            this.lblMatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatHang.Location = new System.Drawing.Point(37, 23);
            this.lblMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatHang.Name = "lblMatHang";
            this.lblMatHang.Size = new System.Drawing.Size(66, 19);
            this.lblMatHang.TabIndex = 0;
            this.lblMatHang.Text = "Mặt hàng";
            // 
            // cboMatHang
            // 
            this.cboMatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMatHang.FormattingEnabled = true;
            this.cboMatHang.Location = new System.Drawing.Point(148, 20);
            this.cboMatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMatHang.Name = "cboMatHang";
            this.cboMatHang.Size = new System.Drawing.Size(204, 27);
            this.cboMatHang.TabIndex = 6;
            this.cboMatHang.SelectedIndexChanged += new System.EventHandler(this.cboMatHang_SelectedIndexChanged);
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDat.Location = new System.Drawing.Point(479, 14);
            this.lblNgayDat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(65, 19);
            this.lblNgayDat.TabIndex = 17;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // lblNgayNhan
            // 
            this.lblNgayNhan.AutoSize = true;
            this.lblNgayNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhan.Location = new System.Drawing.Point(477, 58);
            this.lblNgayNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.Size = new System.Drawing.Size(74, 19);
            this.lblNgayNhan.TabIndex = 23;
            this.lblNgayNhan.Text = "Ngày nhận";
            // 
            // grdKq
            // 
            this.grdKq.AllowUserToAddRows = false;
            this.grdKq.AllowUserToDeleteRows = false;
            this.grdKq.AllowUserToResizeRows = false;
            this.grdKq.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grdKq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKq.Location = new System.Drawing.Point(21, 258);
            this.grdKq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdKq.MultiSelect = false;
            this.grdKq.Name = "grdKq";
            this.grdKq.ReadOnly = true;
            this.grdKq.Size = new System.Drawing.Size(748, 179);
            this.grdKq.TabIndex = 17;
            this.grdKq.CurrentCellChanged += new System.EventHandler(this.grdKq_CurrentCellChanged);
            this.grdKq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKq_CellContentClick);
            // 
            // pckNgayDat
            // 
            this.pckNgayDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pckNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckNgayDat.Location = new System.Drawing.Point(568, 14);
            this.pckNgayDat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pckNgayDat.Name = "pckNgayDat";
            this.pckNgayDat.Size = new System.Drawing.Size(181, 26);
            this.pckNgayDat.TabIndex = 8;
            // 
            // pckNgayNhan
            // 
            this.pckNgayNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pckNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckNgayNhan.Location = new System.Drawing.Point(568, 58);
            this.pckNgayNhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pckNgayNhan.Name = "pckNgayNhan";
            this.pckNgayNhan.Size = new System.Drawing.Size(181, 26);
            this.pckNgayNhan.TabIndex = 9;
            // 
            // btnDatHang
            // 
            this.btnDatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnDatHang.Image")));
            this.btnDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatHang.Location = new System.Drawing.Point(413, 101);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(122, 28);
            this.btnDatHang.TabIndex = 5;
            this.btnDatHang.Text = "Đặt hàng (&D)";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhi.Location = new System.Drawing.Point(337, 468);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(86, 28);
            this.btnGhi.TabIndex = 13;
            this.btnGhi.Text = "Ghi (&G)";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnHoan
            // 
            this.btnHoan.Image = ((System.Drawing.Image)(resources.GetObject("btnHoan.Image")));
            this.btnHoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoan.Location = new System.Drawing.Point(442, 468);
            this.btnHoan.Name = "btnHoan";
            this.btnHoan.Size = new System.Drawing.Size(95, 28);
            this.btnHoan.TabIndex = 14;
            this.btnHoan.Text = "Hoãn (&H)";
            this.btnHoan.UseVisualStyleBackColor = true;
            this.btnHoan.Click += new System.EventHandler(this.btnHoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(680, 468);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 28);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát (&T)";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(148, 55);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(204, 26);
            this.txtSoLuong.TabIndex = 7;
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(134, 468);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 28);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa (&S)";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(239, 468);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 28);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa (&X)";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieu.Image")));
            this.btnInPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInPhieu.Location = new System.Drawing.Point(548, 468);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(108, 28);
            this.btnInPhieu.TabIndex = 15;
            this.btnInPhieu.Text = "In phiếu (&I)";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click_1);
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(148, 63);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(204, 26);
            this.txtTenKhach.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tên khách hàng";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(568, 23);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(181, 26);
            this.txtDienThoai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Điện thoại";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(568, 66);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(181, 27);
            this.txtGhiChu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Mã phiếu";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(148, 19);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(204, 26);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // groupDatHang
            // 
            this.groupDatHang.Controls.Add(this.txtMaPhieu);
            this.groupDatHang.Controls.Add(this.label5);
            this.groupDatHang.Controls.Add(this.label4);
            this.groupDatHang.Controls.Add(this.txtGhiChu);
            this.groupDatHang.Controls.Add(this.label3);
            this.groupDatHang.Controls.Add(this.txtDienThoai);
            this.groupDatHang.Controls.Add(this.label1);
            this.groupDatHang.Controls.Add(this.txtTenKhach);
            this.groupDatHang.Controls.Add(this.btnDatHang);
            this.groupDatHang.Location = new System.Drawing.Point(20, 12);
            this.groupDatHang.Name = "groupDatHang";
            this.groupDatHang.Size = new System.Drawing.Size(772, 140);
            this.groupDatHang.TabIndex = 50;
            this.groupDatHang.TabStop = false;
            // 
            // groupDatHangCT
            // 
            this.groupDatHangCT.Controls.Add(this.label2);
            this.groupDatHangCT.Controls.Add(this.txtSoLuong);
            this.groupDatHangCT.Controls.Add(this.pckNgayNhan);
            this.groupDatHangCT.Controls.Add(this.pckNgayDat);
            this.groupDatHangCT.Controls.Add(this.lblNgayNhan);
            this.groupDatHangCT.Controls.Add(this.lblNgayDat);
            this.groupDatHangCT.Controls.Add(this.cboMatHang);
            this.groupDatHangCT.Controls.Add(this.lblMatHang);
            this.groupDatHangCT.Location = new System.Drawing.Point(21, 158);
            this.groupDatHangCT.Name = "groupDatHangCT";
            this.groupDatHangCT.Size = new System.Drawing.Size(771, 92);
            this.groupDatHangCT.TabIndex = 51;
            this.groupDatHangCT.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(13, 468);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 28);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm (&M)";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaH
            // 
            this.txtMaH.Location = new System.Drawing.Point(875, 150);
            this.txtMaH.Name = "txtMaH";
            this.txtMaH.Size = new System.Drawing.Size(50, 26);
            this.txtMaH.TabIndex = 53;
            this.txtMaH.Visible = false;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(804, 530);
            this.Controls.Add(this.txtMaH);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupDatHangCT);
            this.Controls.Add(this.groupDatHang);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoan);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.grdKq);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt hàng";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKq)).EndInit();
            this.groupDatHang.ResumeLayout(false);
            this.groupDatHang.PerformLayout();
            this.groupDatHangCT.ResumeLayout(false);
            this.groupDatHangCT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatHang;
        private System.Windows.Forms.ComboBox cboMatHang;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.DataGridView grdKq;
        private System.Windows.Forms.DateTimePicker pckNgayDat;
        private System.Windows.Forms.DateTimePicker pckNgayNhan;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.GroupBox groupDatHang;
        private System.Windows.Forms.GroupBox groupDatHangCT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaH;
    }
}