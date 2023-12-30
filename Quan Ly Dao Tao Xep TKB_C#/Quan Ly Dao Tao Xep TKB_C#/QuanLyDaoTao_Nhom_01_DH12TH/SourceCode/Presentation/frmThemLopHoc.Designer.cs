namespace QuanLyDaoTao.Presentation
{
    partial class frmThemLopHoc
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
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.cmbNganh = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rdgBacHoc = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateBatDau = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateKetThuc = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBacHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QuanLyDaoTao.Properties.Resources.button_cancel_icon2;
            this.btnHuy.Location = new System.Drawing.Point(381, 144);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 43);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::QuanLyDaoTao.Properties.Resources.Save__1_;
            this.btnLuu.Location = new System.Drawing.Point(223, 144);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 43);
            this.btnLuu.TabIndex = 9;
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
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.lop_hoc_128;
            this.reflectionImage1.Location = new System.Drawing.Point(12, -24);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(142, 263);
            this.reflectionImage1.TabIndex = 12;
            // 
            // txtMaLop
            // 
            this.txtMaLop.EnterMoveNextControl = true;
            this.txtMaLop.Location = new System.Drawing.Point(223, 35);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtMaLop.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaLop.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMaLop.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMaLop.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaLop.Properties.MaxLength = 5;
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(123, 24);
            this.txtMaLop.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblHoTen.Location = new System.Drawing.Point(160, 38);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(48, 18);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Mã lớp:";
            // 
            // cmbNganh
            // 
            this.cmbNganh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNganh.EnterMoveNextControl = true;
            this.cmbNganh.Location = new System.Drawing.Point(490, 35);
            this.cmbNganh.Name = "cmbNganh";
            this.cmbNganh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbNganh.Properties.Appearance.Options.UseFont = true;
            this.cmbNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNganh.Properties.DisplayMember = "TenNganh";
            this.cmbNganh.Properties.ValueMember = "MaNganh";
            this.cmbNganh.Size = new System.Drawing.Size(197, 24);
            this.cmbNganh.TabIndex = 3;
            this.cmbNganh.EditValueChanged += new System.EventHandler(this.cmbNganh_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(437, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngành:";
            // 
            // rdgBacHoc
            // 
            this.rdgBacHoc.Location = new System.Drawing.Point(223, 84);
            this.rdgBacHoc.Name = "rdgBacHoc";
            this.rdgBacHoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.rdgBacHoc.Properties.Appearance.Options.UseFont = true;
            this.rdgBacHoc.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Đại học"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cao đẳng")});
            this.rdgBacHoc.Size = new System.Drawing.Size(173, 30);
            this.rdgBacHoc.TabIndex = 5;
            this.rdgBacHoc.SelectedIndexChanged += new System.EventHandler(this.rdgBacHoc_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Location = new System.Drawing.Point(160, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Bậc học:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(437, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Niên khóa:";
            // 
            // dateBatDau
            // 
            this.dateBatDau.EditValue = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateBatDau.EnterMoveNextControl = true;
            this.dateBatDau.Location = new System.Drawing.Point(512, 87);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateBatDau.Properties.Appearance.Options.UseFont = true;
            this.dateBatDau.Properties.Appearance.Options.UseTextOptions = true;
            this.dateBatDau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Properties.DisplayFormat.FormatString = "yyyy";
            this.dateBatDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateBatDau.Properties.EditFormat.FormatString = "yyyy";
            this.dateBatDau.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateBatDau.Properties.Mask.EditMask = "yyyy";
            this.dateBatDau.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateBatDau.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateBatDau.Size = new System.Drawing.Size(77, 24);
            this.dateBatDau.TabIndex = 7;
            this.dateBatDau.EditValueChanged += new System.EventHandler(this.dateBatDau_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(595, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(9, 24);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "-";
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.EditValue = null;
            this.dateKetThuc.EnterMoveNextControl = true;
            this.dateKetThuc.Location = new System.Drawing.Point(610, 87);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateKetThuc.Properties.Appearance.Options.UseFont = true;
            this.dateKetThuc.Properties.Appearance.Options.UseTextOptions = true;
            this.dateKetThuc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.DisplayFormat.FormatString = "yyyy";
            this.dateKetThuc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateKetThuc.Properties.EditFormat.FormatString = "yyyy";
            this.dateKetThuc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateKetThuc.Properties.Mask.EditMask = "yyyy";
            this.dateKetThuc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateKetThuc.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateKetThuc.Size = new System.Drawing.Size(77, 24);
            this.dateKetThuc.TabIndex = 8;
            // 
            // frmThemLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 210);
            this.Controls.Add(this.dateKetThuc);
            this.Controls.Add(this.dateBatDau);
            this.Controls.Add(this.rdgBacHoc);
            this.Controls.Add(this.cmbNganh);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmThemLopHoc";
            this.Text = "Thêm lớp học mới";
            this.Load += new System.EventHandler(this.frmThemLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgBacHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LookUpEdit cmbNganh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rdgBacHoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateKetThuc;
    }
}