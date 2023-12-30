namespace QuanLyTienGuiTietKiem.Report
{
    partial class frmInDanhSachNhanVien
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
            this.NhanVienInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewerDanhSachNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanVienInfoBindingSource
            // 
            this.NhanVienInfoBindingSource.DataSource = typeof(QuanLyTienGuiTietKiem.Bussiness.NhanVienInfo);
            // 
            // ReportViewerDanhSachNhanVien
            // 
            this.ReportViewerDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QuanLyTienGuiTietKiem_Bussiness_NhanVienInfo";
            reportDataSource1.Value = this.NhanVienInfoBindingSource;
            this.ReportViewerDanhSachNhanVien.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerDanhSachNhanVien.LocalReport.ReportEmbeddedResource = "QuanLyTienGuiTietKiem.Report.rptNhanVien.rdlc";
            this.ReportViewerDanhSachNhanVien.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerDanhSachNhanVien.Name = "ReportViewerDanhSachNhanVien";
            this.ReportViewerDanhSachNhanVien.Size = new System.Drawing.Size(655, 457);
            this.ReportViewerDanhSachNhanVien.TabIndex = 0;
            // 
            // frmInDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 457);
            this.Controls.Add(this.ReportViewerDanhSachNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInDanhSachNhanVien";
            this.ShowInTaskbar = false;
            this.Text = "frmInDanhSachNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerDanhSachNhanVien;
        private System.Windows.Forms.BindingSource NhanVienInfoBindingSource;
    }
}