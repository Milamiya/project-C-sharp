namespace QLPKT
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.authen = new System.Windows.Forms.ComboBox();
            this.database = new System.Windows.Forms.ComboBox();
            this.buttom_cancel = new System.Windows.Forms.PictureBox();
            this.buttom_ok = new System.Windows.Forms.PictureBox();
            this.buttom_test = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label6 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authentication:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Database:";
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(253, 119);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(177, 21);
            this.username.TabIndex = 7;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(253, 153);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(177, 21);
            this.pass.TabIndex = 8;
            // 
            // authen
            // 
            this.authen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authen.FormattingEnabled = true;
            this.authen.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.authen.Location = new System.Drawing.Point(253, 85);
            this.authen.Name = "authen";
            this.authen.Size = new System.Drawing.Size(177, 23);
            this.authen.TabIndex = 9;
            this.authen.SelectedIndexChanged += new System.EventHandler(this.authen_SelectedIndexChanged);
            // 
            // database
            // 
            this.database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database.FormattingEnabled = true;
            this.database.Location = new System.Drawing.Point(253, 220);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(177, 23);
            this.database.TabIndex = 10;
            this.database.SelectedIndexChanged += new System.EventHandler(this.database_SelectedIndexChanged);
            // 
            // buttom_cancel
            // 
            this.buttom_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_cancel.BackgroundImage")));
            this.buttom_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_cancel.Location = new System.Drawing.Point(347, 262);
            this.buttom_cancel.Name = "buttom_cancel";
            this.buttom_cancel.Size = new System.Drawing.Size(83, 25);
            this.buttom_cancel.TabIndex = 16;
            this.buttom_cancel.TabStop = false;
            this.buttom_cancel.Click += new System.EventHandler(this.buttom_cancel_Click);
            // 
            // buttom_ok
            // 
            this.buttom_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_ok.BackgroundImage")));
            this.buttom_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_ok.Location = new System.Drawing.Point(253, 262);
            this.buttom_ok.Name = "buttom_ok";
            this.buttom_ok.Size = new System.Drawing.Size(83, 25);
            this.buttom_ok.TabIndex = 17;
            this.buttom_ok.TabStop = false;
            this.buttom_ok.Click += new System.EventHandler(this.buttom_ok_Click);
            // 
            // buttom_test
            // 
            this.buttom_test.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_test.BackgroundImage")));
            this.buttom_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_test.Location = new System.Drawing.Point(253, 186);
            this.buttom_test.Name = "buttom_test";
            this.buttom_test.Size = new System.Drawing.Size(101, 25);
            this.buttom_test.TabIndex = 18;
            this.buttom_test.TabStop = false;
            this.buttom_test.Click += new System.EventHandler(this.buttom_test_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(449, 296);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 159;
            this.lineShape1.X2 = 430;
            this.lineShape1.Y1 = 252;
            this.lineShape1.Y2 = 252;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(167, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "CONNECTION SETTING";
            // 
            // server
            // 
            this.server.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server.FormattingEnabled = true;
            this.server.Location = new System.Drawing.Point(253, 52);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(177, 23);
            this.server.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 53);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 296);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttom_test);
            this.Controls.Add(this.buttom_ok);
            this.Controls.Add(this.buttom_cancel);
            this.Controls.Add(this.database);
            this.Controls.Add(this.authen);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Connection";
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.ComboBox authen;
        private System.Windows.Forms.ComboBox database;
        private System.Windows.Forms.PictureBox buttom_cancel;
        private System.Windows.Forms.PictureBox buttom_ok;
        private System.Windows.Forms.PictureBox buttom_test;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox server;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}