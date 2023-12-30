namespace QuanLyThuVien
{
    partial class frmInPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInPhieuMuon));
            this.crpt1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpt1
            // 
            this.crpt1.ActiveViewIndex = -1;
            this.crpt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpt1.Location = new System.Drawing.Point(0, 0);
            this.crpt1.Name = "crpt1";
            this.crpt1.SelectionFormula = "";
            this.crpt1.Size = new System.Drawing.Size(680, 442);
            this.crpt1.TabIndex = 0;
            this.crpt1.ViewTimeSelectionFormula = "";
            // 
            // frmInPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 442);
            this.Controls.Add(this.crpt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Phiếu Mượn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInPhieuMuon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt1;

    }
}