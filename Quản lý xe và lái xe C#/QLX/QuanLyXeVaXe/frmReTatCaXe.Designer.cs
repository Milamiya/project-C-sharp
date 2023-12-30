namespace QuanLyXeVaXe
{
    partial class frmReTatCaXe
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dts_TatCaXe = new QuanLyXeVaXe.Dts_TatCaXe();
            this.tb_LaiXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_LaiXeTableAdapter = new QuanLyXeVaXe.Dts_TatCaXeTableAdapters.tb_LaiXeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dts_TatCaXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_LaiXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Dts_TatCaXe_tb_LaiXe";
            reportDataSource1.Value = this.tb_LaiXeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyXeVaXe.RptTatCaXe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 645);
            this.reportViewer1.TabIndex = 0;
            // 
            // Dts_TatCaXe
            // 
            this.Dts_TatCaXe.DataSetName = "Dts_TatCaXe";
            this.Dts_TatCaXe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_LaiXeBindingSource
            // 
            this.tb_LaiXeBindingSource.DataMember = "tb_LaiXe";
            this.tb_LaiXeBindingSource.DataSource = this.Dts_TatCaXe;
            // 
            // tb_LaiXeTableAdapter
            // 
            this.tb_LaiXeTableAdapter.ClearBeforeFill = true;
            // 
            // frmReTatCaXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 645);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReTatCaXe";
            this.Text = "frmReTatCaXe";
            this.Load += new System.EventHandler(this.frmReTatCaXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dts_TatCaXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_LaiXeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_LaiXeBindingSource;
        private Dts_TatCaXe Dts_TatCaXe;
        private QuanLyXeVaXe.Dts_TatCaXeTableAdapters.tb_LaiXeTableAdapter tb_LaiXeTableAdapter;
    }
}