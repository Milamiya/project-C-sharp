namespace GiaoDienCuaHang
{
    partial class frmTimKiemDVT
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
            this.groupBoxchucnang = new System.Windows.Forms.GroupBox();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonTim = new System.Windows.Forms.Button();
            this.groupBoxTimDVT = new System.Windows.Forms.GroupBox();
            this.txtenDVT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimDVT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColMADVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBoxchucnang.SuspendLayout();
            this.groupBoxTimDVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxchucnang);
            this.panel1.Controls.Add(this.groupBoxTimDVT);
            this.panel1.Controls.Add(this.labelTimDVT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 150);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxchucnang
            // 
            this.groupBoxchucnang.Controls.Add(this.buttonxoa);
            this.groupBoxchucnang.Controls.Add(this.buttonThoat);
            this.groupBoxchucnang.Controls.Add(this.buttonTim);
            this.groupBoxchucnang.Location = new System.Drawing.Point(347, 33);
            this.groupBoxchucnang.Name = "groupBoxchucnang";
            this.groupBoxchucnang.Size = new System.Drawing.Size(137, 108);
            this.groupBoxchucnang.TabIndex = 2;
            this.groupBoxchucnang.TabStop = false;
            this.groupBoxchucnang.Text = "Chức Năng";
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(28, 53);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 2;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(28, 82);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 1;
            this.buttonThoat.Text = "Thóat";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(28, 24);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 0;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // groupBoxTimDVT
            // 
            this.groupBoxTimDVT.Controls.Add(this.txtenDVT);
            this.groupBoxTimDVT.Controls.Add(this.label2);
            this.groupBoxTimDVT.Location = new System.Drawing.Point(12, 33);
            this.groupBoxTimDVT.Name = "groupBoxTimDVT";
            this.groupBoxTimDVT.Size = new System.Drawing.Size(318, 109);
            this.groupBoxTimDVT.TabIndex = 1;
            this.groupBoxTimDVT.TabStop = false;
            this.groupBoxTimDVT.Text = "Tìm Đơn Vị Tính";
            // 
            // txtenDVT
            // 
            this.txtenDVT.Location = new System.Drawing.Point(152, 46);
            this.txtenDVT.Name = "txtenDVT";
            this.txtenDVT.Size = new System.Drawing.Size(147, 20);
            this.txtenDVT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đơn Vị Tính";
            // 
            // labelTimDVT
            // 
            this.labelTimDVT.AutoSize = true;
            this.labelTimDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimDVT.Location = new System.Drawing.Point(164, 9);
            this.labelTimDVT.Name = "labelTimDVT";
            this.labelTimDVT.Size = new System.Drawing.Size(147, 24);
            this.labelTimDVT.TabIndex = 0;
            this.labelTimDVT.Text = "Tìm Đơn Vị Tính";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMADVT,
            this.ColTenDVT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 116);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColMADVT
            // 
            this.ColMADVT.DataPropertyName = "MADVT";
            this.ColMADVT.HeaderText = "Mã Đơn Vị Tính";
            this.ColMADVT.Name = "ColMADVT";
            // 
            // ColTenDVT
            // 
            this.ColTenDVT.DataPropertyName = "TENDVT";
            this.ColTenDVT.HeaderText = "Tên Đơn Vị Tính";
            this.ColTenDVT.Name = "ColTenDVT";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MADVT";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Đơn Vị Tính";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENDVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Đơn Vị Tính";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmTimKiemDVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 266);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiemDVT";
            this.Text = "frmTimKiemDVT";
           
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxchucnang.ResumeLayout(false);
            this.groupBoxTimDVT.ResumeLayout(false);
            this.groupBoxTimDVT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTimDVT;
        private System.Windows.Forms.GroupBox groupBoxTimDVT;
        private System.Windows.Forms.TextBox txtenDVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMADVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenDVT;
        private System.Windows.Forms.GroupBox groupBoxchucnang;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonxoa;
    }
}