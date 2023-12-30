namespace QLPKT
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.account = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.lgl1 = new System.Windows.Forms.Label();
            this.lgl2 = new System.Windows.Forms.Label();
            this.lgl3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_connect = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.login_buttom = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_buttom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 10);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_connect});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1084, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_connect
            // 
            this.menu_connect.BackColor = System.Drawing.Color.White;
            this.menu_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_connect.ForeColor = System.Drawing.Color.OrangeRed;
            this.menu_connect.Image = ((System.Drawing.Image)(resources.GetObject("menu_connect.Image")));
            this.menu_connect.Name = "menu_connect";
            this.menu_connect.Size = new System.Drawing.Size(225, 54);
            this.menu_connect.Text = "Connection Setting";
            this.menu_connect.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menu_connect.Click += new System.EventHandler(this.menu_connect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 10);
            this.panel2.TabIndex = 2;
            // 
            // account
            // 
            this.account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(745, 271);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(256, 29);
            this.account.TabIndex = 4;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(745, 311);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(256, 29);
            this.pass.TabIndex = 5;
            this.pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_KeyDown);
            // 
            // lgl1
            // 
            this.lgl1.AutoSize = true;
            this.lgl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lgl1.Location = new System.Drawing.Point(738, 187);
            this.lgl1.Name = "lgl1";
            this.lgl1.Size = new System.Drawing.Size(244, 39);
            this.lgl1.TabIndex = 6;
            this.lgl1.Text = "ADMIN LOGIN";
            // 
            // lgl2
            // 
            this.lgl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lgl2.AutoSize = true;
            this.lgl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lgl2.Location = new System.Drawing.Point(627, 276);
            this.lgl2.Name = "lgl2";
            this.lgl2.Size = new System.Drawing.Size(85, 24);
            this.lgl2.TabIndex = 7;
            this.lgl2.Text = "Account:";
            // 
            // lgl3
            // 
            this.lgl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lgl3.AutoSize = true;
            this.lgl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl3.ForeColor = System.Drawing.Color.OrangeRed;
            this.lgl3.Location = new System.Drawing.Point(627, 316);
            this.lgl3.Name = "lgl3";
            this.lgl3.Size = new System.Drawing.Size(97, 24);
            this.lgl3.TabIndex = 8;
            this.lgl3.Text = "Password:";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(864, 374);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 16);
            this.error.TabIndex = 10;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            this.panel_main.Controls.Add(this.panel_connect);
            this.panel_main.Controls.Add(this.logo);
            this.panel_main.Controls.Add(this.error);
            this.panel_main.Controls.Add(this.account);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.login_buttom);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.pass);
            this.panel_main.Controls.Add(this.menuStrip1);
            this.panel_main.Controls.Add(this.lgl3);
            this.panel_main.Controls.Add(this.lgl1);
            this.panel_main.Controls.Add(this.lgl2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1084, 562);
            this.panel_main.TabIndex = 11;
            this.panel_main.MouseHover += new System.EventHandler(this.panel_main_MouseHover);
            // 
            // panel_connect
            // 
            this.panel_connect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_connect.Location = new System.Drawing.Point(578, 148);
            this.panel_connect.Name = "panel_connect";
            this.panel_connect.Size = new System.Drawing.Size(460, 292);
            this.panel_connect.TabIndex = 11;
            this.panel_connect.MouseHover += new System.EventHandler(this.panel_connect_MouseHover);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(67, 148);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(475, 292);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // login_buttom
            // 
            this.login_buttom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.login_buttom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_buttom.BackgroundImage")));
            this.login_buttom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_buttom.Location = new System.Drawing.Point(745, 357);
            this.login_buttom.Name = "login_buttom";
            this.login_buttom.Size = new System.Drawing.Size(104, 33);
            this.login_buttom.TabIndex = 9;
            this.login_buttom.TabStop = false;
            this.login_buttom.Click += new System.EventHandler(this.login_buttom_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.panel_main);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Login_Load);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_buttom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label lgl1;
        private System.Windows.Forms.Label lgl2;
        private System.Windows.Forms.Label lgl3;
        private System.Windows.Forms.PictureBox login_buttom;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.ToolStripMenuItem menu_connect;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_connect;
    }
}