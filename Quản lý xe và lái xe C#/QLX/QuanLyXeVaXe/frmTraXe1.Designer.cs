namespace QuanLyXeVaXe
{
    partial class frmTraXe1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdTimKiem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.ComboBox();
            this.txtMaHD_Search = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayTraXeThucTe = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.ComboBox();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdNext = new System.Windows.Forms.Button();
            this.txtMaKL = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã hợp đồng cần trả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(489, 120);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmdTimKiem
            // 
            this.cmdTimKiem.Location = new System.Drawing.Point(360, 15);
            this.cmdTimKiem.Name = "cmdTimKiem";
            this.cmdTimKiem.Size = new System.Drawing.Size(75, 23);
            this.cmdTimKiem.TabIndex = 3;
            this.cmdTimKiem.Text = "Tìm kiếm";
            this.cmdTimKiem.UseVisualStyleBackColor = true;
            this.cmdTimKiem.Click += new System.EventHandler(this.cmdTimKiem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(489, 74);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.FormattingEnabled = true;
            this.txtMaKH.Location = new System.Drawing.Point(102, 172);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(121, 23);
            this.txtMaKH.TabIndex = 6;
            this.txtMaKH.SelectedIndexChanged += new System.EventHandler(this.txtMaKH_SelectedIndexChanged);
            // 
            // txtMaHD_Search
            // 
            this.txtMaHD_Search.Location = new System.Drawing.Point(190, 17);
            this.txtMaHD_Search.Name = "txtMaHD_Search";
            this.txtMaHD_Search.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD_Search.TabIndex = 7;
            this.txtMaHD_Search.TextChanged += new System.EventHandler(this.txtMaHD_Search_TextChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.FormattingEnabled = true;
            this.txtMaHD.Location = new System.Drawing.Point(102, 137);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(121, 20);
            this.txtMaHD.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã HĐ";
            // 
            // dtpNgayTraXeThucTe
            // 
            this.dtpNgayTraXeThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraXeThucTe.Location = new System.Drawing.Point(367, 173);
            this.dtpNgayTraXeThucTe.Name = "dtpNgayTraXeThucTe";
            this.dtpNgayTraXeThucTe.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayTraXeThucTe.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày trả xe thực tế";
            // 
            // txtMaNV
            // 
            this.txtMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaNV.FormattingEnabled = true;
            this.txtMaNV.Location = new System.Drawing.Point(367, 137);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(121, 21);
            this.txtMaNV.TabIndex = 10;
            // 
            // cmdThem
            // 
            this.cmdThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdThem.Location = new System.Drawing.Point(103, 380);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(75, 23);
            this.cmdThem.TabIndex = 11;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(271, 380);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(75, 23);
            this.cmdNext.TabIndex = 12;
            this.cmdNext.Text = "Next";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // txtMaKL
            // 
            this.txtMaKL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaKL.FormattingEnabled = true;
            this.txtMaKL.Location = new System.Drawing.Point(102, 213);
            this.txtMaKL.Name = "txtMaKL";
            this.txtMaKL.Size = new System.Drawing.Size(121, 21);
            this.txtMaKL.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã kỷ luật";
            // 
            // frmTraXe1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 459);
            this.Controls.Add(this.txtMaKL);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.dtpNgayTraXeThucTe);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtMaHD_Search);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdTimKiem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmTraXe1";
            this.Text = "frmTraXe1";
            this.Load += new System.EventHandler(this.frmTraXe1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdTimKiem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHD_Search;
        private System.Windows.Forms.ComboBox txtMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayTraXeThucTe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtMaNV;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.ComboBox txtMaKL;
        private System.Windows.Forms.Label label6;
    }
}