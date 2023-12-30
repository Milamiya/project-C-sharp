VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_TKNCC 
   BackColor       =   &H00FFFF80&
   Caption         =   "TÌM KIÊM NHÀ CUNG CÂP"
   ClientHeight    =   4515
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10635
   LinkTopic       =   "Form1"
   ScaleHeight     =   4515
   ScaleWidth      =   10635
   StartUpPosition =   3  'Windows Default
   Begin MSFlexGridLib.MSFlexGrid MSTKNCC 
      Height          =   3135
      Left            =   3240
      TabIndex        =   2
      Top             =   1200
      Width           =   7335
      _ExtentX        =   12938
      _ExtentY        =   5530
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00C0FFFF&
      Height          =   3375
      Left            =   0
      TabIndex        =   1
      Top             =   1080
      Width           =   3135
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
         Left            =   1920
         TabIndex        =   8
         Top             =   2520
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
         Left            =   960
         TabIndex        =   7
         Top             =   2520
         Width           =   855
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
         Left            =   0
         TabIndex        =   6
         Top             =   2520
         Width           =   855
      End
      Begin VB.TextBox Text1 
         Height          =   375
         Left            =   240
         TabIndex        =   5
         Top             =   1560
         Width           =   2535
      End
      Begin VB.OptionButton Option2 
         BackColor       =   &H00C0FFFF&
         Caption         =   "Tìm Theo Tên NCC"
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
         Width           =   2895
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H00C0FFFF&
         Caption         =   "TÌm Theo Mã NCC"
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
         Top             =   240
         Width           =   2775
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF80&
      Caption         =   "Tìm Kiêm Nhà Cung Câp"
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
      Left            =   3000
      TabIndex        =   0
      Top             =   120
      Width           =   4815
   End
End
Attribute VB_Name = "F_TKNCC"
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
MSTKNCC.Cols = 5
MSTKNCC.Rows = 20
MSTKNCC.Font.Size = 10
MSTKNCC.Row = 0
'cot dau tien hien thi so thu tu
MSTKNCC.Col = 0
MSTKNCC.ColWidth(0) = 600
MSTKNCC.CellAlignment = 3
MSTKNCC.ColAlignment(0) = 3
MSTKNCC.Text = " STT"
'cot thu 2 hien thi ma NCC
MSTKNCC.Col = 1
MSTKNCC.ColWidth(1) = 1200
MSTKNCC.CellAlignment = 3
MSTKNCC.ColAlignment(1) = 3
MSTKNCC.Text = " Mã NCC "
'cot thu3 hien thi tên NCC
MSTKNCC.Col = 2
MSTKNCC.ColWidth(2) = 2500
MSTKNCC.CellAlignment = 3
MSTKNCC.ColAlignment(2) = 3
MSTKNCC.Text = " Tên NCC"
'cot thu 4 hien thi Dia chi NCC
MSTKNCC.Col = 3
MSTKNCC.ColWidth(3) = 2500
MSTKNCC.CellAlignment = 3
MSTKNCC.ColAlignment(3) = 3
MSTKNCC.Text = " Dia chi NCC"
' cot thu 5 hien thi Dien thoai NCC
MSTKNCC.Col = 4
MSTKNCC.ColWidth(4) = 1500
MSTKNCC.CellAlignment = 3
MSTKNCC.ColAlignment(4) = 3
MSTKNCC.Text = " Dien Thoai NCC"
'danh so thu tu tren luoi
Dim stt
MSTKNCC.Col = 0
For stt = 1 To MSTKNCC.Rows - 1
MSTKNCC.Row = stt
MSTKNCC.Text = stt
Next stt
End Sub

Private Sub MsTKncc_clear()
Dim i, j
For i = 1 To MSTKNCC.Rows - 1
For j = 1 To MSTKNCC.Cols - 1
MSTKNCC.TextMatrix(i, j) = ""
Next j
Next i
End Sub

Private Sub MsTKncc_Click()
F_DMNCC.Show
MSTKNCC.Col = 1
F_DMNCC.Text4.Text = MSTKNCC.Text
MSTKNCC.Col = 2
F_DMNCC.Text1.Text = MSTKNCC.Text
MSTKNCC.Col = 3
F_DMNCC.Text2.Text = MSTKNCC.Text
MSTKNCC.Col = 4
F_DMNCC.Text3.Text = MSTKNCC.Text
Unload Me
End Sub



Private Sub command1_Click()
Dim rs As New ADODB.Recordset
Dim str, i
'neu chon theo mã Nhà cung c?p
If Option1.Value = True Then
MsTKncc_clear
str = "select* from NhaCungCap where MaNcc = '" & Trim(Text1) & "'"
rs.Open str, cn
If rs.EOF = True Then
MsgBox "Khong tim thay Mã nhà cung câp nh? trên nhu tren", vbOKOnly + vbExclamation, "Thông báo"
  Exit Sub
  End If
  End If
  If Option2.Value = True Then
  MsTKncc_clear
'tim theo ten nhung ko can tim chinh xac
str = "select * from NhaCungCap where tenNCC like'%" & Trim(Text1) & "%'"
 rs.Open str, cn
 End If
 i = 0
 If rs.EOF = False Then
While Not rs.EOF
 i = i + 1
 If i > MSTKNCC.Rows - 1 Then
 MSTKNCC.Rows = MSTKNCC.Rows + 1
  End If
MSTKNCC.TextMatrix(i, 1) = rs!mancc
MSTKNCC.TextMatrix(i, 2) = rs!tenncc
MSTKNCC.TextMatrix(i, 3) = rs!DCNCC
MSTKNCC.TextMatrix(i, 4) = rs!DTNCC
rs.MoveNext
Wend
Else
MsgBox "Khong tim thay tên Nhà Cung Câp nhu tren "
Exit Sub
End If
End Sub



