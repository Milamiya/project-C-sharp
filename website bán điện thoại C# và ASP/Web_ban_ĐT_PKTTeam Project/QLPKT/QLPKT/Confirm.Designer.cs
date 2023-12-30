namespace QLPKT
{
    partial class Confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm));
            this.account = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.lgl3 = new System.Windows.Forms.Label();
            this.lgl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttom_confirm = new System.Windows.Forms.PictureBox();
            this.buttom_cancel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(148, 50);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(256, 24);
            this.account.TabIndex = 9;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(148, 84);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(256, 24);
            this.pass.TabIndex = 10;
            // 
            // lgl3
            // 
            this.lgl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lgl3.AutoSize = true;
            this.lgl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl3.ForeColor = System.Drawing.Color.Red;
            this.lgl3.Location = new System.Drawing.Point(30, 89);
            this.lgl3.Name = "lgl3";
            this.lgl3.Size = new System.Drawing.Size(79, 18);
            this.lgl3.TabIndex = 12;
            this.lgl3.Text = "Password:";
            // 
            // lgl2
            // 
            this.lgl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lgl2.AutoSize = true;
            this.lgl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgl2.ForeColor = System.Drawing.Color.Red;
            this.lgl2.Location = new System.Drawing.Point(30, 55);
            this.lgl2.Name = "lgl2";
            this.lgl2.Size = new System.Drawing.Size(66, 18);
            this.lgl2.TabIndex = 11;
            this.lgl2.Text = "Account:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bạn phải được xác nhận bởi Master hoặc trưởng phòng thì mới thực hiện được thao t" +
                "ác này.";
            // 
            // buttom_confirm
            // 
            this.buttom_confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_confirm.BackgroundImage")));
            this.buttom_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_confirm.Location = new System.Drawing.Point(148, 120);
            this.buttom_confirm.Name = "buttom_confirm";
            this.buttom_confirm.Size = new System.Drawing.Size(94, 31);
            this.buttom_confirm.TabIndex = 73;
            this.buttom_confirm.TabStop = false;
            this.buttom_confirm.Click += new System.EventHandler(this.buttom_confirm_Click);
            // 
            // buttom_cancel
            // 
            this.buttom_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_cancel.BackgroundImage")));
            this.buttom_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_cancel.Location = new System.Drawing.Point(248, 120);
            this.buttom_cancel.Name = "buttom_cancel";
            this.buttom_cancel.Size = new System.Drawing.Size(92, 31);
            this.buttom_cancel.TabIndex = 74;
            this.buttom_cancel.TabStop = false;
            this.buttom_cancel.Click += new System.EventHandler(this.buttom_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(33, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // error
            // 
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(145, 154);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(259, 19);
            this.error.TabIndex = 76;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 179);
            this.Controls.Add(this.error);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttom_cancel);
            this.Controls.Add(this.buttom_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.account);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.lgl3);
            this.Controls.Add(this.lgl2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirm";
            ((System.ComponentModel.ISupportInitialize)(this.buttom_confirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label lgl3;
        private System.Windows.Forms.Label lgl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttom_confirm;
        private System.Windows.Forms.PictureBox buttom_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label error;
    }
}