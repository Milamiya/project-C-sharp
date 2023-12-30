namespace QuanLyDaoTao.Presentation
{
    partial class frmThemPhongHoc
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
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtChucNang = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lblMSSV = new DevExpress.XtraEditors.LabelControl();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.numSucChua = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucNang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSucChua.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.EnterMoveNextControl = true;
            this.txtDiaChi.Location = new System.Drawing.Point(262, 96);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.Mask.BeepOnError = true;
            this.txtDiaChi.Properties.MaxLength = 50;
            this.txtDiaChi.Size = new System.Drawing.Size(515, 24);
            this.txtDiaChi.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(181, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 18);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Địa chỉ:";
            // 
            // txtChucNang
            // 
            this.txtChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChucNang.EnterMoveNextControl = true;
            this.txtChucNang.Location = new System.Drawing.Point(262, 58);
            this.txtChucNang.Name = "txtChucNang";
            this.txtChucNang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtChucNang.Properties.Appearance.Options.UseFont = true;
            this.txtChucNang.Properties.MaxLength = 50;
            this.txtChucNang.Size = new System.Drawing.Size(515, 24);
            this.txtChucNang.TabIndex = 5;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.EnterMoveNextControl = true;
            this.txtMaPhong.Location = new System.Drawing.Point(262, 20);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaPhong.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaPhong.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhong.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaPhong.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaPhong.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaPhong.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMaPhong.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaPhong.Properties.MaxLength = 6;
            this.txtMaPhong.Size = new System.Drawing.Size(122, 24);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(181, 61);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 18);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Chức năng:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMSSV.Location = new System.Drawing.Point(181, 23);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(70, 18);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã phòng:";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.phong_hoc128;
            this.reflectionImage1.Location = new System.Drawing.Point(-4, -25);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(142, 263);
            this.reflectionImage1.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QuanLyDaoTao.Properties.Resources.button_cancel_icon2;
            this.btnHuy.Location = new System.Drawing.Point(420, 137);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 43);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::QuanLyDaoTao.Properties.Resources.Save__1_;
            this.btnLuu.Location = new System.Drawing.Point(262, 137);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 43);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // numSucChua
            // 
            this.numSucChua.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSucChua.EnterMoveNextControl = true;
            this.numSucChua.Location = new System.Drawing.Point(501, 20);
            this.numSucChua.Name = "numSucChua";
            this.numSucChua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numSucChua.Properties.Appearance.Options.UseFont = true;
            this.numSucChua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numSucChua.Properties.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSucChua.Properties.IsFloatValue = false;
            this.numSucChua.Properties.Mask.EditMask = "N00";
            this.numSucChua.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numSucChua.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSucChua.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSucChua.Size = new System.Drawing.Size(126, 24);
            this.numSucChua.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(424, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Sức chứa:";
            // 
            // frmThemPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.numSucChua);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtChucNang);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSSV);
            this.Name = "frmThemPhongHoc";
            this.Text = "frmThemPhongHoc";
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucNang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSucChua.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtChucNang;
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LabelControl lblMSSV;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SpinEdit numSucChua;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}