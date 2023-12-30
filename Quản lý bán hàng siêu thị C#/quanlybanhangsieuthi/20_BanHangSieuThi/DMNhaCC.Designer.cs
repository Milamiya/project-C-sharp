namespace _20_BanHangSieuThi
{
    partial class DMNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMNhaCC));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboManhacungcap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTennhacungcap = new System.Windows.Forms.TextBox();
            this.txtManhacungcap = new System.Windows.Forms.TextBox();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTennhacungcap = new System.Windows.Forms.Label();
            this.lblManhacungcap = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.Location = new System.Drawing.Point(300, 497);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 54;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cboManhacungcap
            // 
            this.cboManhacungcap.FormattingEnabled = true;
            this.cboManhacungcap.Location = new System.Drawing.Point(110, 497);
            this.cboManhacungcap.Name = "cboManhacungcap";
            this.cboManhacungcap.Size = new System.Drawing.Size(139, 22);
            this.cboManhacungcap.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 192);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(760, 274);
            this.DataGridView.TabIndex = 51;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.mskDienthoai);
            this.groupBox2.Controls.Add(this.txtDiachi);
            this.groupBox2.Controls.Add(this.txtTennhacungcap);
            this.groupBox2.Controls.Add(this.txtManhacungcap);
            this.groupBox2.Controls.Add(this.lblDienthoai);
            this.groupBox2.Controls.Add(this.lblDiachi);
            this.groupBox2.Controls.Add(this.lblTennhacungcap);
            this.groupBox2.Controls.Add(this.lblManhacungcap);
            this.groupBox2.Location = new System.Drawing.Point(12, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 112);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(541, 61);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(193, 20);
            this.mskDienthoai.TabIndex = 16;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(541, 20);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(193, 20);
            this.txtDiachi.TabIndex = 15;
            // 
            // txtTennhacungcap
            // 
            this.txtTennhacungcap.Location = new System.Drawing.Point(148, 61);
            this.txtTennhacungcap.Name = "txtTennhacungcap";
            this.txtTennhacungcap.Size = new System.Drawing.Size(198, 20);
            this.txtTennhacungcap.TabIndex = 14;
            // 
            // txtManhacungcap
            // 
            this.txtManhacungcap.Location = new System.Drawing.Point(148, 22);
            this.txtManhacungcap.Name = "txtManhacungcap";
            this.txtManhacungcap.Size = new System.Drawing.Size(198, 20);
            this.txtManhacungcap.TabIndex = 13;
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.BackColor = System.Drawing.Color.Transparent;
            this.lblDienthoai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienthoai.Location = new System.Drawing.Point(458, 65);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(73, 16);
            this.lblDienthoai.TabIndex = 12;
            this.lblDienthoai.Text = "Điện thoại";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiachi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(458, 23);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(52, 16);
            this.lblDiachi.TabIndex = 11;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTennhacungcap
            // 
            this.lblTennhacungcap.AutoSize = true;
            this.lblTennhacungcap.BackColor = System.Drawing.Color.Transparent;
            this.lblTennhacungcap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennhacungcap.Location = new System.Drawing.Point(17, 65);
            this.lblTennhacungcap.Name = "lblTennhacungcap";
            this.lblTennhacungcap.Size = new System.Drawing.Size(122, 16);
            this.lblTennhacungcap.TabIndex = 10;
            this.lblTennhacungcap.Text = "Tên nhà cung cấp";
            // 
            // lblManhacungcap
            // 
            this.lblManhacungcap.AutoSize = true;
            this.lblManhacungcap.BackColor = System.Drawing.Color.Transparent;
            this.lblManhacungcap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhacungcap.Location = new System.Drawing.Point(17, 25);
            this.lblManhacungcap.Name = "lblManhacungcap";
            this.lblManhacungcap.Size = new System.Drawing.Size(117, 16);
            this.lblManhacungcap.TabIndex = 9;
            this.lblManhacungcap.Text = "Mã nhà cung cấp";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator1,
            this.btnSua,
            this.toolStripSeparator2,
            this.btnXoa,
            this.toolStripSeparator3,
            this.btnBoqua,
            this.toolStripSeparator4,
            this.btnLuu});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 537);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator1.TabIndex = 50;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 22);
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 22);
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 22);
            this.btnXoa.Text = "Xóa Dữ Liệu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoqua.Image")));
            this.btnBoqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(118, 22);
            this.btnBoqua.Text = "Bỏ Qua Thao Tác";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 22);
            this.btnLuu.Text = "Lưu Dữ Liệu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // DMNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboManhacungcap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Name = "DMNhaCC";
            this.Text = "Danh mục nhà cung cấp";
            this.Load += new System.EventHandler(this.DMNhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboManhacungcap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTennhacungcap;
        private System.Windows.Forms.TextBox txtManhacungcap;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTennhacungcap;
        private System.Windows.Forms.Label lblManhacungcap;
    }
}