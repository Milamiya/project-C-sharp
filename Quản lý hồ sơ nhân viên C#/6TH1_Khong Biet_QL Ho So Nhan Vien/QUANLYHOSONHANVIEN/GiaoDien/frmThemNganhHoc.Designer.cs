namespace QUANLYHOSONHANVIEN.GiaoDien
{
    partial class frmThemNganhHoc
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
            this.labelX120 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtmangoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttenngoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnLammoi = new DevComponents.DotNetBar.ButtonX();
            this.btnThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.btnCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewNganhHoc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltennh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNganhHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX120
            // 
            this.labelX120.BackColor = System.Drawing.Color.SkyBlue;
            this.labelX120.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX120.Location = new System.Drawing.Point(0, 0);
            this.labelX120.Name = "labelX120";
            this.labelX120.Size = new System.Drawing.Size(452, 21);
            this.labelX120.TabIndex = 103;
            this.labelX120.Text = "Danh Sách Ngành Học";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(26, 37);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(88, 20);
            this.labelX3.TabIndex = 106;
            this.labelX3.Text = "Mã Ngành Học :;";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(26, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 20);
            this.labelX4.TabIndex = 104;
            this.labelX4.Text = "Tên Ngành Học :\r\n";
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
            // btnLammoi
            // 
            this.btnLammoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLammoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLammoi.Location = new System.Drawing.Point(41, 102);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 25);
            this.btnLammoi.TabIndex = 110;
            this.btnLammoi.Text = "Làm Mới";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMoi.Location = new System.Drawing.Point(149, 102);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(70, 25);
            this.btnThemMoi.TabIndex = 111;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhat.Location = new System.Drawing.Point(247, 102);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(71, 25);
            this.btnCapNhat.TabIndex = 112;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(346, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 25);
            this.btnXoa.TabIndex = 113;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.btnCapNhat);
            this.groupPanel1.Controls.Add(this.btnThemMoi);
            this.groupPanel1.Controls.Add(this.btnLammoi);
            this.groupPanel1.Controls.Add(this.txttenngoai);
            this.groupPanel1.Controls.Add(this.txtmangoai);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX120);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(458, 149);
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
            this.groupPanel1.TabIndex = 2;
            // 
            // dataGridViewNganhHoc
            // 
            this.dataGridViewNganhHoc.AllowUserToAddRows = false;
            this.dataGridViewNganhHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNganhHoc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNganhHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmanh,
            this.coltennh});
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
            this.dataGridViewNganhHoc.Location = new System.Drawing.Point(0, 149);
            this.dataGridViewNganhHoc.Name = "dataGridViewNganhHoc";
            this.dataGridViewNganhHoc.Size = new System.Drawing.Size(458, 183);
            this.dataGridViewNganhHoc.TabIndex = 3;
            this.dataGridViewNganhHoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNganhHoc_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "manh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 208;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tennh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Ngành Học";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 207;
            // 
            // colmanh
            // 
            this.colmanh.DataPropertyName = "manh";
            this.colmanh.HeaderText = "Mã Số";
            this.colmanh.Name = "colmanh";
            // 
            // coltennh
            // 
            this.coltennh.DataPropertyName = "tennh";
            this.coltennh.HeaderText = "Tên Ngành Học";
            this.coltennh.Name = "coltennh";
            // 
            // frmThemNganhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 332);
            this.Controls.Add(this.dataGridViewNganhHoc);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmThemNganhHoc";
            this.Text = "Danh Sách Ngành Học";
            this.Load += new System.EventHandler(this.frmThemNganhHoc_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNganhHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevComponents.DotNetBar.LabelX labelX120;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmangoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenngoai;
        private DevComponents.DotNetBar.ButtonX btnLammoi;
        private DevComponents.DotNetBar.ButtonX btnThemMoi;
        private DevComponents.DotNetBar.ButtonX btnCapNhat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltennh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanh;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewNganhHoc;
    }
}