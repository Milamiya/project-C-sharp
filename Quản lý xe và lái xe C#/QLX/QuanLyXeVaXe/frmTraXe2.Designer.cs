namespace QuanLyXeVaXe
{
    partial class frmTraXe2
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
            this.txtMaKH_Search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdNhapMaKL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdTim = new System.Windows.Forms.Button();
            this.dtpNgayTraXeThucTe = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKL = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmdThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKH_Search
            // 
            this.txtMaKH_Search.FormattingEnabled = true;
            this.txtMaKH_Search.Location = new System.Drawing.Point(104, 12);
            this.txtMaKH_Search.Name = "txtMaKH_Search";
            this.txtMaKH_Search.Size = new System.Drawing.Size(100, 21);
            this.txtMaKH_Search.TabIndex = 1;
            this.txtMaKH_Search.SelectedIndexChanged += new System.EventHandler(this.txtMaKH_Search_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(104, 101);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdNhapMaKL
            // 
            this.cmdNhapMaKL.Location = new System.Drawing.Point(215, 208);
            this.cmdNhapMaKL.Name = "cmdNhapMaKL";
            this.cmdNhapMaKL.Size = new System.Drawing.Size(75, 23);
            this.cmdNhapMaKL.TabIndex = 3;
            this.cmdNhapMaKL.Text = "Nhập kỷ luật";
            this.cmdNhapMaKL.UseVisualStyleBackColor = true;
            this.cmdNhapMaKL.Click += new System.EventHandler(this.cmdNhapMaKL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(374, 130);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã HĐ";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Enabled = false;
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(104, 127);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayHetHan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày hết hạn";
            // 
            // cmdTim
            // 
            this.cmdTim.Location = new System.Drawing.Point(114, 40);
            this.cmdTim.Name = "cmdTim";
            this.cmdTim.Size = new System.Drawing.Size(75, 23);
            this.cmdTim.TabIndex = 3;
            this.cmdTim.Text = "Tìm";
            this.cmdTim.UseVisualStyleBackColor = true;
            this.cmdTim.Click += new System.EventHandler(this.cmdTim_Click);
            // 
            // dtpNgayTraXeThucTe
            // 
            this.dtpNgayTraXeThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraXeThucTe.Location = new System.Drawing.Point(104, 210);
            this.dtpNgayTraXeThucTe.Name = "dtpNgayTraXeThucTe";
            this.dtpNgayTraXeThucTe.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayTraXeThucTe.TabIndex = 6;
            this.dtpNgayTraXeThucTe.ValueChanged += new System.EventHandler(this.dtpNgayTraXeThucTe_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày trả xe thực tế";
            // 
            // txtMaKL
            // 
            this.txtMaKL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaKL.FormattingEnabled = true;
            this.txtMaKL.Location = new System.Drawing.Point(103, 263);
            this.txtMaKL.Name = "txtMaKL";
            this.txtMaKL.Size = new System.Drawing.Size(100, 21);
            this.txtMaKL.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã kỉ luật";
            // 
            // txtmaKH
            // 
            this.txtmaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtmaKH.FormattingEnabled = true;
            this.txtmaKH.Location = new System.Drawing.Point(104, 70);
            this.txtmaKH.Name = "txtmaKH";
            this.txtmaKH.Size = new System.Drawing.Size(100, 21);
            this.txtmaKH.TabIndex = 1;
            this.txtmaKH.SelectedIndexChanged += new System.EventHandler(this.txtmaKH_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "(Dành cho khách hàng trả xe quá hạn)";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 315);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(732, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(183, 504);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(75, 23);
            this.cmdThem.TabIndex = 3;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // frmTraXe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 588);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtpNgayTraXeThucTe);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdNhapMaKL);
            this.Controls.Add(this.cmdTim);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKL);
            this.Controls.Add(this.txtmaKH);
            this.Controls.Add(this.txtMaKH_Search);
            this.Controls.Add(this.txtMaHD);
            this.Name = "frmTraXe2";
            this.Text = "frmTraXe2";
            this.Load += new System.EventHandler(this.frmTraXe2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtMaKH_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdNhapMaKL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdTim;
        private System.Windows.Forms.DateTimePicker dtpNgayTraXeThucTe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtMaKL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtmaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button cmdThem;
    }
}