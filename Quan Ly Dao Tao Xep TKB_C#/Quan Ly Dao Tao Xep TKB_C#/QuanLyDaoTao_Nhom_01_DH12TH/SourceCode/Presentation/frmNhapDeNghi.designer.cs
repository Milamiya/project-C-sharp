namespace QuanLyDaoTao.Presentation
{
    partial class frmNhapDeNghi
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
            this.numTietBatDau = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.numSoTiet = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPhanCong = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.numTietBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhanCong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // numTietBatDau
            // 
            this.numTietBatDau.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTietBatDau.EnterMoveNextControl = true;
            this.numTietBatDau.Location = new System.Drawing.Point(104, 8);
            this.numTietBatDau.Name = "numTietBatDau";
            this.numTietBatDau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numTietBatDau.Properties.Appearance.Options.UseFont = true;
            this.numTietBatDau.Properties.Appearance.Options.UseTextOptions = true;
            this.numTietBatDau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numTietBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numTietBatDau.Properties.IsFloatValue = false;
            this.numTietBatDau.Properties.Mask.EditMask = "N00";
            this.numTietBatDau.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numTietBatDau.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTietBatDau.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTietBatDau.Size = new System.Drawing.Size(57, 24);
            this.numTietBatDau.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tiết bắt đầu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(193, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Số tiết:";
            // 
            // numSoTiet
            // 
            this.numSoTiet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTiet.EnterMoveNextControl = true;
            this.numSoTiet.Location = new System.Drawing.Point(245, 8);
            this.numSoTiet.Name = "numSoTiet";
            this.numSoTiet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numSoTiet.Properties.Appearance.Options.UseFont = true;
            this.numSoTiet.Properties.Appearance.Options.UseTextOptions = true;
            this.numSoTiet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numSoTiet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numSoTiet.Properties.IsFloatValue = false;
            this.numSoTiet.Properties.Mask.EditMask = "N00";
            this.numSoTiet.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numSoTiet.Properties.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSoTiet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTiet.Size = new System.Drawing.Size(57, 24);
            this.numSoTiet.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Location = new System.Drawing.Point(12, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Phân công:";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QuanLyDaoTao.Properties.Resources.button_cancel_icon2;
            this.btnHuy.Location = new System.Drawing.Point(193, 72);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 36);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Image = global::QuanLyDaoTao.Properties.Resources.button_ok1;
            this.btnOk.Location = new System.Drawing.Point(104, 72);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(73, 36);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Lưu";
            this.btnOk.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmbPhanCong
            // 
            this.cmbPhanCong.Location = new System.Drawing.Point(104, 41);
            this.cmbPhanCong.Name = "cmbPhanCong";
            this.cmbPhanCong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbPhanCong.Properties.Appearance.Options.UseFont = true;
            this.cmbPhanCong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPhanCong.Properties.DisplayMember = "TenMH";
            this.cmbPhanCong.Properties.ValueMember = "MaPC";
            this.cmbPhanCong.Size = new System.Drawing.Size(198, 24);
            this.cmbPhanCong.TabIndex = 12;
            // 
            // frmNhapDeNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 116);
            this.ControlBox = false;
            this.Controls.Add(this.cmbPhanCong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numSoTiet);
            this.Controls.Add(this.numTietBatDau);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.MaximumSize = new System.Drawing.Size(330, 154);
            this.MinimumSize = new System.Drawing.Size(330, 154);
            this.Name = "frmNhapDeNghi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đề nghị";
            this.Load += new System.EventHandler(this.frmNhapDeNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTietBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhanCong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        public DevExpress.XtraEditors.SpinEdit numTietBatDau;
        public DevExpress.XtraEditors.SpinEdit numSoTiet;
        private DevExpress.XtraEditors.LookUpEdit cmbPhanCong;
    }
}