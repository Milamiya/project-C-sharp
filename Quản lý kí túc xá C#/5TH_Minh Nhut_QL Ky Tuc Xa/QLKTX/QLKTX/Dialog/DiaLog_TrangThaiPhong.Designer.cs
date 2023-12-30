namespace QLKTX.Dialog
{
    partial class DiaLog_TrangThaiPhong
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu_Sua = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu_Them = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnKetThuc = new DevComponents.DotNetBar.ButtonX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.listTrangThaiPhong = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMa = new System.Windows.Forms.ColumnHeader();
            this.colTen = new System.Windows.Forms.ColumnHeader();
            this.groupPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(205, 197);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(193, 32);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Trạng thái Phòng";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLuu_Sua);
            this.groupBox1.Controls.Add(this.btnLuu_Them);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnKetThuc);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.listTrangThaiPhong);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnLuu_Sua
            // 
            this.btnLuu_Sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu_Sua.Location = new System.Drawing.Point(142, 109);
            this.btnLuu_Sua.Name = "btnLuu_Sua";
            this.btnLuu_Sua.Size = new System.Drawing.Size(45, 20);
            this.btnLuu_Sua.TabIndex = 10;
            this.btnLuu_Sua.Text = "Lưu";
            this.btnLuu_Sua.Visible = false;
            this.btnLuu_Sua.Click += new System.EventHandler(this.btnLuu_Sua_Click);
            // 
            // btnLuu_Them
            // 
            this.btnLuu_Them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu_Them.Location = new System.Drawing.Point(142, 83);
            this.btnLuu_Them.Name = "btnLuu_Them";
            this.btnLuu_Them.Size = new System.Drawing.Size(45, 20);
            this.btnLuu_Them.TabIndex = 9;
            this.btnLuu_Them.Text = "Lưu";
            this.btnLuu_Them.Visible = false;
            this.btnLuu_Them.Click += new System.EventHandler(this.btnLuu_Them_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.Location = new System.Drawing.Point(151, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(36, 20);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.Location = new System.Drawing.Point(109, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(36, 20);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Location = new System.Drawing.Point(67, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(36, 20);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKetThuc.Location = new System.Drawing.Point(142, 31);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(45, 20);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(36, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(101, 20);
            this.txtTen.TabIndex = 4;
            // 
            // txtMa
            // 
            // 
            // 
            // 
            this.txtMa.Border.Class = "TextBoxBorder";
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(36, 9);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(26, 20);
            this.txtMa.TabIndex = 3;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(6, 30);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(24, 20);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Tên:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(6, 9);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(24, 20);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mã:";
            // 
            // listTrangThaiPhong
            // 
            this.listTrangThaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.listTrangThaiPhong.Border.Class = "ListViewBorder";
            this.listTrangThaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMa,
            this.colTen});
            this.listTrangThaiPhong.FullRowSelect = true;
            this.listTrangThaiPhong.GridLines = true;
            this.listTrangThaiPhong.Location = new System.Drawing.Point(6, 56);
            this.listTrangThaiPhong.MultiSelect = false;
            this.listTrangThaiPhong.Name = "listTrangThaiPhong";
            this.listTrangThaiPhong.Size = new System.Drawing.Size(181, 94);
            this.listTrangThaiPhong.TabIndex = 0;
            this.listTrangThaiPhong.UseCompatibleStateImageBehavior = false;
            this.listTrangThaiPhong.View = System.Windows.Forms.View.Details;
            this.listTrangThaiPhong.SelectedIndexChanged += new System.EventHandler(this.listTrangThaiPhong_SelectedIndexChanged);
            // 
            // colMa
            // 
            this.colMa.Text = "Mã";
            this.colMa.Width = 43;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            this.colTen.Width = 130;
            // 
            // DiaLog_TrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 197);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiaLog_TrangThaiPhong";
            this.ShowInTaskbar = false;
            this.Text = "DiaLog_TrangThaiPhong";
            this.Load += new System.EventHandler(this.DiaLog_TrangThaiPhong_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ListViewEx listTrangThaiPhong;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnKetThuc;
        private System.Windows.Forms.ColumnHeader colMa;
        private System.Windows.Forms.ColumnHeader colTen;
        private DevComponents.DotNetBar.ButtonX btnLuu_Sua;
        private DevComponents.DotNetBar.ButtonX btnLuu_Them;
    }
}