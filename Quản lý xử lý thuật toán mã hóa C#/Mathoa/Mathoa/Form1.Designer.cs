namespace Mathoa
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open1 = new System.Windows.Forms.OpenFileDialog();
            this.save1 = new System.Windows.Forms.SaveFileDialog();
            this.icon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Rt1 = new System.Windows.Forms.RichTextBox();
            this.btkiemtra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.btnguon = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Rt2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_mh = new System.Windows.Forms.RadioButton();
            this.RB_GM = new System.Windows.Forms.RadioButton();
            this.FileNguon = new System.Windows.Forms.TextBox();
            this.FileDich = new System.Windows.Forms.TextBox();
            this.BtThucHien = new System.Windows.Forms.Button();
            this.tx_key = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btmh = new System.Windows.Forms.Button();
            this.TxDich = new System.Windows.Forms.TextBox();
            this.TxGoc = new System.Windows.Forms.TextBox();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // open1
            // 
            this.open1.FileName = "openFileDialog1";
            // 
            // save1
            // 
            this.save1.Filter = "des(*.des)|*.des|3des(*3ds)|*.3ds|rc2(*.rc2)|*.rc2";
            this.save1.FilterIndex = 3;
            // 
            // icon1
            // 
            this.icon1.BalloonTipText = "Chương Trình Mã Hóa Demo\r\nNhóm 1 Lớp 07CT113";
            this.icon1.Icon = ((System.Drawing.Icon)(resources.GetObject("icon1.Icon")));
            this.icon1.Text = "Chương Trình Mã Hóa Demo";
            this.icon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icon1_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.ForeColor = System.Drawing.Color.Fuchsia;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Mathoa.Properties.Resources._Untitled;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btthoat);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.Pb1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 635);
            this.panel1.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Mathoa.Properties.Resources.f11;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(598, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 12);
            this.button3.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button3, "Ẩn");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btthoat.BackgroundImage = global::Mathoa.Properties.Resources.ss;
            this.btthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(646, 27);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(31, 31);
            this.btthoat.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btthoat, "Thoát");
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(189, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 393);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::Mathoa.Properties.Resources.f2;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.Rt1);
            this.tabPage2.Controls.Add(this.btkiemtra);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tx1);
            this.tabPage2.Controls.Add(this.btnguon);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiểm tra file";
            // 
            // Rt1
            // 
            this.Rt1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rt1.Location = new System.Drawing.Point(52, 127);
            this.Rt1.Name = "Rt1";
            this.Rt1.ReadOnly = true;
            this.Rt1.Size = new System.Drawing.Size(311, 175);
            this.Rt1.TabIndex = 4;
            this.Rt1.Text = "";
            // 
            // btkiemtra
            // 
            this.btkiemtra.BackgroundImage = global::Mathoa.Properties.Resources.f11;
            this.btkiemtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btkiemtra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkiemtra.Location = new System.Drawing.Point(99, 77);
            this.btkiemtra.Name = "btkiemtra";
            this.btkiemtra.Size = new System.Drawing.Size(100, 35);
            this.btkiemtra.TabIndex = 3;
            this.btkiemtra.Text = "Kiểm tra";
            this.btkiemtra.UseVisualStyleBackColor = true;
            this.btkiemtra.Click += new System.EventHandler(this.btkiemtra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "File vào";
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(99, 47);
            this.tx1.Name = "tx1";
            this.tx1.ReadOnly = true;
            this.tx1.Size = new System.Drawing.Size(247, 20);
            this.tx1.TabIndex = 1;
            // 
            // btnguon
            // 
            this.btnguon.BackgroundImage = global::Mathoa.Properties.Resources.f11;
            this.btnguon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguon.Location = new System.Drawing.Point(352, 45);
            this.btnguon.Name = "btnguon";
            this.btnguon.Size = new System.Drawing.Size(35, 23);
            this.btnguon.TabIndex = 0;
            this.btnguon.Text = "...";
            this.btnguon.UseVisualStyleBackColor = true;
            this.btnguon.Click += new System.EventHandler(this.btnguon_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::Mathoa.Properties.Resources.f2;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.Rt2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.FileNguon);
            this.tabPage1.Controls.Add(this.FileDich);
            this.tabPage1.Controls.Add(this.BtThucHien);
            this.tabPage1.Controls.Add(this.tx_key);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mã hóa file";
            // 
            // Rt2
            // 
            this.Rt2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rt2.Location = new System.Drawing.Point(38, 236);
            this.Rt2.Name = "Rt2";
            this.Rt2.ReadOnly = true;
            this.Rt2.Size = new System.Drawing.Size(365, 97);
            this.Rt2.TabIndex = 18;
            this.Rt2.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_mh);
            this.groupBox1.Controls.Add(this.RB_GM);
            this.groupBox1.Location = new System.Drawing.Point(62, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 52);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ";
            // 
            // RB_mh
            // 
            this.RB_mh.AutoSize = true;
            this.RB_mh.Location = new System.Drawing.Point(31, 20);
            this.RB_mh.Name = "RB_mh";
            this.RB_mh.Size = new System.Drawing.Size(63, 17);
            this.RB_mh.TabIndex = 15;
            this.RB_mh.TabStop = true;
            this.RB_mh.Text = "Mã Hóa";
            this.RB_mh.UseVisualStyleBackColor = true;
            // 
            // RB_GM
            // 
            this.RB_GM.AutoSize = true;
            this.RB_GM.Location = new System.Drawing.Point(153, 19);
            this.RB_GM.Name = "RB_GM";
            this.RB_GM.Size = new System.Drawing.Size(61, 17);
            this.RB_GM.TabIndex = 16;
            this.RB_GM.TabStop = true;
            this.RB_GM.Text = "Giải Mã";
            this.RB_GM.UseVisualStyleBackColor = true;
            // 
            // FileNguon
            // 
            this.FileNguon.Location = new System.Drawing.Point(152, 100);
            this.FileNguon.Multiline = true;
            this.FileNguon.Name = "FileNguon";
            this.FileNguon.ReadOnly = true;
            this.FileNguon.Size = new System.Drawing.Size(205, 41);
            this.FileNguon.TabIndex = 0;
            // 
            // FileDich
            // 
            this.FileDich.Location = new System.Drawing.Point(152, 147);
            this.FileDich.Multiline = true;
            this.FileDich.Name = "FileDich";
            this.FileDich.ReadOnly = true;
            this.FileDich.Size = new System.Drawing.Size(205, 41);
            this.FileDich.TabIndex = 11;
            // 
            // BtThucHien
            // 
            this.BtThucHien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtThucHien.BackgroundImage")));
            this.BtThucHien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtThucHien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtThucHien.Location = new System.Drawing.Point(270, 198);
            this.BtThucHien.Name = "BtThucHien";
            this.BtThucHien.Size = new System.Drawing.Size(87, 32);
            this.BtThucHien.TabIndex = 10;
            this.BtThucHien.Text = "Thực hiện";
            this.BtThucHien.UseVisualStyleBackColor = true;
            this.BtThucHien.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tx_key
            // 
            this.tx_key.Location = new System.Drawing.Point(152, 200);
            this.tx_key.Name = "tx_key";
            this.tx_key.PasswordChar = '*';
            this.tx_key.Size = new System.Drawing.Size(54, 20);
            this.tx_key.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(363, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn file nguồn";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lưu tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.BackgroundImage = global::Mathoa.Properties.Resources.f2;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.btmh);
            this.tabPage3.Controls.Add(this.TxDich);
            this.tabPage3.Controls.Add(this.TxGoc);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(443, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mã hóa chuỗi";
            // 
            // btmh
            // 
            this.btmh.BackgroundImage = global::Mathoa.Properties.Resources.f11;
            this.btmh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmh.Enabled = false;
            this.btmh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmh.Location = new System.Drawing.Point(312, 96);
            this.btmh.Name = "btmh";
            this.btmh.Size = new System.Drawing.Size(88, 32);
            this.btmh.TabIndex = 2;
            this.btmh.Text = "Mã hóa";
            this.btmh.UseVisualStyleBackColor = true;
            this.btmh.Click += new System.EventHandler(this.btmh_Click);
            // 
            // TxDich
            // 
            this.TxDich.Location = new System.Drawing.Point(50, 145);
            this.TxDich.Multiline = true;
            this.TxDich.Name = "TxDich";
            this.TxDich.ReadOnly = true;
            this.TxDich.Size = new System.Drawing.Size(335, 186);
            this.TxDich.TabIndex = 1;
            // 
            // TxGoc
            // 
            this.TxGoc.BackColor = System.Drawing.Color.White;
            this.TxGoc.Location = new System.Drawing.Point(50, 34);
            this.TxGoc.Multiline = true;
            this.TxGoc.Name = "TxGoc";
            this.TxGoc.Size = new System.Drawing.Size(335, 56);
            this.TxGoc.TabIndex = 0;
            this.TxGoc.TextChanged += new System.EventHandler(this.TxGoc_TextChanged);
            // 
            // Pb1
            // 
            this.Pb1.Location = new System.Drawing.Point(0, 0);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(183, 516);
            this.Pb1.TabIndex = 21;
            this.Pb1.TabStop = false;
            this.toolTip1.SetToolTip(this.Pb1, "Di Chuyển");
            this.Pb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb1_MouseDown);
            this.Pb1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pb1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(689, 635);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog open1;
        private System.Windows.Forms.SaveFileDialog save1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox Rt1;
        private System.Windows.Forms.Button btkiemtra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.Button btnguon;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox Rt2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_mh;
        private System.Windows.Forms.RadioButton RB_GM;
        private System.Windows.Forms.TextBox FileNguon;
        private System.Windows.Forms.TextBox FileDich;
        private System.Windows.Forms.Button BtThucHien;
        private System.Windows.Forms.TextBox tx_key;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btmh;
        private System.Windows.Forms.TextBox TxDich;
        private System.Windows.Forms.TextBox TxGoc;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NotifyIcon icon1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

