namespace QuanLyDiem
{
    partial class FormXemDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXemDiem));
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cmbMaHK = new System.Windows.Forms.ComboBox();
            this.hocKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet_HocKy = new QuanLyDiem.CNPM_1DataSet4();
            this.cNPM1DataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.hocKyTableAdapter = new QuanLyDiem.CNPM_1DataSet4TableAdapters.HocKyTableAdapter();
            this.btnXuatRaExcel = new System.Windows.Forms.Button();
            this.lblDiemTongKet = new System.Windows.Forms.Label();
            this.lblHe10 = new System.Windows.Forms.Label();
            this.lblHe4 = new System.Windows.Forms.Label();
            this.txtHe4 = new System.Windows.Forms.TextBox();
            this.txtHe10 = new System.Windows.Forms.TextBox();
            this.chbXemTatCaHocKy = new System.Windows.Forms.CheckBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hocKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_HocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM1DataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(138, 34);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(458, 31);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Xem Điểm Của Sinh Viên Trong Học Kỳ";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(72, 98);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(39, 13);
            this.lblMaSV.TabIndex = 1;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(311, 95);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(60, 13);
            this.lblMaHK.TabIndex = 1;
            this.lblMaHK.Text = "Mã Học Kỳ";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(144, 95);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(117, 20);
            this.txtMaSV.TabIndex = 2;
            this.txtMaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSV_KeyPress);
            // 
            // cmbMaHK
            // 
            this.cmbMaHK.DataSource = this.hocKyBindingSource;
            this.cmbMaHK.DisplayMember = "MaHK";
            this.cmbMaHK.FormattingEnabled = true;
            this.cmbMaHK.Location = new System.Drawing.Point(395, 92);
            this.cmbMaHK.Name = "cmbMaHK";
            this.cmbMaHK.Size = new System.Drawing.Size(121, 21);
            this.cmbMaHK.TabIndex = 3;
            this.cmbMaHK.ValueMember = "MaHK";
            // 
            // hocKyBindingSource
            // 
            this.hocKyBindingSource.DataMember = "HocKy";
            this.hocKyBindingSource.DataSource = this.cNPM_1DataSet_HocKy;
            // 
            // cNPM_1DataSet_HocKy
            // 
            this.cNPM_1DataSet_HocKy.DataSetName = "CNPM_1DataSet_HocKy";
            this.cNPM_1DataSet_HocKy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cNPM1DataSet4BindingSource
            // 
            this.cNPM1DataSet4BindingSource.DataSource = this.cNPM_1DataSet_HocKy;
            this.cNPM1DataSet4BindingSource.Position = 0;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(84, 145);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(566, 190);
            this.dgvKetQua.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(607, 403);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXem.BackgroundImage")));
            this.btnXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXem.Location = new System.Drawing.Point(578, 89);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(72, 30);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "        Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // hocKyTableAdapter
            // 
            this.hocKyTableAdapter.ClearBeforeFill = true;
            // 
            // btnXuatRaExcel
            // 
            this.btnXuatRaExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatRaExcel.BackgroundImage")));
            this.btnXuatRaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXuatRaExcel.Location = new System.Drawing.Point(84, 357);
            this.btnXuatRaExcel.Name = "btnXuatRaExcel";
            this.btnXuatRaExcel.Size = new System.Drawing.Size(72, 30);
            this.btnXuatRaExcel.TabIndex = 10;
            this.btnXuatRaExcel.Text = "       In File";
            this.btnXuatRaExcel.UseVisualStyleBackColor = true;
            this.btnXuatRaExcel.Click += new System.EventHandler(this.btnXuatRaExcel_Click);
            // 
            // lblDiemTongKet
            // 
            this.lblDiemTongKet.AutoSize = true;
            this.lblDiemTongKet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTongKet.ForeColor = System.Drawing.Color.Red;
            this.lblDiemTongKet.Location = new System.Drawing.Point(328, 357);
            this.lblDiemTongKet.Name = "lblDiemTongKet";
            this.lblDiemTongKet.Size = new System.Drawing.Size(112, 19);
            this.lblDiemTongKet.TabIndex = 11;
            this.lblDiemTongKet.Text = "Điểm Tổng Kết";
            // 
            // lblHe10
            // 
            this.lblHe10.AutoSize = true;
            this.lblHe10.Location = new System.Drawing.Point(446, 344);
            this.lblHe10.Name = "lblHe10";
            this.lblHe10.Size = new System.Drawing.Size(36, 13);
            this.lblHe10.TabIndex = 12;
            this.lblHe10.Text = "Hệ 10";
            // 
            // lblHe4
            // 
            this.lblHe4.AutoSize = true;
            this.lblHe4.Location = new System.Drawing.Point(446, 377);
            this.lblHe4.Name = "lblHe4";
            this.lblHe4.Size = new System.Drawing.Size(30, 13);
            this.lblHe4.TabIndex = 12;
            this.lblHe4.Text = "Hệ 4";
            // 
            // txtHe4
            // 
            this.txtHe4.Enabled = false;
            this.txtHe4.Location = new System.Drawing.Point(508, 374);
            this.txtHe4.Name = "txtHe4";
            this.txtHe4.Size = new System.Drawing.Size(100, 20);
            this.txtHe4.TabIndex = 13;
            this.txtHe4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHe10
            // 
            this.txtHe10.Enabled = false;
            this.txtHe10.Location = new System.Drawing.Point(508, 341);
            this.txtHe10.Name = "txtHe10";
            this.txtHe10.Size = new System.Drawing.Size(100, 20);
            this.txtHe10.TabIndex = 13;
            this.txtHe10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chbXemTatCaHocKy
            // 
            this.chbXemTatCaHocKy.AutoSize = true;
            this.chbXemTatCaHocKy.Location = new System.Drawing.Point(395, 122);
            this.chbXemTatCaHocKy.Name = "chbXemTatCaHocKy";
            this.chbXemTatCaHocKy.Size = new System.Drawing.Size(120, 17);
            this.chbXemTatCaHocKy.TabIndex = 14;
            this.chbXemTatCaHocKy.Text = "Xem Tất Cả Học Kỳ";
            this.chbXemTatCaHocKy.UseVisualStyleBackColor = true;
            this.chbXemTatCaHocKy.CheckedChanged += new System.EventHandler(this.chbXemTatCaHocKy_CheckedChanged);
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.ForeColor = System.Drawing.Color.Red;
            this.lblTenSV.Location = new System.Drawing.Point(101, 126);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(45, 19);
            this.lblTenSV.TabIndex = 15;
            this.lblTenSV.Text = "label1";
            this.lblTenSV.Visible = false;
            // 
            // FormXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.chbXemTatCaHocKy);
            this.Controls.Add(this.txtHe10);
            this.Controls.Add(this.txtHe4);
            this.Controls.Add(this.lblHe4);
            this.Controls.Add(this.lblHe10);
            this.Controls.Add(this.lblDiemTongKet);
            this.Controls.Add(this.btnXuatRaExcel);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.cmbMaHK);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Năng Xem Điểm Sinh Viên";
            this.Load += new System.EventHandler(this.FormXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hocKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_HocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM1DataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cmbMaHK;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.BindingSource cNPM1DataSet4BindingSource;
        private CNPM_1DataSet4 cNPM_1DataSet_HocKy;
        private System.Windows.Forms.BindingSource hocKyBindingSource;
        private QuanLyDiem.CNPM_1DataSet4TableAdapters.HocKyTableAdapter hocKyTableAdapter;
        private System.Windows.Forms.Button btnXuatRaExcel;
        private System.Windows.Forms.Label lblDiemTongKet;
        private System.Windows.Forms.Label lblHe10;
        private System.Windows.Forms.Label lblHe4;
        private System.Windows.Forms.TextBox txtHe4;
        private System.Windows.Forms.TextBox txtHe10;
        private System.Windows.Forms.CheckBox chbXemTatCaHocKy;
        private System.Windows.Forms.Label lblTenSV;
    }
}