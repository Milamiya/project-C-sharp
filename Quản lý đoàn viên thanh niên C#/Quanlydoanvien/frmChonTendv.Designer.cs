namespace Quanlydoanvien
{
    partial class frmChonTendv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonTendv));
            this.dgchon = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txttendv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnchonten = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgchon)).BeginInit();
            this.SuspendLayout();
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
            this.dgchon.Location = new System.Drawing.Point(69, 92);
            this.dgchon.Name = "dgchon";
            this.dgchon.ReadOnly = true;
            this.dgchon.Size = new System.Drawing.Size(155, 150);
            this.dgchon.TabIndex = 15;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(12, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(128, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Tên đoàn viên được chọn";
            // 
            // txttendv
            // 
            // 
            // 
            // 
            this.txttendv.Border.Class = "TextBoxBorder";
            this.txttendv.Location = new System.Drawing.Point(138, 27);
            this.txttendv.Name = "txttendv";
            this.txttendv.ReadOnly = true;
            this.txttendv.Size = new System.Drawing.Size(100, 20);
            this.txttendv.TabIndex = 13;
            // 
            // btnchonten
            // 
            this.btnchonten.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnchonten.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnchonten.Location = new System.Drawing.Point(73, 54);
            this.btnchonten.Name = "btnchonten";
            this.btnchonten.Size = new System.Drawing.Size(166, 23);
            this.btnchonten.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnchonten.TabIndex = 12;
            this.btnchonten.Text = "Chọn tên đoàn viên này này!";
            this.btnchonten.Click += new System.EventHandler(this.btnchonten_Click);
            // 
            // frmChonTendv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 245);
            this.Controls.Add(this.dgchon);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.btnchonten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChonTendv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn tên đoàn viên";
            this.Load += new System.EventHandler(this.frmChonTendv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgchon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgchon;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttendv;
        private DevComponents.DotNetBar.ButtonX btnchonten;
    }
}