namespace _20_BanHangSieuThi
{
    partial class DMNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMNhanVien));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnboqua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCongviec = new System.Windows.Forms.Label();
            this.cboMacongviec = new System.Windows.Forms.ComboBox();
            this.mskNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.chkGioitinh = new System.Windows.Forms.CheckBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblTennhanvien = new System.Windows.Forms.Label();
            this.lblManhanvien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator1,
            this.btnLuu,
            this.btnSua,
            this.toolStripSeparator2,
            this.btnXoa,
            this.toolStripSeparator3,
            this.btnboqua,
            this.toolStripSeparator4});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 537);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator1.TabIndex = 51;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 22);
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 22);
            this.btnLuu.Text = "Lưu Dữ Liệu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 22);
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 22);
            this.btnXoa.Text = "Xóa Dữ Liệu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnboqua
            // 
            this.btnboqua.Image = ((System.Drawing.Image)(resources.GetObject("btnboqua.Image")));
            this.btnboqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(118, 22);
            this.btnboqua.Text = "Bỏ Qua Thao Tác";
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(31, 246);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(724, 252);
            this.dgvNhanVien.TabIndex = 74;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblCongviec);
            this.groupBox1.Controls.Add(this.cboMacongviec);
            this.groupBox1.Controls.Add(this.mskNgaysinh);
            this.groupBox1.Controls.Add(this.mskDienthoai);
            this.groupBox1.Controls.Add(this.chkGioitinh);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.txtManhanvien);
            this.groupBox1.Controls.Add(this.lblNgaysinh);
            this.groupBox1.Controls.Add(this.lblDienthoai);
            this.groupBox1.Controls.Add(this.lblDiachi);
            this.groupBox1.Controls.Add(this.lblGioitinh);
            this.groupBox1.Controls.Add(this.lblTennhanvien);
            this.groupBox1.Controls.Add(this.lblManhanvien);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(24, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 143);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // lblCongviec
            // 
            this.lblCongviec.AutoSize = true;
            this.lblCongviec.BackColor = System.Drawing.Color.Transparent;
            this.lblCongviec.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCongviec.ForeColor = System.Drawing.Color.Black;
            this.lblCongviec.Location = new System.Drawing.Point(510, 73);
            this.lblCongviec.Name = "lblCongviec";
            this.lblCongviec.Size = new System.Drawing.Size(61, 14);
            this.lblCongviec.TabIndex = 89;
            this.lblCongviec.Text = "Công việc";
            // 
            // cboMacongviec
            // 
            this.cboMacongviec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboMacongviec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMacongviec.FormattingEnabled = true;
            this.cboMacongviec.Location = new System.Drawing.Point(576, 71);
            this.cboMacongviec.Name = "cboMacongviec";
            this.cboMacongviec.Size = new System.Drawing.Size(134, 22);
            this.cboMacongviec.TabIndex = 88;
            // 
            // mskNgaysinh
            // 
            this.mskNgaysinh.BackColor = System.Drawing.Color.White;
            this.mskNgaysinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskNgaysinh.Location = new System.Drawing.Point(576, 29);
            this.mskNgaysinh.Mask = "00/00/0000";
            this.mskNgaysinh.Name = "mskNgaysinh";
            this.mskNgaysinh.Size = new System.Drawing.Size(134, 20);
            this.mskNgaysinh.TabIndex = 85;
            this.mskNgaysinh.ValidatingType = typeof(System.DateTime);
            this.mskNgaysinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskNgaysinh_KeyUp);
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.BackColor = System.Drawing.Color.White;
            this.mskDienthoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDienthoai.Location = new System.Drawing.Point(334, 71);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(116, 20);
            this.mskDienthoai.TabIndex = 84;
            this.mskDienthoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskDienthoai_KeyUp);
            // 
            // chkGioitinh
            // 
            this.chkGioitinh.AutoSize = true;
            this.chkGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.chkGioitinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkGioitinh.ForeColor = System.Drawing.Color.Black;
            this.chkGioitinh.Location = new System.Drawing.Point(142, 111);
            this.chkGioitinh.Name = "chkGioitinh";
            this.chkGioitinh.Size = new System.Drawing.Size(47, 18);
            this.chkGioitinh.TabIndex = 83;
            this.chkGioitinh.Text = "Nam";
            this.chkGioitinh.UseVisualStyleBackColor = false;
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.Color.White;
            this.txtDiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiachi.Location = new System.Drawing.Point(334, 29);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(116, 20);
            this.txtDiachi.TabIndex = 82;
            this.txtDiachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiachi_KeyUp);
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.BackColor = System.Drawing.Color.White;
            this.txtTennhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTennhanvien.Location = new System.Drawing.Point(98, 71);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(116, 20);
            this.txtTennhanvien.TabIndex = 81;
            this.txtTennhanvien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTennhanvien_KeyUp);
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.BackColor = System.Drawing.Color.White;
            this.txtManhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManhanvien.Location = new System.Drawing.Point(98, 29);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(116, 20);
            this.txtManhanvien.TabIndex = 80;
            this.txtManhanvien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtManhanvien_KeyUp);
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaysinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaysinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaysinh.Location = new System.Drawing.Point(513, 35);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(60, 14);
            this.lblNgaysinh.TabIndex = 79;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.BackColor = System.Drawing.Color.Transparent;
            this.lblDienthoai.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDienthoai.ForeColor = System.Drawing.Color.Black;
            this.lblDienthoai.Location = new System.Drawing.Point(268, 73);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(62, 14);
            this.lblDienthoai.TabIndex = 78;
            this.lblDienthoai.Text = "Điện thoại";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiachi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiachi.ForeColor = System.Drawing.Color.Black;
            this.lblDiachi.Location = new System.Drawing.Point(272, 31);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(43, 14);
            this.lblDiachi.TabIndex = 77;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioitinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioitinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioitinh.Location = new System.Drawing.Point(13, 111);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(53, 14);
            this.lblGioitinh.TabIndex = 76;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblTennhanvien
            // 
            this.lblTennhanvien.AutoSize = true;
            this.lblTennhanvien.BackColor = System.Drawing.Color.Transparent;
            this.lblTennhanvien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTennhanvien.ForeColor = System.Drawing.Color.Black;
            this.lblTennhanvien.Location = new System.Drawing.Point(13, 73);
            this.lblTennhanvien.Name = "lblTennhanvien";
            this.lblTennhanvien.Size = new System.Drawing.Size(84, 14);
            this.lblTennhanvien.TabIndex = 75;
            this.lblTennhanvien.Text = "Tên nhân viên";
            // 
            // lblManhanvien
            // 
            this.lblManhanvien.AutoSize = true;
            this.lblManhanvien.BackColor = System.Drawing.Color.Transparent;
            this.lblManhanvien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblManhanvien.ForeColor = System.Drawing.Color.Black;
            this.lblManhanvien.Location = new System.Drawing.Point(13, 31);
            this.lblManhanvien.Name = "lblManhanvien";
            this.lblManhanvien.Size = new System.Drawing.Size(79, 14);
            this.lblManhanvien.TabIndex = 74;
            this.lblManhanvien.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(280, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 76;
            this.label1.Text = "DANH MỤC NHÂN VIÊN\r\n";
            // 
            // DMNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "DMNhanVien";
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.DMNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnboqua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskNgaysinh;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.CheckBox chkGioitinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblTennhanvien;
        private System.Windows.Forms.Label lblManhanvien;
        private System.Windows.Forms.Label lblCongviec;
        private System.Windows.Forms.ComboBox cboMacongviec;
        private System.Windows.Forms.Label label1;
    }
}