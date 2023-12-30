namespace QLKTX
{
    partial class frmDanhGiaSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDanhSach = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPhong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbKTX = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbDay = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbHocKi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThemHocKi = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblGioiTinh = new DevComponents.DotNetBar.LabelX();
            this.btnDanhGia = new DevComponents.DotNetBar.ButtonX();
            this.lblDay = new DevComponents.DotNetBar.LabelX();
            this.lblKTX = new DevComponents.DotNetBar.LabelX();
            this.lblPhong = new DevComponents.DotNetBar.LabelX();
            this.lblHoTen = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.lblMa = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTieuCuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTichCuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThemDanhGia = new DevComponents.DotNetBar.ButtonX();
            this.cmbDanhGia = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(605, 53);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Đánh giá Sinh viên";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(7, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sinh viên";
            // 
            // dtDanhSach
            // 
            this.dtDanhSach.AllowUserToAddRows = false;
            this.dtDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHoTen,
            this.colPhong,
            this.colDay,
            this.ColKTX});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDanhSach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtDanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtDanhSach.Location = new System.Drawing.Point(7, 19);
            this.dtDanhSach.Name = "dtDanhSach";
            this.dtDanhSach.RowHeadersWidth = 20;
            this.dtDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDanhSach.Size = new System.Drawing.Size(282, 191);
            this.dtDanhSach.TabIndex = 0;
            this.dtDanhSach.SelectionChanged += new System.EventHandler(this.dtDanhSach_SelectionChanged);
            this.dtDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDanhSach_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPhong);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.cmbKTX);
            this.groupBox2.Controls.Add(this.cmbDay);
            this.groupBox2.Controls.Add(this.labelX10);
            this.groupBox2.Controls.Add(this.cmbNamHoc);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.cmbHocKi);
            this.groupBox2.Controls.Add(this.btnThemHocKi);
            this.groupBox2.Controls.Add(this.labelX14);
            this.groupBox2.Controls.Add(this.labelX13);
            this.groupBox2.Controls.Add(this.labelX12);
            this.groupBox2.Controls.Add(this.labelX11);
            this.groupBox2.Location = new System.Drawing.Point(8, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm";
            // 
            // cmbPhong
            // 
            this.cmbPhong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPhong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPhong.DisplayMember = "Text";
            this.cmbPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cmbPhong.Location = new System.Drawing.Point(45, 92);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(100, 21);
            this.cmbPhong.TabIndex = 5;
            this.cmbPhong.SelectionChangeCommitted += new System.EventHandler(this.cmbPhong_SelectionChangeCommitted);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "comboItem1";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "comboItem2";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "comboItem3";
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Location = new System.Drawing.Point(45, 14);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 11;
            this.txtTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxX1_KeyDown);
            // 
            // cmbKTX
            // 
            this.cmbKTX.DisplayMember = "Text";
            this.cmbKTX.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKTX.FormattingEnabled = true;
            this.cmbKTX.Location = new System.Drawing.Point(45, 40);
            this.cmbKTX.Name = "cmbKTX";
            this.cmbKTX.Size = new System.Drawing.Size(100, 21);
            this.cmbKTX.TabIndex = 10;
            this.cmbKTX.SelectionChangeCommitted += new System.EventHandler(this.cmbKTX_SelectionChangeCommitted);
            // 
            // cmbDay
            // 
            this.cmbDay.DisplayMember = "Text";
            this.cmbDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(45, 66);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(100, 21);
            this.cmbDay.TabIndex = 10;
            this.cmbDay.SelectionChangeCommitted += new System.EventHandler(this.cmbDay_SelectionChangeCommitted);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Location = new System.Drawing.Point(153, 14);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(47, 17);
            this.labelX10.TabIndex = 3;
            this.labelX10.Text = "Năm học:";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(151, 40);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(138, 21);
            this.cmbNamHoc.TabIndex = 7;
            this.cmbNamHoc.SelectionChangeCommitted += new System.EventHandler(this.cmbNamHoc_SelectionChangeCommitted);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(153, 66);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(47, 17);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Học kỳ:";
            // 
            // cmbHocKi
            // 
            this.cmbHocKi.DisplayMember = "Text";
            this.cmbHocKi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocKi.FormattingEnabled = true;
            this.cmbHocKi.Location = new System.Drawing.Point(151, 92);
            this.cmbHocKi.Name = "cmbHocKi";
            this.cmbHocKi.Size = new System.Drawing.Size(138, 21);
            this.cmbHocKi.TabIndex = 7;
            this.cmbHocKi.SelectionChangeCommitted += new System.EventHandler(this.cmbHocKi_SelectionChangeCommitted);
            // 
            // btnThemHocKi
            // 
            this.btnThemHocKi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemHocKi.Location = new System.Drawing.Point(265, 66);
            this.btnThemHocKi.Name = "btnThemHocKi";
            this.btnThemHocKi.Size = new System.Drawing.Size(24, 23);
            this.btnThemHocKi.TabIndex = 8;
            this.btnThemHocKi.Text = "<b>...</b>";
            this.btnThemHocKi.Tooltip = "Thêm bảng đánh giá";
            this.btnThemHocKi.Click += new System.EventHandler(this.btnThemHocKi_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblGioiTinh);
            this.groupPanel1.Controls.Add(this.btnDanhGia);
            this.groupPanel1.Controls.Add(this.lblDay);
            this.groupPanel1.Controls.Add(this.lblKTX);
            this.groupPanel1.Controls.Add(this.lblPhong);
            this.groupPanel1.Controls.Add(this.lblHoTen);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.lblMa);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.groupBox5);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.groupBox4);
            this.groupPanel1.Controls.Add(this.groupBox3);
            this.groupPanel1.Controls.Add(this.btnThemDanhGia);
            this.groupPanel1.Controls.Add(this.cmbDanhGia);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Location = new System.Drawing.Point(307, 58);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(316, 334);
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
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Thông tin Sinh viên";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Red;
            this.lblGioiTinh.Location = new System.Drawing.Point(269, 26);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(38, 17);
            this.lblGioiTinh.TabIndex = 19;
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            //this.btnDanhGia.Image = global::QLKTX.Properties.Resources.DanhMuc32;
            this.btnDanhGia.Location = new System.Drawing.Point(213, 81);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(89, 30);
            this.btnDanhGia.TabIndex = 9;
            this.btnDanhGia.Text = "Đánh giá";
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblDay.Location = new System.Drawing.Point(232, 47);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(80, 17);
            this.lblDay.TabIndex = 19;
            // 
            // lblKTX
            // 
            this.lblKTX.BackColor = System.Drawing.Color.Transparent;
            this.lblKTX.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblKTX.Location = new System.Drawing.Point(65, 65);
            this.lblKTX.Name = "lblKTX";
            this.lblKTX.Size = new System.Drawing.Size(80, 17);
            this.lblKTX.TabIndex = 19;
            // 
            // lblPhong
            // 
            this.lblPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblPhong.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblPhong.Location = new System.Drawing.Point(65, 47);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(80, 17);
            this.lblPhong.TabIndex = 19;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblHoTen.Location = new System.Drawing.Point(56, 26);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(161, 15);
            this.lblHoTen.TabIndex = 15;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(223, 26);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(54, 17);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "Giới tình:";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(188, 47);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(47, 17);
            this.labelX9.TabIndex = 12;
            this.labelX9.Text = "Dãy:";
            // 
            // lblMa
            // 
            this.lblMa.BackColor = System.Drawing.Color.Transparent;
            this.lblMa.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblMa.Location = new System.Drawing.Point(65, 3);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(75, 19);
            this.lblMa.TabIndex = 14;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(17, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(47, 17);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "KTX:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.txtGhiChu);
            this.groupBox5.Location = new System.Drawing.Point(6, 211);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 91);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            // 
            // 
            // 
            this.txtGhiChu.Border.Class = "TextBoxBorder";
            this.txtGhiChu.Location = new System.Drawing.Point(11, 19);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(273, 66);
            this.txtGhiChu.TabIndex = 0;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(17, 47);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(47, 17);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "Phòng:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtTieuCuc);
            this.groupBox4.Location = new System.Drawing.Point(156, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 88);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiêu cực:";
            // 
            // txtTieuCuc
            // 
            // 
            // 
            // 
            this.txtTieuCuc.Border.Class = "TextBoxBorder";
            this.txtTieuCuc.Location = new System.Drawing.Point(6, 19);
            this.txtTieuCuc.Name = "txtTieuCuc";
            this.txtTieuCuc.Size = new System.Drawing.Size(128, 63);
            this.txtTieuCuc.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtTichCuc);
            this.groupBox3.Location = new System.Drawing.Point(3, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 88);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tích cực:";
            // 
            // txtTichCuc
            // 
            // 
            // 
            // 
            this.txtTichCuc.Border.Class = "TextBoxBorder";
            this.txtTichCuc.Location = new System.Drawing.Point(9, 18);
            this.txtTichCuc.Name = "txtTichCuc";
            this.txtTichCuc.Size = new System.Drawing.Size(132, 63);
            this.txtTichCuc.TabIndex = 0;
            // 
            // btnThemDanhGia
            // 
            this.btnThemDanhGia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemDanhGia.Location = new System.Drawing.Point(182, 88);
            this.btnThemDanhGia.Name = "btnThemDanhGia";
            this.btnThemDanhGia.Size = new System.Drawing.Size(24, 23);
            this.btnThemDanhGia.TabIndex = 8;
            this.btnThemDanhGia.Text = "<b>...</b>";
            this.btnThemDanhGia.Tooltip = "Thêm bảng đánh giá";
            this.btnThemDanhGia.Click += new System.EventHandler(this.btnThemDanhGia_Click);
            // 
            // cmbDanhGia
            // 
            this.cmbDanhGia.DisplayMember = "Text";
            this.cmbDanhGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDanhGia.FormattingEnabled = true;
            this.cmbDanhGia.Location = new System.Drawing.Point(83, 88);
            this.cmbDanhGia.Name = "cmbDanhGia";
            this.cmbDanhGia.Size = new System.Drawing.Size(94, 21);
            this.cmbDanhGia.TabIndex = 7;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(17, 88);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(51, 23);
            this.labelX8.TabIndex = 6;
            this.labelX8.Text = "Đánh giá:";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(17, 3);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(47, 19);
            this.labelX7.TabIndex = 5;
            this.labelX7.Text = "Mã KTX:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(17, 26);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(51, 15);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Họ tên:";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Location = new System.Drawing.Point(7, 14);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(54, 23);
            this.labelX11.TabIndex = 12;
            this.labelX11.Text = "Tên:";
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            this.labelX12.Location = new System.Drawing.Point(7, 40);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(54, 23);
            this.labelX12.TabIndex = 13;
            this.labelX12.Text = "KTX:";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            this.labelX13.Location = new System.Drawing.Point(7, 92);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(54, 23);
            this.labelX13.TabIndex = 14;
            this.labelX13.Text = "Phòng:";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            this.labelX14.Location = new System.Drawing.Point(7, 66);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(54, 23);
            this.labelX14.TabIndex = 15;
            this.labelX14.Text = "Dãy:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 165;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENPHG";
            this.dataGridViewTextBoxColumn2.HeaderText = "Phòng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENDAY";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dãy";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENKTX";
            this.dataGridViewTextBoxColumn4.HeaderText = "KTX";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HOTEN";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHoTen.Width = 130;
            // 
            // colPhong
            // 
            this.colPhong.DataPropertyName = "TENPHG";
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            this.colPhong.Width = 60;
            // 
            // colDay
            // 
            this.colDay.DataPropertyName = "TENDAY";
            this.colDay.HeaderText = "Dãy";
            this.colDay.Name = "colDay";
            this.colDay.ReadOnly = true;
            this.colDay.Width = 60;
            // 
            // ColKTX
            // 
            this.ColKTX.DataPropertyName = "TENKTX";
            this.ColKTX.HeaderText = "KTX";
            this.ColKTX.Name = "ColKTX";
            this.ColKTX.Width = 80;
            // 
            // frmDanhGiaSinhVien
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(629, 396);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelX1);
            this.Name = "frmDanhGiaSinhVien";
            this.Text = "Đánh gia Sinh viên";
            this.Load += new System.EventHandler(this.frmDanhGiaSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnThemDanhGia;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDanhGia;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX btnDanhGia;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtDanhSach;
        private DevComponents.DotNetBar.LabelX lblPhong;
        private DevComponents.DotNetBar.LabelX lblHoTen;
        private DevComponents.DotNetBar.LabelX lblMa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPhong;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDay;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKTX;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevComponents.DotNetBar.ButtonX btnThemHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKTX;
        private DevComponents.DotNetBar.LabelX lblDay;
        private DevComponents.DotNetBar.LabelX lblKTX;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lblGioiTinh;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhiChu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTieuCuc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTichCuc;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX11;
    }
}