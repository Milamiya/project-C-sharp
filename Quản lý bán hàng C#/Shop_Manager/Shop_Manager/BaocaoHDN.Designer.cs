namespace Shop_Manager
{
    partial class frmBaocaoHDN
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
            this.rptHDN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptHDN
            // 
            this.rptHDN.ActiveViewIndex = -1;
            this.rptHDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptHDN.Location = new System.Drawing.Point(0, 0);
            this.rptHDN.Name = "rptHDN";
            this.rptHDN.SelectionFormula = "";
            this.rptHDN.Size = new System.Drawing.Size(688, 352);
            this.rptHDN.TabIndex = 0;
            this.rptHDN.ViewTimeSelectionFormula = "";
            // 
            // frmBaocaoHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 352);
            this.Controls.Add(this.rptHDN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBaocaoHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhập hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaocaoHDN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptHDN;

    }
}