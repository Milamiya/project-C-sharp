namespace QuanLyThuVien
{
    partial class frmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxtensach = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btndel = new DevComponents.DotNetBar.ButtonX();
            this.btninsert = new DevComponents.DotNetBar.ButtonX();
            this.lblChuaCoMa = new DevComponents.DotNetBar.LabelX();
            this.lblCoMa = new DevComponents.DotNetBar.LabelX();
            this.lblTong = new DevComponents.DotNetBar.LabelX();
            this.txtmasach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxmadausach = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclear = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxtensach);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.lblChuaCoMa);
            this.groupBox1.Controls.Add(this.lblCoMa);
            this.groupBox1.Controls.Add(this.lblTong);
            this.groupBox1.Controls.Add(this.txtmasach);
            this.groupBox1.Controls.Add(this.cbxmadausach);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxtensach
            // 
            this.cbxtensach.DisplayMember = "Text";
            this.cbxtensach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxtensach.FormattingEnabled = true;
            this.cbxtensach.ItemHeight = 14;
            this.cbxtensach.Location = new System.Drawing.Point(104, 28);
            this.cbxtensach.Name = "cbxtensach";
            this.cbxtensach.Size = new System.Drawing.Size(176, 20);
            this.cbxtensach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxtensach.TabIndex = 1;
            this.cbxtensach.Text = "Chọn Tên Sách";
            this.cbxtensach.WatermarkText = "Tên Sách";
            this.cbxtensach.SelectedIndexChanged += new System.EventHandler(this.cbxtensach_SelectedIndexChanged_1);
            // 
            // btndel
            // 
            this.btndel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = ((System.Drawing.Image)(resources.GetObject("btndel.Image")));
            this.btndel.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btndel.Location = new System.Drawing.Point(360, 163);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(58, 44);
            this.btndel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndel.TabIndex = 6;
            this.btndel.Tooltip = "Xóa Sách.";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btninsert
            // 
            this.btninsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btninsert.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Image = global::QuanLyThuVien.Properties.Resources.add1_;
            this.btninsert.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btninsert.Location = new System.Drawing.Point(190, 162);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(58, 45);
            this.btninsert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btninsert.TabIndex = 5;
            this.btninsert.Tooltip = "Thêm Sách.";
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lblChuaCoMa
            // 
            // 
            // 
            // 
            this.lblChuaCoMa.BackgroundStyle.Class = "";
            this.lblChuaCoMa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblChuaCoMa.Location = new System.Drawing.Point(408, 119);
            this.lblChuaCoMa.Name = "lblChuaCoMa";
            this.lblChuaCoMa.Size = new System.Drawing.Size(36, 23);
            this.lblChuaCoMa.TabIndex = 11;
            this.lblChuaCoMa.Click += new System.EventHandler(this.labelX9_Click);
            // 
            // lblCoMa
            // 
            // 
            // 
            // 
            this.lblCoMa.BackgroundStyle.Class = "";
            this.lblCoMa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCoMa.Location = new System.Drawing.Point(392, 72);
            this.lblCoMa.Name = "lblCoMa";
            this.lblCoMa.Size = new System.Drawing.Size(41, 23);
            this.lblCoMa.TabIndex = 10;
            // 
            // lblTong
            // 
            // 
            // 
            // 
            this.lblTong.BackgroundStyle.Class = "";
            this.lblTong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTong.Location = new System.Drawing.Point(392, 28);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(41, 23);
            this.lblTong.TabIndex = 9;
            this.lblTong.Click += new System.EventHandler(this.labelX7_Click);
            // 
            // txtmasach
            // 
            // 
            // 
            // 
            this.txtmasach.Border.Class = "TextBoxBorder";
            this.txtmasach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmasach.Location = new System.Drawing.Point(104, 122);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.ReadOnly = true;
            this.txtmasach.Size = new System.Drawing.Size(121, 20);
            this.txtmasach.TabIndex = 3;
            this.txtmasach.WatermarkText = "Mã Sách";
            // 
            // cbxmadausach
            // 
            this.cbxmadausach.DisplayMember = "Text";
            this.cbxmadausach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxmadausach.FormattingEnabled = true;
            this.cbxmadausach.ItemHeight = 14;
            this.cbxmadausach.Location = new System.Drawing.Point(104, 75);
            this.cbxmadausach.Name = "cbxmadausach";
            this.cbxmadausach.Size = new System.Drawing.Size(157, 20);
            this.cbxmadausach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxmadausach.TabIndex = 2;
            this.cbxmadausach.WatermarkText = "Mã Đầu Sách";
            this.cbxmadausach.SelectedIndexChanged += new System.EventHandler(this.cbxmadausach_SelectedIndexChanged);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(306, 119);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(97, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Sách Chưa Có Mã:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(306, 72);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(97, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Sách Đã Có Mã:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(306, 28);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(83, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Tổng Số Lượng:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 119);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Mã Sách:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 72);
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
            this.labelX1.Location = new System.Drawing.Point(11, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tên Sách:";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Location = new System.Drawing.Point(1, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(464, 198);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenSach";
            this.Column1.HeaderText = "Tên Sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDauSach";
            this.Column2.HeaderText = "Mã Đầu Sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaSach";
            this.Column3.HeaderText = "Mã Sách";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btnclear
            // 
            this.btnclear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclear.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Transparent;
            this.btnclear.Image = global::QuanLyThuVien.Properties.Resources.edit_clear;
            this.btnclear.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnclear.Location = new System.Drawing.Point(34, 168);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(52, 39);
            this.btnclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclear.TabIndex = 4;
            this.btnclear.Tooltip = "Làm Mới.";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSach_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmasach;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxmadausach;
        private DevComponents.DotNetBar.LabelX lblTong;
        private DevComponents.DotNetBar.LabelX lblChuaCoMa;
        private DevComponents.DotNetBar.LabelX lblCoMa;
        private DevComponents.DotNetBar.ButtonX btndel;
        private DevComponents.DotNetBar.ButtonX btninsert;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxtensach;
        private DevComponents.DotNetBar.ButtonX btnclear;
    }
}