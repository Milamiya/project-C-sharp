namespace QuanLyXeVaXe
{
    partial class frmReTraXeCoNguoiLai
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
            this.tb_ChiTietPhieuTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTS_TraXeKoNguoilai = new QuanLyXeVaXe.DTS_TraXeKoNguoilai();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_ChiTietPhieuTraTableAdapter = new QuanLyXeVaXe.DTS_TraXeKoNguoilaiTableAdapters.tb_ChiTietPhieuTraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChiTietPhieuTraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTS_TraXeKoNguoilai)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ChiTietPhieuTraBindingSource
            // 
            this.tb_ChiTietPhieuTraBindingSource.DataMember = "tb_ChiTietPhieuTra";
            this.tb_ChiTietPhieuTraBindingSource.DataSource = this.DTS_TraXeKoNguoilai;
            // 
            // DTS_TraXeKoNguoilai
            // 
            this.DTS_TraXeKoNguoilai.DataSetName = "DTS_TraXeKoNguoilai";
            this.DTS_TraXeKoNguoilai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DTS_TraXeKoNguoilai_tb_ChiTietPhieuTra";
            reportDataSource1.Value = this.tb_ChiTietPhieuTraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyXeVaXe.RE_TraxeCoNguoiLai.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1042, 654);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_ChiTietPhieuTraTableAdapter
            // 
            this.tb_ChiTietPhieuTraTableAdapter.ClearBeforeFill = true;
            // 
            // frmReTraXeCoNguoiLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 654);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReTraXeCoNguoiLai";
            this.Text = "frmReTraXeCoNguoiLai";
            this.Load += new System.EventHandler(this.frmReTraXeCoNguoiLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChiTietPhieuTraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTS_TraXeKoNguoilai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_ChiTietPhieuTraBindingSource;
        private DTS_TraXeKoNguoilai DTS_TraXeKoNguoilai;
        private QuanLyXeVaXe.DTS_TraXeKoNguoilaiTableAdapters.tb_ChiTietPhieuTraTableAdapter tb_ChiTietPhieuTraTableAdapter;
    }
}