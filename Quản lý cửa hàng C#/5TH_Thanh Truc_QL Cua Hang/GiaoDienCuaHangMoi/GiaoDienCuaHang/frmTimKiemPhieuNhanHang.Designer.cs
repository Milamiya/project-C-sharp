namespace GiaoDienCuaHang
{
    partial class frmTimKiemPhieuNhanHang
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
            this.groupBoxTTTK = new System.Windows.Forms.GroupBox();
            this.labelDen = new System.Windows.Forms.Label();
            this.labelTuNgay = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNL = new System.Windows.Forms.Label();
            this.labelMNV = new System.Windows.Forms.Label();
            this.labelMNCC = new System.Windows.Forms.Label();
            this.labelTKPNH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBoxTTTK.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTTTK);
            this.panel1.Controls.Add(this.labelTKPNH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 202);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxTTTK
            // 
            this.groupBoxTTTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxTTTK.Controls.Add(this.labelDen);
            this.groupBoxTTTK.Controls.Add(this.labelTuNgay);
            this.groupBoxTTTK.Controls.Add(this.dateTimePicker2);
            this.groupBoxTTTK.Controls.Add(this.dateTimePicker1);
            this.groupBoxTTTK.Controls.Add(this.comboBox4);
            this.groupBoxTTTK.Controls.Add(this.comboBox3);
            this.groupBoxTTTK.Controls.Add(this.comboBox2);
            this.groupBoxTTTK.Controls.Add(this.comboBox1);
            this.groupBoxTTTK.Controls.Add(this.labelNL);
            this.groupBoxTTTK.Controls.Add(this.labelMNV);
            this.groupBoxTTTK.Controls.Add(this.labelMNCC);
            this.groupBoxTTTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTTTK.Location = new System.Drawing.Point(0, 58);
            this.groupBoxTTTK.Name = "groupBoxTTTK";
            this.groupBoxTTTK.Size = new System.Drawing.Size(489, 144);
            this.groupBoxTTTK.TabIndex = 1;
            this.groupBoxTTTK.TabStop = false;
            this.groupBoxTTTK.Text = "Thông Tin Tìm Kiếm";
            // 
            // labelDen
            // 
            this.labelDen.AutoSize = true;
            this.labelDen.ForeColor = System.Drawing.Color.Red;
            this.labelDen.Location = new System.Drawing.Point(350, 103);
            this.labelDen.Name = "labelDen";
            this.labelDen.Size = new System.Drawing.Size(32, 16);
            this.labelDen.TabIndex = 12;
            this.labelDen.Text = "Đến";
            // 
            // labelTuNgay
            // 
            this.labelTuNgay.AutoSize = true;
            this.labelTuNgay.ForeColor = System.Drawing.Color.Red;
            this.labelTuNgay.Location = new System.Drawing.Point(180, 103);
            this.labelTuNgay.Name = "labelTuNgay";
            this.labelTuNgay.Size = new System.Drawing.Size(60, 16);
            this.labelTuNgay.TabIndex = 11;
            this.labelTuNgay.Text = "Từ Ngày";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(388, 100);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(89, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "NONE",
            "AND",
            "OR"});
            this.comboBox4.Location = new System.Drawing.Point(112, 100);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(65, 24);
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
            this.comboBox3.Location = new System.Drawing.Point(183, 64);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(99, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "NONE",
            "AND",
            "OR"});
            this.comboBox2.Location = new System.Drawing.Point(112, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 24);
            this.comboBox2.TabIndex = 5;
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
            this.comboBox1.Location = new System.Drawing.Point(112, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // labelNL
            // 
            this.labelNL.AutoSize = true;
            this.labelNL.ForeColor = System.Drawing.Color.Red;
            this.labelNL.Location = new System.Drawing.Point(12, 103);
            this.labelNL.Name = "labelNL";
            this.labelNL.Size = new System.Drawing.Size(67, 16);
            this.labelNL.TabIndex = 2;
            this.labelNL.Text = "Ngày Lập";
            // 
            // labelMNV
            // 
            this.labelMNV.AutoSize = true;
            this.labelMNV.ForeColor = System.Drawing.Color.Red;
            this.labelMNV.Location = new System.Drawing.Point(12, 67);
            this.labelMNV.Name = "labelMNV";
            this.labelMNV.Size = new System.Drawing.Size(92, 16);
            this.labelMNV.TabIndex = 1;
            this.labelMNV.Text = "Mã Nhân Viên";
            // 
            // labelMNCC
            // 
            this.labelMNCC.AutoSize = true;
            this.labelMNCC.ForeColor = System.Drawing.Color.Red;
            this.labelMNCC.Location = new System.Drawing.Point(12, 28);
            this.labelMNCC.Name = "labelMNCC";
            this.labelMNCC.Size = new System.Drawing.Size(58, 16);
            this.labelMNCC.TabIndex = 0;
            this.labelMNCC.Text = "Mã NCC";
            // 
            // labelTKPNH
            // 
            this.labelTKPNH.AutoSize = true;
            this.labelTKPNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTKPNH.ForeColor = System.Drawing.Color.Olive;
            this.labelTKPNH.Location = new System.Drawing.Point(55, 9);
            this.labelTKPNH.Name = "labelTKPNH";
            this.labelTKPNH.Size = new System.Drawing.Size(371, 31);
            this.labelTKPNH.TabIndex = 0;
            this.labelTKPNH.Text = "Tìm Kiếm Phiếu Nhận Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.buttonxoa);
            this.panel2.Controls.Add(this.buttonThoat);
            this.panel2.Controls.Add(this.buttonTim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 46);
            this.panel2.TabIndex = 1;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(292, 11);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(76, 11);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 0;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMP,
            this.ColMNCC,
            this.ColMNV,
            this.ColNL});
            this.dataGridView1.Location = new System.Drawing.Point(0, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 87);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(183, 11);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 3;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPHIEU";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phiếu";
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
            // ColMP
            // 
            this.ColMP.DataPropertyName = "MAPHIEU";
            this.ColMP.HeaderText = "Mã Phiếu";
            this.ColMP.Name = "ColMP";
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
            // frmTimKiemPhieuNhanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiemPhieuNhanHang";
            this.Text = "frmTimKiemPhieuNhanHang";
            this.Load += new System.EventHandler(this.frmTimKiemPhieuNhanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxTTTK.ResumeLayout(false);
            this.groupBoxTTTK.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTTTK;
        private System.Windows.Forms.Label labelNL;
        private System.Windows.Forms.Label labelMNV;
        private System.Windows.Forms.Label labelMNCC;
        private System.Windows.Forms.Label labelTKPNH;
        private System.Windows.Forms.Label labelDen;
        private System.Windows.Forms.Label labelTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNL;
    }
}