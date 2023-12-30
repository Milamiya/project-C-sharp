namespace QLPKT
{
    partial class Customer_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Add));
            this.buttom_clear = new System.Windows.Forms.PictureBox();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.day = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.idcard = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttom_add = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            this.passtextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cofirmtextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Acountbox = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buttom_clear)).BeginInit();
            this.InfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_add)).BeginInit();
            this.Acountbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttom_clear
            // 
            this.buttom_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_clear.BackgroundImage")));
            this.buttom_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_clear.Location = new System.Drawing.Point(628, 172);
            this.buttom_clear.Name = "buttom_clear";
            this.buttom_clear.Size = new System.Drawing.Size(100, 35);
            this.buttom_clear.TabIndex = 58;
            this.buttom_clear.TabStop = false;
            this.buttom_clear.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Controls.Add(this.year);
            this.InfoBox.Controls.Add(this.month);
            this.InfoBox.Controls.Add(this.day);
            this.InfoBox.Controls.Add(this.label2);
            this.InfoBox.Controls.Add(this.sex);
            this.InfoBox.Controls.Add(this.idcard);
            this.InfoBox.Controls.Add(this.add);
            this.InfoBox.Controls.Add(this.email);
            this.InfoBox.Controls.Add(this.phone);
            this.InfoBox.Controls.Add(this.namebox);
            this.InfoBox.Controls.Add(this.label7);
            this.InfoBox.Controls.Add(this.label6);
            this.InfoBox.Controls.Add(this.label5);
            this.InfoBox.Controls.Add(this.label4);
            this.InfoBox.Controls.Add(this.label3);
            this.InfoBox.Controls.Add(this.label1);
            this.InfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.ForeColor = System.Drawing.Color.Red;
            this.InfoBox.Location = new System.Drawing.Point(22, 14);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(791, 135);
            this.InfoBox.TabIndex = 55;
            this.InfoBox.TabStop = false;
            this.InfoBox.Text = "Infomation";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(587, 55);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(58, 24);
            this.year.TabIndex = 54;
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(536, 55);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(39, 24);
            this.month.TabIndex = 53;
            this.month.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // day
            // 
            this.day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.FormattingEnabled = true;
            this.day.Location = new System.Drawing.Point(486, 55);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(39, 24);
            this.day.TabIndex = 52;
            this.day.SelectedIndexChanged += new System.EventHandler(this.day_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(395, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Birthday:";
            // 
            // sex
            // 
            this.sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex.Location = new System.Drawing.Point(454, 88);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(76, 24);
            this.sex.TabIndex = 43;
            // 
            // idcard
            // 
            this.idcard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idcard.Location = new System.Drawing.Point(629, 89);
            this.idcard.Name = "idcard";
            this.idcard.Size = new System.Drawing.Size(119, 22);
            this.idcard.TabIndex = 42;
            this.idcard.TextChanged += new System.EventHandler(this.idcard_TextChanged);
            // 
            // add
            // 
            this.add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(486, 19);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(262, 22);
            this.add.TabIndex = 41;
            this.add.TextChanged += new System.EventHandler(this.add_TextChanged);
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(96, 89);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(251, 22);
            this.email.TabIndex = 39;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(96, 54);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(251, 22);
            this.phone.TabIndex = 38;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // namebox
            // 
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(96, 19);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(251, 22);
            this.namebox.TabIndex = 37;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(553, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID Card:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(394, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sex:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(394, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(18, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // buttom_add
            // 
            this.buttom_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_add.BackgroundImage")));
            this.buttom_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_add.Location = new System.Drawing.Point(508, 172);
            this.buttom_add.Name = "buttom_add";
            this.buttom_add.Size = new System.Drawing.Size(100, 35);
            this.buttom_add.TabIndex = 57;
            this.buttom_add.TabStop = false;
            this.buttom_add.Click += new System.EventHandler(this.buttom_add_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(508, 214);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 59;
            // 
            // passtextbox
            // 
            this.passtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtextbox.Location = new System.Drawing.Point(161, 14);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.Size = new System.Drawing.Size(196, 22);
            this.passtextbox.TabIndex = 35;
            this.passtextbox.TextChanged += new System.EventHandler(this.passtextbox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(18, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Password:";
            // 
            // cofirmtextbox
            // 
            this.cofirmtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cofirmtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofirmtextbox.Location = new System.Drawing.Point(161, 49);
            this.cofirmtextbox.Name = "cofirmtextbox";
            this.cofirmtextbox.Size = new System.Drawing.Size(196, 22);
            this.cofirmtextbox.TabIndex = 37;
            this.cofirmtextbox.TextChanged += new System.EventHandler(this.cofirmtextbox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(18, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Comfirm pasword:";
            // 
            // Acountbox
            // 
            this.Acountbox.Controls.Add(this.label12);
            this.Acountbox.Controls.Add(this.cofirmtextbox);
            this.Acountbox.Controls.Add(this.label11);
            this.Acountbox.Controls.Add(this.passtextbox);
            this.Acountbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acountbox.ForeColor = System.Drawing.Color.Red;
            this.Acountbox.Location = new System.Drawing.Point(22, 158);
            this.Acountbox.Name = "Acountbox";
            this.Acountbox.Size = new System.Drawing.Size(419, 93);
            this.Acountbox.TabIndex = 56;
            this.Acountbox.TabStop = false;
            this.Acountbox.Text = "Acount";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Customer_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.error);
            this.Controls.Add(this.buttom_clear);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.buttom_add);
            this.Controls.Add(this.Acountbox);
            this.Name = "Customer_Add";
            this.Text = "Customer_Add";
            this.Load += new System.EventHandler(this.Customer_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttom_clear)).EndInit();
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_add)).EndInit();
            this.Acountbox.ResumeLayout(false);
            this.Acountbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox buttom_clear;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.TextBox idcard;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttom_add;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox passtextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cofirmtextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Acountbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}