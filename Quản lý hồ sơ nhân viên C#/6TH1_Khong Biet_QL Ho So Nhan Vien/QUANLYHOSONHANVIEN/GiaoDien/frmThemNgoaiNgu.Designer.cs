namespace QUANLYHOSONHANVIEN.GiaoDien
{
    partial class frmThemNgoaiNgu
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
            this.dataGridViewNgoaingu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colmann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltennn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNgoaingu)).BeginInit();
            this.SuspendLayout();
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
            this.groupPanel1.Size = new System.Drawing.Size(481, 149);
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
            this.groupPanel1.TabIndex = 1;
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
            this.labelX4.Location = new System.Drawing.Point(26, 63);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 20);
            this.labelX4.TabIndex = 104;
            this.labelX4.Text = "Tên Ngoại Ngữ :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(26, 37);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(88, 20);
            this.labelX3.TabIndex = 106;
            this.labelX3.Text = "Mã Ngoại Ngữ :";
            // 
            // labelX120
            // 
            this.labelX120.BackColor = System.Drawing.Color.SkyBlue;
            this.labelX120.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX120.Location = new System.Drawing.Point(0, 0);
            this.labelX120.Name = "labelX120";
            this.labelX120.Size = new System.Drawing.Size(475, 21);
            this.labelX120.TabIndex = 103;
            this.labelX120.Text = "Danh Sách Ngoại Ngữ";
            // 
            // dataGridViewNgoaingu
            // 
            this.dataGridViewNgoaingu.AllowUserToAddRows = false;
            this.dataGridViewNgoaingu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNgoaingu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNgoaingu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNgoaingu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmann,
            this.coltennn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNgoaingu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNgoaingu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNgoaingu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewNgoaingu.Location = new System.Drawing.Point(0, 149);
            this.dataGridViewNgoaingu.Name = "dataGridViewNgoaingu";
            this.dataGridViewNgoaingu.Size = new System.Drawing.Size(481, 223);
            this.dataGridViewNgoaingu.TabIndex = 2;
            this.dataGridViewNgoaingu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNgoaingu_RowEnter);
            // 
            // colmann
            // 
            this.colmann.DataPropertyName = "mann";
            this.colmann.HeaderText = "Mã Số";
            this.colmann.Name = "colmann";
            // 
            // coltennn
            // 
            this.coltennn.DataPropertyName = "tennn";
            this.coltennn.HeaderText = "Tên Ngoại Ngữ";
            this.coltennn.Name = "coltennn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mann";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 219;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tennn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Ngoại Ngữ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 219;
            // 
            // frmThemNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 372);
            this.Controls.Add(this.dataGridViewNgoaingu);
            this.Controls.Add(this.groupPanel1);
            this.Name = "frmThemNgoaiNgu";
            this.Text = "Danh Sách Ngoại Ngữ";
            this.Load += new System.EventHandler(this.frmThemNgoaiNgu_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNgoaingu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnCapNhat;
        private DevComponents.DotNetBar.ButtonX btnThemMoi;
        private DevComponents.DotNetBar.ButtonX btnLammoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenngoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmangoai;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX120;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewNgoaingu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmann;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltennn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}