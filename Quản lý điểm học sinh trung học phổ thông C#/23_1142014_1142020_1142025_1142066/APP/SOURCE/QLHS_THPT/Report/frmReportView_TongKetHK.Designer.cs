namespace QLHS.Report
{
    partial class frmReportView_TongKetHK
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
            this.crystalReportViewerTongKetMonHoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerTongKetMonHoc
            // 
            this.crystalReportViewerTongKetMonHoc.ActiveViewIndex = -1;
            this.crystalReportViewerTongKetMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTongKetMonHoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTongKetMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTongKetMonHoc.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTongKetMonHoc.Name = "crystalReportViewerTongKetMonHoc";
            this.crystalReportViewerTongKetMonHoc.Size = new System.Drawing.Size(984, 362);
            this.crystalReportViewerTongKetMonHoc.TabIndex = 0;
            // 
            // frmReportView_TongKetHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 362);
            this.Controls.Add(this.crystalReportViewerTongKetMonHoc);
            this.Name = "frmReportView_TongKetHK";
            this.Text = "Tổng kết học kỳ";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTongKetMonHoc;

    }
}