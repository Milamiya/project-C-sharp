namespace QuanLyDaoTao.Presentation
{
    partial class frmNhapTKB
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
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tietBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Image = global::QuanLyDaoTao.Properties.Resources.button_cancel_icon2;
            this.btnHuy.Location = new System.Drawing.Point(310, 153);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 36);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Image = global::QuanLyDaoTao.Properties.Resources.button_ok1;
            this.btnOk.Location = new System.Drawing.Point(173, 153);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(73, 36);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Lưu";
            this.btnOk.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(549, 144);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Các đề nghị giảng dạy ngày:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(545, 121);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maGV,
            this.tenGV,
            this.maMH,
            this.tenMH,
            this.maLop,
            this.tietBD,
            this.soTiet});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // maGV
            // 
            this.maGV.Caption = "Mã GV";
            this.maGV.FieldName = "MaGV";
            this.maGV.Name = "maGV";
            this.maGV.Visible = true;
            this.maGV.VisibleIndex = 0;
            this.maGV.Width = 61;
            // 
            // tenGV
            // 
            this.tenGV.Caption = "Tên GV";
            this.tenGV.FieldName = "TenGV";
            this.tenGV.Name = "tenGV";
            this.tenGV.Visible = true;
            this.tenGV.VisibleIndex = 1;
            this.tenGV.Width = 130;
            // 
            // maMH
            // 
            this.maMH.Caption = "Mã MH";
            this.maMH.FieldName = "MaMH";
            this.maMH.Name = "maMH";
            this.maMH.Visible = true;
            this.maMH.VisibleIndex = 2;
            this.maMH.Width = 62;
            // 
            // tenMH
            // 
            this.tenMH.Caption = "Môn học";
            this.tenMH.FieldName = "TenMH";
            this.tenMH.Name = "tenMH";
            this.tenMH.Visible = true;
            this.tenMH.VisibleIndex = 3;
            this.tenMH.Width = 108;
            // 
            // maLop
            // 
            this.maLop.Caption = "Lớp";
            this.maLop.FieldName = "MaLop";
            this.maLop.Name = "maLop";
            this.maLop.Visible = true;
            this.maLop.VisibleIndex = 4;
            // 
            // tietBD
            // 
            this.tietBD.Caption = "Tiết BĐ";
            this.tietBD.FieldName = "TietBatDau";
            this.tietBD.Name = "tietBD";
            this.tietBD.Visible = true;
            this.tietBD.VisibleIndex = 5;
            this.tietBD.Width = 45;
            // 
            // soTiet
            // 
            this.soTiet.Caption = "Số tiết";
            this.soTiet.FieldName = "SoTiet";
            this.soTiet.Name = "soTiet";
            this.soTiet.Visible = true;
            this.soTiet.VisibleIndex = 6;
            this.soTiet.Width = 44;
            // 
            // frmNhapTKB
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(556, 195);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOk);
            this.MinimumSize = new System.Drawing.Size(572, 233);
            this.Name = "frmNhapTKB";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xếp thời khóa biểu";
            this.Load += new System.EventHandler(this.frmNhapTKB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn maGV;
        private DevExpress.XtraGrid.Columns.GridColumn tenGV;
        private DevExpress.XtraGrid.Columns.GridColumn maMH;
        private DevExpress.XtraGrid.Columns.GridColumn tenMH;
        private DevExpress.XtraGrid.Columns.GridColumn maLop;
        private DevExpress.XtraGrid.Columns.GridColumn tietBD;
        private DevExpress.XtraGrid.Columns.GridColumn soTiet;
    }
}