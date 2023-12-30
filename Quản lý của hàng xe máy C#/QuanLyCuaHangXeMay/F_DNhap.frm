VERSION 5.00
Object = "{0D452EE1-E08F-101A-852E-02608C4D0BB4}#2.0#0"; "FM20.DLL"
Begin VB.Form F_DNhap 
   BackColor       =   &H00C0FFC0&
   Caption         =   "DANG NHAP HE THONG"
   ClientHeight    =   4125
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6315
   LinkTopic       =   "Form1"
   ScaleHeight     =   4125
   ScaleWidth      =   6315
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Cmdcancel 
      Caption         =   "&Cancel"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   3480
      TabIndex        =   6
      Top             =   3120
      Width           =   1695
   End
   Begin VB.CommandButton Cmdok 
      Caption         =   "&Ok"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1560
      TabIndex        =   5
      Top             =   3120
      Width           =   1575
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00C0FFC0&
      Height          =   2535
      Left            =   1560
      TabIndex        =   0
      Top             =   360
      Width           =   4215
      Begin VB.TextBox Txtpass 
         Alignment       =   2  'Center
         Height          =   495
         IMEMode         =   3  'DISABLE
         Left            =   1560
         PasswordChar    =   "*"
         TabIndex        =   4
         Top             =   1680
         Width           =   2535
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00C0FFC0&
         Caption         =   "&Password"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   3
         Top             =   1680
         Width           =   1335
      End
      Begin MSForms.ComboBox Cbdnhap 
         Height          =   495
         Left            =   1560
         TabIndex        =   2
         Top             =   240
         Width           =   2535
         VariousPropertyBits=   746604571
         DisplayStyle    =   3
         Size            =   "4471;873"
         MatchEntry      =   1
         ShowDropButtonWhen=   2
         FontHeight      =   165
         FontCharSet     =   0
         FontPitchAndFamily=   2
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackColor       =   &H00C0FFC0&
         Caption         =   "&User"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   1095
      End
   End
   Begin VB.Image Image2 
      Height          =   1125
      Left            =   240
      Picture         =   "F_DNhap.frx":0000
      Top             =   1680
      Width           =   1125
   End
   Begin VB.Image Image1 
      Height          =   1125
      Left            =   240
      Picture         =   "F_DNhap.frx":05C2
      Top             =   360
      Width           =   1125
   End
End
Attribute VB_Name = "F_DNhap"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public quyen As Integer
Dim flag As Boolean


Private Sub cmdCancel_Click()
    Unload Me
    End Sub

Private Sub Cbdnhap_Click()
   If Cbdnhap.Text <> "OTHER" Then
        Txtpass.Visible = True
        Txtpass.Enabled = True
        txtPass_Change
        Txtpass.SetFocus
    Else
        Txtpass.Visible = False
        Cmdok.Enabled = True
        Cmdok.SetFocus
    End If
End Sub

Private Sub cmdOK_Click()
    Dim quyen As String
    If Cbdnhap.Text <> "OTHER" Then
        quyen = CheckPasswd(Trim(Cbdnhap.Text), Trim(Txtpass.Text))
        If quyen <> "" Then
            F_Main.quyen = quyen
            F_Main.taikhoan = Cbdnhap.Text
            Unload Me
            F_Main.Show
        Else
            MsgBox "Nhap sai Password"
            Txtpass.SetFocus
        End If
    Else
        F_Main.quyen = "User"
        F_Main.taikhoan = "OTHER"
        Unload Me
        F_Main.Show
     End If
End Sub
Private Sub Form_Load()
    TruyVan
    Txtpass.Visible = False
    Cmdok.Enabled = True
    
End Sub

Private Sub TruyVan()
    'Connection.ConnectDataBase
    connection.OpenData ("SELECT TenTK FROM TaiKhoan")
    Do Until rs.EOF
        Cbdnhap.AddItem rs!TenTK
        rs.MoveNext
    Loop
    Cbdnhap.AddItem "OTHER"
    connection.Closedata
End Sub
Function CheckPasswd(user As String, password As String) As String
    'Connection.ConnectDataBase
    connection.OpenData ("SELECT * FROM TaiKhoan WHERE TenTK ='" & user & "'")
    'Dim rs As Recordset
    'Dim sql As String
    'Set rs = New Recordset
    'sql = "select * from TaiKhoan WHERE TenTK ='" & user & "'"
    'rs.Source = sql
    'rs.ActiveConnection = F_Main.cn
    'rs.Open
    If rs!pass = password Then
        CheckPasswd = rs!GHICHU
    Else
        CheckPasswd = ""
    End If
    Exit Function
End Function
Private Sub txtPass_Change()
    If Txtpass.Text <> "" Then
        Cmdok.Enabled = True
    Else
        Cmdok.Enabled = False
    End If
End Sub

