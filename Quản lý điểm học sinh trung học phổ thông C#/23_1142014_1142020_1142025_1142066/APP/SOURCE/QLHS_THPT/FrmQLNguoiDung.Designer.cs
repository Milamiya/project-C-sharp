namespace QLHS
{
    partial class FrmQLNguoiDung
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditNguoiDung = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdittenTruyCap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.radioGroupTrangThai = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditQuyenSuDung = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonDong = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGhi = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gridViewNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaND_TenND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiND = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditNguoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdittenTruyCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditQuyenSuDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Người dùng:";
            // 
            // comboBoxEditNguoiDung
            // 
            this.comboBoxEditNguoiDung.EditValue = "";
            this.comboBoxEditNguoiDung.Enabled = false;
            this.comboBoxEditNguoiDung.Location = new System.Drawing.Point(22, 33);
            this.comboBoxEditNguoiDung.Name = "comboBoxEditNguoiDung";
            this.comboBoxEditNguoiDung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditNguoiDung.Size = new System.Drawing.Size(195, 20);
            this.comboBoxEditNguoiDung.TabIndex = 1;
            // 
            // textEdittenTruyCap
            // 
            this.textEdittenTruyCap.Location = new System.Drawing.Point(22, 78);
            this.textEdittenTruyCap.Name = "textEdittenTruyCap";
            this.textEdittenTruyCap.Size = new System.Drawing.Size(195, 20);
            this.textEdittenTruyCap.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên truy cập:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(240, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Mật khẩu:";
            // 
            // textEditMatKhau
            // 
            this.textEditMatKhau.Location = new System.Drawing.Point(240, 78);
            this.textEditMatKhau.Name = "textEditMatKhau";
            this.textEditMatKhau.Size = new System.Drawing.Size(167, 20);
            this.textEditMatKhau.TabIndex = 3;
            // 
            // radioGroupTrangThai
            // 
            this.radioGroupTrangThai.EditValue = true;
            this.radioGroupTrangThai.Location = new System.Drawing.Point(430, 73);
            this.radioGroupTrangThai.Name = "radioGroupTrangThai";
            this.radioGroupTrangThai.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Không được phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Được phép")});
            this.radioGroupTrangThai.Size = new System.Drawing.Size(223, 29);
            this.radioGroupTrangThai.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(430, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Trạng thái sử dụng:";
            // 
            // comboBoxEditQuyenSuDung
            // 
            this.comboBoxEditQuyenSuDung.Location = new System.Drawing.Point(430, 26);
            this.comboBoxEditQuyenSuDung.Name = "comboBoxEditQuyenSuDung";
            this.comboBoxEditQuyenSuDung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditQuyenSuDung.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditQuyenSuDung.Size = new System.Drawing.Size(169, 20);
            this.comboBoxEditQuyenSuDung.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(430, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Quyền sử dụng chương trình";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonDong);
            this.panelControl1.Controls.Add(this.simpleButtonXoa);
            this.panelControl1.Controls.Add(this.simpleButtonGhi);
            this.panelControl1.Controls.Add(this.simpleButtonThemMoi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 353);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(665, 67);
            this.panelControl1.TabIndex = 21;
            // 
            // simpleButtonDong
            // 
            this.simpleButtonDong.Image = global::QLHS.Properties.Resources.thoat_small;
            this.simpleButtonDong.Location = new System.Drawing.Point(491, 16);
            this.simpleButtonDong.Name = "simpleButtonDong";
            this.simpleButtonDong.Size = new System.Drawing.Size(123, 35);
            this.simpleButtonDong.TabIndex = 10;
            this.simpleButtonDong.Text = "Đóng (Alt+&X)";
            this.simpleButtonDong.Click += new System.EventHandler(this.simpleButtonDong_Click);
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Image = global::QLHS.Properties.Resources.xoa_small;
            this.simpleButtonXoa.Location = new System.Drawing.Point(345, 16);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(122, 35);
            this.simpleButtonXoa.TabIndex = 9;
            this.simpleButtonXoa.Text = "Xóa (Alt+&D)";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoa_Click);
            // 
            // simpleButtonGhi
            // 
            this.simpleButtonGhi.Image = global::QLHS.Properties.Resources.them_small;
            this.simpleButtonGhi.Location = new System.Drawing.Point(202, 16);
            this.simpleButtonGhi.Name = "simpleButtonGhi";
            this.simpleButtonGhi.Size = new System.Drawing.Size(124, 35);
            this.simpleButtonGhi.TabIndex = 8;
            this.simpleButtonGhi.Text = "Lưu (Enter)";
            this.simpleButtonGhi.Click += new System.EventHandler(this.simpleButtonGhi_Click);
            // 
            // simpleButtonThemMoi
            // 
            this.simpleButtonThemMoi.Image = global::QLHS.Properties.Resources.them;
            this.simpleButtonThemMoi.Location = new System.Drawing.Point(56, 16);
            this.simpleButtonThemMoi.Name = "simpleButtonThemMoi";
            this.simpleButtonThemMoi.Size = new System.Drawing.Size(122, 35);
            this.simpleButtonThemMoi.TabIndex = 7;
            this.simpleButtonThemMoi.Text = "Thêm mới (Alt+&N)";
            this.simpleButtonThemMoi.Click += new System.EventHandler(this.simpleButtonThemMoi_Click);
            // 
            // gridControlNguoiDung
            // 
            this.gridControlNguoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlNguoiDung.Location = new System.Drawing.Point(0, 108);
            this.gridControlNguoiDung.MainView = this.gridViewNguoiDung;
            this.gridControlNguoiDung.Name = "gridControlNguoiDung";
            this.gridControlNguoiDung.Size = new System.Drawing.Size(665, 245);
            this.gridControlNguoiDung.TabIndex = 6;
            this.gridControlNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNguoiDung});
            // 
            // gridViewNguoiDung
            // 
            this.gridViewNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaND,
            this.colTenDNhap,
            this.colMaND_TenND,
            this.colMaLoai,
            this.colTrangThai,
            this.colMaLoaiND});
            this.gridViewNguoiDung.GridControl = this.gridControlNguoiDung;
            this.gridViewNguoiDung.Name = "gridViewNguoiDung";
            this.gridViewNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gridViewNguoiDung.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNguoiDung_FocusedRowChanged);
            // 
            // colMaND
            // 
            this.colMaND.AppearanceCell.Options.UseTextOptions = true;
            this.colMaND.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaND.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaND.Caption = "Mã người dùng";
            this.colMaND.FieldName = "MaND";
            this.colMaND.Name = "colMaND";
            this.colMaND.OptionsColumn.AllowEdit = false;
            this.colMaND.OptionsColumn.AllowFocus = false;
            this.colMaND.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colMaND.OptionsColumn.AllowIncrementalSearch = false;
            this.colMaND.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colMaND.OptionsColumn.AllowMove = false;
            this.colMaND.OptionsColumn.AllowShowHide = false;
            this.colMaND.OptionsColumn.AllowSize = false;
            this.colMaND.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colMaND.OptionsColumn.FixedWidth = true;
            this.colMaND.OptionsColumn.ReadOnly = true;
            this.colMaND.OptionsFilter.AllowAutoFilter = false;
            this.colMaND.OptionsFilter.AllowFilter = false;
            this.colMaND.Visible = true;
            this.colMaND.VisibleIndex = 0;
            this.colMaND.Width = 79;
            // 
            // colTenDNhap
            // 
            this.colTenDNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDNhap.Caption = "Tên đăng nhập";
            this.colTenDNhap.FieldName = "TenDNhap";
            this.colTenDNhap.Name = "colTenDNhap";
            this.colTenDNhap.OptionsColumn.AllowEdit = false;
            this.colTenDNhap.OptionsColumn.AllowFocus = false;
            this.colTenDNhap.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDNhap.OptionsColumn.AllowIncrementalSearch = false;
            this.colTenDNhap.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDNhap.OptionsColumn.AllowMove = false;
            this.colTenDNhap.OptionsColumn.AllowShowHide = false;
            this.colTenDNhap.OptionsColumn.AllowSize = false;
            this.colTenDNhap.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colTenDNhap.OptionsColumn.FixedWidth = true;
            this.colTenDNhap.OptionsColumn.ReadOnly = true;
            this.colTenDNhap.OptionsFilter.AllowAutoFilter = false;
            this.colTenDNhap.OptionsFilter.AllowFilter = false;
            this.colTenDNhap.Visible = true;
            this.colTenDNhap.VisibleIndex = 2;
            this.colTenDNhap.Width = 142;
            // 
            // colMaND_TenND
            // 
            this.colMaND_TenND.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaND_TenND.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaND_TenND.Caption = "Tên người dùng";
            this.colMaND_TenND.FieldName = "TenGiaoVien";
            this.colMaND_TenND.Name = "colMaND_TenND";
            this.colMaND_TenND.OptionsColumn.AllowEdit = false;
            this.colMaND_TenND.OptionsColumn.AllowFocus = false;
            this.colMaND_TenND.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colMaND_TenND.OptionsColumn.AllowIncrementalSearch = false;
            this.colMaND_TenND.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colMaND_TenND.OptionsColumn.AllowMove = false;
            this.colMaND_TenND.OptionsColumn.AllowShowHide = false;
            this.colMaND_TenND.OptionsColumn.AllowSize = false;
            this.colMaND_TenND.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colMaND_TenND.OptionsColumn.FixedWidth = true;
            this.colMaND_TenND.OptionsColumn.ReadOnly = true;
            this.colMaND_TenND.OptionsFilter.AllowAutoFilter = false;
            this.colMaND_TenND.OptionsFilter.AllowFilter = false;
            this.colMaND_TenND.Visible = true;
            this.colMaND_TenND.VisibleIndex = 1;
            this.colMaND_TenND.Width = 153;
            // 
            // colMaLoai
            // 
            this.colMaLoai.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaLoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLoai.Caption = "Loại người dùng";
            this.colMaLoai.FieldName = "TenLoaiND";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.OptionsColumn.AllowEdit = false;
            this.colMaLoai.OptionsColumn.AllowFocus = false;
            this.colMaLoai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colMaLoai.OptionsColumn.AllowIncrementalSearch = false;
            this.colMaLoai.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colMaLoai.OptionsColumn.AllowMove = false;
            this.colMaLoai.OptionsColumn.AllowShowHide = false;
            this.colMaLoai.OptionsColumn.AllowSize = false;
            this.colMaLoai.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colMaLoai.OptionsColumn.FixedWidth = true;
            this.colMaLoai.OptionsColumn.ReadOnly = true;
            this.colMaLoai.OptionsFilter.AllowAutoFilter = false;
            this.colMaLoai.OptionsFilter.AllowFilter = false;
            this.colMaLoai.Visible = true;
            this.colMaLoai.VisibleIndex = 3;
            this.colMaLoai.Width = 120;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AppearanceCell.Options.UseTextOptions = true;
            this.colTrangThai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrangThai.AppearanceHeader.Options.UseTextOptions = true;
            this.colTrangThai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTrangThai.Caption = "Được phép truy cập";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.OptionsColumn.AllowEdit = false;
            this.colTrangThai.OptionsColumn.AllowFocus = false;
            this.colTrangThai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colTrangThai.OptionsColumn.AllowIncrementalSearch = false;
            this.colTrangThai.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colTrangThai.OptionsColumn.AllowMove = false;
            this.colTrangThai.OptionsColumn.AllowShowHide = false;
            this.colTrangThai.OptionsColumn.AllowSize = false;
            this.colTrangThai.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colTrangThai.OptionsColumn.FixedWidth = true;
            this.colTrangThai.OptionsColumn.ReadOnly = true;
            this.colTrangThai.OptionsFilter.AllowAutoFilter = false;
            this.colTrangThai.OptionsFilter.AllowFilter = false;
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 4;
            this.colTrangThai.Width = 121;
            // 
            // colMaLoaiND
            // 
            this.colMaLoaiND.Caption = "Mã loại người dùng";
            this.colMaLoaiND.FieldName = "MaLoai";
            this.colMaLoaiND.Name = "colMaLoaiND";
            // 
            // frmQLNguoiDung
            // 
            this.AcceptButton = this.simpleButtonGhi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 420);
            this.Controls.Add(this.gridControlNguoiDung);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.comboBoxEditQuyenSuDung);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.radioGroupTrangThai);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditMatKhau);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdittenTruyCap);
            this.Controls.Add(this.comboBoxEditNguoiDung);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQLNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý người dùng";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmQLNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditNguoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdittenTruyCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditQuyenSuDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditNguoiDung;
        private DevExpress.XtraEditors.TextEdit textEdittenTruyCap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditMatKhau;
        private DevExpress.XtraEditors.RadioGroup radioGroupTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditQuyenSuDung;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colMaND;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaND_TenND;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiND;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDong;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGhi;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThemMoi;
    }
}