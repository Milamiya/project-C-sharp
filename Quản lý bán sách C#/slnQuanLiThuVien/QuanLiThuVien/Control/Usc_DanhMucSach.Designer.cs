namespace QuanLiThuVien.Control
{
    partial class Usc_DanhMucSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usc_DanhMucSach));
            this.lwvDanhMucSach = new System.Windows.Forms.ListView();
            this.cSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMaDauSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLoaiSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTuaSachDMS = new System.Windows.Forms.Label();
            this.lblLoaiSachDMS = new System.Windows.Forms.Label();
            this.lblTacGiaDMS = new System.Windows.Forms.Label();
            this.grpTinhTrang = new System.Windows.Forms.GroupBox();
            this.radChuaMuon = new System.Windows.Forms.RadioButton();
            this.radDaMuon = new System.Windows.Forms.RadioButton();
            this.btnLuuDMS = new System.Windows.Forms.Button();
            this.btnTraCuuDMS = new System.Windows.Forms.Button();
            this.btnXoaDMS = new System.Windows.Forms.Button();
            this.btnCapNhatDMS = new System.Windows.Forms.Button();
            this.btnThemMoiDMS = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMaDauSachDMS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiDungTomLuocDMS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSachDMS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSachDMS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpTinhTrang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwvDanhMucSach
            // 
            this.lwvDanhMucSach.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lwvDanhMucSach.BackColor = System.Drawing.Color.White;
            this.lwvDanhMucSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwvDanhMucSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cSTT,
            this.cTenSach,
            this.cMaDauSach,
            this.cLoaiSach,
            this.cTacGia});
            this.lwvDanhMucSach.FullRowSelect = true;
            this.lwvDanhMucSach.GridLines = true;
            this.lwvDanhMucSach.Location = new System.Drawing.Point(7, 3);
            this.lwvDanhMucSach.Name = "lwvDanhMucSach";
            this.lwvDanhMucSach.Size = new System.Drawing.Size(416, 386);
            this.lwvDanhMucSach.TabIndex = 8;
            this.lwvDanhMucSach.UseCompatibleStateImageBehavior = false;
            this.lwvDanhMucSach.View = System.Windows.Forms.View.Details;
            this.lwvDanhMucSach.SelectedIndexChanged += new System.EventHandler(this.lwvDanhMucSach_SelectedIndexChanged);
            // 
            // cSTT
            // 
            this.cSTT.Text = "STT";
            this.cSTT.Width = 34;
            // 
            // cTenSach
            // 
            this.cTenSach.Text = "Tên Sách";
            this.cTenSach.Width = 92;
            // 
            // cMaDauSach
            // 
            this.cMaDauSach.Text = "Mã đầu sách";
            this.cMaDauSach.Width = 75;
            // 
            // cLoaiSach
            // 
            this.cLoaiSach.Text = "Loại Sách";
            this.cLoaiSach.Width = 98;
            // 
            // cTacGia
            // 
            this.cTacGia.Text = "Tác giả";
            this.cTacGia.Width = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.lblTuaSachDMS);
            this.groupBox1.Controls.Add(this.lblLoaiSachDMS);
            this.groupBox1.Controls.Add(this.lblTacGiaDMS);
            this.groupBox1.Controls.Add(this.grpTinhTrang);
            this.groupBox1.Controls.Add(this.btnLuuDMS);
            this.groupBox1.Controls.Add(this.btnTraCuuDMS);
            this.groupBox1.Controls.Add(this.btnXoaDMS);
            this.groupBox1.Controls.Add(this.btnCapNhatDMS);
            this.groupBox1.Controls.Add(this.btnThemMoiDMS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboMaDauSachDMS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNoiDungTomLuocDMS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenSachDMS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSachDMS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(419, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 386);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblTuaSachDMS
            // 
            this.lblTuaSachDMS.BackColor = System.Drawing.Color.Honeydew;
            this.lblTuaSachDMS.Location = new System.Drawing.Point(119, 129);
            this.lblTuaSachDMS.Name = "lblTuaSachDMS";
            this.lblTuaSachDMS.Size = new System.Drawing.Size(202, 24);
            this.lblTuaSachDMS.TabIndex = 58;
            // 
            // lblLoaiSachDMS
            // 
            this.lblLoaiSachDMS.BackColor = System.Drawing.Color.Honeydew;
            this.lblLoaiSachDMS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoaiSachDMS.Location = new System.Drawing.Point(119, 199);
            this.lblLoaiSachDMS.Name = "lblLoaiSachDMS";
            this.lblLoaiSachDMS.Size = new System.Drawing.Size(202, 24);
            this.lblLoaiSachDMS.TabIndex = 57;
            // 
            // lblTacGiaDMS
            // 
            this.lblTacGiaDMS.BackColor = System.Drawing.Color.Honeydew;
            this.lblTacGiaDMS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTacGiaDMS.Location = new System.Drawing.Point(119, 161);
            this.lblTacGiaDMS.Name = "lblTacGiaDMS";
            this.lblTacGiaDMS.Size = new System.Drawing.Size(202, 24);
            this.lblTacGiaDMS.TabIndex = 57;
            // 
            // grpTinhTrang
            // 
            this.grpTinhTrang.Controls.Add(this.radChuaMuon);
            this.grpTinhTrang.Controls.Add(this.radDaMuon);
            this.grpTinhTrang.Location = new System.Drawing.Point(119, 232);
            this.grpTinhTrang.Name = "grpTinhTrang";
            this.grpTinhTrang.Size = new System.Drawing.Size(216, 37);
            this.grpTinhTrang.TabIndex = 56;
            this.grpTinhTrang.TabStop = false;
            // 
            // radChuaMuon
            // 
            this.radChuaMuon.AutoSize = true;
            this.radChuaMuon.Checked = true;
            this.radChuaMuon.Location = new System.Drawing.Point(112, 10);
            this.radChuaMuon.Name = "radChuaMuon";
            this.radChuaMuon.Size = new System.Drawing.Size(103, 22);
            this.radChuaMuon.TabIndex = 53;
            this.radChuaMuon.TabStop = true;
            this.radChuaMuon.Text = "Chưa Mượn";
            this.radChuaMuon.UseVisualStyleBackColor = true;
            // 
            // radDaMuon
            // 
            this.radDaMuon.AutoSize = true;
            this.radDaMuon.Location = new System.Drawing.Point(6, 13);
            this.radDaMuon.Name = "radDaMuon";
            this.radDaMuon.Size = new System.Drawing.Size(87, 22);
            this.radDaMuon.TabIndex = 52;
            this.radDaMuon.Text = "Đã Mượn";
            this.radDaMuon.UseVisualStyleBackColor = true;
            // 
            // btnLuuDMS
            // 
            this.btnLuuDMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDMS.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDMS.Image")));
            this.btnLuuDMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuDMS.Location = new System.Drawing.Point(341, 161);
            this.btnLuuDMS.Name = "btnLuuDMS";
            this.btnLuuDMS.Size = new System.Drawing.Size(112, 48);
            this.btnLuuDMS.TabIndex = 26;
            this.btnLuuDMS.Text = "Lưu";
            this.btnLuuDMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuDMS.UseVisualStyleBackColor = true;
            this.btnLuuDMS.Click += new System.EventHandler(this.btnLuuDMS_Click);
            // 
            // btnTraCuuDMS
            // 
            this.btnTraCuuDMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuDMS.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuDMS.Image")));
            this.btnTraCuuDMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuuDMS.Location = new System.Drawing.Point(341, 300);
            this.btnTraCuuDMS.Name = "btnTraCuuDMS";
            this.btnTraCuuDMS.Size = new System.Drawing.Size(112, 48);
            this.btnTraCuuDMS.TabIndex = 27;
            this.btnTraCuuDMS.Text = "Tra cứu";
            this.btnTraCuuDMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraCuuDMS.UseVisualStyleBackColor = true;
            this.btnTraCuuDMS.Click += new System.EventHandler(this.btnTraCuuDMS_Click);
            // 
            // btnXoaDMS
            // 
            this.btnXoaDMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDMS.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDMS.Image")));
            this.btnXoaDMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDMS.Location = new System.Drawing.Point(341, 232);
            this.btnXoaDMS.Name = "btnXoaDMS";
            this.btnXoaDMS.Size = new System.Drawing.Size(112, 48);
            this.btnXoaDMS.TabIndex = 25;
            this.btnXoaDMS.Text = "Xóa";
            this.btnXoaDMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDMS.UseVisualStyleBackColor = true;
            this.btnXoaDMS.Click += new System.EventHandler(this.btnXoaDMS_Click);
            // 
            // btnCapNhatDMS
            // 
            this.btnCapNhatDMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDMS.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatDMS.Image")));
            this.btnCapNhatDMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatDMS.Location = new System.Drawing.Point(341, 90);
            this.btnCapNhatDMS.Name = "btnCapNhatDMS";
            this.btnCapNhatDMS.Size = new System.Drawing.Size(112, 48);
            this.btnCapNhatDMS.TabIndex = 23;
            this.btnCapNhatDMS.Text = "Cập Nhật";
            this.btnCapNhatDMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatDMS.UseVisualStyleBackColor = true;
            this.btnCapNhatDMS.Click += new System.EventHandler(this.btnCapNhatDMS_Click);
            // 
            // btnThemMoiDMS
            // 
            this.btnThemMoiDMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoiDMS.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoiDMS.Image")));
            this.btnThemMoiDMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoiDMS.Location = new System.Drawing.Point(341, 23);
            this.btnThemMoiDMS.Name = "btnThemMoiDMS";
            this.btnThemMoiDMS.Size = new System.Drawing.Size(112, 48);
            this.btnThemMoiDMS.TabIndex = 24;
            this.btnThemMoiDMS.Text = "Thêm Mới";
            this.btnThemMoiDMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoiDMS.UseVisualStyleBackColor = true;
            this.btnThemMoiDMS.Click += new System.EventHandler(this.btnThemMoiDMS_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(17, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tình trạng:";
            // 
            // cboMaDauSachDMS
            // 
            this.cboMaDauSachDMS.FormattingEnabled = true;
            this.cboMaDauSachDMS.Location = new System.Drawing.Point(119, 90);
            this.cboMaDauSachDMS.Name = "cboMaDauSachDMS";
            this.cboMaDauSachDMS.Size = new System.Drawing.Size(202, 26);
            this.cboMaDauSachDMS.TabIndex = 16;
            this.cboMaDauSachDMS.SelectedIndexChanged += new System.EventHandler(this.cboMaDauSachDMS_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã Đầu Sách";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Loại sách :";
            // 
            // txtNoiDungTomLuocDMS
            // 
            this.txtNoiDungTomLuocDMS.Location = new System.Drawing.Point(13, 305);
            this.txtNoiDungTomLuocDMS.MaxLength = 4000;
            this.txtNoiDungTomLuocDMS.Multiline = true;
            this.txtNoiDungTomLuocDMS.Name = "txtNoiDungTomLuocDMS";
            this.txtNoiDungTomLuocDMS.ReadOnly = true;
            this.txtNoiDungTomLuocDMS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoiDungTomLuocDMS.Size = new System.Drawing.Size(308, 75);
            this.txtNoiDungTomLuocDMS.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nội dung tóm lược :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tác giả :";
            // 
            // txtTenSachDMS
            // 
            this.txtTenSachDMS.Location = new System.Drawing.Point(119, 53);
            this.txtTenSachDMS.MaxLength = 1000;
            this.txtTenSachDMS.Name = "txtTenSachDMS";
            this.txtTenSachDMS.Size = new System.Drawing.Size(202, 24);
            this.txtTenSachDMS.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tựa sách:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách :";
            // 
            // txtMaSachDMS
            // 
            this.txtMaSachDMS.Location = new System.Drawing.Point(119, 18);
            this.txtMaSachDMS.MaxLength = 10;
            this.txtMaSachDMS.Name = "txtMaSachDMS";
            this.txtMaSachDMS.Size = new System.Drawing.Size(202, 24);
            this.txtMaSachDMS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách :";
            // 
            // Usc_DanhMucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lwvDanhMucSach);
            this.Name = "Usc_DanhMucSach";
            this.Size = new System.Drawing.Size(881, 392);
            this.Load += new System.EventHandler(this.Usc_DanhMucSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTinhTrang.ResumeLayout(false);
            this.grpTinhTrang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwvDanhMucSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiDungTomLuocDMS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSachDMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSachDMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaDauSachDMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader cSTT;
        private System.Windows.Forms.ColumnHeader cTenSach;
        private System.Windows.Forms.ColumnHeader cMaDauSach;
        private System.Windows.Forms.ColumnHeader cLoaiSach;
        private System.Windows.Forms.ColumnHeader cTacGia;
        private System.Windows.Forms.Button btnLuuDMS;
        private System.Windows.Forms.Button btnTraCuuDMS;
        private System.Windows.Forms.Button btnXoaDMS;
        private System.Windows.Forms.Button btnCapNhatDMS;
        private System.Windows.Forms.Button btnThemMoiDMS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpTinhTrang;
        private System.Windows.Forms.RadioButton radChuaMuon;
        private System.Windows.Forms.RadioButton radDaMuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLoaiSachDMS;
        private System.Windows.Forms.Label lblTacGiaDMS;
        private System.Windows.Forms.Label lblTuaSachDMS;
    }
}
