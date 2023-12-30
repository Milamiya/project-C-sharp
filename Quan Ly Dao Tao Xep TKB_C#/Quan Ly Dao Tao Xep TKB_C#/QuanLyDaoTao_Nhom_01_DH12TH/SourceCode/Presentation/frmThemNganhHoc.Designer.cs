namespace QuanLyDaoTao.Presentation
{
    partial class frmThemNganhHoc
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
            this.txtTenNganh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNganh = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKhoa = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNganh.EnterMoveNextControl = true;
            this.txtTenNganh.Location = new System.Drawing.Point(242, 76);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenNganh.Properties.Appearance.Options.UseFont = true;
            this.txtTenNganh.Properties.Mask.BeepOnError = true;
            this.txtTenNganh.Properties.MaxLength = 30;
            this.txtTenNganh.Size = new System.Drawing.Size(387, 24);
            this.txtTenNganh.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(148, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên ngành:";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.EnterMoveNextControl = true;
            this.txtMaNganh.Location = new System.Drawing.Point(242, 25);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaNganh.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaNganh.Properties.Appearance.Options.UseFont = true;
            this.txtMaNganh.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaNganh.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaNganh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaNganh.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaNganh.Properties.MaxLength = 5;
            this.txtMaNganh.Size = new System.Drawing.Size(123, 24);
            this.txtMaNganh.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(148, 28);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(70, 18);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Mã ngành:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(148, 130);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Khoa:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhoa.EnterMoveNextControl = true;
            this.txtKhoa.Location = new System.Drawing.Point(242, 127);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtKhoa.Properties.Mask.BeepOnError = true;
            this.txtKhoa.Properties.MaxLength = 30;
            this.txtKhoa.Size = new System.Drawing.Size(387, 24);
            this.txtKhoa.TabIndex = 6;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QuanLyDaoTao.Properties.Resources.button_cancel_icon2;
            this.btnHuy.Location = new System.Drawing.Point(400, 173);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 43);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::QuanLyDaoTao.Properties.Resources.Save__1_;
            this.btnLuu.Location = new System.Drawing.Point(242, 173);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 43);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.non_128;
            this.reflectionImage1.Location = new System.Drawing.Point(0, -9);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(142, 263);
            this.reflectionImage1.TabIndex = 0;
            // 
            // frmThemNganhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 241);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtTenNganh);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaNganh);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmThemNganhHoc";
            this.Text = "Ngành học mới";
            this.Load += new System.EventHandler(this.frmThemNganhHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTenNganh;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaNganh;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKhoa;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}