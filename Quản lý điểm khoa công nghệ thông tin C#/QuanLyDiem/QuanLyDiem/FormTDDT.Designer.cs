namespace QuanLyDiem
{
    partial class FormTDDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTDDT));
            this.dgvTDDT = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaTDDT = new System.Windows.Forms.TextBox();
            this.txtTenTDDT = new System.Windows.Forms.TextBox();
            this.lblMaTDDT = new System.Windows.Forms.Label();
            this.lblTenTDDT = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDDT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTDDT
            // 
            this.dgvTDDT.AllowUserToAddRows = false;
            this.dgvTDDT.AllowUserToDeleteRows = false;
            this.dgvTDDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTDDT.Location = new System.Drawing.Point(83, 122);
            this.dgvTDDT.Name = "dgvTDDT";
            this.dgvTDDT.ReadOnly = true;
            this.dgvTDDT.Size = new System.Drawing.Size(245, 240);
            this.dgvTDDT.TabIndex = 0;
            this.dgvTDDT.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTDDT_RowEnter);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(641, 249);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(531, 249);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(417, 249);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(641, 366);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaTDDT
            // 
            this.txtMaTDDT.Location = new System.Drawing.Point(506, 142);
            this.txtMaTDDT.Name = "txtMaTDDT";
            this.txtMaTDDT.Size = new System.Drawing.Size(136, 20);
            this.txtMaTDDT.TabIndex = 2;
            this.txtMaTDDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaTDDT_KeyPress);
            // 
            // txtTenTDDT
            // 
            this.txtTenTDDT.Location = new System.Drawing.Point(506, 189);
            this.txtTenTDDT.Name = "txtTenTDDT";
            this.txtTenTDDT.Size = new System.Drawing.Size(136, 20);
            this.txtTenTDDT.TabIndex = 2;
            // 
            // lblMaTDDT
            // 
            this.lblMaTDDT.AutoSize = true;
            this.lblMaTDDT.Location = new System.Drawing.Point(393, 142);
            this.lblMaTDDT.Name = "lblMaTDDT";
            this.lblMaTDDT.Size = new System.Drawing.Size(55, 13);
            this.lblMaTDDT.TabIndex = 3;
            this.lblMaTDDT.Text = "Mã TĐĐT";
            // 
            // lblTenTDDT
            // 
            this.lblTenTDDT.AutoSize = true;
            this.lblTenTDDT.Location = new System.Drawing.Point(393, 189);
            this.lblTenTDDT.Name = "lblTenTDDT";
            this.lblTenTDDT.Size = new System.Drawing.Size(59, 13);
            this.lblTenTDDT.TabIndex = 3;
            this.lblTenTDDT.Text = "Tên TĐĐT";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(52, 56);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(339, 31);
            this.lblTittle.TabIndex = 3;
            this.lblTittle.Text = "Danh Mục Trình Độ Đào Tạo";
            // 
            // FormTDDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.lblTenTDDT);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblMaTDDT);
            this.Controls.Add(this.txtTenTDDT);
            this.Controls.Add(this.txtMaTDDT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvTDDT);
            this.Name = "FormTDDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Trình Độ Đào Tạo";
            this.Load += new System.EventHandler(this.FormTDDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTDDT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaTDDT;
        private System.Windows.Forms.TextBox txtTenTDDT;
        private System.Windows.Forms.Label lblMaTDDT;
        private System.Windows.Forms.Label lblTenTDDT;
        private System.Windows.Forms.Label lblTittle;
    }
}