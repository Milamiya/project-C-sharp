VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_TKNV 
   BackColor       =   &H0080FFFF&
   Caption         =   "TÌM KIÊM NHÂN VIÊN"
   ClientHeight    =   4050
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   11190
   LinkTopic       =   "Form1"
   ScaleHeight     =   4050
   ScaleWidth      =   11190
   StartUpPosition =   3  'Windows Default
   Begin MSFlexGridLib.MSFlexGrid MSTKNV 
      Height          =   3135
      Left            =   3600
      TabIndex        =   8
      Top             =   840
      Width           =   7455
      _ExtentX        =   13150
      _ExtentY        =   5530
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00C0C0FF&
      Height          =   3135
      Left            =   120
      TabIndex        =   1
      Top             =   840
      Width           =   3375
      Begin VB.CommandButton Command3 
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
         Left            =   2280
         TabIndex        =   7
         Top             =   2280
         Width           =   975
      End
      Begin VB.CommandButton Command2 
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
         Left            =   1200
         TabIndex        =   6
         Top             =   2280
         Width           =   975
      End
      Begin VB.CommandButton Command1 
         Caption         =   "&Ok"
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
         Top             =   2280
         Width           =   975
      End
      Begin VB.TextBox Text1 
         Height          =   615
         Left            =   360
         TabIndex        =   4
         Top             =   1440
         Width           =   2655
      End
      Begin VB.OptionButton Option2 
         BackColor       =   &H00C0C0FF&
         Caption         =   "Tìm Theo tên Nhân Viên"
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
         TabIndex        =   3
         Top             =   840
         Width           =   3015
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H00C0C0FF&
         Caption         =   "&Tìm theo Mã Nhân Viên"
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
         Top             =   240
         Width           =   3135
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0080FFFF&
      Caption         =   "Tìm Kiêm Nhân Viên"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   495
      Left            =   2760
      TabIndex        =   0
      Top             =   120
      Width           =   6255
   End
End
Attribute VB_Name = "F_TKNV"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command3_Click()
Unload Me
F_Main.Show
End Sub

Private Sub Form_Load()
ConnectDataBase
khoitaoluoi
End Sub
Public Sub khoitaoluoi()
' khoi tao luoi gam 9 cot,20 dong
MSTKNV.Cols = 9
MSTKNV.Rows = 20
MSTKNV.Font.Size = 10
MSTKNV.Row = 0
'cot dau tien hien thi so thu tu
MSTKNV.Col = 0
MSTKNV.ColWidth(0) = 600
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(0) = 3
MSTKNV.Text = " STT"
'cot thu 2 hien thi ma NV
MSTKNV.Col = 1
MSTKNV.ColWidth(1) = 1500
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(1) = 3
MSTKNV.Text = " Mã Nhân Viên "
'cot thu3 hien thi Tên NV
MSTKNV.Col = 2
MSTKNV.ColWidth(2) = 2000
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(2) = 3
MSTKNV.Text = " Tên NV"
'cot thu 4 hien thi Tuôi
MSTKNV.Col = 3
MSTKNV.ColWidth(3) = 1000
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(3) = 3
MSTKNV.Text = " Tuoi"
' cot thu 5 hien thi Ngày Sinh
MSTKNV.Col = 4
MSTKNV.ColWidth(4) = 1500
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(4) = 3
MSTKNV.Text = " Ngày Sinh"
'cot thu 6 hien thi Gioi Tính
MSTKNV.Col = 5
MSTKNV.ColWidth(5) = 800
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(5) = 3
MSTKNV.Text = " Gioi Tính "
'côt thu 7 hien thi Chuc vu
MSTKNV.Col = 6
MSTKNV.ColWidth(6) = 1200
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(6) = 3
MSTKNV.Text = ""
'côt thu 8 hien thi Dia Chi"
MSTKNV.Col = 7
MSTKNV.ColWidth(7) = 2400
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(7) = 3
MSTKNV.Text = "Dia Chi"
'côt thu 9 hiên thi Mã tài Khoan
MSTKNV.Col = 8
MSTKNV.ColWidth(8) = 1200
MSTKNV.CellAlignment = 3
MSTKNV.ColAlignment(8) = 3
MSTKNV.Text = "Mã TK"
'danh so thu tu tren luoi
Dim stt
MSTKNV.Col = 0
For stt = 1 To MSTKNV.Rows - 1
MSTKNV.Row = stt
MSTKNV.Text = stt
Next stt
End Sub

Private Sub MsTKnv_clear()
Dim i, j
For i = 1 To MSTKNV.Rows - 1
For j = 1 To MSTKNV.Cols - 1
MSTKNV.TextMatrix(i, j) = ""
Next j
Next i
End Sub

Private Sub MsTKnv_Click()
F_DMNV.Show
MSTKNV.Col = 1
F_DMNV.Combo1.Text = MSTKNV.Text
MSTKNV.Col = 2
F_DMNV.Txtnv.Text = MSTKNV.Text
MSTKNV.Col = 3
F_DMNV.Txttuoi.Text = MSTKNV.Text
MSTKNV.Col = 4
F_DMNV.Txtns.Text = MSTKNV.Text
MSTKNV.Col = 5
F_DMNV.Combo2.Text = MSTKNV.Text
MSTKNV.Col = 6
F_DMNV.Txtcv.Text = MSTKNV.Text
MSTKNV.Col = 7
F_DMNV.Txtdc.Text = MSTKNV.Text
MSTKNV.Col = 8
F_DMNV.Txttk.Text = MSTKNV.Text
Unload Me
End Sub



Private Sub command1_Click()
Dim rs As New ADODB.Recordset
Dim str, i
'neu chon theo mã Nhân Viên
If Option1.Value = True Then
MsTKnv_clear
str = "select* from NhanVien where Manv = '" & Trim(Text1) & "'"
rs.Open str, cn
If rs.EOF = True Then
MsgBox "Khong tim thay Mã Nhân Viên nh? trên nhu tren", vbOKOnly + vbExclamation, "Thông báo"
  Exit Sub
  End If
  End If
  If Option2.Value = True Then
  MsTKnv_clear
'tim theo ten nhung ko can tim chinh xac ho ten
str = "select * from NhanVien where tennv like'%" & Trim(Text1) & "%'"
 rs.Open str, cn
 End If
 i = 0
 If rs.EOF = False Then
While Not rs.EOF
 i = i + 1
 If i > MSTKNV.Rows - 1 Then
 MSTKNV.Rows = MSTKNV.Rows + 1
  End If
MSTKNV.TextMatrix(i, 1) = rs!MaNV
MSTKNV.TextMatrix(i, 2) = rs!tennv
MSTKNV.TextMatrix(i, 3) = rs!TuoiNV
MSTKNV.TextMatrix(i, 4) = rs!NgaySinhNV
MSTKNV.TextMatrix(i, 5) = rs!NamNV
MSTKNV.TextMatrix(i, 6) = rs!ChucVu
MSTKNV.TextMatrix(i, 7) = rs!DCNV
MSTKNV.TextMatrix(i, 8) = rs!MaTK
rs.MoveNext
Wend
Else
MsgBox "Khong tim thay tên Nhân Viên nhu tren "
Exit Sub
End If
End Sub



