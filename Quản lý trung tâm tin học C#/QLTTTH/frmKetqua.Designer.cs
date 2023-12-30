namespace QLTTTH
{
    partial class frmKetqua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetqua));
            this.gbxKQHT = new System.Windows.Forms.GroupBox();
            this.cboMaMHK = new System.Windows.Forms.ComboBox();
            this.cboMaHVK = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLanthi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxKQ = new System.Windows.Forms.GroupBox();
            this.lvwKetquaHT = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.gbxDK = new System.Windows.Forms.GroupBox();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemKQ = new System.Windows.Forms.Button();
            this.btnDongKQ = new System.Windows.Forms.Button();
            this.btnXoaKQ = new System.Windows.Forms.Button();
            this.btnSuaKQ = new System.Windows.Forms.Button();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.ilsButton = new System.Windows.Forms.ImageList(this.components);
            this.gbxKQHT.SuspendLayout();
            this.gbxKQ.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbxDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKQHT
            // 
            this.gbxKQHT.Controls.Add(this.cboMaMHK);
            this.gbxKQHT.Controls.Add(this.cboMaHVK);
            this.gbxKQHT.Controls.Add(this.txtDiem);
            this.gbxKQHT.Controls.Add(this.label4);
            this.gbxKQHT.Controls.Add(this.txtLanthi);
            this.gbxKQHT.Controls.Add(this.label3);
            this.gbxKQHT.Controls.Add(this.label2);
            this.gbxKQHT.Controls.Add(this.label1);
            this.gbxKQHT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKQHT.ForeColor = System.Drawing.Color.Blue;
            this.gbxKQHT.Location = new System.Drawing.Point(12, 10);
            this.gbxKQHT.Name = "gbxKQHT";
            this.gbxKQHT.Size = new System.Drawing.Size(494, 72);
            this.gbxKQHT.TabIndex = 0;
            this.gbxKQHT.TabStop = false;
            this.gbxKQHT.Text = "Kết Quả Học Tập Từng Học Viên";
            // 
            // cboMaMHK
            // 
            this.cboMaMHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaMHK.Enabled = false;
            this.cboMaMHK.FormattingEnabled = true;
            this.cboMaMHK.Location = new System.Drawing.Point(83, 42);
            this.cboMaMHK.Name = "cboMaMHK";
            this.cboMaMHK.Size = new System.Drawing.Size(154, 22);
            this.cboMaMHK.TabIndex = 1;
            // 
            // cboMaHVK
            // 
            this.cboMaHVK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHVK.Enabled = false;
            this.cboMaHVK.FormattingEnabled = true;
            this.cboMaHVK.Location = new System.Drawing.Point(83, 16);
            this.cboMaHVK.Name = "cboMaHVK";
            this.cboMaHVK.Size = new System.Drawing.Size(154, 22);
            this.cboMaHVK.TabIndex = 0;
            // 
            // txtDiem
            // 
            this.txtDiem.Enabled = false;
            this.txtDiem.Location = new System.Drawing.Point(327, 43);
            this.txtDiem.MaxLength = 3;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(154, 20);
            this.txtDiem.TabIndex = 3;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(290, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm";
            // 
            // txtLanthi
            // 
            this.txtLanthi.Enabled = false;
            this.txtLanthi.Location = new System.Drawing.Point(327, 17);
            this.txtLanthi.MaxLength = 1;
            this.txtLanthi.Name = "txtLanthi";
            this.txtLanthi.Size = new System.Drawing.Size(154, 20);
            this.txtLanthi.TabIndex = 2;
            this.txtLanthi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLanthi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(282, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lần thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // gbxKQ
            // 
            this.gbxKQ.Controls.Add(this.lvwKetquaHT);
            this.gbxKQ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKQ.ForeColor = System.Drawing.Color.Blue;
            this.gbxKQ.Location = new System.Drawing.Point(12, 158);
            this.gbxKQ.Name = "gbxKQ";
            this.gbxKQ.Size = new System.Drawing.Size(494, 222);
            this.gbxKQ.TabIndex = 1;
            this.gbxKQ.TabStop = false;
            this.gbxKQ.Text = "Kết Quả Học Tập";
            // 
            // lvwKetquaHT
            // 
            this.lvwKetquaHT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwKetquaHT.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwKetquaHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwKetquaHT.FullRowSelect = true;
            this.lvwKetquaHT.GridLines = true;
            this.lvwKetquaHT.LargeImageList = this.ilsLon;
            this.lvwKetquaHT.Location = new System.Drawing.Point(3, 16);
            this.lvwKetquaHT.Name = "lvwKetquaHT";
            this.lvwKetquaHT.Size = new System.Drawing.Size(488, 203);
            this.lvwKetquaHT.SmallImageList = this.ilsNho;
            this.lvwKetquaHT.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwKetquaHT.TabIndex = 0;
            this.lvwKetquaHT.UseCompatibleStateImageBehavior = false;
            this.lvwKetquaHT.View = System.Windows.Forms.View.Details;
            this.lvwKetquaHT.SelectedIndexChanged += new System.EventHandler(this.lvwKetquaHT_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học viên";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã môn học";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lần thi";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điểm";
            this.columnHeader4.Width = 66;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.tilesToolStripMenuItem,
            this.listToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 114);
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Image = global::QLTTTH.Properties.Resources.larger;
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.largeIconsToolStripMenuItem.Text = "Large Icons";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = global::QLTTTH.Properties.Resources.deitail;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Image = global::QLTTTH.Properties.Resources.icon;
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // tilesToolStripMenuItem
            // 
            this.tilesToolStripMenuItem.Image = global::QLTTTH.Properties.Resources.tile;
            this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            this.tilesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tilesToolStripMenuItem.Text = "Tiles";
            this.tilesToolStripMenuItem.Click += new System.EventHandler(this.tilesToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Image = global::QLTTTH.Properties.Resources.list;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // ilsLon
            // 
            this.ilsLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsLon.ImageStream")));
            this.ilsLon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsLon.Images.SetKeyName(0, "kq.ico");
            // 
            // ilsNho
            // 
            this.ilsNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsNho.ImageStream")));
            this.ilsNho.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsNho.Images.SetKeyName(0, "kq.ico");
            // 
            // gbxDK
            // 
            this.gbxDK.Controls.Add(this.btnXemKQ);
            this.gbxDK.Controls.Add(this.btnLuu);
            this.gbxDK.Controls.Add(this.btnThemKQ);
            this.gbxDK.Controls.Add(this.btnDongKQ);
            this.gbxDK.Controls.Add(this.btnXoaKQ);
            this.gbxDK.Controls.Add(this.btnSuaKQ);
            this.gbxDK.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDK.ForeColor = System.Drawing.Color.Blue;
            this.gbxDK.Location = new System.Drawing.Point(12, 88);
            this.gbxDK.Name = "gbxDK";
            this.gbxDK.Size = new System.Drawing.Size(494, 64);
            this.gbxDK.TabIndex = 2;
            this.gbxDK.TabStop = false;
            this.gbxDK.Text = "Bảng Điều Khiển";
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKQ.ForeColor = System.Drawing.Color.Red;
            this.btnXemKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemKQ.ImageKey = "Search.ico";
            this.btnXemKQ.ImageList = this.ilsButton;
            this.btnXemKQ.Location = new System.Drawing.Point(330, 19);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(75, 33);
            this.btnXemKQ.TabIndex = 8;
            this.btnXemKQ.Text = "Xem";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "Save.ico";
            this.btnLuu.ImageList = this.ilsButton;
            this.btnLuu.Location = new System.Drawing.Point(249, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemKQ
            // 
            this.btnThemKQ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKQ.ForeColor = System.Drawing.Color.Red;
            this.btnThemKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKQ.ImageKey = "AddObj.ico";
            this.btnThemKQ.ImageList = this.ilsButton;
            this.btnThemKQ.Location = new System.Drawing.Point(6, 19);
            this.btnThemKQ.Name = "btnThemKQ";
            this.btnThemKQ.Size = new System.Drawing.Size(75, 33);
            this.btnThemKQ.TabIndex = 4;
            this.btnThemKQ.Text = "Thêm";
            this.btnThemKQ.UseVisualStyleBackColor = true;
            this.btnThemKQ.Click += new System.EventHandler(this.btnThemKQ_Click);
            // 
            // btnDongKQ
            // 
            this.btnDongKQ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongKQ.ForeColor = System.Drawing.Color.Red;
            this.btnDongKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongKQ.ImageKey = "Close.ico";
            this.btnDongKQ.ImageList = this.ilsButton;
            this.btnDongKQ.Location = new System.Drawing.Point(411, 19);
            this.btnDongKQ.Name = "btnDongKQ";
            this.btnDongKQ.Size = new System.Drawing.Size(75, 33);
            this.btnDongKQ.TabIndex = 9;
            this.btnDongKQ.Text = "Đóng";
            this.btnDongKQ.UseVisualStyleBackColor = true;
            this.btnDongKQ.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnXoaKQ
            // 
            this.btnXoaKQ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKQ.ForeColor = System.Drawing.Color.Red;
            this.btnXoaKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKQ.ImageKey = "Delete.ico";
            this.btnXoaKQ.ImageList = this.ilsButton;
            this.btnXoaKQ.Location = new System.Drawing.Point(168, 19);
            this.btnXoaKQ.Name = "btnXoaKQ";
            this.btnXoaKQ.Size = new System.Drawing.Size(75, 33);
            this.btnXoaKQ.TabIndex = 6;
            this.btnXoaKQ.Text = "Xóa";
            this.btnXoaKQ.UseVisualStyleBackColor = true;
            this.btnXoaKQ.Click += new System.EventHandler(this.btnXoaKQ_Click);
            // 
            // btnSuaKQ
            // 
            this.btnSuaKQ.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKQ.ForeColor = System.Drawing.Color.Red;
            this.btnSuaKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKQ.ImageKey = "Fix.ico";
            this.btnSuaKQ.ImageList = this.ilsButton;
            this.btnSuaKQ.Location = new System.Drawing.Point(87, 19);
            this.btnSuaKQ.Name = "btnSuaKQ";
            this.btnSuaKQ.Size = new System.Drawing.Size(75, 33);
            this.btnSuaKQ.TabIndex = 5;
            this.btnSuaKQ.Text = "Sửa";
            this.btnSuaKQ.UseVisualStyleBackColor = true;
            this.btnSuaKQ.Click += new System.EventHandler(this.btnSuaKQ_Click);
            // 
            // lblKetqua
            // 
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetqua.Location = new System.Drawing.Point(248, 383);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(255, 23);
            this.lblKetqua.TabIndex = 3;
            this.lblKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ilsButton
            // 
            this.ilsButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsButton.ImageStream")));
            this.ilsButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsButton.Images.SetKeyName(0, "Save.ico");
            this.ilsButton.Images.SetKeyName(1, "Delete.ico");
            this.ilsButton.Images.SetKeyName(2, "AddObj.ico");
            this.ilsButton.Images.SetKeyName(3, "Fix.ico");
            this.ilsButton.Images.SetKeyName(4, "Close.ico");
            this.ilsButton.Images.SetKeyName(5, "Search.ico");
            this.ilsButton.Images.SetKeyName(6, "Cancel.ico");
            // 
            // frmKetqua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(519, 409);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.gbxDK);
            this.Controls.Add(this.gbxKQ);
            this.Controls.Add(this.gbxKQHT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKetqua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Học Tập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKetqua_FormClosing);
            this.Load += new System.EventHandler(this.frmKetqua_Load);
            this.gbxKQHT.ResumeLayout(false);
            this.gbxKQHT.PerformLayout();
            this.gbxKQ.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbxDK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxKQHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLanthi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxKQ;
        private System.Windows.Forms.GroupBox gbxDK;
        private System.Windows.Forms.Button btnDongKQ;
        private System.Windows.Forms.Button btnXoaKQ;
        private System.Windows.Forms.Button btnSuaKQ;
        private System.Windows.Forms.ListView lvwKetquaHT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnThemKQ;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboMaMHK;
        private System.Windows.Forms.ComboBox cboMaHVK;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.ImageList ilsButton;
    }
}