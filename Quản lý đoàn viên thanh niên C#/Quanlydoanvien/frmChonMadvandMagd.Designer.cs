namespace Quanlydoanvien
{
    partial class frmChonMadvandMagd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonMadvandMagd));
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtmagd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgchon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtmadv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnchon = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            ((System.ComponentModel.ISupportInitialize)(this.dgchon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(13, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(118, 18);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Mã gia đình được chọn";
            // 
            // txtmagd
            // 
            // 
            // 
            // 
            this.txtmagd.Border.Class = "TextBoxBorder";
            this.txtmagd.Location = new System.Drawing.Point(137, 43);
            this.txtmagd.Name = "txtmagd";
            this.txtmagd.ReadOnly = true;
            this.txtmagd.Size = new System.Drawing.Size(100, 20);
            this.txtmagd.TabIndex = 11;
            this.txtmagd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgchon
            // 
            this.dgchon.AllowUserToAddRows = false;
            this.dgchon.AllowUserToDeleteRows = false;
            this.dgchon.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgchon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgchon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgchon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgchon.Location = new System.Drawing.Point(70, 103);
            this.dgchon.Name = "dgchon";
            this.dgchon.ReadOnly = true;
            this.dgchon.Size = new System.Drawing.Size(246, 150);
            this.dgchon.TabIndex = 10;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(13, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(118, 20);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Mã đoàn vên được chọn";
            // 
            // txtmadv
            // 
            // 
            // 
            // 
            this.txtmadv.Border.Class = "TextBoxBorder";
            this.txtmadv.Location = new System.Drawing.Point(137, 17);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.ReadOnly = true;
            this.txtmadv.Size = new System.Drawing.Size(100, 20);
            this.txtmadv.TabIndex = 8;
            this.txtmadv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnchon
            // 
            this.btnchon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnchon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnchon.Location = new System.Drawing.Point(95, 75);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(196, 25);
            this.btnchon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnchon.TabIndex = 7;
            this.btnchon.Text = "Chọn mã đoàn viên và mã gia đình này";
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.balloonTip1.SetBalloonText(this.pictureBox1, "Các các bạn xem mình dập con mèo đen tè le nè!");
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // balloonTip1
            // 
            this.balloonTip1.ShowCloseButton = false;
            // 
            // frmChonMadvandMagd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 255);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtmagd);
            this.Controls.Add(this.dgchon);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.btnchon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChonMadvandMagd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Mã đoàn viên và Mã gia đình";
            this.Load += new System.EventHandler(this.frmChonMadvandMagd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgchon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmagd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgchon;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmadv;
        private DevComponents.DotNetBar.ButtonX btnchon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
    }
}