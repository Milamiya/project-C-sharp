namespace GiaoDienCuaHang
{
    partial class frmLapPhieuSuCo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxTT = new System.Windows.Forms.TextBox();
            this.textBoxDG = new System.Windows.Forms.TextBox();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.textBoxLD = new System.Windows.Forms.TextBox();
            this.comboBoxMSP = new System.Windows.Forms.ComboBox();
            this.textBoxMPSC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTT = new System.Windows.Forms.Label();
            this.labelDG = new System.Windows.Forms.Label();
            this.labelSL = new System.Windows.Forms.Label();
            this.labelNHH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMPSC = new System.Windows.Forms.Label();
            this.labelPSC = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMPSC = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMSP = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNgayHH = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLD = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderSLHH = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDG = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTT = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBoxTT);
            this.panel1.Controls.Add(this.textBoxDG);
            this.panel1.Controls.Add(this.textBoxSL);
            this.panel1.Controls.Add(this.textBoxLD);
            this.panel1.Controls.Add(this.comboBoxMSP);
            this.panel1.Controls.Add(this.textBoxMPSC);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelTT);
            this.panel1.Controls.Add(this.labelDG);
            this.panel1.Controls.Add(this.labelSL);
            this.panel1.Controls.Add(this.labelNHH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelMPSC);
            this.panel1.Controls.Add(this.labelPSC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 189);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonIn);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(589, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 105);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(78, 63);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(45, 23);
            this.buttonIn.TabIndex = 3;
            this.buttonIn.Text = "In";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(78, 23);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(45, 23);
            this.buttonXoa.TabIndex = 1;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(6, 23);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(47, 23);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBoxTT
            // 
            this.textBoxTT.Location = new System.Drawing.Point(480, 110);
            this.textBoxTT.Name = "textBoxTT";
            this.textBoxTT.ReadOnly = true;
            this.textBoxTT.Size = new System.Drawing.Size(100, 20);
            this.textBoxTT.TabIndex = 13;
            // 
            // textBoxDG
            // 
            this.textBoxDG.Location = new System.Drawing.Point(480, 70);
            this.textBoxDG.Name = "textBoxDG";
            this.textBoxDG.Size = new System.Drawing.Size(100, 20);
            this.textBoxDG.TabIndex = 12;
            // 
            // textBoxSL
            // 
            this.textBoxSL.Location = new System.Drawing.Point(286, 111);
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(100, 20);
            this.textBoxSL.TabIndex = 11;
            // 
            // textBoxLD
            // 
            this.textBoxLD.Location = new System.Drawing.Point(74, 153);
            this.textBoxLD.Name = "textBoxLD";
            this.textBoxLD.Size = new System.Drawing.Size(506, 20);
            this.textBoxLD.TabIndex = 10;
            // 
            // comboBoxMSP
            // 
            this.comboBoxMSP.FormattingEnabled = true;
            this.comboBoxMSP.Location = new System.Drawing.Point(108, 110);
            this.comboBoxMSP.Name = "comboBoxMSP";
            this.comboBoxMSP.Size = new System.Drawing.Size(88, 21);
            this.comboBoxMSP.TabIndex = 9;
            // 
            // textBoxMPSC
            // 
            this.textBoxMPSC.Location = new System.Drawing.Point(108, 68);
            this.textBoxMPSC.Name = "textBoxMPSC";
            this.textBoxMPSC.Size = new System.Drawing.Size(88, 20);
            this.textBoxMPSC.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lý Do";
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.Location = new System.Drawing.Point(412, 118);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(56, 13);
            this.labelTT.TabIndex = 6;
            this.labelTT.Text = "Tổng Tiền";
            // 
            // labelDG
            // 
            this.labelDG.AutoSize = true;
            this.labelDG.Location = new System.Drawing.Point(412, 72);
            this.labelDG.Name = "labelDG";
            this.labelDG.Size = new System.Drawing.Size(46, 13);
            this.labelDG.TabIndex = 5;
            this.labelDG.Text = "Đơn Giá";
            // 
            // labelSL
            // 
            this.labelSL.AutoSize = true;
            this.labelSL.Location = new System.Drawing.Point(202, 114);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(53, 13);
            this.labelSL.TabIndex = 4;
            this.labelSL.Text = "Số Lượng";
            // 
            // labelNHH
            // 
            this.labelNHH.AutoSize = true;
            this.labelNHH.Location = new System.Drawing.Point(202, 72);
            this.labelNHH.Name = "labelNHH";
            this.labelNHH.Size = new System.Drawing.Size(78, 13);
            this.labelNHH.TabIndex = 3;
            this.labelNHH.Text = "Ngày Hư Hỏng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // labelMPSC
            // 
            this.labelMPSC.AutoSize = true;
            this.labelMPSC.Location = new System.Drawing.Point(18, 71);
            this.labelMPSC.Name = "labelMPSC";
            this.labelMPSC.Size = new System.Drawing.Size(84, 13);
            this.labelMPSC.TabIndex = 1;
            this.labelMPSC.Text = "Mã Phiếu Sự Cố";
            // 
            // labelPSC
            // 
            this.labelPSC.AutoSize = true;
            this.labelPSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPSC.Location = new System.Drawing.Point(315, 9);
            this.labelPSC.Name = "labelPSC";
            this.labelPSC.Size = new System.Drawing.Size(116, 24);
            this.labelPSC.TabIndex = 0;
            this.labelPSC.Text = "Phiếu Sự Cố";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeaderMPSC,
            this.columnHeaderMSP,
            this.columnHeaderNgayHH,
            this.columnHeaderLD,
            this.columnHeaderSLHH,
            this.columnHeaderDG,
            this.columnHeaderTT});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(744, 138);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeaderMPSC
            // 
            this.columnHeaderMPSC.Text = "Mã Phiếu Sự Cố";
            this.columnHeaderMPSC.Width = 92;
            // 
            // columnHeaderMSP
            // 
            this.columnHeaderMSP.Text = "Mã Sản Phẩm";
            this.columnHeaderMSP.Width = 83;
            // 
            // columnHeaderNgayHH
            // 
            this.columnHeaderNgayHH.Text = "Ngày Hư Hỏng";
            this.columnHeaderNgayHH.Width = 89;
            // 
            // columnHeaderLD
            // 
            this.columnHeaderLD.Text = "Lý Do";
            this.columnHeaderLD.Width = 202;
            // 
            // columnHeaderSLHH
            // 
            this.columnHeaderSLHH.Text = "Số Lượng Hư Hỏng";
            this.columnHeaderSLHH.Width = 109;
            // 
            // columnHeaderDG
            // 
            this.columnHeaderDG.Text = "Đơn Giá";
            this.columnHeaderDG.Width = 74;
            // 
            // columnHeaderTT
            // 
            this.columnHeaderTT.Text = "Tổng Tiền";
            this.columnHeaderTT.Width = 88;
            // 
            // frmLapPhieuSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 327);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmLapPhieuSuCo";
            this.Text = "frmLapPhieuSuCo";
            this.Load += new System.EventHandler(this.frmLapPhieuSuCo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPSC;
        private System.Windows.Forms.Label labelMPSC;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderMPSC;
        private System.Windows.Forms.ColumnHeader columnHeaderMSP;
        private System.Windows.Forms.ColumnHeader columnHeaderNgayHH;
        private System.Windows.Forms.ColumnHeader columnHeaderLD;
        private System.Windows.Forms.ColumnHeader columnHeaderSLHH;
        private System.Windows.Forms.ColumnHeader columnHeaderDG;
        private System.Windows.Forms.ColumnHeader columnHeaderTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.Label labelDG;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.Label labelNHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMPSC;
        private System.Windows.Forms.ComboBox comboBoxMSP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxTT;
        private System.Windows.Forms.TextBox textBoxDG;
        private System.Windows.Forms.TextBox textBoxSL;
        private System.Windows.Forms.TextBox textBoxLD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}