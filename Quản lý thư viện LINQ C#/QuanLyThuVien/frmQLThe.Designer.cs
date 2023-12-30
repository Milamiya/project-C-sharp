namespace QuanLyThuVien
{
    partial class frmQLThe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLThe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mktHan = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.mklNgayCap = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtMaThe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenDG = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxChucVu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxMaDG = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Nhập Mã Thẻ Thư Viện.");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Chọn Tên Độc Giả.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Chọn Mã Độc Giả.");
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
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btndel = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate = new DevComponents.DotNetBar.ButtonX();
            this.btninsert = new DevComponents.DotNetBar.ButtonX();
            this.btnclear = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.mktHan);
            this.groupBox1.Controls.Add(this.mklNgayCap);
            this.groupBox1.Controls.Add(this.txtMaThe);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.cbxChucVu);
            this.groupBox1.Controls.Add(this.cbxMaDG);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(1, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // mktHan
            // 
            // 
            // 
            // 
            this.mktHan.BackgroundStyle.Class = "TextBoxBorder";
            this.mktHan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mktHan.ButtonClear.Visible = true;
            this.mktHan.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.highlighter1.SetHighlightOnFocus(this.mktHan, true);
            this.mktHan.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mktHan.Location = new System.Drawing.Point(354, 96);
            this.mktHan.Mask = "00/00/0000";
            this.mktHan.Name = "mktHan";
            this.mktHan.ReadOnly = true;
            this.mktHan.Size = new System.Drawing.Size(132, 20);
            this.mktHan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mktHan.TabIndex = 6;
            this.mktHan.Text = "";
            this.mktHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mktHan.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mktHan.ValidatingType = typeof(System.DateTime);
            // 
            // mklNgayCap
            // 
            // 
            // 
            // 
            this.mklNgayCap.BackgroundStyle.Class = "TextBoxBorder";
            this.mklNgayCap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mklNgayCap.ButtonClear.Visible = true;
            this.mklNgayCap.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.highlighter1.SetHighlightOnFocus(this.mklNgayCap, true);
            this.mklNgayCap.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mklNgayCap.Location = new System.Drawing.Point(354, 63);
            this.mklNgayCap.Mask = "00/00/0000";
            this.mklNgayCap.Name = "mklNgayCap";
            this.mklNgayCap.ReadOnly = true;
            this.mklNgayCap.Size = new System.Drawing.Size(132, 20);
            this.mklNgayCap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mklNgayCap.TabIndex = 5;
            this.mklNgayCap.Text = "";
            this.mklNgayCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mklNgayCap.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mklNgayCap.ValidatingType = typeof(System.DateTime);
            // 
            // txtMaThe
            // 
            // 
            // 
            // 
            this.txtMaThe.Border.Class = "TextBoxBorder";
            this.txtMaThe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtMaThe, true);
            this.txtMaThe.Location = new System.Drawing.Point(354, 30);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.ReadOnly = true;
            this.txtMaThe.Size = new System.Drawing.Size(132, 20);
            this.txtMaThe.TabIndex = 4;
            this.superValidator1.SetValidator1(this.txtMaThe, this.requiredFieldValidator3);
            this.txtMaThe.WatermarkText = "Nhập Mã Thẻ Thư Viện";
            // 
            // txtTenDG
            // 
            // 
            // 
            // 
            this.txtTenDG.Border.Class = "TextBoxBorder";
            this.txtTenDG.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtTenDG, true);
            this.txtTenDG.Location = new System.Drawing.Point(94, 60);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(132, 20);
            this.txtTenDG.TabIndex = 999;
            this.txtTenDG.WatermarkText = "Tên Độc Giả";
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.DisplayMember = "Text";
            this.cbxChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxChucVu.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxChucVu, true);
            this.cbxChucVu.ItemHeight = 14;
            this.cbxChucVu.Location = new System.Drawing.Point(94, 99);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(132, 20);
            this.cbxChucVu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxChucVu.TabIndex = 3;
            this.cbxChucVu.Text = "Chọn Chức Vụ";
            this.superValidator1.SetValidator1(this.cbxChucVu, this.requiredFieldValidator2);
            this.cbxChucVu.SelectedIndexChanged += new System.EventHandler(this.cbxChucVu_SelectedIndexChanged);
            // 
            // cbxMaDG
            // 
            this.cbxMaDG.DisplayMember = "Text";
            this.cbxMaDG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaDG.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxMaDG, true);
            this.cbxMaDG.ItemHeight = 14;
            this.cbxMaDG.Location = new System.Drawing.Point(94, 27);
            this.cbxMaDG.Name = "cbxMaDG";
            this.cbxMaDG.Size = new System.Drawing.Size(132, 20);
            this.cbxMaDG.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMaDG.TabIndex = 1;
            this.cbxMaDG.Text = "Chọn Mã Độc Giả";
            this.superValidator1.SetValidator1(this.cbxMaDG, this.requiredFieldValidator1);
            this.cbxMaDG.SelectedIndexChanged += new System.EventHandler(this.cbxMaDG_SelectedIndexChanged);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(254, 96);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Hạn:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(254, 60);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Ngày Cấp:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(254, 27);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(98, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Mã Thẻ Thư Viện:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(16, 96);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Chức Vụ:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(16, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên Độc Giả:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã Độc Giả:";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "Chưa Nhập Mã Thẻ Thư Viện.";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Chưa Chọn Tên Độc Giả.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Chưa Chọn Mã Độc Giả.";
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
            this.groupBox2.Location = new System.Drawing.Point(1, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.dataGridViewX1.CausesValidation = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(641, 220);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDG";
            this.Column1.HeaderText = "Mã ĐG";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDG";
            this.Column2.HeaderText = "Tên Độc Giả";
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
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaThe";
            this.Column4.HeaderText = "Mã Thẻ TV";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayCap";
            this.Column5.HeaderText = "Ngày Cấp";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Han";
            this.Column6.HeaderText = "Hạn";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.CausesValidation = false;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX2.Image = global::QuanLyThuVien.Properties.Resources.Symbol_Delete;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonX2.Location = new System.Drawing.Point(579, 138);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(52, 48);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 12;
            this.buttonX2.Tooltip = "Huỷ Bỏ.";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(514, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 50);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 11;
            this.btnSave.Tooltip = "Save.";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndel
            // 
            this.btndel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btndel.Location = new System.Drawing.Point(579, 82);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(58, 44);
            this.btndel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndel.TabIndex = 10;
            this.btndel.Tooltip = "Xóa Thẻ.";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = global::QuanLyThuVien.Properties.Resources.edit;
            this.btnupdate.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnupdate.Location = new System.Drawing.Point(514, 85);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(52, 41);
            this.btnupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Tooltip = "Sửa Thông Tin Thẻ.";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btninsert.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Image = global::QuanLyThuVien.Properties.Resources.add1_;
            this.btninsert.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btninsert.Location = new System.Drawing.Point(579, 30);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(58, 45);
            this.btninsert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btninsert.TabIndex = 8;
            this.btninsert.Tooltip = "Thêm Thẻ Thư Viện.";
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnclear
            // 
            this.btnclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclear.CausesValidation = false;
            this.btnclear.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = global::QuanLyThuVien.Properties.Resources.edit_clear;
            this.btnclear.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnclear.Location = new System.Drawing.Point(514, 30);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(52, 39);
            this.btnclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclear.TabIndex = 7;
            this.btnclear.Tooltip = "Làm Mới.";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmQLThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLThe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thẻ Thư Viện";
            this.Load += new System.EventHandler(this.frmQLThe_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLThe_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaThe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenDG;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxChucVu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMaDG;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mktHan;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mklNgayCap;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btndel;
        private DevComponents.DotNetBar.ButtonX btnupdate;
        private DevComponents.DotNetBar.ButtonX btninsert;
        private DevComponents.DotNetBar.ButtonX btnclear;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}