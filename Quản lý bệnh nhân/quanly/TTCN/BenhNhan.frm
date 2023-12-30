VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmBenhNhan 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Benh Nhan"
   ClientHeight    =   7965
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10725
   Icon            =   "BenhNhan.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7965
   ScaleWidth      =   10725
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame6 
      Caption         =   "Beänh aùn"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3135
      Left            =   7320
      TabIndex        =   31
      Top             =   3840
      Width           =   3255
      Begin VB.CommandButton cmdLapBenhAn 
         Caption         =   "Laäp beänh aùn"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   120
         TabIndex        =   35
         Top             =   1920
         Width           =   1455
      End
      Begin VB.CommandButton cmdChiTietBenhAn 
         Caption         =   "Xem chi tieát"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   1800
         TabIndex        =   34
         Top             =   1920
         Width           =   1335
      End
      Begin VB.OptionButton opKhongCoBenhAn 
         Caption         =   "Khoâng coù"
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
         TabIndex        =   33
         Top             =   1200
         Width           =   1575
      End
      Begin VB.OptionButton opCoBenhAn 
         Caption         =   "Coù Beänh aùn"
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
         TabIndex        =   32
         Top             =   600
         Width           =   1575
      End
   End
   Begin VB.Frame Frame5 
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
      Height          =   855
      Left            =   120
      TabIndex        =   25
      Top             =   6960
      Width           =   10455
      Begin VB.CommandButton cmdMoi 
         Caption         =   "Môùi"
         CausesValidation=   0   'False
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
         TabIndex        =   30
         ToolTipText     =   "Them du lieu"
         Top             =   360
         Width           =   1335
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
         TabIndex        =   29
         Top             =   360
         Width           =   1335
      End
      Begin VB.CommandButton cmdXoa 
         Caption         =   "Xoùa"
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
         Left            =   4440
         TabIndex        =   28
         Top             =   360
         Width           =   1335
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
         Left            =   8880
         TabIndex        =   27
         Top             =   360
         Width           =   1215
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
         Left            =   6720
         TabIndex        =   26
         Top             =   360
         Width           =   1335
      End
   End
   Begin MSComctlLib.ListView lstBenhNhan 
      Height          =   3255
      Left            =   120
      TabIndex        =   24
      Top             =   3720
      Width           =   7095
      _ExtentX        =   12515
      _ExtentY        =   5741
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
      NumItems        =   8
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Maõ Beänh nhaân"
         Object.Width           =   2910
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Hoï teân beänh nhaân"
         Object.Width           =   5293
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Ngaøy sinh"
         Object.Width           =   2364
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Giôùi tính"
         Object.Width           =   1836
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "SoNha"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "Xa"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   6
         Text            =   "Huyen"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   7
         Text            =   "Tinh"
         Object.Width           =   0
      EndProperty
   End
   Begin VB.Frame Frame4 
      Caption         =   "Baûo hieåm benh nhan"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   6480
      TabIndex        =   19
      Top             =   2400
      Width           =   4095
      Begin VB.CommandButton cmdThemMoiBaoHiem 
         Caption         =   "Theâm môùi"
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
         TabIndex        =   23
         Top             =   720
         Width           =   1455
      End
      Begin VB.CommandButton cmdXemBaoHiem 
         Caption         =   "Xem chi tieát"
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
         TabIndex        =   22
         Top             =   240
         Width           =   1455
      End
      Begin VB.OptionButton opKhongCoBaoHiem 
         Caption         =   "Khoâng coù baûo hieåm"
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
         Left            =   120
         TabIndex        =   21
         Top             =   720
         Width           =   2415
      End
      Begin VB.OptionButton opCoBaoHiem 
         Caption         =   "Coù baûo hieåm"
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
         Left            =   120
         TabIndex        =   20
         Top             =   360
         Width           =   1815
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "Ñòa chæ beänh nhaân"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2415
      Left            =   6480
      TabIndex        =   10
      Top             =   0
      Width           =   4095
      Begin VB.TextBox txtXa 
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
         Left            =   960
         TabIndex        =   38
         Top             =   1320
         Width           =   3015
      End
      Begin VB.TextBox txtHuyen 
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
         Left            =   960
         TabIndex        =   37
         Top             =   840
         Width           =   3015
      End
      Begin VB.TextBox txtTinh 
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
         Left            =   960
         TabIndex        =   36
         Top             =   360
         Width           =   3015
      End
      Begin VB.TextBox txtSoNha 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   960
         MaxLength       =   10
         TabIndex        =   14
         Top             =   1800
         Width           =   3015
      End
      Begin VB.ComboBox cbTinh 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   960
         TabIndex        =   13
         Top             =   360
         Width           =   3015
      End
      Begin VB.ComboBox cbHuyen 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   960
         TabIndex        =   12
         Top             =   840
         Width           =   3015
      End
      Begin VB.ComboBox cbXa 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   960
         TabIndex        =   11
         Top             =   1320
         Width           =   3015
      End
      Begin VB.Label Label6 
         Caption         =   "Tænh"
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
         TabIndex        =   18
         Top             =   360
         Width           =   1095
      End
      Begin VB.Label Label7 
         Caption         =   "Huyeän"
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
         TabIndex        =   17
         Top             =   840
         Width           =   1095
      End
      Begin VB.Label Label8 
         Caption         =   "Xaõ"
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
         TabIndex        =   16
         Top             =   1320
         Width           =   1095
      End
      Begin VB.Label Label9 
         Caption         =   "Soá nhaø"
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
         TabIndex        =   15
         Top             =   1800
         Width           =   975
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Thoâng tin beänh nhaân"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3615
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   6135
      Begin VB.Frame Frame2 
         Caption         =   "Giôùi tính beänh nhaân"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1335
         Left            =   360
         TabIndex        =   7
         Top             =   2040
         Width           =   5415
         Begin VB.OptionButton OpNu 
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
            Left            =   480
            TabIndex        =   9
            Top             =   840
            Width           =   1695
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
            Left            =   480
            TabIndex        =   8
            Top             =   360
            Width           =   1695
         End
      End
      Begin MSMask.MaskEdBox marNgaySinhBenhNhan 
         Height          =   375
         Left            =   2400
         TabIndex        =   6
         Top             =   1440
         Width           =   3375
         _ExtentX        =   5953
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
      Begin VB.TextBox txtHoTenBenhNhan 
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
         Left            =   2400
         TabIndex        =   5
         Top             =   960
         Width           =   3375
      End
      Begin VB.TextBox txtMaBenhNhan 
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
         Left            =   2400
         MaxLength       =   8
         TabIndex        =   4
         Top             =   480
         Width           =   3375
      End
      Begin VB.Label Label3 
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
         Left            =   120
         TabIndex        =   3
         Top             =   1440
         Width           =   2175
      End
      Begin VB.Label Label2 
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
         Left            =   120
         TabIndex        =   2
         Top             =   960
         Width           =   2175
      End
      Begin VB.Label Label1 
         Caption         =   "Maõ beänh nhaân"
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
         Left            =   120
         TabIndex        =   1
         Top             =   480
         Width           =   2175
      End
   End
End
Attribute VB_Name = "frmBenhNhan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public clBenhNhan  As New clBenhNhan
Dim MaBenhNhancls$
Dim CoLuu As String
'Dim CoBaoHiem As Boolean
'Dim CoBenhAn As Boolean

Private Sub cbhuyen_Click()
    txtHuyen.Text = cbHuyen.Text
    cbHuyen.Visible = False
    txtHuyen.Visible = True
    disPlaycbXa
End Sub

Private Sub cbTinh_Click()
    txtTinh.Text = cbTinh.Text
    txtTinh.Visible = True
    cbTinh.Visible = False
    disPlayCbHuyen
End Sub

Private Sub cbXa_Click()
    txtXa.Text = cbXa.Text
    txtXa.Visible = True
    cbXa.Visible = False
End Sub

Private Sub cmdChiTietBenhAn_Click()
    Dim MaBenhNhan$, HoTenBenhNhan$, NgaySinh$, GioiTinh As Boolean
    MaBenhNhan = Trim(txtMaBenhNhan.Text)
    HoTenBenhNhan = txtHoTenBenhNhan.Text
    NgaySinh = marNgaySinhBenhNhan.Text
    GioiTinh = OpNam
    clBenhNhan.LayThongTinTuDanhSachBenhNhan MaBenhNhan, _
                HoTenBenhNhan, NgaySinh, GioiTinh
    frmThemXemBenhAn.Co = "Xem"
    frmThemXemBenhAn.Show 1
End Sub

Private Sub cmdLapBenhAn_Click()
    Dim MaBenhNhan$, HoTenBenhNhan$, NgaySinh$, GioiTinh As Boolean
    Dim MaBenhAn$, MaNhanVien$, MaBenh$, NgayVao$, NgayRa$
    Dim MaNoiDieuTri As String
    '------------------------------------------------
    MaBenhNhan = Trim(txtMaBenhNhan.Text)
    HoTenBenhNhan = txtHoTenBenhNhan.Text
    NgaySinh = marNgaySinhBenhNhan.Text
    GioiTinh = OpNam
    clBenhNhan.LayThongTinTuDanhSachBenhNhan MaBenhNhan, _
                HoTenBenhNhan, NgaySinh, GioiTinh
    frmThemXemBenhAn.Co = "Moi"
    frmThemXemBenhAn.Show 1
    frmThemXemBenhAn.clBenhAn.TTBenhAnRa MaBenhAn, _
            MaNhanVien, MaBenh, MaNoiDieuTri, NgayVao, NgayRa
    If Trim(MaBenhAn) = "" Then
        opCoBenhAn = False
        opKhongCoBenhAn = True
    End If
End Sub

Private Sub cmdLuu_Click()
    '---- Bien Benh an
    Dim MaBenhAn$, NgayVao$, NgayRa$, MaBenh$
    Dim CoLuuBenhAn As Boolean, MaNhanVien$
    '--- Bien bao hiem
    Dim SoTheBaoHiem$, NgayBatDau$, PhanTram As Currency
    Dim MaCoQuan$, CoLuuBaoHiem As Boolean, NgayKetThuc$
    Dim CoLuuCanBo As Boolean
    '------ Bien benh nhan
    Dim MaBenhNhan$, HoBenhNhan$, TenBenhNhan$, NgaySinh$
    Dim SoNha$, MaXa$, MaHuyen$, MaTinh$, GioiTinh As Boolean
    Dim TenXa$, TenHuyen$, TenTinh$, Msg As Long
    Dim SQL$, HoTenBenhNhan$, Tes As Long, MaNoiDieuTri$
    '------------------------------------------------------------------
    CoLuuBaoHiem = False
    CoLuuBenhAn = False
    '------------------------------------------------------------
    If CoLuu = "Moi" Then 'Truong hop them mot benh nhan moi
        '------ kiem tra ma benh nhan co hop lie khong -------------------
        MaBenhNhan = Trim(txtMaBenhNhan.Text)
        If MaBenhNhan = "" Then 'Mabenh nhan =""
            MsgBox "Ban chua nhap ma benh nhan ", vbInformation
            Exit Sub
        Else 'Ma benh nhan <> ""
            SQL = "Select * From tblBenhNhan Where MaBenhNhan=" & _
                    MaBenhNhan
            If Kt_Text(SQL) = False Then
                MsgBox "Ban vui long nhap lai ma benh nhan ma nay da co " & _
                                 "trong CSDL", vbCritical
                Exit Sub
            End If 'Kiem tra xem ma benh nhan da co trong co so du lieu chua
        End If 'Kiem tra ma benh nhan
        '--------- Ket thuc kiem tra mabenh nhan --------------------
        
        '------- Tach lay ho ten benh nhan rieng ---------------------
        HoTenBenhNhan = SuLiChuoi(Trim(txtHoTenBenhNhan.Text))
        If HoTenBenhNhan <> "" Then
            TachHoTen HoTenBenhNhan, HoBenhNhan, TenBenhNhan
        Else ' Truong hop chua nhap ho ten benh nhan
            MsgBox "Ban chua nhap ho ten benh nhan", vbInformation
            Exit Sub
        End If 'Kiem tra ho ten benh nhan
        '---- Ket thuc viec kiem tra ho ten ben nhan ----
        
        '--- Kiem tra ngay sinh benh nhan
        NgaySinh = SuLiNgaySinh(marNgaySinhBenhNhan.Text, "BenhNhan")
        If NgaySinh = "NotOK" Then
            MsgBox " Ngay sinh benh nhan khong hop le", vbCritical
            Exit Sub
        End If
        '------Ket thuc kiem tra ngay ----------------
        '----- Xac dinh dia chi benh nhan
        TenTinh = Trim(txtTinh.Text)
        TenHuyen = Trim(txtHuyen.Text)
        TenXa = Trim(txtXa.Text)
        SoNha = Trim(txtSoNha.Text)
        If SoNha = "" Then SoNha = "Chua co"
        If TenTinh = "" Then
            MsgBox "Ban chua chon tinh ma benh nhan song", vbInformation
            Exit Sub
        Else 'TenTinh<>""
            If TenHuyen = "" Then
                MsgBox "Ban chua chon ten huyen ma benh nhan song", vbInformation
                Exit Sub
            Else  'TenHuyen<>""
                If TenXa = "" Then
                    MsgBox "Ban chua chon ten xa", vbInformation
                    Exit Sub
                End If
            End If
        End If
        '------------------------------
        Tes = DE.Sp_LayMaTinh(TenTinh, MaTinh)
        Tes = DE.Sp_LayMaHuyen(TenHuyen, MaTinh, MaHuyen)
        Tes = DE.sp_LayMaXa(TenXa, MaHuyen, MaXa)
        ' End xac dinh ma tinh
        '-----------------
        GioiTinh = OpNam
        '----------------------
        frmThemXemBaoHiemYTe.clBaoHiem.TTBaoHiemRa _
                                        SoTheBaoHiem, NgayBatDau, NgayKetThuc, _
                                        PhanTram, MaCoQuan
        frmThemXemBaoHiemYTe.clBaoHiem.SetNull
        If Trim(SoTheBaoHiem) <> "" Then CoLuuBaoHiem = True
        If Trim(MaCoQuan) <> "" Then CoLuuCanBo = True
        '-------------------------------------------------------------------------
        frmThemXemBenhAn.clBenhAn.TTBenhAnRa MaBenhAn, _
                        MaNhanVien, MaBenh, MaNoiDieuTri, NgayVao, NgayRa
        frmThemXemBenhAn.clBenhAn.SetNull
        If Trim(MaBenhAn) <> "" Then CoLuuBenhAn = True
        DE.sp_NhapBenhNhan MaBenhNhan, HoBenhNhan, TenBenhNhan, _
                            DateValue(NgaySinh), GioiTinh, SoNha, MaXa
        '----- truong hop benh nhan co bao hiem
        '   Luu bao hiem
        If CoLuuBaoHiem = True Then
            DE.sp_NhapBaoHiem MaBenhNhan, SoTheBaoHiem, _
                            Format(NgayBatDau, "dd/mm/yyyy"), _
                            Format(NgayKetThuc, "dd/mm/yyyy"), PhanTram
            ' Benh nhan co bao hiem la can bo
            If CoLuuCanBo = True Then
                DE.sp_NhapCanBo MaBenhNhan, MaCoQuan
            End If
        End If 'Ket thuc luu bao hiem
        ' Benh nhan co benh an
        If CoLuuBenhAn = True Then
            DE.sp_NhapBenhAn MaBenhAn, MaBenhNhan, MaNhanVien, _
                            MaBenh, MaNoiDieuTri, Format(NgayVao, "dd/mm/yyyy"), Trim(NgayRa)
        End If 'Luu benh an
        disPlayListView
        SetNull
    '-----------------------------------------------------------------------
    Else 'Coluu=Sua
        'Kiem tra ten benh nhan sau khi sua
        MaBenhNhan = Trim(txtMaBenhNhan.Text)
        HoTenBenhNhan = SuLiChuoi(Trim(txtHoTenBenhNhan.Text))
        If HoTenBenhNhan <> "" Then
            TachHoTen HoTenBenhNhan, HoBenhNhan, TenBenhNhan
        Else ' Truong hop chua nhap ho ten benh nhan
            MsgBox "Ban chua nhap ho ten benh nhan", vbInformation
            Exit Sub
        End If 'Kiem tra ho ten benh nhan
    '--- Su li ngay sinh sau khi nhap lai
        NgaySinh = SuLiNgaySinh(marNgaySinhBenhNhan.Text, "BenhNhan")
        If NgaySinh = "NotOK" Then
            MsgBox " Ngay sinh benh nhan khong hop le", vbCritical
            Exit Sub
        End If
        '------------------------
        TenTinh = Trim(txtTinh.Text)
        TenHuyen = Trim(txtHuyen.Text)
        TenXa = Trim(txtXa.Text)
        SoNha = Trim(txtSoNha.Text)
        If SoNha = "" Then SoNha = "Chua co"
        If TenTinh = "" Then
            MsgBox "Ban chua chon tinh ma benh nhan song", vbInformation
            Exit Sub
        Else 'TenTinh<>""
            If TenHuyen = "" Then
                MsgBox "Ban chua chon ten huyen ma benh nhan song", vbInformation
                Exit Sub
            Else  'TenHuyen<>""
                If TenXa = "" Then
                    MsgBox "Ban chua chon ten xa", vbInformation
                    Exit Sub
                End If
            End If
        End If
        '------------------------------
        Tes = DE.Sp_LayMaTinh(TenTinh, MaTinh)
        Tes = DE.Sp_LayMaHuyen(TenHuyen, MaTinh, MaHuyen)
        Tes = DE.sp_LayMaXa(TenXa, MaHuyen, MaXa)
        ' End xac dinh ma tinh
        GioiTinh = OpNam
        '--------------------------
        Msg = MsgBox("Ban co chac chan sua benh nhan nay khong", vbQuestion + vbYesNo)
        If Msg = vbYes Then
            DE.sp_SuaBenhNhan MaBenhNhan, HoBenhNhan, TenBenhNhan, _
                        Format(NgaySinh, "dd/mm/yyyy"), GioiTinh, _
                        SoNha, MaXa
            disPlayListView
        End If
        '----------------------
    End If ' CoLuu=Moi
End Sub

Private Sub cmdMoi_Click()
    SetNull
    txtHoTenBenhNhan.Enabled = True
    txtMaBenhNhan.Enabled = True
    marNgaySinhBenhNhan.Enabled = True
    txtTinh.Enabled = True
    txtHuyen.Enabled = True
    txtXa.Enabled = True
    txtSoNha.Enabled = True
    opKhongCoBaoHiem = True
    opKhongCoBenhAn = True
    '------------------------------------------
    frmThemXemBaoHiemYTe.clBaoHiem.SetNull
    frmThemXemBenhAn.clBenhAn.SetNull
    '--------------------------------------------------------
    'If opCoBaoHiem = True Then
        'cmdThemMoiBaoHiem.Enabled = True
    'End If
    cmdXemBaoHiem.Enabled = False
    '------------------------------------
    cmdLuu.Enabled = True
    cmdChiTietBenhAn.Enabled = False
    'cmdLapBenhAn.Enabled = True
    CoLuu = "Moi"
End Sub

Private Sub cmdSua_Click()
    txtMaBenhNhan.Enabled = False
    txtHoTenBenhNhan.Enabled = True
    marNgaySinhBenhNhan.Enabled = True
    txtTinh.Enabled = True
    txtXa.Enabled = True
    txtHuyen.Enabled = True
    txtSoNha.Enabled = True
    cmdLuu.Enabled = True
End Sub

Private Sub cmdThemMoiBaoHiem_Click()
    Dim MaBenhNhan$, HoTen$, NgaySinh$, GioiTinh As Boolean
    Dim SoThe$, NgayBatDau$, NgayKetThuc$
    Dim PhanTram As Currency, MaCoQuan$
    MaBenhNhan = txtMaBenhNhan.Text
    HoTen = txtHoTenBenhNhan.Text
    NgaySinh = marNgaySinhBenhNhan.Text
    GioiTinh = OpNam
    clBenhNhan.LayThongTinTuDanhSachBenhNhan MaBenhNhan, _
                    HoTen, NgaySinh, GioiTinh
    frmThemXemBaoHiemYTe.CoMoi = "Moi"
    frmThemXemBaoHiemYTe.Show 1
    frmThemXemBaoHiemYTe.clBaoHiem.TTBaoHiemRa SoThe, _
                NgayBatDau, NgayKetThuc, PhanTram, MaCoQuan
    If SoThe = "" Then
        opCoBaoHiem = False
        opKhongCoBaoHiem = True
    End If
    'If frmThemXemBaoHiemYTe.clBaoHiem.TTBaoHiemRa(SoTheBaoHiem, _
                                NgayBatDau, NgayKetThuc, PhanTram) Then
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXemBaoHiem_Click()
    Dim MaBenhNhan$, HoTen$, NgaySinh$, GioiTinh As Boolean
    '---------------------------------------
    MaBenhNhan = Trim(txtMaBenhNhan.Text)
    HoTen = Trim(txtHoTenBenhNhan.Text)
    NgaySinh = marNgaySinhBenhNhan.Text
    GioiTinh = OpNam
    clBenhNhan.LayThongTinTuDanhSachBenhNhan MaBenhNhan, _
                                        HoTen, NgaySinh, GioiTinh
    frmThemXemBaoHiemYTe.CoMoi = "Xem"
    frmThemXemBaoHiemYTe.Show 1
End Sub

Private Sub cmdXoa_Click()
    Dim MaBenhNhan$, Msg As Long
    MaBenhNhan = Trim(txtMaBenhNhan)
    Msg = MsgBox("Ban co chac chan xoa benh nhan nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_XoaBenhNhan MaBenhNhan
        disPlayListView
        SetNull
    End If
End Sub

Private Sub Form_Load()
    cbTinh.Visible = False
    cbHuyen.Visible = False
    cbXa.Visible = False
    txtTinh.Enabled = False
    txtHuyen.Enabled = False
    txtXa.Enabled = False
    txtSoNha.Enabled = False
    txtMaBenhNhan.Enabled = False
    txtHoTenBenhNhan.Enabled = False
    marNgaySinhBenhNhan.Enabled = False
    cmdLuu.Enabled = False
    cmdLapBenhAn.Enabled = False
    cmdChiTietBenhAn.Enabled = False
    cmdThemMoiBaoHiem.Enabled = False
    cmdXemBaoHiem.Enabled = False
    '------------------------------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    '--------------------------------
    disPlayListView
    DisPlaycbTinh
End Sub

Private Sub disPlayListView()
    Dim Item As listItem
    Dim rs As ADODB.Recordset
    Dim SQL$
    lstBenhNhan.ListItems.Clear
    SQL = "Select * From vwBenhNhan " 'Order by MaBenhNhan"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set Item = lstBenhNhan.ListItems.Add(, , Trim(rs!MaBenhNhan))
                Item.SubItems(1) = Trim(rs!HoBenhNhan) & " " & Trim(rs!TenBenhNhan)
                Item.SubItems(2) = rs!NgaySinhBenhNhan
                Item.SubItems(3) = tfGT(rs!GioiTinhBenhNhan)
                Item.SubItems(4) = Trim(rs!SoNhaBenhNhan)
                Item.SubItems(5) = Trim(rs!TenXa)
                Item.SubItems(6) = Trim(rs!TenHuyen)
                Item.SubItems(7) = Trim(rs!TenTinh)
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub lstBenhNhan_ItemClick(ByVal Item As MSComctlLib.listItem)
    Dim MaBenhNhan$, SQLBaoHiem$, SQLBenhAn$
    Dim rsBaoHiem As ADODB.Recordset
    Dim rsBenhAn As ADODB.Recordset
    '---------------------------------------------------
    txtMaBenhNhan.Enabled = False
    txtMaBenhNhan.Text = Item.Text
    MaBenhNhan = Trim(txtMaBenhNhan)
    txtHoTenBenhNhan.Text = Item.SubItems(1)
    marNgaySinhBenhNhan.Text = Item.SubItems(2)
    OpNam = strGT(Item.SubItems(3))
    OpNu = Not OpNam
    txtSoNha.Text = Item.SubItems(4)
    txtXa.Text = Item.SubItems(5)
    txtHuyen.Text = Item.SubItems(6)
    txtTinh.Text = Item.SubItems(7)
    '----------------------------------------
    cmdLapBenhAn.Enabled = False
    cmdThemMoiBaoHiem.Enabled = False
    SQLBaoHiem = "Select SoTheBHYT From tblBaoHiemYTe Where MaBenhNhan = " & _
                                    MaBenhNhan
    Set rsBaoHiem = cn.Execute(SQLBaoHiem)
    If rsBaoHiem.EOF = False Then
        opCoBaoHiem = True
        opKhongCoBaoHiem = Not opCoBaoHiem
        cmdXemBaoHiem.Enabled = True
    Else
        opCoBaoHiem = False
        opKhongCoBaoHiem = Not opCoBaoHiem
        cmdXemBaoHiem.Enabled = False
    End If
    '--------------------------------
    SQLBenhAn = "Select MaBenhAn From tblBenhAn Where MaBenhNhan=" & _
                MaBenhNhan
    Set rsBenhAn = cn.Execute(SQLBenhAn)
    If rsBenhAn.EOF = False Then
        opCoBenhAn = True
        opKhongCoBenhAn = False
        cmdChiTietBenhAn.Enabled = True
    Else
        opCoBenhAn = False
        opKhongCoBenhAn = True
        cmdChiTietBenhAn.Enabled = False
    End If
    If CoLuu = "Moi" Then CoLuu = ""
End Sub

Private Sub SetNull()
    txtMaBenhNhan.Text = ""
    txtHoTenBenhNhan.Text = ""
    marNgaySinhBenhNhan.Text = "__/__/____"
    '----- Dia Chi --------------------
    txtTinh.Text = ""
    txtHuyen.Text = ""
    txtXa.Text = ""
    txtSoNha.Text = ""
End Sub

Private Sub DisPlaycbTinh()
    Dim rs As ADODB.Recordset
    Dim SQL$
    SQL = "Select * From tblTinh Order By maTinh"
    cbTinh.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
             cbTinh.AddItem Trim(rs.Fields("TenTinh"))
             rs.MoveNext
        Loop
    End If
End Sub

Private Sub disPlayCbHuyen()
    Dim MaTinh$, TenTinh$, SQL$
    Dim Tes As Long
    Dim rs As ADODB.Recordset
    TenTinh = Trim(txtTinh.Text)
    cbHuyen.Clear
    Tes = DE.Sp_LayMaTinh(TenTinh, MaTinh)
    If MaTinh <> "0" Then
        SQL = "Select TenHuyen  From tblHuyen Where tblHuyen.matinh=" & MaTinh
        Set rs = cn.Execute(SQL)
        If rs.EOF = False Then
            Do While rs.EOF = False
                cbHuyen.AddItem rs.Fields("TenHuyen")
                rs.MoveNext
            Loop
        End If
    End If
End Sub
Private Sub disPlaycbXa()
    Dim MaHuyen$, TenHuyen$, SQL$
    Dim Tes As Long, MaTinh$, TenTinh$
    Dim rs As ADODB.Recordset
    cbXa.Clear
    TenTinh = Trim(txtTinh)
    TenHuyen = Trim(txtHuyen.Text)
    Tes = DE.Sp_LayMaTinh(TenTinh, MaTinh)
    Tes = DE.Sp_LayMaHuyen(TenHuyen, MaTinh, MaHuyen)
    If MaHuyen <> "0" Then
        SQL = "Select TenXa From tblXa Where tblXa.MaHuyen=" & MaHuyen
        Set rs = cn.Execute(SQL)
        If rs.EOF = False Then
            Do While rs.EOF = False
                cbXa.AddItem rs.Fields("TenXa")
                rs.MoveNext
            Loop
        End If
    End If
End Sub

Private Sub opCoBaoHiem_Click()
    If CoLuu = "Moi" Then
        cmdThemMoiBaoHiem.Enabled = opCoBaoHiem
    End If
End Sub

Private Sub opCoBenhAn_Click()
    If CoLuu = "Moi" Then
        cmdLapBenhAn.Enabled = opCoBenhAn
    End If
End Sub

Private Sub opKhongCoBaoHiem_Click()
    If CoLuu = "Moi" Then
        cmdThemMoiBaoHiem.Enabled = Not opKhongCoBaoHiem
    End If
End Sub

Private Sub opKhongCoBenhAn_Click()
    If CoLuu = "Moi" Then
        cmdLapBenhAn.Enabled = Not opKhongCoBenhAn
    End If
End Sub

Private Sub txtHoTenBenhNhan_KeyPress(KeyAscii As Integer)
NhapTen KeyAscii, False
End Sub

Private Sub txtHuyen_Click()
    txtHuyen.Visible = False
    cbHuyen.Visible = True
End Sub

Private Sub txtMaBenhNhan_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtTinh_Click()
    cbTinh.Visible = True
    txtTinh.Visible = False
End Sub

Private Sub txtXa_Click()
    cbXa.Visible = True
    txtXa.Visible = False
    txtXa.Text = ""
End Sub
