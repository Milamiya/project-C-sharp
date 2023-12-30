<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Cap_pass
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Cap_pass))
        Me.Panel_Cappass = New DevComponents.DotNetBar.PanelEx
        Me.ReflectionLabel_ChaoMung = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.LinkLabelLanguague = New System.Windows.Forms.LinkLabel
        Me.cmdExit = New DevComponents.DotNetBar.ButtonX
        Me.btn_DongY = New DevComponents.DotNetBar.ButtonX
        Me.txt_IdNguoiDung = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_NewPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label_Password = New DevComponents.DotNetBar.LabelX
        Me.Label_UserName = New DevComponents.DotNetBar.LabelX
        Me.Timer_Doi_Anh = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel_Cappass.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Cappass
        '
        Me.Panel_Cappass.CanvasColor = System.Drawing.SystemColors.Control
        Me.Panel_Cappass.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Panel_Cappass.Controls.Add(Me.PictureBox1)
        Me.Panel_Cappass.Controls.Add(Me.ReflectionLabel_ChaoMung)
        Me.Panel_Cappass.Controls.Add(Me.LinkLabelLanguague)
        Me.Panel_Cappass.Controls.Add(Me.cmdExit)
        Me.Panel_Cappass.Controls.Add(Me.btn_DongY)
        Me.Panel_Cappass.Controls.Add(Me.txt_IdNguoiDung)
        Me.Panel_Cappass.Controls.Add(Me.txt_NewPassword)
        Me.Panel_Cappass.Controls.Add(Me.Label_Password)
        Me.Panel_Cappass.Controls.Add(Me.Label_UserName)
        Me.Panel_Cappass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Cappass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Panel_Cappass.Location = New System.Drawing.Point(5, 1)
        Me.Panel_Cappass.Name = "Panel_Cappass"
        Me.Panel_Cappass.Size = New System.Drawing.Size(521, 271)
        Me.Panel_Cappass.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panel_Cappass.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Cappass.Style.BackColor2.Color = System.Drawing.Color.MediumSpringGreen
        Me.Panel_Cappass.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panel_Cappass.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Cappass.Style.ForeColor.Color = System.Drawing.Color.Chartreuse
        Me.Panel_Cappass.Style.GradientAngle = 90
        Me.Panel_Cappass.StyleMouseDown.BackColor1.Color = System.Drawing.Color.GreenYellow
        Me.Panel_Cappass.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Cappass.StyleMouseOver.BackColor1.Color = System.Drawing.Color.PaleGreen
        Me.Panel_Cappass.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Cappass.TabIndex = 2
        '
        'ReflectionLabel_ChaoMung
        '
        Me.ReflectionLabel_ChaoMung.BackColor = System.Drawing.Color.ForestGreen
        '
        '
        '
        Me.ReflectionLabel_ChaoMung.BackgroundStyle.Class = ""
        Me.ReflectionLabel_ChaoMung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel_ChaoMung.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel_ChaoMung.ForeColor = System.Drawing.Color.White
        Me.ReflectionLabel_ChaoMung.Location = New System.Drawing.Point(0, 0)
        Me.ReflectionLabel_ChaoMung.Name = "ReflectionLabel_ChaoMung"
        Me.ReflectionLabel_ChaoMung.Size = New System.Drawing.Size(521, 67)
        Me.ReflectionLabel_ChaoMung.TabIndex = 8
        Me.ReflectionLabel_ChaoMung.Text = "CẤP PASS CHO NGƯỜI DÙNG"
        '
        'LinkLabelLanguague
        '
        Me.LinkLabelLanguague.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabelLanguague.Location = New System.Drawing.Point(0, 0)
        Me.LinkLabelLanguague.Name = "LinkLabelLanguague"
        Me.LinkLabelLanguague.Size = New System.Drawing.Size(100, 23)
        Me.LinkLabelLanguague.TabIndex = 0
        '
        'cmdExit
        '
        Me.cmdExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdExit.AutoSize = True
        Me.cmdExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.cmdExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdExit.Location = New System.Drawing.Point(402, 222)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(84, 23)
        Me.cmdExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "&Thoát"
        '
        'btn_DongY
        '
        Me.btn_DongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_DongY.AutoSize = True
        Me.btn_DongY.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btn_DongY.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_DongY.Location = New System.Drawing.Point(265, 222)
        Me.btn_DongY.Name = "btn_DongY"
        Me.btn_DongY.Size = New System.Drawing.Size(87, 23)
        Me.btn_DongY.TabIndex = 5
        Me.btn_DongY.Text = "&Đồng ý"
        '
        'txt_IdNguoiDung
        '
        '
        '
        '
        Me.txt_IdNguoiDung.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2
        Me.txt_IdNguoiDung.Border.BorderLeftColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor
        Me.txt_IdNguoiDung.Border.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txt_IdNguoiDung.Border.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground2
        Me.txt_IdNguoiDung.Border.Class = "TextBoxBorder"
        Me.txt_IdNguoiDung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_IdNguoiDung.FocusHighlightEnabled = True
        Me.txt_IdNguoiDung.Location = New System.Drawing.Point(312, 118)
        Me.txt_IdNguoiDung.Name = "txt_IdNguoiDung"
        Me.txt_IdNguoiDung.Size = New System.Drawing.Size(160, 21)
        Me.txt_IdNguoiDung.TabIndex = 4
        '
        'txt_NewPassword
        '
        '
        '
        '
        Me.txt_NewPassword.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2
        Me.txt_NewPassword.Border.BorderLeftColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor
        Me.txt_NewPassword.Border.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txt_NewPassword.Border.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground2
        Me.txt_NewPassword.Border.Class = "TextBoxBorder"
        Me.txt_NewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_NewPassword.FocusHighlightEnabled = True
        Me.txt_NewPassword.Location = New System.Drawing.Point(312, 162)
        Me.txt_NewPassword.Name = "txt_NewPassword"
        Me.txt_NewPassword.Size = New System.Drawing.Size(160, 21)
        Me.txt_NewPassword.TabIndex = 4
        Me.txt_NewPassword.UseSystemPasswordChar = True
        '
        'Label_Password
        '
        '
        '
        '
        Me.Label_Password.BackgroundStyle.Class = ""
        Me.Label_Password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_Password.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_Password.Location = New System.Drawing.Point(200, 162)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(96, 23)
        Me.Label_Password.TabIndex = 3
        Me.Label_Password.Text = "&Password mới"
        '
        'Label_UserName
        '
        '
        '
        '
        Me.Label_UserName.BackgroundStyle.Class = ""
        Me.Label_UserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Label_UserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label_UserName.Location = New System.Drawing.Point(200, 118)
        Me.Label_UserName.Name = "Label_UserName"
        Me.Label_UserName.Size = New System.Drawing.Size(96, 23)
        Me.Label_UserName.TabIndex = 1
        Me.Label_UserName.Text = "&Id người dùng"
        '
        'Timer_Doi_Anh
        '
        Me.Timer_Doi_Anh.Enabled = True
        Me.Timer_Doi_Anh.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PhanMemBanVeXe_Full.My.Resources.Resources.ferme
        Me.PictureBox1.Location = New System.Drawing.Point(22, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form_Cap_pass
        '
        Me.AcceptButton = Me.btn_DongY
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 274)
        Me.Controls.Add(Me.Panel_Cappass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Cap_pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cap Lai Pass Cho Nguoi Dung"
        Me.Panel_Cappass.ResumeLayout(False)
        Me.Panel_Cappass.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Cappass As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionLabel_ChaoMung As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LinkLabelLanguague As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_DongY As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txt_IdNguoiDung As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_NewPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label_Password As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label_UserName As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer_Doi_Anh As System.Windows.Forms.Timer
End Class
