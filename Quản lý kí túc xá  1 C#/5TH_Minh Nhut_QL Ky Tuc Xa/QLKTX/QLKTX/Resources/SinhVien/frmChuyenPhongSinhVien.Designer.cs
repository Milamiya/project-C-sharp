namespace QLKTX
{
    partial class frmChuyenPhongSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPhongDen = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbPhongDen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKTXDen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtPhongDi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbPhongDi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKTXDi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhongDen)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhongDi)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPhongDen);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.cmbPhongDen);
            this.groupBox1.Controls.Add(this.cmbKTXDen);
            this.groupBox1.Location = new System.Drawing.Point(343, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng đến";
            // 
            // dtPhongDen
            // 
            this.dtPhongDen.AllowUserToAddRows = false;
            this.dtPhongDen.AllowUserToDeleteRows = false;
            this.dtPhongDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhongDen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPhongDen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtPhongDen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtPhongDen.Location = new System.Drawing.Point(13, 80);
            this.dtPhongDen.MultiSelect = false;
            this.dtPhongDen.Name = "dtPhongDen";
            this.dtPhongDen.RowHeadersWidth = 15;
            this.dtPhongDen.Size = new System.Drawing.Size(250, 201);
            this.dtPhongDen.TabIndex = 5;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Họ tên";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Lớp";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(41, 40);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 4;
            this.labelX6.Text = "Tên phòng:";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(41, 14);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(49, 21);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Tên KTX:";
            // 
            // cmbPhongDen
            // 
            this.cmbPhongDen.DisplayMember = "Text";
            this.cmbPhongDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhongDen.FormattingEnabled = true;
            this.cmbPhongDen.Location = new System.Drawing.Point(122, 39);
            this.cmbPhongDen.Name = "cmbPhongDen";
            this.cmbPhongDen.Size = new System.Drawing.Size(121, 21);
            this.cmbPhongDen.TabIndex = 1;
            // 
            // cmbKTXDen
            // 
            this.cmbKTXDen.DisplayMember = "Text";
            this.cmbKTXDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKTXDen.FormattingEnabled = true;
            this.cmbKTXDen.Location = new System.Drawing.Point(122, 13);
            this.cmbKTXDen.Name = "cmbKTXDen";
            this.cmbKTXDen.Size = new System.Drawing.Size(121, 21);
            this.cmbKTXDen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtPhongDi);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.cmbPhongDi);
            this.groupBox2.Controls.Add(this.cmbKTXDi);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 296);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng đi";
            // 
            // dtPhongDi
            // 
            this.dtPhongDi.AllowUserToAddRows = false;
            this.dtPhongDi.AllowUserToDeleteRows = false;
            this.dtPhongDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhongDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPhongDi.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtPhongDi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtPhongDi.Location = new System.Drawing.Point(7, 80);
            this.dtPhongDi.MultiSelect = false;
            this.dtPhongDi.Name = "dtPhongDi";
            this.dtPhongDi.RowHeadersWidth = 15;
            this.dtPhongDi.Size = new System.Drawing.Size(251, 201);
            this.dtPhongDi.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lớp";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(49, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(55, 22);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Tên KTX:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(49, 39);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 24);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tên phòng:";
            // 
            // cmbPhongDi
            // 
            this.cmbPhongDi.DisplayMember = "Text";
            this.cmbPhongDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhongDi.FormattingEnabled = true;
            this.cmbPhongDi.Location = new System.Drawing.Point(125, 41);
            this.cmbPhongDi.Name = "cmbPhongDi";
            this.cmbPhongDi.Size = new System.Drawing.Size(121, 21);
            this.cmbPhongDi.TabIndex = 1;
            // 
            // cmbKTXDi
            // 
            this.cmbKTXDi.DisplayMember = "Text";
            this.cmbKTXDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKTXDi.FormattingEnabled = true;
            this.cmbKTXDi.Location = new System.Drawing.Point(125, 14);
            this.cmbKTXDi.Name = "cmbKTXDi";
            this.cmbKTXDi.Size = new System.Drawing.Size(121, 21);
            this.cmbKTXDi.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(588, 42);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Chuyển phòng";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(288, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 117);
            this.panel1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(49, 117);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QLKTX.Properties.Resources.Next32;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 36);
            this.toolStripButton1.Text = "==>";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::QLKTX.Properties.Resources.Back32;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(47, 36);
            this.toolStripButton2.Text = "<==";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::QLKTX.Properties.Resources.Luu32_1;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(47, 36);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // frmChuyenPhongSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(618, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 390);
            this.MinimumSize = new System.Drawing.Size(626, 390);
            this.Name = "frmChuyenPhongSinhVien";
            this.Text = "Chuyen phong Sinh vien";
            this.Load += new System.EventHandler(this.frmChuyenPhongSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPhongDen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPhongDi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPhongDi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKTXDi;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPhongDen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKTXDen;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtPhongDen;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtPhongDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}