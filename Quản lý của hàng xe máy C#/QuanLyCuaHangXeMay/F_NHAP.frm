VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_NHAP 
   BackColor       =   &H0080FF80&
   Caption         =   "NHAP HANG"
   ClientHeight    =   6510
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9270
   LinkTopic       =   "Form1"
   ScaleHeight     =   6510
   ScaleWidth      =   9270
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      BackColor       =   &H008080FF&
      Height          =   1095
      Left            =   0
      TabIndex        =   9
      Top             =   5280
      Width           =   9135
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
         Left            =   7800
         TabIndex        =   15
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
         Left            =   6360
         TabIndex        =   14
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
         Left            =   4800
         TabIndex        =   13
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
         Left            =   3240
         TabIndex        =   12
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
         Left            =   1680
         TabIndex        =   11
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
         TabIndex        =   10
         Top             =   240
         Width           =   1215
      End
   End
   Begin MSFlexGridLib.MSFlexGrid MSNH 
      Height          =   2055
      Left            =   0
      TabIndex        =   8
      Top             =   3000
      Width           =   9135
      _ExtentX        =   16113
      _ExtentY        =   3625
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0000FFFF&
      Height          =   2055
      Left            =   0
      TabIndex        =   1
      Top             =   840
      Width           =   9135
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   2040
         TabIndex        =   17
         Top             =   1320
         Width           =   2175
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2040
         TabIndex        =   16
         Top             =   360
         Width           =   2175
      End
      Begin VB.TextBox Text4 
         Height          =   495
         Left            =   6600
         TabIndex        =   7
         Top             =   1200
         Width           =   2175
      End
      Begin VB.TextBox Text3 
         Height          =   495
         Left            =   6600
         TabIndex        =   6
         Top             =   240
         Width           =   2175
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
         Caption         =   "Don Giá Nhâp"
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
         Left            =   4320
         TabIndex        =   5
         Top             =   1320
         Width           =   1815
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
         Caption         =   "Sô Luong Nhâp"
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
         Left            =   4440
         TabIndex        =   4
         Top             =   360
         Width           =   1695
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
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
         Height          =   375
         Left            =   120
         TabIndex        =   3
         Top             =   1320
         Width           =   1815
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H0000FFFF&
         Caption         =   "Mã Phiêu Nhâp"
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
         TabIndex        =   2
         Top             =   360
         Width           =   1935
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0080FF80&
      Caption         =   "Danh Muc Nhâp Hàng"
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
      Height          =   495
      Left            =   2280
      TabIndex        =   0
      Top             =   120
      Width           =   4455
   End
End
Attribute VB_Name = "F_NHAP"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Option Explicit
Private flag As String
Dim rsMapn As New ADODB.Recordset
Dim rsmahh As New ADODB.Recordset

Private Sub command1_Click()
un_lock_text
setnull
End Sub
Private Sub setnull()
Text4.Text = ""
Combo1.Text = ""
Combo2.Text = ""
Text3.Text = ""
End Sub
Private Sub khoitaoluoi()
' khoi tao luoi gam 5 cot,20 dong
MSNH.Cols = 5
MSNH.Rows = 20
MSNH.Font.Size = 10
MSNH.Row = 0
'cot dau tien hien thi so thu tu
MSNH.Col = 0
MSNH.ColWidth(0) = 600
MSNH.CellAlignment = 3
MSNH.ColAlignment(0) = 3
MSNH.Text = " STT"
'cot thu 2 hien thi ma Phiêu Nhâp
MSNH.Col = 1
MSNH.ColWidth(1) = 1200
MSNH.CellAlignment = 3
MSNH.ColAlignment(1) = 3
MSNH.Text = " Mã PN "
'cot thu3 hien thi Mã HH
MSNH.Col = 2
MSNH.ColWidth(2) = 2500
MSNH.CellAlignment = 3
MSNH.ColAlignment(2) = 3
MSNH.Text = " Mã HH"
'cot thu 4 hien thi Sô Luong Nhâp
MSNH.Col = 3
MSNH.ColWidth(3) = 2500
MSNH.CellAlignment = 3
MSNH.ColAlignment(3) = 3
MSNH.Text = " SL nhâp"
' cot thu 5 hien thi DG nhâp
MSNH.Col = 4
MSNH.ColWidth(4) = 1500
MSNH.CellAlignment = 3
MSNH.ColAlignment(4) = 3
MSNH.Text = " DG nhâp"
'danh so thu tu tren luoi
Dim stt
MSNH.Col = 0
For stt = 1 To MSNH.Rows - 1
MSNH.Row = stt
MSNH.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From CTHoaDonNhap"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSNH.Rows <= i Then
    MSNH.Rows = MSNH.Rows + 1
    MSNH.TextMatrix(i, 0) = i
    End If
    MSNH.TextMatrix(i, 1) = rs!MaPN
    MSNH.TextMatrix(i, 2) = rs!mahh
    MSNH.TextMatrix(i, 3) = rs!SLNhap
    MSNH.TextMatrix(i, 4) = rs!DGnhap
   i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSNH.Refresh
End Sub

Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Combo2.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete*from CTHoaDonNhap where MaPN='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
If MSNH.Rows > 1 And MSNH.Rows <> 1 Then
MSNH.RemoveItem (MSNH.Row)
End If
Call khoitaoluoi
Call display
End Sub

Private Sub Command3_Click()
flag = "update"
suadulieu
'text3.SetFocus
End Sub
Private Sub suadulieu()
un_lock_text
Combo1.Enabled = False
Combo2.Enabled = True
Text3.SetFocus
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
If Trim(Combo1) = "" Or Trim(Combo2) = "" Then
MsgBox " Phai nhap du lieu day du truoc khi luu", vbOKOnly + vbExclamation, " Thông Báo"
lock_text
Exit Sub
End If
str = "select*from CTHoaDonNhap where MaPN='" & Trim(Combo1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into CTHoaDonNhap values('" & Trim(Combo1) & "','" & Trim(Combo2) & "','" & Trim(Text3) & "','" & Trim(Text4) & "')"
cn.Execute (str) ' them môt record moi vao bang CTHoaDonNhap
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma Phiêu Nhap da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update CTHoaDonNhap set MaHH='" & Trim(Combo2) & "',SLNhap='" & Trim(Text3) & "',DGNhap='" & Trim(Text4) & "'where MaPN='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
display
End Sub

Private Sub Command5_Click()
RP_Nhap.Show
End Sub

Private Sub msnH_dblclick()
lock_text
MSNH.Col = 1
Combo1.Text = MSNH.Text
MSNH.Col = 2
Combo2.Text = MSNH.Text
MSNH.Col = 3
Text3.Text = MSNH.Text
MSNH.Col = 4
Text4.Text = MSNH.Text
End Sub


Private Sub Form_Load()
ConnectDataBase
lock_text
rsMapn.Open "select * from HoaDonNH", cn
Do While rsMapn.EOF = False
Combo1.AddItem rsMapn.Fields("MaPN")
rsMapn.MoveNext
Loop

rsmahh.Open "select * from HangHoa", cn
Do While rsmahh.EOF = False
Combo2.AddItem rsmahh.Fields("Mahh")
rsmahh.MoveNext
Loop
khoitaoluoi
display
End Sub
Private Sub lock_text()
Text4.Enabled = False
Combo1.Enabled = False
Combo2.Enabled = False
Text3.Enabled = False
Command4.Enabled = False
Command1.Enabled = True
Command2.Enabled = True
Command3.Enabled = True
End Sub
Private Sub un_lock_text()
Text4.Enabled = True
Combo1.Enabled = True
Combo2.Enabled = True
Text3.Enabled = True
Command4.Enabled = True
Command1.Enabled = False
Command2.Enabled = False
Command3.Enabled = False
End Sub
Private Sub Command6_Click()
Unload Me
F_Main.Show
rsMapn.Close
rsmahh.Close
End Sub



Private Sub Text3_LostFocus()
If (Not IsNumeric(Text3.Text)) Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
  End If
End Sub

Private Sub Text4_lostfocus()
If (Not IsNumeric(Text4.Text)) Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
  End If
End Sub
