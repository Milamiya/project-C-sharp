namespace VietGraph
{
    partial class ThongTinDoThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDoThi));
            this.cbBieuThuc = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.lvXAndFX = new System.Windows.Forms.ListView();
            this.chX = new System.Windows.Forms.ColumnHeader();
            this.chFX = new System.Windows.Forms.ColumnHeader();
            this.btnDong = new System.Windows.Forms.Button();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRadian = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBieuThuc
            // 
            this.cbBieuThuc.FormattingEnabled = true;
            this.cbBieuThuc.Location = new System.Drawing.Point(16, 13);
            this.cbBieuThuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbBieuThuc.Name = "cbBieuThuc";
            this.cbBieuThuc.Size = new System.Drawing.Size(291, 24);
            this.cbBieuThuc.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(315, 13);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(81, 24);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lvXAndFX
            // 
            this.lvXAndFX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chX,
            this.chFX});
            this.lvXAndFX.FullRowSelect = true;
            this.lvXAndFX.GridLines = true;
            this.lvXAndFX.Location = new System.Drawing.Point(16, 45);
            this.lvXAndFX.Margin = new System.Windows.Forms.Padding(4);
            this.lvXAndFX.Name = "lvXAndFX";
            this.lvXAndFX.Size = new System.Drawing.Size(291, 183);
            this.lvXAndFX.TabIndex = 2;
            this.lvXAndFX.UseCompatibleStateImageBehavior = false;
            this.lvXAndFX.View = System.Windows.Forms.View.Details;
            // 
            // chX
            // 
            this.chX.Text = "x";
            this.chX.Width = 94;
            // 
            // chFX
            // 
            this.chFX.Text = "f(x)";
            this.chFX.Width = 189;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(315, 45);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 25);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(6, 21);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(43, 20);
            this.rbDo.TabIndex = 4;
            this.rbDo.TabStop = true;
            this.rbDo.Text = "Độ";
            this.rbDo.UseVisualStyleBackColor = true;
            this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRadian);
            this.groupBox1.Controls.Add(this.rbDo);
            this.groupBox1.Location = new System.Drawing.Point(315, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(81, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbRadian
            // 
            this.rbRadian.AutoSize = true;
            this.rbRadian.Location = new System.Drawing.Point(6, 47);
            this.rbRadian.Name = "rbRadian";
            this.rbRadian.Size = new System.Drawing.Size(70, 20);
            this.rbRadian.TabIndex = 5;
            this.rbRadian.TabStop = true;
            this.rbRadian.Text = "Radian";
            this.rbRadian.UseVisualStyleBackColor = true;
            this.rbRadian.CheckedChanged += new System.EventHandler(this.rbRadian_CheckedChanged);
            // 
            // ThongTinDoThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lvXAndFX);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbBieuThuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ThongTinDoThi";
            this.Text = "Thong Tin Do Thi";
            this.Load += new System.EventHandler(this.ThongTinDoThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBieuThuc;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ListView lvXAndFX;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ColumnHeader chX;
        private System.Windows.Forms.ColumnHeader chFX;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRadian;
    }
}