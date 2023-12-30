namespace VietGraph
{
    partial class Graph
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSensitivity = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cartesianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ẩnHiệnKhungLướiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ẩnHiệnBiểuThứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThemBotBieuThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChuThich = new System.Windows.Forms.Label();
            expPlotter = new VietGraph.ExpressionPlotter();
            this.mniThongTinDoThi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGiamDoNhayPolar = new System.Windows.Forms.Button();
            this.btnTangDoNhayPolar = new System.Windows.Forms.Button();
            this.btnLuuDoThi = new System.Windows.Forms.Button();
            this.btnSangPhai = new System.Windows.Forms.Button();
            this.btnThuNhoTrucY = new System.Windows.Forms.Button();
            this.btnSaoChepDoThi = new System.Windows.Forms.Button();
            this.btnSangTrai = new System.Windows.Forms.Button();
            this.btnPhongToTrucY = new System.Windows.Forms.Button();
            this.btnThuNhoTrucX = new System.Windows.Forms.Button();
            this.btnPhongToTrucX = new System.Windows.Forms.Button();
            this.btnThuNho = new System.Windows.Forms.Button();
            this.btnPhongTo = new System.Windows.Forms.Button();
            this.btnXuongDuoi = new System.Windows.Forms.Button();
            this.btnLenTren = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select expressions to view";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.White;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.Red;
            this.lblPosition.Location = new System.Drawing.Point(12, 574);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(141, 16);
            this.lblPosition.TabIndex = 23;
            this.lblPosition.Tag = " ";
            this.lblPosition.Text = "Vị trí hiện tại của chuột:";
            // 
            // lblSensitivity
            // 
            this.lblSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSensitivity.AutoSize = true;
            this.lblSensitivity.BackColor = System.Drawing.Color.White;
            this.lblSensitivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensitivity.ForeColor = System.Drawing.Color.Red;
            this.lblSensitivity.Location = new System.Drawing.Point(488, 9);
            this.lblSensitivity.Name = "lblSensitivity";
            this.lblSensitivity.Size = new System.Drawing.Size(94, 16);
            this.lblSensitivity.TabIndex = 24;
            this.lblSensitivity.Text = "Độ nhạy polar:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartesianToolStripMenuItem,
            this.polarToolStripMenuItem,
            this.ẩnHiệnKhungLướiToolStripMenuItem,
            this.ẩnHiệnBiểuThứcToolStripMenuItem,
            this.mniThemBotBieuThuc,
            this.mniThongTinDoThi,
            this.thoátToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 180);
            // 
            // cartesianToolStripMenuItem
            // 
            this.cartesianToolStripMenuItem.Name = "cartesianToolStripMenuItem";
            this.cartesianToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cartesianToolStripMenuItem.Text = "Cartesian";
            this.cartesianToolStripMenuItem.Click += new System.EventHandler(this.cartesianToolStripMenuItem_Click);
            // 
            // polarToolStripMenuItem
            // 
            this.polarToolStripMenuItem.Name = "polarToolStripMenuItem";
            this.polarToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.polarToolStripMenuItem.Text = "Polar";
            this.polarToolStripMenuItem.Click += new System.EventHandler(this.polarToolStripMenuItem_Click);
            // 
            // ẩnHiệnKhungLướiToolStripMenuItem
            // 
            this.ẩnHiệnKhungLướiToolStripMenuItem.Name = "ẩnHiệnKhungLướiToolStripMenuItem";
            this.ẩnHiệnKhungLướiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ẩnHiệnKhungLướiToolStripMenuItem.Text = "Ẩn hiện khung lưới";
            this.ẩnHiệnKhungLướiToolStripMenuItem.Click += new System.EventHandler(this.ẩnHiệnKhungLướiToolStripMenuItem_Click);
            // 
            // ẩnHiệnBiểuThứcToolStripMenuItem
            // 
            this.ẩnHiệnBiểuThứcToolStripMenuItem.Name = "ẩnHiệnBiểuThứcToolStripMenuItem";
            this.ẩnHiệnBiểuThứcToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ẩnHiệnBiểuThứcToolStripMenuItem.Text = "Ẩn hiện biểu thức";
            this.ẩnHiệnBiểuThứcToolStripMenuItem.Click += new System.EventHandler(this.ẩnHiệnBiểuThứcToolStripMenuItem_Click);
            // 
            // mniThemBotBieuThuc
            // 
            this.mniThemBotBieuThuc.Name = "mniThemBotBieuThuc";
            this.mniThemBotBieuThuc.Size = new System.Drawing.Size(178, 22);
            this.mniThemBotBieuThuc.Text = "Thêm bớt biểu thức";
            this.mniThemBotBieuThuc.Click += new System.EventHandler(this.mniThemBotBieuThuc_Click);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // lblChuThich
            // 
            this.lblChuThich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChuThich.AutoSize = true;
            this.lblChuThich.BackColor = System.Drawing.Color.White;
            this.lblChuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuThich.ForeColor = System.Drawing.Color.Red;
            this.lblChuThich.Location = new System.Drawing.Point(375, 574);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(175, 16);
            this.lblChuThich.TabIndex = 39;
            this.lblChuThich.Tag = " ";
            this.lblChuThich.Text = "Hãy kích chuột phải để thoát";
            this.lblChuThich.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // expPlotter
            // 
            expPlotter.ContextMenuStrip = this.contextMenuStrip1;
            expPlotter.DisplayText = true;
            expPlotter.DivisionsX = 8;
            expPlotter.DivisionsY = 8;
            expPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
            expPlotter.ForwardX = 0;
            expPlotter.ForwardY = 0;
            expPlotter.GraphMode = VietGraph.GraphMode.Rectangular;
            expPlotter.Grids = false;
            expPlotter.Location = new System.Drawing.Point(0, 0);
            expPlotter.Name = "expPlotter";
            expPlotter.PenWidth = 1;
            expPlotter.PolarSensitivity = 100;
            expPlotter.PrintStepX = 1;
            expPlotter.PrintStepY = 1;
            expPlotter.ScaleX = 8;
            expPlotter.ScaleY = 8;
            expPlotter.Size = new System.Drawing.Size(685, 599);
            expPlotter.TabIndex = 0;
            expPlotter.Text = "expressionPlotter1";
            expPlotter.Click += new System.EventHandler(expPlotter_Click);
            expPlotter.MouseMove += new System.Windows.Forms.MouseEventHandler(expPlotter_MouseMove);
            // 
            // mniThongTinDoThi
            // 
            this.mniThongTinDoThi.Name = "mniThongTinDoThi";
            this.mniThongTinDoThi.Size = new System.Drawing.Size(178, 22);
            this.mniThongTinDoThi.Text = "Thông tin đồ thị";
            this.mniThongTinDoThi.Click += new System.EventHandler(this.mniThongTinDoThi_Click);
            // 
            // btnGiamDoNhayPolar
            // 
            this.btnGiamDoNhayPolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiamDoNhayPolar.BackColor = System.Drawing.Color.White;
            this.btnGiamDoNhayPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiamDoNhayPolar.Image = global::VietGraph.Properties.Resources.polarDown;
            this.btnGiamDoNhayPolar.Location = new System.Drawing.Point(637, 378);
            this.btnGiamDoNhayPolar.Name = "btnGiamDoNhayPolar";
            this.btnGiamDoNhayPolar.Size = new System.Drawing.Size(36, 36);
            this.btnGiamDoNhayPolar.TabIndex = 38;
            this.btnGiamDoNhayPolar.UseVisualStyleBackColor = false;
            this.btnGiamDoNhayPolar.Click += new System.EventHandler(this.btnGiamDoNhayPolar_Click);
            this.btnGiamDoNhayPolar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGiamDoNhayPolar_MouseMove);
            // 
            // btnTangDoNhayPolar
            // 
            this.btnTangDoNhayPolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTangDoNhayPolar.BackColor = System.Drawing.Color.White;
            this.btnTangDoNhayPolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTangDoNhayPolar.Image = global::VietGraph.Properties.Resources.polarup;
            this.btnTangDoNhayPolar.Location = new System.Drawing.Point(637, 336);
            this.btnTangDoNhayPolar.Name = "btnTangDoNhayPolar";
            this.btnTangDoNhayPolar.Size = new System.Drawing.Size(36, 36);
            this.btnTangDoNhayPolar.TabIndex = 37;
            this.btnTangDoNhayPolar.UseVisualStyleBackColor = false;
            this.btnTangDoNhayPolar.Click += new System.EventHandler(this.btnTangDoNhayPolar_Click);
            this.btnTangDoNhayPolar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTangDoNhayPolar_MouseMove);
            // 
            // btnLuuDoThi
            // 
            this.btnLuuDoThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuDoThi.BackColor = System.Drawing.Color.White;
            this.btnLuuDoThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDoThi.Image = global::VietGraph.Properties.Resources.disk;
            this.btnLuuDoThi.Location = new System.Drawing.Point(637, 0);
            this.btnLuuDoThi.Name = "btnLuuDoThi";
            this.btnLuuDoThi.Size = new System.Drawing.Size(36, 36);
            this.btnLuuDoThi.TabIndex = 36;
            this.btnLuuDoThi.Tag = "";
            this.btnLuuDoThi.UseVisualStyleBackColor = false;
            this.btnLuuDoThi.Click += new System.EventHandler(this.btnLuuDoThi_Click);
            this.btnLuuDoThi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLuuDoThi_MouseMove);
            // 
            // btnSangPhai
            // 
            this.btnSangPhai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSangPhai.BackColor = System.Drawing.Color.White;
            this.btnSangPhai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSangPhai.Image = global::VietGraph.Properties.Resources.right;
            this.btnSangPhai.Location = new System.Drawing.Point(637, 508);
            this.btnSangPhai.Name = "btnSangPhai";
            this.btnSangPhai.Size = new System.Drawing.Size(36, 36);
            this.btnSangPhai.TabIndex = 25;
            this.btnSangPhai.UseVisualStyleBackColor = false;
            this.btnSangPhai.Click += new System.EventHandler(this.btnSangPhai_Click);
            this.btnSangPhai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSangPhai_MouseMove);
            // 
            // btnThuNhoTrucY
            // 
            this.btnThuNhoTrucY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThuNhoTrucY.BackColor = System.Drawing.Color.White;
            this.btnThuNhoTrucY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuNhoTrucY.Image = global::VietGraph.Properties.Resources.ZoomOut_Y;
            this.btnThuNhoTrucY.Location = new System.Drawing.Point(637, 294);
            this.btnThuNhoTrucY.Name = "btnThuNhoTrucY";
            this.btnThuNhoTrucY.Size = new System.Drawing.Size(36, 36);
            this.btnThuNhoTrucY.TabIndex = 34;
            this.btnThuNhoTrucY.UseVisualStyleBackColor = false;
            this.btnThuNhoTrucY.Click += new System.EventHandler(this.btnThuNhoTrucY_Click);
            this.btnThuNhoTrucY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnThuNhoTrucY_MouseMove);
            // 
            // btnSaoChepDoThi
            // 
            this.btnSaoChepDoThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaoChepDoThi.BackColor = System.Drawing.Color.White;
            this.btnSaoChepDoThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaoChepDoThi.Image = global::VietGraph.Properties.Resources.copy;
            this.btnSaoChepDoThi.Location = new System.Drawing.Point(637, 42);
            this.btnSaoChepDoThi.Name = "btnSaoChepDoThi";
            this.btnSaoChepDoThi.Size = new System.Drawing.Size(36, 36);
            this.btnSaoChepDoThi.TabIndex = 35;
            this.btnSaoChepDoThi.UseVisualStyleBackColor = false;
            this.btnSaoChepDoThi.Click += new System.EventHandler(this.btnSaoChepDoThi_Click);
            this.btnSaoChepDoThi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSaoChepDoThi_MouseMove);
            // 
            // btnSangTrai
            // 
            this.btnSangTrai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSangTrai.BackColor = System.Drawing.Color.White;
            this.btnSangTrai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSangTrai.Image = global::VietGraph.Properties.Resources.left;
            this.btnSangTrai.Location = new System.Drawing.Point(637, 550);
            this.btnSangTrai.Name = "btnSangTrai";
            this.btnSangTrai.Size = new System.Drawing.Size(36, 36);
            this.btnSangTrai.TabIndex = 27;
            this.btnSangTrai.UseVisualStyleBackColor = false;
            this.btnSangTrai.Click += new System.EventHandler(this.btnSangTrai_Click);
            this.btnSangTrai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSangTrai_MouseMove);
            // 
            // btnPhongToTrucY
            // 
            this.btnPhongToTrucY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhongToTrucY.BackColor = System.Drawing.Color.White;
            this.btnPhongToTrucY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongToTrucY.Image = global::VietGraph.Properties.Resources.Zoomin_Y;
            this.btnPhongToTrucY.Location = new System.Drawing.Point(637, 252);
            this.btnPhongToTrucY.Name = "btnPhongToTrucY";
            this.btnPhongToTrucY.Size = new System.Drawing.Size(36, 36);
            this.btnPhongToTrucY.TabIndex = 33;
            this.btnPhongToTrucY.UseVisualStyleBackColor = false;
            this.btnPhongToTrucY.Click += new System.EventHandler(this.btnPhongToTrucY_Click);
            this.btnPhongToTrucY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPhongToTrucY_MouseMove);
            // 
            // btnThuNhoTrucX
            // 
            this.btnThuNhoTrucX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThuNhoTrucX.BackColor = System.Drawing.Color.White;
            this.btnThuNhoTrucX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuNhoTrucX.Image = global::VietGraph.Properties.Resources.ZoomOut_X;
            this.btnThuNhoTrucX.Location = new System.Drawing.Point(637, 210);
            this.btnThuNhoTrucX.Name = "btnThuNhoTrucX";
            this.btnThuNhoTrucX.Size = new System.Drawing.Size(36, 36);
            this.btnThuNhoTrucX.TabIndex = 32;
            this.btnThuNhoTrucX.UseVisualStyleBackColor = false;
            this.btnThuNhoTrucX.Click += new System.EventHandler(this.btnThuNhoTrucX_Click);
            this.btnThuNhoTrucX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnThuNhoTrucX_MouseMove);
            // 
            // btnPhongToTrucX
            // 
            this.btnPhongToTrucX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhongToTrucX.BackColor = System.Drawing.Color.White;
            this.btnPhongToTrucX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongToTrucX.Image = global::VietGraph.Properties.Resources.ZoomIn_X;
            this.btnPhongToTrucX.Location = new System.Drawing.Point(637, 168);
            this.btnPhongToTrucX.Name = "btnPhongToTrucX";
            this.btnPhongToTrucX.Size = new System.Drawing.Size(36, 36);
            this.btnPhongToTrucX.TabIndex = 31;
            this.btnPhongToTrucX.UseVisualStyleBackColor = false;
            this.btnPhongToTrucX.Click += new System.EventHandler(this.btnPhongToTrucX_Click);
            this.btnPhongToTrucX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPhongToTrucX_MouseMove);
            // 
            // btnThuNho
            // 
            this.btnThuNho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThuNho.BackColor = System.Drawing.Color.White;
            this.btnThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuNho.Image = global::VietGraph.Properties.Resources.Zoomout;
            this.btnThuNho.Location = new System.Drawing.Point(637, 126);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(36, 36);
            this.btnThuNho.TabIndex = 30;
            this.btnThuNho.UseVisualStyleBackColor = false;
            this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
            this.btnThuNho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnThuNho_MouseMove);
            // 
            // btnPhongTo
            // 
            this.btnPhongTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhongTo.BackColor = System.Drawing.Color.White;
            this.btnPhongTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongTo.Image = global::VietGraph.Properties.Resources.Zoomin;
            this.btnPhongTo.Location = new System.Drawing.Point(637, 84);
            this.btnPhongTo.Name = "btnPhongTo";
            this.btnPhongTo.Size = new System.Drawing.Size(36, 36);
            this.btnPhongTo.TabIndex = 29;
            this.btnPhongTo.UseVisualStyleBackColor = false;
            this.btnPhongTo.Click += new System.EventHandler(this.btnPhongTo_Click);
            this.btnPhongTo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPhongTo_MouseMove);
            // 
            // btnXuongDuoi
            // 
            this.btnXuongDuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuongDuoi.BackColor = System.Drawing.Color.White;
            this.btnXuongDuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuongDuoi.Image = global::VietGraph.Properties.Resources.down;
            this.btnXuongDuoi.Location = new System.Drawing.Point(637, 468);
            this.btnXuongDuoi.Name = "btnXuongDuoi";
            this.btnXuongDuoi.Size = new System.Drawing.Size(36, 36);
            this.btnXuongDuoi.TabIndex = 26;
            this.btnXuongDuoi.UseVisualStyleBackColor = false;
            this.btnXuongDuoi.Click += new System.EventHandler(this.btnXuongDuoi_Click);
            this.btnXuongDuoi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnXuongDuoi_MouseMove);
            // 
            // btnLenTren
            // 
            this.btnLenTren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLenTren.BackColor = System.Drawing.Color.White;
            this.btnLenTren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLenTren.Image = global::VietGraph.Properties.Resources.up;
            this.btnLenTren.Location = new System.Drawing.Point(637, 426);
            this.btnLenTren.Name = "btnLenTren";
            this.btnLenTren.Size = new System.Drawing.Size(36, 36);
            this.btnLenTren.TabIndex = 28;
            this.btnLenTren.UseVisualStyleBackColor = false;
            this.btnLenTren.Click += new System.EventHandler(this.btnLenTren_Click);
            this.btnLenTren.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLenTren_MouseMove);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 599);
            this.Controls.Add(this.btnGiamDoNhayPolar);
            this.Controls.Add(this.btnTangDoNhayPolar);
            this.Controls.Add(this.btnLuuDoThi);
            this.Controls.Add(this.btnSangPhai);
            this.Controls.Add(this.btnThuNhoTrucY);
            this.Controls.Add(this.btnSaoChepDoThi);
            this.Controls.Add(this.lblChuThich);
            this.Controls.Add(this.btnSangTrai);
            this.Controls.Add(this.btnPhongToTrucY);
            this.Controls.Add(this.btnThuNhoTrucX);
            this.Controls.Add(this.btnPhongToTrucX);
            this.Controls.Add(this.btnThuNho);
            this.Controls.Add(this.btnPhongTo);
            this.Controls.Add(this.btnXuongDuoi);
            this.Controls.Add(this.btnLenTren);
            this.Controls.Add(this.lblSensitivity);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(expPlotter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Graph_Resize);
            this.Load += new System.EventHandler(this.Graph_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSensitivity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cartesianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ẩnHiệnKhungLướiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ẩnHiệnBiểuThứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.Button btnSangPhai;
        private System.Windows.Forms.Button btnSangTrai;
        private System.Windows.Forms.Button btnXuongDuoi;
        private System.Windows.Forms.Button btnLenTren;
        private System.Windows.Forms.Button btnPhongTo;
        private System.Windows.Forms.Button btnThuNho;
        private System.Windows.Forms.Button btnPhongToTrucX;
        private System.Windows.Forms.Button btnThuNhoTrucX;
        private System.Windows.Forms.Button btnPhongToTrucY;
        private System.Windows.Forms.Button btnThuNhoTrucY;
        private System.Windows.Forms.Button btnSaoChepDoThi;
        private System.Windows.Forms.Button btnLuuDoThi;
        private System.Windows.Forms.Button btnTangDoNhayPolar;
        private System.Windows.Forms.Button btnGiamDoNhayPolar;
        private System.Windows.Forms.Label lblChuThich;
        private System.Windows.Forms.ToolStripMenuItem mniThemBotBieuThuc;
        private System.Windows.Forms.ToolStripMenuItem mniThongTinDoThi;
        public static ExpressionPlotter expPlotter;
    }
}