namespace prBaiThiWin2_Ca2
{
    partial class frmQuanLyTuyenDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTuyenDL));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwDanhSachTuyenDL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboLoaiPT = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhiAnO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhiPT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoNgayDL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTongPhi = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(-7, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 64);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "QUẢN LÝ CÁC TUYẾN DU LỊCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwDanhSachTuyenDL);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các tuyến du lịch";
            // 
            // lvwDanhSachTuyenDL
            // 
            this.lvwDanhSachTuyenDL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwDanhSachTuyenDL.FullRowSelect = true;
            this.lvwDanhSachTuyenDL.GridLines = true;
            this.lvwDanhSachTuyenDL.HideSelection = false;
            this.lvwDanhSachTuyenDL.Location = new System.Drawing.Point(6, 22);
            this.lvwDanhSachTuyenDL.MultiSelect = false;
            this.lvwDanhSachTuyenDL.Name = "lvwDanhSachTuyenDL";
            this.lvwDanhSachTuyenDL.Size = new System.Drawing.Size(250, 193);
            this.lvwDanhSachTuyenDL.SmallImageList = this.imageList1;
            this.lvwDanhSachTuyenDL.TabIndex = 0;
            this.lvwDanhSachTuyenDL.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachTuyenDL.View = System.Windows.Forms.View.Details;
            this.lvwDanhSachTuyenDL.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSachTuyenDL_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên tuyến";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số ngày du lịch";
            this.columnHeader2.Width = 102;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "C sharp.ico");
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(-7, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 57);
            this.label3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboLoaiPT);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPhiAnO);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPhiPT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoNgayDL);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTenTuyen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMaTuyen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(280, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 221);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết tuyến du lịch";
            // 
            // cboLoaiPT
            // 
            this.cboLoaiPT.FormattingEnabled = true;
            this.cboLoaiPT.Location = new System.Drawing.Point(94, 177);
            this.cboLoaiPT.Name = "cboLoaiPT";
            this.cboLoaiPT.Size = new System.Drawing.Size(165, 24);
            this.cboLoaiPT.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại PT";
            // 
            // txtPhiAnO
            // 
            this.txtPhiAnO.Location = new System.Drawing.Point(94, 148);
            this.txtPhiAnO.Name = "txtPhiAnO";
            this.txtPhiAnO.Size = new System.Drawing.Size(165, 23);
            this.txtPhiAnO.TabIndex = 4;
            this.txtPhiAnO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhiAnO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhiAnO_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phí ăn ở";
            // 
            // txtPhiPT
            // 
            this.txtPhiPT.Location = new System.Drawing.Point(94, 119);
            this.txtPhiPT.Name = "txtPhiPT";
            this.txtPhiPT.Size = new System.Drawing.Size(165, 23);
            this.txtPhiPT.TabIndex = 3;
            this.txtPhiPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhiPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhiPT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phí PT";
            // 
            // txtSoNgayDL
            // 
            this.txtSoNgayDL.Location = new System.Drawing.Point(94, 90);
            this.txtSoNgayDL.Name = "txtSoNgayDL";
            this.txtSoNgayDL.Size = new System.Drawing.Size(165, 23);
            this.txtSoNgayDL.TabIndex = 2;
            this.txtSoNgayDL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgayDL_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ngày DL";
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(94, 61);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(165, 23);
            this.txtTenTuyen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên tuyến";
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Location = new System.Drawing.Point(94, 32);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(165, 23);
            this.txtMaTuyen.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã tuyến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tổng phí phương tiện:";
            // 
            // lblTongPhi
            // 
            this.lblTongPhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongPhi.Location = new System.Drawing.Point(156, 300);
            this.lblTongPhi.Name = "lblTongPhi";
            this.lblTongPhi.Size = new System.Drawing.Size(118, 29);
            this.lblTongPhi.TabIndex = 3;
            this.lblTongPhi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(463, 298);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 34);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(374, 298);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(463, 362);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(76, 34);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // frmQuanLyTuyenDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 408);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblTongPhi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyTuyenDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Tuyen Du Lich";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyTuyenDL_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyTuyenDL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwDanhSachTuyenDL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboLoaiPT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhiAnO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhiPT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoNgayDL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTongPhi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ImageList imageList1;
    }
}

