namespace QuanLyDaoTao.Presentation
{
    partial class frmNhapXuatDuLieuNangCao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapXuatDuLieuNangCao));
            this.pnTop = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportFromCSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportFromExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lsvTables = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.pnBottom = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).BeginInit();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.checkEdit1);
            this.pnTop.Controls.Add(this.btnExportToCSV);
            this.pnTop.Controls.Add(this.btnImportFromCSV);
            this.pnTop.Controls.Add(this.btnImportFromExcel);
            this.pnTop.Controls.Add(this.btnExportToExcel);
            this.pnTop.Controls.Add(this.labelControl1);
            this.pnTop.Controls.Add(this.lsvTables);
            this.pnTop.Controls.Add(this.reflectionImage1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(990, 214);
            this.pnTop.TabIndex = 0;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(668, 12);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Dòng đầu tiên là tên cột";
            this.checkEdit1.Size = new System.Drawing.Size(184, 23);
            this.checkEdit1.TabIndex = 8;
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToCSV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnExportToCSV.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnExportToCSV.Appearance.Options.UseFont = true;
            this.btnExportToCSV.Appearance.Options.UseForeColor = true;
            this.btnExportToCSV.Image = global::QuanLyDaoTao.Properties.Resources.csv_tex2t;
            this.btnExportToCSV.Location = new System.Drawing.Point(858, 86);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(120, 30);
            this.btnExportToCSV.TabIndex = 7;
            this.btnExportToCSV.Text = "Xuất CSV";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // btnImportFromCSV
            // 
            this.btnImportFromCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportFromCSV.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnImportFromCSV.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnImportFromCSV.Appearance.Options.UseFont = true;
            this.btnImportFromCSV.Appearance.Options.UseForeColor = true;
            this.btnImportFromCSV.Image = global::QuanLyDaoTao.Properties.Resources.csv_tex2t;
            this.btnImportFromCSV.Location = new System.Drawing.Point(858, 176);
            this.btnImportFromCSV.Name = "btnImportFromCSV";
            this.btnImportFromCSV.Size = new System.Drawing.Size(120, 30);
            this.btnImportFromCSV.TabIndex = 7;
            this.btnImportFromCSV.Text = "Nhập CSV";
            // 
            // btnImportFromExcel
            // 
            this.btnImportFromExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportFromExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnImportFromExcel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnImportFromExcel.Appearance.Options.UseFont = true;
            this.btnImportFromExcel.Appearance.Options.UseForeColor = true;
            this.btnImportFromExcel.Image = global::QuanLyDaoTao.Properties.Resources.excel_icon_32;
            this.btnImportFromExcel.Location = new System.Drawing.Point(858, 131);
            this.btnImportFromExcel.Name = "btnImportFromExcel";
            this.btnImportFromExcel.Size = new System.Drawing.Size(120, 30);
            this.btnImportFromExcel.TabIndex = 7;
            this.btnImportFromExcel.Text = "Nhập Excel";
            this.btnImportFromExcel.Click += new System.EventHandler(this.btnImportFromExcel_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnExportToExcel.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnExportToExcel.Appearance.Options.UseFont = true;
            this.btnExportToExcel.Appearance.Options.UseForeColor = true;
            this.btnExportToExcel.Image = global::QuanLyDaoTao.Properties.Resources.excel_icon_32;
            this.btnExportToExcel.Location = new System.Drawing.Point(858, 41);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(120, 30);
            this.btnExportToExcel.TabIndex = 7;
            this.btnExportToExcel.Text = "Xuất Excel";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Location = new System.Drawing.Point(148, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Chọn bảng để thao tác:";
            // 
            // lsvTables
            // 
            this.lsvTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lsvTables.Border.Class = "ListViewBorder";
            this.lsvTables.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsvTables.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lsvTables.FullRowSelect = true;
            this.lsvTables.GridLines = true;
            this.lsvTables.Location = new System.Drawing.Point(148, 41);
            this.lsvTables.MultiSelect = false;
            this.lsvTables.Name = "lsvTables";
            this.lsvTables.Size = new System.Drawing.Size(704, 167);
            this.lsvTables.SmallImageList = this.imageList1;
            this.lsvTables.TabIndex = 4;
            this.lsvTables.UseCompatibleStateImageBehavior = false;
            this.lsvTables.View = System.Windows.Forms.View.SmallIcon;
            this.lsvTables.SelectedIndexChanged += new System.EventHandler(this.lsvTables_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "table 16.png");
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::QuanLyDaoTao.Properties.Resources.database_export;
            this.reflectionImage1.Location = new System.Drawing.Point(0, -21);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(142, 263);
            this.reflectionImage1.TabIndex = 48;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.groupControl3);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 214);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(990, 244);
            this.pnBottom.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(986, 240);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Dữ liệu hiện tại trong CSDL";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(982, 217);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridControl1_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // frmNhapXuatDuLieuNangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 458);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Name = "frmNhapXuatDuLieuNangCao";
            this.Text = "frmNhapXuatDuLieuNangCao";
            this.Load += new System.EventHandler(this.frmNhapXuatDuLieuNangCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).EndInit();
            this.pnBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnTop;
        private DevExpress.XtraEditors.PanelControl pnBottom;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton btnExportToExcel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevComponents.DotNetBar.Controls.ListViewEx lsvTables;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevExpress.XtraEditors.SimpleButton btnExportToCSV;
        private DevExpress.XtraEditors.SimpleButton btnImportFromExcel;
        private DevExpress.XtraEditors.SimpleButton btnImportFromCSV;
    }
}