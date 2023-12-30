namespace Doan
{
    partial class Frmhuongdan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhuongdan));
            this.lbhuongdan = new System.Windows.Forms.Label();
            this.lbndhuongdan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbhuongdan
            // 
            this.lbhuongdan.AutoSize = true;
            this.lbhuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhuongdan.Location = new System.Drawing.Point(137, 22);
            this.lbhuongdan.Name = "lbhuongdan";
            this.lbhuongdan.Size = new System.Drawing.Size(179, 24);
            this.lbhuongdan.TabIndex = 0;
            this.lbhuongdan.Text = "Hướng dẫn sử dụng";
            // 
            // lbndhuongdan
            // 
            this.lbndhuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbndhuongdan.Location = new System.Drawing.Point(36, 70);
            this.lbndhuongdan.Name = "lbndhuongdan";
            this.lbndhuongdan.Size = new System.Drawing.Size(407, 178);
            this.lbndhuongdan.TabIndex = 1;
            this.lbndhuongdan.Text = resources.GetString("lbndhuongdan.Text");
            this.lbndhuongdan.Click += new System.EventHandler(this.lbndhuongdan_Click);
            // 
            // Frmhuongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.Controls.Add(this.lbndhuongdan);
            this.Controls.Add(this.lbhuongdan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmhuongdan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmhuongdan";
            this.Click += new System.EventHandler(this.Frmhuongdan_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhuongdan;
        private System.Windows.Forms.Label lbndhuongdan;
    }
}