namespace QLTTTH
{
    partial class frmTimKQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKQ));
            this.btnDongXKQ = new System.Windows.Forms.Button();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.lblThongtinKQ = new System.Windows.Forms.Label();
            this.txtXemKQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwXemKQHT = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.txtXemMHVKQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLopKQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ilsButton = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDongXKQ
            // 
            this.btnDongXKQ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongXKQ.ForeColor = System.Drawing.Color.Red;
            this.btnDongXKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongXKQ.ImageKey = "Close.ico";
            this.btnDongXKQ.ImageList = this.ilsButton;
            this.btnDongXKQ.Location = new System.Drawing.Point(199, 98);
            this.btnDongXKQ.Name = "btnDongXKQ";
            this.btnDongXKQ.Size = new System.Drawing.Size(75, 34);
            this.btnDongXKQ.TabIndex = 2;
            this.btnDongXKQ.Text = "Đóng";
            this.btnDongXKQ.UseVisualStyleBackColor = true;
            this.btnDongXKQ.Click += new System.EventHandler(this.btnDongXKQ_Click);
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKQ.ForeColor = System.Drawing.Color.Red;
            this.btnXemKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemKQ.ImageKey = "Search.ico";
            this.btnXemKQ.ImageList = this.ilsButton;
            this.btnXemKQ.Location = new System.Drawing.Point(67, 98);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(75, 34);
            this.btnXemKQ.TabIndex = 1;
            this.btnXemKQ.Text = "Xem";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // lblThongtinKQ
            // 
            this.lblThongtinKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblThongtinKQ.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtinKQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThongtinKQ.Location = new System.Drawing.Point(12, 165);
            this.lblThongtinKQ.Name = "lblThongtinKQ";
            this.lblThongtinKQ.Size = new System.Drawing.Size(352, 24);
            this.lblThongtinKQ.TabIndex = 17;
            this.lblThongtinKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtXemKQ
            // 
            this.txtXemKQ.Location = new System.Drawing.Point(154, 19);
            this.txtXemKQ.Name = "txtXemKQ";
            this.txtXemKQ.Size = new System.Drawing.Size(180, 20);
            this.txtXemKQ.TabIndex = 0;
            this.txtXemKQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXemKQ_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập mã học viên cần xem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwXemKQHT);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 201);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả Học Tập";
            // 
            // lvwXemKQHT
            // 
            this.lvwXemKQHT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwXemKQHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwXemKQHT.FullRowSelect = true;
            this.lvwXemKQHT.GridLines = true;
            this.lvwXemKQHT.LargeImageList = this.ilsLon;
            this.lvwXemKQHT.Location = new System.Drawing.Point(3, 16);
            this.lvwXemKQHT.Name = "lvwXemKQHT";
            this.lvwXemKQHT.Size = new System.Drawing.Size(346, 182);
            this.lvwXemKQHT.SmallImageList = this.ilsNho;
            this.lvwXemKQHT.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwXemKQHT.TabIndex = 0;
            this.lvwXemKQHT.UseCompatibleStateImageBehavior = false;
            this.lvwXemKQHT.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên môn học";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lần thi";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điểm";
            this.columnHeader3.Width = 97;
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
            // txtXemMHVKQ
            // 
            this.txtXemMHVKQ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtXemMHVKQ.Location = new System.Drawing.Point(154, 45);
            this.txtXemMHVKQ.Name = "txtXemMHVKQ";
            this.txtXemMHVKQ.ReadOnly = true;
            this.txtXemMHVKQ.Size = new System.Drawing.Size(180, 20);
            this.txtXemMHVKQ.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(78, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên học viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLopKQ);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtXemMHVKQ);
            this.groupBox2.Controls.Add(this.btnDongXKQ);
            this.groupBox2.Controls.Add(this.btnXemKQ);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtXemKQ);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 145);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Cần Xem";
            // 
            // txtLopKQ
            // 
            this.txtLopKQ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLopKQ.Location = new System.Drawing.Point(154, 72);
            this.txtLopKQ.Name = "txtLopKQ";
            this.txtLopKQ.ReadOnly = true;
            this.txtLopKQ.Size = new System.Drawing.Size(180, 20);
            this.txtLopKQ.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(123, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lớp";
            // 
            // ilsButton
            // 
            this.ilsButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsButton.ImageStream")));
            this.ilsButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsButton.Images.SetKeyName(0, "Close.ico");
            this.ilsButton.Images.SetKeyName(1, "Search.ico");
            this.ilsButton.Images.SetKeyName(2, "Again.ico");
            // 
            // frmTimKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(376, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblThongtinKQ);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTimKQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Kết Quả Học Tập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKQ_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKQ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDongXKQ;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label lblThongtinKQ;
        private System.Windows.Forms.TextBox txtXemKQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtXemMHVKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwXemKQHT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLopKQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ImageList ilsButton;
    }
}