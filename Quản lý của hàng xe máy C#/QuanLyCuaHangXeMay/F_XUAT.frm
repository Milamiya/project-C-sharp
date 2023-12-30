VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_XUAT 
   BackColor       =   &H0000FFFF&
   Caption         =   "XUAT HANG"
   ClientHeight    =   6870
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   8445
   LinkTopic       =   "Form1"
   ScaleHeight     =   6870
   ScaleWidth      =   8445
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFF80&
      ForeColor       =   &H00C0FFC0&
      Height          =   1215
      Left            =   0
      TabIndex        =   11
      Top             =   5400
      Width           =   8295
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
         Left            =   6960
         TabIndex        =   17
         Top             =   360
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
         Left            =   5760
         TabIndex        =   16
         Top             =   360
         Width           =   975
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
         Left            =   4320
         TabIndex        =   15
         Top             =   360
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
         Left            =   2880
         TabIndex        =   14
         Top             =   360
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
         Left            =   1440
         TabIndex        =   13
         Top             =   360
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
         Top             =   360
         Width           =   1215
      End
   End
   Begin MSFlexGridLib.MSFlexGrid MSBH 
      Height          =   1815
      Left            =   0
      TabIndex        =   10
      Top             =   3480
      Width           =   8415
      _ExtentX        =   14843
      _ExtentY        =   3201
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FF8080&
      Height          =   2655
      Left            =   0
      TabIndex        =   1
      Top             =   720
      Width           =   8415
      Begin VB.TextBox Text4 
         Height          =   615
         Left            =   5760
         TabIndex        =   9
         Top             =   1200
         Width           =   2295
      End
      Begin VB.TextBox Text3 
         Height          =   615
         Left            =   5760
         TabIndex        =   8
         Top             =   240
         Width           =   2295
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   2040
         TabIndex        =   7
         Top             =   1440
         Width           =   1815
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2040
         TabIndex        =   6
         Top             =   360
         Width           =   1815
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H00FF8080&
         Caption         =   "Don Giá Bán"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   495
         Left            =   3960
         TabIndex        =   5
         Top             =   1320
         Width           =   1455
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H00FF8080&
         Caption         =   "Sô Luong Bán"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   495
         Left            =   3960
         TabIndex        =   4
         Top             =   360
         Width           =   1575
      End
      Begin VB.Label Label3 
         BackColor       =   &H00FF8080&
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
         ForeColor       =   &H8000000E&
         Height          =   495
         Left            =   120
         TabIndex        =   3
         Top             =   1440
         Width           =   1575
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00FF8080&
         Caption         =   "Mã Hóa Don Ban"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   495
         Left            =   0
         TabIndex        =   2
         Top             =   360
         Width           =   2055
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H0000FFFF&
      Caption         =   "Danh Muc Xuât Hàng"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   1680
      TabIndex        =   0
      Top             =   120
      Width           =   5055
   End
End
Attribute VB_Name = "F_XUAT"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Option Explicit
Private flag As String
Dim rsMaHDB As New ADODB.Recordset
Dim rsmahh As New ADODB.Recordset



Private Sub Combo1_Click()
rsMaHDB.Find " MaHDB ='" & Combo1.Text & "'", , , adBookmarkFirst
End Sub

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
MSBH.Cols = 5
MSBH.Rows = 20
MSBH.Font.Size = 10
MSBH.Row = 0
'cot dau tien hien thi so thu tu
MSBH.Col = 0
MSBH.ColWidth(0) = 600
MSBH.CellAlignment = 3
MSBH.ColAlignment(0) = 3
MSBH.Text = " STT"
'cot thu 2 hien thi ma Hóa Don Ban
MSBH.Col = 1
MSBH.ColWidth(1) = 1200
MSBH.CellAlignment = 3
MSBH.ColAlignment(1) = 3
MSBH.Text = " Mã HDB "
'cot thu3 hien thi Mã HH
MSBH.Col = 2
MSBH.ColWidth(2) = 2500
MSBH.CellAlignment = 3
MSBH.ColAlignment(2) = 3
MSBH.Text = " Mã HH"
'cot thu 4 hien thi Sô Luong Xuât
MSBH.Col = 3
MSBH.ColWidth(3) = 2500
MSBH.CellAlignment = 3
MSBH.ColAlignment(3) = 3
MSBH.Text = " SL Bán"
' cot thu 5 hien thi DG Bán
MSBH.Col = 4
MSBH.ColWidth(4) = 1500
MSBH.CellAlignment = 3
MSBH.ColAlignment(4) = 3
MSBH.Text = " DG Bán"
'danh so thu tu tren luoi
Dim stt
MSBH.Col = 0
For stt = 1 To MSBH.Rows - 1
MSBH.Row = stt
MSBH.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From CTHoaDonBan"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSBH.Rows <= i Then
    MSBH.Rows = MSBH.Rows + 1
    MSBH.TextMatrix(i, 0) = i
    End If
    MSBH.TextMatrix(i, 1) = rs!MaHDB
    MSBH.TextMatrix(i, 2) = rs!mahh
    MSBH.TextMatrix(i, 3) = rs!SLBan
    MSBH.TextMatrix(i, 4) = rs!DGBan
   i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSBH.Refresh
End Sub

Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Combo2.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete*from CTHoaDonBan where MaHDB='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
If MSBH.Rows > 1 And MSBH.Rows <> 1 Then
MSBH.RemoveItem (MSBH.Row)
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
str = "select*from CTHoaDonBan where MaHDB='" & Trim(Combo1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into CTHoaDonBan values('" & Trim(Combo1) & "','" & Trim(Combo2) & "','" & Trim(Text3) & "','" & Trim(Text4) & "')"
cn.Execute (str) ' them môt record moi vao bang CTHoaDonBan
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma Hóa don Bán da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update CTHoaDonBan set MaHH='" & Trim(Combo2) & "',SLBan='" & Trim(Text3) & "',DGBAn='" & Trim(Text4) & "'where MaHDB='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
display
End Sub

Private Sub Command5_Click()
RP_Xuat.Show
End Sub

Private Sub msbH_dblclick()
lock_text
MSBH.Col = 1
Combo1.Text = MSBH.Text
MSBH.Col = 2
Combo2.Text = MSBH.Text
MSBH.Col = 3
Text3.Text = MSBH.Text
MSBH.Col = 4
Text4.Text = MSBH.Text
End Sub


Private Sub Form_Load()
ConnectDataBase
lock_text
rsMaHDB.Open "select * from HoaDonBH", cn
Do While rsMaHDB.EOF = False
Combo1.AddItem rsMaHDB.Fields("MaHDB")
rsMaHDB.MoveNext
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
rsMaHDB.Close
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
