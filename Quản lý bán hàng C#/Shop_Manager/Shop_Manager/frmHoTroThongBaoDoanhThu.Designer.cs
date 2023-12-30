namespace Shop_Manager
{
    partial class frmHoTroThongBaoDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoTroThongBaoDoanhThu));
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnXemTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(110, 19);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(59, 26);
            this.txtThang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(110, 60);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(59, 26);
            this.txtNam.TabIndex = 2;
            // 
            // btnXemTB
            // 
            this.btnXemTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTB.Image = ((System.Drawing.Image)(resources.GetObject("btnXemTB.Image")));
            this.btnXemTB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemTB.Location = new System.Drawing.Point(39, 110);
            this.btnXemTB.Name = "btnXemTB";
            this.btnXemTB.Size = new System.Drawing.Size(164, 32);
            this.btnXemTB.TabIndex = 4;
            this.btnXemTB.Text = "Xem thông báo";
            this.btnXemTB.UseVisualStyleBackColor = true;
            this.btnXemTB.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHoTroThongBaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(231, 154);
            this.Controls.Add(this.btnXemTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmHoTroThongBaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo doanh thu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnXemTB;
    }
}