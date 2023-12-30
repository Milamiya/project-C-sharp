Imports System.IO

Public Class des
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btlapma As System.Windows.Forms.Button
    Friend WithEvents btgiaima As System.Windows.Forms.Button
    Friend WithEvents btthoat As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtchuoinhap As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtkhoak As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtpc2 As System.Windows.Forms.TextBox
    Friend WithEvents dgs0 As System.Windows.Forms.DataGrid
    Friend WithEvents dgs1 As System.Windows.Forms.DataGrid
    Friend WithEvents dgs2 As System.Windows.Forms.DataGrid
    Friend WithEvents dgs4 As System.Windows.Forms.DataGrid
    Friend WithEvents dgs3 As System.Windows.Forms.DataGrid
    Friend WithEvents dgs5 As System.Windows.Forms.DataGrid
    Friend WithEvents dgs6 As System.Windows.Forms.DataGrid
    Friend WithEvents dgs7 As System.Windows.Forms.DataGrid
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdaykhoa As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtbanro As System.Windows.Forms.TextBox
    Friend WithEvents txtbanmabit As System.Windows.Forms.TextBox
    Friend WithEvents txtbanma As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtbanrobit As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtp As System.Windows.Forms.TextBox
    Friend WithEvents txte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtip As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btlapma = New System.Windows.Forms.Button
        Me.btgiaima = New System.Windows.Forms.Button
        Me.btthoat = New System.Windows.Forms.Button
        Me.dgs0 = New System.Windows.Forms.DataGrid
        Me.dgs1 = New System.Windows.Forms.DataGrid
        Me.dgs2 = New System.Windows.Forms.DataGrid
        Me.dgs4 = New System.Windows.Forms.DataGrid
        Me.dgs3 = New System.Windows.Forms.DataGrid
        Me.dgs5 = New System.Windows.Forms.DataGrid
        Me.dgs6 = New System.Windows.Forms.DataGrid
        Me.dgs7 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtpc2 = New System.Windows.Forms.TextBox
        Me.txtpc1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtbanrobit = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtbanma = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtbanro = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdaykhoa = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtbanmabit = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtkhoak = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtchuoinhap = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtp = New System.Windows.Forms.TextBox
        Me.txte = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtip = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgs0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgs2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgs4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgs3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgs5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgs6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgs7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btlapma
        '
        Me.btlapma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlapma.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btlapma.Location = New System.Drawing.Point(712, 104)
        Me.btlapma.Name = "btlapma"
        Me.btlapma.TabIndex = 4
        Me.btlapma.Text = "LẬP MÃ"
        '
        'btgiaima
        '
        Me.btgiaima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btgiaima.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btgiaima.Location = New System.Drawing.Point(712, 128)
        Me.btgiaima.Name = "btgiaima"
        Me.btgiaima.TabIndex = 5
        Me.btgiaima.Text = "GIẢI MÃ"
        '
        'btthoat
        '
        Me.btthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btthoat.Location = New System.Drawing.Point(712, 152)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.TabIndex = 6
        Me.btthoat.Text = "THOÁT"
        '
        'dgs0
        '
        Me.dgs0.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgs0.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.dgs0.CaptionForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs0.CaptionText = "S1"
        Me.dgs0.ColumnHeadersVisible = False
        Me.dgs0.DataMember = ""
        Me.dgs0.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgs0.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.dgs0.Location = New System.Drawing.Point(0, 264)
        Me.dgs0.Name = "dgs0"
        Me.dgs0.PreferredColumnWidth = 20
        Me.dgs0.ReadOnly = True
        Me.dgs0.RowHeadersVisible = False
        Me.dgs0.Size = New System.Drawing.Size(200, 112)
        Me.dgs0.TabIndex = 12
        Me.dgs0.TabStop = False
        '
        'dgs1
        '
        Me.dgs1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgs1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.dgs1.CaptionForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs1.CaptionText = "S2"
        Me.dgs1.ColumnHeadersVisible = False
        Me.dgs1.DataMember = ""
        Me.dgs1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgs1.Location = New System.Drawing.Point(200, 264)
        Me.dgs1.Name = "dgs1"
        Me.dgs1.PreferredColumnWidth = 20
        Me.dgs1.ReadOnly = True
        Me.dgs1.RowHeadersVisible = False
        Me.dgs1.Size = New System.Drawing.Size(208, 112)
        Me.dgs1.TabIndex = 13
        Me.dgs1.TabStop = False
        '
        'dgs2
        '
        Me.dgs2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgs2.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.dgs2.CaptionForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs2.CaptionText = "S3"
        Me.dgs2.ColumnHeadersVisible = False
        Me.dgs2.DataMember = ""
        Me.dgs2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgs2.Location = New System.Drawing.Point(408, 264)
        Me.dgs2.Name = "dgs2"
        Me.dgs2.PreferredColumnWidth = 20
        Me.dgs2.ReadOnly = True
        Me.dgs2.RowHeadersVisible = False
        Me.dgs2.Size = New System.Drawing.Size(192, 112)
        Me.dgs2.TabIndex = 14
        Me.dgs2.TabStop = False
        '
        'dgs4
        '
        Me.dgs4.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgs4.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.dgs4.CaptionForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs4.CaptionText = "S5"
        Me.dgs4.ColumnHeadersVisible = False
        Me.dgs4.DataMember = ""
        Me.dgs4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgs4.Location = New System.Drawing.Point(0, 376)
        Me.dgs4.Name = "dgs4"
        Me.dgs4.PreferredColumnWidth = 20
        Me.dgs4.ReadOnly = True
        Me.dgs4.RowHeadersVisible = False
        Me.dgs4.Size = New System.Drawing.Size(200, 112)
        Me.dgs4.TabIndex = 15
        Me.dgs4.TabStop = False
        '
        'dgs3
        '
        Me.dgs3.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgs3.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.dgs3.CaptionForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs3.CaptionText = "S4"
        Me.dgs3.ColumnHeadersVisible = False
        Me.dgs3.DataMember = ""
        Me.dgs3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgs3.Location = New System.Drawing.Point(592, 264)
        Me.dgs3.Name = "dgs3"
        Me.dgs3.PreferredColumnWidth = 20
        Me.dgs3.ReadOnly = True
        Me.dgs3.RowHeadersVisible = False
        Me.dgs3.Size = New System.Drawing.Size(200, 112)
        Me.dgs3.TabIndex = 16
        Me.dgs3.TabStop = False
        '
        'dgs5
        '
        Me.dgs5.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgs5.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.dgs5.CaptionForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs5.CaptionText = "S6"
        Me.dgs5.ColumnHeadersVisible = False
        Me.dgs5.DataMember = ""
        Me.dgs5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgs5.Location = New System.Drawing.Point(200, 376)
        Me.dgs5.Name = "dgs5"
        Me.dgs5.PreferredColumnWidth = 20
        Me.dgs5.ReadOnly = True
        Me.dgs5.RowHeadersVisible = False
        Me.dgs5.Size = New System.Drawing.Size(208, 112)
        Me.dgs5.TabIndex = 17
        Me.dgs5.TabStop = False
        '
        'dgs6
        '
        Me.dgs6.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgs6.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.dgs6.CaptionForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs6.CaptionText = "S7"
        Me.dgs6.ColumnHeadersVisible = False
        Me.dgs6.DataMember = ""
        Me.dgs6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgs6.Location = New System.Drawing.Point(408, 376)
        Me.dgs6.Name = "dgs6"
        Me.dgs6.PreferredColumnWidth = 20
        Me.dgs6.ReadOnly = True
        Me.dgs6.RowHeadersVisible = False
        Me.dgs6.Size = New System.Drawing.Size(192, 112)
        Me.dgs6.TabIndex = 18
        Me.dgs6.TabStop = False
        '
        'dgs7
        '
        Me.dgs7.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgs7.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.dgs7.CaptionForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs7.CaptionText = "S8"
        Me.dgs7.ColumnHeadersVisible = False
        Me.dgs7.DataMember = ""
        Me.dgs7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgs7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgs7.Location = New System.Drawing.Point(592, 376)
        Me.dgs7.Name = "dgs7"
        Me.dgs7.PreferredColumnWidth = 20
        Me.dgs7.ReadOnly = True
        Me.dgs7.RowHeadersVisible = False
        Me.dgs7.Size = New System.Drawing.Size(200, 112)
        Me.dgs7.TabIndex = 19
        Me.dgs7.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtip)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtp)
        Me.GroupBox1.Controls.Add(Me.txtpc2)
        Me.GroupBox1.Controls.Add(Me.txtpc1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 488)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 128)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'txtpc2
        '
        Me.txtpc2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpc2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtpc2.Location = New System.Drawing.Point(636, 35)
        Me.txtpc2.Multiline = True
        Me.txtpc2.Name = "txtpc2"
        Me.txtpc2.Size = New System.Drawing.Size(155, 72)
        Me.txtpc2.TabIndex = 15
        Me.txtpc2.Text = "14 17 11 24 01 05 03 28 15 06 21 10 23 19 12 04 26 08 16 07 27 20 13 02 41 52 31 " & _
        "37 47 55 30 40 51 45 33 48 44 49 39 56 34 53 46 42 50 36 29 32"
        '
        'txtpc1
        '
        Me.txtpc1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpc1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtpc1.Location = New System.Drawing.Point(444, 37)
        Me.txtpc1.Multiline = True
        Me.txtpc1.Name = "txtpc1"
        Me.txtpc1.Size = New System.Drawing.Size(187, 73)
        Me.txtpc1.TabIndex = 14
        Me.txtpc1.Text = "57 49 41 33 25 17 09 01 58 50 42 34 26 18 10 02 59 51 43 35 27 19 11 03 60 52 44 " & _
        "36 63 55 47 39 31 23 15 07 62 54 46 38 30 22 14 06 61 53 45 37 29 21 13 05 28 20" & _
        " 12 04"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(674, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "HOÁN VỊ PC-2"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(501, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "HOÁN VỊ PC-1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbanrobit)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtbanma)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtbanro)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtdaykhoa)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtbanmabit)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtkhoak)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtchuoinhap)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btlapma)
        Me.GroupBox2.Controls.Add(Me.btgiaima)
        Me.GroupBox2.Controls.Add(Me.btthoat)
        Me.GroupBox2.Controls.Add(Me.dgs7)
        Me.GroupBox2.Controls.Add(Me.dgs3)
        Me.GroupBox2.Controls.Add(Me.dgs4)
        Me.GroupBox2.Controls.Add(Me.dgs2)
        Me.GroupBox2.Controls.Add(Me.dgs1)
        Me.GroupBox2.Controls.Add(Me.dgs0)
        Me.GroupBox2.Controls.Add(Me.dgs6)
        Me.GroupBox2.Controls.Add(Me.dgs5)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(832, 632)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'txtbanrobit
        '
        Me.txtbanrobit.Location = New System.Drawing.Point(408, 136)
        Me.txtbanrobit.Multiline = True
        Me.txtbanrobit.Name = "txtbanrobit"
        Me.txtbanrobit.Size = New System.Drawing.Size(304, 48)
        Me.txtbanrobit.TabIndex = 20
        Me.txtbanrobit.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(408, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "BẢN RÕ BIT"
        '
        'txtbanma
        '
        Me.txtbanma.Location = New System.Drawing.Point(408, 80)
        Me.txtbanma.Multiline = True
        Me.txtbanma.Name = "txtbanma"
        Me.txtbanma.Size = New System.Drawing.Size(304, 32)
        Me.txtbanma.TabIndex = 18
        Me.txtbanma.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(408, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "BẢN MÃ"
        '
        'txtbanro
        '
        Me.txtbanro.Location = New System.Drawing.Point(408, 208)
        Me.txtbanro.Multiline = True
        Me.txtbanro.Name = "txtbanro"
        Me.txtbanro.Size = New System.Drawing.Size(304, 48)
        Me.txtbanro.TabIndex = 16
        Me.txtbanro.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(408, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "BẢN RÕ"
        '
        'txtdaykhoa
        '
        Me.txtdaykhoa.Location = New System.Drawing.Point(0, 120)
        Me.txtdaykhoa.Multiline = True
        Me.txtdaykhoa.Name = "txtdaykhoa"
        Me.txtdaykhoa.Size = New System.Drawing.Size(400, 144)
        Me.txtdaykhoa.TabIndex = 14
        Me.txtdaykhoa.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(8, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "DÃY KHOÁ"
        '
        'txtbanmabit
        '
        Me.txtbanmabit.Location = New System.Drawing.Point(408, 24)
        Me.txtbanmabit.Multiline = True
        Me.txtbanmabit.Name = "txtbanmabit"
        Me.txtbanmabit.Size = New System.Drawing.Size(304, 32)
        Me.txtbanmabit.TabIndex = 12
        Me.txtbanmabit.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(408, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "BẢN MÃ BIT"
        '
        'txtkhoak
        '
        Me.txtkhoak.Location = New System.Drawing.Point(8, 72)
        Me.txtkhoak.Name = "txtkhoak"
        Me.txtkhoak.Size = New System.Drawing.Size(384, 20)
        Me.txtkhoak.TabIndex = 10
        Me.txtkhoak.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(16, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "KHOÁ K"
        '
        'txtchuoinhap
        '
        Me.txtchuoinhap.Location = New System.Drawing.Point(8, 24)
        Me.txtchuoinhap.Multiline = True
        Me.txtchuoinhap.Name = "txtchuoinhap"
        Me.txtchuoinhap.Size = New System.Drawing.Size(400, 24)
        Me.txtchuoinhap.TabIndex = 8
        Me.txtchuoinhap.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CHUỖI NHẬP"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(319, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "HOÁN VỊ P"
        '
        'txtp
        '
        Me.txtp.BackColor = System.Drawing.Color.White
        Me.txtp.Location = New System.Drawing.Point(313, 39)
        Me.txtp.Multiline = True
        Me.txtp.Name = "txtp"
        Me.txtp.Size = New System.Drawing.Size(126, 68)
        Me.txtp.TabIndex = 16
        Me.txtp.TabStop = False
        Me.txtp.Text = "16 07 20 21 29 12 28 17 01 15 23 26 05 18 31 10 02 08 24 14 32 27 03 09 19 13 30 " & _
        "06 22 11 04 25"
        '
        'txte
        '
        Me.txte.BackColor = System.Drawing.Color.White
        Me.txte.Location = New System.Drawing.Point(182, 34)
        Me.txte.Multiline = True
        Me.txte.Name = "txte"
        Me.txte.Size = New System.Drawing.Size(130, 87)
        Me.txte.TabIndex = 19
        Me.txte.TabStop = False
        Me.txte.Text = "32 01 02 03 04 05 04 05 06 07 08 09 08 09 10 11 12 13 12 13 14 15 16 17 16 17 18 " & _
        "19 20 21 20 21 22 23 24 25 24 25 26 27 28 29 28 29 30 31 32 01"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(192, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "HOÁN VỊ E"
        '
        'txtip
        '
        Me.txtip.BackColor = System.Drawing.Color.White
        Me.txtip.Location = New System.Drawing.Point(6, 31)
        Me.txtip.Multiline = True
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(172, 89)
        Me.txtip.TabIndex = 20
        Me.txtip.TabStop = False
        Me.txtip.Text = "58 50 42 34 26 18 10 02 60 52 44 36 28 20 12 04 62 54 46 38 30 22 14 06 64 56 48 " & _
        "40 32 24 16 08 57 49 41 33 25 17 09 01 59 51 43 35 27 19 11 03 61 53 45 37 29 21" & _
        " 13 05 63 55 47 39 31 23 15 07"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(36, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "HOÁN VỊ IP"
        '
        'des
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(788, 569)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "des"
        Me.Text = "des"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgs0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgs2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgs4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgs3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgs5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgs6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgs7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "khai bao biến"
    Dim str As String
    Dim s(7) As DataTable
    Dim ip() As String
    'Dim iptru() As String
    Dim e() As String
    Dim p() As String
    Dim pc1() As String
    Dim pc2() As String
    Dim daykhoa(15) As String
    Dim x As String
    Dim daynhap(29) As String
    Dim daybanma(29) As String
#End Region
#Region "khởi tạo"
    Sub khoitao_s0()
        Dim i As Integer
        s(0) = New DataTable
        For i = 0 To 15
            Dim col As DataColumn = New DataColumn
            s(0).Columns.Add(col)
        Next
        For i = 0 To 3
            Dim row As DataRow = s(0).NewRow
            s(0).Rows.Add(row)
        Next
        s(0).Rows(0).Item(0) = 14
        s(0).Rows(0).Item(1) = 4
        s(0).Rows(0).Item(2) = 13
        s(0).Rows(0).Item(3) = 1
        s(0).Rows(0).Item(4) = 2
        s(0).Rows(0).Item(5) = 15
        s(0).Rows(0).Item(6) = 11
        s(0).Rows(0).Item(7) = 8
        s(0).Rows(0).Item(8) = 3
        s(0).Rows(0).Item(9) = 10
        s(0).Rows(0).Item(10) = 6
        s(0).Rows(0).Item(11) = 12
        s(0).Rows(0).Item(12) = 5
        s(0).Rows(0).Item(13) = 9
        s(0).Rows(0).Item(14) = 0
        s(0).Rows(0).Item(15) = 7
        s(0).Rows(1).Item(0) = 0
        s(0).Rows(1).Item(1) = 15
        s(0).Rows(1).Item(2) = 7
        s(0).Rows(1).Item(3) = 4
        s(0).Rows(1).Item(4) = 14
        s(0).Rows(1).Item(5) = 2
        s(0).Rows(1).Item(6) = 13
        s(0).Rows(1).Item(7) = 1
        s(0).Rows(1).Item(8) = 10
        s(0).Rows(1).Item(9) = 6
        s(0).Rows(1).Item(10) = 12
        s(0).Rows(1).Item(11) = 11
        s(0).Rows(1).Item(12) = 9
        s(0).Rows(1).Item(13) = 5
        s(0).Rows(1).Item(14) = 3
        s(0).Rows(1).Item(15) = 8
        s(0).Rows(2).Item(0) = 4
        s(0).Rows(2).Item(1) = 1
        s(0).Rows(2).Item(2) = 14
        s(0).Rows(2).Item(3) = 8
        s(0).Rows(2).Item(4) = 13
        s(0).Rows(2).Item(5) = 6
        s(0).Rows(2).Item(6) = 2
        s(0).Rows(2).Item(7) = 11
        s(0).Rows(2).Item(8) = 15
        s(0).Rows(2).Item(9) = 12
        s(0).Rows(2).Item(10) = 9
        s(0).Rows(2).Item(11) = 7
        s(0).Rows(2).Item(12) = 3
        s(0).Rows(2).Item(13) = 10
        s(0).Rows(2).Item(14) = 5
        s(0).Rows(2).Item(15) = 0
        s(0).Rows(3).Item(0) = 15
        s(0).Rows(3).Item(1) = 12
        s(0).Rows(3).Item(2) = 8
        s(0).Rows(3).Item(3) = 2
        s(0).Rows(3).Item(4) = 4
        s(0).Rows(3).Item(5) = 9
        s(0).Rows(3).Item(6) = 1
        s(0).Rows(3).Item(7) = 7
        s(0).Rows(3).Item(8) = 5
        s(0).Rows(3).Item(9) = 11
        s(0).Rows(3).Item(10) = 3
        s(0).Rows(3).Item(11) = 14
        s(0).Rows(3).Item(12) = 10
        s(0).Rows(3).Item(13) = 0
        s(0).Rows(3).Item(14) = 6
        s(0).Rows(3).Item(15) = 13
        dgs0.DataSource = s(0)
    End Sub
    Sub khoitao_s1()
        Dim i As Integer
        s(1) = New DataTable
        For i = 0 To 15
            Dim col As DataColumn = New DataColumn
            s(1).Columns.Add(col)
        Next
        For i = 0 To 3
            Dim row As DataRow = s(1).NewRow
            s(1).Rows.Add(row)
        Next
        s(1).Rows(0).Item(0) = 15
        s(1).Rows(0).Item(1) = 1
        s(1).Rows(0).Item(2) = 8
        s(1).Rows(0).Item(3) = 14
        s(1).Rows(0).Item(4) = 6
        s(1).Rows(0).Item(5) = 11
        s(1).Rows(0).Item(6) = 3
        s(1).Rows(0).Item(7) = 4
        s(1).Rows(0).Item(8) = 9
        s(1).Rows(0).Item(9) = 7
        s(1).Rows(0).Item(10) = 2
        s(1).Rows(0).Item(11) = 13
        s(1).Rows(0).Item(12) = 12
        s(1).Rows(0).Item(13) = 0
        s(1).Rows(0).Item(14) = 5
        s(1).Rows(0).Item(15) = 10
        s(1).Rows(1).Item(0) = 3
        s(1).Rows(1).Item(1) = 13
        s(1).Rows(1).Item(2) = 4
        s(1).Rows(1).Item(3) = 7
        s(1).Rows(1).Item(4) = 15
        s(1).Rows(1).Item(5) = 2
        s(1).Rows(1).Item(6) = 8
        s(1).Rows(1).Item(7) = 14
        s(1).Rows(1).Item(8) = 12
        s(1).Rows(1).Item(9) = 0
        s(1).Rows(1).Item(10) = 1
        s(1).Rows(1).Item(11) = 10
        s(1).Rows(1).Item(12) = 6
        s(1).Rows(1).Item(13) = 9
        s(1).Rows(1).Item(14) = 11
        s(1).Rows(1).Item(15) = 5
        s(1).Rows(2).Item(0) = 0
        s(1).Rows(2).Item(1) = 14
        s(1).Rows(2).Item(2) = 7
        s(1).Rows(2).Item(3) = 11
        s(1).Rows(2).Item(4) = 10
        s(1).Rows(2).Item(5) = 4
        s(1).Rows(2).Item(6) = 13
        s(1).Rows(2).Item(7) = 1
        s(1).Rows(2).Item(8) = 5
        s(1).Rows(2).Item(9) = 8
        s(1).Rows(2).Item(10) = 12
        s(1).Rows(2).Item(11) = 6
        s(1).Rows(2).Item(12) = 9
        s(1).Rows(2).Item(13) = 3
        s(1).Rows(2).Item(14) = 2
        s(1).Rows(2).Item(15) = 15
        s(1).Rows(3).Item(0) = 13
        s(1).Rows(3).Item(1) = 8
        s(1).Rows(3).Item(2) = 10
        s(1).Rows(3).Item(3) = 1
        s(1).Rows(3).Item(4) = 3
        s(1).Rows(3).Item(5) = 15
        s(1).Rows(3).Item(6) = 4
        s(1).Rows(3).Item(7) = 2
        s(1).Rows(3).Item(8) = 11
        s(1).Rows(3).Item(9) = 6
        s(1).Rows(3).Item(10) = 7
        s(1).Rows(3).Item(11) = 12
        s(1).Rows(3).Item(12) = 0
        s(1).Rows(3).Item(13) = 5
        s(1).Rows(3).Item(14) = 14
        s(1).Rows(3).Item(15) = 9
        dgs1.DataSource = s(1)
    End Sub
    Sub khoitao_s2()
        Dim i As Integer
        s(2) = New DataTable
        For i = 0 To 15
            Dim col As DataColumn = New DataColumn
            s(2).Columns.Add(col)
        Next
        For i = 0 To 3
            Dim row As DataRow = s(2).NewRow
            s(2).Rows.Add(row)
        Next
        s(2).Rows(0).Item(0) = 10
        s(2).Rows(0).Item(1) = 0
        s(2).Rows(0).Item(2) = 9
        s(2).Rows(0).Item(3) = 14
        s(2).Rows(0).Item(4) = 6
        s(2).Rows(0).Item(5) = 3
        s(2).Rows(0).Item(6) = 15
        s(2).Rows(0).Item(7) = 5
        s(2).Rows(0).Item(8) = 1
        s(2).Rows(0).Item(9) = 13
        s(2).Rows(0).Item(10) = 12
        s(2).Rows(0).Item(11) = 7
        s(2).Rows(0).Item(12) = 11
        s(2).Rows(0).Item(13) = 4
        s(2).Rows(0).Item(14) = 2
        s(2).Rows(0).Item(15) = 8
        s(2).Rows(1).Item(0) = 13
        s(2).Rows(1).Item(1) = 7
        s(2).Rows(1).Item(2) = 0
        s(2).Rows(1).Item(3) = 9
        s(2).Rows(1).Item(4) = 3
        s(2).Rows(1).Item(5) = 4
        s(2).Rows(1).Item(6) = 6
        s(2).Rows(1).Item(7) = 10
        s(2).Rows(1).Item(8) = 2
        s(2).Rows(1).Item(9) = 8
        s(2).Rows(1).Item(10) = 5
        s(2).Rows(1).Item(11) = 14
        s(2).Rows(1).Item(12) = 12
        s(2).Rows(1).Item(13) = 11
        s(2).Rows(1).Item(14) = 15
        s(2).Rows(1).Item(15) = 1
        s(2).Rows(2).Item(0) = 13
        s(2).Rows(2).Item(1) = 6
        s(2).Rows(2).Item(2) = 4
        s(2).Rows(2).Item(3) = 9
        s(2).Rows(2).Item(4) = 8
        s(2).Rows(2).Item(5) = 15
        s(2).Rows(2).Item(6) = 3
        s(2).Rows(2).Item(7) = 0
        s(2).Rows(2).Item(8) = 11
        s(2).Rows(2).Item(9) = 1
        s(2).Rows(2).Item(10) = 2
        s(2).Rows(2).Item(11) = 12
        s(2).Rows(2).Item(12) = 5
        s(2).Rows(2).Item(13) = 10
        s(2).Rows(2).Item(14) = 14
        s(2).Rows(2).Item(15) = 7
        s(2).Rows(3).Item(0) = 1
        s(2).Rows(3).Item(1) = 10
        s(2).Rows(3).Item(2) = 13
        s(2).Rows(3).Item(3) = 0
        s(2).Rows(3).Item(4) = 6
        s(2).Rows(3).Item(5) = 9
        s(2).Rows(3).Item(6) = 8
        s(2).Rows(3).Item(7) = 7
        s(2).Rows(3).Item(8) = 4
        s(2).Rows(3).Item(9) = 15
        s(2).Rows(3).Item(10) = 14
        s(2).Rows(3).Item(11) = 3
        s(2).Rows(3).Item(12) = 11
        s(2).Rows(3).Item(13) = 5
        s(2).Rows(3).Item(14) = 3
        s(2).Rows(3).Item(15) = 12
        dgs2.DataSource = s(2)
    End Sub
    Sub khoitao_s3()
        Dim i As Integer
        s(3) = New DataTable
        For i = 0 To 15
            Dim col As DataColumn = New DataColumn
            s(3).Columns.Add(col)
        Next
        For i = 0 To 3
            Dim row As DataRow = s(3).NewRow
            s(3).Rows.Add(row)
        Next
        s(3).Rows(0).Item(0) = 7
        s(3).Rows(0).Item(1) = 13
        s(3).Rows(0).Item(2) = 14
        s(3).Rows(0).Item(3) = 3
        s(3).Rows(0).Item(4) = 0
        s(3).Rows(0).Item(5) = 6
        s(3).Rows(0).Item(6) = 9
        s(3).Rows(0).Item(7) = 10
        s(3).Rows(0).Item(8) = 1
        s(3).Rows(0).Item(9) = 2
        s(3).Rows(0).Item(10) = 8
        s(3).Rows(0).Item(11) = 5
        s(3).Rows(0).Item(12) = 11
        s(3).Rows(0).Item(13) = 12
        s(3).Rows(0).Item(14) = 4
        s(3).Rows(0).Item(15) = 15
        s(3).Rows(1).Item(0) = 13
        s(3).Rows(1).Item(1) = 8
        s(3).Rows(1).Item(2) = 11
        s(3).Rows(1).Item(3) = 5
        s(3).Rows(1).Item(4) = 6
        s(3).Rows(1).Item(5) = 15
        s(3).Rows(1).Item(6) = 0
        s(3).Rows(1).Item(7) = 3
        s(3).Rows(1).Item(8) = 4
        s(3).Rows(1).Item(9) = 7
        s(3).Rows(1).Item(10) = 2
        s(3).Rows(1).Item(11) = 12
        s(3).Rows(1).Item(12) = 1
        s(3).Rows(1).Item(13) = 10
        s(3).Rows(1).Item(14) = 14
        s(3).Rows(1).Item(15) = 9
        s(3).Rows(2).Item(0) = 10
        s(3).Rows(2).Item(1) = 6
        s(3).Rows(2).Item(2) = 9
        s(3).Rows(2).Item(3) = 0
        s(3).Rows(2).Item(4) = 12
        s(3).Rows(2).Item(5) = 11
        s(3).Rows(2).Item(6) = 7
        s(3).Rows(2).Item(7) = 13
        s(3).Rows(2).Item(8) = 15
        s(3).Rows(2).Item(9) = 1
        s(3).Rows(2).Item(10) = 3
        s(3).Rows(2).Item(11) = 14
        s(3).Rows(2).Item(12) = 5
        s(3).Rows(2).Item(13) = 2
        s(3).Rows(2).Item(14) = 8
        s(3).Rows(2).Item(15) = 4
        s(3).Rows(3).Item(0) = 3
        s(3).Rows(3).Item(1) = 15
        s(3).Rows(3).Item(2) = 0
        s(3).Rows(3).Item(3) = 6
        s(3).Rows(3).Item(4) = 10
        s(3).Rows(3).Item(5) = 1
        s(3).Rows(3).Item(6) = 13
        s(3).Rows(3).Item(7) = 8
        s(3).Rows(3).Item(8) = 9
        s(3).Rows(3).Item(9) = 4
        s(3).Rows(3).Item(10) = 5
        s(3).Rows(3).Item(11) = 11
        s(3).Rows(3).Item(12) = 12
        s(3).Rows(3).Item(13) = 7
        s(3).Rows(3).Item(14) = 2
        s(3).Rows(3).Item(15) = 14
        dgs3.DataSource = s(3)
    End Sub
    Sub khoitao_s4()
        Dim i As Integer
        s(4) = New DataTable
        For i = 0 To 15
            Dim col As DataColumn = New DataColumn
            s(4).Columns.Add(col)
        Next
        For i = 0 To 3
            Dim row As DataRow = s(4).NewRow
            s(4).Rows.Add(row)
        Next
        s(4).Rows(0).Item(0) = 2
        s(4).Rows(0).Item(1) = 12
        s(4).Rows(0).Item(2) = 4
        s(4).Rows(0).Item(3) = 1
        s(4).Rows(0).Item(4) = 7
        s(4).Rows(0).Item(5) = 10
        s(4).Rows(0).Item(6) = 11
        s(4).Rows(0).Item(7) = 6
        s(4).Rows(0).Item(8) = 8
        s(4).Rows(0).Item(9) = 5
        s(4).Rows(0).Item(10) = 3
        s(4).Rows(0).Item(11) = 15
        s(4).Rows(0).Item(12) = 13
        s(4).Rows(0).Item(13) = 0
        s(4).Rows(0).Item(14) = 14
        s(4).Rows(0).Item(15) = 9
        s(4).Rows(1).Item(0) = 14
        s(4).Rows(1).Item(1) = 11
        s(4).Rows(1).Item(2) = 2
        s(4).Rows(1).Item(3) = 12
        s(4).Rows(1).Item(4) = 4
        s(4).Rows(1).Item(5) = 7
        s(4).Rows(1).Item(6) = 13
        s(4).Rows(1).Item(7) = 1
        s(4).Rows(1).Item(8) = 5
        s(4).Rows(1).Item(9) = 0
        s(4).Rows(1).Item(10) = 15
        s(4).Rows(1).Item(11) = 10
        s(4).Rows(1).Item(12) = 3
        s(4).Rows(1).Item(13) = 9
        s(4).Rows(1).Item(14) = 8
        s(4).Rows(1).Item(15) = 6
        s(4).Rows(2).Item(0) = 4
        s(4).Rows(2).Item(1) = 2
        s(4).Rows(2).Item(2) = 1
        s(4).Rows(2).Item(3) = 11
        s(4).Rows(2).Item(4) = 10
        s(4).Rows(2).Item(5) = 13
        s(4).Rows(2).Item(6) = 7
        s(4).Rows(2).Item(7) = 8
        s(4).Rows(2).Item(8) = 15
        s(4).Rows(2).Item(9) = 9
        s(4).Rows(2).Item(10) = 12
        s(4).Rows(2).Item(11) = 5
        s(4).Rows(2).Item(12) = 6
        s(4).Rows(2).Item(13) = 3
        s(4).Rows(2).Item(14) = 0
        s(4).Rows(2).Item(15) = 14
        s(4).Rows(3).Item(0) = 11
        s(4).Rows(3).Item(1) = 8
        s(4).Rows(3).Item(2) = 12
        s(4).Rows(3).Item(3) = 7
        s(4).Rows(3).Item(4) = 0
        s(4).Rows(3).Item(5) = 14
        s(4).Rows(3).Item(6) = 2
        s(4).Rows(3).Item(7) = 13
        s(4).Rows(3).Item(8) = 6
        s(4).Rows(3).Item(9) = 15
        s(4).Rows(3).Item(10) = 0
        s(4).Rows(3).Item(11) = 9
        s(4).Rows(3).Item(12) = 10
        s(4).Rows(3).Item(13) = 4
        s(4).Rows(3).Item(14) = 5
        s(4).Rows(3).Item(15) = 3
        dgs4.DataSource = s(4)
    End Sub
    Sub khoitao_s5()
        Dim i As Integer
        s(5) = New DataTable
        For i = 0 To 15
            Dim col As DataColumn = New DataColumn
            s(5).Columns.Add(col)
        Next
        For i = 0 To 3
            Dim row As DataRow = s(5).NewRow
            s(5).Rows.Add(row)
        Next
        s(5).Rows(0).Item(0) = 12
        s(5).Rows(0).Item(1) = 1
        s(5).Rows(0).Item(2) = 10
        s(5).Rows(0).Item(3) = 15
        s(5).Rows(0).Item(4) = 9
        s(5).Rows(0).Item(5) = 2
        s(5).Rows(0).Item(6) = 6
        s(5).Rows(0).Item(7) = 8
        s(5).Rows(0).Item(8) = 0
        s(5).Rows(0).Item(9) = 13
        s(5).Rows(0).Item(10) = 3
        s(5).Rows(0).Item(11) = 4
        s(5).Rows(0).Item(12) = 14
        s(5).Rows(0).Item(13) = 7
        s(5).Rows(0).Item(14) = 5
        s(5).Rows(0).Item(15) = 11
        s(5).Rows(1).Item(0) = 10
        s(5).Rows(1).Item(1) = 15
        s(5).Rows(1).Item(2) = 4
        s(5).Rows(1).Item(3) = 2
        s(5).Rows(1).Item(4) = 7
        s(5).Rows(1).Item(5) = 12
        s(5).Rows(1).Item(6) = 9
        s(5).Rows(1).Item(7) = 5
        s(5).Rows(1).Item(8) = 6
        s(5).Rows(1).Item(9) = 1
        s(5).Rows(1).Item(10) = 13
        s(5).Rows(1).Item(11) = 14
        s(5).Rows(1).Item(12) = 0
        s(5).Rows(1).Item(13) = 11
        s(5).Rows(1).Item(14) = 3
        s(5).Rows(1).Item(15) = 8
        s(5).Rows(2).Item(0) = 9
        s(5).Rows(2).Item(1) = 14
        s(5).Rows(2).Item(2) = 15
        s(5).Rows(2).Item(3) = 5
        s(5).Rows(2).Item(4) = 2
        s(5).Rows(2).Item(5) = 8
        s(5).Rows(2).Item(6) = 12
        s(5).Rows(2).Item(7) = 3
        s(5).Rows(2).Item(8) = 7
        s(5).Rows(2).Item(9) = 0
        s(5).Rows(2).Item(10) = 4
        s(5).Rows(2).Item(11) = 10
        s(5).Rows(2).Item(12) = 1
        s(5).Rows(2).Item(13) = 13
        s(5).Rows(2).Item(14) = 11
        s(5).Rows(2).Item(15) = 6
        s(5).Rows(3).Item(0) = 4
        s(5).Rows(3).Item(1) = 3
        s(5).Rows(3).Item(2) = 2
        s(5).Rows(3).Item(3) = 12
        s(5).Rows(3).Item(4) = 9
        s(5).Rows(3).Item(5) = 5
        s(5).Rows(3).Item(6) = 15
        s(5).Rows(3).Item(7) = 10
        s(5).Rows(3).Item(8) = 11
        s(5).Rows(3).Item(9) = 14
        s(5).Rows(3).Item(10) = 1
        s(5).Rows(3).Item(11) = 7
        s(5).Rows(3).Item(12) = 6
        s(5).Rows(3).Item(13) = 0
        s(5).Rows(3).Item(14) = 8
        s(5).Rows(3).Item(15) = 13
        dgs5.DataSource = s(5)
    End Sub
    Sub khoitao_s6()
        Dim i As Integer
        s(6) = New DataTable
        For i = 0 To 15
            Dim col As DataColumn = New DataColumn
            s(6).Columns.Add(col)
        Next
        For i = 0 To 3
            Dim row As DataRow = s(6).NewRow
            s(6).Rows.Add(row)
        Next
        s(6).Rows(0).Item(0) = 4
        s(6).Rows(0).Item(1) = 11
        s(6).Rows(0).Item(2) = 2
        s(6).Rows(0).Item(3) = 14
        s(6).Rows(0).Item(4) = 15
        s(6).Rows(0).Item(5) = 0
        s(6).Rows(0).Item(6) = 8
        s(6).Rows(0).Item(7) = 13
        s(6).Rows(0).Item(8) = 3
        s(6).Rows(0).Item(9) = 12
        s(6).Rows(0).Item(10) = 9
        s(6).Rows(0).Item(11) = 7
        s(6).Rows(0).Item(12) = 5
        s(6).Rows(0).Item(13) = 10
        s(6).Rows(0).Item(14) = 6
        s(6).Rows(0).Item(15) = 1
        s(6).Rows(1).Item(0) = 13
        s(6).Rows(1).Item(1) = 0
        s(6).Rows(1).Item(2) = 11
        s(6).Rows(1).Item(3) = 7
        s(6).Rows(1).Item(4) = 4
        s(6).Rows(1).Item(5) = 9
        s(6).Rows(1).Item(6) = 1
        s(6).Rows(1).Item(7) = 10
        s(6).Rows(1).Item(8) = 14
        s(6).Rows(1).Item(9) = 3
        s(6).Rows(1).Item(10) = 5
        s(6).Rows(1).Item(11) = 12
        s(6).Rows(1).Item(12) = 2
        s(6).Rows(1).Item(13) = 15
        s(6).Rows(1).Item(14) = 8
        s(6).Rows(1).Item(15) = 6
        s(6).Rows(2).Item(0) = 1
        s(6).Rows(2).Item(1) = 4
        s(6).Rows(2).Item(2) = 11
        s(6).Rows(2).Item(3) = 13
        s(6).Rows(2).Item(4) = 12
        s(6).Rows(2).Item(5) = 3
        s(6).Rows(2).Item(6) = 7
        s(6).Rows(2).Item(7) = 14
        s(6).Rows(2).Item(8) = 10
        s(6).Rows(2).Item(9) = 15
        s(6).Rows(2).Item(10) = 6
        s(6).Rows(2).Item(11) = 8
        s(6).Rows(2).Item(12) = 0
        s(6).Rows(2).Item(13) = 5
        s(6).Rows(2).Item(14) = 9
        s(6).Rows(2).Item(15) = 2
        s(6).Rows(3).Item(0) = 6
        s(6).Rows(3).Item(1) = 11
        s(6).Rows(3).Item(2) = 13
        s(6).Rows(3).Item(3) = 8
        s(6).Rows(3).Item(4) = 1
        s(6).Rows(3).Item(5) = 4
        s(6).Rows(3).Item(6) = 10
        s(6).Rows(3).Item(7) = 7
        s(6).Rows(3).Item(8) = 9
        s(6).Rows(3).Item(9) = 5
        s(6).Rows(3).Item(10) = 0
        s(6).Rows(3).Item(11) = 15
        s(6).Rows(3).Item(12) = 14
        s(6).Rows(3).Item(13) = 2
        s(6).Rows(3).Item(14) = 3
        s(6).Rows(3).Item(15) = 12
        dgs6.DataSource = s(6)
    End Sub
    Sub khoitao_s7()
        Dim i As Integer
        s(7) = New DataTable
        For i = 0 To 15
            Dim col As DataColumn = New DataColumn
            s(7).Columns.Add(col)
        Next
        For i = 0 To 3
            Dim row As DataRow = s(7).NewRow
            s(7).Rows.Add(row)
        Next
        s(7).Rows(0).Item(0) = 13
        s(7).Rows(0).Item(1) = 2
        s(7).Rows(0).Item(2) = 8
        s(7).Rows(0).Item(3) = 4
        s(7).Rows(0).Item(4) = 6
        s(7).Rows(0).Item(5) = 15
        s(7).Rows(0).Item(6) = 11
        s(7).Rows(0).Item(7) = 1
        s(7).Rows(0).Item(8) = 10
        s(7).Rows(0).Item(9) = 9
        s(7).Rows(0).Item(10) = 3
        s(7).Rows(0).Item(11) = 14
        s(7).Rows(0).Item(12) = 5
        s(7).Rows(0).Item(13) = 0
        s(7).Rows(0).Item(14) = 12
        s(7).Rows(0).Item(15) = 7
        s(7).Rows(1).Item(0) = 1
        s(7).Rows(1).Item(1) = 15
        s(7).Rows(1).Item(2) = 13
        s(7).Rows(1).Item(3) = 8
        s(7).Rows(1).Item(4) = 10
        s(7).Rows(1).Item(5) = 3
        s(7).Rows(1).Item(6) = 7
        s(7).Rows(1).Item(7) = 4
        s(7).Rows(1).Item(8) = 12
        s(7).Rows(1).Item(9) = 5
        s(7).Rows(1).Item(10) = 6
        s(7).Rows(1).Item(11) = 11
        s(7).Rows(1).Item(12) = 0
        s(7).Rows(1).Item(13) = 14
        s(7).Rows(1).Item(14) = 9
        s(7).Rows(1).Item(15) = 2
        s(7).Rows(2).Item(0) = 7
        s(7).Rows(2).Item(1) = 11
        s(7).Rows(2).Item(2) = 4
        s(7).Rows(2).Item(3) = 1
        s(7).Rows(2).Item(4) = 9
        s(7).Rows(2).Item(5) = 12
        s(7).Rows(2).Item(6) = 14
        s(7).Rows(2).Item(7) = 2
        s(7).Rows(2).Item(8) = 0
        s(7).Rows(2).Item(9) = 6
        s(7).Rows(2).Item(10) = 10
        s(7).Rows(2).Item(11) = 13
        s(7).Rows(2).Item(12) = 15
        s(7).Rows(2).Item(13) = 3
        s(7).Rows(2).Item(14) = 5
        s(7).Rows(2).Item(15) = 8
        s(7).Rows(3).Item(0) = 2
        s(7).Rows(3).Item(1) = 1
        s(7).Rows(3).Item(2) = 14
        s(7).Rows(3).Item(3) = 7
        s(7).Rows(3).Item(4) = 4
        s(7).Rows(3).Item(5) = 10
        s(7).Rows(3).Item(6) = 8
        s(7).Rows(3).Item(7) = 13
        s(7).Rows(3).Item(8) = 15
        s(7).Rows(3).Item(9) = 12
        s(7).Rows(3).Item(10) = 9
        s(7).Rows(3).Item(11) = 0
        s(7).Rows(3).Item(12) = 3
        s(7).Rows(3).Item(13) = 5
        s(7).Rows(3).Item(14) = 6
        s(7).Rows(3).Item(15) = 11
        dgs7.DataSource = s(7)
    End Sub
    Sub khoitao()
        ip = txtip.Text.Split(" ", ";", ":", ".")
        'iptru = txtiptru.Text.Split(" ", " ", ";", ":", ".")
        e = txte.Text.Split(" ", ";", ":", ".")
        p = txtp.Text.Split(" ", ";", ":", ".")
        pc1 = txtpc1.Text.Split(" ", ";", ":", ".")
        pc2 = txtpc2.Text.Split(" ", ";", ":", ".")
        khoitao_s0()
        khoitao_s1()
        khoitao_s2()
        khoitao_s3()
        khoitao_s4()
        khoitao_s5()
        khoitao_s6()
        khoitao_s7()
    End Sub
#End Region
#Region "tạo dãy khóa "
    Function catbitcuoi(ByVal k As String) As String 'dua vao 64 bit tra ra 56 bit
        Dim i As Integer = 0
        Dim j As Integer
        Dim tam As String
        While i < 63
            For j = i To i + 6
                tam += k.Substring(j, 1)
            Next
            i = i + 8
        End While
        Return tam
    End Function
    Function hvpc1(ByVal k As String) As String
        Dim tam(63) As Char
        Dim i As Integer
        For i = 0 To 63
            tam(i) = k.Substring(i, 1)
        Next
        tam = catbitcuoi(tam)
        For i = 0 To 55
            tam(i) = k.Substring(Integer.Parse(pc1(i) - 1), 1)
        Next
        Return tam
    End Function
    Function hvpc2(ByVal str As String) As String
        Dim tam(47) As Char
        Dim i As Integer
        For i = 0 To 47
            tam(i) = str.Substring(Integer.Parse(pc2(i) - 1), 1)
        Next
        Return tam
    End Function
    Function ls(ByVal s As String, ByVal n As Integer) As String
        Return s.Substring(n, s.Length - n) + s.Substring(0, n)
    End Function
    Sub taodaykhoa()
        'Dim khoa As String = "0001001100110100010101110111100110011011101111001101111111110001" 'txtkhoak.Text
        Dim khoa As String = txtkhoak.Text
        Dim j As Integer
        If khoa.Length > 8 Then
            khoa = txtkhoak.Text.Remove(8, khoa.Length - 8)
            txtkhoak.Text = khoa
        End If
        Dim tam As String
        For j = 0 To khoa.Length - 1
            tam += bi_acsii(Asc(khoa.Substring(j, 1)))
        Next
        khoa = tam
        Dim khoa1 As String = hvpc1(khoa)
        Dim d(16) As String
        Dim c(16) As String
        c(0) = khoa1.Substring(0, 28)
        c(0) = ls(c(0), 1)
        d(0) = khoa1.Substring(28, 28)
        d(0) = ls(d(0), 1)
        daykhoa(0) = hvpc2(c(0) + d(0))
        txtdaykhoa.Text += daykhoa(0) + Chr(9)
        Dim i As Integer
        For i = 1 To 15
            If i = 2 - 1 Or i = 9 - 1 Or i = 16 - 1 Then
                c(i) = ls(c(i - 1), 1)
                d(i) = ls(d(i - 1), 1)
            Else
                c(i) = ls(c(i - 1), 2)
                d(i) = ls(d(i - 1), 2)
            End If
            daykhoa(i) = hvpc2(c(i) + d(i))
            txtdaykhoa.Text += daykhoa(i) + Chr(9)
        Next i
    End Sub
#End Region
#Region "xử lí chuỗi nhập"
    Sub binarynhap()
        x = txtchuoinhap.Text
        Dim y As String
        Dim i As Integer
        Dim j As Integer
        Dim sokitudu As Integer = x.Length Mod 8
        If sokitudu > 0 Then
            Dim sokituthem As Integer = 8 - sokitudu
            For i = 1 To sokituthem
                x += " "
            Next
        End If
        Dim sodaynhap As Integer = x.Length \ 8
        ReDim daynhap(sodaynhap - 1)
        For i = 0 To sodaynhap - 1
            daynhap(i) = x.Substring(i * 8, 8)
            y = ""
            For j = 0 To daynhap(i).Length - 1
                y += bi_acsii(Asc(daynhap(i).Substring(j, 1)))
            Next
            daynhap(i) = y
        Next
    End Sub
    Function bi_acsii(ByVal int As Integer) As String
        Dim tam(7) As Char
        Dim i As Integer
        For i = 0 To 7
            tam(i) = (int Mod 2).ToString
            int \= 2
        Next
        Array.Reverse(tam)
        Return tam
    End Function
#End Region
#Region "mã hoá"
    Function hvip(ByVal x As String) As String
        Dim tam(63) As Char
        Dim i As Integer
        For i = 0 To 63
            tam(i) = x.Substring(ip(i) - 1, 1)
        Next
        Return tam
    End Function
    Function hve(ByVal r As String) As String
        Dim tam(47) As Char
        Dim i As Integer
        For i = 0 To 47
            tam(i) = r.Substring(e(i) - 1, 1)
        Next
        Return tam
    End Function
    Function hvp(ByVal c As String) As String
        Dim tam(31) As Char
        Dim i As Integer
        For i = 0 To 31
            tam(i) = c.Substring(p(i) - 1, 1)
        Next
        Return tam
    End Function
    Function hviptru(ByVal c As String) As String
        Dim tam(63) As Char
        Dim i As Integer
        For i = 0 To 63
            tam(ip(i) - 1) = c.Substring(i, 1)
        Next
        Return tam
    End Function
    Function mahoa() As String
        binarynhap()
        Dim k As Integer
        Dim y As String
        For k = 0 To daynhap.Length - 1
            'x += "0000000100100011010001010110011110001001101010101100110111101111"  
            x = daynhap(k)
            Dim x0 As String = hvip(x)
            Dim l(15) As String
            Dim r(15) As String
            Dim i, j As Integer
            Dim l0 As String = x0.Substring(0, 32)
            Dim r0 As String = x0.Substring(32, 32)
            l(0) = r0
            For i = 0 To 31
                r(0) += (l0.Substring(i, 1) Xor f(r0, daykhoa(0)).Substring(i, 1)).ToString
            Next
            For i = 1 To 15
                l(i) = r(i - 1)
                Dim a As String = f(r(i - 1), daykhoa(i))
                For j = 0 To 31
                    r(i) += (l(i - 1).Substring(j, 1) Xor a.Substring(j, 1)).ToString
                Next j
            Next i
            Dim v As String = hviptru(r(15) + l(15))
            y += v
        Next k
        Return y
    End Function
    Function f(ByVal r As String, ByVal k As String) As String
        Dim i As Integer
        Dim e As String
        Dim hv As String = hve(r)
        For i = 0 To 47
            e += (hv.Substring(i, 1) Xor k.Substring(i, 1)).ToString
        Next
        Dim b(7) As String
        Dim c As String
        For i = 0 To 7
            b(i) = e.Substring(i * 6, 6)
            Dim haibitcuoi As String = b(i).Substring(0, 1) + b(i).Substring(5, 1)
            Dim bonbitgiua As String = b(i).Substring(1, 4)
            Dim srow = thapphan(haibitcuoi)
            Dim scol = thapphan(bonbitgiua)
            Dim sij As Integer = s(i).Rows(srow).Item(scol)
            c += binary(sij)
        Next
        c = hvp(c)
        Return c
    End Function
    Function thapphan(ByVal b As String) As Integer
        Dim i As Integer
        Dim tam As Integer = 0
        For i = 0 To b.Length - 1
            If b.Substring(i, 1) = 1 Then
                tam += 2 ^ (b.Length - 1 - i)
            End If
        Next
        Return tam
    End Function
    Function binary(ByVal a As Integer) As String
        Dim i As Integer
        Dim tam(3) As Char
        For i = 0 To 3
            tam(i) = (a Mod 2).ToString
            a = a \ 2
        Next
        Array.Reverse(tam)
        Return tam
    End Function
    Function doirachu(ByVal y As String) As String
        Dim tam As String = y
        Dim tam1 As String = ""
        Dim so As Integer
        Dim i As Integer
        Dim j As Integer
        While i < tam.Length - 1
            so = 0
            For j = i To i + 7
                If tam.Substring(j, 1) = 1 Then
                    so += 2 ^ (7 - (j - i))
                End If
            Next
            tam1 += Chr(so)
            i = i + 8
        End While
        Return tam1
    End Function
#End Region
#Region "giải mã"
    Sub binaybanma()
        Dim sodaybanma = txtbanma.Text.Length \ 8
        Dim i, j As Integer
        Dim tam As String
        ReDim daybanma(sodaybanma - 1)
        For i = 0 To sodaybanma - 1
            daybanma(i) = txtbanma.Text.Substring(i * 8, 8)
            tam = ""
            For j = 0 To daybanma(i).Length - 1
                tam += bi_acsii(Asc(daybanma(i).Substring(j, 1)))
            Next
            daybanma(i) = tam
        Next i
    End Sub
    Function giaima() As String
        binaybanma()
        Dim k As Integer
        x = ""
        For k = 0 To daybanma.Length - 1
            Dim y0 As String = hvip(daybanma(k))
            Dim rr As String = y0.Substring(0, 32)
            Dim ll As String = y0.Substring(32, 32)
            Dim i, j As Integer
            Dim l(15) As String
            Dim r(15) As String
            r(15) = ll
            For i = 0 To 31
                l(15) += (rr.Substring(i, 1) Xor f(ll, daykhoa(15)).Substring(i, 1)).ToString
            Next
            For i = 14 To 0 Step -1
                r(i) = l(i + 1)
                Dim a As String = f(l(i + 1), daykhoa(i))
                For j = 0 To 31
                    l(i) += (r(i + 1).Substring(j, 1) Xor a.Substring(j, 1)).ToString
                Next j
            Next i
            x += hviptru(l(0) + r(0))
        Next k
        Return x
    End Function
#End Region
#Region "các sự kiện"
    Private Sub des_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        khoitao()
    End Sub
    Private Sub btlapma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlapma.Click
        khoitao()
        If txtchuoinhap.Text = "" Then
            MessageBox.Show("Bạn hãy nhập vào chuỗi cần mã hoá")
            txtchuoinhap.Focus()
            Return
        End If
        If txtkhoak.Text = "" Or txtkhoak.Text.Length < 8 Then
            MessageBox.Show("Bạn hãy nhập vào khóa :8 kí tự")
            txtkhoak.Focus()
            Return
        End If
        txtdaykhoa.Text = ""
        taodaykhoa()
        txtbanmabit.Text = mahoa()
        txtbanma.Text = doirachu(mahoa())
    End Sub
    Private Sub btthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btthoat.Click
        Me.Close()
    End Sub
    Private Sub btgiaima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btgiaima.Click
        If txtkhoak.Text = "" Or txtkhoak.Text.Length < 8 Then
            MessageBox.Show("Bạn hãy nhập khóa : 8 kí tự")
            txtkhoak.Focus()
            Return
        End If
        If txtbanma.Text = "" Then
            MessageBox.Show("Bạn hãy nhập vào chuỗi cần giải mã")
            txtbanma.Focus()
            Return
        End If
        txtdaykhoa.Text = ""
        taodaykhoa()
        txtbanrobit.Text = giaima()
        txtbanro.Text = doirachu(giaima())
    End Sub
#End Region

   
    
   
End Class
