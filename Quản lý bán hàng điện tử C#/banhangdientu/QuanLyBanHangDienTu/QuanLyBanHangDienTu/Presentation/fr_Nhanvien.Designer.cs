namespace QuanLyBanHangDienTu.Presentation
{
    partial class fr_Nhanvien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbgt = new System.Windows.Forms.ComboBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msds = new System.Windows.Forms.DataGridView();
            this.cbc = new System.Windows.Forms.ComboBox();
            this.cbcv = new System.Windows.Forms.ComboBox();
            this.lbc = new System.Windows.Forms.Label();
            this.lbcv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 50);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(301, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btxoa);
            this.panel3.Controls.Add(this.btsua);
            this.panel3.Controls.Add(this.btluu);
            this.panel3.Controls.Add(this.btmoi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 43);
            this.panel3.TabIndex = 16;
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Image = global::QuanLyBanHangDienTu.Properties.Resources._3Xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(307, 0);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(90, 43);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Image = global::QuanLyBanHangDienTu.Properties.Resources._2Sua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(220, 0);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(87, 43);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluu
            // 
            this.btluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Image = global::QuanLyBanHangDienTu.Properties.Resources.Luu;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(129, 0);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(91, 43);
            this.btluu.TabIndex = 1;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btmoi
            // 
            this.btmoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btmoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmoi.Image = global::QuanLyBanHangDienTu.Properties.Resources._1Them;
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(0, 0);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(129, 43);
            this.btmoi.TabIndex = 0;
            this.btmoi.Text = "Thêm Mới";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.btmoi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtngaysinh);
            this.panel2.Controls.Add(this.cbcv);
            this.panel2.Controls.Add(this.cbc);
            this.panel2.Controls.Add(this.cbgt);
            this.panel2.Controls.Add(this.txtghichu);
            this.panel2.Controls.Add(this.txtdc);
            this.panel2.Controls.Add(this.txtten);
            this.panel2.Controls.Add(this.txtdt);
            this.panel2.Controls.Add(this.txtma);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lbcv);
            this.panel2.Controls.Add(this.lbc);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 324);
            this.panel2.TabIndex = 17;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.CustomFormat = "MM/dd/yyyy";
            this.txtngaysinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaysinh.Location = new System.Drawing.Point(118, 118);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(203, 27);
            this.txtngaysinh.TabIndex = 6;
            // 
            // cbgt
            // 
            this.cbgt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgt.FormattingEnabled = true;
            this.cbgt.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbgt.Location = new System.Drawing.Point(117, 85);
            this.cbgt.Name = "cbgt";
            this.cbgt.Size = new System.Drawing.Size(204, 27);
            this.cbgt.TabIndex = 5;
            // 
            // txtghichu
            // 
            this.txtghichu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtghichu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.Location = new System.Drawing.Point(115, 218);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(206, 27);
            this.txtghichu.TabIndex = 4;
            // 
            // txtdc
            // 
            this.txtdc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdc.Location = new System.Drawing.Point(115, 187);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(206, 27);
            this.txtdc.TabIndex = 4;
            // 
            // txtten
            // 
            this.txtten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(117, 52);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(206, 27);
            this.txtten.TabIndex = 4;
            // 
            // txtdt
            // 
            this.txtdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdt.Location = new System.Drawing.Point(115, 151);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(206, 27);
            this.txtdt.TabIndex = 3;
            // 
            // txtma
            // 
            this.txtma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(117, 16);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(206, 27);
            this.txtma.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã Công Việc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã Ca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ghi Chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.SystemColors.Control;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(346, 93);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(552, 324);
            this.msds.TabIndex = 21;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            // 
            // cbc
            // 
            this.cbc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbc.FormattingEnabled = true;
            this.cbc.Location = new System.Drawing.Point(117, 251);
            this.cbc.Name = "cbc";
            this.cbc.Size = new System.Drawing.Size(103, 27);
            this.cbc.TabIndex = 5;
            this.cbc.SelectedIndexChanged += new System.EventHandler(this.cbc_SelectedIndexChanged);
            // 
            // cbcv
            // 
            this.cbcv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcv.FormattingEnabled = true;
            this.cbcv.Location = new System.Drawing.Point(115, 284);
            this.cbcv.Name = "cbcv";
            this.cbcv.Size = new System.Drawing.Size(103, 27);
            this.cbcv.TabIndex = 5;
            this.cbcv.SelectedIndexChanged += new System.EventHandler(this.cbcv_SelectedIndexChanged);
            // 
            // lbc
            // 
            this.lbc.AutoSize = true;
            this.lbc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbc.Location = new System.Drawing.Point(226, 254);
            this.lbc.Name = "lbc";
            this.lbc.Size = new System.Drawing.Size(27, 19);
            this.lbc.TabIndex = 2;
            this.lbc.Text = "---";
            // 
            // lbcv
            // 
            this.lbcv.AutoSize = true;
            this.lbcv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcv.Location = new System.Drawing.Point(226, 287);
            this.lbcv.Name = "lbcv";
            this.lbcv.Size = new System.Drawing.Size(27, 19);
            this.lbcv.TabIndex = 2;
            this.lbcv.Text = "---";
            // 
            // fr_Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 417);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fr_Nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fr_Nhanvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker txtngaysinh;
        private System.Windows.Forms.ComboBox cbgt;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.ComboBox cbcv;
        private System.Windows.Forms.ComboBox cbc;
        private System.Windows.Forms.Label lbcv;
        private System.Windows.Forms.Label lbc;
    }
}