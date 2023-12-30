namespace QLTTTH
{
    partial class frmTimMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimMH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwTimMH = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.btnDongcobanMH = new System.Windows.Forms.Button();
            this.btnTimcobanMH = new System.Windows.Forms.Button();
            this.txtTimcobanMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtTMHcoban = new System.Windows.Forms.RadioButton();
            this.rbtMMHcoban = new System.Windows.Forms.RadioButton();
            this.lblThongtincobanMH = new System.Windows.Forms.Label();
            this.ilsButton = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwTimMH);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(14, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 208);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Môn Học";
            // 
            // lvwTimMH
            // 
            this.lvwTimMH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwTimMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTimMH.FullRowSelect = true;
            this.lvwTimMH.GridLines = true;
            this.lvwTimMH.LargeImageList = this.ilsLon;
            this.lvwTimMH.Location = new System.Drawing.Point(3, 16);
            this.lvwTimMH.Name = "lvwTimMH";
            this.lvwTimMH.Size = new System.Drawing.Size(574, 189);
            this.lvwTimMH.SmallImageList = this.ilsNho;
            this.lvwTimMH.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwTimMH.TabIndex = 0;
            this.lvwTimMH.UseCompatibleStateImageBehavior = false;
            this.lvwTimMH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã môn học";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên tên học";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số tiết";
            this.columnHeader3.Width = 96;
            // 
            // ilsLon
            // 
            this.ilsLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsLon.ImageStream")));
            this.ilsLon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsLon.Images.SetKeyName(0, "mhl.ico");
            // 
            // ilsNho
            // 
            this.ilsNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsNho.ImageStream")));
            this.ilsNho.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsNho.Images.SetKeyName(0, "mhl.ico");
            // 
            // btnDongcobanMH
            // 
            this.btnDongcobanMH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongcobanMH.ForeColor = System.Drawing.Color.Red;
            this.btnDongcobanMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongcobanMH.ImageKey = "Close.ico";
            this.btnDongcobanMH.ImageList = this.ilsButton;
            this.btnDongcobanMH.Location = new System.Drawing.Point(279, 39);
            this.btnDongcobanMH.Name = "btnDongcobanMH";
            this.btnDongcobanMH.Size = new System.Drawing.Size(75, 34);
            this.btnDongcobanMH.TabIndex = 4;
            this.btnDongcobanMH.Text = "Đóng";
            this.btnDongcobanMH.UseVisualStyleBackColor = true;
            this.btnDongcobanMH.Click += new System.EventHandler(this.btnDongcobanMH_Click);
            // 
            // btnTimcobanMH
            // 
            this.btnTimcobanMH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimcobanMH.ForeColor = System.Drawing.Color.Red;
            this.btnTimcobanMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimcobanMH.ImageKey = "Search.ico";
            this.btnTimcobanMH.ImageList = this.ilsButton;
            this.btnTimcobanMH.Location = new System.Drawing.Point(147, 39);
            this.btnTimcobanMH.Name = "btnTimcobanMH";
            this.btnTimcobanMH.Size = new System.Drawing.Size(75, 34);
            this.btnTimcobanMH.TabIndex = 3;
            this.btnTimcobanMH.Text = "Tìm";
            this.btnTimcobanMH.UseVisualStyleBackColor = true;
            this.btnTimcobanMH.Click += new System.EventHandler(this.btnTimcobanMH_Click);
            // 
            // txtTimcobanMH
            // 
            this.txtTimcobanMH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimcobanMH.Location = new System.Drawing.Point(134, 11);
            this.txtTimcobanMH.Name = "txtTimcobanMH";
            this.txtTimcobanMH.Size = new System.Drawing.Size(220, 20);
            this.txtTimcobanMH.TabIndex = 0;
            this.txtTimcobanMH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimcobanMH_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhập thông tin  cần tìm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtTMHcoban);
            this.groupBox2.Controls.Add(this.rbtMMHcoban);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(400, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 51);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Theo";
            // 
            // rbtTMHcoban
            // 
            this.rbtTMHcoban.AutoSize = true;
            this.rbtTMHcoban.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTMHcoban.ForeColor = System.Drawing.Color.Yellow;
            this.rbtTMHcoban.Location = new System.Drawing.Point(103, 20);
            this.rbtTMHcoban.Name = "rbtTMHcoban";
            this.rbtTMHcoban.Size = new System.Drawing.Size(87, 18);
            this.rbtTMHcoban.TabIndex = 2;
            this.rbtTMHcoban.TabStop = true;
            this.rbtTMHcoban.Text = "Tên môn học";
            this.rbtTMHcoban.UseVisualStyleBackColor = true;
            // 
            // rbtMMHcoban
            // 
            this.rbtMMHcoban.AutoSize = true;
            this.rbtMMHcoban.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMMHcoban.ForeColor = System.Drawing.Color.Yellow;
            this.rbtMMHcoban.Location = new System.Drawing.Point(7, 20);
            this.rbtMMHcoban.Name = "rbtMMHcoban";
            this.rbtMMHcoban.Size = new System.Drawing.Size(83, 18);
            this.rbtMMHcoban.TabIndex = 1;
            this.rbtMMHcoban.TabStop = true;
            this.rbtMMHcoban.Text = "Mã môn học";
            this.rbtMMHcoban.UseVisualStyleBackColor = true;
            // 
            // lblThongtincobanMH
            // 
            this.lblThongtincobanMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblThongtincobanMH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtincobanMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThongtincobanMH.Location = new System.Drawing.Point(14, 84);
            this.lblThongtincobanMH.Name = "lblThongtincobanMH";
            this.lblThongtincobanMH.Size = new System.Drawing.Size(580, 24);
            this.lblThongtincobanMH.TabIndex = 26;
            this.lblThongtincobanMH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilsButton
            // 
            this.ilsButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsButton.ImageStream")));
            this.ilsButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsButton.Images.SetKeyName(0, "Close.ico");
            this.ilsButton.Images.SetKeyName(1, "Search.ico");
            this.ilsButton.Images.SetKeyName(2, "Again.ico");
            // 
            // frmTimMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(608, 336);
            this.Controls.Add(this.lblThongtincobanMH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDongcobanMH);
            this.Controls.Add(this.btnTimcobanMH);
            this.Controls.Add(this.txtTimcobanMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTimMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Thông Tin Môn Học ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimcobanMH_FormClosing);
            this.Load += new System.EventHandler(this.frmTimcobanMH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwTimMH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDongcobanMH;
        private System.Windows.Forms.Button btnTimcobanMH;
        private System.Windows.Forms.TextBox txtTimcobanMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtTMHcoban;
        private System.Windows.Forms.RadioButton rbtMMHcoban;
        private System.Windows.Forms.Label lblThongtincobanMH;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ImageList ilsButton;
    }
}