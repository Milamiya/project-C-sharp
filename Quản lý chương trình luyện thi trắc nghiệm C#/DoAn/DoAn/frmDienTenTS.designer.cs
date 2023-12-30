namespace Doan
{
    partial class frmDienTenTS
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
            this.tbten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbmathisinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btbatdauthi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbten
            // 
            this.tbten.Location = new System.Drawing.Point(202, 136);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(157, 20);
            this.tbten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và Tên";
            // 
            // tbmathisinh
            // 
            this.tbmathisinh.Location = new System.Drawing.Point(202, 183);
            this.tbmathisinh.Name = "tbmathisinh";
            this.tbmathisinh.Size = new System.Drawing.Size(157, 20);
            this.tbmathisinh.TabIndex = 2;
            this.tbmathisinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmathisinh_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thí sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chúc bạn thi thành công";
            // 
            // btbatdauthi
            // 
            this.btbatdauthi.BackgroundImage = global::Doan.Properties.Resources.bt;
            this.btbatdauthi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbatdauthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbatdauthi.Location = new System.Drawing.Point(192, 242);
            this.btbatdauthi.Name = "btbatdauthi";
            this.btbatdauthi.Size = new System.Drawing.Size(167, 40);
            this.btbatdauthi.TabIndex = 3;
            this.btbatdauthi.Text = "Bắt Đầu Thi";
            this.btbatdauthi.UseVisualStyleBackColor = true;
            this.btbatdauthi.Click += new System.EventHandler(this.btbatdauthi_Click);
            // 
            // frmDienTenTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doan.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 324);
            this.Controls.Add(this.btbatdauthi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbmathisinh);
            this.Controls.Add(this.tbten);
            this.Name = "frmDienTenTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điền thông tin thí sinh";
            this.Load += new System.EventHandler(this.frmDienTenTS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmathisinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btbatdauthi;
    }
}