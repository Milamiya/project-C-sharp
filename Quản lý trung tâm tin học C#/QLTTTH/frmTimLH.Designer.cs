namespace QLTTTH
{
    partial class frmTimLH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimLH));
            this.lblThongtincobanLH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwTimLH = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.btnDongcobanLH = new System.Windows.Forms.Button();
            this.btnTimcobanLH = new System.Windows.Forms.Button();
            this.txtTimcobanLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtTLHcoban = new System.Windows.Forms.RadioButton();
            this.rbtMLHcoban = new System.Windows.Forms.RadioButton();
            this.ilsButton = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongtincobanLH
            // 
            this.lblThongtincobanLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblThongtincobanLH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtincobanLH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThongtincobanLH.Location = new System.Drawing.Point(11, 84);
            this.lblThongtincobanLH.Name = "lblThongtincobanLH";
            this.lblThongtincobanLH.Size = new System.Drawing.Size(580, 24);
            this.lblThongtincobanLH.TabIndex = 20;
            this.lblThongtincobanLH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwTimLH);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(11, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 208);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lớp Học";
            // 
            // lvwTimLH
            // 
            this.lvwTimLH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwTimLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTimLH.FullRowSelect = true;
            this.lvwTimLH.GridLines = true;
            this.lvwTimLH.LargeImageList = this.ilsLon;
            this.lvwTimLH.Location = new System.Drawing.Point(3, 16);
            this.lvwTimLH.Name = "lvwTimLH";
            this.lvwTimLH.Size = new System.Drawing.Size(574, 189);
            this.lvwTimLH.SmallImageList = this.ilsNho;
            this.lvwTimLH.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwTimLH.TabIndex = 0;
            this.lvwTimLH.UseCompatibleStateImageBehavior = false;
            this.lvwTimLH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã lớp học";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên lớp học";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khóa học";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giáo viên CN";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày khai giảng";
            this.columnHeader5.Width = 125;
            // 
            // ilsLon
            // 
            this.ilsLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsLon.ImageStream")));
            this.ilsLon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsLon.Images.SetKeyName(0, "lhl.ico");
            // 
            // ilsNho
            // 
            this.ilsNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsNho.ImageStream")));
            this.ilsNho.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsNho.Images.SetKeyName(0, "lhl.ico");
            // 
            // btnDongcobanLH
            // 
            this.btnDongcobanLH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongcobanLH.ForeColor = System.Drawing.Color.Red;
            this.btnDongcobanLH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongcobanLH.ImageKey = "Close.ico";
            this.btnDongcobanLH.ImageList = this.ilsButton;
            this.btnDongcobanLH.Location = new System.Drawing.Point(276, 39);
            this.btnDongcobanLH.Name = "btnDongcobanLH";
            this.btnDongcobanLH.Size = new System.Drawing.Size(75, 34);
            this.btnDongcobanLH.TabIndex = 4;
            this.btnDongcobanLH.Text = "Đóng";
            this.btnDongcobanLH.UseVisualStyleBackColor = true;
            this.btnDongcobanLH.Click += new System.EventHandler(this.btnDongcobanLH_Click);
            // 
            // btnTimcobanLH
            // 
            this.btnTimcobanLH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimcobanLH.ForeColor = System.Drawing.Color.Red;
            this.btnTimcobanLH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimcobanLH.ImageKey = "Search.ico";
            this.btnTimcobanLH.ImageList = this.ilsButton;
            this.btnTimcobanLH.Location = new System.Drawing.Point(144, 39);
            this.btnTimcobanLH.Name = "btnTimcobanLH";
            this.btnTimcobanLH.Size = new System.Drawing.Size(75, 34);
            this.btnTimcobanLH.TabIndex = 3;
            this.btnTimcobanLH.Text = "Tìm";
            this.btnTimcobanLH.UseVisualStyleBackColor = true;
            this.btnTimcobanLH.Click += new System.EventHandler(this.btnTimcobanLH_Click);
            // 
            // txtTimcobanLH
            // 
            this.txtTimcobanLH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimcobanLH.Location = new System.Drawing.Point(131, 11);
            this.txtTimcobanLH.Name = "txtTimcobanLH";
            this.txtTimcobanLH.Size = new System.Drawing.Size(220, 20);
            this.txtTimcobanLH.TabIndex = 0;
            this.txtTimcobanLH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimcobanLH_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập thông tin  cần tìm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtTLHcoban);
            this.groupBox2.Controls.Add(this.rbtMLHcoban);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(397, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 51);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Theo";
            // 
            // rbtTLHcoban
            // 
            this.rbtTLHcoban.AutoSize = true;
            this.rbtTLHcoban.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTLHcoban.ForeColor = System.Drawing.Color.Yellow;
            this.rbtTLHcoban.Location = new System.Drawing.Point(103, 20);
            this.rbtTLHcoban.Name = "rbtTLHcoban";
            this.rbtTLHcoban.Size = new System.Drawing.Size(82, 18);
            this.rbtTLHcoban.TabIndex = 2;
            this.rbtTLHcoban.TabStop = true;
            this.rbtTLHcoban.Text = "Tên lớp học";
            this.rbtTLHcoban.UseVisualStyleBackColor = true;
            // 
            // rbtMLHcoban
            // 
            this.rbtMLHcoban.AutoSize = true;
            this.rbtMLHcoban.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMLHcoban.ForeColor = System.Drawing.Color.Yellow;
            this.rbtMLHcoban.Location = new System.Drawing.Point(7, 20);
            this.rbtMLHcoban.Name = "rbtMLHcoban";
            this.rbtMLHcoban.Size = new System.Drawing.Size(78, 18);
            this.rbtMLHcoban.TabIndex = 1;
            this.rbtMLHcoban.TabStop = true;
            this.rbtMLHcoban.Text = "Mã lớp học";
            this.rbtMLHcoban.UseVisualStyleBackColor = true;
            // 
            // ilsButton
            // 
            this.ilsButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsButton.ImageStream")));
            this.ilsButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsButton.Images.SetKeyName(0, "Close.ico");
            this.ilsButton.Images.SetKeyName(1, "Search.ico");
            this.ilsButton.Images.SetKeyName(2, "Again.ico");
            // 
            // frmTimLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(604, 336);
            this.Controls.Add(this.lblThongtincobanLH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDongcobanLH);
            this.Controls.Add(this.btnTimcobanLH);
            this.Controls.Add(this.txtTimcobanLH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTimLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Thông Tin Lớp Học ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimcobanLH_FormClosing);
            this.Load += new System.EventHandler(this.frmTimcobanLH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongtincobanLH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwTimLH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDongcobanLH;
        private System.Windows.Forms.Button btnTimcobanLH;
        private System.Windows.Forms.TextBox txtTimcobanLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtTLHcoban;
        private System.Windows.Forms.RadioButton rbtMLHcoban;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ImageList ilsButton;
    }
}