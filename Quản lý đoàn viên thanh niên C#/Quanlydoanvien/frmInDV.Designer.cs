namespace Quanlydoanvien
{
    partial class frmInDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInDV));
            this.DOANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlydoanvienDataSet = new Quanlydoanvien.quanlydoanvienDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DOANVIENTableAdapter = new Quanlydoanvien.quanlydoanvienDataSetTableAdapters.DOANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DOANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydoanvienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DOANVIENBindingSource
            // 
            this.DOANVIENBindingSource.DataMember = "DOANVIEN";
            this.DOANVIENBindingSource.DataSource = this.quanlydoanvienDataSet;
            // 
            // quanlydoanvienDataSet
            // 
            this.quanlydoanvienDataSet.DataSetName = "quanlydoanvienDataSet";
            this.quanlydoanvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "quanlydoanvienDataSet_DOANVIEN";
            reportDataSource1.Value = this.DOANVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quanlydoanvien.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(850, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // DOANVIENTableAdapter
            // 
            this.DOANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmInDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách tất cả các đoàn viên";
            this.Load += new System.EventHandler(this.frmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DOANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlydoanvienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DOANVIENBindingSource;
        private quanlydoanvienDataSet quanlydoanvienDataSet;
        private Quanlydoanvien.quanlydoanvienDataSetTableAdapters.DOANVIENTableAdapter DOANVIENTableAdapter;
    }
}