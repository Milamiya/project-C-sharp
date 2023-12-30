namespace GiaoDienCuaHang
{
    partial class frmTimKiemPhieuDatHang
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
            this.groupBoxCN = new System.Windows.Forms.GroupBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttontim = new System.Windows.Forms.Button();
            this.groupBoxTTTK = new System.Windows.Forms.GroupBox();
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
            this.labelMNCC = new System.Windows.Forms.Label();
            this.labelTKPDH = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMPDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBoxCN.SuspendLayout();
            this.groupBoxTTTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.groupBoxCN);
            this.panel1.Controls.Add(this.groupBoxTTTK);
            this.panel1.Controls.Add(this.labelTKPDH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 215);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxCN
            // 
            this.groupBoxCN.Controls.Add(this.buttonxoa);
            this.groupBoxCN.Controls.Add(this.buttonThoat);
            this.groupBoxCN.Controls.Add(this.buttontim);
            this.groupBoxCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCN.Location = new System.Drawing.Point(485, 59);
            this.groupBoxCN.Name = "groupBoxCN";
            this.groupBoxCN.Size = new System.Drawing.Size(92, 150);
            this.groupBoxCN.TabIndex = 2;
            this.groupBoxCN.TabStop = false;
            this.groupBoxCN.Text = "Chức Năng";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(7, 108);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttontim
            // 
            this.buttontim.Location = new System.Drawing.Point(7, 28);
            this.buttontim.Name = "buttontim";
            this.buttontim.Size = new System.Drawing.Size(75, 23);
            this.buttontim.TabIndex = 0;
            this.buttontim.Text = "Tìm ";
            this.buttontim.UseVisualStyleBackColor = true;
            this.buttontim.Click += new System.EventHandler(this.buttontim_Click);
            // 
            // groupBoxTTTK
            // 
            this.groupBoxTTTK.Controls.Add(this.labelDen);
            this.groupBoxTTTK.Controls.Add(this.labelTu);
            this.groupBoxTTTK.Controls.Add(this.dateTimePicker2);
            this.groupBoxTTTK.Controls.Add(this.dateTimePicker1);
            this.groupBoxTTTK.Controls.Add(this.comboBox4);
            this.groupBoxTTTK.Controls.Add(this.comboBox3);
            this.groupBoxTTTK.Controls.Add(this.comboBox2);
            this.groupBoxTTTK.Controls.Add(this.comboBox1);
            this.groupBoxTTTK.Controls.Add(this.labelNL);
            this.groupBoxTTTK.Controls.Add(this.labelMNV);
            this.groupBoxTTTK.Controls.Add(this.labelMNCC);
            this.groupBoxTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTTTK.Location = new System.Drawing.Point(3, 59);
            this.groupBoxTTTK.Name = "groupBoxTTTK";
            this.groupBoxTTTK.Size = new System.Drawing.Size(476, 150);
            this.groupBoxTTTK.TabIndex = 1;
            this.groupBoxTTTK.TabStop = false;
            this.groupBoxTTTK.Text = "Thông Tin Tìm Kiếm";
            // 
            // labelDen
            // 
            this.labelDen.AutoSize = true;
            this.labelDen.ForeColor = System.Drawing.Color.Purple;
            this.labelDen.Location = new System.Drawing.Point(306, 115);
            this.labelDen.Name = "labelDen";
            this.labelDen.Size = new System.Drawing.Size(32, 16);
            this.labelDen.TabIndex = 10;
            this.labelDen.Text = "Đến";
            // 
            // labelTu
            // 
            this.labelTu.AutoSize = true;
            this.labelTu.ForeColor = System.Drawing.Color.Purple;
            this.labelTu.Location = new System.Drawing.Point(167, 114);
            this.labelTu.Name = "labelTu";
            this.labelTu.Size = new System.Drawing.Size(24, 16);
            this.labelTu.TabIndex = 9;
            this.labelTu.Text = "Từ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(340, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "NV001",
            "NV002",
            "NV003",
            "NV004",
            "NV005"});
            this.comboBox4.Location = new System.Drawing.Point(193, 67);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(130, 24);
            this.comboBox4.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "NONE",
            "AND",
            "OR"});
            this.comboBox3.Location = new System.Drawing.Point(87, 112);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(69, 24);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "NONE",
            "AND",
            "OR"});
            this.comboBox2.Location = new System.Drawing.Point(118, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(69, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NCC001",
            "NCC002",
            "NCC003",
            "NCC004",
            "NCC005"});
            this.comboBox1.Location = new System.Drawing.Point(129, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // labelNL
            // 
            this.labelNL.AutoSize = true;
            this.labelNL.ForeColor = System.Drawing.Color.Purple;
            this.labelNL.Location = new System.Drawing.Point(6, 115);
            this.labelNL.Name = "labelNL";
            this.labelNL.Size = new System.Drawing.Size(67, 16);
            this.labelNL.TabIndex = 2;
            this.labelNL.Text = "Ngày Lập";
            // 
            // labelMNV
            // 
            this.labelMNV.AutoSize = true;
            this.labelMNV.ForeColor = System.Drawing.Color.Purple;
            this.labelMNV.Location = new System.Drawing.Point(6, 70);
            this.labelMNV.Name = "labelMNV";
            this.labelMNV.Size = new System.Drawing.Size(92, 16);
            this.labelMNV.TabIndex = 1;
            this.labelMNV.Text = "Mã Nhân Viên";
            // 
            // labelMNCC
            // 
            this.labelMNCC.AutoSize = true;
            this.labelMNCC.ForeColor = System.Drawing.Color.Purple;
            this.labelMNCC.Location = new System.Drawing.Point(6, 28);
            this.labelMNCC.Name = "labelMNCC";
            this.labelMNCC.Size = new System.Drawing.Size(117, 16);
            this.labelMNCC.TabIndex = 0;
            this.labelMNCC.Text = "Mã Nhà Cung Cấp";
            // 
            // labelTKPDH
            // 
            this.labelTKPDH.AutoSize = true;
            this.labelTKPDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTKPDH.ForeColor = System.Drawing.Color.Green;
            this.labelTKPDH.Location = new System.Drawing.Point(131, 9);
            this.labelTKPDH.Name = "labelTKPDH";
            this.labelTKPDH.Size = new System.Drawing.Size(348, 31);
            this.labelTKPDH.TabIndex = 0;
            this.labelTKPDH.Text = "Tìm Kiếm Phiếu Đặt Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMPDH,
            this.ColMNCC,
            this.ColMNV,
            this.ColNL});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 105);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(7, 66);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 3;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPHIEUDATHANG";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã PĐH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANCC";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã NCC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYLAP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày Lập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ColMPDH
            // 
            this.ColMPDH.DataPropertyName = "MAPHIEUDATHANG";
            this.ColMPDH.HeaderText = "Mã PĐH";
            this.ColMPDH.Name = "ColMPDH";
            // 
            // ColMNCC
            // 
            this.ColMNCC.DataPropertyName = "MANCC";
            this.ColMNCC.HeaderText = "Mã NCC";
            this.ColMNCC.Name = "ColMNCC";
            // 
            // ColMNV
            // 
            this.ColMNV.DataPropertyName = "MANV";
            this.ColMNV.HeaderText = "Mã NV";
            this.ColMNV.Name = "ColMNV";
            // 
            // ColNL
            // 
            this.ColNL.DataPropertyName = "NGAYLAP";
            this.ColNL.HeaderText = "Ngày Lập";
            this.ColNL.Name = "ColNL";
            // 
            // frmTimKiemPhieuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 320);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiemPhieuDatHang";
            this.Text = "TimKiemPhieuDatHang";
            this.Load += new System.EventHandler(this.frmTimKiemPhieuDatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxCN.ResumeLayout(false);
            this.groupBoxTTTK.ResumeLayout(false);
            this.groupBoxTTTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTKPDH;
        private System.Windows.Forms.GroupBox groupBoxTTTK;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelNL;
        private System.Windows.Forms.Label labelMNV;
        private System.Windows.Forms.Label labelMNCC;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTu;
        private System.Windows.Forms.GroupBox groupBoxCN;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttontim;
        private System.Windows.Forms.Label labelDen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMPDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNL;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}