VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_PHIEUTHU 
   BackColor       =   &H0080FF80&
   Caption         =   "PHIEU THU"
   ClientHeight    =   6450
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10320
   LinkTopic       =   "Form1"
   ScaleHeight     =   6450
   ScaleWidth      =   10320
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      BackColor       =   &H008080FF&
      Height          =   855
      Left            =   120
      TabIndex        =   13
      Top             =   5400
      Width           =   9975
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
         Height          =   495
         Left            =   8640
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
         Height          =   495
         Left            =   7080
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
         Height          =   495
         Left            =   5400
         TabIndex        =   17
         Top             =   240
         Width           =   1215
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
         Height          =   495
         Left            =   3600
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
         Height          =   495
         Left            =   1800
         TabIndex        =   15
         Top             =   240
         Width           =   1335
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
         Height          =   495
         Left            =   120
         TabIndex        =   14
         Top             =   240
         Width           =   1215
      End
   End
   Begin MSFlexGridLib.MSFlexGrid MSPT 
      Height          =   2175
      Left            =   0
      TabIndex        =   12
      Top             =   3120
      Width           =   10215
      _ExtentX        =   18018
      _ExtentY        =   3836
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0000FFFF&
      Height          =   2295
      Left            =   0
      TabIndex        =   1
      Top             =   720
      Width           =   10215
      Begin VB.TextBox Text3 
         Height          =   375
         Left            =   7200
         TabIndex        =   11
         Top             =   1680
         Width           =   2535
      End
      Begin VB.TextBox Text2 
         Height          =   375
         Left            =   7200
         TabIndex        =   10
         Top             =   960
         Width           =   2535
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   7200
         TabIndex        =   9
         Top             =   240
         Width           =   2535
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2040
         TabIndex        =   5
         Top             =   1440
         Width           =   1815
      End
      Begin VB.TextBox Text1 
         Height          =   495
         Left            =   2040
         TabIndex        =   4
         Top             =   360
         Width           =   1695
      End
      Begin VB.Label Label6 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
         Caption         =   "Sô Tiên Thu"
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
         Left            =   4560
         TabIndex        =   8
         Top             =   1680
         Width           =   2535
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
         Caption         =   "Ngày Thu"
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
         TabIndex        =   7
         Top             =   960
         Width           =   1935
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
         Caption         =   "Mã Khách Hàng"
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
         Left            =   4920
         TabIndex        =   6
         Top             =   240
         Width           =   1815
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
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
         Left            =   240
         TabIndex        =   3
         Top             =   1320
         Width           =   1695
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
         Caption         =   "Mã Phiêu Thu"
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
         Top             =   480
         Width           =   1575
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0080FF80&
      Caption         =   "Danh Muc Phieu Thu"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2400
      TabIndex        =   0
      Top             =   120
      Width           =   5415
   End
End
Attribute VB_Name = "F_PHIEUTHU"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Option Explicit
Private flag As String
Dim rsMaNV As New ADODB.Recordset
Dim rsmaKH As New ADODB.Recordset

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
MSPT.Cols = 6
MSPT.Rows = 20
MSPT.Font.Size = 10
MSPT.Row = 0
'cot dau tien hien thi so thu tu
MSPT.Col = 0
MSPT.ColWidth(0) = 600
MSPT.CellAlignment = 3
MSPT.ColAlignment(0) = 3
MSPT.Text = " STT"
'cot thu 2 hien thi ma Phiêu Thu
MSPT.Col = 1
MSPT.ColWidth(1) = 1200
MSPT.CellAlignment = 3
MSPT.ColAlignment(1) = 3
MSPT.Text = " Mã PT "
'cot thu3 hien thi Mã NV
MSPT.Col = 2
MSPT.ColWidth(2) = 1200
MSPT.CellAlignment = 3
MSPT.ColAlignment(2) = 3
MSPT.Text = " Mã NV"
'cot thu 4 hien thi Mã Khách hàng
MSPT.Col = 3
MSPT.ColWidth(3) = 1200
MSPT.CellAlignment = 3
MSPT.ColAlignment(3) = 3
MSPT.Text = " Mã KH"
' cot thu 5 hien thi ngày bán
MSPT.Col = 4
MSPT.ColWidth(4) = 1500
MSPT.CellAlignment = 3
MSPT.ColAlignment(4) = 3
MSPT.Text = " ngày Bán"
'cot thu 6 hien sô tiên thu
MSPT.Col = 5
MSPT.ColWidth(5) = 2000
MSPT.CellAlignment = 3
MSPT.ColAlignment(5) = 3
MSPT.Text = "Sô Tiên Thu"
'danh so thu tu tren luoi
Dim stt
MSPT.Col = 0
For stt = 1 To MSPT.Rows - 1
MSPT.Row = stt
MSPT.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From PhieuTHu"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSPT.Rows <= i Then
    MSPT.Rows = MSPT.Rows + 1
    MSPT.TextMatrix(i, 0) = i
    End If
    MSPT.TextMatrix(i, 1) = rs!MaPT
    MSPT.TextMatrix(i, 2) = rs!Manv
    MSPT.TextMatrix(i, 3) = rs!Makh
    MSPT.TextMatrix(i, 4) = rs!NgayTHu
    MSPT.TextMatrix(i, 5) = rs!SoTienThu
   i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSPT.Refresh
End Sub

Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Text1.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete*from PhieuThu where MaPT='" & Trim(Text1) & "'"
cn.Execute (str)
End If
If MSPT.Rows > 1 And MSPT.Rows <> 1 Then
MSPT.RemoveItem (MSPT.Row)
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
str = "select*from PhieuThu where MaPT='" & Trim(Text1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into PhieuThu values('" & Trim(Text1) & "','" & Trim(Combo1) & "','" & Trim(Combo2) & "','" & Trim(Text2) & "','" & Trim(Text3) & "')"
cn.Execute (str) ' them môt record moi vao bang PhieuThu
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma phiêu thu da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update PhieuThu set Manv='" & Trim(Combo1) & "',MaKh='" & Trim(Combo2) & "',NgayThu='" & Trim(Text2) & "',SoTienThu='" & Trim(Text3) & "'where MaPT='" & Trim(Text1) & "'"
cn.Execute (str)
End If
display
End Sub

Private Sub mspt_dblclick()
lock_text
MSPT.Col = 1
Text1.Text = MSPT.Text
MSPT.Col = 2
Combo1.Text = MSPT.Text
MSPT.Col = 3
Combo2.Text = MSPT.Text
MSPT.Col = 4
Text2.Text = MSPT.Text
MSPT.Col = 5
Text3.Text = MSPT.Text
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

rsmaKH.Open "select * from KhachHang", cn
Do While rsmaKH.EOF = False
Combo2.AddItem rsmaKH.Fields("Makh")
rsmaKH.MoveNext
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
rsmaKH.Close
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
