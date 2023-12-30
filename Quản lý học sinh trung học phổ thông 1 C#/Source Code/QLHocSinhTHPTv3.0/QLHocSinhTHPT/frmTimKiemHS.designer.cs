namespace QLHocSinhTHPT
{
    partial class frmTimKiemHS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemHS));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dGVKetQuaTimKiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorKetQuaTimKiem = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorExitItem = new System.Windows.Forms.ToolStripButton();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cmbTonGiao = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbDanToc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbTheoTGiao = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.col07 = new DevComponents.Editors.ComboItem();
            this.col08 = new DevComponents.Editors.ComboItem();
            this.col09 = new DevComponents.Editors.ComboItem();
            this.cmbTheoDToc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.col04 = new DevComponents.Editors.ComboItem();
            this.col05 = new DevComponents.Editors.ComboItem();
            this.col06 = new DevComponents.Editors.ComboItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTheoNSinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.col01 = new DevComponents.Editors.ComboItem();
            this.col02 = new DevComponents.Editors.ComboItem();
            this.col03 = new DevComponents.Editors.ComboItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoiSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetQuaTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetQuaTimKiem)).BeginInit();
            this.bindingNavigatorKetQuaTimKiem.SuspendLayout();
            this.navPaneLeft.SuspendLayout();
            this.navPanelTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dGVKetQuaTimKiem);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorKetQuaTimKiem);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(185, 0);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(659, 398);
            this.groupBoxDanhSach.TabIndex = 2;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Kết quả tìm kiếm";
            // 
            // dGVKetQuaTimKiem
            // 
            this.dGVKetQuaTimKiem.AllowUserToAddRows = false;
            this.dGVKetQuaTimKiem.AllowUserToDeleteRows = false;
            this.dGVKetQuaTimKiem.AllowUserToResizeColumns = false;
            this.dGVKetQuaTimKiem.AllowUserToResizeRows = false;
            this.dGVKetQuaTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dGVKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVKetQuaTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colNoiSinh,
            this.colTenDanToc,
            this.colTenTonGiao});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVKetQuaTimKiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVKetQuaTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVKetQuaTimKiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dGVKetQuaTimKiem.Location = new System.Drawing.Point(3, 51);
            this.dGVKetQuaTimKiem.Name = "dGVKetQuaTimKiem";
            this.dGVKetQuaTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVKetQuaTimKiem.Size = new System.Drawing.Size(653, 344);
            this.dGVKetQuaTimKiem.TabIndex = 4;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã học sinh";
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaHocSinh.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHoTen.Width = 120;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colGioiTinh.ToolTipText = "Nam: không check; Nữ: check";
            this.colGioiTinh.Width = 50;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNgaySinh.Width = 80;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.DataPropertyName = "NoiSinh";
            this.colNoiSinh.HeaderText = "Nơi sinh";
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNoiSinh.Width = 120;
            // 
            // colTenDanToc
            // 
            this.colTenDanToc.DataPropertyName = "TenDanToc";
            this.colTenDanToc.HeaderText = "Dân tộc";
            this.colTenDanToc.Name = "colTenDanToc";
            this.colTenDanToc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenDanToc.Width = 80;
            // 
            // colTenTonGiao
            // 
            this.colTenTonGiao.DataPropertyName = "TenTonGiao";
            this.colTenTonGiao.HeaderText = "Tôn giáo";
            this.colTenTonGiao.Name = "colTenTonGiao";
            this.colTenTonGiao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenTonGiao.Width = 80;
            // 
            // bindingNavigatorKetQuaTimKiem
            // 
            this.bindingNavigatorKetQuaTimKiem.AddNewItem = null;
            this.bindingNavigatorKetQuaTimKiem.AutoSize = false;
            this.bindingNavigatorKetQuaTimKiem.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorKetQuaTimKiem.CountItemFormat = "của {0}";
            this.bindingNavigatorKetQuaTimKiem.DeleteItem = null;
            this.bindingNavigatorKetQuaTimKiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorExitItem});
            this.bindingNavigatorKetQuaTimKiem.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorKetQuaTimKiem.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorKetQuaTimKiem.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorKetQuaTimKiem.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorKetQuaTimKiem.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorKetQuaTimKiem.Name = "bindingNavigatorKetQuaTimKiem";
            this.bindingNavigatorKetQuaTimKiem.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorKetQuaTimKiem.Size = new System.Drawing.Size(653, 35);
            this.bindingNavigatorKetQuaTimKiem.TabIndex = 3;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 32);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorExitItem
            // 
            this.bindingNavigatorExitItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorExitItem.Image = global::QLHocSinhTHPT.Properties.Resources.exit;
            this.bindingNavigatorExitItem.Name = "bindingNavigatorExitItem";
            this.bindingNavigatorExitItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorExitItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorExitItem.Text = "Thoát";
            this.bindingNavigatorExitItem.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click);
            // 
            // navPaneLeft
            // 
            this.navPaneLeft.CanCollapse = true;
            this.navPaneLeft.Controls.Add(this.navPanelTimKiem);
            this.navPaneLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPaneLeft.ItemPaddingBottom = 2;
            this.navPaneLeft.ItemPaddingTop = 2;
            this.navPaneLeft.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemTimKiem});
            this.navPaneLeft.Location = new System.Drawing.Point(0, 0);
            this.navPaneLeft.Name = "navPaneLeft";
            this.navPaneLeft.NavigationBarHeight = 67;
            this.navPaneLeft.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneLeft.Size = new System.Drawing.Size(185, 398);
            this.navPaneLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TabIndex = 0;
            // 
            // 
            // 
            this.navPaneLeft.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneLeft.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneLeft.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneLeft.TitlePanel.Name = "panelTitle";
            this.navPaneLeft.TitlePanel.Size = new System.Drawing.Size(183, 24);
            this.navPaneLeft.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneLeft.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneLeft.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneLeft.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneLeft.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneLeft.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneLeft.TitlePanel.Style.GradientAngle = 90;
            this.navPaneLeft.TitlePanel.Style.MarginLeft = 4;
            this.navPaneLeft.TitlePanel.TabIndex = 0;
            this.navPaneLeft.TitlePanel.Text = "Tìm kiếm học sinh";
            // 
            // navPanelTimKiem
            // 
            this.navPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelTimKiem.Controls.Add(this.cmbTonGiao);
            this.navPanelTimKiem.Controls.Add(this.cmbDanToc);
            this.navPanelTimKiem.Controls.Add(this.cmbTheoTGiao);
            this.navPanelTimKiem.Controls.Add(this.cmbTheoDToc);
            this.navPanelTimKiem.Controls.Add(this.label4);
            this.navPanelTimKiem.Controls.Add(this.cmbTheoNSinh);
            this.navPanelTimKiem.Controls.Add(this.label3);
            this.navPanelTimKiem.Controls.Add(this.label2);
            this.navPanelTimKiem.Controls.Add(this.label1);
            this.navPanelTimKiem.Controls.Add(this.txtNoiSinh);
            this.navPanelTimKiem.Controls.Add(this.btnTimKiem);
            this.navPanelTimKiem.Controls.Add(this.txtHoTen);
            this.navPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelTimKiem.Location = new System.Drawing.Point(1, 25);
            this.navPanelTimKiem.Name = "navPanelTimKiem";
            this.navPanelTimKiem.ParentItem = this.buttonItemTimKiem;
            this.navPanelTimKiem.Size = new System.Drawing.Size(183, 305);
            this.navPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelTimKiem.Style.GradientAngle = 90;
            this.navPanelTimKiem.TabIndex = 1;
            // 
            // cmbTonGiao
            // 
            this.cmbTonGiao.DisplayMember = "Text";
            this.cmbTonGiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTonGiao.FormattingEnabled = true;
            this.cmbTonGiao.ItemHeight = 14;
            this.cmbTonGiao.Location = new System.Drawing.Point(11, 190);
            this.cmbTonGiao.Name = "cmbTonGiao";
            this.cmbTonGiao.Size = new System.Drawing.Size(160, 20);
            this.cmbTonGiao.TabIndex = 7;
            // 
            // cmbDanToc
            // 
            this.cmbDanToc.DisplayMember = "Text";
            this.cmbDanToc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDanToc.FormattingEnabled = true;
            this.cmbDanToc.ItemHeight = 14;
            this.cmbDanToc.Location = new System.Drawing.Point(11, 135);
            this.cmbDanToc.Name = "cmbDanToc";
            this.cmbDanToc.Size = new System.Drawing.Size(160, 20);
            this.cmbDanToc.TabIndex = 5;
            // 
            // cmbTheoTGiao
            // 
            this.cmbTheoTGiao.DisplayMember = "Text";
            this.cmbTheoTGiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTheoTGiao.FormattingEnabled = true;
            this.cmbTheoTGiao.ItemHeight = 14;
            this.cmbTheoTGiao.Items.AddRange(new object[] {
            this.col07,
            this.col08,
            this.col09});
            this.cmbTheoTGiao.Location = new System.Drawing.Point(11, 165);
            this.cmbTheoTGiao.Name = "cmbTheoTGiao";
            this.cmbTheoTGiao.Size = new System.Drawing.Size(54, 20);
            this.cmbTheoTGiao.TabIndex = 6;
            this.cmbTheoTGiao.Text = "NONE";
            // 
            // col07
            // 
            this.col07.Text = "NONE";
            // 
            // col08
            // 
            this.col08.Text = "AND";
            // 
            // col09
            // 
            this.col09.Text = "OR";
            // 
            // cmbTheoDToc
            // 
            this.cmbTheoDToc.DisplayMember = "Text";
            this.cmbTheoDToc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTheoDToc.FormattingEnabled = true;
            this.cmbTheoDToc.ItemHeight = 14;
            this.cmbTheoDToc.Items.AddRange(new object[] {
            this.col04,
            this.col05,
            this.col06});
            this.cmbTheoDToc.Location = new System.Drawing.Point(11, 110);
            this.cmbTheoDToc.Name = "cmbTheoDToc";
            this.cmbTheoDToc.Size = new System.Drawing.Size(54, 20);
            this.cmbTheoDToc.TabIndex = 4;
            this.cmbTheoDToc.Text = "NONE";
            // 
            // col04
            // 
            this.col04.Text = "NONE";
            // 
            // col05
            // 
            this.col05.Text = "AND";
            // 
            // col06
            // 
            this.col06.Text = "OR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tôn giáo:";
            // 
            // cmbTheoNSinh
            // 
            this.cmbTheoNSinh.DisplayMember = "Text";
            this.cmbTheoNSinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTheoNSinh.FormattingEnabled = true;
            this.cmbTheoNSinh.ItemHeight = 14;
            this.cmbTheoNSinh.Items.AddRange(new object[] {
            this.col01,
            this.col02,
            this.col03});
            this.cmbTheoNSinh.Location = new System.Drawing.Point(11, 55);
            this.cmbTheoNSinh.Name = "cmbTheoNSinh";
            this.cmbTheoNSinh.Size = new System.Drawing.Size(54, 20);
            this.cmbTheoNSinh.TabIndex = 2;
            this.cmbTheoNSinh.Text = "NONE";
            // 
            // col01
            // 
            this.col01.Text = "NONE";
            // 
            // col02
            // 
            this.col02.Text = "AND";
            // 
            // col03
            // 
            this.col03.Text = "OR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dân tộc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nơi sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // txtNoiSinh
            // 
            // 
            // 
            // 
            this.txtNoiSinh.Border.Class = "TextBoxBorder";
            this.txtNoiSinh.Location = new System.Drawing.Point(11, 80);
            this.txtNoiSinh.MaxLength = 50;
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(160, 20);
            this.txtNoiSinh.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 220);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 23);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.Border.Class = "TextBoxBorder";
            this.txtHoTen.Location = new System.Drawing.Point(11, 25);
            this.txtHoTen.MaxLength = 30;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(160, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // buttonItemTimKiem
            // 
            this.buttonItemTimKiem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemTimKiem.Checked = true;
            this.buttonItemTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemTimKiem.Image")));
            this.buttonItemTimKiem.ImagePaddingHorizontal = 8;
            this.buttonItemTimKiem.Name = "buttonItemTimKiem";
            this.buttonItemTimKiem.OptionGroup = "navBar";
            this.buttonItemTimKiem.Text = "Tìm kiếm học sinh";
            // 
            // frmTimKiemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 398);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.navPaneLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTimKiemHS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiemHS_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetQuaTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetQuaTimKiem)).EndInit();
            this.bindingNavigatorKetQuaTimKiem.ResumeLayout(false);
            this.bindingNavigatorKetQuaTimKiem.PerformLayout();
            this.navPaneLeft.ResumeLayout(false);
            this.navPanelTimKiem.ResumeLayout(false);
            this.navPanelTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGVKetQuaTimKiem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDanToc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTonGiao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTheoTGiao;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTheoDToc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTheoNSinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNoiSinh;
        private DevComponents.DotNetBar.NavigationPane navPaneLeft;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelTimKiem;
        private DevComponents.DotNetBar.ButtonItem buttonItemTimKiem;
        private DevComponents.DotNetBar.ButtonX btnTimKiem; 
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.ComboItem col01;
        private DevComponents.Editors.ComboItem col02;
        private DevComponents.Editors.ComboItem col03;
        private DevComponents.Editors.ComboItem col04;
        private DevComponents.Editors.ComboItem col05;
        private DevComponents.Editors.ComboItem col06;
        private DevComponents.Editors.ComboItem col07;
        private DevComponents.Editors.ComboItem col08;
        private DevComponents.Editors.ComboItem col09;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTonGiao;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKetQuaTimKiem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExitItem;
        #endregion
    }
}