namespace QuanLyTienGuiTietKiem.Report
{
    partial class frmInSoCoKH
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
            this.ReportViewerInSoCoKyHan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SoTietKiemInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SoTietKiemInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerInSoCoKyHan
            // 
            this.ReportViewerInSoCoKyHan.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QuanLyTienGuiTietKiem_Bussiness_SoTietKiemInfo";
            reportDataSource1.Value = this.SoTietKiemInfoBindingSource;
            this.ReportViewerInSoCoKyHan.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerInSoCoKyHan.LocalReport.ReportEmbeddedResource = "QuanLyTienGuiTietKiem.Report.rptInSoCoKyHan.rdlc";
            this.ReportViewerInSoCoKyHan.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerInSoCoKyHan.Name = "ReportViewerInSoCoKyHan";
            this.ReportViewerInSoCoKyHan.Size = new System.Drawing.Size(429, 349);
            this.ReportViewerInSoCoKyHan.TabIndex = 0;
            // 
            // SoTietKiemInfoBindingSource
            // 
            this.SoTietKiemInfoBindingSource.DataSource = typeof(QuanLyTienGuiTietKiem.Bussiness.SoTietKiemInfo);
            // 
            // frmInSoCoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 349);
            this.Controls.Add(this.ReportViewerInSoCoKyHan);
            this.Name = "frmInSoCoKH";
            this.Text = "frmInSoCoKH";
            this.Load += new System.EventHandler(this.frmInSoCoKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoTietKiemInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerInSoCoKyHan;
        private System.Windows.Forms.BindingSource SoTietKiemInfoBindingSource;
    }
}