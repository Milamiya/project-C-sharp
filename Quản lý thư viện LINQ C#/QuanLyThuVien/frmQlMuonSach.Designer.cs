namespace QuanLyThuVien
{
    partial class frmQlMuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQlMuonSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTra = new System.Windows.Forms.MaskedTextBox();
            this.txtMuon = new System.Windows.Forms.MaskedTextBox();
            this.cbxao = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btndel = new DevComponents.DotNetBar.ButtonX();
            this.btnupdate = new DevComponents.DotNetBar.ButtonX();
            this.btninsert = new DevComponents.DotNetBar.ButtonX();
            this.btnclear = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxMaSach = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxMaDS = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxChuyenNganh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxMaThe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxTenSach = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Chưa Chọn Mã Đầu Sách.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTra);
            this.groupBox1.Controls.Add(this.txtMuon);
            this.groupBox1.Controls.Add(this.cbxao);
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.textBoxX1);
            this.groupBox1.Controls.Add(this.cbxMaSach);
            this.groupBox1.Controls.Add(this.cbxMaDS);
            this.groupBox1.Controls.Add(this.cbxChuyenNganh);
            this.groupBox1.Controls.Add(this.cbxMaThe);
            this.groupBox1.Controls.Add(this.cbxTenSach);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.highlighter1.SetHighlightOnFocus(this.groupBox1, true);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Mượn Sách";
            // 
            // txtTra
            // 
            this.highlighter1.SetHighlightOnFocus(this.txtTra, true);
            this.txtTra.Location = new System.Drawing.Point(371, 117);
            this.txtTra.Mask = "00/00/0000";
            this.txtTra.Name = "txtTra";
            this.txtTra.ReadOnly = true;
            this.txtTra.Size = new System.Drawing.Size(121, 20);
            this.txtTra.TabIndex = 8;
            this.txtTra.ValidatingType = typeof(System.DateTime);
            // 
            // txtMuon
            // 
            this.highlighter1.SetHighlightOnFocus(this.txtMuon, true);
            this.txtMuon.Location = new System.Drawing.Point(371, 85);
            this.txtMuon.Mask = "00/00/0000";
            this.txtMuon.Name = "txtMuon";
            this.txtMuon.ReadOnly = true;
            this.txtMuon.Size = new System.Drawing.Size(121, 20);
            this.txtMuon.TabIndex = 7;
            this.txtMuon.ValidatingType = typeof(System.DateTime);
            this.txtMuon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cbxao
            // 
            this.cbxao.DisplayMember = "Text";
            this.cbxao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxao.FormattingEnabled = true;
            this.cbxao.ItemHeight = 14;
            this.cbxao.Location = new System.Drawing.Point(6, 144);
            this.cbxao.Name = "cbxao";
            this.cbxao.Size = new System.Drawing.Size(26, 20);
            this.cbxao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxao.TabIndex = 17;
            this.cbxao.Visible = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX2.Image = global::QuanLyThuVien.Properties.Resources._1301240336_down;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonX2.Location = new System.Drawing.Point(588, 132);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(39, 38);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 15;
            this.buttonX2.Tooltip = "Trả Sách";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnIn.Image = global::QuanLyThuVien.Properties.Resources._1301337343_document_print;
            this.btnIn.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnIn.Location = new System.Drawing.Point(527, 132);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(55, 38);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 14;
            this.btnIn.Tooltip = "In Phiếu Mượn";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btndel
            // 
            this.btndel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndel.CausesValidation = false;
            this.btndel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = global::QuanLyThuVien.Properties.Resources.Open_Folder_Delete;
            this.btndel.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btndel.Location = new System.Drawing.Point(588, 69);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(39, 45);
            this.btndel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndel.TabIndex = 13;
            this.btndel.Tooltip = "Xóa Phiếu Mượn";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = global::QuanLyThuVien.Properties.Resources.edit;
            this.btnupdate.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnupdate.Location = new System.Drawing.Point(527, 80);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(47, 38);
            this.btnupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Tooltip = "Sửa Phiếu Mượn";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btninsert.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Image = global::QuanLyThuVien.Properties.Resources.add1_;
            this.btninsert.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btninsert.Location = new System.Drawing.Point(587, 22);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(47, 41);
            this.btninsert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btninsert.TabIndex = 11;
            this.btninsert.Tooltip = "Mượn Sách";
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnclear
            // 
            this.btnclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclear.CausesValidation = false;
            this.btnclear.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = global::QuanLyThuVien.Properties.Resources.edit_clear;
            this.btnclear.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnclear.Location = new System.Drawing.Point(527, 25);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(47, 40);
            this.btnclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclear.TabIndex = 10;
            this.btnclear.Tooltip = "Làm Mới";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.textBoxX1, true);
            this.textBoxX1.Location = new System.Drawing.Point(371, 54);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(120, 20);
            this.textBoxX1.TabIndex = 6;
            this.textBoxX1.WatermarkText = "Tên Độc Giả";
            // 
            // cbxMaSach
            // 
            this.cbxMaSach.DisplayMember = "Text";
            this.cbxMaSach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaSach.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxMaSach, true);
            this.cbxMaSach.ItemHeight = 14;
            this.cbxMaSach.Location = new System.Drawing.Point(110, 118);
            this.cbxMaSach.Name = "cbxMaSach";
            this.cbxMaSach.Size = new System.Drawing.Size(150, 20);
            this.cbxMaSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMaSach.TabIndex = 4;
            this.cbxMaSach.Text = "Chọn Mã Sách";
            this.cbxMaSach.SelectedIndexChanged += new System.EventHandler(this.cbxMaSach_SelectedIndexChanged);
            // 
            // cbxMaDS
            // 
            this.cbxMaDS.DisplayMember = "Text";
            this.cbxMaDS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaDS.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxMaDS, true);
            this.cbxMaDS.ItemHeight = 14;
            this.cbxMaDS.Location = new System.Drawing.Point(110, 86);
            this.cbxMaDS.Name = "cbxMaDS";
            this.cbxMaDS.Size = new System.Drawing.Size(150, 20);
            this.cbxMaDS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMaDS.TabIndex = 3;
            this.cbxMaDS.Text = "Chọn Mã Đầu Sách";
            this.superValidator1.SetValidator1(this.cbxMaDS, this.requiredFieldValidator5);
            this.cbxMaDS.SelectedIndexChanged += new System.EventHandler(this.cbxMaDS_SelectedIndexChanged);
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.DisplayMember = "Text";
            this.cbxChuyenNganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxChuyenNganh.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxChuyenNganh, true);
            this.cbxChuyenNganh.ItemHeight = 14;
            this.cbxChuyenNganh.Location = new System.Drawing.Point(110, 54);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(150, 20);
            this.cbxChuyenNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxChuyenNganh.TabIndex = 2;
            this.cbxChuyenNganh.Text = "Chọn Chuyên Ngành";
            this.cbxChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cbxChuyenNganh_SelectedIndexChanged);
            // 
            // cbxMaThe
            // 
            this.cbxMaThe.DisplayMember = "Text";
            this.cbxMaThe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaThe.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxMaThe, true);
            this.cbxMaThe.ItemHeight = 14;
            this.cbxMaThe.Location = new System.Drawing.Point(371, 25);
            this.cbxMaThe.Name = "cbxMaThe";
            this.cbxMaThe.Size = new System.Drawing.Size(121, 20);
            this.cbxMaThe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMaThe.TabIndex = 5;
            this.cbxMaThe.Text = "Chọn Mã Thẻ";
            this.cbxMaThe.SelectedIndexChanged += new System.EventHandler(this.cbxMaThe_SelectedIndexChanged);
            // 
            // cbxTenSach
            // 
            this.cbxTenSach.DisplayMember = "Text";
            this.cbxTenSach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTenSach.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cbxTenSach, true);
            this.cbxTenSach.ItemHeight = 14;
            this.cbxTenSach.Location = new System.Drawing.Point(110, 25);
            this.cbxTenSach.Name = "cbxTenSach";
            this.cbxTenSach.Size = new System.Drawing.Size(150, 20);
            this.cbxTenSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxTenSach.TabIndex = 1;
            this.cbxTenSach.Text = "Chọn Tên Sách";
            this.superValidator1.SetValidator1(this.cbxTenSach, this.requiredFieldValidator5);
            this.cbxTenSach.SelectedIndexChanged += new System.EventHandler(this.cbxTenSach_SelectedIndexChanged);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(287, 115);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 7;
            this.labelX8.Text = "Ngày Trả:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(287, 51);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Tên Độc Giả:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(287, 25);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(53, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Mã Thẻ:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(287, 83);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Ngày Mượn:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 115);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Mã Sách:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 51);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(89, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Chuyên Ngành:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 83);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mã Đầu Sách:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(58, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên Sách:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Location = new System.Drawing.Point(2, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
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
            this.dataGridViewX1.Size = new System.Drawing.Size(628, 221);
            this.dataGridViewX1.TabIndex = 1;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSach";
            this.Column1.HeaderText = "Tên Sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChuyenNganh";
            this.Column3.HeaderText = "Chuyên Ngành";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaDauSach";
            this.Column4.HeaderText = "Mã ĐS";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaSach";
            this.Column5.HeaderText = "Mã Sách";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaThe";
            this.Column6.HeaderText = "Mã Thẻ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenDG";
            this.Column7.HeaderText = "Tên Độc Giả";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayMuon";
            this.Column8.HeaderText = "Ngày Mượn";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NgayTra";
            this.Column9.HeaderText = "Ngày Trả";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "Chưa Chọn Mã Đầu Sách.";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // frmQlMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQlMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mượn Sách";
            this.Load += new System.EventHandler(this.frmQlMuonSach_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQlMuonSach_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxTenSach;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMaSach;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMaDS;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxChuyenNganh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMaThe;
        private DevComponents.DotNetBar.ButtonX btndel;
        private DevComponents.DotNetBar.ButtonX btnupdate;
        private DevComponents.DotNetBar.ButtonX btninsert;
        private DevComponents.DotNetBar.ButtonX btnclear;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxao;
        private System.Windows.Forms.MaskedTextBox txtMuon;
        private System.Windows.Forms.MaskedTextBox txtTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;


    }
}