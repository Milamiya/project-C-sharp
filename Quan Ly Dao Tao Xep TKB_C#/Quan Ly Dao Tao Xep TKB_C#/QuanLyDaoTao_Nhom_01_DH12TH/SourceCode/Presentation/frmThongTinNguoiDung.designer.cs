namespace QuanLyDaoTao.Presentation
{
    partial class frmThongTinNguoiDung
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
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblQuyen = new DevExpress.XtraEditors.LabelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.info72;
            this.reflectionImage1.Location = new System.Drawing.Point(12, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(78, 112);
            this.reflectionImage1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = global::QuanLyDaoTao.Properties.Resources.button_cancel_icon2;
            this.simpleButton1.Location = new System.Drawing.Point(239, 68);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 34);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Đóng";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblQuyen
            // 
            this.lblQuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblQuyen.Location = new System.Drawing.Point(179, 12);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(48, 18);
            this.lblQuyen.TabIndex = 2;
            this.lblQuyen.Text = "Quyền:";
            // 
            // lblTen
            // 
            this.lblTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTen.Location = new System.Drawing.Point(116, 39);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 18);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            // 
            // frmThongTinNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 114);
            this.ControlBox = false;
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.reflectionImage1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 178);
            this.MinimizeBox = false;
            this.Name = "frmThongTinNguoiDung";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin của bạn";
            this.Load += new System.EventHandler(this.frmThongTinNguoiDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblQuyen;
        private DevExpress.XtraEditors.LabelControl lblTen;

    }
}