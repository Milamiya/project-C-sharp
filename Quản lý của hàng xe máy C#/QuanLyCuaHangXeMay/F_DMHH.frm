VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_DMHH 
   BackColor       =   &H00C0FFC0&
   Caption         =   "THONG TIN HANG HOA"
   ClientHeight    =   7905
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10920
   LinkTopic       =   "Form1"
   ScaleHeight     =   7905
   ScaleWidth      =   10920
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Txtmk 
      Height          =   495
      Left            =   8400
      TabIndex        =   20
      Top             =   2760
      Width           =   2415
   End
   Begin VB.TextBox Txttgt 
      Height          =   615
      Left            =   8400
      TabIndex        =   19
      Top             =   1680
      Width           =   2415
   End
   Begin VB.TextBox Txtslt 
      Height          =   495
      Left            =   8400
      TabIndex        =   18
      Top             =   840
      Width           =   2415
   End
   Begin VB.TextBox Txtdvt 
      Height          =   615
      Left            =   2520
      TabIndex        =   17
      Top             =   2880
      Width           =   2295
   End
   Begin VB.TextBox Txthh 
      Height          =   615
      Left            =   2520
      TabIndex        =   16
      Top             =   1920
      Width           =   2295
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00C0C0FF&
      Height          =   1455
      Left            =   0
      TabIndex        =   9
      Top             =   6240
      Width           =   10815
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
         Height          =   735
         Left            =   9240
         TabIndex        =   15
         Top             =   360
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
         Height          =   735
         Left            =   7440
         TabIndex        =   14
         Top             =   360
         Width           =   1455
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
         Height          =   735
         Left            =   5520
         TabIndex        =   13
         Top             =   360
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
         Height          =   735
         Left            =   3720
         TabIndex        =   12
         Top             =   360
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
         Height          =   735
         Left            =   1920
         TabIndex        =   11
         Top             =   360
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
         Height          =   735
         Left            =   120
         TabIndex        =   10
         Top             =   360
         Width           =   1335
      End
   End
   Begin MSFlexGridLib.MSFlexGrid MSHH 
      Height          =   2295
      Left            =   120
      TabIndex        =   8
      Top             =   3720
      Width           =   10815
      _ExtentX        =   19076
      _ExtentY        =   4048
      _Version        =   393216
   End
   Begin VB.ComboBox Combo1 
      Height          =   315
      Left            =   2520
      TabIndex        =   4
      Top             =   840
      Width           =   2295
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Mã Kho Hàng"
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
      Left            =   5640
      TabIndex        =   7
      Top             =   2880
      Width           =   2415
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Tông Giá Tri Tôn Dâu Ky"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   5520
      TabIndex        =   6
      Top             =   1800
      Width           =   2655
   End
   Begin VB.Label Label5 
      BackColor       =   &H00C0FFC0&
      Caption         =   "Sô Luong Tôn Dâu Ky"
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
      Left            =   5760
      TabIndex        =   5
      Top             =   840
      Width           =   2295
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Don Vi Tính"
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
      TabIndex        =   3
      Top             =   3120
      Width           =   1935
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Tên Hàng Hóa"
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
      Left            =   0
      TabIndex        =   2
      Top             =   2040
      Width           =   2295
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Mã Hàng Hóa"
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
      TabIndex        =   1
      Top             =   960
      Width           =   1935
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Thông Tin Hàng Hóa"
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
      Height          =   615
      Left            =   3000
      TabIndex        =   0
      Top             =   120
      Width           =   5655
   End
End
Attribute VB_Name = "F_DMHH"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Private flag As String
Dim rsmahh As New ADODB.Recordset

Private Sub Command5_Click()

RP_HH.Show
End Sub

Private Sub Form_Load()
ConnectDataBase
lock_text
rsmahh.Open "select * from HangHoa", cn
Do While rsmahh.EOF = False
Combo1.AddItem rsmahh.Fields("MaHH")
rsmahh.MoveNext
Loop
khoitaoluoi
display
End Sub
Private Sub lock_text()
Combo1.Enabled = False
Txthh.Enabled = False
Txtdvt.Enabled = False
Txtslt.Enabled = False
Txttgt.Enabled = False
Txtmk.Enabled = False
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
Txthh.Text = ""
Txtdvt.Text = ""
Txtslt.Text = ""
Txttgt.Text = ""
Combo1.Text = ""
Txtmk.Text = ""
End Sub
Private Sub khoitaoluoi()
' khoi tao luoi gam 7 cot,20 dong
MSHH.Cols = 7
MSHH.Rows = 20
MSHH.Font.Size = 10
MSHH.Row = 0
'cot dau tien hien thi so thu tu
MSHH.Col = 0
MSHH.ColWidth(0) = 600
MSHH.CellAlignment = 3
MSHH.ColAlignment(0) = 3
MSHH.Text = " STT"
'cot thu 2 hien thi ma HH
MSHH.Col = 1
MSHH.ColWidth(1) = 1200
MSHH.CellAlignment = 3
MSHH.ColAlignment(1) = 3
MSHH.Text = " Mã Hàng Hóa "
'cot thu3 hien thi tên HH
MSHH.Col = 2
MSHH.ColWidth(2) = 1800
MSHH.CellAlignment = 3
MSHH.ColAlignment(2) = 3
MSHH.Text = " Tên Hàng Hóa"
'cot thu 4 hien thi DVT
MSHH.Col = 3
MSHH.ColWidth(3) = 1000
MSHH.CellAlignment = 3
MSHH.ColAlignment(3) = 3
MSHH.Text = " Don Vi Tính"
' cot thu 5 hien thi SLTonDK
MSHH.Col = 4
MSHH.ColWidth(4) = 1000
MSHH.CellAlignment = 3
MSHH.ColAlignment(4) = 3
MSHH.Text = " SL Tôn Dâu Ky"
'cot thu 6 hien thi TGTonDK
MSHH.Col = 5
MSHH.ColWidth(5) = 2000
MSHH.CellAlignment = 3
MSHH.ColAlignment(5) = 3
MSHH.Text = " TG Tôn Dâu Ky"
'cot thu 7 hien thi Mã Kho
MSHH.Col = 6
MSHH.ColWidth(6) = 1200
MSHH.CellAlignment = 3
MSHH.ColAlignment(6) = 3
MSHH.Text = "Mã Kho"
'danh so thu tu tren luoi
Dim stt
MSHH.Col = 0
For stt = 1 To MSHH.Rows - 1
MSHH.Row = stt
MSHH.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From HangHoa"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSHH.Rows <= i Then
    MSHH.Rows = MSHH.Rows + 1
    MSHH.TextMatrix(i, 0) = i
    End If
    MSHH.TextMatrix(i, 1) = rs!mahh
    MSHH.TextMatrix(i, 2) = rs!tenhh
    MSHH.TextMatrix(i, 3) = rs!dvt
    MSHH.TextMatrix(i, 4) = rs!slTonDK
    MSHH.TextMatrix(i, 5) = rs!tgTonDK
    MSHH.TextMatrix(i, 6) = rs!makho
    i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSHH.Refresh
End Sub
Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Txthh.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete* from HangHoa where MaHH='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
If MSHH.Rows > 1 And MSHH.Rows <> 1 Then
MSHH.RemoveItem (MSHH.Row)
End If
Call khoitaoluoi
Call display
End Sub


Private Sub Command3_Click()
flag = "update"
suadulieu
'txthh.SetFocus
End Sub
Private Sub suadulieu()
un_lock_text
Combo1.Enabled = False
Txthh.SetFocus
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
If Trim(Combo1) = "" Or Trim(Txthh) = "" Then
MsgBox " Phai nhap du lieu day du truoc khi luu", vbOKOnly + vbExclamation, " Thông Báo"
lock_text
Exit Sub
End If
str = "select*from HangHoa where Mahh='" & Trim(Combo1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into HangHoa values('" & Trim(Combo1) & "','" & Trim(Txthh) & "','" & Trim(Txtdvt) & "','" & Trim(Txtslt) & "','" & Trim(Txttgt) & "','" & Trim(Txtmk) & "')"
cn.Execute (str) ' them môt record moi vao bang HangHoa
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma Hang Hóa da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update HangHoa set TenHH='" & Trim(Txthh) & "',DVT='" & Trim(Txtdvt) & "',SLTonDK='" & Trim(Txtslt) & "',TGtonDK='" & Trim(Txttgt) & "',MaKho='" & Trim(Txtmk) & "' where MaHH='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
display
End Sub

Private Sub mshh_dblclick()
lock_text
MSHH.Col = 1
Combo1.Text = MSHH.Text
MSHH.Col = 2
Txthh.Text = MSHH.Text
MSHH.Col = 3
Txtdvt.Text = MSHH.Text
MSHH.Col = 4
Txtslt.Text = MSHH.Text
MSHH.Col = 5
Txttgt.Text = MSHH.Text
MSHH.Col = 6
Txtmk.Text = MSHH.Text
End Sub

Private Sub un_lock_text()
Txtslt.Enabled = True
Txttgt.Enabled = True
Txtdvt.Enabled = True
Txtmk.Enabled = True
Txthh.Enabled = True
Combo1.Enabled = True
Command4.Enabled = True
Command1.Enabled = False
Command2.Enabled = False
Command3.Enabled = False
End Sub
Private Sub Command6_Click()
Unload Me
F_Main.Show
rsmahh.Close
End Sub

Private Sub Combo1_Click()
rsmahh.Find " mahh ='" & Combo1.Text & "'", , , adBookmarkFirst
Txthh.Text = rsmahh.Fields("TenHH")
End Sub


Private Sub Txtslt_LostFocus()
If (Not IsNumeric(Txtslt.Text) Or Txtslt.Text = "") Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
  End If

End Sub

Private Sub Txttgt_lostfocus()
If (Not IsNumeric(Txttgt.Text) Or Txttgt.Text = "") Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
End Sub
