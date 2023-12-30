namespace QuanLyThuVien
{
    partial class frmQLTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTraSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnclear = new DevComponents.DotNetBar.ButtonX();
            this.txtTra = new System.Windows.Forms.MaskedTextBox();
            this.txtMuon = new System.Windows.Forms.MaskedTextBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonX2);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.txtTra);
            this.groupBox1.Controls.Add(this.txtMuon);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX2.Image = global::QuanLyThuVien.Properties.Resources._1301240336_down;
            this.buttonX2.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonX2.Location = new System.Drawing.Point(556, 41);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(39, 38);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 30;
            this.buttonX2.Tooltip = "Trả Sách.";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnclear
            // 
            this.btnclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclear.CausesValidation = false;
            this.btnclear.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Image = global::QuanLyThuVien.Properties.Resources.edit_clear;
            this.btnclear.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnclear.Location = new System.Drawing.Point(503, 41);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(47, 40);
            this.btnclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclear.TabIndex = 25;
            this.btnclear.Tooltip = "Làm Mới.";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtTra
            // 
            this.txtTra.Location = new System.Drawing.Point(365, 114);
            this.txtTra.Mask = "00/00/0000";
            this.txtTra.Name = "txtTra";
            this.txtTra.ReadOnly = true;
            this.txtTra.Size = new System.Drawing.Size(121, 20);
            this.txtTra.TabIndex = 24;
            this.txtTra.ValidatingType = typeof(System.DateTime);
            // 
            // txtMuon
            // 
            this.txtMuon.Location = new System.Drawing.Point(365, 82);
            this.txtMuon.Mask = "00/00/0000";
            this.txtMuon.Name = "txtMuon";
            this.txtMuon.ReadOnly = true;
            this.txtMuon.Size = new System.Drawing.Size(121, 20);
            this.txtMuon.TabIndex = 22;
            this.txtMuon.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(365, 51);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(120, 20);
            this.textBoxX1.TabIndex = 20;
            this.textBoxX1.WatermarkText = "Tên Độc Giả";
            // 
            // cbxMaSach
            // 
            this.cbxMaSach.DisplayMember = "Text";
            this.cbxMaSach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaSach.FormattingEnabled = true;
            this.cbxMaSach.ItemHeight = 14;
            this.cbxMaSach.Location = new System.Drawing.Point(104, 115);
            this.cbxMaSach.Name = "cbxMaSach";
            this.cbxMaSach.Size = new System.Drawing.Size(150, 20);
            this.cbxMaSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMaSach.TabIndex = 16;
            this.cbxMaSach.Text = "Chọn Mã Sách";
            // 
            // cbxMaDS
            // 
            this.cbxMaDS.DisplayMember = "Text";
            this.cbxMaDS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaDS.FormattingEnabled = true;
            this.cbxMaDS.ItemHeight = 14;
            this.cbxMaDS.Location = new System.Drawing.Point(104, 83);
            this.cbxMaDS.Name = "cbxMaDS";
            this.cbxMaDS.Size = new System.Drawing.Size(150, 20);
            this.cbxMaDS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMaDS.TabIndex = 15;
            this.cbxMaDS.Text = "Chọn Mã Đầu Sách";
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.DisplayMember = "Text";
            this.cbxChuyenNganh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxChuyenNganh.FormattingEnabled = true;
            this.cbxChuyenNganh.ItemHeight = 14;
            this.cbxChuyenNganh.Location = new System.Drawing.Point(104, 51);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(150, 20);
            this.cbxChuyenNganh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxChuyenNganh.TabIndex = 12;
            this.cbxChuyenNganh.Text = "Chọn Chuyên Ngành";
            // 
            // cbxMaThe
            // 
            this.cbxMaThe.DisplayMember = "Text";
            this.cbxMaThe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMaThe.FormattingEnabled = true;
            this.cbxMaThe.ItemHeight = 14;
            this.cbxMaThe.Location = new System.Drawing.Point(365, 22);
            this.cbxMaThe.Name = "cbxMaThe";
            this.cbxMaThe.Size = new System.Drawing.Size(121, 20);
            this.cbxMaThe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMaThe.TabIndex = 19;
            this.cbxMaThe.Text = "Chọn Mã Thẻ";
            // 
            // cbxTenSach
            // 
            this.cbxTenSach.DisplayMember = "Text";
            this.cbxTenSach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTenSach.FormattingEnabled = true;
            this.cbxTenSach.ItemHeight = 14;
            this.cbxTenSach.Location = new System.Drawing.Point(104, 22);
            this.cbxTenSach.Name = "cbxTenSach";
            this.cbxTenSach.Size = new System.Drawing.Size(150, 20);
            this.cbxTenSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxTenSach.TabIndex = 10;
            this.cbxTenSach.Text = "Chọn Tên Sách";
            this.cbxTenSach.SelectedIndexChanged += new System.EventHandler(this.cbxTenSach_SelectedIndexChanged);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(281, 112);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 23;
            this.labelX8.Text = "Ngày Trả:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(281, 48);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 21;
            this.labelX7.Text = "Tên Độc Giả:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(281, 22);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(53, 23);
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "Mã Thẻ:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(281, 80);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 17;
            this.labelX5.Text = "Ngày Mượn:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 112);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "Mã Sách:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(6, 48);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(89, 23);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "Chuyên Ngành:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 80);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Mã Đầu Sách:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(6, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(58, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Tên Sách:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Location = new System.Drawing.Point(4, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Sách Đang Mượn";
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
            this.dataGridViewX1.Size = new System.Drawing.Size(595, 194);
            this.dataGridViewX1.TabIndex = 2;
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
            // frmQLTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Trả Sách";
            this.Load += new System.EventHandler(this.frmQLTraSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtTra;
        private System.Windows.Forms.MaskedTextBox txtMuon;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMaSach;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMaDS;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxChuyenNganh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMaThe;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxTenSach;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnclear;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}