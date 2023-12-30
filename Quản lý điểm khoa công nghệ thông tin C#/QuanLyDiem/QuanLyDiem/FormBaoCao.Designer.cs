namespace QuanLyDiem
{
    partial class FormBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCao));
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.crvHocKyHocPhan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Red;
            this.lblTittle.Location = new System.Drawing.Point(117, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(524, 31);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Báo Cáo Danh Sách Sinh Viên Trong Một Lớp";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(201, 55);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(43, 13);
            this.lblMaLop.TabIndex = 1;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(296, 52);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(121, 21);
            this.cmbMaLop.TabIndex = 2;
            // 
            // btnLoc
            // 
            this.btnLoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoc.BackgroundImage")));
            this.btnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoc.Location = new System.Drawing.Point(458, 46);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(72, 30);
            this.btnLoc.TabIndex = 20;
            this.btnLoc.Text = "      Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // crvHocKyHocPhan
            // 
            this.crvHocKyHocPhan.ActiveViewIndex = -1;
            this.crvHocKyHocPhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHocKyHocPhan.DisplayGroupTree = false;
            this.crvHocKyHocPhan.Location = new System.Drawing.Point(1, 79);
            this.crvHocKyHocPhan.Name = "crvHocKyHocPhan";
            this.crvHocKyHocPhan.SelectionFormula = "";
            this.crvHocKyHocPhan.Size = new System.Drawing.Size(757, 374);
            this.crvHocKyHocPhan.TabIndex = 21;
            this.crvHocKyHocPhan.ViewTimeSelectionFormula = "";
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.crvHocKyHocPhan);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cmbMaLop);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblTittle);
            this.Name = "FormBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Năng Báo Cáo";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Button btnLoc;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHocKyHocPhan;
    }
}