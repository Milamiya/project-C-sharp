namespace QuanLyDaoTao.Presentation
{
    partial class frmDanhMucNguoiDung
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuyen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.lblTenKH = new DevExpress.XtraEditors.LabelControl();
            this.lblMaNV = new DevExpress.XtraEditors.LabelControl();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soNguoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mucPhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.giaiDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moTaPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phuongThucTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayTTTheoKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayThatSuTT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDoiMatKhau);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.txtQuyen);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.txtTenDangNhap);
            this.panelControl1.Controls.Add(this.lblTenKH);
            this.panelControl1.Controls.Add(this.lblMaNV);
            this.panelControl1.Controls.Add(this.reflectionImage1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(957, 156);
            this.panelControl1.TabIndex = 3;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnDoiMatKhau.Appearance.Options.UseFont = true;
            this.btnDoiMatKhau.Image = global::QuanLyDaoTao.Properties.Resources.resetpass32;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(499, 103);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(193, 35);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Thiết lập lại mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.Image = global::QuanLyDaoTao.Properties.Resources.Print_icon;
            this.btnIn.Location = new System.Drawing.Point(698, 103);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(136, 35);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In danh sách";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtQuyen
            // 
            this.txtQuyen.EnterMoveNextControl = true;
            this.txtQuyen.Location = new System.Drawing.Point(295, 100);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtQuyen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtQuyen.Properties.Appearance.Options.UseBackColor = true;
            this.txtQuyen.Properties.Appearance.Options.UseFont = true;
            this.txtQuyen.Properties.ReadOnly = true;
            this.txtQuyen.Size = new System.Drawing.Size(177, 24);
            this.txtQuyen.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Location = new System.Drawing.Point(184, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Quyền:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.EnterMoveNextControl = true;
            this.txtHoTen.Location = new System.Drawing.Point(295, 56);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHoTen.Properties.Appearance.Options.UseBackColor = true;
            this.txtHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtHoTen.Properties.MaxLength = 50;
            this.txtHoTen.Properties.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(639, 24);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.EnterMoveNextControl = true;
            this.txtTenDangNhap.Location = new System.Drawing.Point(295, 12);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtTenDangNhap.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTenDangNhap.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Properties.Appearance.Options.UseForeColor = true;
            this.txtTenDangNhap.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTenDangNhap.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTenDangNhap.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtTenDangNhap.Properties.MaxLength = 8;
            this.txtTenDangNhap.Properties.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(127, 24);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblTenKH.Location = new System.Drawing.Point(184, 59);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(49, 18);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Họ tên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblMaNV.Location = new System.Drawing.Point(184, 15);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(106, 18);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Tên đăng nhập:";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.Staff1;
            this.reflectionImage1.Location = new System.Drawing.Point(12, -20);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(144, 252);
            this.reflectionImage1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 156);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(957, 272);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh sách người dùng";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(953, 249);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tenDangNhap,
            this.hoTen,
            this.quyen});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.AppearanceCell.Options.UseTextOptions = true;
            this.tenDangNhap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenDangNhap.AppearanceHeader.Options.UseTextOptions = true;
            this.tenDangNhap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenDangNhap.Caption = "Tên đăng nhập";
            this.tenDangNhap.FieldName = "TenDangNhap";
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.OptionsColumn.AllowEdit = false;
            this.tenDangNhap.Visible = true;
            this.tenDangNhap.VisibleIndex = 0;
            this.tenDangNhap.Width = 129;
            // 
            // hoTen
            // 
            this.hoTen.Caption = "Họ tên";
            this.hoTen.FieldName = "TenNguoiDung";
            this.hoTen.Name = "hoTen";
            this.hoTen.Visible = true;
            this.hoTen.VisibleIndex = 1;
            this.hoTen.Width = 162;
            // 
            // quyen
            // 
            this.quyen.Caption = "Quyền";
            this.quyen.FieldName = "MoTaQuyen";
            this.quyen.Name = "quyen";
            this.quyen.Visible = true;
            this.quyen.VisibleIndex = 2;
            this.quyen.Width = 412;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.gridColumn1,
            this.nhanVien,
            this.ngayBD,
            this.ngayKetThuc,
            this.soNguoi,
            this.mucPhat,
            this.gridColumn2,
            this.diaDiem,
            this.khachHang});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.AppearanceCell.Options.UseTextOptions = true;
            this.id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id.AppearanceHeader.Options.UseTextOptions = true;
            this.id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.id.Caption = "Số";
            this.id.FieldName = "ID";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 59;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chương trình";
            this.gridColumn1.FieldName = "MaCT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 93;
            // 
            // nhanVien
            // 
            this.nhanVien.Caption = "Nhân viên";
            this.nhanVien.FieldName = "MaNV";
            this.nhanVien.Name = "nhanVien";
            this.nhanVien.Visible = true;
            this.nhanVien.VisibleIndex = 3;
            this.nhanVien.Width = 105;
            // 
            // ngayBD
            // 
            this.ngayBD.Caption = "Ngày bắt đầu";
            this.ngayBD.FieldName = "NgayBatDau";
            this.ngayBD.Name = "ngayBD";
            this.ngayBD.Visible = true;
            this.ngayBD.VisibleIndex = 4;
            this.ngayBD.Width = 93;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.Caption = "Ngày kết thúc";
            this.ngayKetThuc.FieldName = "NgayKetThuc";
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Visible = true;
            this.ngayKetThuc.VisibleIndex = 5;
            this.ngayKetThuc.Width = 101;
            // 
            // soNguoi
            // 
            this.soNguoi.Caption = "Số người tham gia";
            this.soNguoi.FieldName = "SoNguoiThamGia";
            this.soNguoi.Name = "soNguoi";
            this.soNguoi.Visible = true;
            this.soNguoi.VisibleIndex = 6;
            this.soNguoi.Width = 104;
            // 
            // mucPhat
            // 
            this.mucPhat.Caption = "Mức phạt";
            this.mucPhat.FieldName = "MucPhat";
            this.mucPhat.Name = "mucPhat";
            this.mucPhat.Visible = true;
            this.mucPhat.VisibleIndex = 7;
            this.mucPhat.Width = 107;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mô tả";
            this.gridColumn2.FieldName = "MoTa";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 206;
            // 
            // diaDiem
            // 
            this.diaDiem.Caption = "Địa điểm";
            this.diaDiem.FieldName = "DiaDiem";
            this.diaDiem.Name = "diaDiem";
            this.diaDiem.Visible = true;
            this.diaDiem.VisibleIndex = 8;
            this.diaDiem.Width = 105;
            // 
            // khachHang
            // 
            this.khachHang.Caption = "Khách hàng";
            this.khachHang.FieldName = "MaKH";
            this.khachHang.Name = "khachHang";
            this.khachHang.Visible = true;
            this.khachHang.VisibleIndex = 1;
            this.khachHang.Width = 87;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.giaiDoan,
            this.phi,
            this.moTaPhi,
            this.phuongThucTT,
            this.ngayTTTheoKH,
            this.ngayThatSuTT});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // giaiDoan
            // 
            this.giaiDoan.AppearanceCell.Options.UseTextOptions = true;
            this.giaiDoan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.giaiDoan.AppearanceHeader.Options.UseTextOptions = true;
            this.giaiDoan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.giaiDoan.Caption = "Giai đoạn";
            this.giaiDoan.FieldName = "GiaiDoan";
            this.giaiDoan.Name = "giaiDoan";
            this.giaiDoan.Visible = true;
            this.giaiDoan.VisibleIndex = 0;
            this.giaiDoan.Width = 73;
            // 
            // phi
            // 
            this.phi.Caption = "Phí";
            this.phi.FieldName = "Phi";
            this.phi.Name = "phi";
            this.phi.Visible = true;
            this.phi.VisibleIndex = 1;
            // 
            // moTaPhi
            // 
            this.moTaPhi.Caption = "Mô tả phí";
            this.moTaPhi.FieldName = "MoTaPhi";
            this.moTaPhi.Name = "moTaPhi";
            this.moTaPhi.Visible = true;
            this.moTaPhi.VisibleIndex = 5;
            this.moTaPhi.Width = 166;
            // 
            // phuongThucTT
            // 
            this.phuongThucTT.Caption = "Phương thức thanh toán";
            this.phuongThucTT.FieldName = "PhuongThucTT";
            this.phuongThucTT.Name = "phuongThucTT";
            this.phuongThucTT.Visible = true;
            this.phuongThucTT.VisibleIndex = 2;
            this.phuongThucTT.Width = 127;
            // 
            // ngayTTTheoKH
            // 
            this.ngayTTTheoKH.Caption = "Ngày phải thanh toán";
            this.ngayTTTheoKH.FieldName = "NgayTTTheoKH";
            this.ngayTTTheoKH.Name = "ngayTTTheoKH";
            this.ngayTTTheoKH.Visible = true;
            this.ngayTTTheoKH.VisibleIndex = 3;
            this.ngayTTTheoKH.Width = 113;
            // 
            // ngayThatSuTT
            // 
            this.ngayThatSuTT.Caption = "Ngày thanh toán";
            this.ngayThatSuTT.FieldName = "NgayThatSuTT";
            this.ngayThatSuTT.Name = "ngayThatSuTT";
            this.ngayThatSuTT.Visible = true;
            this.ngayThatSuTT.VisibleIndex = 4;
            this.ngayThatSuTT.Width = 90;
            // 
            // frmDanhMucNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 428);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDanhMucNguoiDung";
            this.Text = "frmDanhMucNguoiDung";
            this.Load += new System.EventHandler(this.frmDanhMucNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.TextEdit txtQuyen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl lblTenKH;
        private DevExpress.XtraEditors.LabelControl lblMaNV;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn nhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn ngayBD;
        private DevExpress.XtraGrid.Columns.GridColumn ngayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn soNguoi;
        private DevExpress.XtraGrid.Columns.GridColumn mucPhat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn diaDiem;
        private DevExpress.XtraGrid.Columns.GridColumn khachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn giaiDoan;
        private DevExpress.XtraGrid.Columns.GridColumn phi;
        private DevExpress.XtraGrid.Columns.GridColumn moTaPhi;
        private DevExpress.XtraGrid.Columns.GridColumn phuongThucTT;
        private DevExpress.XtraGrid.Columns.GridColumn ngayTTTheoKH;
        private DevExpress.XtraGrid.Columns.GridColumn ngayThatSuTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn tenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn hoTen;
        private DevExpress.XtraGrid.Columns.GridColumn quyen;
    }
}