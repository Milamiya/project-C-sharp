namespace Shop_Manager
{
    partial class frmDanhSachPhieuDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachPhieuDatHang));
            this.grdKq = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.chkListBox = new System.Windows.Forms.CheckedListBox();
            this.btnInPhieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdKq)).BeginInit();
            this.SuspendLayout();
            // 
            // grdKq
            // 
            this.grdKq.AllowUserToAddRows = false;
            this.grdKq.AllowUserToDeleteRows = false;
            this.grdKq.AllowUserToResizeRows = false;
            this.grdKq.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdKq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKq.Location = new System.Drawing.Point(59, 80);
            this.grdKq.MultiSelect = false;
            this.grdKq.Name = "grdKq";
            this.grdKq.ReadOnly = true;
            this.grdKq.Size = new System.Drawing.Size(546, 175);
            this.grdKq.TabIndex = 5;
            this.grdKq.CurrentCellChanged += new System.EventHandler(this.grdKq_CurrentCellChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(208, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 35);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa (&X)";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(335, 21);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(64, 20);
            this.txtMa.TabIndex = 4;
            this.txtMa.Visible = false;
            // 
            // chkListBox
            // 
            this.chkListBox.CheckOnClick = true;
            this.chkListBox.FormattingEnabled = true;
            this.chkListBox.Location = new System.Drawing.Point(483, 21);
            this.chkListBox.Name = "chkListBox";
            this.chkListBox.Size = new System.Drawing.Size(132, 34);
            this.chkListBox.TabIndex = 3;
            this.chkListBox.SelectedIndexChanged += new System.EventHandler(this.chkListBox_SelectedIndexChanged);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieu.Image")));
            this.btnInPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInPhieu.Location = new System.Drawing.Point(367, 272);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(108, 35);
            this.btnInPhieu.TabIndex = 2;
            this.btnInPhieu.Text = "In phiếu (&I)";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // frmDanhSachPhieuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(673, 335);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.chkListBox);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grdKq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDanhSachPhieuDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu đặt hàng";
            this.Load += new System.EventHandler(this.frmDanhSachPhieuDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdKq;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.CheckedListBox chkListBox;
        private System.Windows.Forms.Button btnInPhieu;
    }
}