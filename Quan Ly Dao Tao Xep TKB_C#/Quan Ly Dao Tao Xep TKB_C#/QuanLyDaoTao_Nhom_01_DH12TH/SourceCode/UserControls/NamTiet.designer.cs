namespace QuanLyDaoTao.UserControls
{
    partial class NamTiet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.SuspendLayout();
            // 
            // lblPhong
            // 
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.ForeColor = System.Drawing.Color.Blue;
            this.lblPhong.Location = new System.Drawing.Point(3, 94);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(132, 22);
            this.lblPhong.TabIndex = 7;
            this.lblPhong.Text = "Phòng học";
            this.lblPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(5, 44);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(129, 50);
            this.lblMonHoc.TabIndex = 6;
            this.lblMonHoc.Text = "Môn học";
            this.lblMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.toolTipController1.Appearance.Options.UseFont = true;
            this.toolTipController1.AppearanceTitle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.toolTipController1.AppearanceTitle.Options.UseFont = true;
            this.toolTipController1.AutoPopDelay = 500000;
            this.toolTipController1.InitialDelay = 1;
            this.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // NamTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.lblMonHoc);
            this.Name = "NamTiet";
            this.Size = new System.Drawing.Size(138, 202);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblMonHoc;
        public System.Windows.Forms.Label lblPhong;
        public DevExpress.Utils.ToolTipController toolTipController1;
    }
}
