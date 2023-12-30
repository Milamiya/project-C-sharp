namespace QuanLyDiem
{
    partial class FormHDSD
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
            AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHDSD));
            this.lblTittleHuongDan = new System.Windows.Forms.Label();
            this.lblHuongDan = new System.Windows.Forms.Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 34);
            axWindowsMediaPlayer1.MaximumSize = new System.Drawing.Size(500, 430);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            axWindowsMediaPlayer1.Size = new System.Drawing.Size(486, 383);
            axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // lblTittleHuongDan
            // 
            this.lblTittleHuongDan.AutoSize = true;
            this.lblTittleHuongDan.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittleHuongDan.ForeColor = System.Drawing.Color.Red;
            this.lblTittleHuongDan.Location = new System.Drawing.Point(516, 71);
            this.lblTittleHuongDan.Name = "lblTittleHuongDan";
            this.lblTittleHuongDan.Size = new System.Drawing.Size(243, 31);
            this.lblTittleHuongDan.TabIndex = 1;
            this.lblTittleHuongDan.Text = "Hướng Dẫn Sử Dụng";
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDan.Location = new System.Drawing.Point(518, 123);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(240, 126);
            this.lblHuongDan.TabIndex = 2;
            this.lblHuongDan.Text = "Xin mời xem video hướng dẫn \r\nsử dụng.\r\n\r\nMọi thắc mắc xin liên hệ : \r\nEmail : pn" +
                "phi49@gmail.com\r\nPhone: 0972670046\r\n";
            // 
            // FormHDSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 456);
            this.ControlBox = false;
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.lblTittleHuongDan);
            this.Controls.Add(axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormHDSD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng Dẫn Sử Dụng";
            ((System.ComponentModel.ISupportInitialize)(axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittleHuongDan;
        private System.Windows.Forms.Label lblHuongDan;
    }
}