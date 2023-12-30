namespace QuanLyXeVaXe
{
    partial class frmTraTienKhongLaiXe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbThanhToanHet = new System.Windows.Forms.RadioButton();
            this.rbTreXe = new System.Windows.Forms.RadioButton();
            this.rbMuonThanhToan = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTienPhatTheoNgay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayTraTienThucTe = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHanTraTien = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.cbTinhTrangThanhToan = new System.Windows.Forms.CheckBox();
            this.cmdThemTat = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdTim = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.ComboBox();
            this.cmdThanhToan = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbThanhToanHet);
            this.groupBox1.Controls.Add(this.rbTreXe);
            this.groupBox1.Controls.Add(this.rbMuonThanhToan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn hình thức thanh toán";
            // 
            // rbThanhToanHet
            // 
            this.rbThanhToanHet.AutoSize = true;
            this.rbThanhToanHet.Location = new System.Drawing.Point(261, 54);
            this.rbThanhToanHet.Name = "rbThanhToanHet";
            this.rbThanhToanHet.Size = new System.Drawing.Size(14, 13);
            this.rbThanhToanHet.TabIndex = 8;
            this.rbThanhToanHet.TabStop = true;
            this.rbThanhToanHet.UseVisualStyleBackColor = true;
            this.rbThanhToanHet.CheckedChanged += new System.EventHandler(this.rbThanhToanHet_CheckedChanged);
            // 
            // rbTreXe
            // 
            this.rbTreXe.AutoSize = true;
            this.rbTreXe.Location = new System.Drawing.Point(158, 54);
            this.rbTreXe.Name = "rbTreXe";
            this.rbTreXe.Size = new System.Drawing.Size(14, 13);
            this.rbTreXe.TabIndex = 8;
            this.rbTreXe.TabStop = true;
            this.rbTreXe.UseVisualStyleBackColor = true;
            this.rbTreXe.CheckedChanged += new System.EventHandler(this.rbTreXe_CheckedChanged);
            // 
            // rbMuonThanhToan
            // 
            this.rbMuonThanhToan.AutoSize = true;
            this.rbMuonThanhToan.Location = new System.Drawing.Point(44, 54);
            this.rbMuonThanhToan.Name = "rbMuonThanhToan";
            this.rbMuonThanhToan.Size = new System.Drawing.Size(14, 13);
            this.rbMuonThanhToan.TabIndex = 8;
            this.rbMuonThanhToan.TabStop = true;
            this.rbMuonThanhToan.UseVisualStyleBackColor = true;
            this.rbMuonThanhToan.CheckedChanged += new System.EventHandler(this.rbMuonThanhToan_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(140, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Trả hết xe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(10, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Thanh toán hết tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(237, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Thanh toán hết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTienPhatTheoNgay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dtpNgayTraTienThucTe);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpHanTraTien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 129);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // txtTienPhatTheoNgay
            // 
            this.txtTienPhatTheoNgay.Location = new System.Drawing.Point(782, 81);
            this.txtTienPhatTheoNgay.Name = "txtTienPhatTheoNgay";
            this.txtTienPhatTheoNgay.Size = new System.Drawing.Size(100, 20);
            this.txtTienPhatTheoNgay.TabIndex = 3;
            this.txtTienPhatTheoNgay.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(662, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày trả tiền thực tế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(628, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "SốTiền phạt quá hạn/Ngày";
            // 
            // dtpNgayTraTienThucTe
            // 
            this.dtpNgayTraTienThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraTienThucTe.Location = new System.Drawing.Point(782, 44);
            this.dtpNgayTraTienThucTe.Name = "dtpNgayTraTienThucTe";
            this.dtpNgayTraTienThucTe.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayTraTienThucTe.TabIndex = 4;
            this.dtpNgayTraTienThucTe.Visible = false;
            this.dtpNgayTraTienThucTe.ValueChanged += new System.EventHandler(this.dtpNgayTraTienThucTe_ValueChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(504, 62);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(411, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(411, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã HĐ";
            // 
            // dtpHanTraTien
            // 
            this.dtpHanTraTien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTraTien.Location = new System.Drawing.Point(504, 90);
            this.dtpHanTraTien.Name = "dtpHanTraTien";
            this.dtpHanTraTien.Size = new System.Drawing.Size(100, 20);
            this.dtpHanTraTien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(411, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hạn trả tiền";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(504, 34);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhachHang.TabIndex = 3;
            // 
            // cbTinhTrangThanhToan
            // 
            this.cbTinhTrangThanhToan.AutoSize = true;
            this.cbTinhTrangThanhToan.Location = new System.Drawing.Point(831, 531);
            this.cbTinhTrangThanhToan.Name = "cbTinhTrangThanhToan";
            this.cbTinhTrangThanhToan.Size = new System.Drawing.Size(15, 14);
            this.cbTinhTrangThanhToan.TabIndex = 21;
            this.cbTinhTrangThanhToan.UseVisualStyleBackColor = true;
            this.cbTinhTrangThanhToan.Visible = false;
            this.cbTinhTrangThanhToan.CheckedChanged += new System.EventHandler(this.cbTinhTrangThanhToan_CheckedChanged);
            // 
            // cmdThemTat
            // 
            this.cmdThemTat.Location = new System.Drawing.Point(329, 522);
            this.cmdThemTat.Name = "cmdThemTat";
            this.cmdThemTat.Size = new System.Drawing.Size(75, 23);
            this.cmdThemTat.TabIndex = 23;
            this.cmdThemTat.Text = "Thêm";
            this.cmdThemTat.UseVisualStyleBackColor = true;
            this.cmdThemTat.Visible = false;
            this.cmdThemTat.Click += new System.EventHandler(this.cmdThemTat_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(252, 522);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(75, 23);
            this.cmdThem.TabIndex = 22;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Visible = false;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(903, 160);
            this.dataGridView2.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(558, 130);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "KH thanh toán";
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(410, 522);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 23);
            this.cmdNext.TabIndex = 14;
            this.cmdNext.Text = "Next";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Visible = false;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // cmdTim
            // 
            this.cmdTim.Location = new System.Drawing.Point(314, 32);
            this.cmdTim.Name = "cmdTim";
            this.cmdTim.Size = new System.Drawing.Size(75, 23);
            this.cmdTim.TabIndex = 13;
            this.cmdTim.Text = "Tìm";
            this.cmdTim.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(785, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Xác nhận nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(719, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "NV thanh toán";
            // 
            // txtMaKH
            // 
            this.txtMaKH.FormattingEnabled = true;
            this.txtMaKH.Location = new System.Drawing.Point(128, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(121, 21);
            this.txtMaKH.TabIndex = 11;
            // 
            // cmdThanhToan
            // 
            this.cmdThanhToan.Location = new System.Drawing.Point(176, 522);
            this.cmdThanhToan.Name = "cmdThanhToan";
            this.cmdThanhToan.Size = new System.Drawing.Size(75, 23);
            this.cmdThanhToan.TabIndex = 15;
            this.cmdThanhToan.Text = "Thanh toán";
            this.cmdThanhToan.UseVisualStyleBackColor = true;
            this.cmdThanhToan.Visible = false;
            this.cmdThanhToan.Click += new System.EventHandler(this.cmdThanhToan_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaNhanVien.FormattingEnabled = true;
            this.txtMaNhanVien.Location = new System.Drawing.Point(803, 470);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(100, 21);
            this.txtMaNhanVien.TabIndex = 12;
            // 
            // frmTraTienKhongLaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(949, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbTinhTrangThanhToan);
            this.Controls.Add(this.cmdThemTat);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.cmdTim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.cmdThanhToan);
            this.Controls.Add(this.txtMaNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTraTienKhongLaiXe";
            this.Text = "frmTraTienKhongLaiXe";
            this.Load += new System.EventHandler(this.frmTraTienKhongLaiXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbThanhToanHet;
        private System.Windows.Forms.RadioButton rbTreXe;
        private System.Windows.Forms.RadioButton rbMuonThanhToan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTienPhatTheoNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayTraTienThucTe;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHanTraTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.CheckBox cbTinhTrangThanhToan;
        private System.Windows.Forms.Button cmdThemTat;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdTim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtMaKH;
        private System.Windows.Forms.Button cmdThanhToan;
        private System.Windows.Forms.ComboBox txtMaNhanVien;
    }
}