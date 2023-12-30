VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_DMNV 
   BackColor       =   &H0000FFFF&
   Caption         =   "THONG TIN NHAN VIEN"
   ClientHeight    =   8655
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   11235
   LinkTopic       =   "Form1"
   ScaleHeight     =   8655
   ScaleWidth      =   11235
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      BackColor       =   &H00FF80FF&
      Height          =   1095
      Left            =   120
      TabIndex        =   19
      Top             =   7320
      Width           =   10935
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
         Left            =   9480
         TabIndex        =   25
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
         TabIndex        =   24
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
         Left            =   5760
         TabIndex        =   23
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
         Left            =   3840
         TabIndex        =   22
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
         Left            =   1920
         TabIndex        =   21
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
         Height          =   615
         Left            =   120
         TabIndex        =   20
         Top             =   240
         Width           =   1215
      End
   End
   Begin MSFlexGridLib.MSFlexGrid MSNV 
      Height          =   2175
      Left            =   0
      TabIndex        =   18
      Top             =   4920
      Width           =   11175
      _ExtentX        =   19711
      _ExtentY        =   3836
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      Height          =   3975
      Left            =   0
      TabIndex        =   1
      Top             =   720
      Width           =   11175
      Begin VB.TextBox Txttk 
         Height          =   495
         Left            =   7440
         TabIndex        =   17
         Top             =   3120
         Width           =   3015
      End
      Begin VB.TextBox Txtdc 
         Height          =   615
         Left            =   7440
         TabIndex        =   16
         Top             =   2160
         Width           =   3015
      End
      Begin VB.TextBox Txtcv 
         Height          =   495
         Left            =   7440
         TabIndex        =   15
         Top             =   1320
         Width           =   2895
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   7440
         TabIndex        =   14
         Top             =   480
         Width           =   2895
      End
      Begin VB.TextBox Txtns 
         Height          =   615
         Left            =   2040
         TabIndex        =   9
         Top             =   3120
         Width           =   2415
      End
      Begin VB.TextBox Txttuoi 
         Height          =   495
         Left            =   2040
         TabIndex        =   8
         Top             =   2160
         Width           =   2415
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2040
         TabIndex        =   7
         Top             =   360
         Width           =   2415
      End
      Begin VB.TextBox Txtnv 
         Height          =   495
         Left            =   2040
         TabIndex        =   6
         Top             =   1200
         Width           =   2415
      End
      Begin VB.Label Label10 
         Alignment       =   2  'Center
         Caption         =   "Mã Tài khoan"
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
         Left            =   4920
         TabIndex        =   13
         Top             =   3240
         Width           =   1695
      End
      Begin VB.Label Label9 
         Alignment       =   2  'Center
         Caption         =   "Dia Chi"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   5040
         TabIndex        =   12
         Top             =   2400
         Width           =   1695
      End
      Begin VB.Label Label8 
         Alignment       =   2  'Center
         Caption         =   "Chúc Vu"
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
         Left            =   5040
         TabIndex        =   11
         Top             =   1440
         Width           =   1695
      End
      Begin VB.Label Label6 
         Alignment       =   2  'Center
         Caption         =   "Gioi Tính"
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
         Left            =   5040
         TabIndex        =   10
         Top             =   480
         Width           =   1695
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         Caption         =   "Ngày Sinh"
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
         TabIndex        =   5
         Top             =   3360
         Width           =   1935
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         Caption         =   "Tuôi"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   2520
         Width           =   1815
      End
      Begin VB.Label Label3 
         Caption         =   "Tên Nhân Viên"
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
         Top             =   1440
         Width           =   1695
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
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
         Height          =   375
         Left            =   120
         TabIndex        =   2
         Top             =   480
         Width           =   1815
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0000FFFF&
      Caption         =   "Danh Muc Nhân Viên"
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
      Left            =   2280
      TabIndex        =   0
      Top             =   120
      Width           =   6495
   End
End
Attribute VB_Name = "F_DMNV"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Private flag As String
Dim rsMaNV As New ADODB.Recordset

Private Sub Form_Load()
ConnectDataBase
Combo2.AddItem "Nam"
Combo2.AddItem "Nu"
lock_text
rsMaNV.Open "select * from NhanVien", cn
Do While rsMaNV.EOF = False
Combo1.AddItem rsMaNV.Fields("MaNV")
rsMaNV.MoveNext
Loop
khoitaoluoi
display
End Sub
Private Sub lock_text()
Combo1.Enabled = False
Combo2.Enabled = False
Txtnv.Enabled = False
Txtns.Enabled = False
Txtdc.Enabled = False
Txttuoi.Enabled = False
Txttk.Enabled = False
Txtcv.Enabled = False
Command4.Enabled = False
Command3.Enabled = True
Command2.Enabled = True
Command1.Enabled = True
End Sub



Private Sub command1_Click()
un_lock_text
setnull
Combo1.Text = ""
End Sub
Private Sub setnull()
Txtnv.Text = ""
Txtdc.Text = ""
Txttuoi.Text = ""
Txtns.Text = ""
Combo1.Text = ""
Combo2.Text = ""
Txtcv.Text = ""
Txttk.Text = ""
End Sub
Private Sub khoitaoluoi()
' khoi tao luoi gam 9 cot,20 dong
MSNV.Cols = 9
MSNV.Rows = 20
MSNV.Font.Size = 10
MSNV.Row = 0
'cot dau tien hien thi so thu tu
MSNV.Col = 0
MSNV.ColWidth(0) = 600
MSNV.CellAlignment = 3
MSNV.ColAlignment(0) = 3
MSNV.Text = " STT"
'cot thu 2 hien thi ma NV
MSNV.Col = 1
MSNV.ColWidth(1) = 1500
MSNV.CellAlignment = 3
MSNV.ColAlignment(1) = 3
MSNV.Text = " Mã Nhân Viên "
'cot thu3 hien thi Tên NV
MSNV.Col = 2
MSNV.ColWidth(2) = 2000
MSNV.CellAlignment = 3
MSNV.ColAlignment(2) = 3
MSNV.Text = " Tên NV"
'cot thu 4 hien thi Tuôi
MSNV.Col = 3
MSNV.ColWidth(3) = 1000
MSNV.CellAlignment = 3
MSNV.ColAlignment(3) = 3
MSNV.Text = " Tuoi"
' cot thu 5 hien thi Ngày Sinh
MSNV.Col = 4
MSNV.ColWidth(4) = 1500
MSNV.CellAlignment = 3
MSNV.ColAlignment(4) = 3
MSNV.Text = " Ngày Sinh"
'cot thu 6 hien thi Gioi Tính
MSNV.Col = 5
MSNV.ColWidth(5) = 800
MSNV.CellAlignment = 3
MSNV.ColAlignment(5) = 3
MSNV.Text = " Gioi Tính "
'côt thu 7 hien thi Chuc vu
MSNV.Col = 6
MSNV.ColWidth(6) = 1200
MSNV.CellAlignment = 3
MSNV.ColAlignment(6) = 3
MSNV.Text = ""
'côt thu 8 hien thi Dia Chi"
MSNV.Col = 7
MSNV.ColWidth(7) = 2400
MSNV.CellAlignment = 3
MSNV.ColAlignment(7) = 3
MSNV.Text = "Dia Chi"
'côt thu 9 hiên thi Mã tài Khoan
MSNV.Col = 8
MSNV.ColWidth(8) = 1200
MSNV.CellAlignment = 3
MSNV.ColAlignment(8) = 3
MSNV.Text = "Mã TK"
'danh so thu tu tren luoi
Dim stt
MSNV.Col = 0
For stt = 1 To MSNV.Rows - 1
MSNV.Row = stt
MSNV.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From NhanVien"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSNV.Rows <= i Then
    MSNV.Rows = MSNV.Rows + 1
    MSNV.TextMatrix(i, 0) = i
    End If
    MSNV.TextMatrix(i, 1) = rs!Manv
    MSNV.TextMatrix(i, 2) = rs!tennv
    MSNV.TextMatrix(i, 3) = rs!TuoiNV
    MSNV.TextMatrix(i, 4) = rs!NgaySinhNV
    MSNV.TextMatrix(i, 5) = rs!NamNV
    MSNV.TextMatrix(i, 6) = rs!ChucVu
    MSNV.TextMatrix(i, 7) = rs!DCNV
    MSNV.TextMatrix(i, 8) = rs!MaTK
    i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSNV.Refresh
End Sub
Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Txtnv.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete* from NhanVien where MaNV='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
If MSNV.Rows > 1 And MSNV.Rows <> 1 Then
MSNV.RemoveItem (MSNV.Row)
End If
Call khoitaoluoi
Call display
End Sub
Private Sub Command3_Click()
flag = "update"
suadulieu
'txtnv.SetFocus
End Sub
Private Sub suadulieu()
un_lock_text
Combo1.Enabled = False
Txtnv.SetFocus
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
If Trim(Combo1) = "" Or Trim(Txtnv) = "" Then
MsgBox " Phai nhap du lieu day du truoc khi luu", vbOKOnly + vbExclamation, " Thông Báo"
lock_text
Exit Sub
End If
str = "select*from NhanVien where Manv='" & Trim(Combo1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into NhanVien values('" & Trim(Combo1) & "','" & Trim(Txtnv) & "','" & Trim(Txttuoi) & "','" & Trim(Txtns) & "','" & Trim(Combo2) & "','" & Trim(Txtcv) & "','" & Trim(Txtdc) & "','" & Trim(Txttk) & "')"
cn.Execute (str) ' them môt record moi vao bang NhanVien
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma Nhân Viên da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update NhanVien set TenNV='" & Trim(Txtnv) & "',TuoiNV='" & Trim(Txttuoi) & "',NgaySinhNV='" & Trim(Txtns) & "',NamNV='" & Trim(Combo2) & "',ChucVu='" & Trim(Txtcv) & "',DCNV='" & Trim(Txtdc) & "',MaTK='" & Trim(Txttk) & "' where Manv='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
Call display
End Sub
Private Sub msnv_dblclick()
lock_text
MSNV.Col = 1
Combo1.Text = MSNV.Text
MSNV.Col = 2
Txtnv.Text = MSNV.Text
MSNV.Col = 3
Txttuoi.Text = MSNV.Text
MSNV.Col = 4
Txtns.Text = MSNV.Text
MSNV.Col = 5
Combo2.Text = MSNV.Text
MSNV.Col = 6
Txtcv.Text = MSNV.Text
MSNV.Col = 7
Txtdc.Text = MSNV.Text
MSNV.Col = 8
Txttk.Text = MSNV.Text
End Sub
Private Sub un_lock_text()
Combo1.Enabled = True
Combo2.Enabled = True
Txtnv.Enabled = True
Txtns.Enabled = True
Txtdc.Enabled = True
Txttuoi.Enabled = True
Txttk.Enabled = True
Txtcv.Enabled = True
Command4.Enabled = True
Command3.Enabled = False
Command2.Enabled = False
Command1.Enabled = False
End Sub
Private Sub Command6_Click()
Unload Me
F_Main.Show
rsMaNV.Close
End Sub

Private Sub Combo1_Click()
rsMaNV.Find " manv ='" & Combo1.Text & "'", , , adBookmarkFirst
Txtnv.Text = rsMaNV.Fields("TenNV")
End Sub


Private Sub txtns_LostFocus()
If Not IsDate(Txtns.Text) Then
    MsgBox "Ngày tháng không h?p l?", vbOKOnly + vbExclamation, "thông báo"
    Txtns.Text = ""
    Txtnv.SetFocus
    'lock_text
End If
End Sub
Private Sub txtnlv_LostFocus()
If Not IsDate(Txtnlv.Text) Then
    MsgBox "Ngày tháng không h?p l?", vbOKOnly + vbExclamation, "thông báo"
    Txtnlv.Text = ""
    Txtnlv.SetFocus
    'lock_text
End If
End Sub



Private Sub Txttuoi_LostFocus()
If (Not IsNumeric(Txttuoi.Text)) Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
  End If
End Sub
