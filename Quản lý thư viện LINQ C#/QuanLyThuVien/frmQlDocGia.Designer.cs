namespace QuanLyThuVien
{
    partial class frmQlDocGia
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQlDocGia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblTong = new DevComponents.DotNetBar.LabelX();
            this.lblrow = new DevComponents.DotNetBar.LabelX();
            this.btnnext = new DevComponents.DotNetBar.ButtonX();
            this.btnpre = new DevComponents.DotNetBar.ButtonX();
            this.btnfirst = new DevComponents.DotNetBar.ButtonX();
            this.btnLast = new DevComponents.DotNetBar.ButtonX();
            this.mktNgaySinh = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btndel = new DevComponents.DotNetBar.ButtonX();
            this.btnclear = new DevComponents.DotNetBar.ButtonX();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.txtKhoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenDG = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaDG = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxChucVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator7 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Nhập Năm Sinh.");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Chọn Giới Tính.");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Nhập Khoa.");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Nhập Lớp.");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Nhập Tên Độc Giả.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Nhập Mã Độc Giả.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Chọn Chức Vụ.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.groupPanel1);
            this.groupBox1.Controls.Add(this.mktNgaySinh);
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.cbxGioiTinh);
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.cbxChucVu);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Độc Giả";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnAdd.Image = global::QuanLyThuVien.Properties.Resources.add1_;
            this.btnAdd.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnAdd.Location = new System.Drawing.Point(583, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 43);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Tooltip = "Thêm Độc Giả";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnEdit.Image = global::QuanLyThuVien.Properties.Resources.edit;
            this.btnEdit.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnEdit.Location = new System.Drawing.Point(523, 90);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 43);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Tooltip = "Sửa Thông Tin Độc Giả.";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblTong);
            this.groupPanel1.Controls.Add(this.lblrow);
            this.groupPanel1.Controls.Add(this.btnnext);
            this.groupPanel1.Controls.Add(this.btnpre);
            this.groupPanel1.Controls.Add(this.btnfirst);
            this.groupPanel1.Controls.Add(this.btnLast);
            this.groupPanel1.Location = new System.Drawing.Point(116, 192);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(384, 65);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 131;
            this.groupPanel1.Text = "Move";
            // 
            // lblTong
            // 
            // 
            // 
            // 
            this.lblTong.BackgroundStyle.Class = "";
            this.lblTong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTong.Location = new System.Drawing.Point(217, 9);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(53, 23);
            this.lblTong.TabIndex = 5;
            this.lblTong.Text = "labelX10";
            // 
            // lblrow
            // 
            // 
            // 
            // 
            this.lblrow.BackgroundStyle.Class = "";
            this.lblrow.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblrow.Location = new System.Drawing.Point(131, 9);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(35, 23);
            this.lblrow.TabIndex = 4;
            this.lblrow.Text = "0";
            // 
            // btnnext
            // 
            this.btnnext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnext.CausesValidation = false;
            this.btnnext.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnnext.Image = global::QuanLyThuVien.Properties.Resources._1301412273_next;
            this.btnnext.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnnext.Location = new System.Drawing.Point(288, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(28, 38);
            this.btnnext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnext.TabIndex = 3;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnpre
            // 
            this.btnpre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnpre.CausesValidation = false;
            this.btnpre.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnpre.Image = global::QuanLyThuVien.Properties.Resources._1301412276_previous;
            this.btnpre.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnpre.Location = new System.Drawing.Point(70, 3);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(28, 38);
            this.btnpre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnpre.TabIndex = 2;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnfirst.CausesValidation = false;
            this.btnfirst.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnfirst.Image = global::QuanLyThuVien.Properties.Resources._1301412111_start;
            this.btnfirst.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnfirst.Location = new System.Drawing.Point(18, 3);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(28, 38);
            this.btnfirst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnfirst.TabIndex = 1;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLast.CausesValidation = false;
            this.btnLast.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLast.Image = global::QuanLyThuVien.Properties.Resources._1301410046_finish;
            this.btnLast.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnLast.Location = new System.Drawing.Point(338, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(28, 38);
            this.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLast.TabIndex = 0;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // mktNgaySinh
            // 
            // 
            // 
            // 
            this.mktNgaySinh.BackgroundStyle.Class = "TextBoxBorder";
            this.mktNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mktNgaySinh.ButtonClear.Visible = true;
            this.mktNgaySinh.Culture = new System.Globalization.CultureInfo("vi-VN");
            this.mktNgaySinh.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.highlighter1.SetHighlightOnFocus(this.mktNgaySinh, true);
            this.errorProvider1.SetIconAlignment(this.mktNgaySinh, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.mktNgaySinh.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mktNgaySinh.Location = new System.Drawing.Point(336, 68);
            this.mktNgaySinh.Mask = "00/00/0000";
            this.mktNgaySinh.Name = "mktNgaySinh";
            this.mktNgaySinh.ReadOnly = true;
            this.mktNgaySinh.Size = new System.Drawing.Size(142, 20);
            this.mktNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mktNgaySinh.TabIndex = 130;
            this.mktNgaySinh.Text = "";
            this.mktNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mktNgaySinh.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mktNgaySinh.ValidatingType = typeof(System.DateTime);
            this.superValidator1.SetValidator1(this.mktNgaySinh, this.requiredFieldValidator7);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.CausesValidation = false;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX2.Image = global::QuanLyThuVien.Properties.Resources.Symbol_Delete;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonX2.Location = new System.Drawing.Point(583, 143);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(40, 43);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Tooltip = "Huỷ Bỏ";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::QuanLyThuVien.Properties.Resources.save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(523, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 43);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 13;
            this.btnSave.Tooltip = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndel
            // 
            this.btndel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = global::QuanLyThuVien.Properties.Resources.Open_Folder_Delete;
            this.btndel.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btndel.Location = new System.Drawing.Point(584, 88);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(39, 45);
            this.btndel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndel.TabIndex = 12;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnclear
            // 
            this.btnclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclear.CausesValidation = false;
            this.btnclear.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = global::QuanLyThuVien.Properties.Resources.edit_clear;
            this.btnclear.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnclear.Location = new System.Drawing.Point(523, 44);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(47, 40);
            this.btnclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclear.TabIndex = 9;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtGhiChu, true);
            this.txtGhiChu.Location = new System.Drawing.Point(336, 158);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(142, 28);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.WatermarkText = "Ghi Chú";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.DisplayMember = "Text";
            this.cbxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGioiTinh.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxGioiTinh, true);
            this.cbxGioiTinh.ItemHeight = 14;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cbxGioiTinh.Location = new System.Drawing.Point(336, 116);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(144, 20);
            this.cbxGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxGioiTinh.TabIndex = 6;
            this.cbxGioiTinh.Text = "Chọn Giới Tính";
            this.superValidator1.SetValidator1(this.cbxGioiTinh, this.requiredFieldValidator6);
            this.cbxGioiTinh.WatermarkText = "Chọn Chức Vụ";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nam";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Nữ";
            // 
            // txtKhoa
            // 
            // 
            // 
            // 
            this.txtKhoa.Border.Class = "TextBoxBorder";
            this.txtKhoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtKhoa, true);
            this.txtKhoa.Location = new System.Drawing.Point(336, 31);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.Size = new System.Drawing.Size(142, 20);
            this.txtKhoa.TabIndex = 5;
            this.superValidator1.SetValidator1(this.txtKhoa, this.requiredFieldValidator5);
            this.txtKhoa.WatermarkText = "Nhập Khoa";
            // 
            // txtLop
            // 
            // 
            // 
            // 
            this.txtLop.Border.Class = "TextBoxBorder";
            this.txtLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtLop, true);
            this.txtLop.Location = new System.Drawing.Point(94, 158);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(142, 20);
            this.txtLop.TabIndex = 4;
            this.superValidator1.SetValidator1(this.txtLop, this.requiredFieldValidator4);
            this.txtLop.WatermarkText = "Nhập Lớp";
            // 
            // txtTenDG
            // 
            // 
            // 
            // 
            this.txtTenDG.Border.Class = "TextBoxBorder";
            this.txtTenDG.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtTenDG, true);
            this.txtTenDG.Location = new System.Drawing.Point(96, 116);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(142, 20);
            this.txtTenDG.TabIndex = 3;
            this.superValidator1.SetValidator1(this.txtTenDG, this.requiredFieldValidator3);
            this.txtTenDG.WatermarkText = "Nhập Tên Độc Giả";
            // 
            // txtMaDG
            // 
            // 
            // 
            // 
            this.txtMaDG.Border.Class = "";
            this.txtMaDG.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtMaDG, true);
            this.txtMaDG.Location = new System.Drawing.Point(96, 70);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(142, 13);
            this.txtMaDG.TabIndex = 2;
            this.superValidator1.SetValidator1(this.txtMaDG, this.requiredFieldValidator2);
            this.txtMaDG.WatermarkText = "Nhập Mã Độc Giả";
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.DisplayMember = "Text";
            this.cbxChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxChucVu.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxChucVu, true);
            this.cbxChucVu.ItemHeight = 14;
            this.cbxChucVu.Location = new System.Drawing.Point(94, 31);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(144, 20);
            this.cbxChucVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxChucVu.TabIndex = 1;
            this.cbxChucVu.Text = "Chọn Chức Vụ";
            this.superValidator1.SetValidator1(this.cbxChucVu, this.requiredFieldValidator1);
            this.cbxChucVu.WatermarkText = "Chọn Chức Vụ";
            this.cbxChucVu.SelectedIndexChanged += new System.EventHandler(this.cbxChucVu_SelectedIndexChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(267, 116);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(64, 23);
            this.labelX7.TabIndex = 7;
            this.labelX7.Text = "Giới Tính:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(267, 28);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(42, 23);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "Khoa:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(267, 158);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(64, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "Ghi Chú:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(14, 158);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(57, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Lớp:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(14, 116);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 3;
            this.labelX6.Text = "Tên Độc Giả:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(267, 68);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Ngày Sinh:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 68);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 122;
            this.labelX2.Text = "Mã Độc Giả:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(14, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Chức Vụ:";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.ErrorMessage = "Chưa Nhập Năm Sinh.";
            this.requiredFieldValidator7.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "Chưa Chọn Giới Tính.";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "Chưa Nhập Khoa.";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "Chưa Nhập Lớp.";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Chưa Nhập Tên Độc Giả.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Chưa Nhập Mã Độc Giả.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Chưa Chọn Chức Vụ.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Location = new System.Drawing.Point(2, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Độc Giả";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(635, 185);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDG";
            this.Column1.HeaderText = "Mã ĐG";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDG";
            this.Column2.HeaderText = "Tên ĐG";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChucVu";
            this.Column3.HeaderText = "Chức Vụ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Lop";
            this.Column4.HeaderText = "Lớp";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Khoa";
            this.Column5.HeaderText = "Khoa";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgaySinh";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GioiTinh";
            this.Column7.HeaderText = "Giơi Tính";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GhiChu";
            this.Column8.HeaderText = "Ghi Chú";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // frmQlDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQlDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.frmQlDocGia_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQlDocGia_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKhoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDG;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaDG;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxChucVu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxGioiTinh;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btndel;
        private DevComponents.DotNetBar.ButtonX btnclear;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mktNgaySinh;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator7;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnLast;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnfirst;
        private DevComponents.DotNetBar.ButtonX btnnext;
        private DevComponents.DotNetBar.ButtonX btnpre;
        private DevComponents.DotNetBar.LabelX lblTong;
        private DevComponents.DotNetBar.LabelX lblrow;
    }
}