namespace QuanLyXeVaXe
{
    partial class frmTimKiemKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemKH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdTimKiemKH = new System.Windows.Forms.Button();
            this.dgvTimKiemKH = new System.Windows.Forms.DataGridView();
            this.grbTimKiemKhachHang = new System.Windows.Forms.GroupBox();
            this.rbTimKiemTheoMaKH = new System.Windows.Forms.RadioButton();
            this.rbTimKiemTheoDiaChiKH = new System.Windows.Forms.RadioButton();
            this.rbTimKiemTheoTenKH = new System.Windows.Forms.RadioButton();
            this.rbTimKiemTheoMaHopDong = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).BeginInit();
            this.grbTimKiemKhachHang.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdTimKiemKH
            // 
            this.cmdTimKiemKH.BackColor = System.Drawing.Color.Green;
            this.cmdTimKiemKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdTimKiemKH.BackgroundImage")));
            this.cmdTimKiemKH.Location = new System.Drawing.Point(644, 130);
            this.cmdTimKiemKH.Name = "cmdTimKiemKH";
            this.cmdTimKiemKH.Size = new System.Drawing.Size(70, 70);
            this.cmdTimKiemKH.TabIndex = 0;
            this.cmdTimKiemKH.UseVisualStyleBackColor = false;
            this.cmdTimKiemKH.Click += new System.EventHandler(this.cmdTimKiemKH_Click);
            // 
            // dgvTimKiemKH
            // 
            this.dgvTimKiemKH.AllowUserToAddRows = false;
            this.dgvTimKiemKH.AllowUserToDeleteRows = false;
            this.dgvTimKiemKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimKiemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKiemKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimKiemKH.Location = new System.Drawing.Point(0, 3);
            this.dgvTimKiemKH.Name = "dgvTimKiemKH";
            this.dgvTimKiemKH.ReadOnly = true;
            this.dgvTimKiemKH.Size = new System.Drawing.Size(965, 259);
            this.dgvTimKiemKH.TabIndex = 1;
            // 
            // grbTimKiemKhachHang
            // 
            this.grbTimKiemKhachHang.Controls.Add(this.rbTimKiemTheoMaKH);
            this.grbTimKiemKhachHang.Controls.Add(this.rbTimKiemTheoDiaChiKH);
            this.grbTimKiemKhachHang.Controls.Add(this.rbTimKiemTheoTenKH);
            this.grbTimKiemKhachHang.Controls.Add(this.rbTimKiemTheoMaHopDong);
            this.grbTimKiemKhachHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.grbTimKiemKhachHang.ForeColor = System.Drawing.Color.Yellow;
            this.grbTimKiemKhachHang.Location = new System.Drawing.Point(5, 13);
            this.grbTimKiemKhachHang.Name = "grbTimKiemKhachHang";
            this.grbTimKiemKhachHang.Size = new System.Drawing.Size(974, 71);
            this.grbTimKiemKhachHang.TabIndex = 2;
            this.grbTimKiemKhachHang.TabStop = false;
            this.grbTimKiemKhachHang.Text = "Tìm kiếm khách hàng";
            // 
            // rbTimKiemTheoMaKH
            // 
            this.rbTimKiemTheoMaKH.AutoSize = true;
            this.rbTimKiemTheoMaKH.Location = new System.Drawing.Point(19, 34);
            this.rbTimKiemTheoMaKH.Name = "rbTimKiemTheoMaKH";
            this.rbTimKiemTheoMaKH.Size = new System.Drawing.Size(173, 21);
            this.rbTimKiemTheoMaKH.TabIndex = 5;
            this.rbTimKiemTheoMaKH.TabStop = true;
            this.rbTimKiemTheoMaKH.Text = "Tìm kiếm theo mã KH";
            this.rbTimKiemTheoMaKH.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemTheoDiaChiKH
            // 
            this.rbTimKiemTheoDiaChiKH.AutoSize = true;
            this.rbTimKiemTheoDiaChiKH.Location = new System.Drawing.Point(484, 34);
            this.rbTimKiemTheoDiaChiKH.Name = "rbTimKiemTheoDiaChiKH";
            this.rbTimKiemTheoDiaChiKH.Size = new System.Drawing.Size(196, 21);
            this.rbTimKiemTheoDiaChiKH.TabIndex = 5;
            this.rbTimKiemTheoDiaChiKH.TabStop = true;
            this.rbTimKiemTheoDiaChiKH.Text = "Tìm kiếm theo địa chỉ KH";
            this.rbTimKiemTheoDiaChiKH.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemTheoTenKH
            // 
            this.rbTimKiemTheoTenKH.AutoSize = true;
            this.rbTimKiemTheoTenKH.Location = new System.Drawing.Point(241, 34);
            this.rbTimKiemTheoTenKH.Name = "rbTimKiemTheoTenKH";
            this.rbTimKiemTheoTenKH.Size = new System.Drawing.Size(175, 21);
            this.rbTimKiemTheoTenKH.TabIndex = 5;
            this.rbTimKiemTheoTenKH.TabStop = true;
            this.rbTimKiemTheoTenKH.Text = "Tìm kiếm theo tên KH";
            this.rbTimKiemTheoTenKH.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemTheoMaHopDong
            // 
            this.rbTimKiemTheoMaHopDong.AutoSize = true;
            this.rbTimKiemTheoMaHopDong.Location = new System.Drawing.Point(739, 34);
            this.rbTimKiemTheoMaHopDong.Name = "rbTimKiemTheoMaHopDong";
            this.rbTimKiemTheoMaHopDong.Size = new System.Drawing.Size(209, 21);
            this.rbTimKiemTheoMaHopDong.TabIndex = 5;
            this.rbTimKiemTheoMaHopDong.TabStop = true;
            this.rbTimKiemTheoMaHopDong.Text = "Tìm kiếm theo mã hợp đồng";
            this.rbTimKiemTheoMaHopDong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTimKiemKH);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(5, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 265);
            this.panel1.TabIndex = 4;
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.Location = new System.Drawing.Point(257, 175);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(381, 20);
            this.txtTimKiemKH.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(745, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 180);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmTimKiemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(980, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbTimKiemKhachHang);
            this.Controls.Add(this.cmdTimKiemKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemKH";
            this.Text = "frmTimKiemHopDong";
            this.Load += new System.EventHandler(this.frmTimKiemKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).EndInit();
            this.grbTimKiemKhachHang.ResumeLayout(false);
            this.grbTimKiemKhachHang.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdTimKiemKH;
        private System.Windows.Forms.DataGridView dgvTimKiemKH;
        private System.Windows.Forms.GroupBox grbTimKiemKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTimKiemTheoMaKH;
        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.RadioButton rbTimKiemTheoTenKH;
        private System.Windows.Forms.RadioButton rbTimKiemTheoMaHopDong;
        private System.Windows.Forms.RadioButton rbTimKiemTheoDiaChiKH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}