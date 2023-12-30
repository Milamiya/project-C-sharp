namespace QLPKT
{
    partial class Changepass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changepass));
            this.error2 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.buttom_cancel = new System.Windows.Forms.PictureBox();
            this.buttom_change = new System.Windows.Forms.PictureBox();
            this.passcode = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.error3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_change)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(564, 94);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(0, 13);
            this.error2.TabIndex = 8;
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(564, 53);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(0, 13);
            this.error1.TabIndex = 1;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(288, 198);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 0;
            // 
            // buttom_cancel
            // 
            this.buttom_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_cancel.BackgroundImage")));
            this.buttom_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_cancel.Location = new System.Drawing.Point(419, 156);
            this.buttom_cancel.Name = "buttom_cancel";
            this.buttom_cancel.Size = new System.Drawing.Size(100, 35);
            this.buttom_cancel.TabIndex = 6;
            this.buttom_cancel.TabStop = false;
            // 
            // buttom_change
            // 
            this.buttom_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_change.BackgroundImage")));
            this.buttom_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_change.Location = new System.Drawing.Point(288, 156);
            this.buttom_change.Name = "buttom_change";
            this.buttom_change.Size = new System.Drawing.Size(100, 35);
            this.buttom_change.TabIndex = 5;
            this.buttom_change.TabStop = false;
            this.buttom_change.Click += new System.EventHandler(this.buttom_change_Click);
            // 
            // passcode
            // 
            this.passcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passcode.ForeColor = System.Drawing.Color.Black;
            this.passcode.Location = new System.Drawing.Point(147, 69);
            this.passcode.Name = "passcode";
            this.passcode.PasswordChar = '*';
            this.passcode.Size = new System.Drawing.Size(183, 22);
            this.passcode.TabIndex = 2;
            this.passcode.Leave += new System.EventHandler(this.passcode_TextChanged);
            // 
            // newpass
            // 
            this.newpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.ForeColor = System.Drawing.Color.Black;
            this.newpass.Location = new System.Drawing.Point(567, 29);
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(167, 22);
            this.newpass.TabIndex = 3;
            this.newpass.TextChanged += new System.EventHandler(this.newpass_TextChanged);
            // 
            // confirmpass
            // 
            this.confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpass.ForeColor = System.Drawing.Color.Black;
            this.confirmpass.Location = new System.Drawing.Point(567, 69);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.PasswordChar = '*';
            this.confirmpass.Size = new System.Drawing.Size(167, 22);
            this.confirmpass.TabIndex = 4;
            this.confirmpass.TextChanged += new System.EventHandler(this.confirmpass_TextChanged);
            // 
            // namebox
            // 
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namebox.Enabled = false;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.ForeColor = System.Drawing.Color.Black;
            this.namebox.Location = new System.Drawing.Point(147, 29);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(183, 22);
            this.namebox.TabIndex = 1;
            this.namebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(379, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comfirm new password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(379, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "New password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.error3);
            this.groupBox1.Controls.Add(this.passcode);
            this.groupBox1.Controls.Add(this.error2);
            this.groupBox1.Controls.Add(this.confirmpass);
            this.groupBox1.Controls.Add(this.error1);
            this.groupBox1.Controls.Add(this.newpass);
            this.groupBox1.Controls.Add(this.namebox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(23, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acount";
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error3.ForeColor = System.Drawing.Color.Red;
            this.error3.Location = new System.Drawing.Point(149, 97);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(0, 13);
            this.error3.TabIndex = 9;
            // 
            // Changepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.buttom_cancel);
            this.Controls.Add(this.buttom_change);
            this.Name = "Changepass";
            this.Text = "Changepass";
            this.Load += new System.EventHandler(this.Changepass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_change)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passcode;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttom_cancel;
        private System.Windows.Forms.PictureBox buttom_change;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label error3;
    }
}