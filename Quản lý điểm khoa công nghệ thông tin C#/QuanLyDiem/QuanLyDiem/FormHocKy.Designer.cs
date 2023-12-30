namespace QuanLyDiem
{
    partial class FormHocKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocKy));
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaHocKy = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.lblTGBatDau = new System.Windows.Forms.Label();
            this.lblTGKetThuc = new System.Windows.Forms.Label();
            this.dgvHocKy = new System.Windows.Forms.DataGridView();
            this.txtTenHocKy = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblTenHocKy = new System.Windows.Forms.Label();
            this.txtMaHocKy = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDau.Location = new System.Drawing.Point(602, 230);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(144, 20);
            this.dtpBatDau.TabIndex = 0;
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetThuc.Location = new System.Drawing.Point(602, 276);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(144, 20);
            this.dtpKetThuc.TabIndex = 0;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(51, 23);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(221, 31);
            this.lblTittle.TabIndex = 2;
            this.lblTittle.Text = "Danh Mục Học Kỳ";
            // 
            // lblMaHocKy
            // 
            this.lblMaHocKy.AutoSize = true;
            this.lblMaHocKy.Location = new System.Drawing.Point(478, 84);
            this.lblMaHocKy.Name = "lblMaHocKy";
            this.lblMaHocKy.Size = new System.Drawing.Size(60, 13);
            this.lblMaHocKy.TabIndex = 2;
            this.lblMaHocKy.Text = "Mã Học Kỳ";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Location = new System.Drawing.Point(478, 176);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(52, 13);
            this.lblNamHoc.TabIndex = 2;
            this.lblNamHoc.Text = "Năm Học";
            // 
            // lblTGBatDau
            // 
            this.lblTGBatDau.AutoSize = true;
            this.lblTGBatDau.Location = new System.Drawing.Point(478, 230);
            this.lblTGBatDau.Name = "lblTGBatDau";
            this.lblTGBatDau.Size = new System.Drawing.Size(95, 13);
            this.lblTGBatDau.TabIndex = 2;
            this.lblTGBatDau.Text = "Thời Gian Bắt Đầu";
            // 
            // lblTGKetThuc
            // 
            this.lblTGKetThuc.AutoSize = true;
            this.lblTGKetThuc.Location = new System.Drawing.Point(478, 276);
            this.lblTGKetThuc.Name = "lblTGKetThuc";
            this.lblTGKetThuc.Size = new System.Drawing.Size(100, 13);
            this.lblTGKetThuc.TabIndex = 2;
            this.lblTGKetThuc.Text = "Thời Gian Kết Thúc";
            // 
            // dgvHocKy
            // 
            this.dgvHocKy.AllowUserToAddRows = false;
            this.dgvHocKy.AllowUserToDeleteRows = false;
            this.dgvHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocKy.Location = new System.Drawing.Point(7, 80);
            this.dgvHocKy.Name = "dgvHocKy";
            this.dgvHocKy.ReadOnly = true;
            this.dgvHocKy.Size = new System.Drawing.Size(465, 312);
            this.dgvHocKy.TabIndex = 3;
            this.dgvHocKy.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocKy_RowEnter);
            // 
            // txtTenHocKy
            // 
            this.txtTenHocKy.Location = new System.Drawing.Point(602, 131);
            this.txtTenHocKy.Name = "txtTenHocKy";
            this.txtTenHocKy.Size = new System.Drawing.Size(144, 20);
            this.txtTenHocKy.TabIndex = 4;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(602, 176);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(144, 20);
            this.txtNamHoc.TabIndex = 4;
            // 
            // lblTenHocKy
            // 
            this.lblTenHocKy.AutoSize = true;
            this.lblTenHocKy.Location = new System.Drawing.Point(478, 131);
            this.lblTenHocKy.Name = "lblTenHocKy";
            this.lblTenHocKy.Size = new System.Drawing.Size(64, 13);
            this.lblTenHocKy.TabIndex = 2;
            this.lblTenHocKy.Text = "Tên Học Kỳ";
            // 
            // txtMaHocKy
            // 
            this.txtMaHocKy.Location = new System.Drawing.Point(602, 84);
            this.txtMaHocKy.Name = "txtMaHocKy";
            this.txtMaHocKy.Size = new System.Drawing.Size(144, 20);
            this.txtMaHocKy.TabIndex = 4;
            this.txtMaHocKy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHocKy_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(674, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(481, 321);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(579, 321);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(674, 321);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.txtMaHocKy);
            this.Controls.Add(this.txtTenHocKy);
            this.Controls.Add(this.dgvHocKy);
            this.Controls.Add(this.lblTGKetThuc);
            this.Controls.Add(this.lblTGBatDau);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblTenHocKy);
            this.Controls.Add(this.lblMaHocKy);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.dtpKetThuc);
            this.Controls.Add(this.dtpBatDau);
            this.Name = "FormHocKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Học Kỳ";
            this.Load += new System.EventHandler(this.FormHocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblTGBatDau;
        private System.Windows.Forms.Label lblTGKetThuc;
        private System.Windows.Forms.DataGridView dgvHocKy;
        private System.Windows.Forms.TextBox txtTenHocKy;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblTenHocKy;
        private System.Windows.Forms.TextBox txtMaHocKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}