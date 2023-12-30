VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_DMKH 
   BackColor       =   &H00FFFF80&
   Caption         =   "THONG TIN KHACH HANG "
   ClientHeight    =   8670
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10755
   LinkTopic       =   "Form1"
   ScaleHeight     =   8670
   ScaleWidth      =   10755
   StartUpPosition =   3  'Windows Default
   Begin MSFlexGridLib.MSFlexGrid MSKH 
      Height          =   2295
      Left            =   120
      TabIndex        =   25
      Top             =   4920
      Width           =   10455
      _ExtentX        =   18441
      _ExtentY        =   4048
      _Version        =   393216
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00C0C0FF&
      Height          =   1095
      Left            =   0
      TabIndex        =   18
      Top             =   7440
      Width           =   10575
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
         Left            =   9120
         TabIndex        =   24
         Top             =   240
         Width           =   1335
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
         Left            =   7320
         TabIndex        =   23
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
         Left            =   5520
         TabIndex        =   22
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
         Left            =   3840
         TabIndex        =   21
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
         Left            =   2040
         TabIndex        =   20
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
         TabIndex        =   19
         Top             =   240
         Width           =   1335
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H0080FFFF&
      Height          =   3735
      Left            =   120
      TabIndex        =   1
      Top             =   1080
      Width           =   10455
      Begin VB.TextBox Txtns 
         Height          =   495
         Left            =   7680
         TabIndex        =   17
         Top             =   2760
         Width           =   2655
      End
      Begin VB.TextBox Txtcm 
         Height          =   495
         Left            =   7680
         TabIndex        =   15
         Top             =   1920
         Width           =   2655
      End
      Begin VB.ComboBox Combo2 
         Height          =   315
         Left            =   7680
         TabIndex        =   12
         Top             =   1080
         Width           =   2655
      End
      Begin VB.TextBox Txtdc 
         Height          =   495
         Left            =   7680
         TabIndex        =   11
         Top             =   240
         Width           =   2655
      End
      Begin VB.TextBox Txttuoi 
         Alignment       =   2  'Center
         Height          =   495
         Left            =   2400
         TabIndex        =   9
         Top             =   2880
         Width           =   2415
      End
      Begin VB.TextBox Txtdt 
         Alignment       =   2  'Center
         Height          =   495
         Left            =   2400
         TabIndex        =   7
         Top             =   1920
         Width           =   2415
      End
      Begin VB.TextBox Txtkh 
         Alignment       =   2  'Center
         Height          =   495
         Left            =   2400
         TabIndex        =   5
         Top             =   1080
         Width           =   2415
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         Left            =   2400
         TabIndex        =   3
         Top             =   360
         Width           =   2415
      End
      Begin VB.Label Label9 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
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
         Left            =   5400
         TabIndex        =   16
         Top             =   2880
         Width           =   1935
      End
      Begin VB.Label Label8 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Caption         =   "Sô CMND"
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
         Left            =   5400
         TabIndex        =   14
         Top             =   2040
         Width           =   1815
      End
      Begin VB.Label Label7 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
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
         Height          =   615
         Left            =   5280
         TabIndex        =   13
         Top             =   1200
         Width           =   2055
      End
      Begin VB.Label Label6 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
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
         Height          =   495
         Left            =   5400
         TabIndex        =   10
         Top             =   360
         Width           =   1815
      End
      Begin VB.Label Label5 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Caption         =   "Tuôi Khách Hàng"
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
         TabIndex        =   8
         Top             =   2880
         Width           =   1935
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Caption         =   "Sô D/Thoai"
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
         TabIndex        =   6
         Top             =   2040
         Width           =   1935
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Caption         =   "Tên Khách Hàng"
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
         Top             =   1200
         Width           =   2055
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H0080FFFF&
         Caption         =   "Mã Khách Hàng"
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
         Left            =   240
         TabIndex        =   2
         Top             =   360
         Width           =   1815
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFF80&
      Caption         =   "Thông Tin Khách Hàng"
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
      Left            =   3000
      TabIndex        =   0
      Top             =   240
      Width           =   5415
   End
End
Attribute VB_Name = "F_DMKH"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Private flag As String
Dim rsmakh As New ADODB.Recordset

Private Sub Command5_Click()
RP_KH.Show
End Sub

Private Sub Form_Load()
ConnectDataBase
Combo2.AddItem "Nam"
Combo2.AddItem "Nu"
lock_text
rsmakh.Open "select * from KhachHang", cn
Do While rsmakh.EOF = False
Combo1.AddItem rsmakh.Fields("MaKH")
rsmakh.MoveNext
Loop
khoitaoluoi
display
End Sub
Private Sub lock_text()
Combo1.Enabled = False
Combo2.Enabled = False
Txtkh.Enabled = False
Txtns.Enabled = False
Txtdc.Enabled = False
Txttuoi.Enabled = False
Txtdt.Enabled = False
Txtcm.Enabled = False
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
Txtkh.Text = ""
Txtdc.Text = ""
Txttuoi.Text = ""
Txtdc.Text = ""
Combo1.Text = ""
Combo2.Text = ""
Txtdt.Text = ""
Txtns.Text = ""
End Sub
Private Sub khoitaoluoi()
' khoi tao luoi gam 9 cot,20 dong
MSKH.Cols = 9
MSKH.Rows = 20
MSKH.Font.Size = 10
MSKH.Row = 0
'cot dau tien hien thi so thu tu
MSKH.Col = 0
MSKH.ColWidth(0) = 600
MSKH.CellAlignment = 3
MSKH.ColAlignment(0) = 3
MSKH.Text = " STT"
'cot thu 2 hien thi ma KH
MSKH.Col = 1
MSKH.ColWidth(1) = 1500
MSKH.CellAlignment = 3
MSKH.ColAlignment(1) = 3
MSKH.Text = " Mã Khách Hàng "
'cot thu3 hien thi Tên KH
MSKH.Col = 2
MSKH.ColWidth(2) = 1600
MSKH.CellAlignment = 3
MSKH.ColAlignment(2) = 3
MSKH.Text = " Tên KH"
'cot thu 4 hien thi Sô DT
MSKH.Col = 3
MSKH.ColWidth(3) = 1000
MSKH.CellAlignment = 3
MSKH.ColAlignment(3) = 3
MSKH.Text = " Sô DT"
' cot thu 5 hien thi Tuoi KH
MSKH.Col = 4
MSKH.ColWidth(4) = 600
MSKH.CellAlignment = 3
MSKH.ColAlignment(4) = 3
MSKH.Text = " Tuôi KH"
'cot thu 6 hien thi Dia Chi KH
MSKH.Col = 5
MSKH.ColWidth(5) = 2400
MSKH.CellAlignment = 3
MSKH.ColAlignment(5) = 3
MSKH.Text = " Dia Chi "
'cot thu 7 hien thi Gi?i TÍnh
MSKH.Col = 6
MSKH.ColWidth(6) = 1000
MSKH.CellAlignment = 3
MSKH.ColAlignment(6) = 3
MSKH.Text = "Gioi TÍnh"
'côt thu 8 hien thi Sô CMND
MSKH.Col = 7
MSKH.ColWidth(7) = 1200
MSKH.CellAlignment = 3
MSKH.ColAlignment(7) = 3
MSKH.Text = "Sô CMND"
'côt thu 9 hien thi Ngày Sinh"
MSKH.Col = 8
MSKH.ColWidth(8) = 1200
MSKH.CellAlignment = 3
MSKH.ColAlignment(8) = 3
MSKH.Text = "Ngày Sinh"
'danh so thu tu tren luoi
Dim stt
MSKH.Col = 0
For stt = 1 To MSKH.Rows - 1
MSKH.Row = stt
MSKH.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From KhachHang"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSKH.Rows <= i Then
    MSKH.Rows = MSKH.Rows + 1
    MSKH.TextMatrix(i, 0) = i
    End If
    MSKH.TextMatrix(i, 1) = rs!MaKH
    MSKH.TextMatrix(i, 2) = rs!tenkh
    MSKH.TextMatrix(i, 3) = rs!DTKH
    MSKH.TextMatrix(i, 4) = rs!tuoi
    MSKH.TextMatrix(i, 5) = rs!DCKH
    MSKH.TextMatrix(i, 6) = rs!GioiTinh
    MSKH.TextMatrix(i, 7) = rs!SoCMND
    MSKH.TextMatrix(i, 8) = rs!NgaySinh
    i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSKH.Refresh
End Sub
Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Txtkh.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete* from KhachHang where MaKH='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
If MSKH.Rows > 1 And MSKH.Rows <> 1 Then
MSKH.RemoveItem (MSKH.Row)
End If
Call khoitaoluoi
Call display
End Sub


Private Sub Command3_Click()
flag = "update"
suadulieu
'txtkh.SetFocus
End Sub
Private Sub suadulieu()
un_lock_text
Combo1.Enabled = False
Txtkh.SetFocus
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
If Trim(Combo1) = "" Or Trim(Txtkh) = "" Then
MsgBox " Phai nhap du lieu day du truoc khi luu", vbOKOnly + vbExclamation, " Thông Báo"
lock_text
Exit Sub
End If
str = "select*from KhachHang where Makh='" & Trim(Combo1) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into KhachHang values('" & Trim(Combo1) & "','" & Trim(Txtkh) & "','" & Trim(Txtdt) & "','" & Trim(Txttuoi) & "','" & Trim(Txtdc) & "','" & Trim(Combo2) & "','" & Trim(Txtcm) & "','" & Trim(Txtns) & "')"
cn.Execute (str) ' them môt record moi vao bang KhachHang
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma Khách Hàng da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update KhachHang set TenkH='" & Trim(Txtkh) & "',DTKH='" & Trim(Txtdt) & "',Tuoi='" & Trim(Txttuoi) & "',DCKH='" & Trim(Txtdc) & "',GioiTinh='" & Trim(Combo2) & "',SoCMND='" & Trim(Txtcm) & "',NgaySinh='" & Trim(Txtns) & "' where MakH='" & Trim(Combo1) & "'"
cn.Execute (str)
End If
display
End Sub



Private Sub mskh_dblclick()
lock_text
MSKH.Col = 1
Combo1.Text = MSKH.Text
MSKH.Col = 2
Txtkh.Text = MSKH.Text
MSKH.Col = 3
Txtdt.Text = MSKH.Text
MSKH.Col = 4
Txttuoi.Text = MSKH.Text
MSKH.Col = 5
Txtdc.Text = MSKH.Text
MSKH.Col = 6
Combo2.Text = MSKH.Text
MSKH.Col = 7
Txtcm.Text = MSKH.Text
MSKH.Col = 8
Txtns.Text = MSKH.Text
End Sub

Private Sub un_lock_text()
Txtdt.Enabled = True
Txttuoi.Enabled = True
Txtns.Enabled = True
Txtkh.Enabled = True
Txtdc.Enabled = True
Combo1.Enabled = True
Combo2.Enabled = True
Txtcm.Enabled = True
Command4.Enabled = True
Command1.Enabled = False
Command2.Enabled = False
Command3.Enabled = False
End Sub
Private Sub Command6_Click()
Unload Me
F_Main.Show
rsmakh.Close
End Sub

Private Sub Combo1_Click()
rsmakh.Find " makh ='" & Combo1.Text & "'", , , adBookmarkFirst
Txtkh.Text = rsmakh.Fields("TenKH")
End Sub


Private Sub Txtcm_lostfocus()
If (Not IsNumeric(Txtcm.Text)) Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
  End If
End Sub

Private Sub Txtdt_LostFocus()
If (Not IsNumeric(Txtdt.Text)) Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
  End If
End Sub

Private Sub txtns_LostFocus()
If Not IsDate(Txtns.Text) Then
    MsgBox "Ngày tháng không h?p l?", vbOKOnly + vbExclamation, "thông báo"
    Txtns.Text = ""
    Txtkh.SetFocus
    'lock_text
End If
End Sub

Private Sub Txttuoi_LostFocus()
If (Not IsNumeric(Txttuoi.Text)) Then
    MsgBox "Du lieu phai la kieu so", vbOKCancel + vbExclamation, "Thong bao"
  End If
End Sub
