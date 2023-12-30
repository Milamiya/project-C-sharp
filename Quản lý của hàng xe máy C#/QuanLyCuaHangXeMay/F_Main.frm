VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{0D452EE1-E08F-101A-852E-02608C4D0BB4}#2.0#0"; "FM20.DLL"
Begin VB.Form F_Main 
   BackColor       =   &H0000FFFF&
   Caption         =   "(~*~Truong Cao Dang Duc Tri - Khoa Cong Nghe Thong Tin~Http://p2share.com*~)"
   ClientHeight    =   6075
   ClientLeft      =   225
   ClientTop       =   855
   ClientWidth     =   7545
   LinkTopic       =   "Form1"
   Picture         =   "F_Main.frx":0000
   ScaleHeight     =   6075
   ScaleWidth      =   7545
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   90
      Left            =   120
      Top             =   3240
   End
   Begin MSComctlLib.StatusBar StatusBar1 
      Align           =   2  'Align Bottom
      Height          =   495
      Left            =   0
      TabIndex        =   6
      Top             =   5580
      Width           =   7545
      _ExtentX        =   13309
      _ExtentY        =   873
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   2
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   5
            Picture         =   "F_Main.frx":4041F
            TextSave        =   "11:10 PM"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   6
            Picture         =   "F_Main.frx":4082A
            TextSave        =   "10/01/12"
         EndProperty
      EndProperty
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00FFFF00&
      Height          =   1335
      Left            =   3960
      TabIndex        =   1
      Top             =   4200
      Width           =   3495
      Begin VB.TextBox Txtquyen 
         Height          =   375
         Left            =   1560
         TabIndex        =   5
         Top             =   840
         Width           =   1815
      End
      Begin VB.TextBox Txtten 
         Height          =   375
         Left            =   1560
         TabIndex        =   3
         Top             =   240
         Width           =   1815
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "Quyên"
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
         TabIndex        =   4
         Top             =   960
         Width           =   855
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         BackColor       =   &H00FFFF00&
         Caption         =   "Tên"
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
         Left            =   240
         TabIndex        =   2
         Top             =   360
         Width           =   615
      End
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H008080FF&
      Height          =   1215
      Left            =   0
      TabIndex        =   0
      Top             =   4320
      Width           =   3855
      Begin VB.CommandButton Cmdtt 
         Caption         =   "Thông Tin"
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
         TabIndex        =   9
         Top             =   240
         Width           =   1095
      End
      Begin VB.CommandButton cmdtk 
         Caption         =   "Tìm Kiêm"
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
         Left            =   1320
         Picture         =   "F_Main.frx":40BE3
         TabIndex        =   7
         Top             =   240
         Width           =   1095
      End
      Begin MSForms.CommandButton CmdThoat 
         CausesValidation=   0   'False
         Height          =   615
         Left            =   2640
         TabIndex        =   8
         Top             =   240
         Width           =   975
         Caption         =   "Thoát"
         Size            =   "1720;1085"
         FontEffects     =   1073741825
         FontHeight      =   195
         FontCharSet     =   0
         FontPitchAndFamily=   2
         ParagraphAlign  =   3
         FontWeight      =   700
      End
   End
   Begin VB.Menu mnhthong 
      Caption         =   "Hê Thông"
      Begin VB.Menu mndnhap 
         Caption         =   "Dang Nhap"
      End
      Begin VB.Menu mnthoat 
         Caption         =   "Thoat"
         Shortcut        =   ^X
      End
   End
   Begin VB.Menu mnql 
      Caption         =   "Quan Lý"
      Begin VB.Menu mnnhap 
         Caption         =   "Nhâp Hàng"
      End
      Begin VB.Menu mnxuat 
         Caption         =   "Xuât Hàng"
      End
      Begin VB.Menu mnNV 
         Caption         =   "Nhân Viên"
      End
      Begin VB.Menu mnKH 
         Caption         =   "Khách Hàng"
      End
      Begin VB.Menu mnncc 
         Caption         =   "Nhà Cung Câp"
      End
      Begin VB.Menu mnThu 
         Caption         =   "Phiêu Thu"
      End
      Begin VB.Menu mnChi 
         Caption         =   "Phiêu Chi"
      End
      Begin VB.Menu mnqlhd 
         Caption         =   "Hóa Don"
         Begin VB.Menu mnhdxuat 
            Caption         =   "Xuât"
            Index           =   2
         End
         Begin VB.Menu mnhdnhap 
            Caption         =   "Nhâp"
            Index           =   3
         End
      End
      Begin VB.Menu mnus 
         Caption         =   "New User"
      End
   End
   Begin VB.Menu mntk 
      Caption         =   "Tìm Kiêm"
      Begin VB.Menu mntknv 
         Caption         =   "Nhân Viên"
      End
      Begin VB.Menu mntkkh 
         Caption         =   "Khách Hàng"
      End
      Begin VB.Menu mntkncc 
         Caption         =   "Nhà Cung Câp"
      End
      Begin VB.Menu mntkhh 
         Caption         =   "Hàng Hóa"
      End
      Begin VB.Menu mnhd 
         Caption         =   "Hóa Don"
         Begin VB.Menu mnhdn 
            Caption         =   "Nhâp"
         End
         Begin VB.Menu mnhdx 
            Caption         =   "Xuât"
         End
      End
   End
   Begin VB.Menu mnTg 
      Caption         =   "Tro Giúp"
   End
End
Attribute VB_Name = "F_Main"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Option Explicit
Public taikhoan As String
Public quyen As String
Dim PreWith As Long, PreHeight As Long


Private Sub cmdthoat_Click()
MsgBox "  ban có muôn thoát kh?i ch??ng trình không ?", vbOKCancel + vbExclamation, " thông báo"
End
End Sub

Private Sub cmdtk_Click()
F_TIMKIEM.Show
F_Main.Hide
End Sub

Private Sub Cmdtt_Click()
F_Thongtin.Show
F_Main.Hide
End Sub

Private Sub Form_Load()
''On Error GoTo nextx
'Dim rs As Recordset
'Set rs = New Recordset
'rs.Open "select * from sec_user where isadmin=1 and usergroupid=" + curuser.EmployeeID, cn, 1, 3
'If rs.RecordCount = 0 Then
'End If

    Txtten.Text = taikhoan
    Txtquyen.Text = quyen
    Txtten.Enabled = False
    Txtquyen.Enabled = False
    Connect_To_DataBase
   PreWith = Me.Width
   PreHeight = Me.Height
nextx:

End Sub

Private Sub mnChi_Click()
F_Main.Hide
F_PHIEUCHI.Show
End Sub

Private Sub mndnhap_Click()
F_Main.Hide
F_DNhap.Show
Txtten.Text = taikhoan
Txtquyen.Text = quyen

End Sub

Private Sub mnhdn_Click()
F_Main.Hide
F_TKHDN.Show
End Sub

Private Sub mnhdnhap_Click(Index As Integer)
F_Main.Hide
F_QLHDN.Show
End Sub

Private Sub mnhdx_Click()
F_Main.Hide
F_TKHDX.Show
End Sub

Private Sub mnhdxuat_Click(Index As Integer)
F_Main.Hide
F_QLHDX.Show
End Sub

Private Sub mnKH_Click()
F_Main.Hide
F_DMKH.Show
End Sub

Private Sub mnncc_Click()
F_Main.Hide
F_DMNCC.Show
End Sub

Private Sub mnnhap_Click()
F_Main.Hide
F_NHAP.Show
End Sub

Private Sub mnNV_Click()
F_Main.Hide
F_DMNV.Show
End Sub

Private Sub mnThu_Click()
F_Main.Hide
F_PHIEUTHU.Show
End Sub

Private Sub mntkhh_Click()
F_Main.Hide
F_TKHH.Show
End Sub

Private Sub mntkkh_Click()
F_Main.Hide
F_TKKH.Show
End Sub

Private Sub mntkncc_Click()
F_Main.Hide
F_TKNCC.Show
End Sub

Private Sub mntknv_Click()
F_Main.Hide
F_TKNV.Show
End Sub

Private Sub mnus_Click()
F_Main.Hide
F_NUSER.Show
End Sub

Private Sub mnxuat_Click()
F_Main.Hide
F_XUAT.Show
End Sub

Private Sub Timer1_Timer()
F_Main.Caption = Right(F_Main.Caption, Len(F_Main.Caption) - 1)
    If F_Main.Caption = "" Then
        F_Main.Caption = Space(50) & "(~*~Chuong Trinh Quan Ly Hàng Hóa Cty TNHH Quôc Tu?n~*~)" & Space(50) & "(~*~Design by Nguyen Tuan Duong~*~)" & Space(50) & "(~*~Truong Cao Dang Duc Tri - Khoa Cong Nghe Thong Tin~*~)"
    End If
End Sub
