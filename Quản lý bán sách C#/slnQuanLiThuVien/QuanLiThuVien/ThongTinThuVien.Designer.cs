namespace QuanLiThuVien
{
    partial class frmThongTinThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinThuVien));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtThongTinThuVien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(963, 489);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(130, 54);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtThongTinThuVien
            // 
            this.txtThongTinThuVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThongTinThuVien.Location = new System.Drawing.Point(0, 0);
            this.txtThongTinThuVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThongTinThuVien.Multiline = true;
            this.txtThongTinThuVien.Name = "txtThongTinThuVien";
            this.txtThongTinThuVien.ReadOnly = true;
            this.txtThongTinThuVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtThongTinThuVien.Size = new System.Drawing.Size(1182, 446);
            this.txtThongTinThuVien.TabIndex = 0;
            this.txtThongTinThuVien.Text = resources.GetString("txtThongTinThuVien.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtThongTinThuVien);
            this.panel1.Location = new System.Drawing.Point(4, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 446);
            this.panel1.TabIndex = 3;
            // 
            // frmThongTinThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThongTinThuVien";
            this.Text = "ThongTinThuVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtThongTinThuVien;
        private System.Windows.Forms.Panel panel1;
    }
}