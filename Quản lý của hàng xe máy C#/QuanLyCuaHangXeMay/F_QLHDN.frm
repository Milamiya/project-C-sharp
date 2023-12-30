VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_QLHDN 
   BackColor       =   &H00FF80FF&
   Caption         =   "QUAN LY HOA DON NHAP"
   ClientHeight    =   6990
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10620
   LinkTopic       =   "Form1"
   ScaleHeight     =   6990
   ScaleWidth      =   10620
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      BackColor       =   &H0080FFFF&
      Height          =   1095
      Left            =   0
      TabIndex        =   11
      Top             =   5760
      Width           =   10575
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
         Left            =   8880
         TabIndex        =   17
         Top             =   240
         Width           =   1455
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
         Left            =   7200
         TabIndex        =   16
         Top             =   240
         Width           =   1335
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
         Left            =   5400
         TabIndex        =   15
         Top             =   240
         Width           =   1455
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
         Left            =   3600
         TabIndex        =   14
         Top             =   240
         Width           =   1455
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
         Left            =   1800
         TabIndex        =   13
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
         TabIndex        =   12
         Top             =   240
         Width           =   1455
      End
   End
   Begin MSFlexGridLib.MSFlexGrid MSQLN 
      Height          =   2055
      Left            =   0
      TabIndex        =   10
      Top             =   3600
      Width           =   10575
      _ExtentX        =   18653
      _ExtentY        =   3625
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFF80&
      Height          =   2535
      Left            =   0
      TabIndex        =   1
      Top             =   960
      Width           =   10575
      Begin VB.ComboBox Combo3 
         BackColor       =   &H00FFFFFF&
         Height          =   315
         Left            =   7200
         TabIndex        =   9
         Top             =   1440
         Width           =   2535
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   7200
         TabIndex        =   7
         Top             =   240
         Width           =   2535
      End
      Begin VB.TextBox Text1 
         Height          =   495
         Left            =   2400
         TabIndex        =   5
         Top             =   1440
         Width           =   2055
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2400
         TabIndex        =   4
         Top             =   240
         Width           =   2055
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF80&
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
         Height          =   495
         Left            =   4800
         TabIndex        =   8
         Top             =   1440
         Width           =   2055
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF80&
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
         Height          =   495
         Left            =   4920
         TabIndex        =   6
         Top             =   240
         Width           =   1935
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF80&
         Caption         =   "Ngày Nhâp"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   3
         Top             =   1560
         Width           =   1815
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF80&
         Caption         =   "Mã Hóa Don Nhâp"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   2
         Top             =   360
         Width           =   2055
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FF80FF&
      Caption         =   "Quan Lý Hóa Don Nhâp"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFF00&
      Height          =   615
      Left            =   2640
      TabIndex        =   0
      Top             =   120
      Width           =   5775
   End
End
Attribute VB_Name = "F_QLHDN"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Option Explicit
Private flag As String
Dim rsMapn As New ADODB.Recordset
Dim rsmancc As New ADODB.Recordset
Dim rsmanv As New ADODB.Recordset
Private Sub Combo1_Click()
rsMapn.Find " Mapn ='" & Combo1.Text & "'", , , adBookmarkFirst
End Sub
Private Sub Combo2_Click()
rsmancc.Find " MaNCC ='" & Combo2.Text & "'", , , adBookmarkFirst
End Sub
Private Sub Combo3_Click()
rsmanv.Find " Manv ='" & Combo3.Text & "'", , , adBookmarkFirst
End Sub
Private Sub command1_Click()
un_lock_text
setnull
End Sub
Private Sub setnull()
Text1.Text = ""
Combo1.Text = ""
Combo2.Text = ""
Combo3.Text = ""
End Sub
Private Sub khoitaoluoi()
' khoi tao luoi gam 5 cot,20 dong
MSQLN.Cols = 5
MSQLN.Rows = 20
MSQLN.Font.Size = 10
MSQLN.Row = 0
'cot dau tien hien thi so thu tu
MSQLN.Col = 0
MSQLN.ColWidth(0) = 600
MSQLN.CellAlignment = 3
MSQLN.ColAlignment(0) = 3
MSQLN.Text = " STT"
'cot thu 2 hien thi ma Hóa Don Nhâp
MSQLN.Col = 1
MSQLN.ColWidth(1) = 1200
MSQLN.CellAlignment = 3
MSQLN.ColAlignment(1) = 3
MSQLN.Text = " Mã PN "
'cot thu3 hien thi Ngày Nhâp
MSQLN.Col = 2
MSQLN.ColWidth(2) = 1500
MSQLN.CellAlignment = 3
MSQLN.ColAlignment(2) = 3
MSQLN.Text = "Ngày Nhâp"
'cot thu 4 hien thi Mã Nhà Cung Câp
MSQLN.Col = 3
MSQLN.ColWidth(3) = 1500
MSQLN.CellAlignment = 3
MSQLN.ColAlignment(3) = 3
MSQLN.Text = "Mã NCC"
' cot thu 5 hien thi Mã NV
MSQLN.Col = 4
MSQLN.ColWidth(4) = 1500
MSQLN.CellAlignment = 3
MSQLN.ColAlignment(4) = 3
MSQLN.Text = " Mã NV"
'danh so thu tu tren luoi
Dim stt
MSQLN.Col = 0
For stt = 1 To MSQLN.Rows - 1
MSQLN.Row = stt
MSQLN.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From HoaDonNH"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSQLN.Rows <= i Then
    MSQLN.Rows = MSQLN.Rows + 1
    MSQLN.TextMatrix(i, 0) = i
    End If
    MSQLN.TextMatrix(i, 1) = rs!MaPN
    MSQLN.TextMatrix(i, 2) = rs!NgayNhap
    MSQLN.TextMatrix(i, 3) = rs!MaNCC
    MSQLN.TextMatrix(i, 4) = rs!MaNV
   i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSQLN.Refresh
End Sub
Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Combo1.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete*from HoaDonNH where MapN='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
If MSQLN.Rows > 1 And MSQLN.Rows <> 1 Then
MSQLN.RemoveItem (MSQLN.Row)
End If
Call khoitaoluoi
Call display
End Sub

Private Sub Command3_Click()
flag = "update"
suadulieu
'text1.SetFocus
End Sub
Private Sub suadulieu()
un_lock_text
Combo1.Enabled = False
Text1.SetFocus
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
If Trim(Combo1) = "" Or Trim(Text1) = "" Then
MsgBox " Phai nhap du lieu day du truoc khi luu", vbOKOnly + vbExclamation, " Thông Báo"
lock_text
Exit Sub
End If
str = "select*from HoaDonNH where MaPN='" & Trim(Combo1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into HoaDonNH values('" & Trim(Combo1) & "','" & Trim(Text1) & "','" & Trim(Combo2) & "','" & Trim(Combo3) & "')"
cn.Execute (str) ' them môt record moi vao bang HoaDonNH
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma Hóa don Nhâp da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update HoaDonNH set NgayNhap='" & Trim(Text1) & "',MaNCC='" & Trim(Combo2) & "',MaNV='" & Trim(Combo3) & "'where MaPN='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
display
End Sub

Private Sub msqln_dblclick()
lock_text
MSQLN.Col = 1
Combo1.Text = MSQLN.Text
MSQLN.Col = 2
Text1.Text = MSQLN.Text
MSQLN.Col = 3
Combo2.Text = MSQLN.Text
MSQLN.Col = 4
Combo3.Text = MSQLN.Text
End Sub
Private Sub Form_Load()
ConnectDataBase
lock_text
rsMapn.Open "select * from HoaDonNH", cn
Do While rsMapn.EOF = False
Combo1.AddItem rsMapn.Fields("MaPN")
rsMapn.MoveNext
Loop

rsmancc.Open "select * from NhaCungCap", cn
Do While rsmancc.EOF = False
Combo2.AddItem rsmancc.Fields("MaNCC")
rsmancc.MoveNext
Loop

rsmanv.Open "select * from NhanVien", cn
Do While rsmanv.EOF = False
Combo3.AddItem rsmanv.Fields("MaNV")
rsmanv.MoveNext
Loop
khoitaoluoi
display
End Sub
Private Sub lock_text()
Text1.Enabled = False
Combo1.Enabled = False
Combo2.Enabled = False
Combo3.Enabled = False
Command4.Enabled = False
Command1.Enabled = True
Command2.Enabled = True
Command3.Enabled = True
End Sub
Private Sub un_lock_text()
Text1.Enabled = True
Combo1.Enabled = True
Combo2.Enabled = True
Combo3.Enabled = True
Command4.Enabled = True
Command1.Enabled = False
Command2.Enabled = False
Command3.Enabled = False
End Sub
Private Sub Command6_Click()
Unload Me
F_Main.Show
rsMapn.Close
rsmancc.Close
rsmanv.Close
End Sub

Private Sub Text1_LostFocus()
If Not IsDate(Text1.Text) Then
    MsgBox "Ngày tháng không h?p l?", vbOKOnly + vbExclamation, "thông báo"
    Text1.Text = ""
    Text1.SetFocus
    'lock_text
End If
End Sub




