namespace QuanLyDiem
{
    partial class FormNhomHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhomHocPhan));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaNhomHP = new System.Windows.Forms.TextBox();
            this.txtTenNhomHP = new System.Windows.Forms.TextBox();
            this.dgvNhomHocPhan = new System.Windows.Forms.DataGridView();
            this.cmbMaHP = new System.Windows.Forms.ComboBox();
            this.hocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet9 = new QuanLyDiem.CNPM_1DataSet9();
            this.cmbMaKHGD = new System.Windows.Forms.ComboBox();
            this.keHoachGiangDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet10 = new QuanLyDiem.CNPM_1DataSet10();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet11 = new QuanLyDiem.CNPM_1DataSet11();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaNhomHP = new System.Windows.Forms.Label();
            this.lblTenNhomHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblMaKHGD = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.hocPhanTableAdapter = new QuanLyDiem.CNPM_1DataSet9TableAdapters.HocPhanTableAdapter();
            this.keHoachGiangDayTableAdapter = new QuanLyDiem.CNPM_1DataSet10TableAdapters.KeHoachGiangDayTableAdapter();
            this.giangVienTableAdapter = new QuanLyDiem.CNPM_1DataSet11TableAdapters.GiangVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHocPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keHoachGiangDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(665, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(472, 334);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(570, 334);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(665, 334);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaNhomHP
            // 
            this.txtMaNhomHP.Location = new System.Drawing.Point(588, 107);
            this.txtMaNhomHP.Name = "txtMaNhomHP";
            this.txtMaNhomHP.Size = new System.Drawing.Size(123, 20);
            this.txtMaNhomHP.TabIndex = 37;
            this.txtMaNhomHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNhomHP_KeyPress);
            // 
            // txtTenNhomHP
            // 
            this.txtTenNhomHP.Location = new System.Drawing.Point(588, 148);
            this.txtTenNhomHP.Name = "txtTenNhomHP";
            this.txtTenNhomHP.Size = new System.Drawing.Size(121, 20);
            this.txtTenNhomHP.TabIndex = 37;
            // 
            // dgvNhomHocPhan
            // 
            this.dgvNhomHocPhan.AllowUserToAddRows = false;
            this.dgvNhomHocPhan.AllowUserToDeleteRows = false;
            this.dgvNhomHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHocPhan.Location = new System.Drawing.Point(29, 107);
            this.dgvNhomHocPhan.Name = "dgvNhomHocPhan";
            this.dgvNhomHocPhan.ReadOnly = true;
            this.dgvNhomHocPhan.Size = new System.Drawing.Size(425, 300);
            this.dgvNhomHocPhan.TabIndex = 38;
            this.dgvNhomHocPhan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomHocPhan_RowEnter);
            // 
            // cmbMaHP
            // 
            this.cmbMaHP.DataSource = this.hocPhanBindingSource;
            this.cmbMaHP.DisplayMember = "MaHP";
            this.cmbMaHP.FormattingEnabled = true;
            this.cmbMaHP.Location = new System.Drawing.Point(588, 188);
            this.cmbMaHP.Name = "cmbMaHP";
            this.cmbMaHP.Size = new System.Drawing.Size(121, 21);
            this.cmbMaHP.TabIndex = 39;
            this.cmbMaHP.ValueMember = "MaHP";
            // 
            // hocPhanBindingSource
            // 
            this.hocPhanBindingSource.DataMember = "HocPhan";
            this.hocPhanBindingSource.DataSource = this.cNPM_1DataSet9;
            // 
            // cNPM_1DataSet9
            // 
            this.cNPM_1DataSet9.DataSetName = "CNPM_1DataSet9";
            this.cNPM_1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaKHGD
            // 
            this.cmbMaKHGD.DataSource = this.keHoachGiangDayBindingSource;
            this.cmbMaKHGD.DisplayMember = "MaKHGD";
            this.cmbMaKHGD.FormattingEnabled = true;
            this.cmbMaKHGD.Location = new System.Drawing.Point(588, 231);
            this.cmbMaKHGD.Name = "cmbMaKHGD";
            this.cmbMaKHGD.Size = new System.Drawing.Size(121, 21);
            this.cmbMaKHGD.TabIndex = 39;
            this.cmbMaKHGD.ValueMember = "MaKHGD";
            // 
            // keHoachGiangDayBindingSource
            // 
            this.keHoachGiangDayBindingSource.DataMember = "KeHoachGiangDay";
            this.keHoachGiangDayBindingSource.DataSource = this.cNPM_1DataSet10;
            // 
            // cNPM_1DataSet10
            // 
            this.cNPM_1DataSet10.DataSetName = "CNPM_1DataSet10";
            this.cNPM_1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DataSource = this.giangVienBindingSource;
            this.cmbMaGV.DisplayMember = "MaGV";
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(588, 275);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(121, 21);
            this.cmbMaGV.TabIndex = 39;
            this.cmbMaGV.ValueMember = "MaGV";
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.cNPM_1DataSet11;
            // 
            // cNPM_1DataSet11
            // 
            this.cNPM_1DataSet11.DataSetName = "CNPM_1DataSet11";
            this.cNPM_1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(81, 51);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(318, 31);
            this.lblTittle.TabIndex = 40;
            this.lblTittle.Text = "Danh Mục Nhóm Học Phần";
            // 
            // lblMaNhomHP
            // 
            this.lblMaNhomHP.AutoSize = true;
            this.lblMaNhomHP.Location = new System.Drawing.Point(474, 107);
            this.lblMaNhomHP.Name = "lblMaNhomHP";
            this.lblMaNhomHP.Size = new System.Drawing.Size(71, 13);
            this.lblMaNhomHP.TabIndex = 40;
            this.lblMaNhomHP.Text = "Mã Nhóm HP";
            // 
            // lblTenNhomHP
            // 
            this.lblTenNhomHP.AutoSize = true;
            this.lblTenNhomHP.Location = new System.Drawing.Point(474, 148);
            this.lblTenNhomHP.Name = "lblTenNhomHP";
            this.lblTenNhomHP.Size = new System.Drawing.Size(75, 13);
            this.lblTenNhomHP.TabIndex = 40;
            this.lblTenNhomHP.Text = "Tên Nhóm HP";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Location = new System.Drawing.Point(474, 188);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(40, 13);
            this.lblMaHP.TabIndex = 40;
            this.lblMaHP.Text = "Mã HP";
            // 
            // lblMaKHGD
            // 
            this.lblMaKHGD.AutoSize = true;
            this.lblMaKHGD.Location = new System.Drawing.Point(474, 231);
            this.lblMaKHGD.Name = "lblMaKHGD";
            this.lblMaKHGD.Size = new System.Drawing.Size(56, 13);
            this.lblMaKHGD.TabIndex = 40;
            this.lblMaKHGD.Text = "Mã KHGD";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(474, 275);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(40, 13);
            this.lblMaGV.TabIndex = 40;
            this.lblMaGV.Text = "Mã GV";
            // 
            // hocPhanTableAdapter
            // 
            this.hocPhanTableAdapter.ClearBeforeFill = true;
            // 
            // keHoachGiangDayTableAdapter
            // 
            this.keHoachGiangDayTableAdapter.ClearBeforeFill = true;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhomHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.lblMaKHGD);
            this.Controls.Add(this.lblMaHP);
            this.Controls.Add(this.lblTenNhomHP);
            this.Controls.Add(this.lblMaNhomHP);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.cmbMaGV);
            this.Controls.Add(this.cmbMaKHGD);
            this.Controls.Add(this.cmbMaHP);
            this.Controls.Add(this.dgvNhomHocPhan);
            this.Controls.Add(this.txtTenNhomHP);
            this.Controls.Add(this.txtMaNhomHP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "FormNhomHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm Học Phần";
            this.Load += new System.EventHandler(this.FormNhomHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHocPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keHoachGiangDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaNhomHP;
        private System.Windows.Forms.TextBox txtTenNhomHP;
        private System.Windows.Forms.DataGridView dgvNhomHocPhan;
        private System.Windows.Forms.ComboBox cmbMaHP;
        private System.Windows.Forms.ComboBox cmbMaKHGD;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaNhomHP;
        private System.Windows.Forms.Label lblTenNhomHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label lblMaKHGD;
        private System.Windows.Forms.Label lblMaGV;
        private CNPM_1DataSet9 cNPM_1DataSet9;
        private System.Windows.Forms.BindingSource hocPhanBindingSource;
        private QuanLyDiem.CNPM_1DataSet9TableAdapters.HocPhanTableAdapter hocPhanTableAdapter;
        private CNPM_1DataSet10 cNPM_1DataSet10;
        private System.Windows.Forms.BindingSource keHoachGiangDayBindingSource;
        private QuanLyDiem.CNPM_1DataSet10TableAdapters.KeHoachGiangDayTableAdapter keHoachGiangDayTableAdapter;
        private CNPM_1DataSet11 cNPM_1DataSet11;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private QuanLyDiem.CNPM_1DataSet11TableAdapters.GiangVienTableAdapter giangVienTableAdapter;
    }
}