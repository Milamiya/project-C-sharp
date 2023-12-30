VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_QLHDX 
   BackColor       =   &H0080FF80&
   Caption         =   "HOA DON XUAT"
   ClientHeight    =   6510
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   8940
   LinkTopic       =   "Form1"
   ScaleHeight     =   6510
   ScaleWidth      =   8940
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      BackColor       =   &H00FF8080&
      Height          =   1095
      Left            =   120
      TabIndex        =   11
      Top             =   5040
      Width           =   8655
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
         Left            =   7320
         TabIndex        =   17
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
         Left            =   5880
         TabIndex        =   16
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
         Left            =   4440
         TabIndex        =   15
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
         Height          =   615
         Left            =   3000
         TabIndex        =   14
         Top             =   240
         Width           =   1215
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
         Left            =   1560
         TabIndex        =   13
         Top             =   240
         Width           =   1215
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
         Width           =   1215
      End
   End
   Begin MSFlexGridLib.MSFlexGrid MSQLX 
      Height          =   1695
      Left            =   0
      TabIndex        =   10
      Top             =   3240
      Width           =   8895
      _ExtentX        =   15690
      _ExtentY        =   2990
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0080C0FF&
      Height          =   2295
      Left            =   0
      TabIndex        =   1
      Top             =   840
      Width           =   8895
      Begin VB.ComboBox Combo3 
         Height          =   315
         Left            =   6600
         TabIndex        =   9
         Top             =   1440
         Width           =   2055
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   6600
         TabIndex        =   8
         Top             =   360
         Width           =   2055
      End
      Begin VB.TextBox Text1 
         Height          =   495
         Left            =   2040
         TabIndex        =   5
         Top             =   1320
         Width           =   2175
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2040
         TabIndex        =   4
         Top             =   360
         Width           =   2175
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H0080C0FF&
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
         Left            =   4680
         TabIndex        =   7
         Top             =   1440
         Width           =   1575
      End
      Begin VB.Label Label4 
         BackColor       =   &H0080C0FF&
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
         Height          =   495
         Left            =   4680
         TabIndex        =   6
         Top             =   360
         Width           =   1695
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H0080C0FF&
         Caption         =   "Ngày Xuât"
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
         TabIndex        =   3
         Top             =   1440
         Width           =   1695
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H0080C0FF&
         Caption         =   "Mã Phiêu Xuât"
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
         TabIndex        =   2
         Top             =   360
         Width           =   1695
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0080FF80&
      Caption         =   "Quan Ly Hoa Don Xuât Hàng"
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
      Height          =   495
      Left            =   1680
      TabIndex        =   0
      Top             =   120
      Width           =   5295
   End
End
Attribute VB_Name = "F_QLHDX"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Option Explicit
Private flag As String
Dim rsMaHDB As New ADODB.Recordset
Dim rsmakh As New ADODB.Recordset
Dim rsmanv As New ADODB.Recordset
Private Sub Combo1_Click()
rsMaHDB.Find " MaHDB ='" & Combo1.Text & "'", , , adBookmarkFirst
End Sub
Private Sub Combo2_Click()
rsmakh.Find " MaKH ='" & Combo2.Text & "'", , , adBookmarkFirst
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
MSQLX.Cols = 5
MSQLX.Rows = 20
MSQLX.Font.Size = 10
MSQLX.Row = 0
'cot dau tien hien thi so thu tu
MSQLX.Col = 0
MSQLX.ColWidth(0) = 600
MSQLX.CellAlignment = 3
MSQLX.ColAlignment(0) = 3
MSQLX.Text = " STT"
'cot thu 2 hien thi ma Hóa Don Ban
MSQLX.Col = 1
MSQLX.ColWidth(1) = 1200
MSQLX.CellAlignment = 3
MSQLX.ColAlignment(1) = 3
MSQLX.Text = " Mã HDB "
'cot thu3 hien thi Ngày Xuât
MSQLX.Col = 2
MSQLX.ColWidth(2) = 1500
MSQLX.CellAlignment = 3
MSQLX.ColAlignment(2) = 3
MSQLX.Text = "Ngày Xuât"
'cot thu 4 hien thi Mã Khách Hàng
MSQLX.Col = 3
MSQLX.ColWidth(3) = 1500
MSQLX.CellAlignment = 3
MSQLX.ColAlignment(3) = 3
MSQLX.Text = "Mã KH"
' cot thu 5 hien thi Mã NV
MSQLX.Col = 4
MSQLX.ColWidth(4) = 1500
MSQLX.CellAlignment = 3
MSQLX.ColAlignment(4) = 3
MSQLX.Text = " Mã NV"
'danh so thu tu tren luoi
Dim stt
MSQLX.Col = 0
For stt = 1 To MSQLX.Rows - 1
MSQLX.Row = stt
MSQLX.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From HoaDonBH"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSQLX.Rows <= i Then
    MSQLX.Rows = MSQLX.Rows + 1
    MSQLX.TextMatrix(i, 0) = i
    End If
    MSQLX.TextMatrix(i, 1) = rs!MaHDB
    MSQLX.TextMatrix(i, 2) = rs!NgayBan
    MSQLX.TextMatrix(i, 3) = rs!MaKh
    MSQLX.TextMatrix(i, 4) = rs!Manv
   i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSQLX.Refresh
End Sub
Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Combo1.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete*from HoaDonBH where MaHDB='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
If MSQLX.Rows > 1 And MSQLX.Rows <> 1 Then
MSQLX.RemoveItem (MSQLX.Row)
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
str = "select*from HoaDonBH where MaHDB='" & Trim(Combo1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into HoaDonBH values('" & Trim(Combo1) & "','" & Trim(Text1) & "','" & Trim(Combo2) & "','" & Trim(Combo3) & "')"
cn.Execute (str) ' them môt record moi vao bang HoaDonBH
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma Hóa don Bán da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update HoaDonBH set NgayBan='" & Trim(Text1) & "',MaKH='" & Trim(Combo2) & "',MaNV='" & Trim(Combo3) & "'where MaHDB='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
display
End Sub

Private Sub msqlx_dblclick()
lock_text
MSQLX.Col = 1
Combo1.Text = MSQLX.Text
MSQLX.Col = 2
Text1.Text = MSQLX.Text
MSQLX.Col = 3
Combo2.Text = MSQLX.Text
MSQLX.Col = 4
Combo3.Text = MSQLX.Text
End Sub


Private Sub Form_Load()
ConnectDataBase
lock_text
rsMaHDB.Open "select * from HoaDonBH", cn
Do While rsMaHDB.EOF = False
Combo1.AddItem rsMaHDB.Fields("MaHDB")
rsMaHDB.MoveNext
Loop

rsmakh.Open "select * from KhachHang", cn
Do While rsmakh.EOF = False
Combo2.AddItem rsmakh.Fields("Makh")
rsmakh.MoveNext
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
rsMaHDB.Close
rsmakh.Close
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



