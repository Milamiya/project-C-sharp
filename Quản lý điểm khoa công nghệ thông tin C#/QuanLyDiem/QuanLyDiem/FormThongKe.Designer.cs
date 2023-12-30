namespace QuanLyDiem
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblThongKeTheo = new System.Windows.Forms.Label();
            this.cmbThongKeTheo = new System.Windows.Forms.ComboBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.cmbMa = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.cmbXepLoai = new System.Windows.Forms.ComboBox();
            this.lblMaHK = new System.Windows.Forms.Label();
            this.cmbMaHK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(168, 21);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(423, 31);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Thống Kê Xếp Loại Học Tập Của SV";
            // 
            // lblThongKeTheo
            // 
            this.lblThongKeTheo.AutoSize = true;
            this.lblThongKeTheo.Location = new System.Drawing.Point(212, 76);
            this.lblThongKeTheo.Name = "lblThongKeTheo";
            this.lblThongKeTheo.Size = new System.Drawing.Size(82, 13);
            this.lblThongKeTheo.TabIndex = 1;
            this.lblThongKeTheo.Text = "Thống Kê Theo";
            // 
            // cmbThongKeTheo
            // 
            this.cmbThongKeTheo.FormattingEnabled = true;
            this.cmbThongKeTheo.Items.AddRange(new object[] {
            "Lớp",
            "Khối Lớp"});
            this.cmbThongKeTheo.Location = new System.Drawing.Point(300, 73);
            this.cmbThongKeTheo.Name = "cmbThongKeTheo";
            this.cmbThongKeTheo.Size = new System.Drawing.Size(112, 21);
            this.cmbThongKeTheo.TabIndex = 2;
            this.cmbThongKeTheo.SelectedValueChanged += new System.EventHandler(this.cmbThongKeTheo_SelectedValueChanged);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(418, 73);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(35, 13);
            this.lblMa.TabIndex = 3;
            this.lblMa.Text = "label1";
            this.lblMa.Visible = false;
            // 
            // cmbMa
            // 
            this.cmbMa.FormattingEnabled = true;
            this.cmbMa.Items.AddRange(new object[] {
            "Lớp",
            "Khối Lớp"});
            this.cmbMa.Location = new System.Drawing.Point(493, 70);
            this.cmbMa.Name = "cmbMa";
            this.cmbMa.Size = new System.Drawing.Size(112, 21);
            this.cmbMa.TabIndex = 2;
            this.cmbMa.Visible = false;
            // 
            // btnLoc
            // 
            this.btnLoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoc.BackgroundImage")));
            this.btnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoc.Location = new System.Drawing.Point(634, 70);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(72, 30);
            this.btnLoc.TabIndex = 20;
            this.btnLoc.Text = "      Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(206, 138);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(341, 247);
            this.dgvThongKe.TabIndex = 21;
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Location = new System.Drawing.Point(634, 397);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 30);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "      Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Location = new System.Drawing.Point(418, 100);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(49, 13);
            this.lblXepLoai.TabIndex = 24;
            this.lblXepLoai.Text = "Xếp Loại";
            // 
            // cmbXepLoai
            // 
            this.cmbXepLoai.FormattingEnabled = true;
            this.cmbXepLoai.Items.AddRange(new object[] {
            "Xuất Sắc",
            "Giỏi",
            "Khá",
            "Trung Bình",
            "Yếu",
            "Kém"});
            this.cmbXepLoai.Location = new System.Drawing.Point(493, 97);
            this.cmbXepLoai.Name = "cmbXepLoai";
            this.cmbXepLoai.Size = new System.Drawing.Size(112, 21);
            this.cmbXepLoai.TabIndex = 23;
            // 
            // lblMaHK
            // 
            this.lblMaHK.AutoSize = true;
            this.lblMaHK.Location = new System.Drawing.Point(48, 76);
            this.lblMaHK.Name = "lblMaHK";
            this.lblMaHK.Size = new System.Drawing.Size(40, 13);
            this.lblMaHK.TabIndex = 1;
            this.lblMaHK.Text = "Mã HK";
            // 
            // cmbMaHK
            // 
            this.cmbMaHK.FormattingEnabled = true;
            this.cmbMaHK.Items.AddRange(new object[] {
            "Lớp",
            "Khối Lớp"});
            this.cmbMaHK.Location = new System.Drawing.Point(94, 73);
            this.cmbMaHK.Name = "cmbMaHK";
            this.cmbMaHK.Size = new System.Drawing.Size(112, 21);
            this.cmbMaHK.TabIndex = 2;
            this.cmbMaHK.SelectedValueChanged += new System.EventHandler(this.cmbThongKeTheo_SelectedValueChanged);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.cmbXepLoai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.cmbMa);
            this.Controls.Add(this.cmbMaHK);
            this.Controls.Add(this.lblMaHK);
            this.Controls.Add(this.cmbThongKeTheo);
            this.Controls.Add(this.lblThongKeTheo);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Năng Thống Kê";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblThongKeTheo;
        private System.Windows.Forms.ComboBox cmbThongKeTheo;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.ComboBox cmbMa;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.ComboBox cmbXepLoai;
        private System.Windows.Forms.Label lblMaHK;
        private System.Windows.Forms.ComboBox cmbMaHK;
    }
}