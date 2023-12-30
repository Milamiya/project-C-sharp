VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_TKHDN 
   BackColor       =   &H0080FF80&
   Caption         =   "TIM KIEM HOA DON NHAP"
   ClientHeight    =   4245
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9840
   LinkTopic       =   "Form1"
   ScaleHeight     =   4245
   ScaleWidth      =   9840
   StartUpPosition =   3  'Windows Default
   Begin MSFlexGridLib.MSFlexGrid MSTKN 
      Height          =   3975
      Left            =   3960
      TabIndex        =   4
      Top             =   120
      Width           =   5775
      _ExtentX        =   10186
      _ExtentY        =   7011
      _Version        =   393216
   End
   Begin VB.CommandButton Command3 
      Caption         =   "&Cancel"
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
      Left            =   2640
      TabIndex        =   3
      Top             =   3360
      Width           =   1095
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
      Left            =   1320
      TabIndex        =   2
      Top             =   3360
      Width           =   1095
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
      TabIndex        =   1
      Top             =   3360
      Width           =   1095
   End
   Begin VB.TextBox Text1 
      Alignment       =   2  'Center
      Height          =   735
      Left            =   360
      TabIndex        =   0
      Top             =   1800
      Width           =   3375
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0080FF80&
      Caption         =   "Tìm Theo Mã hóa Don Nhâp"
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
      Left            =   120
      TabIndex        =   5
      Top             =   360
      Width           =   3495
   End
End
Attribute VB_Name = "F_TKHDN"
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
' khoi tao luoi gam 5 cot,20 dong
MSTKN.Cols = 5
MSTKN.Rows = 20
MSTKN.Font.Size = 10
MSTKN.Row = 0
'cot dau tien hien thi so thu tu
MSTKN.Col = 0
MSTKN.ColWidth(0) = 600
MSTKN.CellAlignment = 3
MSTKN.ColAlignment(0) = 3
MSTKN.Text = " STT"
'cot thu 2 hien thi ma PN
MSTKN.Col = 1
MSTKN.ColWidth(1) = 1200
MSTKN.CellAlignment = 3
MSTKN.ColAlignment(1) = 3
MSTKN.Text = " Mã PN "
'cot thu3 hien thi Ngày Nhâp
MSTKN.Col = 2
MSTKN.ColWidth(2) = 1500
MSTKN.CellAlignment = 3
MSTKN.ColAlignment(2) = 3
MSTKN.Text = " Ngày Nhâp"
'cot thu 4 hien thi Mã Nhà Cung Câp
MSTKN.Col = 3
MSTKN.ColWidth(3) = 1500
MSTKN.CellAlignment = 3
MSTKN.ColAlignment(3) = 3
MSTKN.Text = " Mã NCC"
' cot thu 5 hien thi Mã Nhân Viên
MSTKN.Col = 4
MSTKN.ColWidth(4) = 1500
MSTKN.CellAlignment = 3
MSTKN.ColAlignment(4) = 3
MSTKN.Text = " Mã NV"
'danh so thu tu tren luoi
Dim stt
MSTKN.Col = 0
For stt = 1 To MSTKN.Rows - 1
MSTKN.Row = stt
MSTKN.Text = stt
Next stt
End Sub

Private Sub MsTKn_clear()
Dim i, j
For i = 1 To MSTKN.Rows - 1
For j = 1 To MSTKN.Cols - 1
MSTKN.TextMatrix(i, j) = ""
Next j
Next i
End Sub

Private Sub MsTKn_Click()
F_QLHDN.Show
MSTKN.Col = 1
F_QLHDN.Combo1.Text = MSTKN.Text
MSTKNCC.Col = 2
F_QLHDN.Text1.Text = MSTKN.Text
MSTKN.Col = 3
F_QLHDN.Combo2.Text = MSTKN.Text
MSTKN.Col = 4
F_QLHDN.Combo3.Text = MSTKN.Text
Unload Me
End Sub
Private Sub command1_Click()
Dim rs As New ADODB.Recordset
Dim str, i
 'chon theo mã hoa don nhap
MsTKn_clear
str = "select* from HoaDonNH where MaPN = '" & Trim(Text1) & "'"
rs.Open str, cn
If rs.EOF = True Then
MsgBox "Khong tim thay Mã Phieu Nhâp nh? trên nhu tren", vbOKOnly + vbExclamation, "Thông báo"
End If
 i = 0
 If rs.EOF = False Then
While Not rs.EOF
 i = i + 1
 If i > MSTKN.Rows - 1 Then
 MSTKN.Rows = MSTKN.Rows + 1
  End If
MSTKN.TextMatrix(i, 1) = rs!MaPN
MSTKN.TextMatrix(i, 2) = rs!NgayNhap
MSTKN.TextMatrix(i, 3) = rs!MaNCC
MSTKN.TextMatrix(i, 4) = rs!MaNV
rs.MoveNext
Wend
Else
MsgBox "Khong tim thay mã hoa don nhu trên "
Exit Sub
End If
End Sub




