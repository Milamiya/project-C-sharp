namespace QuanLyDiem
{
    partial class FormQuanLyDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDiem));
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaNhomHP = new System.Windows.Forms.Label();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.cmbMaHK = new System.Windows.Forms.ComboBox();
            this.hocKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet4 = new QuanLyDiem.CNPM_1DataSet4();
            this.hocKyTableAdapter = new QuanLyDiem.CNPM_1DataSet4TableAdapters.HocKyTableAdapter();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblDiemQT = new System.Windows.Forms.Label();
            this.txtDiemQuaTrinh = new System.Windows.Forms.TextBox();
            this.lblDiemThi = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cmbMaNhomHP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hocKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(35, 20);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(305, 31);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Chức Năng Quản Lý Điểm";
            // 
            // lblMaNhomHP
            // 
            this.lblMaNhomHP.AutoSize = true;
            this.lblMaNhomHP.Location = new System.Drawing.Point(44, 141);
            this.lblMaNhomHP.Name = "lblMaNhomHP";
            this.lblMaNhomHP.Size = new System.Drawing.Size(104, 13);
            this.lblMaNhomHP.TabIndex = 1;
            this.lblMaNhomHP.Text = "Mã Nhóm Học Phần";
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(70, 95);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(60, 13);
            this.lblMaHK.TabIndex = 1;
            this.lblMaHK.Text = "Mã Học Kỳ";
            // 
            // cmbMaHK
            // 
            this.cmbMaHK.DataSource = this.hocKyBindingSource;
            this.cmbMaHK.DisplayMember = "MaHK";
            this.cmbMaHK.FormattingEnabled = true;
            this.cmbMaHK.Location = new System.Drawing.Point(171, 86);
            this.cmbMaHK.Name = "cmbMaHK";
            this.cmbMaHK.Size = new System.Drawing.Size(125, 21);
            this.cmbMaHK.TabIndex = 3;
            this.cmbMaHK.ValueMember = "MaHK";
            this.cmbMaHK.SelectedValueChanged += new System.EventHandler(this.cmbMaHK_SelectedValueChanged);
            // 
            // hocKyBindingSource
            // 
            this.hocKyBindingSource.DataMember = "HocKy";
            this.hocKyBindingSource.DataSource = this.cNPM_1DataSet4;
            // 
            // cNPM_1DataSet4
            // 
            this.cNPM_1DataSet4.DataSetName = "CNPM_1DataSet4";
            this.cNPM_1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocKyTableAdapter
            // 
            this.hocKyTableAdapter.ClearBeforeFill = true;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(369, 27);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(361, 404);
            this.dgvKetQua.TabIndex = 4;
            this.dgvKetQua.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_RowEnter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(103, 391);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Location = new System.Drawing.Point(224, 391);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 30);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "      Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(171, 258);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(125, 20);
            this.txtMaSV.TabIndex = 18;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(53, 265);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(70, 13);
            this.lblMaSV.TabIndex = 17;
            this.lblMaSV.Text = "Mã Sinh Viên";
            // 
            // lblDiemQT
            // 
            this.lblDiemQT.AutoSize = true;
            this.lblDiemQT.Location = new System.Drawing.Point(53, 317);
            this.lblDiemQT.Name = "lblDiemQT";
            this.lblDiemQT.Size = new System.Drawing.Size(81, 13);
            this.lblDiemQT.TabIndex = 17;
            this.lblDiemQT.Text = "Điểm Quá Trình";
            // 
            // txtDiemQuaTrinh
            // 
            this.txtDiemQuaTrinh.Location = new System.Drawing.Point(171, 310);
            this.txtDiemQuaTrinh.Name = "txtDiemQuaTrinh";
            this.txtDiemQuaTrinh.Size = new System.Drawing.Size(125, 20);
            this.txtDiemQuaTrinh.TabIndex = 18;
            // 
            // lblDiemThi
            // 
            this.lblDiemThi.AutoSize = true;
            this.lblDiemThi.Location = new System.Drawing.Point(53, 366);
            this.lblDiemThi.Name = "lblDiemThi";
            this.lblDiemThi.Size = new System.Drawing.Size(49, 13);
            this.lblDiemThi.TabIndex = 17;
            this.lblDiemThi.Text = "Điểm Thi";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(171, 359);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(125, 20);
            this.txtDiemThi.TabIndex = 18;
            // 
            // btnLoc
            // 
            this.btnLoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoc.BackgroundImage")));
            this.btnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoc.Location = new System.Drawing.Point(224, 180);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(72, 30);
            this.btnLoc.TabIndex = 19;
            this.btnLoc.Text = "      Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cmbMaNhomHP
            // 
            this.cmbMaNhomHP.FormattingEnabled = true;
            this.cmbMaNhomHP.Location = new System.Drawing.Point(171, 138);
            this.cmbMaNhomHP.Name = "cmbMaNhomHP";
            this.cmbMaNhomHP.Size = new System.Drawing.Size(125, 21);
            this.cmbMaNhomHP.TabIndex = 20;
            // 
            // FormQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.cmbMaNhomHP);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.txtDiemQuaTrinh);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblDiemThi);
            this.Controls.Add(this.lblDiemQT);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.cmbMaHK);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.lblMaNhomHP);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormQuanLyDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Năng Quản Lý Điểm";
            this.Load += new System.EventHandler(this.FormQuanLyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hocKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaNhomHP;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.ComboBox cmbMaHK;
        private CNPM_1DataSet4 cNPM_1DataSet4;
        private System.Windows.Forms.BindingSource hocKyBindingSource;
        private QuanLyDiem.CNPM_1DataSet4TableAdapters.HocKyTableAdapter hocKyTableAdapter;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblDiemQT;
        private System.Windows.Forms.TextBox txtDiemQuaTrinh;
        private System.Windows.Forms.Label lblDiemThi;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cmbMaNhomHP;
    }
}