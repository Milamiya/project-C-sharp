namespace QLHocSinhTHPT.Reports
{
    partial class frptDanhSachHocSinh
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bSDSHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerDSHS = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bSDSHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // bSDSHocSinh
            // 
            this.bSDSHocSinh.DataSource = typeof(QLHocSinhTHPT.Bussiness.HocSinhInfo);
            // 
            // reportViewerDSHS
            // 
            this.reportViewerDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QLHocSinhTHPT_Bussiness_HocSinhInfo";
            reportDataSource1.Value = this.bSDSHocSinh;
            this.reportViewerDSHS.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDSHS.LocalReport.ReportEmbeddedResource = "QLHocSinhTHPT.Reports.rptDanhSachHocSinh.rdlc";
            this.reportViewerDSHS.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDSHS.Name = "reportViewerDSHS";
            this.reportViewerDSHS.Size = new System.Drawing.Size(792, 466);
            this.reportViewerDSHS.TabIndex = 1;
            // 
            // frptDanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.reportViewerDSHS);
            this.Name = "frptDanhSachHocSinh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptDanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSDSHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDSHS;
        private System.Windows.Forms.BindingSource bSDSHocSinh;
    }
}