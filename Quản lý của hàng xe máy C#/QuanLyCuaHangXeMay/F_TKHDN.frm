VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_TKHDX 
   BackColor       =   &H0000FF00&
   Caption         =   "TIM KIEM HOA DON XUAN"
   ClientHeight    =   3150
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9405
   LinkTopic       =   "Form1"
   ScaleHeight     =   3150
   ScaleWidth      =   9405
   StartUpPosition =   3  'Windows Default
   Begin MSFlexGridLib.MSFlexGrid MSTKX 
      Height          =   3015
      Left            =   3720
      TabIndex        =   6
      Top             =   0
      Width           =   5775
      _ExtentX        =   10186
      _ExtentY        =   5318
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0080C0FF&
      Height          =   2895
      Left            =   0
      TabIndex        =   0
      Top             =   120
      Width           =   3495
      Begin VB.CommandButton Command3 
         Caption         =   "&Cancel"
         Height          =   495
         Left            =   2400
         TabIndex        =   5
         Top             =   2160
         Width           =   855
      End
      Begin VB.CommandButton Command2 
         Caption         =   "&In"
         Height          =   495
         Left            =   1320
         TabIndex        =   4
         Top             =   2160
         Width           =   855
      End
      Begin VB.CommandButton Command1 
         Caption         =   "&Ok"
         Height          =   495
         Left            =   120
         TabIndex        =   3
         Top             =   2160
         Width           =   855
      End
      Begin VB.TextBox Text1 
         Alignment       =   2  'Center
         Height          =   735
         Left            =   240
         TabIndex        =   2
         Top             =   960
         Width           =   3015
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackColor       =   &H0080C0FF&
         Caption         =   "Tim Theo Ma Hóa Don Ban"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   735
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   3255
      End
   End
End
Attribute VB_Name = "F_TKHDX"
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
MSTKX.Cols = 5
MSTKX.Rows = 20
MSTKX.Font.Size = 10
MSTKX.Row = 0
'cot dau tien hien thi so thu tu
MSTKX.Col = 0
MSTKX.ColWidth(0) = 600
MSTKX.CellAlignment = 3
MSTKX.ColAlignment(0) = 3
MSTKX.Text = " STT"
'cot thu 2 hien thi ma HDB
MSTKX.Col = 1
MSTKX.ColWidth(1) = 1200
MSTKX.CellAlignment = 3
MSTKX.ColAlignment(1) = 3
MSTKX.Text = " Mã HDB "
'cot thu3 hien thi Ngày Bán
MSTKX.Col = 2
MSTKX.ColWidth(2) = 1500
MSTKX.CellAlignment = 3
MSTKX.ColAlignment(2) = 3
MSTKX.Text = " Ngày Bán"
'cot thu 4 hien thi Mã Khách hàng
MSTKX.Col = 3
MSTKX.ColWidth(3) = 1500
MSTKX.CellAlignment = 3
MSTKX.ColAlignment(3) = 3
MSTKX.Text = " Mã KH"
' cot thu 5 hien thi Mã Nhân Viên
MSTKX.Col = 4
MSTKX.ColWidth(4) = 1500
MSTKX.CellAlignment = 3
MSTKX.ColAlignment(4) = 3
MSTKX.Text = " Mã NV"
'danh so thu tu tren luoi
Dim stt
MSTKX.Col = 0
For stt = 1 To MSTKX.Rows - 1
MSTKX.Row = stt
MSTKX.Text = stt
Next stt
End Sub

Private Sub MsTKx_clear()
Dim i, j
For i = 1 To MSTKX.Rows - 1
For j = 1 To MSTKX.Cols - 1
MSTKX.TextMatrix(i, j) = ""
Next j
Next i
End Sub

Private Sub MsTKx_Click()
F_QLHDX.Show
MSTKX.Col = 1
F_QLHDX.Combo1.Text = MSTKX.Text
MSTKX.Col = 2
F_QLHDX.Text1.Text = MSTKX.Text
MSTKX.Col = 3
F_QLHDX.Combo2.Text = MSTKX.Text
MSTKX.Col = 4
F_QLHDX.Combo3.Text = MSTKX.Text
Unload Me
End Sub
Private Sub command1_Click()
Dim rs As New ADODB.Recordset
Dim str, i
 'chon theo mã hoa don bán
MsTKx_clear
str = "select* from HoaDonBH where MaHDB = '" & Trim(Text1) & "'"
rs.Open str, cn
If rs.EOF = True Then
MsgBox "Khong tim thay Mã hoa don bán nh? trên nhu tren", vbOKOnly + vbExclamation, "Thông báo"
End If
 i = 0
 If rs.EOF = False Then
While Not rs.EOF
 i = i + 1
 If i > MSTKX.Rows - 1 Then
 MSTKX.Rows = MSTKX.Rows + 1
  End If
MSTKX.TextMatrix(i, 1) = rs!MaHDB
MSTKX.TextMatrix(i, 2) = rs!NgayBan
MSTKX.TextMatrix(i, 3) = rs!MaKH
MSTKX.TextMatrix(i, 4) = rs!MaNV
rs.MoveNext
Wend
Else
MsgBox "Khong tim thay mã hoa don nhu trên "
Exit Sub
End If
End Sub





