Imports System.Windows.Forms
Public Class thammades
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
    Friend WithEvents btthamma As System.Windows.Forms.Button
    Friend WithEvents btthoat As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbthongbao As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbanma As System.Windows.Forms.TextBox
    Friend WithEvents txtbanro As System.Windows.Forms.TextBox
    Friend WithEvents txtkhoav3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkhoa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btthamma = New System.Windows.Forms.Button
        Me.btthoat = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbthongbao = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbanma = New System.Windows.Forms.TextBox
        Me.txtbanro = New System.Windows.Forms.TextBox
        Me.txtkhoav3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtkhoa = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btthamma
        '
        Me.btthamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthamma.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btthamma.Location = New System.Drawing.Point(280, 432)
        Me.btthamma.Name = "btthamma"
        Me.btthamma.Size = New System.Drawing.Size(72, 24)
        Me.btthamma.TabIndex = 11
        Me.btthamma.Text = "THÁM MÃ"
        '
        'btthoat
        '
        Me.btthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btthoat.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btthoat.Location = New System.Drawing.Point(368, 432)
        Me.btthoat.Name = "btthoat"
        Me.btthoat.TabIndex = 21
        Me.btthoat.Text = "THOÁT"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("VNI-Helve", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(152, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 48)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "THAÙM MAÕ DES"
        '
        'lbthongbao
        '
        Me.lbthongbao.ForeColor = System.Drawing.Color.Red
        Me.lbthongbao.Location = New System.Drawing.Point(32, 400)
        Me.lbthongbao.Name = "lbthongbao"
        Me.lbthongbao.Size = New System.Drawing.Size(624, 23)
        Me.lbthongbao.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtkhoav3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtkhoa)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtbanro)
        Me.GroupBox1.Controls.Add(Me.txtbanma)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 336)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(344, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "BẢN MÃ :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(24, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "BẢN RÕ :"
        '
        'txtbanma
        '
        Me.txtbanma.Location = New System.Drawing.Point(336, 144)
        Me.txtbanma.Multiline = True
        Me.txtbanma.Name = "txtbanma"
        Me.txtbanma.Size = New System.Drawing.Size(288, 184)
        Me.txtbanma.TabIndex = 32
        Me.txtbanma.Text = ""
        '
        'txtbanro
        '
        Me.txtbanro.Location = New System.Drawing.Point(16, 144)
        Me.txtbanro.Multiline = True
        Me.txtbanro.Name = "txtbanro"
        Me.txtbanro.Size = New System.Drawing.Size(288, 184)
        Me.txtbanro.TabIndex = 33
        Me.txtbanro.Text = ""
        '
        'txtkhoav3
        '
        Me.txtkhoav3.Location = New System.Drawing.Point(16, 40)
        Me.txtkhoav3.Name = "txtkhoav3"
        Me.txtkhoav3.Size = New System.Drawing.Size(608, 20)
        Me.txtkhoav3.TabIndex = 37
        Me.txtkhoav3.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "KHÓA  VÒNG 3 :"
        '
        'txtkhoa
        '
        Me.txtkhoa.Location = New System.Drawing.Point(16, 88)
        Me.txtkhoa.Name = "txtkhoa"
        Me.txtkhoa.Size = New System.Drawing.Size(608, 20)
        Me.txtkhoa.TabIndex = 35
        Me.txtkhoa.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(16, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 23)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "KHÓA K :"
        '
        'thammades
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(680, 469)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btthoat)
        Me.Controls.Add(Me.btthamma)
        Me.Controls.Add(Me.lbthongbao)
        Me.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Name = "thammades"
        Me.Text = "THÁM MÃ DES"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim banro() As String
    Dim banma() As String
    Dim hve(47) As Integer
    Dim hvp(31) As Integer
    Dim hvpc2(47) As Integer
    Dim hvpc1(55) As Integer
    Dim hvip(63) As Integer
    Dim e() As String
    Dim esao() As String
    Dim ephay() As String
    Dim cphay() As String
    Dim jhop(7, 63) As Integer
    Dim s(7) As DataTable
    Dim chuoikhoa(255) As String
    Dim daykhoa(2) As String
    Dim n As Integer '6 ban ro va 6 ban ma
    Const m = 16 '8 ki tu
    Const hebit = 4 'he 256
    Dim flag As Boolean
#Region "khoi tao"
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
    End Sub
    Sub khoitao_hve()
        hve(0) = 32
        hve(1) = 1
        hve(2) = 2
        hve(3) = 3
        hve(4) = 4
        hve(5) = 5
        hve(6) = 4
        hve(7) = 5
        hve(8) = 6
        hve(9) = 7
        hve(10) = 8
        hve(11) = 9
        hve(12) = 8
        hve(13) = 9
        hve(14) = 10
        hve(15) = 11
        hve(16) = 12
        hve(17) = 13
        hve(18) = 12
        hve(19) = 13
        hve(20) = 14
        hve(21) = 15
        hve(22) = 16
        hve(23) = 17
        hve(24) = 16
        hve(25) = 17
        hve(26) = 18
        hve(27) = 19
        hve(28) = 20
        hve(29) = 21
        hve(30) = 20
        hve(31) = 21
        hve(32) = 22
        hve(33) = 23
        hve(34) = 24
        hve(35) = 25
        hve(36) = 24
        hve(37) = 25
        hve(38) = 26
        hve(39) = 27
        hve(40) = 28
        hve(41) = 29
        hve(42) = 28
        hve(43) = 29
        hve(44) = 30
        hve(45) = 31
        hve(46) = 32
        hve(47) = 1
    End Sub
    Sub khoitao_hvp()
        hvp(0) = 16
        hvp(1) = 7
        hvp(2) = 20
        hvp(3) = 21
        hvp(4) = 29
        hvp(5) = 12
        hvp(6) = 28
        hvp(7) = 17
        hvp(8) = 1
        hvp(9) = 15
        hvp(10) = 23
        hvp(11) = 26
        hvp(12) = 5
        hvp(13) = 18
        hvp(14) = 31
        hvp(15) = 10
        hvp(16) = 2
        hvp(17) = 8
        hvp(18) = 24
        hvp(19) = 14
        hvp(20) = 32
        hvp(21) = 27
        hvp(22) = 3
        hvp(23) = 9
        hvp(24) = 19
        hvp(25) = 13
        hvp(26) = 30
        hvp(27) = 6
        hvp(28) = 22
        hvp(29) = 11
        hvp(30) = 4
        hvp(31) = 25
    End Sub
    Sub khoitao_hvpc2()
        hvpc2(0) = 14
        hvpc2(1) = 17
        hvpc2(2) = 11
        hvpc2(3) = 24
        hvpc2(4) = 1
        hvpc2(5) = 5
        hvpc2(6) = 3
        hvpc2(7) = 28
        hvpc2(8) = 15
        hvpc2(9) = 6
        hvpc2(10) = 21
        hvpc2(11) = 10
        hvpc2(12) = 23
        hvpc2(13) = 19
        hvpc2(14) = 12
        hvpc2(15) = 4
        hvpc2(16) = 26
        hvpc2(17) = 8
        hvpc2(18) = 16
        hvpc2(19) = 7
        hvpc2(20) = 27
        hvpc2(21) = 20
        hvpc2(22) = 13
        hvpc2(23) = 2
        hvpc2(24) = 41
        hvpc2(25) = 52
        hvpc2(26) = 31
        hvpc2(27) = 37
        hvpc2(28) = 47
        hvpc2(29) = 55
        hvpc2(30) = 30
        hvpc2(31) = 40
        hvpc2(32) = 51
        hvpc2(33) = 45
        hvpc2(34) = 33
        hvpc2(35) = 48
        hvpc2(36) = 44
        hvpc2(37) = 49
        hvpc2(38) = 39
        hvpc2(39) = 56
        hvpc2(40) = 34
        hvpc2(41) = 53
        hvpc2(42) = 46
        hvpc2(43) = 42
        hvpc2(44) = 50
        hvpc2(45) = 36
        hvpc2(46) = 29
        hvpc2(47) = 32
    End Sub
    Sub khoitao_hvpc1()
        hvpc1(0) = 57
        hvpc1(1) = 49
        hvpc1(2) = 41
        hvpc1(3) = 33
        hvpc1(4) = 25
        hvpc1(5) = 17
        hvpc1(6) = 9
        hvpc1(7) = 1
        hvpc1(8) = 58
        hvpc1(9) = 50
        hvpc1(10) = 42
        hvpc1(11) = 34
        hvpc1(12) = 26
        hvpc1(13) = 18
        hvpc1(14) = 10
        hvpc1(15) = 2
        hvpc1(16) = 59
        hvpc1(17) = 51
        hvpc1(18) = 43
        hvpc1(19) = 35
        hvpc1(20) = 27
        hvpc1(21) = 19
        hvpc1(22) = 11
        hvpc1(23) = 3
        hvpc1(24) = 60
        hvpc1(25) = 52
        hvpc1(26) = 44
        hvpc1(27) = 36
        hvpc1(28) = 63
        hvpc1(29) = 55
        hvpc1(30) = 47
        hvpc1(31) = 39
        hvpc1(32) = 31
        hvpc1(33) = 23
        hvpc1(34) = 15
        hvpc1(35) = 7
        hvpc1(36) = 62
        hvpc1(37) = 54
        hvpc1(38) = 46
        hvpc1(39) = 38
        hvpc1(40) = 30
        hvpc1(41) = 22
        hvpc1(42) = 14
        hvpc1(43) = 6
        hvpc1(44) = 61
        hvpc1(45) = 53
        hvpc1(46) = 45
        hvpc1(47) = 37
        hvpc1(48) = 29
        hvpc1(49) = 21
        hvpc1(50) = 13
        hvpc1(51) = 5
        hvpc1(52) = 28
        hvpc1(53) = 20
        hvpc1(54) = 12
        hvpc1(55) = 4
    End Sub
    Sub khoitao_hvip()
        hvip(0) = 58
        hvip(1) = 50
        hvip(2) = 42
        hvip(3) = 34
        hvip(4) = 26
        hvip(5) = 18
        hvip(6) = 10
        hvip(7) = 2
        hvip(8) = 60
        hvip(9) = 52
        hvip(10) = 44
        hvip(11) = 36
        hvip(12) = 28
        hvip(13) = 20
        hvip(14) = 12
        hvip(15) = 4
        hvip(16) = 62
        hvip(17) = 54
        hvip(18) = 46
        hvip(19) = 38
        hvip(20) = 30
        hvip(21) = 22
        hvip(22) = 14
        hvip(23) = 6
        hvip(24) = 64
        hvip(25) = 56
        hvip(26) = 48
        hvip(27) = 40
        hvip(28) = 32
        hvip(29) = 24
        hvip(30) = 16
        hvip(31) = 8
        hvip(32) = 57
        hvip(33) = 49
        hvip(34) = 41
        hvip(35) = 33
        hvip(36) = 25
        hvip(37) = 17
        hvip(38) = 9
        hvip(39) = 1
        hvip(40) = 59
        hvip(41) = 51
        hvip(42) = 43
        hvip(43) = 35
        hvip(44) = 27
        hvip(45) = 19
        hvip(46) = 11
        hvip(47) = 3
        hvip(48) = 61
        hvip(49) = 53
        hvip(50) = 45
        hvip(51) = 37
        hvip(52) = 29
        hvip(53) = 21
        hvip(54) = 13
        hvip(55) = 5
        hvip(56) = 63
        hvip(57) = 55
        hvip(58) = 47
        hvip(59) = 39
        hvip(60) = 31
        hvip(61) = 23
        hvip(62) = 15
        hvip(63) = 7
    End Sub
    Sub khoitao()
        khoitao_s0()
        khoitao_s1()
        khoitao_s2()
        khoitao_s3()
        khoitao_s4()
        khoitao_s5()
        khoitao_s6()
        khoitao_s7()
        khoitao_hve()
        khoitao_hvp()
        khoitao_hvpc2()
        khoitao_hvpc1()
        khoitao_hvip()
    End Sub
#End Region
#Region "cac hoan vi"
    Function hoanvi_ip(ByVal x As String) As String
        Dim tam(63) As Char
        Dim i As Integer
        For i = 0 To 63
            tam(i) = x.Substring(hvip(i) - 1, 1)
        Next
        Return tam
    End Function
    Function hoanvi_iptru(ByVal c As String) As String
        Dim tam(63) As Char
        Dim i As Integer
        For i = 0 To 63
            tam(hvip(i) - 1) = c.Substring(i, 1)
        Next
        Return tam
    End Function
    Function hoanvi_e(ByVal r As String) As String
        Dim tam(47) As Char
        Dim i As Integer
        For i = 0 To 47
            tam(i) = r.Substring(hve(i) - 1, 1)
        Next
        Return tam
    End Function
    Function hoanvi_p(ByVal c As String) As String
        Dim tam(31) As Char
        Dim i As Integer
        For i = 0 To 31
            tam(i) = c.Substring(hvp(i) - 1, 1)
        Next
        Return tam
    End Function
    Function hoanvi_ptru(ByVal c As String) As String
        Dim tam(31) As Char
        Dim i As Integer
        For i = 0 To 31
            tam(hvp(i) - 1) = c.Substring(i, 1)
        Next
        Return tam
    End Function
    Function hoanvi_pc1(ByVal k As String) As String
        Dim tam(63) As Char
        Dim i As Integer
        For i = 0 To 63
            tam(i) = k.Substring(i, 1)
        Next
        tam = catbitcuoi(tam)
        For i = 0 To 55
            tam(i) = k.Substring(Integer.Parse(hvpc1(i) - 1), 1)
        Next
        Return tam
    End Function
    Function hoanvi_pc1tru(ByVal c As String) As String
        Dim tam(63) As Char
        Dim i As Integer
        For i = 0 To 63
            tam(i) = "#"
        Next
        For i = 0 To 55
            tam(hvpc1(i) - 1) = c.Substring(i, 1)
        Next
        Dim tam1 As String

        Return tam
    End Function
    Function hoanvi_pc2(ByVal str As String) As String
        Dim tam(47) As Char
        Dim i As Integer
        For i = 0 To 47
            tam(i) = str.Substring(Integer.Parse(hvpc2(i) - 1), 1)
        Next
        Return tam
    End Function
    Function hoanvi_pc2tru(ByVal c As String) As String
        Dim tam(55) As Char
        Dim i As Integer
        For i = 0 To 55
            tam(i) = "?"
        Next
        For i = 0 To 47
            tam(hvpc2(i) - 1) = c.Substring(i, 1)
        Next
        Return tam
    End Function
#End Region
#Region "gan va kiem tra du lieu nhap"
    Function gandulieu() As Boolean
        Try
            Dim i As Integer = 0
            Dim j As Integer
            Dim strbanro As String = txtbanro.Text.Replace(Chr(10), "")
            Dim strbanma As String = txtbanma.Text.Replace(Chr(10), "")
            banro = strbanro.Split(Chr(13))
            banma = strbanma.Split(Chr(13))
            n = banro.Length - 1
            ReDim e((n - 1) / 2)
            ReDim esao((n - 1) / 2)
            ReDim ephay((n - 1) / 2)
            ReDim cphay((n - 1) / 2)
            If (banro.Length - 1 < n Or banma.Length - 1 < n) Then
                MessageBox.Show("thiếu bản rõ hay bản mã")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Dữ liệu nhập không hợp lệ")
            Return False
        End Try

    End Function
    Function kiemtra() As Boolean
        Dim i As Integer
            For i = 0 To n
                If banro(i) = "" Then
                MessageBox.Show("Bạn hãy nhập vào bản rõ thứ " & (i + 1))
                    Return False
                End If
                If banro(i).Length <> m Then
                    MessageBox.Show("Bản rõ " & (i + 1) & " phải có " & m & " kí tự")
                    Return False
                End If
            Next
            For i = 0 To n
                If banma(i) = "" Then
                MessageBox.Show("Bạn hãy nhập vào bản mã thứ " & (i + 1))
                    Return False
                End If
                If banma(i).Length <> m Then
                    MessageBox.Show("Bản mã " & (i + 1) & " phải có " & m & " kí tự")
                    Return False
                End If
            Next
            i = 0
            While i <= n
                If banro(i).Substring(m / 2, m / 2) <> banro(i + 1).Substring(m / 2, m / 2) Then
                    MessageBox.Show("Dữ liệu bản rõ " & (i + 1) & " , " & (i + 2) & " nhập không hợp lệ")
                    Return False
                End If
                i = i + 2
            End While
            Return True
    End Function
#End Region
#Region "xu li e_esao_ephay_cphay"
    Sub xuli_e_esao_ephay()
        Dim i As Integer
        'e(0) = "000000000111111000001110100000000110100000001100"
        'e(1) = "101000001011111111110100000101010000001011110110"
        'e(2) = "111011110001010100000110100011110110100101011111"
        'esao(0) = "101111110000001010101100000001010100000001010010"
        'esao(1) = "100010100110101001011110101111110010100010101010"
        'esao(2) = "000001011110100110100010101111110101011000000100"
        For i = 0 To (n - 1) / 2
            Dim l3 = banma(i * 2).Substring(0, 32)
            Dim l3sao = banma(i * 2 + 1).Substring(0, 32)
            e(i) = hoanvi_e(l3)
            esao(i) = hoanvi_e(l3sao)
            ephay(i) = phay(e(i), esao(i))
        Next
    End Sub
    Function phay(ByVal a As String, ByVal b As String) As String
        Dim i As Integer
        Dim c As String
        For i = 0 To a.Length - 1
            c += (a.Substring(i, 1) Xor b.Substring(i, 1)).ToString
        Next
        Return c
    End Function
    Sub xuli_cphay()
        Dim i, j As Integer
        For i = 0 To (n - 1) / 2
            Dim r3 As String = banma(i * 2).Substring(32, 32)
            Dim r3sao As String = banma(i * 2 + 1).Substring(32, 32)
            Dim l0 As String = banro(i * 2).Substring(0, 32)
            Dim l0sao As String = banro(i * 2 + 1).Substring(0, 32)
            Dim r3phay As String = ""
            Dim l0phay As String = ""
            For j = 0 To 31
                r3phay += (r3.Substring(j, 1) Xor r3sao.Substring(j, 1)).ToString
                l0phay += (l0.Substring(j, 1) Xor l0sao.Substring(j, 1)).ToString
                cphay(i) += (r3phay.Substring(j, 1) Xor l0phay.Substring(j, 1)).ToString
            Next
            cphay(i) = hoanvi_ptru(cphay(i))
        Next
        'cphay(0) = "10010110010111010101101101100111"
        'cphay(1) = "10011100100111000001111101010110"
        'cphay(2) = "11010101011101011101101100101011"
    End Sub
#End Region
#Region "cac ham chuyen doi"
    Function bi_str(ByVal a As String) As String
        Dim i As Integer
        Dim b As String
        For i = 0 To a.Length - 1
            b += binary(asc(a.Substring(i, 1)), hebit)
        Next
        Return b
    End Function
    Sub bi_banro_banma()
        Dim i As Integer
        For i = 0 To n
            banro(i) = bi_str(banro(i))
            banma(i) = bi_str(banma(i))
        Next
    End Sub
    Function bi_so(ByVal a As Integer) As String
        Dim i As Integer
        Dim tam(5) As Char
        For i = 0 To 5
            tam(i) = (a Mod 2).ToString
            a \= 2
        Next
        Array.Reverse(tam)
        Return tam
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
    Function binary(ByVal a As Integer, ByVal n As Integer) As String
        Dim i As Integer
        Dim tam(n - 1) As Char
        For i = 0 To n - 1
            tam(i) = (a Mod 2).ToString
            a = a \ 2
        Next
        Array.Reverse(tam)
        Return tam
    End Function
#End Region
    Function tap_test() As String()
        Dim i, j, k As Integer
        Dim ee(7) As String
        Dim eephay(7) As String
        Dim ccphay(7) As String
        Dim test(63) As String
        For i = 0 To (n - 1) / 2
            For j = 0 To 7
                ee(j) = e(i).Substring(j * 6, 6)
                eephay(j) = ephay(i).Substring(j * 6, 6)
                ccphay(j) = cphay(i).Substring(j * 4, 4)
                test = tap_in(ee(j), eephay(j), ccphay(j), s(j))
                For k = 0 To 63
                    If test(k) = 1 Then
                        jhop(j, k) += 1
                    End If
                Next
            Next
        Next
    End Function
    Function khoavong3() As String
        Dim khoav3 As String
        Dim i, j As Integer
        Dim count As Integer = 0
        Dim vitrimax As Integer
        For i = 0 To 7
            count = 0
            Dim max As Integer = (n + 1) / 2
            For j = 0 To 63
                If jhop(i, j) = max Then
                    count += 1
                    vitrimax = j
                End If
            Next
            If count > 1 Then
                lbthongbao.Text = "Nhập thêm bản mã và bản rõ, vì chưa xác định được phần tử max trong jhộp"
                btthamma.Enabled = False
                txtbanro.Focus()
                n += 2
                ReDim banro(n)
                ReDim banma(n)
                ReDim e((n - 2) / 2)
                ReDim esao((n - 2) / 2)
                ReDim ephay((n - 2) / 2)
                ReDim cphay((n - 2) / 2)
                flag = False
                Exit Function
            End If
            khoav3 += binary(vitrimax, 6)
        Next
        txtkhoav3.Text = khoav3
        Return khoav3
    End Function

    Function xulikhoa() As String
        Dim khoa As String = khoavong3()
        If flag = False Then
            Exit Function
        End If
        khoa = hoanvi_pc2tru(khoa)
        Dim haitambitdau As String = khoa.Substring(0, 28)
        Dim haitambitcuoi As String = khoa.Substring(28, 28)
        haitambitdau = dichphai(haitambitdau, 4)
        haitambitcuoi = dichphai(haitambitcuoi, 4)
        khoa = haitambitdau + haitambitcuoi
        Dim i As Integer
        khoa = hoanvi_pc1tru(khoa)
        txtkhoa.Text = khoa
        Return khoa 'khoa 56 bit
    End Function
    Sub taochuoikhoa(ByVal c As String)
        If flag = False Then
            Exit Sub
        End If
        Dim chuoibinary(255) As String
        Dim i As Integer
        For i = 0 To 255
            chuoibinary(i) = binary(i, 8)
            chuoikhoa(i) = taotungkhoa(c, chuoibinary(i))
        Next
    End Sub
    Function taotungkhoa(ByVal a As String, ByVal b As String) As String
        Dim i As Integer
        Dim j As Integer = 0
        Dim tam(63) As Char
        For i = 0 To 63
            tam(i) = a.Substring(i, 1)
            If tam(i) = "?" Then
                tam(i) = b.Substring(j, 1)
                j += 1
            End If
        Next
        Return tam
    End Function
    Function dichphai(ByVal s As String, ByVal n As Integer) As String
        Return s.Substring(s.Length - n, n) + s.Substring(0, s.Length - n)
    End Function
    Function tap_in(ByVal e As String, ByVal ephay As String, ByVal cphay As String, ByVal s As DataTable) As String()
        Dim tam(63), b, bsao, c, csao, cphaytam As String
        Dim i As Integer
        For i = 0 To 63
            b = bi_so(i)
            Dim haibitcuoi As String = b.Substring(0, 1) + b.Substring(5, 1)
            Dim bonbitgiua As String = b.Substring(1, 4)
            Dim srow = thapphan(haibitcuoi)
            Dim scol = thapphan(bonbitgiua)
            Dim sij As Integer = s.Rows(srow).Item(scol)
            c = binary(sij, 4)
            bsao = phay(ephay, b)
            haibitcuoi = bsao.Substring(0, 1) + bsao.Substring(5, 1)
            bonbitgiua = bsao.Substring(1, 4)
            srow = thapphan(haibitcuoi)
            scol = thapphan(bonbitgiua)
            sij = s.Rows(srow).Item(scol)
            csao = binary(sij, 4)
            cphaytam = phay(c, csao)
            If cphaytam = cphay Then
                tam(thapphan(phay(e, b))) = 1
            End If
        Next
        Return tam
    End Function

    Private Sub btthamma_Click(ByVal sender As System.Object, ByVal ee As System.EventArgs) Handles btthamma.Click
        ReDim banro(n)
        ReDim banma(n)
        ReDim e((n - 1) / 2)
        ReDim esao((n - 1) / 2)
        ReDim ephay((n - 1) / 2)
        ReDim cphay((n - 1) / 2)
        flag = True
        If gandulieu() = False Then
            Exit Sub
        End If
        If kiemtra() = False Then
            Exit Sub
        End If
        bi_banro_banma()
        xuli_e_esao_ephay()
        xuli_cphay()
        tap_test()
        taochuoikhoa(xulikhoa())
        If flag = False Then
            Exit Sub
        End If
        chonkhoadung()
    End Sub
    Private Sub btthoat_Click(ByVal sender As System.Object, ByVal ee As System.EventArgs) Handles btthoat.Click
        Me.Close()
    End Sub
    Private Sub thammades_Load(ByVal sender As System.Object, ByVal ee As System.EventArgs) Handles MyBase.Load
        
        Dim strbanro As String
        strbanro += "748502CD38451097" + Chr(13) + Chr(10)
        strbanro += "3874756438451097" + Chr(13) + Chr(10)
        strbanro += "486911026ACDFF31" + Chr(13) + Chr(10)
        strbanro += "375BD31F6ACDFF31" + Chr(13) + Chr(10)
        strbanro += "357418DA013FEC86" + Chr(13) + Chr(10)
        strbanro += "12549847013FEC86"
        txtbanro.Text = strbanro
        Dim strbanma As String
        strbanma += "03C70306D8A09F10" + Chr(13) + Chr(10)
        strbanma += "78560A0960E6D4CB" + Chr(13) + Chr(10)
        strbanma += "45FA285BE5ADC730" + Chr(13) + Chr(10)
        strbanma += "134F7915AC253457" + Chr(13) + Chr(10)
        strbanma += "D8A31B2F28BBC5CF" + Chr(13) + Chr(10)
        strbanma += "0F317AC2B23CB944"
        txtbanma.Text = strbanma
        khoitao()
    End Sub
    'des

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

    Function ls(ByVal s As String, ByVal n As Integer) As String
        Return s.Substring(n, s.Length - n) + s.Substring(0, n)
    End Function
    Sub taodaykhoa(ByVal khoa As String)
        khoa = hoanvi_pc1(khoa)
        Dim d(2) As String
        Dim c(2) As String
        c(0) = khoa.Substring(0, 28)
        c(0) = ls(c(0), 1)
        d(0) = khoa.Substring(28, 28)
        d(0) = ls(d(0), 1)
        daykhoa(0) = hoanvi_pc2(c(0) + d(0))
        Dim i As Integer
        For i = 1 To 2
            If i = 1 Then
                c(i) = ls(c(i - 1), 1)
                d(i) = ls(d(i - 1), 1)
            Else
                c(i) = ls(c(i - 1), 2)
                d(i) = ls(d(i - 1), 2)
            End If
            daykhoa(i) = hoanvi_pc2(c(i) + d(i))
        Next i
    End Sub
#End Region
#Region "xử lí chuỗi nhập"
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

    Function mahoa(ByVal x As String) As String
        Dim i, j As Integer
        Dim l(2) As String
        Dim r(2) As String
        'x = hoanvi_ip(x)
        Dim l0 As String = x.Substring(0, 32)
        Dim r0 As String = x.Substring(32, 32)
        l(0) = r0
        For i = 0 To 31
            r(0) += (l0.Substring(i, 1) Xor f(r0, daykhoa(0)).Substring(i, 1)).ToString
        Next
        For i = 1 To 2
            l(i) = r(i - 1)
            Dim a As String = f(r(i - 1), daykhoa(i))
            For j = 0 To 31
                r(i) += (l(i - 1).Substring(j, 1) Xor a.Substring(j, 1)).ToString
            Next j
        Next i
        Dim t As String = l(2) + r(2)
        Return t
        'Return hoanvi_iptru(r(2) + l(2))
    End Function
    Function f(ByVal r As String, ByVal daykhoa_k As String) As String
        Dim i As Integer
        Dim e As String
        Dim hv As String = hoanvi_e(r)
        For i = 0 To 47
            e += (hv.Substring(i, 1) Xor daykhoa_k.Substring(i, 1)).ToString
        Next
        Dim b(7) As String
        Dim c As String
        For i = 0 To 7
            b(i) = e.Substring(i * 6, 6)
            Dim haibitdaucuoi As String = b(i).Substring(0, 1) + b(i).Substring(5, 1)
            Dim bonbitgiua As String = b(i).Substring(1, 4)
            Dim srow = thapphan(haibitdaucuoi)
            Dim scol = thapphan(bonbitgiua)
            Dim sij As Integer = s(i).Rows(srow).Item(scol)
            c += binary(sij, 4)
        Next
        Return hoanvi_p(c)
    End Function
    'Function doirachu(ByVal y As String) As String
    'Dim tam As String = y
    'Dim tam1 As String = ""
    'Dim so As Integer
    'Dim i As Integer
    'Dim j As Integer
    'While i < tam.Length - 1
    'so = 0
    'For j = i To i + 7
    'If tam.Substring(j, 1) = 1 Then
    'so += 2 ^ (7 - (j - i))
    'End If
    'Next
    'tam1 += Chr(so)
    'i = i + 8
    'End While
    'Return tam1
    'End Function
    Function doirachu(ByVal y As String) As String
        Dim tam As String = y
        Dim tam1 As String = ""
        Dim so As Integer
        Dim i, j As Integer
        While i < tam.Length - 1
            so = 0
            For j = i To i + 3
                If tam.Substring(j, 1) = 1 Then
                    so += 2 ^ (3 - (j - i))
                End If
            Next
            tam1 += chucai(so)
            i = i + 4
        End While
        Return tam1
    End Function
    Function chucai(ByVal so As Integer) As Char
        Select Case so
            Case 0
                Return "0"
            Case 1
                Return "1"
            Case 2
                Return "2"
            Case 3
                Return "3"
            Case 4
                Return "4"
            Case 5
                Return "5"
            Case 6
                Return "6"
            Case 7
                Return "7"
            Case 8
                Return "8"
            Case 9
                Return "9"
            Case 10
                Return "A"
            Case 11
                Return "B"
            Case 12
                Return "C"
            Case 13
                Return "D"
            Case 14
                Return "E"
            Case 15
                Return "F"
        End Select
    End Function
    Function asc(ByVal a As Char)
        Select Case a
            Case "0"
                asc = 0
            Case "1"
                asc = 1
            Case "2"
                asc = 2
            Case "3"
                asc = 3
            Case "4"
                asc = 4
            Case "5"
                asc = 5
            Case "6"
                asc = 6
            Case "7"
                asc = 7
            Case "8"
                asc = 8
            Case "9"
                asc = 9
            Case "A"
                asc = 10
            Case "B"
                asc = 11
            Case "C"
                asc = 12
            Case "D"
                asc = 13
            Case "E"
                asc = 14
            Case "F"
                asc = 15
        End Select
    End Function

#End Region
    Sub chonkhoadung()
        Dim i As Integer
        Dim x As String = banro(0)
        'For i = 0 To banro(0).Length - 1
        'x += binary(asc(banro(0).Substring(i, 1)), hebit)
        'Next
        For i = 0 To 255
            taodaykhoa(chuoikhoa(i))
            Dim banma1 As String = doirachu(mahoa(x))
            If banma1 = doirachu(banma(0)) Then
                chuoikhoa(i) = chuoikhoa(i).Replace("#", "0")
                txtkhoa.Text = doirachu(chuoikhoa(i))
                Exit Sub
            End If
        Next
        MessageBox.Show("khong tim duoc khoa")
    End Sub

    Private Sub txtbanro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btthamma.Enabled = True
        lbthongbao.Text = ""
    End Sub

    Private Sub txtbanma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btthamma.Enabled = True
        lbthongbao.Text = ""
    End Sub


End Class
