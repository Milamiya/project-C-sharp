namespace GiaoDienCuaHang
{
    partial class frmTimKiemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTimKH = new System.Windows.Forms.GroupBox();
            this.comboBoxCHONDIENTHOAI = new System.Windows.Forms.ComboBox();
            this.comboBoxchondiachi = new System.Windows.Forms.ComboBox();
            this.labeldiachi = new System.Windows.Forms.Label();
            this.textBoxDIENTHOAI = new System.Windows.Forms.TextBox();
            this.textBoxDIACHI = new System.Windows.Forms.TextBox();
            this.textBoxTEN = new System.Windows.Forms.TextBox();
            this.labelDienthoai = new System.Windows.Forms.Label();
            this.labeltenkhachhang = new System.Windows.Forms.Label();
            this.labelTimKH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxCN = new System.Windows.Forms.GroupBox();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBoxTimKH.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTimKH);
            this.panel1.Controls.Add(this.labelTimKH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 138);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxTimKH
            // 
            this.groupBoxTimKH.Controls.Add(this.comboBoxCHONDIENTHOAI);
            this.groupBoxTimKH.Controls.Add(this.comboBoxchondiachi);
            this.groupBoxTimKH.Controls.Add(this.labeldiachi);
            this.groupBoxTimKH.Controls.Add(this.textBoxDIENTHOAI);
            this.groupBoxTimKH.Controls.Add(this.textBoxDIACHI);
            this.groupBoxTimKH.Controls.Add(this.textBoxTEN);
            this.groupBoxTimKH.Controls.Add(this.labelDienthoai);
            this.groupBoxTimKH.Controls.Add(this.labeltenkhachhang);
            this.groupBoxTimKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTimKH.Location = new System.Drawing.Point(0, 38);
            this.groupBoxTimKH.Name = "groupBoxTimKH";
            this.groupBoxTimKH.Size = new System.Drawing.Size(557, 100);
            this.groupBoxTimKH.TabIndex = 1;
            this.groupBoxTimKH.TabStop = false;
            this.groupBoxTimKH.Text = "Tìm Khách Hàng";
            // 
            // comboBoxCHONDIENTHOAI
            // 
            this.comboBoxCHONDIENTHOAI.FormattingEnabled = true;
            this.comboBoxCHONDIENTHOAI.Items.AddRange(new object[] {
            "NONE",
            "OR",
            "AND",
            "NOT"});
            this.comboBoxCHONDIENTHOAI.Location = new System.Drawing.Point(390, 67);
            this.comboBoxCHONDIENTHOAI.Name = "comboBoxCHONDIENTHOAI";
            this.comboBoxCHONDIENTHOAI.Size = new System.Drawing.Size(58, 21);
            this.comboBoxCHONDIENTHOAI.TabIndex = 8;
            // 
            // comboBoxchondiachi
            // 
            this.comboBoxchondiachi.FormattingEnabled = true;
            this.comboBoxchondiachi.Items.AddRange(new object[] {
            "NONE",
            "OR",
            "AND"});
            this.comboBoxchondiachi.Location = new System.Drawing.Point(54, 67);
            this.comboBoxchondiachi.Name = "comboBoxchondiachi";
            this.comboBoxchondiachi.Size = new System.Drawing.Size(59, 21);
            this.comboBoxchondiachi.TabIndex = 7;
            // 
            // labeldiachi
            // 
            this.labeldiachi.AutoSize = true;
            this.labeldiachi.Location = new System.Drawing.Point(3, 70);
            this.labeldiachi.Name = "labeldiachi";
            this.labeldiachi.Size = new System.Drawing.Size(41, 13);
            this.labeldiachi.TabIndex = 6;
            this.labeldiachi.Text = "Địa Chỉ";
            // 
            // textBoxDIENTHOAI
            // 
            this.textBoxDIENTHOAI.Location = new System.Drawing.Point(454, 67);
            this.textBoxDIENTHOAI.Name = "textBoxDIENTHOAI";
            this.textBoxDIENTHOAI.Size = new System.Drawing.Size(97, 20);
            this.textBoxDIENTHOAI.TabIndex = 5;
            // 
            // textBoxDIACHI
            // 
            this.textBoxDIACHI.Location = new System.Drawing.Point(119, 67);
            this.textBoxDIACHI.Name = "textBoxDIACHI";
            this.textBoxDIACHI.Size = new System.Drawing.Size(185, 20);
            this.textBoxDIACHI.TabIndex = 4;
            // 
            // textBoxTEN
            // 
            this.textBoxTEN.Location = new System.Drawing.Point(244, 23);
            this.textBoxTEN.Name = "textBoxTEN";
            this.textBoxTEN.Size = new System.Drawing.Size(159, 20);
            this.textBoxTEN.TabIndex = 3;
            // 
            // labelDienthoai
            // 
            this.labelDienthoai.AutoSize = true;
            this.labelDienthoai.Location = new System.Drawing.Point(315, 70);
            this.labelDienthoai.Name = "labelDienthoai";
            this.labelDienthoai.Size = new System.Drawing.Size(59, 13);
            this.labelDienthoai.TabIndex = 2;
            this.labelDienthoai.Text = "Điện Thoại";
            // 
            // labeltenkhachhang
            // 
            this.labeltenkhachhang.AutoSize = true;
            this.labeltenkhachhang.Location = new System.Drawing.Point(139, 26);
            this.labeltenkhachhang.Name = "labeltenkhachhang";
            this.labeltenkhachhang.Size = new System.Drawing.Size(89, 13);
            this.labeltenkhachhang.TabIndex = 1;
            this.labeltenkhachhang.Text = "Tên Khách Hàng";
            // 
            // labelTimKH
            // 
            this.labelTimKH.AutoSize = true;
            this.labelTimKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimKH.Location = new System.Drawing.Point(153, 9);
            this.labelTimKH.Name = "labelTimKH";
            this.labelTimKH.Size = new System.Drawing.Size(152, 24);
            this.labelTimKH.TabIndex = 0;
            this.labelTimKH.Text = "Tìm Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxCN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 61);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxCN
            // 
            this.groupBoxCN.Controls.Add(this.buttonxoa);
            this.groupBoxCN.Controls.Add(this.buttonthoat);
            this.groupBoxCN.Controls.Add(this.buttonTim);
            this.groupBoxCN.Location = new System.Drawing.Point(54, 3);
            this.groupBoxCN.Name = "groupBoxCN";
            this.groupBoxCN.Size = new System.Drawing.Size(362, 55);
            this.groupBoxCN.TabIndex = 0;
            this.groupBoxCN.TabStop = false;
            this.groupBoxCN.Text = "Chức Năng";
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(143, 15);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 34);
            this.buttonxoa.TabIndex = 2;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.Location = new System.Drawing.Point(264, 15);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(75, 34);
            this.buttonthoat.TabIndex = 1;
            this.buttonthoat.Text = "Thóat";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(21, 15);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 34);
            this.buttonTim.TabIndex = 0;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMAKH,
            this.ColTenKH,
            this.ColDT,
            this.ColDC});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 131);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColMAKH
            // 
            this.ColMAKH.DataPropertyName = "MAKH";
            this.ColMAKH.HeaderText = "Mã Khách Hàng";
            this.ColMAKH.Name = "ColMAKH";
            // 
            // ColTenKH
            // 
            this.ColTenKH.DataPropertyName = "HOTEN";
            this.ColTenKH.HeaderText = "Tên Khách Hàng";
            this.ColTenKH.Name = "ColTenKH";
            // 
            // ColDT
            // 
            this.ColDT.DataPropertyName = "DIENTHOAI";
            this.ColDT.HeaderText = "Điện Thoại";
            this.ColDT.Name = "ColDT";
            // 
            // ColDC
            // 
            this.ColDC.DataPropertyName = "DIACHI";
            this.ColDC.HeaderText = "Địa Chỉ";
            this.ColDC.Name = "ColDC";
            // 
            // frmTimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 330);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiemKhachHang";
            this.Text = "frmTimKiemKhachHang";
            this.Load += new System.EventHandler(this.frmTimKiemKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxTimKH.ResumeLayout(false);
            this.groupBoxTimKH.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTimKH;
        private System.Windows.Forms.Label labelTimKH;
        private System.Windows.Forms.TextBox textBoxDIENTHOAI;
        private System.Windows.Forms.TextBox textBoxDIACHI;
        private System.Windows.Forms.TextBox textBoxTEN;
        private System.Windows.Forms.Label labelDienthoai;
        private System.Windows.Forms.Label labeltenkhachhang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxCN;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDC;
        private System.Windows.Forms.Label labeldiachi;
        private System.Windows.Forms.ComboBox comboBoxCHONDIENTHOAI;
        private System.Windows.Forms.ComboBox comboBoxchondiachi;
        private System.Windows.Forms.Button buttonxoa;
    }
}