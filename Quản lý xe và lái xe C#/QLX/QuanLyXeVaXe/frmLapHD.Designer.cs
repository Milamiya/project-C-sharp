namespace QuanLyXeVaXe
{
    partial class frmLapHD
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.tb_KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.DataSet1_LapHD = new QuanLyXeVaXe.DataSet1_LapHD();
            //this.tb_KhachHangTableAdapter = new QuanLyXeVaXe.DataSet1_LapHDTableAdapters.tb_KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhachHangBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.DataSet1_LapHD)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1_LapHD_tb_KhachHang";
            reportDataSource1.Value = this.tb_KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyXeVaXe.Re_LapHD6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1051, 572);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tim Kiem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(477, 29);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(100, 20);
            this.txtmakh.TabIndex = 2;
            // 
            // tb_KhachHangBindingSource
            // 
            this.tb_KhachHangBindingSource.DataMember = "tb_KhachHang";
           // this.tb_KhachHangBindingSource.DataSource = this.DataSet1_LapHD;
            // 
            // DataSet1_LapHD
            // 
           // this.DataSet1_LapHD.DataSetName = "DataSet1_LapHD";
            //this.DataSet1_LapHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_KhachHangTableAdapter
            // 
            //this.tb_KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmLapHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 675);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmLapHD";
            this.Text = "frmLapHD";
            this.Load += new System.EventHandler(this.frmLapHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_KhachHangBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.DataSet1_LapHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_KhachHangBindingSource;
       // private DataSet1_LapHD DataSet1_LapHD;
       // private QuanLyXeVaXe.DataSet1_LapHDTableAdapters.tb_KhachHangTableAdapter tb_KhachHangTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmakh;
    }
}