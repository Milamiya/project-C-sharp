namespace QuanLyThuVien
{
    partial class frmSearchSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnclear = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbChuyenNganh = new System.Windows.Forms.RadioButton();
            this.rdbTS = new System.Windows.Forms.RadioButton();
            this.rdbNXB = new System.Windows.Forms.RadioButton();
            this.rdbTenTG = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNXB);
            this.groupBox1.Controls.Add(this.rdbTenTG);
            this.groupBox1.Controls.Add(this.rdbTS);
            this.groupBox1.Controls.Add(this.rdbChuyenNganh);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Theo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.highlighter1.SetHighlightOnFocus(this.txtSearch, true);
            this.txtSearch.Location = new System.Drawing.Point(150, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.WatermarkText = "Nhập Dữ Liệu Cần Tìm Kiếm.";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.btnclear.Location = new System.Drawing.Point(360, 32);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(52, 39);
            this.btnclear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclear.TabIndex = 5;
            this.btnclear.Tooltip = "Chọn Lại.";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewX1);
            this.groupBox2.Location = new System.Drawing.Point(4, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tìm Kiếm";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
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
            this.dataGridViewX1.Size = new System.Drawing.Size(452, 197);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDauSach";
            this.Column1.HeaderText = "Mã ĐS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenTG";
            this.Column3.HeaderText = "Tác Giả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenNXB";
            this.Column4.HeaderText = "Nhà Xuất Bản";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NamXuatBan";
            this.Column5.HeaderText = "Năm";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // rdbChuyenNganh
            // 
            this.rdbChuyenNganh.AutoSize = true;
            this.rdbChuyenNganh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbChuyenNganh.Location = new System.Drawing.Point(17, 21);
            this.rdbChuyenNganh.Name = "rdbChuyenNganh";
            this.rdbChuyenNganh.Size = new System.Drawing.Size(108, 17);
            this.rdbChuyenNganh.TabIndex = 18;
            this.rdbChuyenNganh.TabStop = true;
            this.rdbChuyenNganh.Text = "Chuyên Ngành";
            this.rdbChuyenNganh.UseVisualStyleBackColor = true;
            this.rdbChuyenNganh.CheckedChanged += new System.EventHandler(this.rdbChuyenNganh_CheckedChanged);
            // 
            // rdbTS
            // 
            this.rdbTS.AutoSize = true;
            this.rdbTS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbTS.Location = new System.Drawing.Point(17, 51);
            this.rdbTS.Name = "rdbTS";
            this.rdbTS.Size = new System.Drawing.Size(80, 17);
            this.rdbTS.TabIndex = 19;
            this.rdbTS.TabStop = true;
            this.rdbTS.Text = "Tên Sách";
            this.rdbTS.UseVisualStyleBackColor = true;
            this.rdbTS.CheckedChanged += new System.EventHandler(this.rdbTS_CheckedChanged);
            // 
            // rdbNXB
            // 
            this.rdbNXB.AutoSize = true;
            this.rdbNXB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbNXB.Location = new System.Drawing.Point(17, 109);
            this.rdbNXB.Name = "rdbNXB";
            this.rdbNXB.Size = new System.Drawing.Size(104, 17);
            this.rdbNXB.TabIndex = 21;
            this.rdbNXB.TabStop = true;
            this.rdbNXB.Text = "Nhà Xuất Bản";
            this.rdbNXB.UseVisualStyleBackColor = true;
            this.rdbNXB.CheckedChanged += new System.EventHandler(this.rdbNXB_CheckedChanged);
            // 
            // rdbTenTG
            // 
            this.rdbTenTG.AutoSize = true;
            this.rdbTenTG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbTenTG.Location = new System.Drawing.Point(17, 78);
            this.rdbTenTG.Name = "rdbTenTG";
            this.rdbTenTG.Size = new System.Drawing.Size(70, 17);
            this.rdbTenTG.TabIndex = 20;
            this.rdbTenTG.TabStop = true;
            this.rdbTenTG.Text = "Tác Giả";
            this.rdbTenTG.UseVisualStyleBackColor = true;
            this.rdbTenTG.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // frmSearchSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Sách";
            this.Load += new System.EventHandler(this.frmSearchSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnclear;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.RadioButton rdbChuyenNganh;
        private System.Windows.Forms.RadioButton rdbNXB;
        private System.Windows.Forms.RadioButton rdbTenTG;
        private System.Windows.Forms.RadioButton rdbTS;
    }
}