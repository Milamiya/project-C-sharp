namespace QLKTX
{
    partial class frmChuyenPhongSinhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbDayDen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbPhongDen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKTXDen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtPhongDi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbDayDi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbPhongDi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKTXDi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnQua = new System.Windows.Forms.ToolStripButton();
            this.btnLai = new System.Windows.Forms.ToolStripButton();
            this.dtPhongDen = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKTX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhongDi)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhongDen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPhongDen);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.cmbDayDen);
            this.groupBox1.Controls.Add(this.cmbPhongDen);
            this.groupBox1.Controls.Add(this.cmbKTXDen);
            this.groupBox1.Location = new System.Drawing.Point(329, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng đến";
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(41, 44);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 4;
            this.labelX7.Text = "Tên phòng:";
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(41, 70);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 4;
            this.labelX6.Text = "Tên phòng:";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(41, 14);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(49, 21);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Tên KTX:";
            // 
            // cmbDayDen
            // 
            this.cmbDayDen.DisplayMember = "Text";
            this.cmbDayDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDayDen.FormattingEnabled = true;
            this.cmbDayDen.Location = new System.Drawing.Point(122, 43);
            this.cmbDayDen.Name = "cmbDayDen";
            this.cmbDayDen.Size = new System.Drawing.Size(121, 21);
            this.cmbDayDen.TabIndex = 1;
            this.cmbDayDen.SelectionChangeCommitted += new System.EventHandler(this.cmbDayDen_SelectionChangeCommitted);
            // 
            // cmbPhongDen
            // 
            this.cmbPhongDen.DisplayMember = "Text";
            this.cmbPhongDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhongDen.FormattingEnabled = true;
            this.cmbPhongDen.Location = new System.Drawing.Point(122, 69);
            this.cmbPhongDen.Name = "cmbPhongDen";
            this.cmbPhongDen.Size = new System.Drawing.Size(121, 21);
            this.cmbPhongDen.TabIndex = 1;
            this.cmbPhongDen.SelectionChangeCommitted += new System.EventHandler(this.cmbPhongDen_SelectionChangeCommitted);
            // 
            // cmbKTXDen
            // 
            this.cmbKTXDen.DisplayMember = "Text";
            this.cmbKTXDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKTXDen.FormattingEnabled = true;
            this.cmbKTXDen.Location = new System.Drawing.Point(122, 13);
            this.cmbKTXDen.Name = "cmbKTXDen";
            this.cmbKTXDen.Size = new System.Drawing.Size(121, 21);
            this.cmbKTXDen.TabIndex = 0;
            this.cmbKTXDen.SelectionChangeCommitted += new System.EventHandler(this.cmbKTXDen_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtPhongDi);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.cmbDayDi);
            this.groupBox2.Controls.Add(this.cmbPhongDi);
            this.groupBox2.Controls.Add(this.cmbKTXDi);
            this.groupBox2.Location = new System.Drawing.Point(5, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 296);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng đi";
            // 
            // dtPhongDi
            // 
            this.dtPhongDi.AllowUserToAddRows = false;
            this.dtPhongDi.AllowUserToDeleteRows = false;
            this.dtPhongDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhongDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKTX,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.colPhong,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPhongDi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtPhongDi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtPhongDi.Location = new System.Drawing.Point(6, 104);
            this.dtPhongDi.MultiSelect = false;
            this.dtPhongDi.Name = "dtPhongDi";
            this.dtPhongDi.RowHeadersWidth = 15;
            this.dtPhongDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPhongDi.Size = new System.Drawing.Size(265, 178);
            this.dtPhongDi.TabIndex = 4;
            this.dtPhongDi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtPhongDi_MouseDoubleClick);
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(49, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(55, 22);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Tên KTX:";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(49, 40);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(70, 24);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Tên phòng:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(49, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 24);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tên phòng:";
            // 
            // cmbDayDi
            // 
            this.cmbDayDi.DisplayMember = "Text";
            this.cmbDayDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDayDi.FormattingEnabled = true;
            this.cmbDayDi.Location = new System.Drawing.Point(125, 42);
            this.cmbDayDi.Name = "cmbDayDi";
            this.cmbDayDi.Size = new System.Drawing.Size(121, 21);
            this.cmbDayDi.TabIndex = 1;
            this.cmbDayDi.SelectionChangeCommitted += new System.EventHandler(this.cmbDayDi_SelectionChangeCommitted);
            // 
            // cmbPhongDi
            // 
            this.cmbPhongDi.DisplayMember = "Text";
            this.cmbPhongDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhongDi.FormattingEnabled = true;
            this.cmbPhongDi.Location = new System.Drawing.Point(125, 69);
            this.cmbPhongDi.Name = "cmbPhongDi";
            this.cmbPhongDi.Size = new System.Drawing.Size(121, 21);
            this.cmbPhongDi.TabIndex = 1;
            this.cmbPhongDi.SelectionChangeCommitted += new System.EventHandler(this.cmbPhongDi_SelectionChangeCommitted);
            // 
            // cmbKTXDi
            // 
            this.cmbKTXDi.DisplayMember = "Text";
            this.cmbKTXDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKTXDi.FormattingEnabled = true;
            this.cmbKTXDi.Location = new System.Drawing.Point(125, 14);
            this.cmbKTXDi.Name = "cmbKTXDi";
            this.cmbKTXDi.Size = new System.Drawing.Size(121, 21);
            this.cmbKTXDi.TabIndex = 0;
            this.cmbKTXDi.SelectionChangeCommitted += new System.EventHandler(this.cmbKTXDi_SelectionChangeCommitted);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(588, 42);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Chuyển phòng";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(288, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 174);
            this.panel1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQua,
            this.btnLai});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 174);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnQua
            // 
            this.btnQua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQua.Image = global::QLKTX.Properties.Resources.Next32;
            this.btnQua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQua.Name = "btnQua";
            this.btnQua.Size = new System.Drawing.Size(33, 36);
            this.btnQua.Text = "==>";
            this.btnQua.Click += new System.EventHandler(this.btnQua_Click);
            // 
            // btnLai
            // 
            this.btnLai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLai.Image = global::QLKTX.Properties.Resources.Back32;
            this.btnLai.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLai.Name = "btnLai";
            this.btnLai.Size = new System.Drawing.Size(33, 36);
            this.btnLai.Text = "<==";
            this.btnLai.Click += new System.EventHandler(this.btnLai_Click);
            // 
            // dtPhongDen
            // 
            this.dtPhongDen.AllowUserToAddRows = false;
            this.dtPhongDen.AllowUserToDeleteRows = false;
            this.dtPhongDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhongDen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.colMaKTX1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPhongDen.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtPhongDen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtPhongDen.Location = new System.Drawing.Point(6, 104);
            this.dtPhongDen.MultiSelect = false;
            this.dtPhongDen.Name = "dtPhongDen";
            this.dtPhongDen.RowHeadersWidth = 15;
            this.dtPhongDen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPhongDen.Size = new System.Drawing.Size(271, 178);
            this.dtPhongDen.TabIndex = 4;
            this.dtPhongDen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtPhongDen_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKTX";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GIOITINH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lớp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENPHG";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TENDAY";
            this.dataGridViewTextBoxColumn5.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TENKTX";
            this.dataGridViewTextBoxColumn6.HeaderText = "Lớp";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn7.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TENKTX";
            this.dataGridViewTextBoxColumn11.HeaderText = "KTX";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn8.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "GIOITINH";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Nam";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TENPHG";
            this.dataGridViewTextBoxColumn9.HeaderText = "Phòng";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TENDAY";
            this.dataGridViewTextBoxColumn10.HeaderText = "Dãy";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // colMaKTX1
            // 
            this.colMaKTX1.DataPropertyName = "MAKTX";
            this.colMaKTX1.HeaderText = "Mã";
            this.colMaKTX1.Name = "colMaKTX1";
            this.colMaKTX1.ReadOnly = true;
            this.colMaKTX1.Width = 50;
            // 
            // colMaKTX
            // 
            this.colMaKTX.DataPropertyName = "MAKTX";
            this.colMaKTX.HeaderText = "Mã";
            this.colMaKTX.Name = "colMaKTX";
            this.colMaKTX.ReadOnly = true;
            this.colMaKTX.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn14.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 130;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "GIOITINH";
            this.dataGridViewTextBoxColumn15.HeaderText = "Nam";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn15.Width = 35;
            // 
            // colPhong
            // 
            this.colPhong.DataPropertyName = "TENPHG";
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.Name = "colPhong";
            this.colPhong.Width = 50;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TENDAY";
            this.dataGridViewTextBoxColumn17.HeaderText = "Dãy";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TENKTX";
            this.dataGridViewTextBoxColumn18.HeaderText = "KTX";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // frmChuyenPhongSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(618, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 390);
            this.MinimumSize = new System.Drawing.Size(626, 390);
            this.Name = "frmChuyenPhongSinhVien";
            this.Text = "Chuyen phong Sinh vien";
            this.Load += new System.EventHandler(this.frmChuyenPhongSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPhongDi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhongDen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPhongDi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKTXDi;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPhongDen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKTXDen;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnQua;
        private System.Windows.Forms.ToolStripButton btnLai;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDayDen;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtPhongDi;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtPhongDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKTX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}