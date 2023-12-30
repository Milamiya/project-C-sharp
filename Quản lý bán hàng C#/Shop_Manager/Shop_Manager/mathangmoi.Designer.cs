namespace Shop_Manager
{
    partial class frmNewMatH
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
            this.lblMaMatH = new System.Windows.Forms.Label();
            this.txtMaMatH = new System.Windows.Forms.TextBox();
            this.txtTenMatH = new System.Windows.Forms.TextBox();
            this.lblTenMatH = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaMatH
            // 
            this.lblMaMatH.AutoSize = true;
            this.lblMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMatH.Location = new System.Drawing.Point(47, 25);
            this.lblMaMatH.Name = "lblMaMatH";
            this.lblMaMatH.Size = new System.Drawing.Size(120, 19);
            this.lblMaMatH.TabIndex = 0;
            this.lblMaMatH.Text = "Mã mặt hàng (*)";
            // 
            // txtMaMatH
            // 
            this.txtMaMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMatH.Location = new System.Drawing.Point(173, 22);
            this.txtMaMatH.Name = "txtMaMatH";
            this.txtMaMatH.Size = new System.Drawing.Size(158, 26);
            this.txtMaMatH.TabIndex = 1;
            // 
            // txtTenMatH
            // 
            this.txtTenMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatH.Location = new System.Drawing.Point(173, 54);
            this.txtTenMatH.Name = "txtTenMatH";
            this.txtTenMatH.Size = new System.Drawing.Size(158, 26);
            this.txtTenMatH.TabIndex = 3;
            // 
            // lblTenMatH
            // 
            this.lblTenMatH.AutoSize = true;
            this.lblTenMatH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMatH.Location = new System.Drawing.Point(47, 57);
            this.lblTenMatH.Name = "lblTenMatH";
            this.lblTenMatH.Size = new System.Drawing.Size(122, 19);
            this.lblTenMatH.TabIndex = 2;
            this.lblTenMatH.Text = "Tên mặt hàng (*)";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(173, 86);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(158, 26);
            this.txtSoLuong.TabIndex = 5;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(47, 89);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(91, 19);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng (*)";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(173, 118);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(158, 26);
            this.txtDonGia.TabIndex = 7;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(47, 121);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(84, 19);
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Đơn giá (*)";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(194, 162);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 34);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNewMatH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 226);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtTenMatH);
            this.Controls.Add(this.lblTenMatH);
            this.Controls.Add(this.txtMaMatH);
            this.Controls.Add(this.lblMaMatH);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmNewMatH";
            this.Text = "Thêm măt hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMatH;
        private System.Windows.Forms.TextBox txtMaMatH;
        private System.Windows.Forms.TextBox txtTenMatH;
        private System.Windows.Forms.Label lblTenMatH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Button btnThem;

    }
}