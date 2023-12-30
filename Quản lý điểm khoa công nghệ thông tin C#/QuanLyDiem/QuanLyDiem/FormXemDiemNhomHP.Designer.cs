namespace QuanLyDiem
{
    partial class FormXemDiemNhomHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXemDiemNhomHP));
            this.cmbMaNhomHP = new System.Windows.Forms.ComboBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbMaHK = new System.Windows.Forms.ComboBox();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.lblMaNhomHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaNhomHP
            // 
            this.cmbMaNhomHP.Enabled = false;
            this.cmbMaNhomHP.FormattingEnabled = true;
            this.cmbMaNhomHP.Location = new System.Drawing.Point(504, 110);
            this.cmbMaNhomHP.Name = "cmbMaNhomHP";
            this.cmbMaNhomHP.Size = new System.Drawing.Size(104, 21);
            this.cmbMaNhomHP.TabIndex = 13;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(145, 170);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.Size = new System.Drawing.Size(463, 214);
            this.dgvKetQua.TabIndex = 12;
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTim.BackgroundImage")));
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTim.Location = new System.Drawing.Point(674, 104);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(72, 30);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "       Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(139, 50);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(500, 31);
            this.lblTittle.TabIndex = 7;
            this.lblTittle.Text = "Chức Năng Xem Điểm Của Nhóm Học Phần";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(609, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbMaHK
            // 
            this.cmbMaHK.FormattingEnabled = true;
            this.cmbMaHK.Location = new System.Drawing.Point(195, 110);
            this.cmbMaHK.Name = "cmbMaHK";
            this.cmbMaHK.Size = new System.Drawing.Size(121, 21);
            this.cmbMaHK.TabIndex = 16;
            this.cmbMaHK.SelectedValueChanged += new System.EventHandler(this.cmbMaHK_SelectedValueChanged);
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(140, 113);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(40, 13);
            this.lblMaHK.TabIndex = 15;
            this.lblMaHK.Text = "Mã HK";
            // 
            // lblMaNhomHP
            // 
            this.lblMaNhomHP.AutoSize = true;
            this.lblMaNhomHP.Location = new System.Drawing.Point(394, 113);
            this.lblMaNhomHP.Name = "lblMaNhomHP";
            this.lblMaNhomHP.Size = new System.Drawing.Size(104, 13);
            this.lblMaNhomHP.TabIndex = 8;
            this.lblMaNhomHP.Text = "Mã Nhóm Học Phần";
            // 
            // FormXemDiemNhomHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.cmbMaHK);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cmbMaNhomHP);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lblMaNhomHP);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormXemDiemNhomHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Năng Xem Điểm Nhóm Học Phần";
            this.Load += new System.EventHandler(this.FormXemDiemNhomHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaNhomHP;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbMaHK;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.Label lblMaNhomHP;
    }
}