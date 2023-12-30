namespace QLTTTH
{
    partial class frmTimHV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimHV));
            this.btnDongcobanHV = new System.Windows.Forms.Button();
            this.btnTimcobanHV = new System.Windows.Forms.Button();
            this.txtTimcobanHV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtTHVcoban = new System.Windows.Forms.RadioButton();
            this.rbtMHVcoban = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwTimHV = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.lblThongtincobanHV = new System.Windows.Forms.Label();
            this.ilsButton = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDongcobanHV
            // 
            this.btnDongcobanHV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongcobanHV.ForeColor = System.Drawing.Color.Red;
            this.btnDongcobanHV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongcobanHV.ImageKey = "Close.ico";
            this.btnDongcobanHV.ImageList = this.ilsButton;
            this.btnDongcobanHV.Location = new System.Drawing.Point(273, 39);
            this.btnDongcobanHV.Name = "btnDongcobanHV";
            this.btnDongcobanHV.Size = new System.Drawing.Size(75, 34);
            this.btnDongcobanHV.TabIndex = 4;
            this.btnDongcobanHV.Text = "Đóng";
            this.btnDongcobanHV.UseVisualStyleBackColor = true;
            this.btnDongcobanHV.Click += new System.EventHandler(this.btnDongcobanHV_Click);
            // 
            // btnTimcobanHV
            // 
            this.btnTimcobanHV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimcobanHV.ForeColor = System.Drawing.Color.Red;
            this.btnTimcobanHV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimcobanHV.ImageKey = "Search.ico";
            this.btnTimcobanHV.ImageList = this.ilsButton;
            this.btnTimcobanHV.Location = new System.Drawing.Point(141, 39);
            this.btnTimcobanHV.Name = "btnTimcobanHV";
            this.btnTimcobanHV.Size = new System.Drawing.Size(75, 34);
            this.btnTimcobanHV.TabIndex = 3;
            this.btnTimcobanHV.Text = "Tìm";
            this.btnTimcobanHV.UseVisualStyleBackColor = true;
            this.btnTimcobanHV.Click += new System.EventHandler(this.btnTimcobanHV_Click);
            // 
            // txtTimcobanHV
            // 
            this.txtTimcobanHV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimcobanHV.Location = new System.Drawing.Point(128, 11);
            this.txtTimcobanHV.Name = "txtTimcobanHV";
            this.txtTimcobanHV.Size = new System.Drawing.Size(220, 20);
            this.txtTimcobanHV.TabIndex = 0;
            this.txtTimcobanHV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimcobanHV_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập thông tin  cần tìm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtTHVcoban);
            this.groupBox2.Controls.Add(this.rbtMHVcoban);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(394, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 51);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Theo";
            // 
            // rbtTHVcoban
            // 
            this.rbtTHVcoban.AutoSize = true;
            this.rbtTHVcoban.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTHVcoban.ForeColor = System.Drawing.Color.Yellow;
            this.rbtTHVcoban.Location = new System.Drawing.Point(103, 20);
            this.rbtTHVcoban.Name = "rbtTHVcoban";
            this.rbtTHVcoban.Size = new System.Drawing.Size(87, 18);
            this.rbtTHVcoban.TabIndex = 2;
            this.rbtTHVcoban.TabStop = true;
            this.rbtTHVcoban.Text = "Tên học viên";
            this.rbtTHVcoban.UseVisualStyleBackColor = true;
            // 
            // rbtMHVcoban
            // 
            this.rbtMHVcoban.AutoSize = true;
            this.rbtMHVcoban.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMHVcoban.ForeColor = System.Drawing.Color.Yellow;
            this.rbtMHVcoban.Location = new System.Drawing.Point(7, 20);
            this.rbtMHVcoban.Name = "rbtMHVcoban";
            this.rbtMHVcoban.Size = new System.Drawing.Size(83, 18);
            this.rbtMHVcoban.TabIndex = 1;
            this.rbtMHVcoban.TabStop = true;
            this.rbtMHVcoban.Text = "Mã học viên";
            this.rbtMHVcoban.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwTimHV);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(8, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Học Viên";
            // 
            // lvwTimHV
            // 
            this.lvwTimHV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwTimHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTimHV.FullRowSelect = true;
            this.lvwTimHV.GridLines = true;
            this.lvwTimHV.LargeImageList = this.ilsLon;
            this.lvwTimHV.Location = new System.Drawing.Point(3, 16);
            this.lvwTimHV.Name = "lvwTimHV";
            this.lvwTimHV.Size = new System.Drawing.Size(574, 189);
            this.lvwTimHV.SmallImageList = this.ilsNho;
            this.lvwTimHV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwTimHV.TabIndex = 0;
            this.lvwTimHV.UseCompatibleStateImageBehavior = false;
            this.lvwTimHV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học viên";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên học viên";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phái";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa chỉ";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Điện thoại";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã lớp";
            // 
            // ilsLon
            // 
            this.ilsLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsLon.ImageStream")));
            this.ilsLon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsLon.Images.SetKeyName(0, "WLM.ico");
            // 
            // ilsNho
            // 
            this.ilsNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsNho.ImageStream")));
            this.ilsNho.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsNho.Images.SetKeyName(0, "WLM.ico");
            // 
            // lblThongtincobanHV
            // 
            this.lblThongtincobanHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblThongtincobanHV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtincobanHV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThongtincobanHV.Location = new System.Drawing.Point(8, 84);
            this.lblThongtincobanHV.Name = "lblThongtincobanHV";
            this.lblThongtincobanHV.Size = new System.Drawing.Size(580, 24);
            this.lblThongtincobanHV.TabIndex = 13;
            this.lblThongtincobanHV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilsButton
            // 
            this.ilsButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsButton.ImageStream")));
            this.ilsButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsButton.Images.SetKeyName(0, "Close.ico");
            this.ilsButton.Images.SetKeyName(1, "Search.ico");
            this.ilsButton.Images.SetKeyName(2, "Again.ico");
            // 
            // frmTimHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(597, 334);
            this.Controls.Add(this.lblThongtincobanHV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDongcobanHV);
            this.Controls.Add(this.btnTimcobanHV);
            this.Controls.Add(this.txtTimcobanHV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTimHV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Thông Tin Học Viên ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimcobanHV_FormClosing);
            this.Load += new System.EventHandler(this.frmTimcobanHV_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongcobanHV;
        private System.Windows.Forms.Button btnTimcobanHV;
        private System.Windows.Forms.TextBox txtTimcobanHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtTHVcoban;
        private System.Windows.Forms.RadioButton rbtMHVcoban;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwTimHV;
        private System.Windows.Forms.Label lblThongtincobanHV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ImageList ilsButton;
    }
}