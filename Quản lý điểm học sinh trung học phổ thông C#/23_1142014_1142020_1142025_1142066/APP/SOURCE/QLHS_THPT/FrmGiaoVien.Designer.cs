namespace QLHS
{
    partial class FrmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaoVien));
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControlTitle = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonDong = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMaGiaoVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTenGiaoVien = new DevExpress.XtraEditors.TextEdit();
            this.gridcontrolGiaoVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiaoVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TenGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaGiaoVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenGiaoVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontrolGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Image = global::QLHS.Properties.Resources.xoa_small;
            this.simpleButtonXoa.Location = new System.Drawing.Point(324, 16);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(104, 35);
            this.simpleButtonXoa.TabIndex = 6;
            this.simpleButtonXoa.Text = "Xóa (Alt+&D)";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoaGiaovien_Click);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Image = global::QLHS.Properties.Resources.them;
            this.simpleButtonThem.Location = new System.Drawing.Point(23, 16);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(135, 35);
            this.simpleButtonThem.TabIndex = 4;
            this.simpleButtonThem.Text = "Thêm mới (Alt+&N)";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThemGiaoVien_Click);
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Image = global::QLHS.Properties.Resources.them_small;
            this.simpleButtonLuu.Location = new System.Drawing.Point(187, 16);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(116, 35);
            this.simpleButtonLuu.TabIndex = 5;
            this.simpleButtonLuu.Text = "Lưu hồ sơ (Enter)";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuuGiaoVien_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControlTitle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 48);
            this.panelControl1.TabIndex = 9;
            // 
            // labelControlTitle
            // 
            this.labelControlTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlTitle.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControlTitle.Location = new System.Drawing.Point(23, 12);
            this.labelControlTitle.Name = "labelControlTitle";
            this.labelControlTitle.Size = new System.Drawing.Size(176, 23);
            this.labelControlTitle.TabIndex = 20;
            this.labelControlTitle.Text = "HỒ SƠ GIÁO VIÊN";
            // 
            // simpleButtonDong
            // 
            this.simpleButtonDong.Image = global::QLHS.Properties.Resources.thoat_small;
            this.simpleButtonDong.Location = new System.Drawing.Point(455, 16);
            this.simpleButtonDong.Name = "simpleButtonDong";
            this.simpleButtonDong.Size = new System.Drawing.Size(104, 35);
            this.simpleButtonDong.TabIndex = 7;
            this.simpleButtonDong.Text = "Đóng (Alt+&X)";
            this.simpleButtonDong.Click += new System.EventHandler(this.simpleButtonThoat_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButtonLuu);
            this.panelControl2.Controls.Add(this.simpleButtonXoa);
            this.panelControl2.Controls.Add(this.simpleButtonDong);
            this.panelControl2.Controls.Add(this.simpleButtonThem);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 524);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(784, 65);
            this.panelControl2.TabIndex = 10;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.textEditMaGiaoVien);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.textEditTenGiaoVien);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 48);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(784, 104);
            this.panelControl3.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Tên giáo viên:";
            // 
            // textEditMaGiaoVien
            // 
            this.textEditMaGiaoVien.Enabled = false;
            this.textEditMaGiaoVien.Location = new System.Drawing.Point(23, 25);
            this.textEditMaGiaoVien.Name = "textEditMaGiaoVien";
            this.textEditMaGiaoVien.Size = new System.Drawing.Size(147, 20);
            this.textEditMaGiaoVien.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Mã giáo viên:";
            // 
            // textEditTenGiaoVien
            // 
            this.textEditTenGiaoVien.Location = new System.Drawing.Point(23, 70);
            this.textEditTenGiaoVien.Name = "textEditTenGiaoVien";
            this.textEditTenGiaoVien.Size = new System.Drawing.Size(147, 20);
            this.textEditTenGiaoVien.TabIndex = 2;
            // 
            // gridcontrolGiaoVien
            // 
            this.gridcontrolGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridcontrolGiaoVien.Location = new System.Drawing.Point(0, 152);
            this.gridcontrolGiaoVien.MainView = this.gridViewGiaoVien;
            this.gridcontrolGiaoVien.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.gridcontrolGiaoVien.Name = "gridcontrolGiaoVien";
            this.gridcontrolGiaoVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1});
            this.gridcontrolGiaoVien.Size = new System.Drawing.Size(363, 372);
            this.gridcontrolGiaoVien.TabIndex = 3;
            this.gridcontrolGiaoVien.TabStop = false;
            this.gridcontrolGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiaoVien});
            // 
            // gridViewGiaoVien
            // 
            this.gridViewGiaoVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaGiaoVien,
            this.TenGiaoVien});
            this.gridViewGiaoVien.GridControl = this.gridcontrolGiaoVien;
            this.gridViewGiaoVien.Name = "gridViewGiaoVien";
            this.gridViewGiaoVien.OptionsView.ShowGroupPanel = false;
            this.gridViewGiaoVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGiaoVien_FocusedRowChanged);
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.Caption = "Mã Giáo Viên";
            this.MaGiaoVien.ColumnEdit = this.repositoryItemTextEdit1;
            this.MaGiaoVien.FieldName = "MaGiaoVien";
            this.MaGiaoVien.MinWidth = 10;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.OptionsColumn.AllowEdit = false;
            this.MaGiaoVien.OptionsColumn.ReadOnly = true;
            this.MaGiaoVien.Visible = true;
            this.MaGiaoVien.VisibleIndex = 0;
            this.MaGiaoVien.Width = 116;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.Caption = "Tên Giáo Viên";
            this.TenGiaoVien.ColumnEdit = this.repositoryItemTextEdit1;
            this.TenGiaoVien.FieldName = "TenGiaoVien";
            this.TenGiaoVien.MinWidth = 25;
            this.TenGiaoVien.Name = "TenGiaoVien";
            this.TenGiaoVien.OptionsColumn.AllowEdit = false;
            this.TenGiaoVien.OptionsColumn.ReadOnly = true;
            this.TenGiaoVien.Visible = true;
            this.TenGiaoVien.VisibleIndex = 1;
            this.TenGiaoVien.Width = 348;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit1.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(363, 152);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(421, 372);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // frmGiaoVien
            // 
            this.AcceptButton = this.simpleButtonLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 589);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gridcontrolGiaoVien);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.MaximizeBox = false;
            this.Name = "FrmGiaoVien";
            this.ShowIcon = false;
            this.Text = "Quản lý giáo viên";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaGiaoVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenGiaoVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontrolGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDong;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlTitle;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditMaGiaoVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditTenGiaoVien;
        private DevExpress.XtraGrid.GridControl gridcontrolGiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn MaGiaoVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn TenGiaoVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}