namespace _20_BanHangSieuThi
{
    partial class DMKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMKhachHang));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.mskDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTennhacungcap = new System.Windows.Forms.Label();
            this.lblManhacungcap = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 191);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(760, 264);
            this.DataGridView.TabIndex = 58;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // mskDienThoai
            // 
            this.mskDienThoai.Location = new System.Drawing.Point(541, 61);
            this.mskDienThoai.Mask = "(999) 000-0000";
            this.mskDienThoai.Name = "mskDienThoai";
            this.mskDienThoai.Size = new System.Drawing.Size(193, 20);
            this.mskDienThoai.TabIndex = 16;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(148, 61);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(198, 20);
            this.txtTenKhach.TabIndex = 14;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(541, 20);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(193, 20);
            this.txtDiaChi.TabIndex = 15;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(148, 22);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(198, 20);
            this.txtMaKhach.TabIndex = 13;
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // btnBoqua
            // 
            this.btnBoqua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoqua.Image")));
            this.btnBoqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(118, 22);
            this.btnBoqua.Text = "Bỏ Qua Thao Tác";
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.mskDienThoai);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtTenKhach);
            this.groupBox2.Controls.Add(this.txtMaKhach);
            this.groupBox2.Controls.Add(this.lblDienthoai);
            this.groupBox2.Controls.Add(this.lblDiachi);
            this.groupBox2.Controls.Add(this.lblTennhacungcap);
            this.groupBox2.Controls.Add(this.lblManhacungcap);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 109);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // lblTennhacungcap
            // 
            this.lblTennhacungcap.AutoSize = true;
            this.lblTennhacungcap.BackColor = System.Drawing.Color.Transparent;
            this.lblTennhacungcap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennhacungcap.Location = new System.Drawing.Point(17, 65);
            this.lblTennhacungcap.Name = "lblTennhacungcap";
            this.lblTennhacungcap.Size = new System.Drawing.Size(114, 16);
            this.lblTennhacungcap.TabIndex = 10;
            this.lblTennhacungcap.Text = "Tên khách hàng:";
            // 
            // lblManhacungcap
            // 
            this.lblManhacungcap.AutoSize = true;
            this.lblManhacungcap.BackColor = System.Drawing.Color.Transparent;
            this.lblManhacungcap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhacungcap.Location = new System.Drawing.Point(17, 25);
            this.lblManhacungcap.Name = "lblManhacungcap";
            this.lblManhacungcap.Size = new System.Drawing.Size(109, 16);
            this.lblManhacungcap.TabIndex = 9;
            this.lblManhacungcap.Text = "Mã khách hàng:";
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 487);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(784, 25);
            this.bindingNavigator1.TabIndex = 57;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(208, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // DMKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Name = "DMKhachHang";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.DMKhachHang_Load);
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

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.MaskedTextBox mskDienThoai;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTennhacungcap;
        private System.Windows.Forms.Label lblManhacungcap;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Label label1;
    }
}