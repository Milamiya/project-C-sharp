namespace QuanLyXeVaXe
{
    partial class frmTraXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieuTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayTraXeThucTe = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.ComboBox();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdNhapVao = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdTimKiem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtMaHD_Search = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.ComboBox();
            this.txtMaKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu trả";
            // 
            // txtMaPhieuTra
            // 
            this.txtMaPhieuTra.Location = new System.Drawing.Point(207, 214);
            this.txtMaPhieuTra.Name = "txtMaPhieuTra";
            this.txtMaPhieuTra.Size = new System.Drawing.Size(121, 20);
            this.txtMaPhieuTra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày trả xe thực tế";
            // 
            // dtpNgayTraXeThucTe
            // 
            this.dtpNgayTraXeThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraXeThucTe.Location = new System.Drawing.Point(210, 311);
            this.dtpNgayTraXeThucTe.Name = "dtpNgayTraXeThucTe";
            this.dtpNgayTraXeThucTe.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayTraXeThucTe.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.FormattingEnabled = true;
            this.txtMaNV.Location = new System.Drawing.Point(208, 274);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(121, 21);
            this.txtMaNV.TabIndex = 0;
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(360, 214);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 23);
            this.cmdNext.TabIndex = 5;
            this.cmdNext.Text = "Next ";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // cmdNhapVao
            // 
            this.cmdNhapVao.Location = new System.Drawing.Point(360, 180);
            this.cmdNhapVao.Name = "cmdNhapVao";
            this.cmdNhapVao.Size = new System.Drawing.Size(75, 23);
            this.cmdNhapVao.TabIndex = 6;
            this.cmdNhapVao.Text = "Đến";
            this.cmdNhapVao.UseVisualStyleBackColor = true;
            this.cmdNhapVao.Click += new System.EventHandler(this.cmdNhapVao_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 168);
            this.dataGridView1.TabIndex = 7;
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(363, 249);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(72, 25);
            this.cmdThem.TabIndex = 8;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhập vào mã HĐ cần trả";
            // 
            // cmdTimKiem
            // 
            this.cmdTimKiem.Location = new System.Drawing.Point(373, 7);
            this.cmdTimKiem.Name = "cmdTimKiem";
            this.cmdTimKiem.Size = new System.Drawing.Size(75, 23);
            this.cmdTimKiem.TabIndex = 10;
            this.cmdTimKiem.Text = "Tìm kiếm";
            this.cmdTimKiem.UseVisualStyleBackColor = true;
            this.cmdTimKiem.Click += new System.EventHandler(this.cmdTimKiem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(749, 87);
            this.dataGridView2.TabIndex = 11;
            // 
            // txtMaHD_Search
            // 
            this.txtMaHD_Search.FormattingEnabled = true;
            this.txtMaHD_Search.Location = new System.Drawing.Point(207, 9);
            this.txtMaHD_Search.Name = "txtMaHD_Search";
            this.txtMaHD_Search.Size = new System.Drawing.Size(121, 21);
            this.txtMaHD_Search.TabIndex = 13;
            this.txtMaHD_Search.SelectedIndexChanged += new System.EventHandler(this.txtMaHD_Search_SelectedIndexChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.FormattingEnabled = true;
            this.txtMaHD.Location = new System.Drawing.Point(207, 174);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(121, 21);
            this.txtMaHD.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.FormattingEnabled = true;
            this.txtMaKH.Location = new System.Drawing.Point(207, 247);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(121, 21);
            this.txtMaKH.TabIndex = 0;
            // 
            // frmTraXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 556);
            this.Controls.Add(this.txtMaHD_Search);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmdTimKiem);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdNhapVao);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.dtpNgayTraXeThucTe);
            this.Controls.Add(this.txtMaPhieuTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtMaNV);
            this.Name = "frmTraXe";
            this.Text = "frmTraXe";
            this.Load += new System.EventHandler(this.frmTraXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieuTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayTraXeThucTe;
        private System.Windows.Forms.ComboBox txtMaNV;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdNhapVao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdTimKiem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox txtMaHD_Search;
        private System.Windows.Forms.ComboBox txtMaHD;
        private System.Windows.Forms.ComboBox txtMaKH;

    }
}