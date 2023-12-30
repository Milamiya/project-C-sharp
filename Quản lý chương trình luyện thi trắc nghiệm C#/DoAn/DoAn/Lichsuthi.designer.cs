namespace Doan
{
    partial class frmLichsuthi
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mathisinh = new System.Windows.Forms.ColumnHeader();
            this.ten = new System.Windows.Forms.ColumnHeader();
            this.ngaythi = new System.Windows.Forms.ColumnHeader();
            this.socaudung = new System.Windows.Forms.ColumnHeader();
            this.socausai = new System.Windows.Forms.ColumnHeader();
            this.diem = new System.Windows.Forms.ColumnHeader();
            this.tbngaythang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdbt2 = new System.Windows.Forms.RadioButton();
            this.rdbt3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbmats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm thí sinh đã thi";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mathisinh,
            this.ten,
            this.ngaythi,
            this.socaudung,
            this.socausai,
            this.diem});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(88, 218);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(605, 275);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // mathisinh
            // 
            this.mathisinh.Text = "Mã thí sinh";
            this.mathisinh.Width = 80;
            // 
            // ten
            // 
            this.ten.Text = "Tên thí sinh";
            this.ten.Width = 120;
            // 
            // ngaythi
            // 
            this.ngaythi.Text = "Ngày thi";
            this.ngaythi.Width = 120;
            // 
            // socaudung
            // 
            this.socaudung.Text = "Số câu đúng";
            this.socaudung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.socaudung.Width = 110;
            // 
            // socausai
            // 
            this.socausai.Text = "Số câu sai";
            this.socausai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.socausai.Width = 110;
            // 
            // diem
            // 
            this.diem.Text = "Điểm";
            this.diem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbngaythang
            // 
            this.tbngaythang.Location = new System.Drawing.Point(127, 19);
            this.tbngaythang.Name = "tbngaythang";
            this.tbngaythang.Size = new System.Drawing.Size(138, 20);
            this.tbngaythang.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbmats);
            this.groupBox1.Controls.Add(this.rdb4);
            this.groupBox1.Controls.Add(this.rdb1);
            this.groupBox1.Controls.Add(this.rdbt2);
            this.groupBox1.Controls.Add(this.rdbt3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbngaythang);
            this.groupBox1.Location = new System.Drawing.Point(88, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(284, 98);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(76, 17);
            this.rdb4.TabIndex = 8;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "Xem tất cả";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.CheckedChanged += new System.EventHandler(this.rdb4_CheckedChanged);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(284, 17);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(76, 17);
            this.rdb1.TabIndex = 7;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Theo ngày";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // rdbt2
            // 
            this.rdbt2.AutoSize = true;
            this.rdbt2.Location = new System.Drawing.Point(284, 46);
            this.rdbt2.Name = "rdbt2";
            this.rdbt2.Size = new System.Drawing.Size(121, 17);
            this.rdbt2.TabIndex = 7;
            this.rdbt2.TabStop = true;
            this.rdbt2.Text = "Theo điểm cao nhất";
            this.rdbt2.UseVisualStyleBackColor = true;
            this.rdbt2.CheckedChanged += new System.EventHandler(this.rdbt2_CheckedChanged_1);
            // 
            // rdbt3
            // 
            this.rdbt3.AutoSize = true;
            this.rdbt3.Location = new System.Drawing.Point(284, 75);
            this.rdbt3.Name = "rdbt3";
            this.rdbt3.Size = new System.Drawing.Size(122, 17);
            this.rdbt3.TabIndex = 7;
            this.rdbt3.TabStop = true;
            this.rdbt3.Text = "Theo Điểm thất nhất";
            this.rdbt3.UseVisualStyleBackColor = true;
            this.rdbt3.CheckedChanged += new System.EventHandler(this.rdbt3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tháng /ngày/năm";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Doan.Properties.Resources.bt;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(450, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Doan.Properties.Resources.bt;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(709, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 510);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbmats
            // 
            this.tbmats.Enabled = false;
            this.tbmats.Location = new System.Drawing.Point(81, 99);
            this.tbmats.Name = "tbmats";
            this.tbmats.Size = new System.Drawing.Size(96, 20);
            this.tbmats.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã thí sinh :";
            // 
            // frmLichsuthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doan.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 585);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "frmLichsuthi";
            this.Text = "Thí sinh đã thi";
            this.Load += new System.EventHandler(this.frmLichsuthi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ngaythi;
        private System.Windows.Forms.ColumnHeader mathisinh;
        private System.Windows.Forms.ColumnHeader socaudung;
        private System.Windows.Forms.ColumnHeader socausai;
        private System.Windows.Forms.ColumnHeader diem;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.TextBox tbngaythang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdbt2;
        private System.Windows.Forms.RadioButton rdbt3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdb4;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbmats;
        private System.Windows.Forms.Label label2;

    }
}