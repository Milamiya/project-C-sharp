VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_TKKH 
   BackColor       =   &H00FFFF00&
   Caption         =   "TÌm Ki?m Khách Hàng"
   ClientHeight    =   3960
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   11025
   LinkTopic       =   "Form1"
   ScaleHeight     =   3960
   ScaleWidth      =   11025
   StartUpPosition =   3  'Windows Default
   Begin MSFlexGridLib.MSFlexGrid MSTKKH 
      Height          =   3015
      Left            =   3480
      TabIndex        =   2
      Top             =   840
      Width           =   7455
      _ExtentX        =   13150
      _ExtentY        =   5318
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0080FFFF&
      Height          =   3135
      Left            =   0
      TabIndex        =   1
      Top             =   720
      Width           =   3375
      Begin VB.CommandButton Command3 
         Caption         =   "&Exit"
         Height          =   495
         Left            =   2280
         TabIndex        =   8
         Top             =   2280
         Width           =   855
      End
      Begin VB.CommandButton Command2 
         Caption         =   "&In"
         Height          =   495
         Left            =   1200
         TabIndex        =   7
         Top             =   2280
         Width           =   855
      End
      Begin VB.CommandButton Command1 
         Caption         =   "&Ok"
         Height          =   495
         Left            =   120
         TabIndex        =   6
         Top             =   2280
         Width           =   855
      End
      Begin VB.TextBox Text1 
         Alignment       =   2  'Center
         Height          =   495
         Left            =   240
         TabIndex        =   5
         Top             =   1440
         Width           =   2895
      End
      Begin VB.OptionButton Option2 
         BackColor       =   &H0080FFFF&
         Caption         =   "TÌm Theo Tên Khách Hàng"
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
         TabIndex        =   4
         Top             =   720
         Width           =   3135
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H0080FFFF&
         Caption         =   "Tìm Theo Mã Khách Hàng"
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
         TabIndex        =   3
         Top             =   120
         Width           =   3135
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF00&
      Caption         =   "Tìm Kiêm Khách Hàng"
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
      Left            =   3240
      TabIndex        =   0
      Top             =   120
      Width           =   5055
   End
End
Attribute VB_Name = "F_TKKH"
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
MSTKKH.Cols = 9
MSTKKH.Rows = 20
MSTKKH.Font.Size = 10
MSTKKH.Row = 0
'cot dau tien hien thi so thu tu
MSTKKH.Col = 0
MSTKKH.ColWidth(0) = 600
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(0) = 3
MSTKKH.Text = " STT"
'cot thu 2 hien thi ma KH
MSTKKH.Col = 1
MSTKKH.ColWidth(1) = 1000
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(1) = 3
MSTKKH.Text = " Mã Khách Hàng "
'cot thu3 hien thi Tên KH
MSTKKH.Col = 2
MSTKKH.ColWidth(2) = 2000
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(2) = 3
MSTKKH.Text = " Tên KH"
'cot thu 4 hien thi Sô DT
MSTKKH.Col = 3
MSTKKH.ColWidth(3) = 1500
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(3) = 3
MSTKKH.Text = " Sô DT"
' cot thu 5 hien thi Tuoi KH
MSTKKH.Col = 4
MSTKKH.ColWidth(4) = 600
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(4) = 3
MSTKKH.Text = " Tuôi KH"
'cot thu 6 hien thi Dia Chi KH
MSTKKH.Col = 5
MSTKKH.ColWidth(5) = 2400
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(5) = 3
MSTKKH.Text = " Dia Chi "
'cot thu 7 hien thi Gi?i TÍnh
MSTKKH.Col = 6
MSTKKH.ColWidth(6) = 1000
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(6) = 3
MSTKKH.Text = "Gioi TÍnh"
'côt thu 8 hien thi Sô CMND
MSTKKH.Col = 7
MSTKKH.ColWidth(7) = 1200
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(7) = 3
MSTKKH.Text = "Sô CMND"
'côt thu 9 hien thi Ngày Sinh"
MSTKKH.Col = 8
MSTKKH.ColWidth(8) = 1200
MSTKKH.CellAlignment = 3
MSTKKH.ColAlignment(8) = 3
MSTKKH.Text = "Ngày Sinh"
'danh so thu tu tren luoi
Dim stt
MSTKKH.Col = 0
For stt = 1 To MSTKKH.Rows - 1
MSTKKH.Row = stt
MSTKKH.Text = stt
Next stt
End Sub

Private Sub MsTKkH_clear()
Dim i, j
For i = 1 To MSTKKH.Rows - 1
For j = 1 To MSTKKH.Cols - 1
MSTKKH.TextMatrix(i, j) = ""
Next j
Next i
End Sub

Private Sub MsTKkH_Click()
F_DMKH.Show
MSTKKH.Col = 1
F_DMKH.Combo1.Text = MSTKKH.Text
MSTKKH.Col = 2
F_DMKH.Txtkh.Text = MSTKKH.Text
MSTKKH.Col = 3
F_DMKH.Txtdt.Text = MSTKKH.Text
MSTKKH.Col = 4
F_DMKH.Txttuoi.Text = MSTKKH.Text
MSTKKH.Col = 5
F_DMKH.Txtdc.Text = MSTKKH.Text
MSTKKH.Col = 6
F_DMKH.Combo2.Text = MSTKKH.Text
MSTKKH.Col = 7
F_DMKH.Txtcm.Text = MSTKKH.Text
MSTKKH.Col = 8
F_DMKH.Txtns.Text = MSTKKH.Text
Unload Me
End Sub



Private Sub command1_Click()
Dim rs As New ADODB.Recordset
Dim str, i
'neu chon theo mã khách hàng
If Option1.Value = True Then
MsTKkH_clear
str = "select* from KhachHang where Makh = '" & Trim(Text1) & "'"
rs.Open str, cn
If rs.EOF = True Then
MsgBox "Khong tim thay Mã khách hàng nh? trên nhu tren", vbOKOnly + vbExclamation, "Thông báo"
  Exit Sub
  End If
  End If
  If Option2.Value = True Then
  MsTKkH_clear
'tim theo ten nhung ko can tim chinh xac ho ten
str = "select * from KhachHang where tenkh like'%" & Trim(Text1) & "%'"
 rs.Open str, cn
 End If
 i = 0
 If rs.EOF = False Then
While Not rs.EOF
 i = i + 1
 If i > MSTKKH.Rows - 1 Then
 MSTKKH.Rows = MSTKKH.Rows + 1
  End If
MSTKKH.TextMatrix(i, 1) = rs!makh
MSTKKH.TextMatrix(i, 2) = rs!tenkh
MSTKKH.TextMatrix(i, 3) = rs!DTKH
MSTKKH.TextMatrix(i, 4) = rs!tuoi
MSTKKH.TextMatrix(i, 5) = rs!DCKH
MSTKKH.TextMatrix(i, 6) = rs!GioiTinh
MSTKKH.TextMatrix(i, 7) = rs!SoCMND
MSTKKH.TextMatrix(i, 8) = rs!NgaySinh
rs.MoveNext
Wend
Else
MsgBox "Khong tim thay tên khách hàng nhu tren "
Exit Sub
End If
End Sub


