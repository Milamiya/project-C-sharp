<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.DockContainerItem4 = New DevComponents.DotNetBar.DockContainerItem
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem
        Me.DockContainerItem3 = New DevComponents.DotNetBar.DockContainerItem
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.PanelLogin = New DevComponents.DotNetBar.PanelEx
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.lblChaoMung = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.LinkLabel_Language = New System.Windows.Forms.LinkLabel
        Me.LinkLabelLanguague = New System.Windows.Forms.LinkLabel
        Me.Label_HuongDan = New DevComponents.DotNetBar.LabelX
        Me.cmdExit = New DevComponents.DotNetBar.ButtonX
        Me.cmdLogin = New DevComponents.DotNetBar.ButtonX
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Label_Password = New DevComponents.DotNetBar.LabelX
        Me.Label_UserName = New DevComponents.DotNetBar.LabelX
        Me.TimerClosing = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelEx1.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockContainerItem4
        '
        Me.DockContainerItem4.Name = "DockContainerItem4"
        resources.ApplyResources(Me.DockContainerItem4, "DockContainerItem4")
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Name = "DockContainerItem1"
        resources.ApplyResources(Me.DockContainerItem1, "DockContainerItem1")
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Name = "DockContainerItem2"
        resources.ApplyResources(Me.DockContainerItem2, "DockContainerItem2")
        '
        'DockContainerItem3
        '
        Me.DockContainerItem3.Name = "DockContainerItem3"
        resources.ApplyResources(Me.DockContainerItem3, "DockContainerItem3")
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelLogin)
        resources.ApplyResources(Me.PanelEx1, "PanelEx1")
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.MediumSpringGreen
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.StyleMouseDown.BackColor1.Color = System.Drawing.Color.GreenYellow
        Me.PanelEx1.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelEx1.StyleMouseOver.BackColor1.Color = System.Drawing.Color.PaleGreen
        Me.PanelEx1.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'PanelLogin
        '
        Me.PanelLogin.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelLogin.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelLogin.Controls.Add(Me.PictureBox2)
        Me.PanelLogin.Controls.Add(Me.PictureBox1)
        Me.PanelLogin.Controls.Add(Me.ReflectionLabel1)
        Me.PanelLogin.Controls.Add(Me.lblChaoMung)
        Me.PanelLogin.Controls.Add(Me.LinkLabel_Language)
        Me.PanelLogin.Controls.Add(Me.LinkLabelLanguague)
        Me.PanelLogin.Controls.Add(Me.Label_HuongDan)
        Me.PanelLogin.Controls.Add(Me.cmdExit)
        Me.PanelLogin.Controls.Add(Me.cmdLogin)
        Me.PanelLogin.Controls.Add(Me.txtUserName)
        Me.PanelLogin.Controls.Add(Me.txtPassword)
        Me.PanelLogin.Controls.Add(Me.Label_Password)
        Me.PanelLogin.Controls.Add(Me.Label_UserName)
        resources.ApplyResources(Me.PanelLogin, "PanelLogin")
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelLogin.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelLogin.Style.BackColor2.Color = System.Drawing.Color.MediumSpringGreen
        Me.PanelLogin.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelLogin.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelLogin.Style.ForeColor.Color = System.Drawing.Color.Chartreuse
        Me.PanelLogin.Style.GradientAngle = 90
        Me.PanelLogin.StyleMouseDown.BackColor1.Color = System.Drawing.Color.GreenYellow
        Me.PanelLogin.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelLogin.StyleMouseOver.BackColor1.Color = System.Drawing.Color.PaleGreen
        Me.PanelLogin.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.Class = ""
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.ReflectionLabel1, "ReflectionLabel1")
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        '
        'lblChaoMung
        '
        '
        '
        '
        Me.lblChaoMung.BackgroundStyle.Class = ""
        Me.lblChaoMung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblChaoMung.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.lblChaoMung, "lblChaoMung")
        Me.lblChaoMung.Name = "lblChaoMung"
        '
        'LinkLabel_Language
        '
        resources.ApplyResources(Me.LinkLabel_Language, "LinkLabel_Language")
        Me.LinkLabel_Language.Name = "LinkLabel_Language"
        Me.LinkLabel_Language.TabStop = True
        '
        'LinkLabelLanguague
        '
        resources.ApplyResources(Me.LinkLabelLanguague, "LinkLabelLanguague")
        Me.LinkLabelLanguague.Name = "LinkLabelLanguague"
        '
        'Label_HuongDan
        '
        '
        '
        '
        Me.Label_HuongDan.BackgroundStyle.Class = ""
        Me.Label_HuongDan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.Label_HuongDan, "Label_HuongDan")
        Me.Label_HuongDan.Name = "Label_HuongDan"
        '
        'cmdExit
        '
        Me.cmdExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.cmdExit, "cmdExit")
        Me.cmdExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cmdLogin
        '
        Me.cmdLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        resources.ApplyResources(Me.cmdLogin, "cmdLogin")
        Me.cmdLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.cmdLogin.Name = "cmdLogin"
        '
        'txtUserName
        '
        '
        '
        '
        Me.txtUserName.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2
        Me.txtUserName.Border.BorderLeftColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor
        Me.txtUserName.Border.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtUserName.Border.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground2
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUserName.FocusHighlightColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUserName.FocusHighlightEnabled = True
        resources.ApplyResources(Me.txtUserName, "txtUserName")
        Me.txtUserName.Name = "txtUserName"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2
        Me.txtPassword.Border.BorderLeftColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor
        Me.txtPassword.Border.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtPassword.Border.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemCheckedBackground2
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.FocusHighlightEnabled = True
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label_Password
        '
        '
        '
        '
        Me.Label_Password.BackgroundStyle.Class = ""
        Me.Label_Password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.Label_Password, "Label_Password")
        Me.Label_Password.Name = "Label_Password"
        '
        'Label_UserName
        '
        '
        '
        '
        Me.Label_UserName.BackgroundStyle.Class = ""
        Me.Label_UserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        resources.ApplyResources(Me.Label_UserName, "Label_UserName")
        Me.Label_UserName.Name = "Label_UserName"
        '
        'TimerClosing
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 400
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 300
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PhanMemBanVeXe_Full.My.Resources.Resources.bus_icon
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PhanMemBanVeXe_Full.My.Resources.Resources.user_login_icon
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Form_Login
        '
        Me.AcceptButton = Me.cmdLogin
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form_Login"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockContainerItem3 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockContainerItem4 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelLogin As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblChaoMung As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LinkLabel_Language As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelLanguague As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_HuongDan As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmdExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdLogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label_Password As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label_UserName As DevComponents.DotNetBar.LabelX
    Friend WithEvents TimerClosing As System.Windows.Forms.Timer
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
