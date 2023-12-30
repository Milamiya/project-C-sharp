namespace TruyXuatFile
{
    partial class frmWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWord));
            this.label = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenWordDocument = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label.Location = new System.Drawing.Point(24, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 18);
            this.label.TabIndex = 7;
            this.label.Text = "Path";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(229, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 40);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenWordDocument
            // 
            this.btnOpenWordDocument.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenWordDocument.BackgroundImage")));
            this.btnOpenWordDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenWordDocument.Location = new System.Drawing.Point(175, 80);
            this.btnOpenWordDocument.Name = "btnOpenWordDocument";
            this.btnOpenWordDocument.Size = new System.Drawing.Size(48, 40);
            this.btnOpenWordDocument.TabIndex = 10;
            this.btnOpenWordDocument.UseVisualStyleBackColor = true;
            this.btnOpenWordDocument.Click += new System.EventHandler(this.btnOpenWordDocument_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = global::TruyXuatFile.Properties.Resources.OpenFolder;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.Location = new System.Drawing.Point(384, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(50, 31);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPath.Location = new System.Drawing.Point(68, 28);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(310, 30);
            this.txtPath.TabIndex = 13;
            this.txtPath.Text = "Input File Name";
            // 
            // frmWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 150);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenWordDocument);
            this.MaximizeBox = false;
            this.Name = "frmWord";
            this.Text = "CHƯƠNG TRÌNH HỖ TRỢ VIỆC TRUY XUẤT FILE";
            this.Load += new System.EventHandler(this.frmWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenWordDocument;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
    }
}