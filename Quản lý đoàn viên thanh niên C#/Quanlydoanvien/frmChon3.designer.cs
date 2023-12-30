namespace Quanlydoanvien
{
    partial class frmChon3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChon3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtsobb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgchon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtmadv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnchon = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgchon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.balloonTip1.SetBalloonCaption(this.pictureBox1, null);
            this.balloonTip1.SetBalloonText(this.pictureBox1, "Các các bạn xem mình dập con mèo đen tè le nè!");
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(29, 50);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(118, 21);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Số biên bản được chọn";
            // 
            // txtsobb
            // 
            // 
            // 
            // 
            this.txtsobb.Border.Class = "TextBoxBorder";
            this.txtsobb.Location = new System.Drawing.Point(155, 51);
            this.txtsobb.Name = "txtsobb";
            this.txtsobb.ReadOnly = true;
            this.txtsobb.Size = new System.Drawing.Size(100, 20);
            this.txtsobb.TabIndex = 18;
            this.txtsobb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dgchon.Location = new System.Drawing.Point(114, 134);
            this.dgchon.Name = "dgchon";
            this.dgchon.ReadOnly = true;
            this.dgchon.Size = new System.Drawing.Size(254, 150);
            this.dgchon.TabIndex = 17;
            // 
            // balloonTip1
            // 
            this.balloonTip1.ShowCloseButton = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(31, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(118, 20);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "Mã đoàn vên được chọn";
            // 
            // txtmadv
            // 
            // 
            // 
            // 
            this.txtmadv.Border.Class = "TextBoxBorder";
            this.txtmadv.Location = new System.Drawing.Point(155, 25);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.ReadOnly = true;
            this.txtmadv.Size = new System.Drawing.Size(100, 20);
            this.txtmadv.TabIndex = 15;
            this.txtmadv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnchon
            // 
            this.btnchon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnchon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnchon.Location = new System.Drawing.Point(143, 100);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(196, 33);
            this.btnchon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnchon.TabIndex = 14;
            this.btnchon.Text = "Chọn mã đoàn viên và số biên bản này!";
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // frmChon3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 284);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtsobb);
            this.Controls.Add(this.dgchon);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.btnchon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChon3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn tổng hợp";
            this.Load += new System.EventHandler(this.frmChon3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgchon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsobb;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgchon;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmadv;
        private DevComponents.DotNetBar.ButtonX btnchon;
    }
}