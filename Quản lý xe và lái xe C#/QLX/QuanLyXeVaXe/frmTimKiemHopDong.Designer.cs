namespace QuanLyXeVaXe
{
    partial class frmTimKiemHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemHopDong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdTimKiemHopDong = new System.Windows.Forms.Button();
            this.tbTKHD = new System.Windows.Forms.Label();
            this.rbTimKiemTheoMaHD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTimKiemTheoTenHD = new System.Windows.Forms.RadioButton();
            this.rbTimKiemHDTheoMaLX = new System.Windows.Forms.RadioButton();
            this.rbTimKiemHDTheoMaKH = new System.Windows.Forms.RadioButton();
            this.txtTimKiemHopDong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTimKiemHopDong = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdTimKiemHopDong
            // 
            this.cmdTimKiemHopDong.BackColor = System.Drawing.Color.White;
            this.cmdTimKiemHopDong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdTimKiemHopDong.BackgroundImage")));
            this.cmdTimKiemHopDong.ForeColor = System.Drawing.Color.Gray;
            this.cmdTimKiemHopDong.Location = new System.Drawing.Point(628, 139);
            this.cmdTimKiemHopDong.Name = "cmdTimKiemHopDong";
            this.cmdTimKiemHopDong.Size = new System.Drawing.Size(70, 70);
            this.cmdTimKiemHopDong.TabIndex = 0;
            this.cmdTimKiemHopDong.UseVisualStyleBackColor = false;
            this.cmdTimKiemHopDong.Click += new System.EventHandler(this.cmdTimKiemHopDong_Click);
            // 
            // tbTKHD
            // 
            this.tbTKHD.AutoSize = true;
            this.tbTKHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTKHD.ForeColor = System.Drawing.Color.White;
            this.tbTKHD.Location = new System.Drawing.Point(344, 144);
            this.tbTKHD.Name = "tbTKHD";
            this.tbTKHD.Size = new System.Drawing.Size(192, 17);
            this.tbTKHD.TabIndex = 1;
            this.tbTKHD.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // rbTimKiemTheoMaHD
            // 
            this.rbTimKiemTheoMaHD.AutoSize = true;
            this.rbTimKiemTheoMaHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbTimKiemTheoMaHD.Location = new System.Drawing.Point(34, 28);
            this.rbTimKiemTheoMaHD.Name = "rbTimKiemTheoMaHD";
            this.rbTimKiemTheoMaHD.Size = new System.Drawing.Size(131, 21);
            this.rbTimKiemTheoMaHD.TabIndex = 2;
            this.rbTimKiemTheoMaHD.TabStop = true;
            this.rbTimKiemTheoMaHD.Text = "TK theo mã HĐ";
            this.rbTimKiemTheoMaHD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTimKiemTheoTenHD);
            this.groupBox1.Controls.Add(this.rbTimKiemHDTheoMaLX);
            this.groupBox1.Controls.Add(this.rbTimKiemHDTheoMaKH);
            this.groupBox1.Controls.Add(this.rbTimKiemTheoMaHD);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm hợp đồng";
            // 
            // rbTimKiemTheoTenHD
            // 
            this.rbTimKiemTheoTenHD.AutoSize = true;
            this.rbTimKiemTheoTenHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbTimKiemTheoTenHD.Location = new System.Drawing.Point(254, 28);
            this.rbTimKiemTheoTenHD.Name = "rbTimKiemTheoTenHD";
            this.rbTimKiemTheoTenHD.Size = new System.Drawing.Size(133, 21);
            this.rbTimKiemTheoTenHD.TabIndex = 2;
            this.rbTimKiemTheoTenHD.TabStop = true;
            this.rbTimKiemTheoTenHD.Text = "TK theo tên HĐ";
            this.rbTimKiemTheoTenHD.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemHDTheoMaLX
            // 
            this.rbTimKiemHDTheoMaLX.AutoSize = true;
            this.rbTimKiemHDTheoMaLX.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbTimKiemHDTheoMaLX.Location = new System.Drawing.Point(493, 28);
            this.rbTimKiemHDTheoMaLX.Name = "rbTimKiemHDTheoMaLX";
            this.rbTimKiemHDTheoMaLX.Size = new System.Drawing.Size(158, 21);
            this.rbTimKiemHDTheoMaLX.TabIndex = 2;
            this.rbTimKiemHDTheoMaLX.TabStop = true;
            this.rbTimKiemHDTheoMaLX.Text = "TK HĐ theo Mã LX";
            this.rbTimKiemHDTheoMaLX.UseVisualStyleBackColor = true;
            // 
            // rbTimKiemHDTheoMaKH
            // 
            this.rbTimKiemHDTheoMaKH.AutoSize = true;
            this.rbTimKiemHDTheoMaKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbTimKiemHDTheoMaKH.Location = new System.Drawing.Point(768, 28);
            this.rbTimKiemHDTheoMaKH.Name = "rbTimKiemHDTheoMaKH";
            this.rbTimKiemHDTheoMaKH.Size = new System.Drawing.Size(159, 21);
            this.rbTimKiemHDTheoMaKH.TabIndex = 2;
            this.rbTimKiemHDTheoMaKH.TabStop = true;
            this.rbTimKiemHDTheoMaKH.Text = "TK HĐ theo mã KH";
            this.rbTimKiemHDTheoMaKH.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemHopDong
            // 
            this.txtTimKiemHopDong.Location = new System.Drawing.Point(257, 182);
            this.txtTimKiemHopDong.Name = "txtTimKiemHopDong";
            this.txtTimKiemHopDong.Size = new System.Drawing.Size(365, 20);
            this.txtTimKiemHopDong.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTimKiemHopDong);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 256);
            this.panel1.TabIndex = 5;
            // 
            // dgvTimKiemHopDong
            // 
            this.dgvTimKiemHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimKiemHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKiemHopDong.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimKiemHopDong.Location = new System.Drawing.Point(3, 4);
            this.dgvTimKiemHopDong.Name = "dgvTimKiemHopDong";
            this.dgvTimKiemHopDong.Size = new System.Drawing.Size(968, 302);
            this.dgvTimKiemHopDong.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(771, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 180);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frmTimKiemHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(980, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiemHopDong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTKHD);
            this.Controls.Add(this.cmdTimKiemHopDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemHopDong";
            this.Text = "frmTimKiemHopDong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdTimKiemHopDong;
        private System.Windows.Forms.Label tbTKHD;
        private System.Windows.Forms.RadioButton rbTimKiemTheoMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTimKiemTheoTenHD;
        private System.Windows.Forms.RadioButton rbTimKiemHDTheoMaLX;
        private System.Windows.Forms.RadioButton rbTimKiemHDTheoMaKH;
        private System.Windows.Forms.TextBox txtTimKiemHopDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTimKiemHopDong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}