namespace QuanLyDiem
{
    partial class FormKHGD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKHGD));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaKHGD = new System.Windows.Forms.TextBox();
            this.cmbMahocKy = new System.Windows.Forms.ComboBox();
            this.hocKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet_HocKy = new QuanLyDiem.CNPM_1DataSet4();
            this.cmbMaKhoiLop = new System.Windows.Forms.ComboBox();
            this.khoiLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet_KhoiLop = new QuanLyDiem.CNPM_1DataSet5();
            this.dgvKHGD = new System.Windows.Forms.DataGridView();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaKHGD = new System.Windows.Forms.Label();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.lblMaKhoiLop = new System.Windows.Forms.Label();
            this.hocKyTableAdapter = new QuanLyDiem.CNPM_1DataSet4TableAdapters.HocKyTableAdapter();
            this.khoiLopTableAdapter = new QuanLyDiem.CNPM_1DataSet5TableAdapters.KhoiLopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hocKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_HocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_KhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHGD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(658, 364);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(465, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(563, 300);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(658, 300);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaKHGD
            // 
            this.txtMaKHGD.Location = new System.Drawing.Point(576, 125);
            this.txtMaKHGD.Name = "txtMaKHGD";
            this.txtMaKHGD.Size = new System.Drawing.Size(121, 20);
            this.txtMaKHGD.TabIndex = 25;
            this.txtMaKHGD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKHGD_KeyPress);
            // 
            // cmbMahocKy
            // 
            this.cmbMahocKy.DataSource = this.hocKyBindingSource;
            this.cmbMahocKy.DisplayMember = "MaHK";
            this.cmbMahocKy.FormattingEnabled = true;
            this.cmbMahocKy.Location = new System.Drawing.Point(576, 171);
            this.cmbMahocKy.Name = "cmbMahocKy";
            this.cmbMahocKy.Size = new System.Drawing.Size(121, 21);
            this.cmbMahocKy.TabIndex = 26;
            this.cmbMahocKy.ValueMember = "MaHK";
            // 
            // hocKyBindingSource
            // 
            this.hocKyBindingSource.DataMember = "HocKy";
            this.hocKyBindingSource.DataSource = this.cNPM_1DataSet_HocKy;
            // 
            // cNPM_1DataSet_HocKy
            // 
            this.cNPM_1DataSet_HocKy.DataSetName = "_HocKy";
            this.cNPM_1DataSet_HocKy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaKhoiLop
            // 
            this.cmbMaKhoiLop.DataSource = this.khoiLopBindingSource;
            this.cmbMaKhoiLop.DisplayMember = "MaKhoiLop";
            this.cmbMaKhoiLop.FormattingEnabled = true;
            this.cmbMaKhoiLop.Location = new System.Drawing.Point(576, 219);
            this.cmbMaKhoiLop.Name = "cmbMaKhoiLop";
            this.cmbMaKhoiLop.Size = new System.Drawing.Size(121, 21);
            this.cmbMaKhoiLop.TabIndex = 26;
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
            // dgvKHGD
            // 
            this.dgvKHGD.AllowUserToAddRows = false;
            this.dgvKHGD.AllowUserToDeleteRows = false;
            this.dgvKHGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHGD.Location = new System.Drawing.Point(48, 90);
            this.dgvKHGD.Name = "dgvKHGD";
            this.dgvKHGD.ReadOnly = true;
            this.dgvKHGD.Size = new System.Drawing.Size(345, 280);
            this.dgvKHGD.TabIndex = 27;
            this.dgvKHGD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHGD_RowEnter);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(42, 35);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(368, 31);
            this.lblTittle.TabIndex = 28;
            this.lblTittle.Text = "Danh Mục Kế Hoạch Giảng Dạy";
            // 
            // lblMaKHGD
            // 
            this.lblMaKHGD.AutoSize = true;
            this.lblMaKHGD.Location = new System.Drawing.Point(427, 125);
            this.lblMaKHGD.Name = "lblMaKHGD";
            this.lblMaKHGD.Size = new System.Drawing.Size(126, 13);
            this.lblMaKHGD.TabIndex = 28;
            this.lblMaKHGD.Text = "Mã Kế Hoạch Giảng Dạy";
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(427, 171);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(60, 13);
            this.lblMaHK.TabIndex = 28;
            this.lblMaHK.Text = "Mã Học Kỳ";
            // 
            // lblMaKhoiLop
            // 
            this.lblMaKhoiLop.AutoSize = true;
            this.lblMaKhoiLop.Location = new System.Drawing.Point(427, 219);
            this.lblMaKhoiLop.Name = "lblMaKhoiLop";
            this.lblMaKhoiLop.Size = new System.Drawing.Size(67, 13);
            this.lblMaKhoiLop.TabIndex = 28;
            this.lblMaKhoiLop.Text = "Mã Khối Lớp";
            // 
            // hocKyTableAdapter
            // 
            this.hocKyTableAdapter.ClearBeforeFill = true;
            // 
            // khoiLopTableAdapter
            // 
            this.khoiLopTableAdapter.ClearBeforeFill = true;
            // 
            // FormKHGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.lblMaKhoiLop);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.lblMaKHGD);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.dgvKHGD);
            this.Controls.Add(this.cmbMaKhoiLop);
            this.Controls.Add(this.cmbMahocKy);
            this.Controls.Add(this.txtMaKHGD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "FormKHGD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kế Hoạch Giảng Dạy";
            this.Load += new System.EventHandler(this.FormKHGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hocKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_HocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoiLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_KhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHGD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaKHGD;
        private System.Windows.Forms.ComboBox cmbMahocKy;
        private System.Windows.Forms.ComboBox cmbMaKhoiLop;
        private System.Windows.Forms.DataGridView dgvKHGD;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaKHGD;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.Label lblMaKhoiLop;
        private CNPM_1DataSet4 cNPM_1DataSet_HocKy;
        private System.Windows.Forms.BindingSource hocKyBindingSource;
        private QuanLyDiem.CNPM_1DataSet4TableAdapters.HocKyTableAdapter hocKyTableAdapter;
        private CNPM_1DataSet5 cNPM_1DataSet_KhoiLop;
        private System.Windows.Forms.BindingSource khoiLopBindingSource;
        private QuanLyDiem.CNPM_1DataSet5TableAdapters.KhoiLopTableAdapter khoiLopTableAdapter;
    }
}