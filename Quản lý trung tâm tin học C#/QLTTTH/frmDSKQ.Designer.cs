namespace QLTTTH
{
    partial class frmDSKQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSKQ));
            this.gbxDanhsach = new System.Windows.Forms.GroupBox();
            this.lvwDanhsachKQHV = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.cboLopHV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTKHVGV = new System.Windows.Forms.TextBox();
            this.lblSoHV = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtRot = new System.Windows.Forms.RadioButton();
            this.rbtDau = new System.Windows.Forms.RadioButton();
            this.ilsButton = new System.Windows.Forms.ImageList(this.components);
            this.gbxDanhsach.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDanhsach
            // 
            this.gbxDanhsach.Controls.Add(this.lvwDanhsachKQHV);
            this.gbxDanhsach.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDanhsach.ForeColor = System.Drawing.Color.Blue;
            this.gbxDanhsach.Location = new System.Drawing.Point(12, 64);
            this.gbxDanhsach.Name = "gbxDanhsach";
            this.gbxDanhsach.Size = new System.Drawing.Size(677, 227);
            this.gbxDanhsach.TabIndex = 0;
            this.gbxDanhsach.TabStop = false;
            this.gbxDanhsach.Text = "Danh Sách Kết Quả Học Tập Của Học Viên";
            // 
            // lvwDanhsachKQHV
            // 
            this.lvwDanhsachKQHV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwDanhsachKQHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDanhsachKQHV.FullRowSelect = true;
            this.lvwDanhsachKQHV.GridLines = true;
            this.lvwDanhsachKQHV.LargeImageList = this.ilsLon;
            this.lvwDanhsachKQHV.Location = new System.Drawing.Point(3, 16);
            this.lvwDanhsachKQHV.Name = "lvwDanhsachKQHV";
            this.lvwDanhsachKQHV.Size = new System.Drawing.Size(671, 208);
            this.lvwDanhsachKQHV.SmallImageList = this.ilsNho;
            this.lvwDanhsachKQHV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwDanhsachKQHV.TabIndex = 0;
            this.lvwDanhsachKQHV.UseCompatibleStateImageBehavior = false;
            this.lvwDanhsachKQHV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học viên";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên học viên";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phái";
            this.columnHeader3.Width = 45;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã môn học";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên môn học";
            this.columnHeader6.Width = 113;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lần thi";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Điểm";
            this.columnHeader8.Width = 68;
            // 
            // ilsLon
            // 
            this.ilsLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsLon.ImageStream")));
            this.ilsLon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsLon.Images.SetKeyName(0, "Xemketqua.ico");
            // 
            // ilsNho
            // 
            this.ilsNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsNho.ImageStream")));
            this.ilsNho.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsNho.Images.SetKeyName(0, "Xemketqua.ico");
            // 
            // cboLopHV
            // 
            this.cboLopHV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLopHV.FormattingEnabled = true;
            this.cboLopHV.Location = new System.Drawing.Point(124, 12);
            this.cboLopHV.Name = "cboLopHV";
            this.cboLopHV.Size = new System.Drawing.Size(196, 22);
            this.cboLopHV.TabIndex = 1;
            this.cboLopHV.SelectedIndexChanged += new System.EventHandler(this.cboLopHV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn lớp cần xem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giáo viên chủ nhiệm";
            // 
            // txtTKHVGV
            // 
            this.txtTKHVGV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTKHVGV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKHVGV.Location = new System.Drawing.Point(124, 38);
            this.txtTKHVGV.Name = "txtTKHVGV";
            this.txtTKHVGV.ReadOnly = true;
            this.txtTKHVGV.Size = new System.Drawing.Size(196, 20);
            this.txtTKHVGV.TabIndex = 5;
            // 
            // lblSoHV
            // 
            this.lblSoHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSoHV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHV.ForeColor = System.Drawing.Color.Red;
            this.lblSoHV.Location = new System.Drawing.Point(317, 295);
            this.lblSoHV.Name = "lblSoHV";
            this.lblSoHV.Size = new System.Drawing.Size(369, 23);
            this.lblSoHV.TabIndex = 6;
            this.lblSoHV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Red;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.ImageKey = "Close.ico";
            this.btnDong.ImageList = this.ilsButton;
            this.btnDong.Location = new System.Drawing.Point(611, 27);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 31);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtRot);
            this.groupBox1.Controls.Add(this.rbtDau);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(327, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê danh sách";
            // 
            // rbtRot
            // 
            this.rbtRot.AutoSize = true;
            this.rbtRot.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRot.ForeColor = System.Drawing.Color.Yellow;
            this.rbtRot.Location = new System.Drawing.Point(186, 19);
            this.rbtRot.Name = "rbtRot";
            this.rbtRot.Size = new System.Drawing.Size(84, 18);
            this.rbtRot.TabIndex = 1;
            this.rbtRot.Text = "Học viên rớt";
            this.rbtRot.UseVisualStyleBackColor = true;
            // 
            // rbtDau
            // 
            this.rbtDau.AutoSize = true;
            this.rbtDau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDau.ForeColor = System.Drawing.Color.Yellow;
            this.rbtDau.Location = new System.Drawing.Point(11, 20);
            this.rbtDau.Name = "rbtDau";
            this.rbtDau.Size = new System.Drawing.Size(88, 18);
            this.rbtDau.TabIndex = 0;
            this.rbtDau.Text = "Học viên đậu";
            this.rbtDau.UseVisualStyleBackColor = true;
            // 
            // ilsButton
            // 
            this.ilsButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsButton.ImageStream")));
            this.ilsButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsButton.Images.SetKeyName(0, "Close.ico");
            // 
            // frmDSKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(700, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblSoHV);
            this.Controls.Add(this.txtTKHVGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLopHV);
            this.Controls.Add(this.gbxDanhsach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDSKQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Kết Quả Học Tập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDSHVDau_FormClosing);
            this.Load += new System.EventHandler(this.frmDSHVDau_Load);
            this.gbxDanhsach.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDanhsach;
        private System.Windows.Forms.ListView lvwDanhsachKQHV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cboLopHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTKHVGV;
        private System.Windows.Forms.Label lblSoHV;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDau;
        private System.Windows.Forms.RadioButton rbtRot;
        private System.Windows.Forms.ImageList ilsButton;
    }
}