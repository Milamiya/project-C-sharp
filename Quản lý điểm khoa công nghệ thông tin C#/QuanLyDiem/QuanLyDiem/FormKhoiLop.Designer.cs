namespace QuanLyDiem
{
    partial class FormKhoiLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoiLop));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaKhoiLop = new System.Windows.Forms.TextBox();
            this.txtTenKhoiLop = new System.Windows.Forms.TextBox();
            this.cmbMaHeDT = new System.Windows.Forms.ComboBox();
            this.heDaoTaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet_HeDaoTao = new QuanLyDiem.CNPM_1DataSet2();
            this.cmbMaTDDT = new System.Windows.Forms.ComboBox();
            this.trinhDoDaoTaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cNPM_1DataSet_TrinhDoDaoTao = new QuanLyDiem.CNPM_1DataSet3();
            this.lblMaKhoiLop = new System.Windows.Forms.Label();
            this.lblTenKhoiLop = new System.Windows.Forms.Label();
            this.lblMaHeDT = new System.Windows.Forms.Label();
            this.lblMaTDDT = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.dgvKhoiLop = new System.Windows.Forms.DataGridView();
            this.heDaoTaoTableAdapter = new QuanLyDiem.CNPM_1DataSet2TableAdapters.HeDaoTaoTableAdapter();
            this.trinhDoDaoTaoTableAdapter = new QuanLyDiem.CNPM_1DataSet3TableAdapters.TrinhDoDaoTaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.heDaoTaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_HeDaoTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoDaoTaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_TrinhDoDaoTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoiLop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(657, 373);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(464, 309);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(562, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(657, 309);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaKhoiLop
            // 
            this.txtMaKhoiLop.Location = new System.Drawing.Point(595, 106);
            this.txtMaKhoiLop.Name = "txtMaKhoiLop";
            this.txtMaKhoiLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaKhoiLop.TabIndex = 21;
            this.txtMaKhoiLop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKhoiLop_KeyPress);
            // 
            // txtTenKhoiLop
            // 
            this.txtTenKhoiLop.Location = new System.Drawing.Point(595, 148);
            this.txtTenKhoiLop.Name = "txtTenKhoiLop";
            this.txtTenKhoiLop.Size = new System.Drawing.Size(121, 20);
            this.txtTenKhoiLop.TabIndex = 21;
            // 
            // cmbMaHeDT
            // 
            this.cmbMaHeDT.DataSource = this.heDaoTaoBindingSource;
            this.cmbMaHeDT.DisplayMember = "MaHeDT";
            this.cmbMaHeDT.FormattingEnabled = true;
            this.cmbMaHeDT.Location = new System.Drawing.Point(595, 193);
            this.cmbMaHeDT.Name = "cmbMaHeDT";
            this.cmbMaHeDT.Size = new System.Drawing.Size(121, 21);
            this.cmbMaHeDT.TabIndex = 22;
            this.cmbMaHeDT.ValueMember = "MaHeDT";
            // 
            // heDaoTaoBindingSource
            // 
            this.heDaoTaoBindingSource.DataMember = "HeDaoTao";
            this.heDaoTaoBindingSource.DataSource = this.cNPM_1DataSet_HeDaoTao;
            // 
            // cNPM_1DataSet_HeDaoTao
            // 
            this.cNPM_1DataSet_HeDaoTao.DataSetName = "_HeDaoTao";
            this.cNPM_1DataSet_HeDaoTao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaTDDT
            // 
            this.cmbMaTDDT.DataSource = this.trinhDoDaoTaoBindingSource;
            this.cmbMaTDDT.DisplayMember = "MaTDDT";
            this.cmbMaTDDT.FormattingEnabled = true;
            this.cmbMaTDDT.Location = new System.Drawing.Point(595, 239);
            this.cmbMaTDDT.Name = "cmbMaTDDT";
            this.cmbMaTDDT.Size = new System.Drawing.Size(121, 21);
            this.cmbMaTDDT.TabIndex = 22;
            this.cmbMaTDDT.ValueMember = "MaTDDT";
            // 
            // trinhDoDaoTaoBindingSource
            // 
            this.trinhDoDaoTaoBindingSource.DataMember = "TrinhDoDaoTao";
            this.trinhDoDaoTaoBindingSource.DataSource = this.cNPM_1DataSet_TrinhDoDaoTao;
            // 
            // cNPM_1DataSet_TrinhDoDaoTao
            // 
            this.cNPM_1DataSet_TrinhDoDaoTao.DataSetName = "CNPM_1DataSet_TrinhDoDaoTao";
            this.cNPM_1DataSet_TrinhDoDaoTao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMaKhoiLop
            // 
            this.lblMaKhoiLop.AutoSize = true;
            this.lblMaKhoiLop.Location = new System.Drawing.Point(451, 106);
            this.lblMaKhoiLop.Name = "lblMaKhoiLop";
            this.lblMaKhoiLop.Size = new System.Drawing.Size(67, 13);
            this.lblMaKhoiLop.TabIndex = 23;
            this.lblMaKhoiLop.Text = "Mã Khối Lớp";
            // 
            // lblTenKhoiLop
            // 
            this.lblTenKhoiLop.AutoSize = true;
            this.lblTenKhoiLop.Location = new System.Drawing.Point(451, 148);
            this.lblTenKhoiLop.Name = "lblTenKhoiLop";
            this.lblTenKhoiLop.Size = new System.Drawing.Size(71, 13);
            this.lblTenKhoiLop.TabIndex = 23;
            this.lblTenKhoiLop.Text = "Tên Khối Lớp";
            // 
            // lblMaHeDT
            // 
            this.lblMaHeDT.AutoSize = true;
            this.lblMaHeDT.Location = new System.Drawing.Point(451, 193);
            this.lblMaHeDT.Name = "lblMaHeDT";
            this.lblMaHeDT.Size = new System.Drawing.Size(84, 13);
            this.lblMaHeDT.TabIndex = 23;
            this.lblMaHeDT.Text = "Mã Hệ Đào Tạo";
            // 
            // lblMaTDDT
            // 
            this.lblMaTDDT.AutoSize = true;
            this.lblMaTDDT.Location = new System.Drawing.Point(451, 239);
            this.lblMaTDDT.Name = "lblMaTDDT";
            this.lblMaTDDT.Size = new System.Drawing.Size(55, 13);
            this.lblMaTDDT.TabIndex = 23;
            this.lblMaTDDT.Text = "Mã TĐĐT";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(117, 49);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(242, 31);
            this.lblTittle.TabIndex = 23;
            this.lblTittle.Text = "Danh Mục Khối Lớp";
            // 
            // dgvKhoiLop
            // 
            this.dgvKhoiLop.AllowUserToAddRows = false;
            this.dgvKhoiLop.AllowUserToDeleteRows = false;
            this.dgvKhoiLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoiLop.Location = new System.Drawing.Point(12, 99);
            this.dgvKhoiLop.Name = "dgvKhoiLop";
            this.dgvKhoiLop.ReadOnly = true;
            this.dgvKhoiLop.Size = new System.Drawing.Size(416, 279);
            this.dgvKhoiLop.TabIndex = 24;
            this.dgvKhoiLop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoiLop_RowEnter);
            // 
            // heDaoTaoTableAdapter
            // 
            this.heDaoTaoTableAdapter.ClearBeforeFill = true;
            // 
            // trinhDoDaoTaoTableAdapter
            // 
            this.trinhDoDaoTaoTableAdapter.ClearBeforeFill = true;
            // 
            // FormKhoiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.dgvKhoiLop);
            this.Controls.Add(this.lblMaTDDT);
            this.Controls.Add(this.lblMaHeDT);
            this.Controls.Add(this.lblTenKhoiLop);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblMaKhoiLop);
            this.Controls.Add(this.cmbMaTDDT);
            this.Controls.Add(this.cmbMaHeDT);
            this.Controls.Add(this.txtTenKhoiLop);
            this.Controls.Add(this.txtMaKhoiLop);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "FormKhoiLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Khối Lớp";
            this.Load += new System.EventHandler(this.FormKhoiLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heDaoTaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_HeDaoTao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoDaoTaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPM_1DataSet_TrinhDoDaoTao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoiLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaKhoiLop;
        private System.Windows.Forms.TextBox txtTenKhoiLop;
        private System.Windows.Forms.ComboBox cmbMaHeDT;
        private System.Windows.Forms.ComboBox cmbMaTDDT;
        private System.Windows.Forms.Label lblMaKhoiLop;
        private System.Windows.Forms.Label lblTenKhoiLop;
        private System.Windows.Forms.Label lblMaHeDT;
        private System.Windows.Forms.Label lblMaTDDT;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.DataGridView dgvKhoiLop;
        private CNPM_1DataSet2 cNPM_1DataSet_HeDaoTao;
        private System.Windows.Forms.BindingSource heDaoTaoBindingSource;
        private QuanLyDiem.CNPM_1DataSet2TableAdapters.HeDaoTaoTableAdapter heDaoTaoTableAdapter;
        private CNPM_1DataSet3 cNPM_1DataSet_TrinhDoDaoTao;
        private System.Windows.Forms.BindingSource trinhDoDaoTaoBindingSource;
        private QuanLyDiem.CNPM_1DataSet3TableAdapters.TrinhDoDaoTaoTableAdapter trinhDoDaoTaoTableAdapter;
    }
}