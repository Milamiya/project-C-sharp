namespace QuanLyBanHangDienTu.Presentation
{
    partial class fr_Ketnoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdb = new System.Windows.Forms.TextBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.cmddn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 51);
            this.panel1.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "KẾT NỐI SERVER";
            // 
            // txtdb
            // 
            this.txtdb.Enabled = false;
            this.txtdb.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdb.Location = new System.Drawing.Point(135, 97);
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(214, 27);
            this.txtdb.TabIndex = 75;
            this.txtdb.Text = "QL_BanHangDienTu";
            // 
            // txtserver
            // 
            this.txtserver.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserver.Location = new System.Drawing.Point(135, 58);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(214, 27);
            this.txtserver.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Tên CSDL";
            // 
            // cmdthoat
            // 
            this.cmdthoat.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthoat.Location = new System.Drawing.Point(204, 145);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(125, 37);
            this.cmdthoat.TabIndex = 78;
            this.cmdthoat.Text = "Exit";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click);
            // 
            // cmddn
            // 
            this.cmddn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmddn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmddn.Location = new System.Drawing.Point(23, 145);
            this.cmddn.Name = "cmddn";
            this.cmddn.Size = new System.Drawing.Size(125, 37);
            this.cmddn.TabIndex = 79;
            this.cmddn.Text = "OK";
            this.cmddn.UseVisualStyleBackColor = true;
            this.cmddn.Click += new System.EventHandler(this.cmddn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tên Server";
            // 
            // fr_Ketnoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 194);
            this.Controls.Add(this.txtdb);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdthoat);
            this.Controls.Add(this.cmddn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "fr_Ketnoi";
            this.Text = "fr_Ketnoi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdb;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.Button cmddn;
        private System.Windows.Forms.Label label2;
    }
}