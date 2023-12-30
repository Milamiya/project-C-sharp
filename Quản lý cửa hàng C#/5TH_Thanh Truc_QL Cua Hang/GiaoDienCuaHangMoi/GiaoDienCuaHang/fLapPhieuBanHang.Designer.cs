namespace GiaoDienCuaHang
{
    partial class fLapPhieuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLapPhieuBanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMP = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMKH = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMNV = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNL = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTT = new System.Windows.Forms.ColumnHeader();
            this.groupBoxPBH = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMNV = new System.Windows.Forms.ComboBox();
            this.comboBoxMKH = new System.Windows.Forms.ComboBox();
            this.textBoxTT = new System.Windows.Forms.TextBox();
            this.textBoxmp = new System.Windows.Forms.TextBox();
            this.labelTT = new System.Windows.Forms.Label();
            this.labelNL = new System.Windows.Forms.Label();
            this.labelMNV = new System.Windows.Forms.Label();
            this.labelMKH = new System.Windows.Forms.Label();
            this.labelMP = new System.Windows.Forms.Label();
            this.labelLPBH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderSTT = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCTMP = new System.Windows.Forms.TextBox();
            this.comboBoxMSP = new System.Windows.Forms.ComboBox();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.textBoxDG = new System.Windows.Forms.TextBox();
            this.labelCTMP = new System.Windows.Forms.Label();
            this.labelSL = new System.Windows.Forms.Label();
            this.labelMSP = new System.Windows.Forms.Label();
            this.labelDG = new System.Windows.Forms.Label();
            this.groupBoxcn = new System.Windows.Forms.GroupBox();
            this.buttonTKiem = new System.Windows.Forms.Button();
            this.buttonin = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonThemCT = new System.Windows.Forms.Button();
            this.buttonxoaCT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPBH.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxcn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBoxPBH);
            this.panel1.Controls.Add(this.labelLPBH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 165);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(396, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phiếu Bán Hàng";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeaderMP,
            this.columnHeaderMKH,
            this.columnHeaderMNV,
            this.columnHeaderNL,
            this.columnHeaderTT});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(333, 93);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            // 
            // columnHeaderMP
            // 
            this.columnHeaderMP.Text = "Mã Phiếu";
            this.columnHeaderMP.Width = 72;
            // 
            // columnHeaderMKH
            // 
            this.columnHeaderMKH.Text = "Mã KH";
            this.columnHeaderMKH.Width = 76;
            // 
            // columnHeaderMNV
            // 
            this.columnHeaderMNV.Text = "Mã Nhân Viên";
            this.columnHeaderMNV.Width = 97;
            // 
            // columnHeaderNL
            // 
            this.columnHeaderNL.Text = "Ngày Lập";
            this.columnHeaderNL.Width = 76;
            // 
            // columnHeaderTT
            // 
            this.columnHeaderTT.Text = "Tổng Tiền";
            this.columnHeaderTT.Width = 70;
            // 
            // groupBoxPBH
            // 
            this.groupBoxPBH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBoxPBH.Controls.Add(this.dateTimePicker1);
            this.groupBoxPBH.Controls.Add(this.comboBoxMNV);
            this.groupBoxPBH.Controls.Add(this.comboBoxMKH);
            this.groupBoxPBH.Controls.Add(this.textBoxTT);
            this.groupBoxPBH.Controls.Add(this.textBoxmp);
            this.groupBoxPBH.Controls.Add(this.labelTT);
            this.groupBoxPBH.Controls.Add(this.labelNL);
            this.groupBoxPBH.Controls.Add(this.labelMNV);
            this.groupBoxPBH.Controls.Add(this.labelMKH);
            this.groupBoxPBH.Controls.Add(this.labelMP);
            this.groupBoxPBH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPBH.Location = new System.Drawing.Point(3, 45);
            this.groupBoxPBH.Name = "groupBoxPBH";
            this.groupBoxPBH.Size = new System.Drawing.Size(387, 114);
            this.groupBoxPBH.TabIndex = 1;
            this.groupBoxPBH.TabStop = false;
            this.groupBoxPBH.Text = "Thông Tin Phiếu Bán Hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2007, 9, 16, 0, 0, 0, 0);
            // 
            // comboBoxMNV
            // 
            this.comboBoxMNV.FormattingEnabled = true;
            this.comboBoxMNV.Location = new System.Drawing.Point(109, 84);
            this.comboBoxMNV.Name = "comboBoxMNV";
            this.comboBoxMNV.Size = new System.Drawing.Size(87, 24);
            this.comboBoxMNV.TabIndex = 10;
            // 
            // comboBoxMKH
            // 
            this.comboBoxMKH.FormattingEnabled = true;
            this.comboBoxMKH.Location = new System.Drawing.Point(109, 51);
            this.comboBoxMKH.Name = "comboBoxMKH";
            this.comboBoxMKH.Size = new System.Drawing.Size(87, 24);
            this.comboBoxMKH.TabIndex = 9;
            // 
            // textBoxTT
            // 
            this.textBoxTT.Location = new System.Drawing.Point(271, 51);
            this.textBoxTT.Name = "textBoxTT";
            this.textBoxTT.ReadOnly = true;
            this.textBoxTT.Size = new System.Drawing.Size(100, 22);
            this.textBoxTT.TabIndex = 8;
            // 
            // textBoxmp
            // 
            this.textBoxmp.Location = new System.Drawing.Point(109, 22);
            this.textBoxmp.Name = "textBoxmp";
            this.textBoxmp.Size = new System.Drawing.Size(87, 22);
            this.textBoxmp.TabIndex = 5;
            this.textBoxmp.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxmp_Validating);
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelTT.Location = new System.Drawing.Point(202, 56);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(64, 16);
            this.labelTT.TabIndex = 4;
            this.labelTT.Text = "Tổng Tiền";
            // 
            // labelNL
            // 
            this.labelNL.AutoSize = true;
            this.labelNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNL.Location = new System.Drawing.Point(202, 28);
            this.labelNL.Name = "labelNL";
            this.labelNL.Size = new System.Drawing.Size(63, 16);
            this.labelNL.TabIndex = 3;
            this.labelNL.Text = "Ngày Lập";
            // 
            // labelMNV
            // 
            this.labelMNV.AutoSize = true;
            this.labelMNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMNV.Location = new System.Drawing.Point(6, 87);
            this.labelMNV.Name = "labelMNV";
            this.labelMNV.Size = new System.Drawing.Size(90, 16);
            this.labelMNV.TabIndex = 2;
            this.labelMNV.Text = "Mã Nhân Viên";
            // 
            // labelMKH
            // 
            this.labelMKH.AutoSize = true;
            this.labelMKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMKH.Location = new System.Drawing.Point(6, 56);
            this.labelMKH.Name = "labelMKH";
            this.labelMKH.Size = new System.Drawing.Size(101, 16);
            this.labelMKH.TabIndex = 1;
            this.labelMKH.Text = "Mã Khách Hàng";
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMP.Location = new System.Drawing.Point(6, 28);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(63, 16);
            this.labelMP.TabIndex = 0;
            this.labelMP.Text = "Mã Phiếu";
            // 
            // labelLPBH
            // 
            this.labelLPBH.AutoSize = true;
            this.labelLPBH.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLPBH.ForeColor = System.Drawing.Color.Crimson;
            this.labelLPBH.Location = new System.Drawing.Point(252, 9);
            this.labelLPBH.Name = "labelLPBH";
            this.labelLPBH.Size = new System.Drawing.Size(259, 31);
            this.labelLPBH.TabIndex = 0;
            this.labelLPBH.Text = "Lập Phiếu Bán Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(296, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chi Tiết Phiếu Bán Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSTT,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 92);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeaderSTT
            // 
            this.columnHeaderSTT.Text = "STT";
            this.columnHeaderSTT.Width = 49;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phiếu";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành Tiền";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã Sản Phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.textBoxCTMP);
            this.groupBox3.Controls.Add(this.comboBoxMSP);
            this.groupBox3.Controls.Add(this.textBoxSL);
            this.groupBox3.Controls.Add(this.textBoxDG);
            this.groupBox3.Controls.Add(this.labelCTMP);
            this.groupBox3.Controls.Add(this.labelSL);
            this.groupBox3.Controls.Add(this.labelMSP);
            this.groupBox3.Controls.Add(this.labelDG);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 187);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phiếu Bán Hàng";
            // 
            // textBoxCTMP
            // 
            this.textBoxCTMP.Location = new System.Drawing.Point(96, 26);
            this.textBoxCTMP.Name = "textBoxCTMP";
            this.textBoxCTMP.ReadOnly = true;
            this.textBoxCTMP.Size = new System.Drawing.Size(121, 22);
            this.textBoxCTMP.TabIndex = 9;
            // 
            // comboBoxMSP
            // 
            this.comboBoxMSP.FormattingEnabled = true;
            this.comboBoxMSP.Location = new System.Drawing.Point(96, 57);
            this.comboBoxMSP.Name = "comboBoxMSP";
            this.comboBoxMSP.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMSP.TabIndex = 5;
            // 
            // textBoxSL
            // 
            this.textBoxSL.Location = new System.Drawing.Point(96, 128);
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(100, 22);
            this.textBoxSL.TabIndex = 5;
            // 
            // textBoxDG
            // 
            this.textBoxDG.Location = new System.Drawing.Point(96, 91);
            this.textBoxDG.Name = "textBoxDG";
            this.textBoxDG.Size = new System.Drawing.Size(100, 22);
            this.textBoxDG.TabIndex = 4;
            // 
            // labelCTMP
            // 
            this.labelCTMP.AutoSize = true;
            this.labelCTMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCTMP.Location = new System.Drawing.Point(6, 26);
            this.labelCTMP.Name = "labelCTMP";
            this.labelCTMP.Size = new System.Drawing.Size(63, 16);
            this.labelCTMP.TabIndex = 4;
            this.labelCTMP.Text = "Mã Phiếu";
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelSL.Location = new System.Drawing.Point(6, 131);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(67, 16);
            this.labelSL.TabIndex = 7;
            this.labelSL.Text = "Số Lượng";
            // 
            // labelMSP
            // 
            this.labelMSP.AutoSize = true;
            this.labelMSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelMSP.Location = new System.Drawing.Point(6, 60);
            this.labelMSP.Name = "labelMSP";
            this.labelMSP.Size = new System.Drawing.Size(91, 16);
            this.labelMSP.TabIndex = 5;
            this.labelMSP.Text = "Mã Sản Phẩm";
            // 
            // labelDG
            // 
            this.labelDG.AutoSize = true;
            this.labelDG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelDG.Location = new System.Drawing.Point(6, 94);
            this.labelDG.Name = "labelDG";
            this.labelDG.Size = new System.Drawing.Size(57, 16);
            this.labelDG.TabIndex = 6;
            this.labelDG.Text = "Đơn Giá";
            // 
            // groupBoxcn
            // 
            this.groupBoxcn.Controls.Add(this.buttonTKiem);
            this.groupBoxcn.Controls.Add(this.buttonin);
            this.groupBoxcn.Controls.Add(this.buttonluu);
            this.groupBoxcn.Controls.Add(this.buttonsua);
            this.groupBoxcn.Controls.Add(this.buttonxoa);
            this.groupBoxcn.Controls.Add(this.buttonthem);
            this.groupBoxcn.Location = new System.Drawing.Point(250, 175);
            this.groupBoxcn.Name = "groupBoxcn";
            this.groupBoxcn.Size = new System.Drawing.Size(485, 68);
            this.groupBoxcn.TabIndex = 4;
            this.groupBoxcn.TabStop = false;
            this.groupBoxcn.Text = "Chức Năng";
            // 
            // buttonTKiem
            // 
            this.buttonTKiem.Image = ((System.Drawing.Image)(resources.GetObject("buttonTKiem.Image")));
            this.buttonTKiem.Location = new System.Drawing.Point(241, 19);
            this.buttonTKiem.Name = "buttonTKiem";
            this.buttonTKiem.Size = new System.Drawing.Size(82, 43);
            this.buttonTKiem.TabIndex = 5;
            this.buttonTKiem.Text = "Tìm Kiếm";
            this.buttonTKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTKiem.UseVisualStyleBackColor = true;
            this.buttonTKiem.Click += new System.EventHandler(this.buttonTKiem_Click);
            // 
            // buttonin
            // 
            this.buttonin.Location = new System.Drawing.Point(410, 19);
            this.buttonin.Name = "buttonin";
            this.buttonin.Size = new System.Drawing.Size(66, 43);
            this.buttonin.TabIndex = 4;
            this.buttonin.Text = "In";
            this.buttonin.UseVisualStyleBackColor = true;
            this.buttonin.Click += new System.EventHandler(this.buttonin_Click);
            // 
            // buttonluu
            // 
            this.buttonluu.Image = ((System.Drawing.Image)(resources.GetObject("buttonluu.Image")));
            this.buttonluu.Location = new System.Drawing.Point(329, 19);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(75, 43);
            this.buttonluu.TabIndex = 3;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonluu.UseVisualStyleBackColor = true;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.Image = ((System.Drawing.Image)(resources.GetObject("buttonsua.Image")));
            this.buttonsua.Location = new System.Drawing.Point(167, 19);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(68, 43);
            this.buttonsua.TabIndex = 2;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonxoa.Image")));
            this.buttonxoa.Location = new System.Drawing.Point(86, 19);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 43);
            this.buttonxoa.TabIndex = 1;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.Image = ((System.Drawing.Image)(resources.GetObject("buttonthem.Image")));
            this.buttonthem.Location = new System.Drawing.Point(6, 19);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(74, 43);
            this.buttonthem.TabIndex = 0;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // buttonThemCT
            // 
            this.buttonThemCT.Location = new System.Drawing.Point(237, 266);
            this.buttonThemCT.Name = "buttonThemCT";
            this.buttonThemCT.Size = new System.Drawing.Size(53, 30);
            this.buttonThemCT.TabIndex = 1;
            this.buttonThemCT.Text = ">>";
            this.buttonThemCT.UseVisualStyleBackColor = true;
            this.buttonThemCT.Click += new System.EventHandler(this.buttonThemCT_Click);
            // 
            // buttonxoaCT
            // 
            this.buttonxoaCT.Location = new System.Drawing.Point(237, 315);
            this.buttonxoaCT.Name = "buttonxoaCT";
            this.buttonxoaCT.Size = new System.Drawing.Size(53, 30);
            this.buttonxoaCT.TabIndex = 5;
            this.buttonxoaCT.Text = "<<";
            this.buttonxoaCT.UseVisualStyleBackColor = true;
            this.buttonxoaCT.Click += new System.EventHandler(this.buttonxoaCT_Click);
            // 
            // fLapPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 363);
            this.Controls.Add(this.buttonxoaCT);
            this.Controls.Add(this.buttonThemCT);
            this.Controls.Add(this.groupBoxcn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "fLapPhieuBanHang";
            this.Text = "fLapPhieuBanHang";
            this.Load += new System.EventHandler(this.fLapPhieuBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxPBH.ResumeLayout(false);
            this.groupBoxPBH.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxcn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxPBH;
        private System.Windows.Forms.Label labelLPBH;
        private System.Windows.Forms.TextBox textBoxmp;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.Label labelNL;
        private System.Windows.Forms.Label labelMNV;
        private System.Windows.Forms.Label labelMKH;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.TextBox textBoxTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeaderMP;
        private System.Windows.Forms.ColumnHeader columnHeaderMKH;
        private System.Windows.Forms.ColumnHeader columnHeaderMNV;
        private System.Windows.Forms.ColumnHeader columnHeaderNL;
        private System.Windows.Forms.ColumnHeader columnHeaderTT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCTMP;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.Label labelMSP;
        private System.Windows.Forms.Label labelDG;
        private System.Windows.Forms.ComboBox comboBoxMSP;
        private System.Windows.Forms.TextBox textBoxSL;
        private System.Windows.Forms.TextBox textBoxDG;
        private System.Windows.Forms.GroupBox groupBoxcn;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Button buttonin;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMNV;
        private System.Windows.Forms.ComboBox comboBoxMKH;
        private System.Windows.Forms.TextBox textBoxCTMP;
        private System.Windows.Forms.Button buttonThemCT;
        private System.Windows.Forms.Button buttonxoaCT;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeaderSTT;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonTKiem;
    }
}