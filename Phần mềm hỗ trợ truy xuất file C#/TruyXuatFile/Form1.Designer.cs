namespace TruyXuatFile
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.btnDuyetFile = new System.Windows.Forms.Button();
            this.grbThongTinFile = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTruyXuatLanCuoi = new System.Windows.Forms.TextBox();
            this.txtChinhSua = new System.Windows.Forms.TextBox();
            this.txtThoiGianTao = new System.Windows.Forms.TextBox();
            this.txtKichThuocTapTin = new System.Windows.Forms.TextBox();
            this.txtTenTapTin = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnXemNoiDung = new System.Windows.Forms.Button();
            this.grbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btntxt = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbThongTinFile.SuspendLayout();
            this.grbThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDuongDan.Location = new System.Drawing.Point(113, 142);
            this.txtDuongDan.Multiline = true;
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(376, 26);
            this.txtDuongDan.TabIndex = 0;
            this.txtDuongDan.TextChanged += new System.EventHandler(this.txtDuongDan_TextChanged);
            // 
            // btnDuyetFile
            // 
            this.btnDuyetFile.BackgroundImage = global::TruyXuatFile.Properties.Resources.OpenFolder;
            this.btnDuyetFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuyetFile.ForeColor = System.Drawing.Color.Transparent;
            this.btnDuyetFile.Location = new System.Drawing.Point(495, 136);
            this.btnDuyetFile.Name = "btnDuyetFile";
            this.btnDuyetFile.Size = new System.Drawing.Size(44, 34);
            this.btnDuyetFile.TabIndex = 1;
            this.btnDuyetFile.UseVisualStyleBackColor = true;
            this.btnDuyetFile.Click += new System.EventHandler(this.btnDuyetFile_Click);
            // 
            // grbThongTinFile
            // 
            this.grbThongTinFile.BackColor = System.Drawing.Color.Transparent;
            this.grbThongTinFile.Controls.Add(this.label5);
            this.grbThongTinFile.Controls.Add(this.label4);
            this.grbThongTinFile.Controls.Add(this.label3);
            this.grbThongTinFile.Controls.Add(this.label2);
            this.grbThongTinFile.Controls.Add(this.label1);
            this.grbThongTinFile.Controls.Add(this.txtTruyXuatLanCuoi);
            this.grbThongTinFile.Controls.Add(this.txtChinhSua);
            this.grbThongTinFile.Controls.Add(this.txtThoiGianTao);
            this.grbThongTinFile.Controls.Add(this.txtKichThuocTapTin);
            this.grbThongTinFile.Controls.Add(this.txtTenTapTin);
            this.grbThongTinFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinFile.ForeColor = System.Drawing.Color.MediumBlue;
            this.grbThongTinFile.Location = new System.Drawing.Point(27, 225);
            this.grbThongTinFile.Name = "grbThongTinFile";
            this.grbThongTinFile.Size = new System.Drawing.Size(488, 279);
            this.grbThongTinFile.TabIndex = 2;
            this.grbThongTinFile.TabStop = false;
            this.grbThongTinFile.Text = "Thông Tin File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Truy xuất lần cuối";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chỉnh sửa lần cuối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kích thước";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tập tin";
            // 
            // txtTruyXuatLanCuoi
            // 
            this.txtTruyXuatLanCuoi.Enabled = false;
            this.txtTruyXuatLanCuoi.Location = new System.Drawing.Point(139, 205);
            this.txtTruyXuatLanCuoi.Multiline = true;
            this.txtTruyXuatLanCuoi.Name = "txtTruyXuatLanCuoi";
            this.txtTruyXuatLanCuoi.Size = new System.Drawing.Size(328, 26);
            this.txtTruyXuatLanCuoi.TabIndex = 0;
            // 
            // txtChinhSua
            // 
            this.txtChinhSua.Enabled = false;
            this.txtChinhSua.Location = new System.Drawing.Point(139, 166);
            this.txtChinhSua.Multiline = true;
            this.txtChinhSua.Name = "txtChinhSua";
            this.txtChinhSua.Size = new System.Drawing.Size(328, 26);
            this.txtChinhSua.TabIndex = 0;
            // 
            // txtThoiGianTao
            // 
            this.txtThoiGianTao.Enabled = false;
            this.txtThoiGianTao.Location = new System.Drawing.Point(139, 125);
            this.txtThoiGianTao.Multiline = true;
            this.txtThoiGianTao.Name = "txtThoiGianTao";
            this.txtThoiGianTao.Size = new System.Drawing.Size(328, 26);
            this.txtThoiGianTao.TabIndex = 0;
            // 
            // txtKichThuocTapTin
            // 
            this.txtKichThuocTapTin.Enabled = false;
            this.txtKichThuocTapTin.Location = new System.Drawing.Point(139, 88);
            this.txtKichThuocTapTin.Multiline = true;
            this.txtKichThuocTapTin.Name = "txtKichThuocTapTin";
            this.txtKichThuocTapTin.Size = new System.Drawing.Size(328, 26);
            this.txtKichThuocTapTin.TabIndex = 0;
            // 
            // txtTenTapTin
            // 
            this.txtTenTapTin.Enabled = false;
            this.txtTenTapTin.Location = new System.Drawing.Point(139, 49);
            this.txtTenTapTin.Multiline = true;
            this.txtTenTapTin.Name = "txtTenTapTin";
            this.txtTenTapTin.Size = new System.Drawing.Size(328, 26);
            this.txtTenTapTin.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(30, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đường dẫn";
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXemThongTin.Location = new System.Drawing.Point(27, 196);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(128, 29);
            this.btnXemThongTin.TabIndex = 1;
            this.btnXemThongTin.Text = "Xem chi tiết File";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // btnXemNoiDung
            // 
            this.btnXemNoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXemNoiDung.Location = new System.Drawing.Point(161, 196);
            this.btnXemNoiDung.Name = "btnXemNoiDung";
            this.btnXemNoiDung.Size = new System.Drawing.Size(141, 29);
            this.btnXemNoiDung.TabIndex = 1;
            this.btnXemNoiDung.Text = "Xem nội dung File";
            this.btnXemNoiDung.UseVisualStyleBackColor = true;
            this.btnXemNoiDung.Click += new System.EventHandler(this.btnXemNoiDung_Click);
            // 
            // grbThaoTac
            // 
            this.grbThaoTac.BackColor = System.Drawing.Color.Transparent;
            this.grbThaoTac.Controls.Add(this.btnExcel);
            this.grbThaoTac.Controls.Add(this.btnPicture);
            this.grbThaoTac.Controls.Add(this.btnMedia);
            this.grbThaoTac.Controls.Add(this.btntxt);
            this.grbThaoTac.Controls.Add(this.btnWord);
            this.grbThaoTac.Controls.Add(this.btnCopy);
            this.grbThaoTac.Controls.Add(this.btnMove);
            this.grbThaoTac.Controls.Add(this.btnDelete);
            this.grbThaoTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThaoTac.ForeColor = System.Drawing.Color.Blue;
            this.grbThaoTac.Location = new System.Drawing.Point(544, 225);
            this.grbThaoTac.Name = "grbThaoTac";
            this.grbThaoTac.Size = new System.Drawing.Size(200, 279);
            this.grbThaoTac.TabIndex = 3;
            this.grbThaoTac.TabStop = false;
            this.grbThaoTac.Text = "Thao tác File";
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(12, 154);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(57, 57);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPicture.BackgroundImage")));
            this.btnPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture.Location = new System.Drawing.Point(138, 215);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(54, 57);
            this.btnPicture.TabIndex = 4;
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedia.BackgroundImage")));
            this.btnMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedia.Location = new System.Drawing.Point(75, 216);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(54, 57);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btntxt
            // 
            this.btntxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntxt.BackgroundImage")));
            this.btntxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntxt.Location = new System.Drawing.Point(138, 153);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(54, 57);
            this.btntxt.TabIndex = 2;
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWord.BackgroundImage")));
            this.btnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWord.Location = new System.Drawing.Point(75, 153);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(54, 57);
            this.btnWord.TabIndex = 1;
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(46, 69);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(117, 40);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "    Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMove
            // 
            this.btnMove.Image = ((System.Drawing.Image)(resources.GetObject("btnMove.Image")));
            this.btnMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMove.Location = new System.Drawing.Point(46, 112);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(117, 40);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "    Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(46, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "    Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 525);
            this.Controls.Add(this.grbThaoTac);
            this.Controls.Add(this.grbThongTinFile);
            this.Controls.Add(this.btnXemNoiDung);
            this.Controls.Add(this.btnXemThongTin);
            this.Controls.Add(this.btnDuyetFile);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH HỖ TRỢ TRUY XUẤT FILE";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbThongTinFile.ResumeLayout(false);
            this.grbThongTinFile.PerformLayout();
            this.grbThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDuyetFile;
        private System.Windows.Forms.GroupBox grbThongTinFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnXemNoiDung;
        private System.Windows.Forms.GroupBox grbThaoTac;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMove;
        public System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.TextBox txtTenTapTin;
        private System.Windows.Forms.TextBox txtTruyXuatLanCuoi;
        private System.Windows.Forms.TextBox txtChinhSua;
        private System.Windows.Forms.TextBox txtThoiGianTao;
        private System.Windows.Forms.TextBox txtKichThuocTapTin;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnExcel;
    }
}

