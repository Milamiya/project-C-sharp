VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_TKHH 
   BackColor       =   &H0080FF80&
   Caption         =   "TIM KIÊM HÀNG HÓA"
   ClientHeight    =   4185
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   11130
   LinkTopic       =   "Form1"
   ScaleHeight     =   4185
   ScaleWidth      =   11130
   StartUpPosition =   3  'Windows Default
   Begin MSFlexGridLib.MSFlexGrid MSTKHH 
      Height          =   3015
      Left            =   3120
      TabIndex        =   8
      Top             =   1080
      Width           =   7815
      _ExtentX        =   13785
      _ExtentY        =   5318
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0000FFFF&
      Height          =   3135
      Left            =   0
      TabIndex        =   1
      Top             =   960
      Width           =   3015
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
         Left            =   2160
         TabIndex        =   7
         Top             =   2400
         Width           =   735
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
         Left            =   1080
         TabIndex        =   6
         Top             =   2400
         Width           =   735
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
         Top             =   2400
         Width           =   735
      End
      Begin VB.TextBox Text1 
         Alignment       =   2  'Center
         Height          =   495
         Left            =   240
         TabIndex        =   4
         Top             =   1560
         Width           =   2535
      End
      Begin VB.OptionButton Option2 
         BackColor       =   &H0000FFFF&
         Caption         =   "Tìm Theo Tên hàng"
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
         Top             =   960
         Width           =   2535
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H0000FFFF&
         Caption         =   "Tìm Theo Mã hàng"
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
         Width           =   2295
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0080FF80&
      Caption         =   "Tìm Kiêm Hàng Hóa"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF00FF&
      Height          =   615
      Left            =   2880
      TabIndex        =   0
      Top             =   120
      Width           =   5535
   End
End
Attribute VB_Name = "F_TKHH"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command2_Click()
 Dim rs As New ADODB.Recordset
    Dim str
    'neu chon theo ma hang hoa
        If Option1.Value = True Then
         str = " select * from HangHoa where mahh ='" & Trim(Text1) & "'"
End If
    'neu chon theo ten hang hoa
        If Option2.Value = True Then
   
            str = "select * from HangHoa where Tenhh Like '%" & Trim(Text1) & "%'"
End If
    DE1.Commands(2).CommandText = str
    If DE1.rsTKHangHoa.State = 0 Then
    DE1.rsTKHangHoa.Open
End If
    DE1.rsTKHangHoa.Requery
    RP_TKHH.Refresh
    RP_TKHH.Show
End Sub

Private Sub Command3_Click()
Unload Me
F_Main.Show
End Sub

Private Sub Form_Load()
ConnectDataBase
khoitaoluoi
End Sub
Public Sub khoitaoluoi()
 'khoi tao luoi gam 7 cot,20 dong
MSTKHH.Cols = 7
MSTKHH.Rows = 20
MSTKHH.Font.Size = 10
MSTKHH.Row = 0
'cot dau tien hien thi so thu tu
MSTKHH.Col = 0
MSTKHH.ColWidth(0) = 600
MSTKHH.CellAlignment = 3
MSTKHH.ColAlignment(0) = 3
MSTKHH.Text = " STT"
'cot thu 2 hien thi ma HH
MSTKHH.Col = 1
MSTKHH.ColWidth(1) = 1500
MSTKHH.CellAlignment = 3
MSTKHH.ColAlignment(1) = 3
MSTKHH.Text = " Mã Hàng Hóa "
'cot thu3 hien thi tên HH
MSTKHH.Col = 2
MSTKHH.ColWidth(2) = 1800
MSTKHH.CellAlignment = 3
MSTKHH.ColAlignment(2) = 3
MSTKHH.Text = " Tên Hàng Hóa"
'cot thu 4 hien thi DVT
MSTKHH.Col = 3
MSTKHH.ColWidth(3) = 1500
MSTKHH.CellAlignment = 3
MSTKHH.ColAlignment(3) = 3
MSTKHH.Text = " Don Vi Tính"
' cot thu 5 hien thi SLTonDK
MSTKHH.Col = 4
MSTKHH.ColWidth(4) = 1000
MSTKHH.CellAlignment = 3
MSTKHH.ColAlignment(4) = 3
MSTKHH.Text = " SL Tôn Dâu Ky"
'cot thu 6 hien thi TGTonDK
MSTKHH.Col = 5
MSTKHH.ColWidth(5) = 2000
MSTKHH.CellAlignment = 3
MSTKHH.ColAlignment(5) = 3
MSTKHH.Text = " TG Tôn Dâu Ky"
'cot thu 7 hien thi Mã Kho
MSTKHH.Col = 6
MSTKHH.ColWidth(6) = 1200
MSTKHH.CellAlignment = 3
MSTKHH.ColAlignment(6) = 3
MSTKHH.Text = "Mã Kho"
'danh so thu tu tren luoi
Dim stt
MSTKHH.Col = 0
For stt = 1 To MSTKHH.Rows - 1
MSTKHH.Row = stt
MSTKHH.Text = stt
Next stt
End Sub

Private Sub MsTKHH_clear()
Dim i, j
For i = 1 To MSTKHH.Rows - 1
For j = 1 To MSTKHH.Cols - 1
MSTKHH.TextMatrix(i, j) = ""
Next j
Next i
End Sub

Private Sub MsTKHH_Click()
F_DMHH.Show
MSTKHH.Col = 1
F_DMHH.Combo1.Text = MSTKHH.Text
MSTKHH.Col = 2
F_DMHH.Txthh.Text = MSTKHH.Text
MSTKHH.Col = 3
F_DMHH.Txtdvt.Text = MSTKHH.Text
MSTKHH.Col = 4
F_DMHH.Txtslt.Text = MSTKHH.Text
MSTKHH.Col = 5
F_DMHH.Txttgt.Text = MSTKHH.Text
MSTKHH.Col = 6
F_DMHH.Txtmk.Text = MSTKHH.Text
Unload Me
End Sub


Private Sub cmdin_Click()
Dim rs As New ADODB.Recordset
Dim str
'neu chon theo ma GV
If op1.Value = True Then
str = " select * from dmgv where magv ='" & Trim(txttim) & "'"
End If
'neu chon theo ten
If op2.Value = True Then
'tim theo ten nhung khong can chinh xac ho ten
str = "select * from dmgv where tengv Like '%" & Trim(txttim) & "%'"
End If
DE1.Commands(4).CommandText = str
If DE1.rsTIMKIEMGV.State = 0 Then
DE1.rsTIMKIEMGV.Open
End If
DE1.rsTIMKIEMGV.Requery
IN_TIMKIEMGV.Refresh
IN_TIMKIEMGV.Show
End Sub
Private Sub cmdthoat_Click()
FRMMAIN.Show
Unload Me
FRMMAIN.Nhap = True
FRMMAIN.tracuu = True
FRMMAIN.trogiup = True
End Sub
Private Sub command1_Click()
Dim rs As New ADODB.Recordset
Dim str, i
'neu chon theo mã hàng hóa
If Option1.Value = True Then
MsTKHH_clear
str = "select* from HangHoa where Mahh = '" & Trim(Text1) & "'"
rs.Open str, cn
If rs.EOF = True Then
MsgBox "Khong tim thay Mã hàng nh? trên nhu tren", vbOKOnly + vbExclamation, "Thông báo"
  Exit Sub
  End If
  End If
  If Option2.Value = True Then
  MsTKHH_clear
'tim theo ten nhung ko can tim chinh xac ho ten
str = "select * from HangHoa where tenhh like'%" & Trim(Text1) & "%'"
 rs.Open str, cn
 End If
 i = 0
 If rs.EOF = False Then
While Not rs.EOF
 i = i + 1
 If i > MSTKHH.Rows - 1 Then
 MSTKHH.Rows = MSTKHH.Rows + 1
  End If
MSTKHH.TextMatrix(i, 1) = rs!mahh
MSTKHH.TextMatrix(i, 2) = rs!tenhh
MSTKHH.TextMatrix(i, 3) = rs!dvt
MSTKHH.TextMatrix(i, 4) = rs!slTonDK
MSTKHH.TextMatrix(i, 5) = rs!tgTonDK
MSTKHH.TextMatrix(i, 6) = rs!makho
rs.MoveNext
Wend
Else
MsgBox "Khong tim thay ten  nhu tren "
Exit Sub
End If
End Sub

