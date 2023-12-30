namespace QuanLyDaoTao.Presentation
{
    partial class frmThemMonHoc
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
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.numSTC = new DevExpress.XtraEditors.SpinEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.numLyThuyet = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.numThucHanh = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLyThuyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMH.EnterMoveNextControl = true;
            this.txtTenMH.Location = new System.Drawing.Point(249, 83);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTenMH.Properties.Appearance.Options.UseFont = true;
            this.txtTenMH.Properties.Mask.BeepOnError = true;
            this.txtTenMH.Properties.MaxLength = 30;
            this.txtTenMH.Size = new System.Drawing.Size(534, 24);
            this.txtTenMH.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(150, 137);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 18);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Số tín chỉ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(150, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên môn học:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.EnterMoveNextControl = true;
            this.txtMaMH.Location = new System.Drawing.Point(249, 32);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaMH.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaMH.Properties.Appearance.Options.UseFont = true;
            this.txtMaMH.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaMH.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaMH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaMH.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaMH.Properties.MaxLength = 6;
            this.txtMaMH.Size = new System.Drawing.Size(118, 24);
            this.txtMaMH.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(150, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(87, 18);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Mã môn học:";
            // 
            // numSTC
            // 
            this.numSTC.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSTC.EnterMoveNextControl = true;
            this.numSTC.Location = new System.Drawing.Point(249, 134);
            this.numSTC.Name = "numSTC";
            this.numSTC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numSTC.Properties.Appearance.Options.UseFont = true;
            this.numSTC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numSTC.Properties.IsFloatValue = false;
            this.numSTC.Properties.Mask.EditMask = "N00";
            this.numSTC.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numSTC.Properties.MaxValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSTC.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSTC.Size = new System.Drawing.Size(64, 24);
            this.numSTC.TabIndex = 5;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QuanLyDaoTao.Properties.Resources.button_cancel_icon2;
            this.btnHuy.Location = new System.Drawing.Point(402, 180);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 43);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::QuanLyDaoTao.Properties.Resources.Save__1_;
            this.btnLuu.Location = new System.Drawing.Point(244, 180);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 43);
            this.btnLuu.TabIndex = 10;
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
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.sua;
            this.reflectionImage1.Location = new System.Drawing.Point(2, -25);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(142, 263);
            this.reflectionImage1.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(358, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Số tiết lý thuyết:";
            // 
            // numLyThuyet
            // 
            this.numLyThuyet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLyThuyet.EnterMoveNextControl = true;
            this.numLyThuyet.Location = new System.Drawing.Point(472, 134);
            this.numLyThuyet.Name = "numLyThuyet";
            this.numLyThuyet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numLyThuyet.Properties.Appearance.Options.UseFont = true;
            this.numLyThuyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numLyThuyet.Properties.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numLyThuyet.Properties.IsFloatValue = false;
            this.numLyThuyet.Properties.Mask.EditMask = "N00";
            this.numLyThuyet.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numLyThuyet.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numLyThuyet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLyThuyet.Size = new System.Drawing.Size(74, 24);
            this.numLyThuyet.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Location = new System.Drawing.Point(586, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(117, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Số tiết thực hành:";
            // 
            // numThucHanh
            // 
            this.numThucHanh.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThucHanh.EnterMoveNextControl = true;
            this.numThucHanh.Location = new System.Drawing.Point(709, 134);
            this.numThucHanh.Name = "numThucHanh";
            this.numThucHanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numThucHanh.Properties.Appearance.Options.UseFont = true;
            this.numThucHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numThucHanh.Properties.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numThucHanh.Properties.IsFloatValue = false;
            this.numThucHanh.Properties.Mask.EditMask = "N00";
            this.numThucHanh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numThucHanh.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numThucHanh.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThucHanh.Size = new System.Drawing.Size(74, 24);
            this.numThucHanh.TabIndex = 9;
            // 
            // frmThemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 245);
            this.Controls.Add(this.numThucHanh);
            this.Controls.Add(this.numLyThuyet);
            this.Controls.Add(this.numSTC);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmThemMonHoc";
            this.Text = "Môn học mới";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLyThuyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.SpinEdit numSTC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit numLyThuyet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit numThucHanh;
    }
}