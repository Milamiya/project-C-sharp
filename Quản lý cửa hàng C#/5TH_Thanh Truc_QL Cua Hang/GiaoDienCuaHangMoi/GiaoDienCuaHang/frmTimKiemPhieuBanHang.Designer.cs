namespace GiaoDienCuaHang
{
    partial class frmTimKiemPhieuBanHang
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
            this.labelDen = new System.Windows.Forms.Label();
            this.labelTu = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNL = new System.Windows.Forms.Label();
            this.labelMNV = new System.Windows.Forms.Label();
            this.labelMKH = new System.Windows.Forms.Label();
            this.labelTKPBH = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxCN = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.labelTKPBH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 218);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.labelDen);
            this.groupBox1.Controls.Add(this.labelTu);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelNL);
            this.groupBox1.Controls.Add(this.labelMNV);
            this.groupBox1.Controls.Add(this.labelMKH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // labelDen
            // 
            this.labelDen.AutoSize = true;
            this.labelDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelDen.Location = new System.Drawing.Point(347, 95);
            this.labelDen.Name = "labelDen";
            this.labelDen.Size = new System.Drawing.Size(32, 16);
            this.labelDen.TabIndex = 11;
            this.labelDen.Text = "Đến";
            // 
            // labelTu
            // 
            this.labelTu.AutoSize = true;
            this.labelTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelTu.Location = new System.Drawing.Point(196, 95);
            this.labelTu.Name = "labelTu";
            this.labelTu.Size = new System.Drawing.Size(24, 16);
            this.labelTu.TabIndex = 10;
            this.labelTu.Text = "Từ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(409, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "NONE",
            "AND",
            "OR"});
            this.comboBox4.Location = new System.Drawing.Point(114, 92);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(62, 24);
            this.comboBox4.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "NV001",
            "NV002",
            "NV003",
            "NV004",
            "NV005"});
            this.comboBox3.Location = new System.Drawing.Point(202, 57);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "NONE",
            "AND",
            "OR"});
            this.comboBox2.Location = new System.Drawing.Point(114, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(62, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "KH001",
            "KH002",
            "KH003",
            "KH004",
            "KH005"});
            this.comboBox1.Location = new System.Drawing.Point(114, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // labelNL
            // 
            this.labelNL.AutoSize = true;
            this.labelNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelNL.Location = new System.Drawing.Point(12, 95);
            this.labelNL.Name = "labelNL";
            this.labelNL.Size = new System.Drawing.Size(67, 16);
            this.labelNL.TabIndex = 2;
            this.labelNL.Text = "Ngày Lập";
            // 
            // labelMNV
            // 
            this.labelMNV.AutoSize = true;
            this.labelMNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelMNV.Location = new System.Drawing.Point(12, 59);
            this.labelMNV.Name = "labelMNV";
            this.labelMNV.Size = new System.Drawing.Size(92, 16);
            this.labelMNV.TabIndex = 1;
            this.labelMNV.Text = "Mã Nhân Viên";
            // 
            // labelMKH
            // 
            this.labelMKH.AutoSize = true;
            this.labelMKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelMKH.Location = new System.Drawing.Point(12, 26);
            this.labelMKH.Name = "labelMKH";
            this.labelMKH.Size = new System.Drawing.Size(103, 16);
            this.labelMKH.TabIndex = 0;
            this.labelMKH.Text = "Mã Khách Hàng";
            // 
            // labelTKPBH
            // 
            this.labelTKPBH.AutoSize = true;
            this.labelTKPBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTKPBH.ForeColor = System.Drawing.Color.Navy;
            this.labelTKPBH.Location = new System.Drawing.Point(157, 27);
            this.labelTKPBH.Name = "labelTKPBH";
            this.labelTKPBH.Size = new System.Drawing.Size(353, 31);
            this.labelTKPBH.TabIndex = 0;
            this.labelTKPBH.Text = "Tìm Kiếm Phiếu Bán Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMP,
            this.ColMKH,
            this.ColMNV,
            this.ColNL,
            this.ColTT});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(123, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 112);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColMP
            // 
            this.ColMP.DataPropertyName = "MAPHIEU";
            this.ColMP.HeaderText = "Mã Phiếu";
            this.ColMP.Name = "ColMP";
            // 
            // ColMKH
            // 
            this.ColMKH.DataPropertyName = "MAKH";
            this.ColMKH.HeaderText = "Mã Khách Hàng";
            this.ColMKH.Name = "ColMKH";
            // 
            // ColMNV
            // 
            this.ColMNV.DataPropertyName = "MANV";
            this.ColMNV.HeaderText = "Mã Nhân Viên";
            this.ColMNV.Name = "ColMNV";
            // 
            // ColNL
            // 
            this.ColNL.DataPropertyName = "NGAYLAP";
            this.ColNL.HeaderText = "Ngày Lập";
            this.ColNL.Name = "ColNL";
            // 
            // ColTT
            // 
            this.ColTT.DataPropertyName = "TONGTIEN";
            this.ColTT.HeaderText = "Tổng Tiền";
            this.ColTT.Name = "ColTT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxCN);
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 121);
            this.panel2.TabIndex = 2;
            // 
            // groupBoxCN
            // 
            this.groupBoxCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxCN.Controls.Add(this.buttonxoa);
            this.groupBoxCN.Controls.Add(this.buttonThoat);
            this.groupBoxCN.Controls.Add(this.buttonTim);
            this.groupBoxCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxCN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCN.Name = "groupBoxCN";
            this.groupBoxCN.Size = new System.Drawing.Size(117, 121);
            this.groupBoxCN.TabIndex = 0;
            this.groupBoxCN.TabStop = false;
            this.groupBoxCN.Text = "Chức Năng";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(21, 80);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.AutoSize = true;
            this.buttonTim.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonTim.Location = new System.Drawing.Point(21, 22);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 0;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPHIEU";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phiếu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYLAP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày Lập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TONGTIEN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(21, 51);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 3;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // frmTimKiemPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 332);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiemPhieuBanHang";
            this.Text = "frmTimKiemPhieuBanHang";
            this.Load += new System.EventHandler(this.frmTimKiemPhieuBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxCN.ResumeLayout(false);
            this.groupBoxCN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTKPBH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelNL;
        private System.Windows.Forms.Label labelMNV;
        private System.Windows.Forms.Label labelMKH;
        private System.Windows.Forms.Label labelDen;
        private System.Windows.Forms.Label labelTu;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTT;
        private System.Windows.Forms.GroupBox groupBoxCN;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonxoa;
    }
}