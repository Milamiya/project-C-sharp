namespace UIT_Pokemon
{
    partial class KindGameOption
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.EASY = new System.Windows.Forms.RadioButton();
            this.MEDIUM = new System.Windows.Forms.RadioButton();
            this.DIFFICULT = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(25, 154);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(146, 33);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(189, 154);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(146, 33);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // EASY
            // 
            this.EASY.AutoSize = true;
            this.EASY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EASY.ForeColor = System.Drawing.Color.OliveDrab;
            this.EASY.Location = new System.Drawing.Point(25, 31);
            this.EASY.Name = "EASY";
            this.EASY.Size = new System.Drawing.Size(122, 22);
            this.EASY.TabIndex = 2;
            this.EASY.TabStop = true;
            this.EASY.Text = "radioButton1";
            this.EASY.UseVisualStyleBackColor = true;
            // 
            // MEDIUM
            // 
            this.MEDIUM.AutoSize = true;
            this.MEDIUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEDIUM.ForeColor = System.Drawing.Color.OliveDrab;
            this.MEDIUM.Location = new System.Drawing.Point(25, 61);
            this.MEDIUM.Name = "MEDIUM";
            this.MEDIUM.Size = new System.Drawing.Size(122, 22);
            this.MEDIUM.TabIndex = 3;
            this.MEDIUM.TabStop = true;
            this.MEDIUM.Text = "radioButton1";
            this.MEDIUM.UseVisualStyleBackColor = true;
            // 
            // DIFFICULT
            // 
            this.DIFFICULT.AutoSize = true;
            this.DIFFICULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIFFICULT.ForeColor = System.Drawing.Color.OliveDrab;
            this.DIFFICULT.Location = new System.Drawing.Point(25, 91);
            this.DIFFICULT.Name = "DIFFICULT";
            this.DIFFICULT.Size = new System.Drawing.Size(122, 22);
            this.DIFFICULT.TabIndex = 4;
            this.DIFFICULT.TabStop = true;
            this.DIFFICULT.Text = "radioButton1";
            this.DIFFICULT.UseVisualStyleBackColor = true;
            // 
            // KindGameOption
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(370, 220);
            this.Controls.Add(this.DIFFICULT);
            this.Controls.Add(this.MEDIUM);
            this.Controls.Add(this.EASY);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(440, 180);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 220);
            this.Name = "KindGameOption";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kind Game Option";
            this.Load += new System.EventHandler(this.KindGameOption_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.KindGameOption_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RadioButton EASY;
        private System.Windows.Forms.RadioButton MEDIUM;
        private System.Windows.Forms.RadioButton DIFFICULT;
    }
}