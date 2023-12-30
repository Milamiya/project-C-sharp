namespace QuanLyTienGuiTietKiem.Report
{
    partial class frmPhieuThu_PhieuGui
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
            this.ReportViewerInPhieuThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InPhieuThuInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InPhieuThuInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerInPhieuThu
            // 
            this.ReportViewerInPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QuanLyTienGuiTietKiem_Bussiness_InPhieuThuInfo";
            reportDataSource1.Value = this.InPhieuThuInfoBindingSource;
            this.ReportViewerInPhieuThu.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerInPhieuThu.LocalReport.ReportEmbeddedResource = "QuanLyTienGuiTietKiem.Report.rptInPhieuThu.rdlc";
            this.ReportViewerInPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerInPhieuThu.Name = "ReportViewerInPhieuThu";
            this.ReportViewerInPhieuThu.Size = new System.Drawing.Size(556, 431);
            this.ReportViewerInPhieuThu.TabIndex = 0;
            // 
            // InPhieuThuInfoBindingSource
            // 
            this.InPhieuThuInfoBindingSource.DataSource = typeof(QuanLyTienGuiTietKiem.Bussiness.InPhieuThuInfo);
            // 
            // frmPhieuThu_PhieuGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 431);
            this.Controls.Add(this.ReportViewerInPhieuThu);
            this.Name = "frmPhieuThu_PhieuGui";
            this.Text = "frmPhieuThu_PhieuGui";
            this.Load += new System.EventHandler(this.frmPhieuThu_PhieuGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InPhieuThuInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerInPhieuThu;
        private System.Windows.Forms.BindingSource InPhieuThuInfoBindingSource;
    }
}