VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_PHIEUCHI 
   BackColor       =   &H0000FFFF&
   Caption         =   "PHIEU CHI"
   ClientHeight    =   7755
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10935
   LinkTopic       =   "Form1"
   ScaleHeight     =   7755
   ScaleWidth      =   10935
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFF00&
      Height          =   975
      Left            =   120
      TabIndex        =   13
      Top             =   6600
      Width           =   10695
      Begin VB.CommandButton Command6 
         Caption         =   "&Exit"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   9360
         TabIndex        =   19
         Top             =   240
         Width           =   1215
      End
      Begin VB.CommandButton Command5 
         Caption         =   "&In"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   7680
         TabIndex        =   18
         Top             =   240
         Width           =   1215
      End
      Begin VB.CommandButton Command4 
         Caption         =   "&Luu"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   5880
         TabIndex        =   17
         Top             =   240
         Width           =   1335
      End
      Begin VB.CommandButton Command3 
         Caption         =   "&Sua"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   4080
         TabIndex        =   16
         Top             =   240
         Width           =   1335
      End
      Begin VB.CommandButton Command2 
         Caption         =   "&Xóa"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   2040
         TabIndex        =   15
         Top             =   240
         Width           =   1455
      End
      Begin VB.CommandButton Command1 
         Caption         =   "&Thêm"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   120
         TabIndex        =   14
         Top             =   240
         Width           =   1455
      End
   End
   Begin MSFlexGridLib.MSFlexGrid MSPC 
      Height          =   2535
      Left            =   120
      TabIndex        =   12
      Top             =   3960
      Width           =   10695
      _ExtentX        =   18865
      _ExtentY        =   4471
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0000FF00&
      Height          =   2775
      Left            =   120
      TabIndex        =   1
      Top             =   960
      Width           =   10695
      Begin VB.TextBox Text3 
         Height          =   495
         Left            =   7440
         TabIndex        =   11
         Top             =   1800
         Width           =   2295
      End
      Begin VB.TextBox Text2 
         Height          =   495
         Left            =   7440
         TabIndex        =   10
         Top             =   960
         Width           =   2295
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   7440
         TabIndex        =   9
         Top             =   240
         Width           =   2295
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2760
         TabIndex        =   5
         Top             =   1680
         Width           =   1935
      End
      Begin VB.TextBox Text1 
         Height          =   495
         Left            =   2760
         TabIndex        =   4
         Top             =   480
         Width           =   1935
      End
      Begin VB.Label Label6 
         Alignment       =   2  'Center
         BackColor       =   &H0000FF00&
         Caption         =   "Sô Tiên Chi"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   375
         Left            =   5280
         TabIndex        =   8
         Top             =   1920
         Width           =   1935
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H0000FF00&
         Caption         =   "Ngày Chi"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   375
         Left            =   5280
         TabIndex        =   7
         Top             =   1080
         Width           =   1695
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H0000FF00&
         Caption         =   "Mã Nhà Cung Câp"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   375
         Left            =   5040
         TabIndex        =   6
         Top             =   360
         Width           =   2175
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H0000FF00&
         Caption         =   "Mã Nhân Viên"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   615
         Left            =   360
         TabIndex        =   3
         Top             =   1560
         Width           =   2055
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H0000FF00&
         Caption         =   "Mã Phiêu Chi"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   615
         Left            =   360
         TabIndex        =   2
         Top             =   480
         Width           =   2175
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0000FFFF&
      Caption         =   "Danh Muc Phiêu Chi"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   615
      Left            =   2880
      TabIndex        =   0
      Top             =   120
      Width           =   5535
   End
End
Attribute VB_Name = "F_PHIEUCHI"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Option Explicit
Private flag As String
Dim rsMaNV As New ADODB.Recordset
Dim rsmancc As New ADODB.Recordset

Private Sub command1_Click()
un_lock_text
setnull
End Sub
Private Sub setnull()
Text1.Text = ""
Combo1.Text = ""
Combo2.Text = ""
Text2.Text = ""
Text3.Text = ""
End Sub
Private Sub khoitaoluoi()
' khoi tao luoi gam 6 cot,20 dong
MSPC.Cols = 6
MSPC.Rows = 20
MSPC.Font.Size = 10
MSPC.Row = 0
'cot dau tien hien thi so thu tu
MSPC.Col = 0
MSPC.ColWidth(0) = 600
MSPC.CellAlignment = 3
MSPC.ColAlignment(0) = 3
MSPC.Text = " STT"
'cot thu 2 hien thi ma Phiêu chi
MSPC.Col = 1
MSPC.ColWidth(1) = 1200
MSPC.CellAlignment = 3
MSPC.ColAlignment(1) = 3
MSPC.Text = " Mã PC "
'cot thu3 hien thi Mã NV
MSPC.Col = 2
MSPC.ColWidth(2) = 1200
MSPC.CellAlignment = 3
MSPC.ColAlignment(2) = 3
MSPC.Text = " Mã NV"
'cot thu 4 hien thi Mã Nhà Cung Câp
MSPC.Col = 3
MSPC.ColWidth(3) = 1200
MSPC.CellAlignment = 3
MSPC.ColAlignment(3) = 3
MSPC.Text = " Mã NCC"
' cot thu 5 hien thi ngày chi
MSPC.Col = 4
MSPC.ColWidth(4) = 1500
MSPC.CellAlignment = 3
MSPC.ColAlignment(4) = 3
MSPC.Text = " ngày Chi"
'cot thu 6 hien sô tiên chi
MSPC.Col = 5
MSPC.ColWidth(5) = 2000
MSPC.CellAlignment = 3
MSPC.ColAlignment(5) = 3
MSPC.Text = "Sô Tiên Thu"
'danh so thu tu tren luoi
Dim stt
MSPC.Col = 0
For stt = 1 To MSPC.Rows - 1
MSPC.Row = stt
MSPC.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From PhieuChi"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSPC.Rows <= i Then
    MSPC.Rows = MSPC.Rows + 1
    MSPC.TextMatrix(i, 0) = i
    End If
    MSPC.TextMatrix(i, 1) = rs!MaPc
    MSPC.TextMatrix(i, 2) = rs!Manv
    MSPC.TextMatrix(i, 3) = rs!Mancc
    MSPC.TextMatrix(i, 4) = rs!NgayChi
    MSPC.TextMatrix(i, 5) = rs!SoTien
   i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSPC.Refresh
End Sub

Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Text1.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete*from PhieuChi where MaPC='" & Trim(Text1) & "'"
cn.Execute (str)
End If
If MSPC.Rows > 1 And MSPC.Rows <> 1 Then
MSPC.RemoveItem (MSPC.Row)
End If
Call khoitaoluoi
Call display
End Sub

Private Sub Command3_Click()
flag = "update"
suadulieu
'combo2.SetFocus
End Sub
Private Sub suadulieu()
un_lock_text
Text1.Enabled = False
Combo1.SetFocus
End Sub
Private Sub Command4_Click()
If flag <> "update" Then
flag = "save"
End If
luudulieu
lock_text
End Sub
Private Sub luudulieu()
Dim rs As New ADODB.Recordset
Dim str
If Trim(Text1) = "" Then
MsgBox " Phai nhap du lieu day du truoc khi luu", vbOKOnly + vbExclamation, " Thông Báo"
lock_text
Exit Sub
End If
str = "select*from PhieuChi where MaPc='" & Trim(Text1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into PhieuChi values('" & Trim(Text1) & "','" & Trim(Combo1) & "','" & Trim(Combo2) & "','" & Trim(Text2) & "','" & Trim(Text3) & "')"
cn.Execute (str) ' them môt record moi vao bang PhieuChi
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma phiêu Chi da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update PhieuChi set Manv='" & Trim(Combo1) & "',MaNCC='" & Trim(Combo2) & "',NgayChi='" & Trim(Text2) & "',SoTien='" & Trim(Text3) & "'where MaPc='" & Trim(Text1) & "'"
cn.Execute (str)
End If
display
End Sub

Private Sub mspc_dblclick()
lock_text
MSPC.Col = 1
Text1.Text = MSPC.Text
MSPC.Col = 2
Combo1.Text = MSPC.Text
MSPC.Col = 3
Combo2.Text = MSPC.Text
MSPC.Col = 4
Text2.Text = MSPC.Text
MSPC.Col = 5
Text3.Text = MSPC.Text
End Sub


Private Sub Form_Load()
ConnectDataBase
lock_text
Command4.Enabled = False
rsMaNV.Open "select * from NhanVien", cn
Do While rsMaNV.EOF = False
Combo1.AddItem rsMaNV.Fields("Manv")
rsMaNV.MoveNext
Loop

rsmancc.Open "select * from NhaCungCap", cn
Do While rsmancc.EOF = False
Combo2.AddItem rsmancc.Fields("MaNCC")
rsmancc.MoveNext
Loop
khoitaoluoi
display
End Sub
Private Sub lock_text()
Text1.Enabled = False
Combo1.Enabled = False
Combo2.Enabled = False
Text2.Enabled = False
Text3.Enabled = False
Command4.Enabled = False
Command1.Enabled = True
Command2.Enabled = True
Command3.Enabled = True
End Sub
Private Sub un_lock_text()
Text1.Enabled = True
Combo1.Enabled = True
Combo2.Enabled = True
Text3.Enabled = True
Text2.Enabled = True
Command4.Enabled = True
Command1.Enabled = False
Command2.Enabled = False
Command3.Enabled = False
End Sub
Private Sub Command6_Click()
Unload Me
F_Main.Show
rsMaNV.Close
rsmancc.Close
End Sub



Private Sub Text2_LostFocus()
If Not IsDate(Text2.Text) Then
    MsgBox "Ngày tháng không h?p l?", vbOKOnly + vbExclamation, "thông báo"
    Text2.Text = ""
    Combo1.SetFocus
    'lock_text
End If
End Sub




Private Sub Text3_LostFocus()
If (Not IsNumeric(Text3.Text)) Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
  End If
End Sub
