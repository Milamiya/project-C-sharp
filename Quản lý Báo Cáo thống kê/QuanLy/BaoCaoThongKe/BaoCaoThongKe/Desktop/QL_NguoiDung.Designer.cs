namespace BaoCaoThongKe.Desktop
{
    partial class QL_NguoiDung
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_thoat = new DevComponents.DotNetBar.ButtonX();
            this.BT_DK = new DevComponents.DotNetBar.ButtonX();
            this.CMB_QUYEN = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TXT_RE_PASS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_PASS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.TXT_USERNAME = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelX5);
            this.panel1.Controls.Add(this.button_thoat);
            this.panel1.Controls.Add(this.BT_DK);
            this.panel1.Controls.Add(this.CMB_QUYEN);
            this.panel1.Controls.Add(this.TXT_RE_PASS);
            this.panel1.Controls.Add(this.TXT_PASS);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.TXT_USERNAME);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 377);
            this.panel1.TabIndex = 0;
            // 
            // button_thoat
            // 
            this.button_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.ForeColor = System.Drawing.Color.Blue;
            this.button_thoat.Location = new System.Drawing.Point(248, 287);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(87, 27);
            this.button_thoat.TabIndex = 40;
            this.button_thoat.Text = "Hủy";
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // BT_DK
            // 
            this.BT_DK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BT_DK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BT_DK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DK.ForeColor = System.Drawing.Color.Blue;
            this.BT_DK.Location = new System.Drawing.Point(86, 287);
            this.BT_DK.Name = "BT_DK";
            this.BT_DK.Size = new System.Drawing.Size(87, 27);
            this.BT_DK.TabIndex = 39;
            this.BT_DK.Text = "Đăng Ký";
            this.BT_DK.Click += new System.EventHandler(this.BT_DK_Click);
            // 
            // CMB_QUYEN
            // 
            this.CMB_QUYEN.DisplayMember = "Text";
            this.CMB_QUYEN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMB_QUYEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_QUYEN.ForeColor = System.Drawing.Color.Blue;
            this.CMB_QUYEN.FormattingEnabled = true;
            this.CMB_QUYEN.ItemHeight = 15;
            this.CMB_QUYEN.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CMB_QUYEN.Location = new System.Drawing.Point(206, 231);
            this.CMB_QUYEN.Name = "CMB_QUYEN";
            this.CMB_QUYEN.Size = new System.Drawing.Size(54, 21);
            this.CMB_QUYEN.TabIndex = 38;
            this.CMB_QUYEN.Text = "1";
            // 
            // TXT_RE_PASS
            // 
            // 
            // 
            // 
            this.TXT_RE_PASS.Border.Class = "TextBoxBorder";
            this.TXT_RE_PASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_RE_PASS.ForeColor = System.Drawing.Color.Blue;
            this.TXT_RE_PASS.Location = new System.Drawing.Point(206, 193);
            this.TXT_RE_PASS.Name = "TXT_RE_PASS";
            this.TXT_RE_PASS.PasswordChar = '*';
            this.TXT_RE_PASS.Size = new System.Drawing.Size(167, 21);
            this.TXT_RE_PASS.TabIndex = 37;
            // 
            // TXT_PASS
            // 
            // 
            // 
            // 
            this.TXT_PASS.Border.Class = "TextBoxBorder";
            this.TXT_PASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PASS.ForeColor = System.Drawing.Color.Blue;
            this.TXT_PASS.Location = new System.Drawing.Point(206, 148);
            this.TXT_PASS.Name = "TXT_PASS";
            this.TXT_PASS.PasswordChar = '*';
            this.TXT_PASS.Size = new System.Drawing.Size(167, 21);
            this.TXT_PASS.TabIndex = 36;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(86, 100);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 27);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "Tên Đăng Nhập";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Blue;
            this.labelX4.Location = new System.Drawing.Point(83, 229);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(80, 27);
            this.labelX4.TabIndex = 34;
            this.labelX4.Text = "Chọn Quyền";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Blue;
            this.labelX3.Location = new System.Drawing.Point(84, 190);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(79, 27);
            this.labelX3.TabIndex = 33;
            this.labelX3.Text = "Re-Password";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(86, 145);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 27);
            this.labelX2.TabIndex = 32;
            this.labelX2.Text = "Password";
            // 
            // TXT_USERNAME
            // 
            // 
            // 
            // 
            this.TXT_USERNAME.Border.Class = "TextBoxBorder";
            this.TXT_USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_USERNAME.ForeColor = System.Drawing.Color.Blue;
            this.TXT_USERNAME.Location = new System.Drawing.Point(206, 103);
            this.TXT_USERNAME.Name = "TXT_USERNAME";
            this.TXT_USERNAME.Size = new System.Drawing.Size(167, 21);
            this.TXT_USERNAME.TabIndex = 31;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(126, 29);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 41;
            this.labelX5.Text = "labelX5";
            // 
            // QL_NguoiDung
            // 
            this.AcceptButton = this.BT_DK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 380);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QL_NguoiDung";
            this.Text = "DANG KY NGUOI DUNG";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX button_thoat;
        private DevComponents.DotNetBar.ButtonX BT_DK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CMB_QUYEN;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_RE_PASS;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_PASS;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_USERNAME;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}