namespace QuanLyDiem
{
    partial class FormHeDaoTao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeDaoTao));
            this.lblTenHeDT = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaHeDT = new System.Windows.Forms.Label();
            this.txtTenHeDT = new System.Windows.Forms.TextBox();
            this.txtMaHeDT = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvHeDaoTao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeDaoTao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenHeDT
            // 
            this.lblTenHeDT.AutoSize = true;
            this.lblTenHeDT.Location = new System.Drawing.Point(390, 191);
            this.lblTenHeDT.Name = "lblTenHeDT";
            this.lblTenHeDT.Size = new System.Drawing.Size(59, 13);
            this.lblTenHeDT.TabIndex = 11;
            this.lblTenHeDT.Text = "Tên TĐĐT";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(74, 59);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(270, 31);
            this.lblTittle.TabIndex = 12;
            this.lblTittle.Text = "Danh Mục Hệ Đào Tạo";
            // 
            // lblMaHeDT
            // 
            this.lblMaHeDT.AutoSize = true;
            this.lblMaHeDT.Location = new System.Drawing.Point(390, 144);
            this.lblMaHeDT.Name = "lblMaHeDT";
            this.lblMaHeDT.Size = new System.Drawing.Size(55, 13);
            this.lblMaHeDT.TabIndex = 13;
            this.lblMaHeDT.Text = "Mã TĐĐT";
            // 
            // txtTenHeDT
            // 
            this.txtTenHeDT.Location = new System.Drawing.Point(503, 191);
            this.txtTenHeDT.Name = "txtTenHeDT";
            this.txtTenHeDT.Size = new System.Drawing.Size(136, 20);
            this.txtTenHeDT.TabIndex = 9;
            // 
            // txtMaHeDT
            // 
            this.txtMaHeDT.Location = new System.Drawing.Point(503, 144);
            this.txtMaHeDT.Name = "txtMaHeDT";
            this.txtMaHeDT.Size = new System.Drawing.Size(136, 20);
            this.txtMaHeDT.TabIndex = 10;
            this.txtMaHeDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHeDT_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(638, 334);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(414, 251);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "    Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Location = new System.Drawing.Point(528, 251);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 30);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "     Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(638, 251);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 30);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "     Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvHeDaoTao
            // 
            this.dgvHeDaoTao.AllowUserToAddRows = false;
            this.dgvHeDaoTao.AllowUserToDeleteRows = false;
            this.dgvHeDaoTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeDaoTao.Location = new System.Drawing.Point(80, 124);
            this.dgvHeDaoTao.Name = "dgvHeDaoTao";
            this.dgvHeDaoTao.ReadOnly = true;
            this.dgvHeDaoTao.Size = new System.Drawing.Size(245, 240);
            this.dgvHeDaoTao.TabIndex = 4;
            this.dgvHeDaoTao.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeDaoTao_RowEnter);
            // 
            // FormHeDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.lblTenHeDT);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblMaHeDT);
            this.Controls.Add(this.txtTenHeDT);
            this.Controls.Add(this.txtMaHeDT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvHeDaoTao);
            this.Name = "FormHeDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Hệ Đào Tạo";
            this.Load += new System.EventHandler(this.FormHeDaoTao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeDaoTao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenHeDT;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaHeDT;
        private System.Windows.Forms.TextBox txtTenHeDT;
        private System.Windows.Forms.TextBox txtMaHeDT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvHeDaoTao;
    }
}