namespace QLKTX.Phong
{
    partial class frmXepLoai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataDSXepLoai = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnBoQua = new DevComponents.DotNetBar.ButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtDiemCanDuoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiemCanTren = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanTren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanDuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSXepLoai)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(328, 324);
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dataDSXepLoai);
            this.panel2.Controls.Add(this.ribbonBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 162);
            this.panel2.TabIndex = 1;
            // 
            // dataDSXepLoai
            // 
            this.dataDSXepLoai.AllowUserToAddRows = false;
            this.dataDSXepLoai.AllowUserToDeleteRows = false;
            this.dataDSXepLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSXepLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colCanTren,
            this.colCanDuoi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDSXepLoai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDSXepLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDSXepLoai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataDSXepLoai.Location = new System.Drawing.Point(0, 35);
            this.dataDSXepLoai.MultiSelect = false;
            this.dataDSXepLoai.Name = "dataDSXepLoai";
            this.dataDSXepLoai.ReadOnly = true;
            this.dataDSXepLoai.RowHeadersWidth = 20;
            this.dataDSXepLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDSXepLoai.Size = new System.Drawing.Size(322, 127);
            this.dataDSXepLoai.TabIndex = 1;
            this.dataDSXepLoai.SelectionChanged += new System.EventHandler(this.dataDSXepLoai_SelectionChanged);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnBoQua});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(322, 35);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            this.ribbonBar1.TitleVisible = false;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLKTX.Properties.Resources.Them32_1;
            this.btnThem.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnThem.ImagePaddingHorizontal = 8;
            this.btnThem.Name = "btnThem";
            this.btnThem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.btnThem.SubItemsExpandWidth = 14;
            this.btnThem.Text = "y";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLKTX.Properties.Resources.Xoa32_1;
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnXoa.ImagePaddingHorizontal = 8;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.btnXoa.SubItemsExpandWidth = 14;
            this.btnXoa.Text = "y";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLKTX.Properties.Resources.DanhMuc32;
            this.btnSua.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnSua.ImagePaddingHorizontal = 8;
            this.btnSua.Name = "btnSua";
            this.btnSua.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.btnSua.SubItemsExpandWidth = 14;
            this.btnSua.Text = "y";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = global::QLKTX.Properties.Resources.Luu32_1;
            this.btnLuu.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnLuu.ImagePaddingHorizontal = 8;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.SubItemsExpandWidth = 14;
            this.btnLuu.Text = "y";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Image = global::QLKTX.Properties.Resources.Back32;
            this.btnBoQua.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnBoQua.ImagePaddingHorizontal = 8;
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.SubItemsExpandWidth = 14;
            this.btnBoQua.Text = "y";
            this.btnBoQua.Visible = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupPanel2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 156);
            this.panel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtDiemCanDuoi);
            this.groupPanel2.Controls.Add(this.txtDiemCanTren);
            this.groupPanel2.Controls.Add(this.txtMa);
            this.groupPanel2.Controls.Add(this.txtTen);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Location = new System.Drawing.Point(70, 52);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(189, 98);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 1;
            // 
            // txtDiemCanDuoi
            // 
            // 
            // 
            // 
            this.txtDiemCanDuoi.Border.Class = "TextBoxBorder";
            this.txtDiemCanDuoi.Enabled = false;
            this.txtDiemCanDuoi.Location = new System.Drawing.Point(80, 74);
            this.txtDiemCanDuoi.Name = "txtDiemCanDuoi";
            this.txtDiemCanDuoi.Size = new System.Drawing.Size(62, 20);
            this.txtDiemCanDuoi.TabIndex = 7;
            this.txtDiemCanDuoi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiemCanDuoi_KeyUp);
            // 
            // txtDiemCanTren
            // 
            // 
            // 
            // 
            this.txtDiemCanTren.Border.Class = "TextBoxBorder";
            this.txtDiemCanTren.Enabled = false;
            this.txtDiemCanTren.Location = new System.Drawing.Point(80, 51);
            this.txtDiemCanTren.Name = "txtDiemCanTren";
            this.txtDiemCanTren.Size = new System.Drawing.Size(62, 20);
            this.txtDiemCanTren.TabIndex = 6;
            // 
            // txtMa
            // 
            // 
            // 
            // 
            this.txtMa.Border.Class = "TextBoxBorder";
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(80, 5);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(62, 20);
            this.txtMa.TabIndex = 5;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(80, 28);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 4;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(4, 73);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(84, 23);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Điểm cận dưới:";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(4, 27);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Tên Xếp Loại";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(4, 50);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Điểm cận trên:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã số:";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelX1
            // 
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(322, 46);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Xếp Loại";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAXEPLOAI";
            this.dataGridViewTextBoxColumn1.FillWeight = 106.6667F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã xếp loại";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENXEPLOAI";
            this.dataGridViewTextBoxColumn2.FillWeight = 140.6981F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Xếp Loại";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIEMCANTREN";
            this.dataGridViewTextBoxColumn3.FillWeight = 79.59204F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cận Trên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIEMCANDUOI";
            this.dataGridViewTextBoxColumn4.FillWeight = 73.04318F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Cận Dưới";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "MAXEPLOAI";
            this.colMa.FillWeight = 106.6667F;
            this.colMa.HeaderText = "Mã xếp loại";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            this.colMa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMa.Width = 80;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "TENXEPLOAI";
            this.colTen.FillWeight = 140.6981F;
            this.colTen.HeaderText = "Xếp Loại";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCanTren
            // 
            this.colCanTren.DataPropertyName = "DIEMCANTREN";
            this.colCanTren.FillWeight = 79.59204F;
            this.colCanTren.HeaderText = "Cận Trên";
            this.colCanTren.Name = "colCanTren";
            this.colCanTren.ReadOnly = true;
            this.colCanTren.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCanTren.Width = 60;
            // 
            // colCanDuoi
            // 
            this.colCanDuoi.DataPropertyName = "DIEMCANDUOI";
            this.colCanDuoi.FillWeight = 73.04318F;
            this.colCanDuoi.HeaderText = "Cận Dưới";
            this.colCanDuoi.Name = "colCanDuoi";
            this.colCanDuoi.ReadOnly = true;
            this.colCanDuoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCanDuoi.Width = 60;
            // 
            // frmXepLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 324);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmXepLoai";
            this.Text = "frmXepLoai";
            this.Load += new System.EventHandler(this.frmXepLoai_Load);
            this.groupPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSXepLoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiemCanDuoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiemCanTren;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem btnLuu;
        private DevComponents.DotNetBar.ButtonItem btnBoQua;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataDSXepLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanTren;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanDuoi;
    }
}