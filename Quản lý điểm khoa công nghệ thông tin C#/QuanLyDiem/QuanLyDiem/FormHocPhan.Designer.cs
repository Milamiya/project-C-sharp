namespace QuanLyDiem
{
    partial class FormHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocPhan));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblSoTC = new System.Windows.Forms.Label();
            this.lblSoTietTH = new System.Windows.Forms.Label();
            this.lblSoTietLT = new System.Windows.Forms.Label();
            this.lblPhanTramDQT = new System.Windows.Forms.Label();
            this.lblPhanTramDT = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.txtSoTietTH = new System.Windows.Forms.TextBox();
            this.txtSoTietLT = new System.Windows.Forms.TextBox();
            this.txtPhanTramDQT = new System.Windows.Forms.TextBox();
            this.txtPhanTramDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(658, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(465, 334);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(563, 334);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(658, 334);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.AllowUserToAddRows = false;
            this.dgvHocPhan.AllowUserToDeleteRows = false;
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Location = new System.Drawing.Point(12, 81);
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.ReadOnly = true;
            this.dgvHocPhan.Size = new System.Drawing.Size(432, 283);
            this.dgvHocPhan.TabIndex = 17;
            this.dgvHocPhan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Danh Mục Học Phần";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Location = new System.Drawing.Point(472, 81);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(73, 13);
            this.lblMaHP.TabIndex = 19;
            this.lblMaHP.Text = "Mã Học Phần";
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Location = new System.Drawing.Point(472, 116);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(77, 13);
            this.lblTenHP.TabIndex = 19;
            this.lblTenHP.Text = "Tên Học Phần";
            // 
            // lblSoTC
            // 
            this.lblSoTC.AutoSize = true;
            this.lblSoTC.Location = new System.Drawing.Point(472, 149);
            this.lblSoTC.Name = "lblSoTC";
            this.lblSoTC.Size = new System.Drawing.Size(58, 13);
            this.lblSoTC.TabIndex = 19;
            this.lblSoTC.Text = "Số Tín Chỉ";
            // 
            // lblSoTietTH
            // 
            this.lblSoTietTH.AutoSize = true;
            this.lblSoTietTH.Location = new System.Drawing.Point(472, 185);
            this.lblSoTietTH.Name = "lblSoTietTH";
            this.lblSoTietTH.Size = new System.Drawing.Size(98, 13);
            this.lblSoTietTH.TabIndex = 19;
            this.lblSoTietTH.Text = "Số Tiết Thực Hành";
            // 
            // lblSoTietLT
            // 
            this.lblSoTietLT.AutoSize = true;
            this.lblSoTietLT.Location = new System.Drawing.Point(472, 220);
            this.lblSoTietLT.Name = "lblSoTietLT";
            this.lblSoTietLT.Size = new System.Drawing.Size(91, 13);
            this.lblSoTietLT.TabIndex = 19;
            this.lblSoTietLT.Text = "Số Tiết Lý Thuyết";
            // 
            // lblPhanTramDQT
            // 
            this.lblPhanTramDQT.AutoSize = true;
            this.lblPhanTramDQT.Location = new System.Drawing.Point(472, 252);
            this.lblPhanTramDQT.Name = "lblPhanTramDQT";
            this.lblPhanTramDQT.Size = new System.Drawing.Size(136, 13);
            this.lblPhanTramDQT.TabIndex = 19;
            this.lblPhanTramDQT.Text = "Phần Trăm Điểm Quá Trình";
            // 
            // lblPhanTramDT
            // 
            this.lblPhanTramDT.AutoSize = true;
            this.lblPhanTramDT.Location = new System.Drawing.Point(472, 285);
            this.lblPhanTramDT.Name = "lblPhanTramDT";
            this.lblPhanTramDT.Size = new System.Drawing.Size(104, 13);
            this.lblPhanTramDT.TabIndex = 19;
            this.lblPhanTramDT.Text = "Phần Trăm Điểm Thi";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(616, 81);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(114, 20);
            this.txtMaHP.TabIndex = 20;
            this.txtMaHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHP_KeyPress);
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(616, 116);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(114, 20);
            this.txtTenHP.TabIndex = 20;
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(616, 149);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(114, 20);
            this.txtSoTC.TabIndex = 20;
            this.txtSoTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTC_KeyPress);
            // 
            // txtSoTietTH
            // 
            this.txtSoTietTH.Location = new System.Drawing.Point(616, 182);
            this.txtSoTietTH.Name = "txtSoTietTH";
            this.txtSoTietTH.Size = new System.Drawing.Size(114, 20);
            this.txtSoTietTH.TabIndex = 20;
            this.txtSoTietTH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTietTH_KeyPress);
            // 
            // txtSoTietLT
            // 
            this.txtSoTietLT.Location = new System.Drawing.Point(616, 220);
            this.txtSoTietLT.Name = "txtSoTietLT";
            this.txtSoTietLT.Size = new System.Drawing.Size(114, 20);
            this.txtSoTietLT.TabIndex = 20;
            this.txtSoTietLT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTietLT_KeyPress);
            // 
            // txtPhanTramDQT
            // 
            this.txtPhanTramDQT.Location = new System.Drawing.Point(616, 252);
            this.txtPhanTramDQT.Name = "txtPhanTramDQT";
            this.txtPhanTramDQT.Size = new System.Drawing.Size(114, 20);
            this.txtPhanTramDQT.TabIndex = 20;
            this.txtPhanTramDQT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanTramDQT_KeyPress);
            // 
            // txtPhanTramDT
            // 
            this.txtPhanTramDT.Location = new System.Drawing.Point(616, 285);
            this.txtPhanTramDT.Name = "txtPhanTramDT";
            this.txtPhanTramDT.Size = new System.Drawing.Size(114, 20);
            this.txtPhanTramDT.TabIndex = 20;
            this.txtPhanTramDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanTramDT_KeyPress);
            // 
            // FormHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.txtPhanTramDT);
            this.Controls.Add(this.txtPhanTramDQT);
            this.Controls.Add(this.txtSoTietLT);
            this.Controls.Add(this.txtSoTietTH);
            this.Controls.Add(this.txtSoTC);
            this.Controls.Add(this.txtTenHP);
            this.Controls.Add(this.txtMaHP);
            this.Controls.Add(this.lblPhanTramDT);
            this.Controls.Add(this.lblPhanTramDQT);
            this.Controls.Add(this.lblSoTietLT);
            this.Controls.Add(this.lblSoTC);
            this.Controls.Add(this.lblSoTietTH);
            this.Controls.Add(this.lblTenHP);
            this.Controls.Add(this.lblMaHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHocPhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Name = "FormHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Học Phần";
            this.Load += new System.EventHandler(this.FormHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label lblSoTC;
        private System.Windows.Forms.Label lblSoTietTH;
        private System.Windows.Forms.Label lblSoTietLT;
        private System.Windows.Forms.Label lblPhanTramDQT;
        private System.Windows.Forms.Label lblPhanTramDT;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.TextBox txtSoTietTH;
        private System.Windows.Forms.TextBox txtSoTietLT;
        private System.Windows.Forms.TextBox txtPhanTramDQT;
        private System.Windows.Forms.TextBox txtPhanTramDT;
    }
}