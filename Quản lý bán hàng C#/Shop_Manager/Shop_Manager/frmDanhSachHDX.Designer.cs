namespace Shop_Manager
{
    partial class frmDanhSachHDX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachHDX));
            this.grdView = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.chkListBox = new System.Windows.Forms.CheckedListBox();
            this.btnInHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            this.SuspendLayout();
            // 
            // grdView
            // 
            this.grdView.AllowUserToAddRows = false;
            this.grdView.AllowUserToDeleteRows = false;
            this.grdView.AllowUserToResizeRows = false;
            this.grdView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdView.Location = new System.Drawing.Point(48, 73);
            this.grdView.MultiSelect = false;
            this.grdView.Name = "grdView";
            this.grdView.ReadOnly = true;
            this.grdView.Size = new System.Drawing.Size(573, 204);
            this.grdView.TabIndex = 5;
            this.grdView.CurrentCellChanged += new System.EventHandler(this.grdView_CurrentCellChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(189, 294);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 36);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa (&X)";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(375, 22);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 4;
            this.txtMa.Visible = false;
            // 
            // chkListBox
            // 
            this.chkListBox.CheckOnClick = true;
            this.chkListBox.FormattingEnabled = true;
            this.chkListBox.Location = new System.Drawing.Point(538, 8);
            this.chkListBox.Name = "chkListBox";
            this.chkListBox.Size = new System.Drawing.Size(132, 34);
            this.chkListBox.TabIndex = 3;
            this.chkListBox.SelectedIndexChanged += new System.EventHandler(this.chkListBox_SelectedIndexChanged);
            // 
            // btnInHD
            // 
            this.btnInHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHD.Location = new System.Drawing.Point(343, 294);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(132, 36);
            this.btnInHD.TabIndex = 2;
            this.btnInHD.Text = "In hóa đơn (&I)";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // frmDanhSachHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(694, 352);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.chkListBox);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grdView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDanhSachHDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn xuất";
            this.Load += new System.EventHandler(this.frmDanhSachHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdView;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.CheckedListBox chkListBox;
        private System.Windows.Forms.Button btnInHD;
    }
}