namespace QuanLyDiem
{
    partial class FormLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLop));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cmbMaKhoiLop = new System.Windows.Forms.ComboBox();
            this.khoiLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet_KhoiLop = new QuanLyDiem.CNPM_1DataSet7();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet_GiangVien = new QuanLyDiem.CNPM_1DataSet8();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblMaKhoiLop = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.khoiLopTableAdapter = new QuanLyDiem.CNPM_1DataSet7TableAdapters.KhoiLopTableAdapter();
            this.giangVienTableAdapter = new QuanLyDiem.CNPM_1DataSet8TableAdapters.GiangVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khoiLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_KhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_GiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(624, 386);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(431, 322);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(529, 322);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(624, 322);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cmbMaKhoiLop
            // 
            this.cmbMaKhoiLop.DataSource = this.khoiLopBindingSource;
            this.cmbMaKhoiLop.DisplayMember = "MaKhoiLop";
            this.cmbMaKhoiLop.FormattingEnabled = true;
            this.cmbMaKhoiLop.Location = new System.Drawing.Point(542, 195);
            this.cmbMaKhoiLop.Name = "cmbMaKhoiLop";
            this.cmbMaKhoiLop.Size = new System.Drawing.Size(121, 21);
            this.cmbMaKhoiLop.TabIndex = 33;
            this.cmbMaKhoiLop.ValueMember = "MaKhoiLop";
            // 
            // khoiLopBindingSource
            // 
            this.khoiLopBindingSource.DataMember = "KhoiLop";
            this.khoiLopBindingSource.DataSource = this.cNPM_1DataSet_KhoiLop;
            // 
            // cNPM_1DataSet_KhoiLop
            // 
            this.cNPM_1DataSet_KhoiLop.DataSetName = "CNPM_1DataSet_KhoiLop";
            this.cNPM_1DataSet_KhoiLop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DataSource = this.giangVienBindingSource;
            this.cmbMaGV.DisplayMember = "MaGV";
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(542, 242);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(121, 21);
            this.cmbMaGV.TabIndex = 33;
            this.cmbMaGV.ValueMember = "MaGV";
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.cNPM_1DataSet_GiangVien;
            // 
            // cNPM_1DataSet_GiangVien
            // 
            this.cNPM_1DataSet_GiangVien.DataSetName = "CNPM_1DataSet_GiangVien";
            this.cNPM_1DataSet_GiangVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(32, 78);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.Size = new System.Drawing.Size(355, 274);
            this.dgvLop.TabIndex = 34;
            this.dgvLop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(438, 99);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(43, 13);
            this.lblMaLop.TabIndex = 35;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(542, 99);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 36;
            this.txtMaLop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaLop_KeyPress);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(542, 147);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(121, 20);
            this.txtTenLop.TabIndex = 36;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(438, 147);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(47, 13);
            this.lblTenLop.TabIndex = 35;
            this.lblTenLop.Text = "Tên Lớp";
            // 
            // lblMaKhoiLop
            // 
            this.lblMaKhoiLop.AutoSize = true;
            this.lblMaKhoiLop.Location = new System.Drawing.Point(438, 195);
            this.lblMaKhoiLop.Name = "lblMaKhoiLop";
            this.lblMaKhoiLop.Size = new System.Drawing.Size(67, 13);
            this.lblMaKhoiLop.TabIndex = 35;
            this.lblMaKhoiLop.Text = "Mã Khối Lớp";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(438, 242);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(77, 13);
            this.lblMaGV.TabIndex = 35;
            this.lblMaGV.Text = "Mã Giảng Viên";
            this.lblMaGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(118, 35);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(181, 31);
            this.lblTittle.TabIndex = 35;
            this.lblTittle.Text = "Danh Mục Lớp";
            // 
            // khoiLopTableAdapter
            // 
            this.khoiLopTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.lblMaKhoiLop);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.cmbMaGV);
            this.Controls.Add(this.cmbMaKhoiLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "FormLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Lớp";
            this.Load += new System.EventHandler(this.FormLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoiLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_KhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_GiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cmbMaKhoiLop;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblMaKhoiLop;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblTittle;
        private CNPM_1DataSet7 cNPM_1DataSet_KhoiLop;
        private System.Windows.Forms.BindingSource khoiLopBindingSource;
        private QuanLyDiem.CNPM_1DataSet7TableAdapters.KhoiLopTableAdapter khoiLopTableAdapter;
        private CNPM_1DataSet8 cNPM_1DataSet_GiangVien;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private QuanLyDiem.CNPM_1DataSet8TableAdapters.GiangVienTableAdapter giangVienTableAdapter;

    }
}