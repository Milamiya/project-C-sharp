namespace QuanLyXeVaXe
{
    partial class frm_re_BaoCao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_LaiXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dts_TatCaXe = new QuanLyXeVaXe.Dts_TatCaXe();
            this.tb_XeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTS_TatCaXe2 = new QuanLyXeVaXe.DTS_TatCaXe2();
            this.tb_NhanVirnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dts_TatCaNhanVien = new QuanLyXeVaXe.Dts_TatCaNhanVien();
            this.tb_HopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dts_kHthanhtoan = new QuanLyXeVaXe.dts_kHthanhtoan();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tb_LaiXeTableAdapter = new QuanLyXeVaXe.Dts_TatCaXeTableAdapters.tb_LaiXeTableAdapter();
            this.tb_XeTableAdapter = new QuanLyXeVaXe.DTS_TatCaXe2TableAdapters.tb_XeTableAdapter();
            this.tb_NhanVirnTableAdapter = new QuanLyXeVaXe.Dts_TatCaNhanVienTableAdapters.tb_NhanVirnTableAdapter();
            this.tb_HopDongTableAdapter = new QuanLyXeVaXe.dts_kHthanhtoanTableAdapters.tb_HopDongTableAdapter();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dts_KHchuaTT = new QuanLyXeVaXe.dts_KHchuaTT();
            ((System.ComponentModel.ISupportInitialize)(this.tb_LaiXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dts_TatCaXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_XeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTS_TatCaXe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NhanVirnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dts_TatCaNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_kHthanhtoan)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dts_KHchuaTT)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_LaiXeBindingSource
            // 
            this.tb_LaiXeBindingSource.DataMember = "tb_LaiXe";
            this.tb_LaiXeBindingSource.DataSource = this.Dts_TatCaXe;
            // 
            // Dts_TatCaXe
            // 
            this.Dts_TatCaXe.DataSetName = "Dts_TatCaXe";
            this.Dts_TatCaXe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_XeBindingSource
            // 
            this.tb_XeBindingSource.DataMember = "tb_Xe";
            this.tb_XeBindingSource.DataSource = this.DTS_TatCaXe2;
            // 
            // DTS_TatCaXe2
            // 
            this.DTS_TatCaXe2.DataSetName = "DTS_TatCaXe2";
            this.DTS_TatCaXe2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_NhanVirnBindingSource
            // 
            this.tb_NhanVirnBindingSource.DataMember = "tb_NhanVirn";
            this.tb_NhanVirnBindingSource.DataSource = this.Dts_TatCaNhanVien;
            // 
            // Dts_TatCaNhanVien
            // 
            this.Dts_TatCaNhanVien.DataSetName = "Dts_TatCaNhanVien";
            this.Dts_TatCaNhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_HopDongBindingSource
            // 
            this.tb_HopDongBindingSource.DataMember = "tb_HopDong";
            this.tb_HopDongBindingSource.DataSource = this.dts_kHthanhtoan;
            // 
            // dts_kHthanhtoan
            // 
            this.dts_kHthanhtoan.DataSetName = "dts_kHthanhtoan";
            this.dts_kHthanhtoan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 605);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tất cả lái xe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Dts_TatCaXe_tb_LaiXe";
            reportDataSource1.Value = this.tb_LaiXeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyXeVaXe.RptTatCaXe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(943, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tất cả xe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DTS_TatCaXe2_tb_Xe";
            reportDataSource2.Value = this.tb_XeBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyXeVaXe.RE_TatCaXe.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(943, 571);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(949, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhân viên trong công ty";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "Dts_TatCaNhanVien_tb_NhanVirn";
            reportDataSource3.Value = this.tb_NhanVirnBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "QuanLyXeVaXe.RE_TATCANHANVIEN.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(943, 571);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(949, 577);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Khách hàng thanh toán";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "dts_kHthanhtoan_tb_HopDong";
            reportDataSource4.Value = this.tb_HopDongBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "QuanLyXeVaXe.RE_KHTHANHTOAN.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(943, 571);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(949, 577);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Khách hàng chưa thanh toán";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tb_LaiXeTableAdapter
            // 
            this.tb_LaiXeTableAdapter.ClearBeforeFill = true;
            // 
            // tb_XeTableAdapter
            // 
            this.tb_XeTableAdapter.ClearBeforeFill = true;
            // 
            // tb_NhanVirnTableAdapter
            // 
            this.tb_NhanVirnTableAdapter.ClearBeforeFill = true;
            // 
            // tb_HopDongTableAdapter
            // 
            this.tb_HopDongTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "dts_KHchuaTT_tb_HopDong";
            reportDataSource5.Value = this.tb_HopDongBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "QuanLyXeVaXe.RE_KHCHUATT.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(943, 571);
            this.reportViewer5.TabIndex = 0;
            // 
            // dts_KHchuaTT
            // 
            this.dts_KHchuaTT.DataSetName = "dts_KHchuaTT";
            this.dts_KHchuaTT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_re_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 622);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_re_BaoCao";
            this.Text = "frm_re_BaoCao";
            this.Load += new System.EventHandler(this.frm_re_BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_LaiXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dts_TatCaXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_XeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTS_TatCaXe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NhanVirnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dts_TatCaNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_HopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_kHthanhtoan)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dts_KHchuaTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_LaiXeBindingSource;
        private Dts_TatCaXe Dts_TatCaXe;
        private QuanLyXeVaXe.Dts_TatCaXeTableAdapters.tb_LaiXeTableAdapter tb_LaiXeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource tb_XeBindingSource;
        private DTS_TatCaXe2 DTS_TatCaXe2;
        private QuanLyXeVaXe.DTS_TatCaXe2TableAdapters.tb_XeTableAdapter tb_XeTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource tb_NhanVirnBindingSource;
        private Dts_TatCaNhanVien Dts_TatCaNhanVien;
        private QuanLyXeVaXe.Dts_TatCaNhanVienTableAdapters.tb_NhanVirnTableAdapter tb_NhanVirnTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource tb_HopDongBindingSource;
        private dts_kHthanhtoan dts_kHthanhtoan;
        private QuanLyXeVaXe.dts_kHthanhtoanTableAdapters.tb_HopDongTableAdapter tb_HopDongTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private dts_KHchuaTT dts_KHchuaTT;
    }
}