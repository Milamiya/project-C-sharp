namespace Shop_Manager
{
    partial class frmXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatHang));
            this.lblMaMatH = new System.Windows.Forms.Label();
            this.cboMaMatH = new System.Windows.Forms.ComboBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.pckNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdXuatHang = new System.Windows.Forms.DataGridView();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnHoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaH = new System.Windows.Forms.TextBox();
            this.groupHoaDonXuat = new System.Windows.Forms.GroupBox();
            this.groupChiTietHDX = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdXuatHang)).BeginInit();
            this.groupHoaDonXuat.SuspendLayout();
            this.groupChiTietHDX.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaMatH
            // 
            this.lblMaMatH.AutoSize = true;
            this.lblMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMatH.Location = new System.Drawing.Point(23, 24);
            this.lblMaMatH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMatH.Name = "lblMaMatH";
            this.lblMaMatH.Size = new System.Drawing.Size(66, 19);
            this.lblMaMatH.TabIndex = 0;
            this.lblMaMatH.Text = "Mặt hàng";
            // 
            // cboMaMatH
            // 
            this.cboMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaMatH.FormattingEnabled = true;
            this.cboMaMatH.Location = new System.Drawing.Point(123, 20);
            this.cboMaMatH.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaMatH.Name = "cboMaMatH";
            this.cboMaMatH.Size = new System.Drawing.Size(178, 27);
            this.cboMaMatH.TabIndex = 6;
            this.cboMaMatH.SelectedIndexChanged += new System.EventHandler(this.cboMaMatH_SelectedIndexChanged);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(21, 69);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(70, 19);
            this.lblMaNhanVien.TabIndex = 3;
            this.lblMaNhanVien.Text = "Nhân viên";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(121, 19);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(178, 26);
            this.txtMaHD.TabIndex = 1;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(21, 19);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(83, 19);
            this.lblMaHD.TabIndex = 5;
            this.lblMaHD.Text = "Mã hóa đơn";
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayXuat.Location = new System.Drawing.Point(407, 19);
            this.lblNgayXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(71, 19);
            this.lblNgayXuat.TabIndex = 7;
            this.lblNgayXuat.Text = "Ngày xuất";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(123, 68);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(178, 26);
            this.txtSoLuong.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(34, 72);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 19);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(123, 113);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(178, 26);
            this.txtDonGia.TabIndex = 8;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(41, 120);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(56, 19);
            this.lblDonGia.TabIndex = 11;
            this.lblDonGia.Text = "Đơn giá";
            this.lblDonGia.Click += new System.EventHandler(this.lblDonGia_Click);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(505, 16);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(182, 26);
            this.txtDonViTinh.TabIndex = 9;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.Location = new System.Drawing.Point(420, 20);
            this.lblDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(74, 19);
            this.lblDonViTinh.TabIndex = 13;
            this.lblDonViTinh.Text = "Đơn vị tính";
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(121, 69);
            this.cboMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(178, 27);
            this.cboMaNhanVien.TabIndex = 2;
            this.cboMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboMaNhanVien_SelectedIndexChanged);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatHang.Image")));
            this.btnXuatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatHang.Location = new System.Drawing.Point(390, 112);
            this.btnXuatHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(149, 32);
            this.btnXuatHang.TabIndex = 5;
            this.btnXuatHang.Text = "Xuất hàng (&X)";
            this.btnXuatHang.UseVisualStyleBackColor = true;
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // pckNgayXuat
            // 
            this.pckNgayXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pckNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pckNgayXuat.Location = new System.Drawing.Point(503, 19);
            this.pckNgayXuat.Margin = new System.Windows.Forms.Padding(4);
            this.pckNgayXuat.Name = "pckNgayXuat";
            this.pckNgayXuat.Size = new System.Drawing.Size(182, 26);
            this.pckNgayXuat.TabIndex = 3;
            this.pckNgayXuat.Value = new System.DateTime(2008, 4, 15, 14, 46, 2, 0);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(503, 66);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(182, 26);
            this.txtGhiChu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ghi chú";
            // 
            // grdXuatHang
            // 
            this.grdXuatHang.AllowUserToAddRows = false;
            this.grdXuatHang.AllowUserToDeleteRows = false;
            this.grdXuatHang.AllowUserToResizeRows = false;
            this.grdXuatHang.BackgroundColor = System.Drawing.Color.LightCyan;
            this.grdXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdXuatHang.Location = new System.Drawing.Point(40, 339);
            this.grdXuatHang.Margin = new System.Windows.Forms.Padding(4);
            this.grdXuatHang.MultiSelect = false;
            this.grdXuatHang.Name = "grdXuatHang";
            this.grdXuatHang.ReadOnly = true;
            this.grdXuatHang.Size = new System.Drawing.Size(715, 146);
            this.grdXuatHang.TabIndex = 19;
            this.grdXuatHang.CurrentCellChanged += new System.EventHandler(this.grdXuatHang_CurrentCellChanged);
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhi.Location = new System.Drawing.Point(339, 504);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(4);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(84, 32);
            this.btnGhi.TabIndex = 15;
            this.btnGhi.Text = "Ghi (&G)";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnHoan
            // 
            this.btnHoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoan.Image = ((System.Drawing.Image)(resources.GetObject("btnHoan.Image")));
            this.btnHoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoan.Location = new System.Drawing.Point(431, 504);
            this.btnHoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoan.Name = "btnHoan";
            this.btnHoan.Size = new System.Drawing.Size(98, 32);
            this.btnHoan.TabIndex = 16;
            this.btnHoan.Text = "Hoãn (&H)";
            this.btnHoan.UseVisualStyleBackColor = true;
            this.btnHoan.Click += new System.EventHandler(this.btnHoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(677, 504);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 32);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát (&T)";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtThue
            // 
            this.txtThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThue.Location = new System.Drawing.Point(505, 65);
            this.txtThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(182, 26);
            this.txtThue.TabIndex = 10;
            this.txtThue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thuế";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(505, 113);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(182, 26);
            this.txtTongTien.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tổng tiền";
            // 
            // btnInHD
            // 
            this.btnInHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHD.Location = new System.Drawing.Point(538, 504);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(132, 32);
            this.btnInHD.TabIndex = 17;
            this.btnInHD.Text = "In hóa đơn (&I)";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(11, 504);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 32);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm (&M)";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(129, 504);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 32);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa (&S)";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(237, 504);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 32);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa (&X)";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaH
            // 
            this.txtMaH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaH.Location = new System.Drawing.Point(855, 173);
            this.txtMaH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaH.Name = "txtMaH";
            this.txtMaH.Size = new System.Drawing.Size(42, 26);
            this.txtMaH.TabIndex = 27;
            this.txtMaH.Visible = false;
            // 
            // groupHoaDonXuat
            // 
            this.groupHoaDonXuat.Controls.Add(this.txtGhiChu);
            this.groupHoaDonXuat.Controls.Add(this.label1);
            this.groupHoaDonXuat.Controls.Add(this.pckNgayXuat);
            this.groupHoaDonXuat.Controls.Add(this.btnXuatHang);
            this.groupHoaDonXuat.Controls.Add(this.cboMaNhanVien);
            this.groupHoaDonXuat.Controls.Add(this.lblNgayXuat);
            this.groupHoaDonXuat.Controls.Add(this.txtMaHD);
            this.groupHoaDonXuat.Controls.Add(this.lblMaHD);
            this.groupHoaDonXuat.Controls.Add(this.lblMaNhanVien);
            this.groupHoaDonXuat.Location = new System.Drawing.Point(40, 12);
            this.groupHoaDonXuat.Name = "groupHoaDonXuat";
            this.groupHoaDonXuat.Size = new System.Drawing.Size(735, 154);
            this.groupHoaDonXuat.TabIndex = 28;
            this.groupHoaDonXuat.TabStop = false;
            // 
            // groupChiTietHDX
            // 
            this.groupChiTietHDX.Controls.Add(this.label4);
            this.groupChiTietHDX.Controls.Add(this.txtTongTien);
            this.groupChiTietHDX.Controls.Add(this.label3);
            this.groupChiTietHDX.Controls.Add(this.txtThue);
            this.groupChiTietHDX.Controls.Add(this.label2);
            this.groupChiTietHDX.Controls.Add(this.txtDonViTinh);
            this.groupChiTietHDX.Controls.Add(this.lblDonViTinh);
            this.groupChiTietHDX.Controls.Add(this.txtDonGia);
            this.groupChiTietHDX.Controls.Add(this.lblDonGia);
            this.groupChiTietHDX.Controls.Add(this.txtSoLuong);
            this.groupChiTietHDX.Controls.Add(this.lblSoLuong);
            this.groupChiTietHDX.Controls.Add(this.cboMaMatH);
            this.groupChiTietHDX.Controls.Add(this.lblMaMatH);
            this.groupChiTietHDX.Location = new System.Drawing.Point(40, 172);
            this.groupChiTietHDX.Name = "groupChiTietHDX";
            this.groupChiTietHDX.Size = new System.Drawing.Size(736, 150);
            this.groupChiTietHDX.TabIndex = 29;
            this.groupChiTietHDX.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "label4";
            // 
            // frmXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(806, 564);
            this.Controls.Add(this.groupChiTietHDX);
            this.Controls.Add(this.groupHoaDonXuat);
            this.Controls.Add(this.txtMaH);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoan);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.grdXuatHang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất hàng";
            this.Load += new System.EventHandler(this.frmXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdXuatHang)).EndInit();
            this.groupHoaDonXuat.ResumeLayout(false);
            this.groupHoaDonXuat.PerformLayout();
            this.groupChiTietHDX.ResumeLayout(false);
            this.groupChiTietHDX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMatH;
        private System.Windows.Forms.ComboBox cboMaMatH;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.ComboBox cboMaNhanVien;

        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.DateTimePicker pckNgayXuat;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdXuatHang;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaH;
        private System.Windows.Forms.GroupBox groupHoaDonXuat;
        private System.Windows.Forms.GroupBox groupChiTietHDX;
        private System.Windows.Forms.Label label4;
    }
}