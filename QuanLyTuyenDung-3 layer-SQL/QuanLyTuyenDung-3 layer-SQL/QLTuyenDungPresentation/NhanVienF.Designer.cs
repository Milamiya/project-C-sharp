namespace QLTuyenDungPresentation
{
    partial class NhanVienF
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbomatintuyendung = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cboquocgia = new System.Windows.Forms.ComboBox();
            this.cbotinh = new System.Windows.Forms.ComboBox();
            this.cbohuyen = new System.Windows.Forms.ComboBox();
            this.cbochucvu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbomaphong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbothongbao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, -94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hồ sơ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(39, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(840, 254);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(9, 26);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(822, 218);
            this.dgv1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(701, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 218);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.Image = global::QLTuyenDungPresentation.Properties.Resources.back_icon;
            this.btnthoat.Location = new System.Drawing.Point(38, 164);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 36);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnxoa.Appearance.Options.UseFont = true;
            this.btnxoa.Image = global::QLTuyenDungPresentation.Properties.Resources.delete;
            this.btnxoa.Location = new System.Drawing.Point(38, 77);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 36);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnsua.Appearance.Options.UseFont = true;
            this.btnsua.Image = global::QLTuyenDungPresentation.Properties.Resources.edit;
            this.btnsua.Location = new System.Drawing.Point(38, 122);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(109, 36);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnthem.Appearance.Options.UseFont = true;
            this.btnthem.Image = global::QLTuyenDungPresentation.Properties.Resources.math_add_icon;
            this.btnthem.Location = new System.Drawing.Point(38, 35);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 36);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbothongbao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbomaphong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbomatintuyendung);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.mtbngaysinh);
            this.groupBox1.Controls.Add(this.cboquocgia);
            this.groupBox1.Controls.Add(this.cbotinh);
            this.groupBox1.Controls.Add(this.cbohuyen);
            this.groupBox1.Controls.Add(this.cbochucvu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(39, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbomatintuyendung
            // 
            this.cbomatintuyendung.FormattingEnabled = true;
            this.cbomatintuyendung.Location = new System.Drawing.Point(454, 163);
            this.cbomatintuyendung.Name = "cbomatintuyendung";
            this.cbomatintuyendung.Size = new System.Drawing.Size(180, 26);
            this.cbomatintuyendung.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Mã tin tuyển dụng";
            // 
            // mtbngaysinh
            // 
            this.mtbngaysinh.Location = new System.Drawing.Point(120, 101);
            this.mtbngaysinh.Name = "mtbngaysinh";
            this.mtbngaysinh.Size = new System.Drawing.Size(179, 24);
            this.mtbngaysinh.TabIndex = 19;
            // 
            // cboquocgia
            // 
            this.cboquocgia.FormattingEnabled = true;
            this.cboquocgia.Location = new System.Drawing.Point(454, 131);
            this.cboquocgia.Name = "cboquocgia";
            this.cboquocgia.Size = new System.Drawing.Size(180, 26);
            this.cboquocgia.TabIndex = 18;
            // 
            // cbotinh
            // 
            this.cbotinh.FormattingEnabled = true;
            this.cbotinh.Location = new System.Drawing.Point(454, 102);
            this.cbotinh.Name = "cbotinh";
            this.cbotinh.Size = new System.Drawing.Size(180, 26);
            this.cbotinh.TabIndex = 17;
            // 
            // cbohuyen
            // 
            this.cbohuyen.FormattingEnabled = true;
            this.cbohuyen.Location = new System.Drawing.Point(454, 73);
            this.cbohuyen.Name = "cbohuyen";
            this.cbohuyen.Size = new System.Drawing.Size(180, 26);
            this.cbohuyen.TabIndex = 16;
            // 
            // cbochucvu
            // 
            this.cbochucvu.FormattingEnabled = true;
            this.cbochucvu.Location = new System.Drawing.Point(454, 44);
            this.cbochucvu.Name = "cbochucvu";
            this.cbochucvu.Size = new System.Drawing.Size(180, 26);
            this.cbochucvu.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tỉnh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Quốc gia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Huyện";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Vị trí";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(119, 73);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(180, 24);
            this.txttennv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(119, 44);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(180, 24);
            this.txtmanv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(415, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 36);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nhân viên";
            // 
            // cbomaphong
            // 
            this.cbomaphong.FormattingEnabled = true;
            this.cbomaphong.Location = new System.Drawing.Point(119, 163);
            this.cbomaphong.Name = "cbomaphong";
            this.cbomaphong.Size = new System.Drawing.Size(180, 26);
            this.cbomaphong.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã phòng";
            // 
            // cbothongbao
            // 
            this.cbothongbao.FormattingEnabled = true;
            this.cbothongbao.Location = new System.Drawing.Point(119, 131);
            this.cbothongbao.Name = "cbothongbao";
            this.cbothongbao.Size = new System.Drawing.Size(180, 26);
            this.cbothongbao.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã thông báo";
            // 
            // NhanVienF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 618);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhanVienF";
            this.Text = "NhanVienF";
            this.Load += new System.EventHandler(this.NhanVienF_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbomatintuyendung;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker mtbngaysinh;
        private System.Windows.Forms.ComboBox cboquocgia;
        private System.Windows.Forms.ComboBox cbotinh;
        private System.Windows.Forms.ComboBox cbohuyen;
        private System.Windows.Forms.ComboBox cbochucvu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbothongbao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbomaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
    }
}