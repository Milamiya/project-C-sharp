namespace GUI
{
    partial class frmThem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThem));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtNguon = new System.Windows.Forms.TextBox();
            this.cboChuyenMuc = new System.Windows.Forms.ComboBox();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtChuyenmuckhac = new System.Windows.Forms.TextBox();
            this.openFileDialogMoAnh = new System.Windows.Forms.OpenFileDialog();
            this.picAnhThem = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMacdinh = new System.Windows.Forms.RadioButton();
            this.rbTaitumaytinh = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhThem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu Đề:";
            // 
            // dateTimePickerNgayNhap
            // 
            this.dateTimePickerNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayNhap.Location = new System.Drawing.Point(94, 97);
            this.dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            this.dateTimePickerNgayNhap.Size = new System.Drawing.Size(255, 20);
            this.dateTimePickerNgayNhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nguồn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mục:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(94, 31);
            this.txtTieuDe.MaxLength = 50;
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(255, 20);
            this.txtTieuDe.TabIndex = 1;
            // 
            // txtNguon
            // 
            this.txtNguon.Location = new System.Drawing.Point(94, 66);
            this.txtNguon.MaxLength = 36;
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.Size = new System.Drawing.Size(255, 20);
            this.txtNguon.TabIndex = 2;
            // 
            // cboChuyenMuc
            // 
            this.cboChuyenMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenMuc.FormattingEnabled = true;
            this.cboChuyenMuc.Items.AddRange(new object[] {
            "Khác"});
            this.cboChuyenMuc.Location = new System.Drawing.Point(94, 133);
            this.cboChuyenMuc.Name = "cboChuyenMuc";
            this.cboChuyenMuc.Size = new System.Drawing.Size(120, 21);
            this.cboChuyenMuc.TabIndex = 4;
            this.cboChuyenMuc.SelectedIndexChanged += new System.EventHandler(this.cboChuyenMuc_SelectedIndexChanged);
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(14, 19);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoidung.Size = new System.Drawing.Size(493, 227);
            this.txtNoidung.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNoidung);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội Dung:";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(115, 427);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(84, 23);
            this.btnThemmoi.TabIndex = 10;
            this.btnThemmoi.Text = "Thêm Mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(25, 427);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(417, 427);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(84, 23);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // txtChuyenmuckhac
            // 
            this.txtChuyenmuckhac.Location = new System.Drawing.Point(220, 133);
            this.txtChuyenmuckhac.MaxLength = 25;
            this.txtChuyenmuckhac.Name = "txtChuyenmuckhac";
            this.txtChuyenmuckhac.Size = new System.Drawing.Size(129, 20);
            this.txtChuyenmuckhac.TabIndex = 11;
            this.txtChuyenmuckhac.Visible = false;
            // 
            // openFileDialogMoAnh
            // 
            this.openFileDialogMoAnh.FileName = "Chọn Ảnh";
            // 
            // picAnhThem
            // 
            this.picAnhThem.BackColor = System.Drawing.Color.Transparent;
            this.picAnhThem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhThem.ImageLocation = "";
            this.picAnhThem.Location = new System.Drawing.Point(406, 31);
            this.picAnhThem.Name = "picAnhThem";
            this.picAnhThem.Size = new System.Drawing.Size(95, 95);
            this.picAnhThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhThem.TabIndex = 12;
            this.picAnhThem.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(425, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hình ảnh";
            // 
            // rbMacdinh
            // 
            this.rbMacdinh.AutoSize = true;
            this.rbMacdinh.BackColor = System.Drawing.Color.Transparent;
            this.rbMacdinh.Location = new System.Drawing.Point(455, 133);
            this.rbMacdinh.Name = "rbMacdinh";
            this.rbMacdinh.Size = new System.Drawing.Size(70, 17);
            this.rbMacdinh.TabIndex = 14;
            this.rbMacdinh.Text = "Mặc định";
            this.rbMacdinh.UseVisualStyleBackColor = false;
            this.rbMacdinh.Click += new System.EventHandler(this.rbMacdinh_Click);
            // 
            // rbTaitumaytinh
            // 
            this.rbTaitumaytinh.AutoSize = true;
            this.rbTaitumaytinh.BackColor = System.Drawing.Color.Transparent;
            this.rbTaitumaytinh.Location = new System.Drawing.Point(388, 133);
            this.rbTaitumaytinh.Name = "rbTaitumaytinh";
            this.rbTaitumaytinh.Size = new System.Drawing.Size(61, 17);
            this.rbTaitumaytinh.TabIndex = 15;
            this.rbTaitumaytinh.Text = "Tải ảnh";
            this.rbTaitumaytinh.UseVisualStyleBackColor = false;
            this.rbTaitumaytinh.Click += new System.EventHandler(this.rbMacdinh_Click);
            // 
            // frmThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 462);
            this.Controls.Add(this.rbTaitumaytinh);
            this.Controls.Add(this.rbMacdinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picAnhThem);
            this.Controls.Add(this.txtChuyenmuckhac);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboChuyenMuc);
            this.Controls.Add(this.txtNguon);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerNgayNhap);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmThem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNguon;
        private System.Windows.Forms.ComboBox cboChuyenMuc;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        internal System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.TextBox txtChuyenmuckhac;
        private System.Windows.Forms.OpenFileDialog openFileDialogMoAnh;
        private System.Windows.Forms.PictureBox picAnhThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMacdinh;
        private System.Windows.Forms.RadioButton rbTaitumaytinh;
    }
}