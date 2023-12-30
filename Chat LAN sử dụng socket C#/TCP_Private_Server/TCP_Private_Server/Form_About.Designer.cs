namespace TCP_Private_Server
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_CodeDatabase = new System.Windows.Forms.Label();
            this.pictureBox_About = new System.Windows.Forms.PictureBox();
            this.button_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Location = new System.Drawing.Point(133, 23);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(236, 13);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "label_Title";
            // 
            // label_Version
            // 
            this.label_Version.Location = new System.Drawing.Point(133, 51);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(239, 13);
            this.label_Version.TabIndex = 2;
            this.label_Version.Text = "label_Version";
            // 
            // label_Copyright
            // 
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.Location = new System.Drawing.Point(133, 75);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(79, 13);
            this.label_Copyright.TabIndex = 3;
            this.label_Copyright.Text = "label_Copyright";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(133, 98);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(88, 13);
            this.label_Description.TabIndex = 4;
            this.label_Description.Text = "label_Description";
            // 
            // label_CodeDatabase
            // 
            this.label_CodeDatabase.Location = new System.Drawing.Point(136, 122);
            this.label_CodeDatabase.Name = "label_CodeDatabase";
            this.label_CodeDatabase.Size = new System.Drawing.Size(233, 46);
            this.label_CodeDatabase.TabIndex = 5;
            this.label_CodeDatabase.Text = "label_CodeDatabase";
            // 
            // pictureBox_About
            // 
            this.pictureBox_About.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_About.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_About.Image")));
            this.pictureBox_About.Location = new System.Drawing.Point(13, 23);
            this.pictureBox_About.Name = "pictureBox_About";
            this.pictureBox_About.Size = new System.Drawing.Size(100, 97);
            this.pictureBox_About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_About.TabIndex = 6;
            this.pictureBox_About.TabStop = false;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(294, 192);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 7;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_About
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(381, 227);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.pictureBox_About);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_CodeDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_About";
            this.Load += new System.EventHandler(this.Form_About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Label label_Copyright;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_CodeDatabase;
        private System.Windows.Forms.PictureBox pictureBox_About;
        private System.Windows.Forms.Button button_OK;
    }
}