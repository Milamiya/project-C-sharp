namespace QuanLyDaoTao.Presentation
{
    partial class frmRSS
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblUrl = new DevExpress.XtraBars.BarStaticItem();
            this.grbMain = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grbDiaChi = new DevExpress.XtraEditors.GroupControl();
            this.lsvDiaChi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.grbMucTin = new DevExpress.XtraEditors.GroupControl();
            this.lsvMucTin = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbMain)).BeginInit();
            this.grbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbDiaChi)).BeginInit();
            this.grbDiaChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbMucTin)).BeginInit();
            this.grbMucTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblUrl});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1084, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 485);
            this.barDockControlBottom.Size = new System.Drawing.Size(1084, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 485);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1084, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 485);
            // 
            // lblUrl
            // 
            this.lblUrl.Caption = "lblUrl";
            this.lblUrl.Id = 0;
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.splitContainerControl1);
            this.grbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMain.Location = new System.Drawing.Point(0, 0);
            this.grbMain.Name = "grbMain";
            this.grbMain.Size = new System.Drawing.Size(1084, 485);
            this.grbMain.TabIndex = 9;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 20);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1080, 463);
            this.splitContainerControl1.SplitterPosition = 207;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.grbDiaChi);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.grbMucTin);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(207, 463);
            this.splitContainerControl2.SplitterPosition = 177;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // grbDiaChi
            // 
            this.grbDiaChi.Controls.Add(this.lsvDiaChi);
            this.grbDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDiaChi.Location = new System.Drawing.Point(0, 0);
            this.grbDiaChi.Name = "grbDiaChi";
            this.grbDiaChi.Size = new System.Drawing.Size(207, 177);
            this.grbDiaChi.TabIndex = 2;
            this.grbDiaChi.Text = "Địa chỉ";
            // 
            // lsvDiaChi
            // 
            // 
            // 
            // 
            this.lsvDiaChi.Border.Class = "ListViewBorder";
            this.lsvDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsvDiaChi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDiaChi.FullRowSelect = true;
            this.lsvDiaChi.GridLines = true;
            this.lsvDiaChi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvDiaChi.Location = new System.Drawing.Point(2, 20);
            this.lsvDiaChi.MultiSelect = false;
            this.lsvDiaChi.Name = "lsvDiaChi";
            this.lsvDiaChi.Size = new System.Drawing.Size(203, 155);
            this.lsvDiaChi.TabIndex = 1;
            this.lsvDiaChi.UseCompatibleStateImageBehavior = false;
            this.lsvDiaChi.View = System.Windows.Forms.View.Details;
            this.lsvDiaChi.SelectedIndexChanged += new System.EventHandler(this.lsvDiaChi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Địa chỉ";
            this.columnHeader1.Width = 191;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "\"\"";
            this.columnHeader2.Width = 10;
            // 
            // grbMucTin
            // 
            this.grbMucTin.Controls.Add(this.lsvMucTin);
            this.grbMucTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMucTin.Location = new System.Drawing.Point(0, 0);
            this.grbMucTin.Name = "grbMucTin";
            this.grbMucTin.Size = new System.Drawing.Size(207, 281);
            this.grbMucTin.TabIndex = 3;
            this.grbMucTin.Text = "Mục tin";
            // 
            // lsvMucTin
            // 
            // 
            // 
            // 
            this.lsvMucTin.Border.Class = "ListViewBorder";
            this.lsvMucTin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lsvMucTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lsvMucTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvMucTin.FullRowSelect = true;
            this.lsvMucTin.GridLines = true;
            this.lsvMucTin.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvMucTin.Location = new System.Drawing.Point(2, 21);
            this.lsvMucTin.MultiSelect = false;
            this.lsvMucTin.Name = "lsvMucTin";
            this.lsvMucTin.Size = new System.Drawing.Size(203, 258);
            this.lsvMucTin.TabIndex = 1;
            this.lsvMucTin.UseCompatibleStateImageBehavior = false;
            this.lsvMucTin.View = System.Windows.Forms.View.Details;
            this.lsvMucTin.SelectedIndexChanged += new System.EventHandler(this.lsvMucTin_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mục tin";
            this.columnHeader3.Width = 193;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "\"\"";
            this.columnHeader4.Width = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(868, 463);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 485);
            this.Controls.Add(this.grbMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimumSize = new System.Drawing.Size(1100, 523);
            this.Name = "frmRSS";
            this.Text = "frmRSS";
            this.Load += new System.EventHandler(this.frmRSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbMain)).EndInit();
            this.grbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbDiaChi)).EndInit();
            this.grbDiaChi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbMucTin)).EndInit();
            this.grbMucTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarStaticItem lblUrl;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl grbMain;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl grbDiaChi;
        private DevComponents.DotNetBar.Controls.ListViewEx lsvDiaChi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraEditors.GroupControl grbMucTin;
        private DevComponents.DotNetBar.Controls.ListViewEx lsvMucTin;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;

    }
}