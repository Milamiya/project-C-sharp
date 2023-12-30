namespace QuanLyXeVaXe
{
    partial class frmTraXeThoi
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
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdChiTiet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpHanTraXe = new System.Windows.Forms.DateTimePicker();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLaiXe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayTraThucTe = new System.Windows.Forms.DateTimePicker();
            this.txtTienMuonTheoNgay = new System.Windows.Forms.TextBox();
            this.lbTienTraXeMuonTheoNgay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChiPhiBoiThuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmdHoanTatThanhToa = new System.Windows.Forms.Button();
            this.cbTinhTrangHD = new System.Windows.Forms.CheckBox();
            this.txtTinhTrangHong = new System.Windows.Forms.ComboBox();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.rbTraXeCoLai = new System.Windows.Forms.RadioButton();
            this.rbTraXeKoLai = new System.Windows.Forms.RadioButton();
            this.cmdHoanTatKoLaiXe = new System.Windows.Forms.Button();
            this.cmdRefreshKoLaiXe = new System.Windows.Forms.Button();
            this.cmdXemChiTietKoLaiXe = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(491, 16);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(189, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(380, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã hợp đồng";
            // 
            // cmdChiTiet
            // 
            this.cmdChiTiet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChiTiet.Location = new System.Drawing.Point(687, -1);
            this.cmdChiTiet.Name = "cmdChiTiet";
            this.cmdChiTiet.Size = new System.Drawing.Size(64, 54);
            this.cmdChiTiet.TabIndex = 2;
            this.cmdChiTiet.Text = "Xem chi tiết hợp đồng";
            this.cmdChiTiet.UseVisualStyleBackColor = true;
            this.cmdChiTiet.Visible = false;
            this.cmdChiTiet.Click += new System.EventHandler(this.frmChiTiet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(818, 99);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dtpHanTraXe
            // 
            this.dtpHanTraXe.Enabled = false;
            this.dtpHanTraXe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTraXe.Location = new System.Drawing.Point(240, 121);
            this.dtpHanTraXe.Name = "dtpHanTraXe";
            this.dtpHanTraXe.Size = new System.Drawing.Size(100, 20);
            this.dtpHanTraXe.TabIndex = 4;
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Enabled = false;
            this.txtMaHopDong.Location = new System.Drawing.Point(240, 42);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(100, 20);
            this.txtMaHopDong.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(139, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hợp đồng";
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Enabled = false;
            this.txtChiTiet.Location = new System.Drawing.Point(240, 19);
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(100, 20);
            this.txtChiTiet.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(161, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chi tiết";
            // 
            // txtLaiXe
            // 
            this.txtLaiXe.Location = new System.Drawing.Point(240, 92);
            this.txtLaiXe.Name = "txtLaiXe";
            this.txtLaiXe.Size = new System.Drawing.Size(100, 20);
            this.txtLaiXe.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(161, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã lái xe";
            // 
            // dtpNgayTraThucTe
            // 
            this.dtpNgayTraThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraThucTe.Location = new System.Drawing.Point(534, 23);
            this.dtpNgayTraThucTe.Name = "dtpNgayTraThucTe";
            this.dtpNgayTraThucTe.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayTraThucTe.TabIndex = 4;
            this.dtpNgayTraThucTe.ValueChanged += new System.EventHandler(this.dtpNgayTraThucTe_ValueChanged);
            // 
            // txtTienMuonTheoNgay
            // 
            this.txtTienMuonTheoNgay.Location = new System.Drawing.Point(534, 58);
            this.txtTienMuonTheoNgay.Name = "txtTienMuonTheoNgay";
            this.txtTienMuonTheoNgay.Size = new System.Drawing.Size(100, 20);
            this.txtTienMuonTheoNgay.TabIndex = 0;
            this.txtTienMuonTheoNgay.Visible = false;
            // 
            // lbTienTraXeMuonTheoNgay
            // 
            this.lbTienTraXeMuonTheoNgay.AutoSize = true;
            this.lbTienTraXeMuonTheoNgay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienTraXeMuonTheoNgay.ForeColor = System.Drawing.Color.Yellow;
            this.lbTienTraXeMuonTheoNgay.Location = new System.Drawing.Point(392, 61);
            this.lbTienTraXeMuonTheoNgay.Name = "lbTienTraXeMuonTheoNgay";
            this.lbTienTraXeMuonTheoNgay.Size = new System.Drawing.Size(131, 15);
            this.lbTienTraXeMuonTheoNgay.TabIndex = 1;
            this.lbTienTraXeMuonTheoNgay.Text = "Tiền trả xe muộn/Ngày";
            this.lbTienTraXeMuonTheoNgay.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(410, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tình trạng hỏng hóc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(144, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hạn trả xe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(411, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày trả xe thực tế";
            // 
            // txtXe
            // 
            this.txtXe.Enabled = false;
            this.txtXe.Location = new System.Drawing.Point(240, 65);
            this.txtXe.Name = "txtXe";
            this.txtXe.Size = new System.Drawing.Size(100, 20);
            this.txtXe.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(164, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã xe";
            // 
            // txtChiPhiBoiThuong
            // 
            this.txtChiPhiBoiThuong.Location = new System.Drawing.Point(534, 119);
            this.txtChiPhiBoiThuong.Name = "txtChiPhiBoiThuong";
            this.txtChiPhiBoiThuong.Size = new System.Drawing.Size(100, 20);
            this.txtChiPhiBoiThuong.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(410, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Chi phí bồi thường";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 382);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(819, 110);
            this.dataGridView2.TabIndex = 3;
            // 
            // cmdHoanTatThanhToa
            // 
            this.cmdHoanTatThanhToa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHoanTatThanhToa.Location = new System.Drawing.Point(616, 530);
            this.cmdHoanTatThanhToa.Name = "cmdHoanTatThanhToa";
            this.cmdHoanTatThanhToa.Size = new System.Drawing.Size(83, 63);
            this.cmdHoanTatThanhToa.TabIndex = 2;
            this.cmdHoanTatThanhToa.Text = "Hoàn tất thanh toán";
            this.cmdHoanTatThanhToa.UseVisualStyleBackColor = true;
            this.cmdHoanTatThanhToa.Visible = false;
            this.cmdHoanTatThanhToa.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cbTinhTrangHD
            // 
            this.cbTinhTrangHD.AutoSize = true;
            this.cbTinhTrangHD.Location = new System.Drawing.Point(650, 512);
            this.cbTinhTrangHD.Name = "cbTinhTrangHD";
            this.cbTinhTrangHD.Size = new System.Drawing.Size(15, 14);
            this.cbTinhTrangHD.TabIndex = 7;
            this.cbTinhTrangHD.UseVisualStyleBackColor = true;
            this.cbTinhTrangHD.CheckedChanged += new System.EventHandler(this.cbTinhTrangHD_CheckedChanged);
            // 
            // txtTinhTrangHong
            // 
            this.txtTinhTrangHong.BackColor = System.Drawing.Color.White;
            this.txtTinhTrangHong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTinhTrangHong.FormattingEnabled = true;
            this.txtTinhTrangHong.Items.AddRange(new object[] {
            "Khong hong hoc",
            "Rat nho",
            "Nho",
            "Trung Binh",
            "Nhieu",
            "Rat Nhieu"});
            this.txtTinhTrangHong.Location = new System.Drawing.Point(534, 87);
            this.txtTinhTrangHong.Name = "txtTinhTrangHong";
            this.txtTinhTrangHong.Size = new System.Drawing.Size(100, 21);
            this.txtTinhTrangHong.TabIndex = 8;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdRefresh.Location = new System.Drawing.Point(90, 531);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 63);
            this.cmdRefresh.TabIndex = 9;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Visible = false;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dtpNgayTraThucTe);
            this.groupBox1.Controls.Add(this.txtTienMuonTheoNgay);
            this.groupBox1.Controls.Add(this.txtTinhTrangHong);
            this.groupBox1.Controls.Add(this.dtpHanTraXe);
            this.groupBox1.Controls.Add(this.txtChiPhiBoiThuong);
            this.groupBox1.Controls.Add(this.lbTienTraXeMuonTheoNgay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMaHopDong);
            this.groupBox1.Controls.Add(this.txtChiTiet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLaiXe);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtXe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 149);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(342, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Detail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(613, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Xác nhận trả xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(-1, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chi tiết hợp đồng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(819, 10);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(820, 10);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(2, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Chi tiết phiếu trả";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, -4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(10, 61);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rbTraXeCoLai
            // 
            this.rbTraXeCoLai.AutoSize = true;
            this.rbTraXeCoLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTraXeCoLai.ForeColor = System.Drawing.Color.Yellow;
            this.rbTraXeCoLai.Location = new System.Drawing.Point(41, 4);
            this.rbTraXeCoLai.Name = "rbTraXeCoLai";
            this.rbTraXeCoLai.Size = new System.Drawing.Size(106, 19);
            this.rbTraXeCoLai.TabIndex = 13;
            this.rbTraXeCoLai.TabStop = true;
            this.rbTraXeCoLai.Text = "Trả xe có lái xe";
            this.rbTraXeCoLai.UseVisualStyleBackColor = true;
            this.rbTraXeCoLai.CheckedChanged += new System.EventHandler(this.rbTraXeCoLai_CheckedChanged);
            // 
            // rbTraXeKoLai
            // 
            this.rbTraXeKoLai.AutoSize = true;
            this.rbTraXeKoLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbTraXeKoLai.ForeColor = System.Drawing.Color.Yellow;
            this.rbTraXeKoLai.Location = new System.Drawing.Point(41, 27);
            this.rbTraXeKoLai.Name = "rbTraXeKoLai";
            this.rbTraXeKoLai.Size = new System.Drawing.Size(129, 19);
            this.rbTraXeKoLai.TabIndex = 13;
            this.rbTraXeKoLai.TabStop = true;
            this.rbTraXeKoLai.Text = "Trả xe không lái xe";
            this.rbTraXeKoLai.UseVisualStyleBackColor = true;
            this.rbTraXeKoLai.CheckedChanged += new System.EventHandler(this.rbTraXeKoLai_CheckedChanged);
            // 
            // cmdHoanTatKoLaiXe
            // 
            this.cmdHoanTatKoLaiXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdHoanTatKoLaiXe.Location = new System.Drawing.Point(616, 532);
            this.cmdHoanTatKoLaiXe.Name = "cmdHoanTatKoLaiXe";
            this.cmdHoanTatKoLaiXe.Size = new System.Drawing.Size(83, 63);
            this.cmdHoanTatKoLaiXe.TabIndex = 14;
            this.cmdHoanTatKoLaiXe.Text = "Hoàn tất thanh toán";
            this.cmdHoanTatKoLaiXe.UseVisualStyleBackColor = true;
            this.cmdHoanTatKoLaiXe.Visible = false;
            this.cmdHoanTatKoLaiXe.Click += new System.EventHandler(this.cmdHoanTatKoLaiXe_Click);
            // 
            // cmdRefreshKoLaiXe
            // 
            this.cmdRefreshKoLaiXe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdRefreshKoLaiXe.Location = new System.Drawing.Point(90, 530);
            this.cmdRefreshKoLaiXe.Name = "cmdRefreshKoLaiXe";
            this.cmdRefreshKoLaiXe.Size = new System.Drawing.Size(75, 63);
            this.cmdRefreshKoLaiXe.TabIndex = 15;
            this.cmdRefreshKoLaiXe.Text = "Refresh ";
            this.cmdRefreshKoLaiXe.UseVisualStyleBackColor = true;
            this.cmdRefreshKoLaiXe.Visible = false;
            this.cmdRefreshKoLaiXe.Click += new System.EventHandler(this.cmdRefreshKoLaiXe_Click);
            // 
            // cmdXemChiTietKoLaiXe
            // 
            this.cmdXemChiTietKoLaiXe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.cmdXemChiTietKoLaiXe.Location = new System.Drawing.Point(687, 0);
            this.cmdXemChiTietKoLaiXe.Name = "cmdXemChiTietKoLaiXe";
            this.cmdXemChiTietKoLaiXe.Size = new System.Drawing.Size(64, 54);
            this.cmdXemChiTietKoLaiXe.TabIndex = 16;
            this.cmdXemChiTietKoLaiXe.Text = "Xem chi tiết hợp đồng";
            this.cmdXemChiTietKoLaiXe.UseVisualStyleBackColor = true;
            this.cmdXemChiTietKoLaiXe.Visible = false;
            this.cmdXemChiTietKoLaiXe.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(242, 530);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 63);
            this.button5.TabIndex = 17;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(242, 530);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 63);
            this.button6.TabIndex = 17;
            this.button6.Text = "Print";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmTraXeThoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(822, 599);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cmdXemChiTietKoLaiXe);
            this.Controls.Add(this.cmdRefreshKoLaiXe);
            this.Controls.Add(this.cmdHoanTatKoLaiXe);
            this.Controls.Add(this.rbTraXeKoLai);
            this.Controls.Add(this.rbTraXeCoLai);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cbTinhTrangHD);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdHoanTatThanhToa);
            this.Controls.Add(this.cmdChiTiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTraXeThoi";
            this.Text = "frmTraXeThoi";
            this.Load += new System.EventHandler(this.frmTraXeThoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdChiTiet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpHanTraXe;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLaiXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayTraThucTe;
        private System.Windows.Forms.TextBox txtTienMuonTheoNgay;
        private System.Windows.Forms.Label lbTienTraXeMuonTheoNgay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChiPhiBoiThuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button cmdHoanTatThanhToa;
        private System.Windows.Forms.CheckBox cbTinhTrangHD;
        private System.Windows.Forms.ComboBox txtTinhTrangHong;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rbTraXeCoLai;
        private System.Windows.Forms.RadioButton rbTraXeKoLai;
        private System.Windows.Forms.Button cmdHoanTatKoLaiXe;
        private System.Windows.Forms.Button cmdRefreshKoLaiXe;
        private System.Windows.Forms.Button cmdXemChiTietKoLaiXe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}