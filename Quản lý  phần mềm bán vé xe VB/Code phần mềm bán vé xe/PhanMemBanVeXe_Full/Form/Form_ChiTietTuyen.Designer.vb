<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ChiTietTuyen
    'Inherits System.Windows.Forms.Form
    Inherits DevComponents.DotNetBar.Office2007Form
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ChiTietTuyen))
        Me.Panel_ChiTietTuyen = New DevComponents.DotNetBar.PanelEx
        Me.btn_HienDanhSach = New DevComponents.DotNetBar.ButtonX
        Me.cbo_TenTuyen = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbo_MaSoTuyen = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.grb_ThoiDiem = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btn_Xoa = New DevComponents.DotNetBar.ButtonX
        Me.btn_thoat = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txt_GioChay = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.date_Chay = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cbo_MaSoTuyen1 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.cbo_MaThoiDiem = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.luoi_Thoi_diem = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.cot_Ma_so_tuyen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cot_IdTuyen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cot_Ngay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cot_gio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReflectionLabel_ChaoMung = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.LinkLabelLanguague = New System.Windows.Forms.LinkLabel
        Me.lblTenTuyen = New DevComponents.DotNetBar.LabelX
        Me.lblMaSoTuyen = New DevComponents.DotNetBar.LabelX
        Me.Panel_ChiTietTuyen.SuspendLayout()
        Me.grb_ThoiDiem.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.date_Chay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luoi_Thoi_diem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_ChiTietTuyen
        '
        Me.Panel_ChiTietTuyen.CanvasColor = System.Drawing.SystemColors.Control
        Me.Panel_ChiTietTuyen.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Panel_ChiTietTuyen.Controls.Add(Me.btn_HienDanhSach)
        Me.Panel_ChiTietTuyen.Controls.Add(Me.cbo_TenTuyen)
        Me.Panel_ChiTietTuyen.Controls.Add(Me.cbo_MaSoTuyen)
        Me.Panel_ChiTietTuyen.Controls.Add(Me.grb_ThoiDiem)
        Me.Panel_ChiTietTuyen.Controls.Add(Me.ReflectionLabel_ChaoMung)
        Me.Panel_ChiTietTuyen.Controls.Add(Me.LinkLabelLanguague)
        Me.Panel_ChiTietTuyen.Controls.Add(Me.lblTenTuyen)
        Me.Panel_ChiTietTuyen.Controls.Add(Me.lblMaSoTuyen)
        Me.Panel_ChiTietTuyen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ChiTietTuyen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Panel_ChiTietTuyen.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ChiTietTuyen.Name = "Panel_ChiTietTuyen"
        Me.Panel_ChiTietTuyen.Size = New System.Drawing.Size(923, 593)
        Me.Panel_ChiTietTuyen.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panel_ChiTietTuyen.Style.BackColor1.Color = System.Drawing.Color.DeepSkyBlue
        Me.Panel_ChiTietTuyen.Style.BackColor2.Color = System.Drawing.Color.DeepSkyBlue
        Me.Panel_ChiTietTuyen.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panel_ChiTietTuyen.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_ChiTietTuyen.Style.ForeColor.Color = System.Drawing.Color.Chartreuse
        Me.Panel_ChiTietTuyen.Style.GradientAngle = 90
        Me.Panel_ChiTietTuyen.TabIndex = 3
        '
        'btn_HienDanhSach
        '
        Me.btn_HienDanhSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_HienDanhSach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_HienDanhSach.Location = New System.Drawing.Point(543, 75)
        Me.btn_HienDanhSach.Name = "btn_HienDanhSach"
        Me.btn_HienDanhSach.Size = New System.Drawing.Size(173, 23)
        Me.btn_HienDanhSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_HienDanhSach.TabIndex = 11
        Me.btn_HienDanhSach.Text = "Hiện tất cả danh sách"
        '
        'cbo_TenTuyen
        '
        Me.cbo_TenTuyen.DisplayMember = "Text"
        Me.cbo_TenTuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_TenTuyen.FormattingEnabled = True
        Me.cbo_TenTuyen.ItemHeight = 15
        Me.cbo_TenTuyen.Location = New System.Drawing.Point(348, 75)
        Me.cbo_TenTuyen.Name = "cbo_TenTuyen"
        Me.cbo_TenTuyen.Size = New System.Drawing.Size(147, 21)
        Me.cbo_TenTuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbo_TenTuyen.TabIndex = 10
        '
        'cbo_MaSoTuyen
        '
        Me.cbo_MaSoTuyen.DisplayMember = "Text"
        Me.cbo_MaSoTuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_MaSoTuyen.FormattingEnabled = True
        Me.cbo_MaSoTuyen.ItemHeight = 15
        Me.cbo_MaSoTuyen.Location = New System.Drawing.Point(137, 77)
        Me.cbo_MaSoTuyen.Name = "cbo_MaSoTuyen"
        Me.cbo_MaSoTuyen.Size = New System.Drawing.Size(104, 21)
        Me.cbo_MaSoTuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbo_MaSoTuyen.TabIndex = 10
        '
        'grb_ThoiDiem
        '
        Me.grb_ThoiDiem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grb_ThoiDiem.CanvasColor = System.Drawing.SystemColors.Control
        Me.grb_ThoiDiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.grb_ThoiDiem.Controls.Add(Me.btn_Xoa)
        Me.grb_ThoiDiem.Controls.Add(Me.btn_thoat)
        Me.grb_ThoiDiem.Controls.Add(Me.GroupPanel1)
        Me.grb_ThoiDiem.Controls.Add(Me.luoi_Thoi_diem)
        Me.grb_ThoiDiem.Location = New System.Drawing.Point(12, 104)
        Me.grb_ThoiDiem.Name = "grb_ThoiDiem"
        Me.grb_ThoiDiem.Size = New System.Drawing.Size(891, 477)
        '
        '
        '
        Me.grb_ThoiDiem.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grb_ThoiDiem.Style.BackColorGradientAngle = 90
        Me.grb_ThoiDiem.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grb_ThoiDiem.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grb_ThoiDiem.Style.BorderBottomWidth = 1
        Me.grb_ThoiDiem.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grb_ThoiDiem.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grb_ThoiDiem.Style.BorderLeftWidth = 1
        Me.grb_ThoiDiem.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grb_ThoiDiem.Style.BorderRightWidth = 1
        Me.grb_ThoiDiem.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grb_ThoiDiem.Style.BorderTopWidth = 1
        Me.grb_ThoiDiem.Style.Class = ""
        Me.grb_ThoiDiem.Style.CornerDiameter = 4
        Me.grb_ThoiDiem.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.grb_ThoiDiem.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grb_ThoiDiem.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.grb_ThoiDiem.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.grb_ThoiDiem.StyleMouseDown.Class = ""
        Me.grb_ThoiDiem.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grb_ThoiDiem.StyleMouseOver.Class = ""
        Me.grb_ThoiDiem.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grb_ThoiDiem.TabIndex = 9
        Me.grb_ThoiDiem.Text = "Danh sách thời điểm khởi hành"
        '
        'btn_Xoa
        '
        Me.btn_Xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Xoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btn_Xoa.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Xoa.Location = New System.Drawing.Point(568, 284)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(113, 62)
        Me.btn_Xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Xoa.TabIndex = 13
        Me.btn_Xoa.Text = "Xóa"
        '
        'btn_thoat
        '
        Me.btn_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_thoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.btn_thoat.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_thoat.Location = New System.Drawing.Point(749, 284)
        Me.btn_thoat.Name = "btn_thoat"
        Me.btn_thoat.Size = New System.Drawing.Size(118, 62)
        Me.btn_thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_thoat.TabIndex = 12
        Me.btn_thoat.Text = "Thoát"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txt_GioChay)
        Me.GroupPanel1.Controls.Add(Me.date_Chay)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.cbo_MaSoTuyen1)
        Me.GroupPanel1.Controls.Add(Me.cbo_MaThoiDiem)
        Me.GroupPanel1.Location = New System.Drawing.Point(551, 18)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(316, 245)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 11
        Me.GroupPanel1.Text = "Thời điểm"
        '
        'txt_GioChay
        '
        '
        '
        '
        Me.txt_GioChay.Border.Class = "TextBoxBorder"
        Me.txt_GioChay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_GioChay.Location = New System.Drawing.Point(139, 157)
        Me.txt_GioChay.Name = "txt_GioChay"
        Me.txt_GioChay.Size = New System.Drawing.Size(124, 21)
        Me.txt_GioChay.TabIndex = 12
        '
        'date_Chay
        '
        '
        '
        '
        Me.date_Chay.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.date_Chay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_Chay.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.date_Chay.ButtonDropDown.Visible = True
        Me.date_Chay.Location = New System.Drawing.Point(139, 109)
        '
        '
        '
        Me.date_Chay.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.date_Chay.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.date_Chay.MonthCalendar.BackgroundStyle.Class = ""
        Me.date_Chay.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_Chay.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.date_Chay.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.date_Chay.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.date_Chay.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.date_Chay.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.date_Chay.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.date_Chay.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.date_Chay.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.date_Chay.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_Chay.MonthCalendar.DisplayMonth = New Date(2010, 12, 1, 0, 0, 0, 0)
        Me.date_Chay.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.date_Chay.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.date_Chay.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.date_Chay.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.date_Chay.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.date_Chay.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.date_Chay.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_Chay.MonthCalendar.TodayButtonVisible = True
        Me.date_Chay.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.date_Chay.Name = "date_Chay"
        Me.date_Chay.Size = New System.Drawing.Size(124, 21)
        Me.date_Chay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.date_Chay.TabIndex = 11
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX3.Location = New System.Drawing.Point(23, 157)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(86, 23)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "Giờ khởi hành"
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX2.Location = New System.Drawing.Point(23, 109)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(48, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Ngày"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX4.Location = New System.Drawing.Point(23, 16)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(87, 23)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "Mã số tuyến"
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelX1.Location = New System.Drawing.Point(23, 65)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(87, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Mã thời điểm"
        '
        'cbo_MaSoTuyen1
        '
        Me.cbo_MaSoTuyen1.DisplayMember = "Text"
        Me.cbo_MaSoTuyen1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_MaSoTuyen1.FormattingEnabled = True
        Me.cbo_MaSoTuyen1.ItemHeight = 15
        Me.cbo_MaSoTuyen1.Location = New System.Drawing.Point(137, 16)
        Me.cbo_MaSoTuyen1.Name = "cbo_MaSoTuyen1"
        Me.cbo_MaSoTuyen1.Size = New System.Drawing.Size(153, 21)
        Me.cbo_MaSoTuyen1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbo_MaSoTuyen1.TabIndex = 10
        '
        'cbo_MaThoiDiem
        '
        Me.cbo_MaThoiDiem.DisplayMember = "Text"
        Me.cbo_MaThoiDiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_MaThoiDiem.FormattingEnabled = True
        Me.cbo_MaThoiDiem.ItemHeight = 15
        Me.cbo_MaThoiDiem.Location = New System.Drawing.Point(137, 65)
        Me.cbo_MaThoiDiem.Name = "cbo_MaThoiDiem"
        Me.cbo_MaThoiDiem.Size = New System.Drawing.Size(126, 21)
        Me.cbo_MaThoiDiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbo_MaThoiDiem.TabIndex = 10
        '
        'luoi_Thoi_diem
        '
        Me.luoi_Thoi_diem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.luoi_Thoi_diem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.luoi_Thoi_diem.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.luoi_Thoi_diem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.luoi_Thoi_diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.luoi_Thoi_diem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cot_Ma_so_tuyen, Me.cot_IdTuyen, Me.cot_Ngay, Me.cot_gio})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.luoi_Thoi_diem.DefaultCellStyle = DataGridViewCellStyle1
        Me.luoi_Thoi_diem.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.luoi_Thoi_diem.Location = New System.Drawing.Point(24, 18)
        Me.luoi_Thoi_diem.Name = "luoi_Thoi_diem"
        Me.luoi_Thoi_diem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.luoi_Thoi_diem.Size = New System.Drawing.Size(501, 421)
        Me.luoi_Thoi_diem.TabIndex = 0
        '
        'cot_Ma_so_tuyen
        '
        Me.cot_Ma_so_tuyen.DataPropertyName = "IdTuyen"
        Me.cot_Ma_so_tuyen.HeaderText = "Mã số tuyến"
        Me.cot_Ma_so_tuyen.Name = "cot_Ma_so_tuyen"
        '
        'cot_IdTuyen
        '
        Me.cot_IdTuyen.DataPropertyName = "IdThoiDiem"
        Me.cot_IdTuyen.HeaderText = "Mã thời điểm"
        Me.cot_IdTuyen.Name = "cot_IdTuyen"
        '
        'cot_Ngay
        '
        Me.cot_Ngay.DataPropertyName = "Ngay"
        Me.cot_Ngay.HeaderText = "Ngày"
        Me.cot_Ngay.Name = "cot_Ngay"
        '
        'cot_gio
        '
        Me.cot_gio.DataPropertyName = "Gio"
        Me.cot_gio.HeaderText = "Giờ khởi hành"
        Me.cot_gio.Name = "cot_gio"
        '
        'ReflectionLabel_ChaoMung
        '
        Me.ReflectionLabel_ChaoMung.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReflectionLabel_ChaoMung.BackColor = System.Drawing.Color.ForestGreen
        '
        '
        '
        Me.ReflectionLabel_ChaoMung.BackgroundStyle.Class = ""
        Me.ReflectionLabel_ChaoMung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel_ChaoMung.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel_ChaoMung.ForeColor = System.Drawing.Color.White
        Me.ReflectionLabel_ChaoMung.Location = New System.Drawing.Point(0, 0)
        Me.ReflectionLabel_ChaoMung.Name = "ReflectionLabel_ChaoMung"
        Me.ReflectionLabel_ChaoMung.Size = New System.Drawing.Size(923, 59)
        Me.ReflectionLabel_ChaoMung.TabIndex = 8
        Me.ReflectionLabel_ChaoMung.Text = "                                      CHI TIẾT TUYẾN XE"
        '
        'LinkLabelLanguague
        '
        Me.LinkLabelLanguague.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabelLanguague.Location = New System.Drawing.Point(0, 0)
        Me.LinkLabelLanguague.Name = "LinkLabelLanguague"
        Me.LinkLabelLanguague.Size = New System.Drawing.Size(100, 23)
        Me.LinkLabelLanguague.TabIndex = 0
        '
        'lblTenTuyen
        '
        '
        '
        '
        Me.lblTenTuyen.BackgroundStyle.Class = ""
        Me.lblTenTuyen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTenTuyen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTenTuyen.Location = New System.Drawing.Point(263, 75)
        Me.lblTenTuyen.Name = "lblTenTuyen"
        Me.lblTenTuyen.Size = New System.Drawing.Size(68, 23)
        Me.lblTenTuyen.TabIndex = 1
        Me.lblTenTuyen.Text = "&Tên tuyến"
        '
        'lblMaSoTuyen
        '
        '
        '
        '
        Me.lblMaSoTuyen.BackgroundStyle.Class = ""
        Me.lblMaSoTuyen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblMaSoTuyen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMaSoTuyen.Location = New System.Drawing.Point(39, 75)
        Me.lblMaSoTuyen.Name = "lblMaSoTuyen"
        Me.lblMaSoTuyen.Size = New System.Drawing.Size(81, 23)
        Me.lblMaSoTuyen.TabIndex = 1
        Me.lblMaSoTuyen.Text = "&Mã số tuyến"
        '
        'Form_ChiTietTuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 593)
        Me.Controls.Add(Me.Panel_ChiTietTuyen)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_ChiTietTuyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chi Tiet Tuyen Xe"
        Me.Panel_ChiTietTuyen.ResumeLayout(False)
        Me.grb_ThoiDiem.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.date_Chay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luoi_Thoi_diem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_ChiTietTuyen As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionLabel_ChaoMung As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LinkLabelLanguague As System.Windows.Forms.LinkLabel
    Friend WithEvents lblMaSoTuyen As DevComponents.DotNetBar.LabelX
    Friend WithEvents grb_ThoiDiem As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents luoi_Thoi_diem As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cbo_MaSoTuyen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbo_TenTuyen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblTenTuyen As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbo_MaThoiDiem As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txt_GioChay As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents date_Chay As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_HienDanhSach As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cot_Ma_so_tuyen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cot_IdTuyen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cot_Ngay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cot_gio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbo_MaSoTuyen1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_thoat As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_Xoa As DevComponents.DotNetBar.ButtonX
End Class
