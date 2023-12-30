namespace QuanLyXeVaXe
{
    partial class frmTraXeTraTien
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
            this.rbKhongLaiXe = new System.Windows.Forms.RadioButton();
            this.rbCoLaiXe = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rbKhongLaiXe
            // 
            this.rbKhongLaiXe.AutoSize = true;
            this.rbKhongLaiXe.Location = new System.Drawing.Point(392, 12);
            this.rbKhongLaiXe.Name = "rbKhongLaiXe";
            this.rbKhongLaiXe.Size = new System.Drawing.Size(115, 17);
            this.rbKhongLaiXe.TabIndex = 0;
            this.rbKhongLaiXe.TabStop = true;
            this.rbKhongLaiXe.Text = "Trả xe không lái xe";
            this.rbKhongLaiXe.UseVisualStyleBackColor = true;
            this.rbKhongLaiXe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbCoLaiXe
            // 
            this.rbCoLaiXe.AutoSize = true;
            this.rbCoLaiXe.Location = new System.Drawing.Point(276, 12);
            this.rbCoLaiXe.Name = "rbCoLaiXe";
            this.rbCoLaiXe.Size = new System.Drawing.Size(97, 17);
            this.rbCoLaiXe.TabIndex = 0;
            this.rbCoLaiXe.TabStop = true;
            this.rbCoLaiXe.Text = "Trả xe có lái xe";
            this.rbCoLaiXe.UseVisualStyleBackColor = true;
            this.rbCoLaiXe.CheckedChanged += new System.EventHandler(this.rbCoLaiXe_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 553);
            this.panel1.TabIndex = 1;
            // 
            // frmTraXeTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbCoLaiXe);
            this.Controls.Add(this.rbKhongLaiXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTraXeTraTien";
            this.Text = "frmTraXeTraTien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKhongLaiXe;
        private System.Windows.Forms.RadioButton rbCoLaiXe;
        private System.Windows.Forms.Panel panel1;
    }
}