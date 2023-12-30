namespace Chess_Usercontrol
{
    partial class UcChessPiece
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UcChessPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = "UcChessPiece";
            this.Size = new System.Drawing.Size(84, 89);
            this.Load += new System.EventHandler(this.UcChessPiece_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UcChessPiece_Paint);
           
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UcChessPiece_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UcChessPiece_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UcChessPiece_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion


    }
}
