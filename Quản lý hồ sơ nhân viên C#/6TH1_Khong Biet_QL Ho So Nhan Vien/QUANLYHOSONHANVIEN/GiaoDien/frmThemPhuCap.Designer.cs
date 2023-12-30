namespace QUANLYHOSONHANVIEN.GiaoDien
{
    partial class frmThemPhuCap
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
            this.dataGridViewNganhHoc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.btnThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.btnLammoi = new DevComponents.DotNetBar.ButtonX();
            this.txttenngoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmangoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX120 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.diHeSo = new DevComponents.Editors.DoubleInput();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltennh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNganhHoc)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diHeSo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNganhHoc
            // 
            this.dataGridViewNganhHoc.AllowUserToAddRows = false;
            this.dataGridViewNganhHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNganhHoc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNganhHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmanh,
            this.coltennh,
            this.colHeso});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNganhHoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNganhHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNganhHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewNganhHoc.Location = new System.Drawing.Point(0, 179);
            this.dataGridViewNganhHoc.Name = "dataGridViewNganhHoc";
            this.dataGridViewNganhHoc.Size = new System.Drawing.Size(543, 175);
            this.dataGridViewNganhHoc.TabIndex = 9;
            this.dataGridViewNganhHoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNganhHoc_RowEnter);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.diHeSo);
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.btnCapNhat);
            this.groupPanel1.Controls.Add(this.btnThemMoi);
            this.groupPanel1.Controls.Add(this.btnLammoi);
            this.groupPanel1.Controls.Add(this.txttenngoai);
            this.groupPanel1.Controls.Add(this.txtmangoai);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX120);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(543, 179);
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
            this.groupPanel1.TabIndex = 8;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(346, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 25);
            this.btnXoa.TabIndex = 113;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhat.Location = new System.Drawing.Point(247, 129);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(71, 25);
            this.btnCapNhat.TabIndex = 112;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMoi.Location = new System.Drawing.Point(149, 129);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(70, 25);
            this.btnThemMoi.TabIndex = 111;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLammoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLammoi.Location = new System.Drawing.Point(41, 129);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 25);
            this.btnLammoi.TabIndex = 110;
            this.btnLammoi.Text = "Làm Mới";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // txttenngoai
            // 
            // 
            // 
            // 
            this.txttenngoai.Border.Class = "TextBoxBorder";
            this.txttenngoai.Location = new System.Drawing.Point(120, 63);
            this.txttenngoai.Name = "txttenngoai";
            this.txttenngoai.Size = new System.Drawing.Size(284, 20);
            this.txttenngoai.TabIndex = 108;
            this.txttenngoai.TextChanged += new System.EventHandler(this.txttenngoai_TextChanged);
            // 
            // txtmangoai
            // 
            // 
            // 
            // 
            this.txtmangoai.Border.Class = "TextBoxBorder";
            this.txtmangoai.Enabled = false;
            this.txtmangoai.Location = new System.Drawing.Point(120, 37);
            this.txtmangoai.Name = "txtmangoai";
            this.txtmangoai.Size = new System.Drawing.Size(284, 20);
            this.txtmangoai.TabIndex = 109;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(9, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(112, 20);
            this.labelX4.TabIndex = 104;
            this.labelX4.Text = "Tên :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(9, 37);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(105, 20);
            this.labelX3.TabIndex = 106;
            this.labelX3.Text = "Mã Số :";
            // 
            // labelX120
            // 
            this.labelX120.BackColor = System.Drawing.Color.SkyBlue;
            this.labelX120.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX120.Location = new System.Drawing.Point(0, 0);
            this.labelX120.Name = "labelX120";
            this.labelX120.Size = new System.Drawing.Size(537, 21);
            this.labelX120.TabIndex = 103;
            this.labelX120.Text = "Danh Sách Phụ Cấp";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(9, 89);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 20);
            this.labelX1.TabIndex = 104;
            this.labelX1.Text = "Hệ Số :";
            // 
            // diHeSo
            // 
            // 
            // 
            // 
            this.diHeSo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diHeSo.Increment = 1;
            this.diHeSo.Location = new System.Drawing.Point(120, 89);
            this.diHeSo.Name = "diHeSo";
            this.diHeSo.ShowUpDown = true;
            this.diHeSo.Size = new System.Drawing.Size(112, 20);
            this.diHeSo.TabIndex = 114;
            this.diHeSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diHeSo_KeyPress);
            this.diHeSo.Click += new System.EventHandler(this.diHeSo_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mapc";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 167;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenpc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Khen Thưởng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 166;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "heso";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hệ Số";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 167;
            // 
            // colmanh
            // 
            this.colmanh.DataPropertyName = "mapc";
            this.colmanh.HeaderText = "Mã Số";
            this.colmanh.Name = "colmanh";
            // 
            // coltennh
            // 
            this.coltennh.DataPropertyName = "tenpc";
            this.coltennh.HeaderText = "Tên Khen Thưởng";
            this.coltennh.Name = "coltennh";
            // 
            // colHeso
            // 
            this.colHeso.DataPropertyName = "heso";
            this.colHeso.HeaderText = "Hệ Số";
            this.colHeso.Name = "colHeso";
            // 
            // frmThemPhuCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 354);
            this.Controls.Add(this.dataGridViewNganhHoc);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmThemPhuCap";
            this.Text = "Thêm Phụ Cấp";
            this.Load += new System.EventHandler(this.frmThemPhuCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNganhHoc)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diHeSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewNganhHoc;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DoubleInput diHeSo;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnCapNhat;
        private DevComponents.DotNetBar.ButtonX btnThemMoi;
        private DevComponents.DotNetBar.ButtonX btnLammoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenngoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmangoai;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX120;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltennh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}