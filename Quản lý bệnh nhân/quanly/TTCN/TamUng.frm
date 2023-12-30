VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmTamUng 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Tam Ung"
   ClientHeight    =   8055
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9630
   Icon            =   "TamUng.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8055
   ScaleWidth      =   9630
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      Caption         =   "Taïm öùng"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2655
      Left            =   120
      TabIndex        =   10
      Top             =   0
      Width           =   9375
      Begin VB.TextBox txtLanTamUng 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2520
         TabIndex        =   24
         Top             =   1680
         Width           =   2415
      End
      Begin VB.TextBox txtKhoanTamUng 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2520
         TabIndex        =   18
         Top             =   2160
         Width           =   4335
      End
      Begin VB.TextBox txtSoTien 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2520
         TabIndex        =   16
         Top             =   720
         Width           =   2415
      End
      Begin VB.TextBox txtMaTamUng 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2520
         MaxLength       =   8
         TabIndex        =   15
         Top             =   240
         Width           =   2415
      End
      Begin MSMask.MaskEdBox marNgayTamUng 
         Height          =   375
         Left            =   2520
         TabIndex        =   17
         Top             =   1200
         Width           =   2415
         _ExtentX        =   4260
         _ExtentY        =   661
         _Version        =   393216
         MaxLength       =   10
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Mask            =   "##/##/####"
         PromptChar      =   "_"
      End
      Begin VB.Label Label7 
         Caption         =   "Laàn taïm öùng"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   360
         TabIndex        =   25
         Top             =   1680
         Width           =   1935
      End
      Begin VB.Label Label1 
         Caption         =   "Maõ taïm öùng"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   360
         TabIndex        =   14
         Top             =   360
         Width           =   2175
      End
      Begin VB.Label Label2 
         Caption         =   "Khoaûn taïm öùng"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   360
         TabIndex        =   13
         Top             =   2160
         Width           =   2055
      End
      Begin VB.Label Label3 
         Caption         =   "Soá tieàn"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   360
         TabIndex        =   12
         Top             =   720
         Width           =   2175
      End
      Begin VB.Label Label4 
         Caption         =   "Ngaøy taïm öùng"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   360
         TabIndex        =   11
         Top             =   1200
         Width           =   2055
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "Thoâng tin beänh nhaân taïm öùng"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Left            =   120
      TabIndex        =   7
      Top             =   2640
      Width           =   9375
      Begin VB.CommandButton cmdKhac 
         Caption         =   "......"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   7320
         TabIndex        =   23
         Top             =   360
         Width           =   1095
      End
      Begin VB.OptionButton OpNam 
         Caption         =   "Nam"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   22
         Top             =   1200
         Width           =   1095
      End
      Begin VB.OptionButton opNu 
         Caption         =   "Nöõ"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1680
         TabIndex        =   21
         Top             =   1200
         Width           =   1215
      End
      Begin VB.TextBox txtNguoiTamUng 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2520
         TabIndex        =   19
         Top             =   360
         Width           =   4455
      End
      Begin MSMask.MaskEdBox marNgaySinh 
         Height          =   375
         Left            =   2520
         TabIndex        =   20
         Top             =   840
         Width           =   4455
         _ExtentX        =   7858
         _ExtentY        =   661
         _Version        =   393216
         MaxLength       =   10
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Mask            =   "##/##/####"
         PromptChar      =   "_"
      End
      Begin VB.Label Label6 
         Caption         =   "Ngaøy sinh beänh nhaân"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   9
         Top             =   840
         Width           =   2175
      End
      Begin VB.Label Label5 
         Caption         =   "Hoï teân beänh nhaân"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   8
         Top             =   360
         Width           =   2175
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Chöùc naêng"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   120
      TabIndex        =   1
      Top             =   6960
      Width           =   9375
      Begin VB.CommandButton cmdMoi 
         Caption         =   "Môùi"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   360
         TabIndex        =   6
         Top             =   360
         Width           =   975
      End
      Begin VB.CommandButton cmdSua 
         Caption         =   "Söûa"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2280
         TabIndex        =   5
         Top             =   360
         Width           =   975
      End
      Begin VB.CommandButton cmdXoa 
         Caption         =   "Xoaù"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   4320
         TabIndex        =   4
         Top             =   360
         Width           =   855
      End
      Begin VB.CommandButton cmdLuu 
         Caption         =   "Löu"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   6240
         TabIndex        =   3
         Top             =   360
         Width           =   855
      End
      Begin VB.CommandButton cmdThoat 
         Caption         =   "Thoaùt"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   8040
         TabIndex        =   2
         Top             =   360
         Width           =   975
      End
   End
   Begin MSComctlLib.ListView lstTamUng 
      Height          =   2415
      Left            =   120
      TabIndex        =   0
      Top             =   4440
      Width           =   9375
      _ExtentX        =   16536
      _ExtentY        =   4260
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   9
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Maõ taïm öùng"
         Object.Width           =   2512
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Ngöôøi tam öùng"
         Object.Width           =   4480
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Khoaûn taïm öùng"
         Object.Width           =   4410
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Soá tieàn"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Ngaøy "
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "NgaySinh"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   6
         Text            =   "GioiTinh"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   7
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(9) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   8
         Object.Width           =   0
      EndProperty
   End
End
Attribute VB_Name = "frmTamUng"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaBenhNhanLst$, HoTenBenhNhanLst$, NgaysinhBenhNhanLst$
Dim CoLuu As String

Private Sub cmdKhac_Click()
    frmDanhSachBenhNhan.Show 1
    Dim MaBenhNhan$, HoTenBenhNhan$, NgaySinhBenhNhan$
    Dim GioiTinhBenhNhan As Boolean
    frmDanhSachBenhNhan.clThongTinBenhNhan.TraThongTinVeTuDanhSachBenhNhan _
                    MaBenhNhan, HoTenBenhNhan, NgaySinhBenhNhan, GioiTinhBenhNhan
    txtNguoiTamUng.Text = HoTenBenhNhan
    marNgaySinh.Text = NgaySinhBenhNhan
    OpNam = GioiTinhBenhNhan
    OpNu = Not GioiTinhBenhNhan
End Sub

Private Sub cmdLuu_Click()
    Dim MaTamUng$, KhoanTamUng$, SoTien As Currency
    Dim MaBenhNhan$, HoTenBenhNhan$, SQL$
    Dim NgayTamUng$, NgaySinhBenhNhan$, LanTamUng As Integer
    Dim Msg%, Tes%, GioiTinh As Boolean
    Dim rs As ADODB.Recordset
    LanTamUng = 0
    MaTamUng = Trim(txtMaTamUng.Text)
    KhoanTamUng = Trim(txtKhoanTamUng.Text)
    SoTien = Str(Trim(txtSoTien))
    frmDanhSachBenhNhan.clThongTinBenhNhan.TraThongTinVeTuDanhSachBenhNhan _
                    MaBenhNhan, HoTenBenhNhan, NgaySinhBenhNhan, GioiTinh
    MaBenhNhan = Trim(MaBenhNhan)
    'hotenbenhnhan = Trim(HoTenBenhNhan)
    If MaBenhNhan = "" Then
        If CoLuu = "Moi" Then
            MsgBox "Ban chua chon ten benh nhan", vbInformation
            Exit Sub
        Else
            If CoLuu = "Sua" Then
                MaBenhNhan = MaBenhNhanLst
                Trim (MaBenhNhan)
                If MaBenhNhan = "" Then
                    MsgBox "Ban chua chon benh nhan can sua"
                    Exit Sub
                End If
            End If 'Coluu=Sua
        End If
    End If 'end if MaBn=" "
    If MaTamUng = "" Then
        MsgBox "Ban chua nhap ma tam ung", vbInformation
        Exit Sub
    Else 'Else MaTU <> ""
        If KiemTraMa(MaTamUng) = False Then
            MsgBox "Ma khong hop le (Ma khong co khoang trang)", vbCritical
            Exit Sub
        End If
        SQL = "Select MaTamUng From tblTamUng Where MaTamUng=" & _
                      MaTamUng
        If (Kt_Text(SQL) = False) And (CoLuu = "Moi") Then
            MsgBox "Ma nay da co trong co so du lieu ban vui long chon ma khac", vbCritical
            Exit Sub
        End If 'end if KT Ma Tam Ung
    End If
    If KhoanTamUng = "" Then
        MsgBox "Ban chua nhap ten khoan tam ung", vbInformation
        Exit Sub
    End If
    If (SoTien <= 0) Then
        MsgBox "So tien tam ung nhap khong hop le (Sotien >0)", vbCritical
        Exit Sub
    End If
    NgayTamUng = SuLiNgay(marNgayTamUng.Text)
    If NgayTamUng = "NotOK" Then
        MsgBox "Ban vui long kiem tra lai ngay thang, ngay thang khong hop le)"
        Exit Sub
    Else 'Else kiem tra ngay tam ung
        'kiem tra ngay co truoc ngay hien tai khong
        If (Date - DateValue(NgayTamUng) < 0) Or (Date - DateValue(NgayTamUng) > 720) Then
            MsgBox "Ban vui long kiem tra lai ngay thang, ngay nay chua toi hoac da qua hai nam roi", vbCritical
            Exit Sub
        End If
    End If ' end if kiem tra ngay tam ung
    ' Them mot phieu tam ung
    If CoLuu = "Moi" Then
        DE.sp_LayLanTamUng MaBenhNhan, LanTamUng
        LanTamUng = LanTamUng + 1
        '-----------------------------------------------
        Tes = DE.sp_NhapTamUng(MaTamUng, KhoanTamUng, _
                        DateValue(NgayTamUng), SoTien, LanTamUng, MaBenhNhan)
        disPlayListView
        SetNull
    Else 'Coluu <> Moi va=Sua
        If CoLuu = "Sua" Then
            Msg = MsgBox("Ban co dong y sua benh nhan nay khong", vbQuestion + vbYesNo)
            If Msg = vbYes Then
                Tes = DE.sp_SuaTamUng(MaTamUng, KhoanTamUng, DateValue(NgayTamUng), SoTien, MaBenhNhan)
                disPlayListView
            End If 'Chon quyet dinh sua
        End If 'End if coluu=Sua
    End If
End Sub

Private Sub cmdMoi_Click()
    CoLuu = "Moi"
    txtMaTamUng.Enabled = True
    txtKhoanTamUng.Enabled = True
    txtSoTien.Enabled = True
    marNgayTamUng.Enabled = True
    marNgaySinh.Enabled = False
    cmdKhac.Enabled = True
    cmdLuu.Enabled = True
    '----------------------------------------
    ' Xoa du lieu trong phuong thuc lay thong tin benh nhan
    frmDanhSachBenhNhan.clThongTinBenhNhan.LayThongTinTuDanhSachBenhNhan " ", " ", " ", False
    SetNull
End Sub

Private Sub cmdSua_Click()
    txtMaTamUng.Enabled = False
    cmdKhac.Enabled = False
    marNgayTamUng.Enabled = True
    marNgaySinh.Enabled = False
    txtSoTien.Enabled = True
    txtKhoanTamUng.Enabled = True
    cmdLuu.Enabled = True
    CoLuu = "Sua"
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    Dim MaTamUng$, Msg%
    MaTamUng = Trim(txtMaTamUng.Text)
    Msg = MsgBox("Ban co dong y xoa phieu tam ung co ma " & MaTamUng, vbYesNo + vbQuestion)
    If Msg = vbYes Then
        DE.sp_XoaTamUng (MaTamUng)
        disPlayListView
        SetNull
    End If
End Sub

Private Sub Form_Load()
    txtMaTamUng.Enabled = False
    txtNguoiTamUng.Enabled = False
    marNgayTamUng.Enabled = False
    txtKhoanTamUng.Enabled = False
    txtSoTien.Enabled = False
    marNgaySinh.Enabled = False
    cmdLuu.Enabled = False
    cmdKhac.Enabled = False
    txtLanTamUng.Enabled = False
    '----------------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    disPlayListView
End Sub
Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim Str As String
    Dim mItem As listItem
    '------------------------------------------
    Str = "Select * From vwTamUng "
    lstTamUng.ListItems.Clear
    Set rs = cn.Execute(Str) 'Thuc Hien Mot Lenh SQL duoc chi ra boi str
    If rs.EOF = False Then
        While Not rs.EOF
            Set mItem = lstTamUng.ListItems.Add(, , Trim(rs!MaTamUng))
            mItem.SubItems(1) = Trim(rs!HoBenhNhan) & " " & Trim(rs!TenBenhNhan)
            mItem.SubItems(2) = Trim(rs!KhoanTamUng)
            mItem.SubItems(3) = rs!sotientamung
            mItem.SubItems(4) = rs!NgayTamUng
            mItem.SubItems(5) = rs!NgaySinhBenhNhan
            mItem.SubItems(6) = rs!GioiTinhBenhNhan
            mItem.SubItems(7) = rs!MaBenhNhan
            mItem.SubItems(8) = rs!LanTamUng
            rs.MoveNext
        Wend
    End If
End Sub

Private Sub lstTamUng_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaTamUng.Text = Item.Text
    txtNguoiTamUng.Text = Item.SubItems(1)
    'HoTenBenhNhanLst = txtNguoiTamUng.Text
    txtKhoanTamUng.Text = Item.SubItems(2)
    txtSoTien.Text = Item.SubItems(3)
    marNgayTamUng.Text = Item.SubItems(4)
    marNgaySinh.Text = Item.SubItems(5)
    'NgaysinhBenhNhanLst = marNgaySinh.Text
    OpNam = Item.SubItems(6)
    OpNu = Not OpNam
    MaBenhNhanLst = Item.SubItems(7)
    txtLanTamUng.Text = Item.SubItems(8)
    cmdKhac.Enabled = False
End Sub

Private Sub SetNull()
    txtMaTamUng.Text = ""
    txtNguoiTamUng.Text = ""
    txtKhoanTamUng.Text = ""
    txtSoTien.Text = ""
    marNgayTamUng.Text = "__/__/____"
    marNgaySinh.Text = "__/__/____"
End Sub

Private Sub txtMaTamUng_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtSoTien_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, True
End Sub
