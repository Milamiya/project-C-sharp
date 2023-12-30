namespace GiaoDienCuaHang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxU = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.buttonDN = new System.Windows.Forms.Button();
            this.buttonHB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(121, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.Blue;
            this.labelusername.Location = new System.Drawing.Point(150, 87);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(74, 16);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "Username:";
            this.labelusername.Click += new System.EventHandler(this.labelusername_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(150, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // textBoxU
            // 
            this.textBoxU.Location = new System.Drawing.Point(231, 86);
            this.textBoxU.Name = "textBoxU";
            this.textBoxU.Size = new System.Drawing.Size(126, 20);
            this.textBoxU.TabIndex = 4;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(231, 128);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(115, 20);
            this.textBoxP.TabIndex = 5;
            this.textBoxP.UseSystemPasswordChar = true;
            // 
            // buttonDN
            // 
            this.buttonDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonDN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDN.Location = new System.Drawing.Point(153, 180);
            this.buttonDN.Name = "buttonDN";
            this.buttonDN.Size = new System.Drawing.Size(96, 32);
            this.buttonDN.TabIndex = 6;
            this.buttonDN.Text = "Đăng Nhập";
            this.buttonDN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDN.UseVisualStyleBackColor = true;
            this.buttonDN.Click += new System.EventHandler(this.buttonDN_Click);
            // 
            // buttonHB
            // 
            this.buttonHB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonHB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonHB.Location = new System.Drawing.Point(267, 180);
            this.buttonHB.Name = "buttonHB";
            this.buttonHB.Size = new System.Drawing.Size(92, 32);
            this.buttonHB.TabIndex = 7;
            this.buttonHB.Text = "Hủy Bỏ";
            this.buttonHB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHB.UseVisualStyleBackColor = true;
            this.buttonHB.Click += new System.EventHandler(this.buttonHB_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.buttonDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonHB;
            this.ClientSize = new System.Drawing.Size(371, 236);
            this.Controls.Add(this.buttonHB);
            this.Controls.Add(this.buttonDN);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDN;
        private System.Windows.Forms.Button buttonHB;
        public System.Windows.Forms.TextBox textBoxU;
        public System.Windows.Forms.TextBox textBoxP;
    }
}