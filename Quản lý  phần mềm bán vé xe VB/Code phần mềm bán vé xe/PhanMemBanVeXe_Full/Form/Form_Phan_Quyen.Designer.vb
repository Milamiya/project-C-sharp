<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Phan_Quyen
    'Inherits System.Windows.Forms.Form
    Inherits DevComponents.DotNetBar.Office2007RibbonForm
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.ReflectionLabel_ChaoMung = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.grb_PhanQuyen = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txt_IdNhanVien = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.ckb_ThoiDiem = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.Label1 = New System.Windows.Forms.Label
        Me.ckb_banve = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckb_chuyenXe = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckb_xe = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckb_tuyen = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btn_DongY = New DevComponents.DotNetBar.ButtonX
        Me.ButtonThoat = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx1.SuspendLayout()
        Me.grb_PhanQuyen.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.PanelEx1.Controls.Add(Me.ReflectionLabel_ChaoMung)
        Me.PanelEx1.Controls.Add(Me.grb_PhanQuyen)
        Me.PanelEx1.Controls.Add(Me.btn_DongY)
        Me.PanelEx1.Controls.Add(Me.ButtonThoat)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(5, 1)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(471, 409)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.DeepSkyBlue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
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
        Me.ReflectionLabel_ChaoMung.Size = New System.Drawing.Size(471, 59)
        Me.ReflectionLabel_ChaoMung.TabIndex = 9
        Me.ReflectionLabel_ChaoMung.Text = " PHÂN QUYỀN TRUY CẬP"
        '
        'grb_PhanQuyen
        '
        Me.grb_PhanQuyen.CanvasColor = System.Drawing.SystemColors.Control
        Me.grb_PhanQuyen.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.grb_PhanQuyen.Controls.Add(Me.LabelX1)
        Me.grb_PhanQuyen.Controls.Add(Me.txt_IdNhanVien)
        Me.grb_PhanQuyen.Controls.Add(Me.ckb_ThoiDiem)
        Me.grb_PhanQuyen.Controls.Add(Me.Label1)
        Me.grb_PhanQuyen.Controls.Add(Me.ckb_banve)
        Me.grb_PhanQuyen.Controls.Add(Me.ckb_chuyenXe)
        Me.grb_PhanQuyen.Controls.Add(Me.ckb_xe)
        Me.grb_PhanQuyen.Controls.Add(Me.ckb_tuyen)
        Me.grb_PhanQuyen.Location = New System.Drawing.Point(42, 72)
        Me.grb_PhanQuyen.Name = "grb_PhanQuyen"
        Me.grb_PhanQuyen.Size = New System.Drawing.Size(290, 325)
        '
        '
        '
        Me.grb_PhanQuyen.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grb_PhanQuyen.Style.BackColorGradientAngle = 90
        Me.grb_PhanQuyen.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grb_PhanQuyen.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grb_PhanQuyen.Style.BorderBottomWidth = 1
        Me.grb_PhanQuyen.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grb_PhanQuyen.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grb_PhanQuyen.Style.BorderLeftWidth = 1
        Me.grb_PhanQuyen.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grb_PhanQuyen.Style.BorderRightWidth = 1
        Me.grb_PhanQuyen.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grb_PhanQuyen.Style.BorderTopWidth = 1
        Me.grb_PhanQuyen.Style.Class = ""
        Me.grb_PhanQuyen.Style.CornerDiameter = 4
        Me.grb_PhanQuyen.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.grb_PhanQuyen.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grb_PhanQuyen.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.grb_PhanQuyen.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.grb_PhanQuyen.StyleMouseDown.Class = ""
        Me.grb_PhanQuyen.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grb_PhanQuyen.StyleMouseOver.Class = ""
        Me.grb_PhanQuyen.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grb_PhanQuyen.TabIndex = 3
        Me.grb_PhanQuyen.Text = "Phân Quyền"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(35, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(131, 23)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "User name Nhân Viên"
        '
        'txt_IdNhanVien
        '
        '
        '
        '
        Me.txt_IdNhanVien.Border.Class = "TextBoxBorder"
        Me.txt_IdNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_IdNhanVien.FocusHighlightEnabled = True
        Me.txt_IdNhanVien.Location = New System.Drawing.Point(35, 42)
        Me.txt_IdNhanVien.Name = "txt_IdNhanVien"
        Me.txt_IdNhanVien.ReadOnly = True
        Me.txt_IdNhanVien.Size = New System.Drawing.Size(155, 20)
        Me.txt_IdNhanVien.TabIndex = 4
        '
        'ckb_ThoiDiem
        '
        '
        '
        '
        Me.ckb_ThoiDiem.BackgroundStyle.Class = ""
        Me.ckb_ThoiDiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckb_ThoiDiem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_ThoiDiem.Location = New System.Drawing.Point(48, 201)
        Me.ckb_ThoiDiem.Name = "ckb_ThoiDiem"
        Me.ckb_ThoiDiem.Size = New System.Drawing.Size(195, 23)
        Me.ckb_ThoiDiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckb_ThoiDiem.TabIndex = 1
        Me.ckb_ThoiDiem.Text = "Thao Tác Trên Bảng Thời Điểm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(15, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cấp Quyền :"
        '
        'ckb_banve
        '
        '
        '
        '
        Me.ckb_banve.BackgroundStyle.Class = ""
        Me.ckb_banve.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckb_banve.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_banve.Location = New System.Drawing.Point(48, 259)
        Me.ckb_banve.Name = "ckb_banve"
        Me.ckb_banve.Size = New System.Drawing.Size(170, 23)
        Me.ckb_banve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckb_banve.TabIndex = 1
        Me.ckb_banve.Text = "Thao Tác Trên Bảng Vé"
        '
        'ckb_chuyenXe
        '
        '
        '
        '
        Me.ckb_chuyenXe.BackgroundStyle.Class = ""
        Me.ckb_chuyenXe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckb_chuyenXe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_chuyenXe.Location = New System.Drawing.Point(48, 230)
        Me.ckb_chuyenXe.Name = "ckb_chuyenXe"
        Me.ckb_chuyenXe.Size = New System.Drawing.Size(179, 23)
        Me.ckb_chuyenXe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckb_chuyenXe.TabIndex = 1
        Me.ckb_chuyenXe.Text = "Thao Tác Trên Chuyến Xe"
        '
        'ckb_xe
        '
        '
        '
        '
        Me.ckb_xe.BackgroundStyle.Class = ""
        Me.ckb_xe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckb_xe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_xe.Location = New System.Drawing.Point(48, 143)
        Me.ckb_xe.Name = "ckb_xe"
        Me.ckb_xe.Size = New System.Drawing.Size(195, 23)
        Me.ckb_xe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckb_xe.TabIndex = 1
        Me.ckb_xe.Text = "Thao Tác Trên Bảng Xe"
        '
        'ckb_tuyen
        '
        '
        '
        '
        Me.ckb_tuyen.BackgroundStyle.Class = ""
        Me.ckb_tuyen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckb_tuyen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckb_tuyen.Location = New System.Drawing.Point(48, 172)
        Me.ckb_tuyen.Name = "ckb_tuyen"
        Me.ckb_tuyen.Size = New System.Drawing.Size(170, 23)
        Me.ckb_tuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckb_tuyen.TabIndex = 1
        Me.ckb_tuyen.Text = "Thao Tác Trên Bảng Tuyến Xe"
        '
        'btn_DongY
        '
        Me.btn_DongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_DongY.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btn_DongY.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DongY.Image = Global.PhanMemBanVeXe_Full.My.Resources.Resources.phanquyen1
        Me.btn_DongY.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.btn_DongY.Location = New System.Drawing.Point(338, 85)
        Me.btn_DongY.Name = "btn_DongY"
        Me.btn_DongY.Size = New System.Drawing.Size(121, 56)
        Me.btn_DongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_DongY.TabIndex = 2
        Me.btn_DongY.Text = "&Đồng ý"
        '
        'ButtonThoat
        '
        Me.ButtonThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.ButtonThoat.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonThoat.Image = Global.PhanMemBanVeXe_Full.My.Resources.Resources.exit1
        Me.ButtonThoat.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonThoat.Location = New System.Drawing.Point(338, 165)
        Me.ButtonThoat.Name = "ButtonThoat"
        Me.ButtonThoat.Size = New System.Drawing.Size(121, 56)
        Me.ButtonThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonThoat.TabIndex = 2
        Me.ButtonThoat.Tag = ""
        Me.ButtonThoat.Text = "&Thoát"
        '
        'Form_Phan_Quyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 412)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "Form_Phan_Quyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Phan_Quyen"
        Me.PanelEx1.ResumeLayout(False)
        Me.grb_PhanQuyen.ResumeLayout(False)
        Me.grb_PhanQuyen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Public WithEvents grb_PhanQuyen As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Public WithEvents txt_IdNhanVien As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ckb_ThoiDiem As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonThoat As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_DongY As DevComponents.DotNetBar.ButtonX
    Public WithEvents ckb_banve As DevComponents.DotNetBar.Controls.CheckBoxX
    Public WithEvents ckb_chuyenXe As DevComponents.DotNetBar.Controls.CheckBoxX
    Public WithEvents ckb_xe As DevComponents.DotNetBar.Controls.CheckBoxX
    Public WithEvents ckb_tuyen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ReflectionLabel_ChaoMung As DevComponents.DotNetBar.Controls.ReflectionLabel
End Class
