namespace qlhocvien
{
    partial class GiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiangVien));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbmamh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmakhoagv = new System.Windows.Forms.ComboBox();
            this.txttengv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.btsua = new DevComponents.DotNetBar.ButtonX();
            this.showdatagv = new System.Windows.Forms.DataGridView();
            this.timgv = new DevComponents.DotNetBar.ButtonX();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbsearch = new System.Windows.Forms.ComboBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdatagv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.buttonX1);
            this.groupBox4.Controls.Add(this.cbmamh);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbmakhoagv);
            this.groupBox4.Controls.Add(this.txttengv);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtmagv);
            this.groupBox4.Controls.Add(this.btsua);
            this.groupBox4.Location = new System.Drawing.Point(-4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 194);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Giảng Viên";
            // 
            // cbmamh
            // 
            this.cbmamh.FormattingEnabled = true;
            this.cbmamh.Items.AddRange(new object[] {
            "[--Chọn Một--]",
            "MaMH",
            "CSDL",
            "CSVHVN",
            "ĐLĐCS",
            "GDQP",
            "GDTC",
            "HĐH",
            "LTM",
            "PTTKHT",
            "TACN",
            "XDPMHĐT"});
            this.cbmamh.Location = new System.Drawing.Point(106, 133);
            this.cbmamh.Name = "cbmamh";
            this.cbmamh.Size = new System.Drawing.Size(145, 21);
            this.cbmamh.TabIndex = 40;
            this.cbmamh.Text = "[--Chọn Một--]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mã Môn Học";
            // 
            // cbmakhoagv
            // 
            this.cbmakhoagv.FormattingEnabled = true;
            this.cbmakhoagv.Items.AddRange(new object[] {
            "[--Chọn Một--]",
            "AV",
            "CNTT",
            "KHCB",
            "TR"});
            this.cbmakhoagv.Location = new System.Drawing.Point(106, 101);
            this.cbmakhoagv.Name = "cbmakhoagv";
            this.cbmakhoagv.Size = new System.Drawing.Size(145, 21);
            this.cbmakhoagv.TabIndex = 38;
            this.cbmakhoagv.Text = "[--Chọn Một--]";
            // 
            // txttengv
            // 
            this.txttengv.Location = new System.Drawing.Point(107, 68);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(145, 20);
            this.txttengv.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(16, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Tên Giảng Viên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(16, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Khoa";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(16, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Mã Giảng Viên";
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(106, 33);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(145, 20);
            this.txtmagv.TabIndex = 25;
            // 
            // btsua
            // 
            this.btsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btsua.Image = global::qlhocvien.Properties.Resources.refresh;
            this.btsua.Location = new System.Drawing.Point(106, 162);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(95, 30);
            this.btsua.TabIndex = 23;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // showdatagv
            // 
            this.showdatagv.BackgroundColor = System.Drawing.Color.LightCyan;
            this.showdatagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdatagv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.showdatagv.Location = new System.Drawing.Point(-4, 200);
            this.showdatagv.Name = "showdatagv";
            this.showdatagv.Size = new System.Drawing.Size(523, 260);
            this.showdatagv.TabIndex = 30;
            this.showdatagv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdatagv_CellContentClick);
            // 
            // timgv
            // 
            this.timgv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.timgv.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.timgv.Image = global::qlhocvien.Properties.Resources.search_user;
            this.timgv.Location = new System.Drawing.Point(128, 69);
            this.timgv.Name = "timgv";
            this.timgv.Size = new System.Drawing.Size(57, 24);
            this.timgv.TabIndex = 41;
            this.timgv.Text = "Tìm";
            this.timgv.Click += new System.EventHandler(this.timgv_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(40, 73);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(74, 20);
            this.txtsearch.TabIndex = 42;
            // 
            // cbsearch
            // 
            this.cbsearch.FormattingEnabled = true;
            this.cbsearch.Items.AddRange(new object[] {
            "[--Chọn Một--]",
            "Tìm Theo MãGV",
            "Tìm Theo Tên"});
            this.cbsearch.Location = new System.Drawing.Point(40, 31);
            this.cbsearch.Name = "cbsearch";
            this.cbsearch.Size = new System.Drawing.Size(145, 21);
            this.cbsearch.TabIndex = 43;
            this.cbsearch.Text = "[--Chọn Một--]";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Image = global::qlhocvien.Properties.Resources.users;
            this.buttonX1.Location = new System.Drawing.Point(299, 162);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(145, 30);
            this.buttonX1.TabIndex = 44;
            this.buttonX1.Text = "Xem  Danh Sach";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbsearch);
            this.groupBox1.Controls.Add(this.timgv);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Location = new System.Drawing.Point(276, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Giảng Viên";
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 462);
            this.Controls.Add(this.showdatagv);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng Viên";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdatagv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbmakhoagv;
        private System.Windows.Forms.TextBox txttengv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtmagv;
        private DevComponents.DotNetBar.ButtonX btsua;
        private System.Windows.Forms.DataGridView showdatagv;
        private System.Windows.Forms.ComboBox cbmamh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private DevComponents.DotNetBar.ButtonX timgv;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}