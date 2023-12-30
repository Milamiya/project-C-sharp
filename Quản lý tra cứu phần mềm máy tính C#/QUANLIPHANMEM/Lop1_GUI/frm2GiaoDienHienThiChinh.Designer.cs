namespace Lop1_GUI
{
    partial class frm2HienThiChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2HienThiChinh));
            this.cboLoaiPM = new System.Windows.Forms.ComboBox();
            this.dgwSanPham = new System.Windows.Forms.DataGridView();
            this.maphanmem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstLoadDauTien = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTIM = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbotimHDH = new System.Windows.Forms.ComboBox();
            this.PIC_TIMKIEM = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PIC_EXIT = new System.Windows.Forms.PictureBox();
            this.iex = new System.ServiceProcess.ServiceController();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_TIMKIEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_EXIT)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiPM
            // 
            this.cboLoaiPM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboLoaiPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cboLoaiPM.FormattingEnabled = true;
            this.cboLoaiPM.Location = new System.Drawing.Point(468, 88);
            this.cboLoaiPM.Name = "cboLoaiPM";
            this.cboLoaiPM.Size = new System.Drawing.Size(150, 26);
            this.cboLoaiPM.TabIndex = 0;
            this.cboLoaiPM.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPM_SelectedIndexChanged);
            // 
            // dgwSanPham
            // 
            this.dgwSanPham.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgwSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphanmem,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgwSanPham.Location = new System.Drawing.Point(468, 120);
            this.dgwSanPham.Name = "dgwSanPham";
            this.dgwSanPham.Size = new System.Drawing.Size(543, 272);
            this.dgwSanPham.TabIndex = 1;
            this.dgwSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSanPham_CellClick);
            this.dgwSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSanPham_CellContentClick);
            // 
            // maphanmem
            // 
            this.maphanmem.DataPropertyName = "MaPhanMem";
            this.maphanmem.HeaderText = "Mã PM";
            this.maphanmem.Name = "maphanmem";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenPhanMem";
            this.Column1.FillWeight = 300F;
            this.Column1.HeaderText = "Tên PM";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HeDieuHanh";
            this.Column2.HeaderText = "Hệ Điều Hành";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LinkDown";
            this.Column3.HeaderText = "LinkDown";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaPL";
            this.Column4.HeaderText = "Mã PL";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(463, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại Phần Mềm";
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.DarkGray;
            this.btnChinhSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.BackgroundImage")));
            this.btnChinhSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(769, 74);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(245, 40);
            this.btnChinhSua.TabIndex = 2;
            this.btnChinhSua.Text = "Chỉnh Sữa Dữ Liệu";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 6;
            // 
            // lstLoadDauTien
            // 
            this.lstLoadDauTien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lstLoadDauTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLoadDauTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstLoadDauTien.FormattingEnabled = true;
            this.lstLoadDauTien.ItemHeight = 18;
            this.lstLoadDauTien.Location = new System.Drawing.Point(6, 26);
            this.lstLoadDauTien.Name = "lstLoadDauTien";
            this.lstLoadDauTien.Size = new System.Drawing.Size(198, 238);
            this.lstLoadDauTien.TabIndex = 0;
            this.lstLoadDauTien.Click += new System.EventHandler(this.lstLoadDauTien_Click);
            this.lstLoadDauTien.SelectedIndexChanged += new System.EventHandler(this.lstLoadDauTien_SelectedIndexChanged);
            this.lstLoadDauTien.SelectedValueChanged += new System.EventHandler(this.lstLoadDauTien_SelectedValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(18, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(889, 135);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 177);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết Phần Mềm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Phần Mềm,\r";
            // 
            // txtTIM
            // 
            this.txtTIM.Location = new System.Drawing.Point(10, 58);
            this.txtTIM.Name = "txtTIM";
            this.txtTIM.Size = new System.Drawing.Size(204, 29);
            this.txtTIM.TabIndex = 0;
            this.txtTIM.Text = "(ví dụ :Plex)";
            this.txtTIM.DoubleClick += new System.EventHandler(this.txtTIM_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lstLoadDauTien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 272);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HỆ ĐIỀU HÀNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(65, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(888, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = " Phần Mềm Quản Lý Tra Cứu  Phần Mềm";
            this.label2.UseWaitCursor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cbotimHDH);
            this.groupBox4.Controls.Add(this.PIC_TIMKIEM);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTIM);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(228, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 272);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TÌM KIẾM THEO";
            // 
            // cbotimHDH
            // 
            this.cbotimHDH.FormattingEnabled = true;
            this.cbotimHDH.Items.AddRange(new object[] {
            "WIN",
            "MAC",
            "MOBILE"});
            this.cbotimHDH.Location = new System.Drawing.Point(10, 117);
            this.cbotimHDH.Name = "cbotimHDH";
            this.cbotimHDH.Size = new System.Drawing.Size(204, 32);
            this.cbotimHDH.TabIndex = 21;
            this.cbotimHDH.SelectedIndexChanged += new System.EventHandler(this.cbotimHDH_SelectedIndexChanged);
            // 
            // PIC_TIMKIEM
            // 
            this.PIC_TIMKIEM.Image = ((System.Drawing.Image)(resources.GetObject("PIC_TIMKIEM.Image")));
            this.PIC_TIMKIEM.Location = new System.Drawing.Point(30, 153);
            this.PIC_TIMKIEM.Name = "PIC_TIMKIEM";
            this.PIC_TIMKIEM.Size = new System.Drawing.Size(165, 111);
            this.PIC_TIMKIEM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_TIMKIEM.TabIndex = 20;
            this.PIC_TIMKIEM.TabStop = false;
            this.PIC_TIMKIEM.Click += new System.EventHandler(this.PIC_TIMKIEM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hệ Điều Hành";
            // 
            // PIC_EXIT
            // 
            this.PIC_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("PIC_EXIT.Image")));
            this.PIC_EXIT.Location = new System.Drawing.Point(959, 530);
            this.PIC_EXIT.Name = "PIC_EXIT";
            this.PIC_EXIT.Size = new System.Drawing.Size(55, 56);
            this.PIC_EXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_EXIT.TabIndex = 21;
            this.PIC_EXIT.TabStop = false;
            this.PIC_EXIT.Click += new System.EventHandler(this.PIC_EXIT_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(943, 480);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(71, 44);
            this.btnIn.TabIndex = 23;
            this.btnIn.Text = "In Bảng Phần Mềm";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frm2HienThiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1026, 598);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.PIC_EXIT);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwSanPham);
            this.Controls.Add(this.cboLoaiPM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm2HienThiChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Điều Hành";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.frm2HienThiChinh_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_TIMKIEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_EXIT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoaiPM;
        private System.Windows.Forms.DataGridView dgwSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstLoadDauTien;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTIM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox PIC_TIMKIEM;
        private System.Windows.Forms.PictureBox PIC_EXIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphanmem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbotimHDH;
        private System.Windows.Forms.Label label4;
        private System.ServiceProcess.ServiceController iex;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnIn;

    }
}

