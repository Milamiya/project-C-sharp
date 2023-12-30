namespace QuanLyXeVaXe
{
    partial class frmTraXeKhongLaiXe
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
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.txtTinhTrangHong = new System.Windows.Forms.ComboBox();
            this.cbTinhTrangHD = new System.Windows.Forms.CheckBox();
            this.dtpNgayTraThucTe = new System.Windows.Forms.DateTimePicker();
            this.dtpHanTraXe = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdDong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdHoanTatThanhToa = new System.Windows.Forms.Button();
            this.frmChiTiet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChiPhiBoiThuong = new System.Windows.Forms.TextBox();
            this.txtTienMuonTheoNgay = new System.Windows.Forms.TextBox();
            this.txtTienThue = new System.Windows.Forms.TextBox();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.txtXe = new System.Windows.Forms.TextBox();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(224, 576);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.cmdRefresh.TabIndex = 42;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // txtTinhTrangHong
            // 
            this.txtTinhTrangHong.BackColor = System.Drawing.Color.White;
            this.txtTinhTrangHong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTinhTrangHong.FormattingEnabled = true;
            this.txtTinhTrangHong.Items.AddRange(new object[] {
            "Rat nho",
            "Nho",
            "Trung Binh",
            "Nhieu",
            "Rat nhieu"});
            this.txtTinhTrangHong.Location = new System.Drawing.Point(475, 215);
            this.txtTinhTrangHong.Name = "txtTinhTrangHong";
            this.txtTinhTrangHong.Size = new System.Drawing.Size(100, 21);
            this.txtTinhTrangHong.TabIndex = 41;
            // 
            // cbTinhTrangHD
            // 
            this.cbTinhTrangHD.AutoSize = true;
            this.cbTinhTrangHD.Location = new System.Drawing.Point(687, 524);
            this.cbTinhTrangHD.Name = "cbTinhTrangHD";
            this.cbTinhTrangHD.Size = new System.Drawing.Size(15, 14);
            this.cbTinhTrangHD.TabIndex = 40;
            this.cbTinhTrangHD.UseVisualStyleBackColor = true;
            this.cbTinhTrangHD.CheckedChanged += new System.EventHandler(this.cbTinhTrangHD_CheckedChanged);
            // 
            // dtpNgayTraThucTe
            // 
            this.dtpNgayTraThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraThucTe.Location = new System.Drawing.Point(239, 270);
            this.dtpNgayTraThucTe.Name = "dtpNgayTraThucTe";
            this.dtpNgayTraThucTe.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayTraThucTe.TabIndex = 38;
            this.dtpNgayTraThucTe.ValueChanged += new System.EventHandler(this.dtpNgayTraThucTe_ValueChanged);
            // 
            // dtpHanTraXe
            // 
            this.dtpHanTraXe.Enabled = false;
            this.dtpHanTraXe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTraXe.Location = new System.Drawing.Point(239, 236);
            this.dtpHanTraXe.Name = "dtpHanTraXe";
            this.dtpHanTraXe.Size = new System.Drawing.Size(100, 20);
            this.dtpHanTraXe.TabIndex = 39;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(73, 387);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(887, 113);
            this.dataGridView2.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(913, 113);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // cmdDong
            // 
            this.cmdDong.Location = new System.Drawing.Point(633, 235);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(93, 23);
            this.cmdDong.TabIndex = 33;
            this.cmdDong.Text = "Đóng lại";
            this.cmdDong.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Xem chi tiết hợp đồng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmdHoanTatThanhToa
            // 
            this.cmdHoanTatThanhToa.Location = new System.Drawing.Point(633, 544);
            this.cmdHoanTatThanhToa.Name = "cmdHoanTatThanhToa";
            this.cmdHoanTatThanhToa.Size = new System.Drawing.Size(135, 23);
            this.cmdHoanTatThanhToa.TabIndex = 35;
            this.cmdHoanTatThanhToa.Text = "Hoàn tất thanh toán";
            this.cmdHoanTatThanhToa.UseVisualStyleBackColor = true;
            this.cmdHoanTatThanhToa.Visible = false;
            this.cmdHoanTatThanhToa.Click += new System.EventHandler(this.cmdHoanTatThanhToa_Click);
            // 
            // frmChiTiet
            // 
            this.frmChiTiet.Location = new System.Drawing.Point(370, 7);
            this.frmChiTiet.Name = "frmChiTiet";
            this.frmChiTiet.Size = new System.Drawing.Size(135, 23);
            this.frmChiTiet.TabIndex = 34;
            this.frmChiTiet.Text = "Xem chi tiết hợp đồng";
            this.frmChiTiet.UseVisualStyleBackColor = true;
            this.frmChiTiet.Click += new System.EventHandler(this.frmChiTiet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(655, 507);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Xác nhận trả xe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Chi phí bồi thường";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tình trạng hỏng hóc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ngày trả xe thực tế";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Hạn trả xe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tiền thuê xe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Mã xe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tiền đặt cọc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tiền trả xe muộn/Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã hợp đồng";
            // 
            // txtChiPhiBoiThuong
            // 
            this.txtChiPhiBoiThuong.Location = new System.Drawing.Point(475, 245);
            this.txtChiPhiBoiThuong.Name = "txtChiPhiBoiThuong";
            this.txtChiPhiBoiThuong.Size = new System.Drawing.Size(100, 20);
            this.txtChiPhiBoiThuong.TabIndex = 12;
            // 
            // txtTienMuonTheoNgay
            // 
            this.txtTienMuonTheoNgay.Enabled = false;
            this.txtTienMuonTheoNgay.Location = new System.Drawing.Point(239, 304);
            this.txtTienMuonTheoNgay.Name = "txtTienMuonTheoNgay";
            this.txtTienMuonTheoNgay.Size = new System.Drawing.Size(100, 20);
            this.txtTienMuonTheoNgay.TabIndex = 13;
            // 
            // txtTienThue
            // 
            this.txtTienThue.Enabled = false;
            this.txtTienThue.Location = new System.Drawing.Point(475, 181);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.Size = new System.Drawing.Size(100, 20);
            this.txtTienThue.TabIndex = 10;
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Enabled = false;
            this.txtTienDatCoc.Location = new System.Drawing.Point(475, 155);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(100, 20);
            this.txtTienDatCoc.TabIndex = 11;
            // 
            // txtXe
            // 
            this.txtXe.Enabled = false;
            this.txtXe.Location = new System.Drawing.Point(239, 207);
            this.txtXe.Name = "txtXe";
            this.txtXe.Size = new System.Drawing.Size(100, 20);
            this.txtXe.TabIndex = 14;
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Enabled = false;
            this.txtChiTiet.Location = new System.Drawing.Point(239, 153);
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(100, 20);
            this.txtChiTiet.TabIndex = 18;
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Enabled = false;
            this.txtMaHopDong.Location = new System.Drawing.Point(239, 181);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(100, 20);
            this.txtMaHopDong.TabIndex = 15;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(264, 8);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 16;
            // 
            // frmTraXeKhongLaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 667);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.txtTinhTrangHong);
            this.Controls.Add(this.cbTinhTrangHD);
            this.Controls.Add(this.dtpNgayTraThucTe);
            this.Controls.Add(this.dtpHanTraXe);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdHoanTatThanhToa);
            this.Controls.Add(this.frmChiTiet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChiPhiBoiThuong);
            this.Controls.Add(this.txtTienMuonTheoNgay);
            this.Controls.Add(this.txtTienThue);
            this.Controls.Add(this.txtTienDatCoc);
            this.Controls.Add(this.txtXe);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.txtMaHD);
            this.Name = "frmTraXeKhongLaiXe";
            this.Text = "frmTraXeKhongLaiXe";
            this.Load += new System.EventHandler(this.frmTraXeKhongLaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.ComboBox txtTinhTrangHong;
        private System.Windows.Forms.CheckBox cbTinhTrangHD;
        private System.Windows.Forms.DateTimePicker dtpNgayTraThucTe;
        private System.Windows.Forms.DateTimePicker dtpHanTraXe;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdDong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdHoanTatThanhToa;
        private System.Windows.Forms.Button frmChiTiet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChiPhiBoiThuong;
        private System.Windows.Forms.TextBox txtTienMuonTheoNgay;
        private System.Windows.Forms.TextBox txtTienThue;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.TextBox txtXe;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.TextBox txtMaHD;
    }
}