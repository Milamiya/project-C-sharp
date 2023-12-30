VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmHoSoNHanVien 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Ho so nhan vien"
   ClientHeight    =   7020
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   11850
   Icon            =   "HoSoNHanVien.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7020
   ScaleWidth      =   11850
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame3 
      Caption         =   "Coâng taùc"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3375
      Left            =   7320
      TabIndex        =   16
      Top             =   3480
      Width           =   4455
      Begin VB.ComboBox cbChucVu 
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
         Left            =   1560
         TabIndex        =   36
         Top             =   2640
         Width           =   2775
      End
      Begin VB.ComboBox cbChuyenMon 
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
         Left            =   1560
         TabIndex        =   35
         Top             =   1680
         Width           =   2775
      End
      Begin VB.ComboBox cbDonVi 
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
         Left            =   1560
         TabIndex        =   34
         Top             =   600
         Width           =   2775
      End
      Begin VB.TextBox txtChucVu 
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
         Left            =   1560
         TabIndex        =   33
         Top             =   2640
         Width           =   2775
      End
      Begin VB.TextBox txtChuyenMon 
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
         Left            =   1560
         TabIndex        =   32
         Top             =   1680
         Width           =   2775
      End
      Begin VB.TextBox txtDonVi 
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
         Left            =   1560
         TabIndex        =   31
         Top             =   600
         Width           =   2775
      End
      Begin VB.Label Label12 
         Caption         =   "Chöùc vuï"
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
         TabIndex        =   30
         Top             =   2640
         Width           =   1095
      End
      Begin VB.Label Label11 
         Caption         =   "Chuyeân moân"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   120
         TabIndex        =   29
         Top             =   1680
         Width           =   1335
      End
      Begin VB.Label Label10 
         Caption         =   "Ñôn vò"
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
         TabIndex        =   28
         Top             =   600
         Width           =   1215
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Ñòa chæ nhaân vieân"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3255
      Left            =   7320
      TabIndex        =   15
      Top             =   120
      Width           =   4455
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
         Left            =   1440
         TabIndex        =   27
         Top             =   1800
         Width           =   2895
      End
      Begin VB.ComboBox cbhuyen 
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
         Left            =   1440
         TabIndex        =   26
         Top             =   1200
         Width           =   2895
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
         Left            =   1440
         TabIndex        =   25
         Top             =   600
         Width           =   2895
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
         Left            =   1440
         MaxLength       =   10
         TabIndex        =   24
         Top             =   2400
         Width           =   2895
      End
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
         Height          =   420
         Left            =   1440
         TabIndex        =   23
         Top             =   1800
         Width           =   2895
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
         Height          =   420
         Left            =   1440
         TabIndex        =   22
         Top             =   1200
         Width           =   2895
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
         Left            =   1440
         TabIndex        =   18
         Top             =   600
         Width           =   2895
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
         Left            =   360
         TabIndex        =   21
         Top             =   2400
         Width           =   975
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
         Left            =   360
         TabIndex        =   20
         Top             =   1920
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
         Left            =   360
         TabIndex        =   19
         Top             =   1320
         Width           =   1095
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
         Left            =   360
         TabIndex        =   17
         Top             =   600
         Width           =   1095
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Caù nhaân"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   6735
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   7095
      Begin VB.Frame FrGoiTinh 
         Caption         =   "Giôùi tính"
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
         TabIndex        =   37
         Top             =   2520
         Width           =   6855
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
            Left            =   1920
            TabIndex        =   39
            Top             =   360
            Width           =   1695
         End
         Begin VB.OptionButton opNam 
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
            TabIndex        =   38
            Top             =   360
            Width           =   1335
         End
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
         Left            =   4560
         TabIndex        =   14
         Top             =   6120
         Width           =   1095
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
         Left            =   6000
         TabIndex        =   13
         Top             =   6120
         Width           =   975
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
         Left            =   3120
         TabIndex        =   12
         Top             =   6120
         Width           =   1095
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
         Left            =   1560
         TabIndex        =   11
         Top             =   6120
         Width           =   1095
      End
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
         Left            =   120
         TabIndex        =   10
         ToolTipText     =   "Them du lieu"
         Top             =   6120
         Width           =   1095
      End
      Begin MSComctlLib.ListView lstNhanVien 
         Height          =   2415
         Left            =   120
         TabIndex        =   9
         Top             =   3600
         Width           =   6855
         _ExtentX        =   12091
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
         NumItems        =   12
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "Maõ "
            Object.Width           =   1941
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Hoï teân"
            Object.Width           =   5098
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   2
            Text            =   "Ngaøy sinh"
            Object.Width           =   2540
         EndProperty
         BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   3
            Text            =   "Ñieän thoaïi"
            Object.Width           =   2540
         EndProperty
         BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   4
            Text            =   "Tænh"
            Object.Width           =   0
         EndProperty
         BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   5
            Text            =   "Huyeän"
            Object.Width           =   0
         EndProperty
         BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   6
            Text            =   "Xaõ"
            Object.Width           =   0
         EndProperty
         BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   7
            Text            =   "Dôn vò"
            Object.Width           =   0
         EndProperty
         BeginProperty ColumnHeader(9) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   8
            Text            =   "Chuyeân moân"
            Object.Width           =   0
         EndProperty
         BeginProperty ColumnHeader(10) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   9
            Text            =   "Chöùc vuï"
            Object.Width           =   0
         EndProperty
         BeginProperty ColumnHeader(11) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   10
            Text            =   "Gioi Tinh"
            Object.Width           =   0
         EndProperty
         BeginProperty ColumnHeader(12) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   11
            Object.Width           =   0
         EndProperty
      End
      Begin VB.TextBox txtDienThoai 
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
         Left            =   2280
         MaxLength       =   10
         TabIndex        =   8
         Top             =   1920
         Width           =   3375
      End
      Begin MSMask.MaskEdBox MarNgaySinh 
         Height          =   375
         Left            =   2280
         TabIndex        =   7
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
      Begin VB.TextBox txtHoTenNhanVien 
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
         Left            =   2280
         TabIndex        =   6
         Top             =   840
         Width           =   3375
      End
      Begin VB.TextBox txtMaNhanVien 
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
         Left            =   2280
         MaxLength       =   5
         TabIndex        =   5
         Top             =   240
         Width           =   1455
      End
      Begin VB.Label Label4 
         Caption         =   "Ñieän thoaïi nhaân vieân"
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
         TabIndex        =   4
         Top             =   1920
         Width           =   2055
      End
      Begin VB.Label Label3 
         Caption         =   "Ngaøy sinh nhaân vieân"
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
         Caption         =   "Hoï teân nhaân vieân"
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
         Top             =   840
         Width           =   1695
      End
      Begin VB.Label Label1 
         Caption         =   "Maõ Nhaân vieân"
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
         Top             =   360
         Width           =   1815
      End
   End
End
Attribute VB_Name = "frmHoSoNHanVien"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim CoLuu As String

Private Sub cbChucVu_Click()
    txtChucVu.Enabled = False
    txtChucVu.Visible = True
    cbChucVu.Visible = False
    txtChucVu.Text = cbChucVu.Text
    txtChucVu.Enabled = True
End Sub

Private Sub cbChuyenMon_Click()
    txtChuyenMon.Text = cbChuyenMon.Text
    txtChuyenMon.Visible = True
    cbChuyenMon.Visible = False
End Sub

Private Sub cbDonVi_Click()
    txtDonVi.Visible = True
    txtDonVi.Text = cbDonVi.Text
    cbDonVi.Visible = False
End Sub

Private Sub cbhuyen_Click()
    cbHuyen.Visible = False
    txtHuyen.Text = cbHuyen.Text
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

Private Sub cmdLuu_Click()
    Dim MaNhanVien$, HoTenNhanVien$, SoNha$
    Dim NgaySinh As Date, GioiTinh As Boolean
    Dim DienThoai$, TenDonVi$, MaDonVi$
    Dim MaChuyenMon$, TenChuyenMon$, NgayTam$
    Dim MaChucVu$, TenChucVu$, MaTinh$, TenTinh$
    Dim MaXa$, TenXa$, MaHuyen$, TenHuyen$
    Dim i%, Tes As Long, SQL$, Msg%
    '=================================
    MaNhanVien = Trim(txtMaNhanVien.Text)
    HoTenNhanVien = SuLiChuoi(txtHoTenNhanVien.Text)
    NgayTam = SuLiNgaySinh(marNgaySinh.Text, "NhanVien")
    GioiTinh = OpNam
    DienThoai = Trim(txtDienThoai.Text)
    TenDonVi = SuLiChuoi(txtDonVi.Text)
    SoNha = Trim(txtSoNha.Text)
    TenXa = SuLiChuoi(txtXa.Text)
    TenTinh = SuLiChuoi(txtTinh.Text)
    TenHuyen = SuLiChuoi(txtHuyen.Text)
    TenChucVu = SuLiChuoi(txtChucVu.Text)
    TenChuyenMon = SuLiChuoi(txtChuyenMon.Text)
    '--- kiem tra ma nhan vien
    i = 1
    If Len(MaNhanVien) > 0 Then
        If KiemTraMa(MaNhanVien) = False Then
            MsgBox "Ma khong hop le (Ma nhan vien khong co khoang trang)"
            Exit Sub
        Else
            SQL = "Select MaNhanVien From tblNhanVien Where MaNhanVien=" & MaNhanVien
            If CoLuu = "Moi" Then
                If Kt_Text(SQL) = False Then
                    MsgBox "Ma nha vien nay da co trong co so du lieu", vbCritical
                    Exit Sub
                End If
            End If
        End If
    Else
        MsgBox "Ban chua nhap ma nhan vien", vbInformation
        Exit Sub
    End If
    '--------- kiemta ngay thang nhap vao
    If NgayTam = "NotOK" Then
        MsgBox "Ban vui long kiem tra lai ngay thang, ngay thang khong hop le" & Chr(13) & Chr(10) & _
                        "tuoi nhan vien >17 va < 65 ", vbCritical
       Exit Sub
    End If
    '--------- kiemtra so dien thoai
    If KiemTraMa(DienThoai) = False Then
        If DienThoai <> "Chua co" Then
            MsgBox "So dien thoai khong hop le, khong co khoang trang", vbCritical
            Exit Sub
        End If
    End If
    If DienThoai = "" Then DienThoai = "Chua co"
    If OpNam = False Then
        If OpNu = False Then
            MsgBox "ban chua chon gioi thinh ngan vien", vbInformation
        End If
    End If
    '------------ Lay ma cho o chua nhan vien ---------------------------
    If TenTinh = "" Then
        MsgBox "Ban chua chon ten tinh", vbInformation
        Exit Sub
    End If
    If TenHuyen = "" Then
        MsgBox "Ban chua chon ten huyen", vbInformation
        Exit Sub
    End If
    If TenXa = "" Then
        MsgBox "Ban chua nhap ten xa", vbInformation
        Exit Sub
    End If
    Tes = DE.Sp_LayMaTinh(TenTinh, MaTinh)
    Tes = DE.Sp_LayMaHuyen(TenHuyen, MaTinh, MaHuyen)
    Tes = DE.sp_LayMaXa(TenXa, MaHuyen, MaXa)
    If SoNha = "" Then SoNha = "Chua co"
    '----------- Lay ma viec cong tac cua nhan vien
    If TenChucVu = "" Then
        MsgBox "Ban chua nhap ten chuc vu"
        Exit Sub
    End If
    If TenDonVi = "" Then
        MsgBox "Ban chua nhap ten don vi", vbInformation
        Exit Sub
    End If
    If TenChuyenMon = "" Then
        MsgBox "Ban chua nhap ten chuyen mon", vbInformation
        Exit Sub
    End If
    Tes = DE.sp_LayMaChucVu(TenChucVu, MaChucVu)
    Tes = DE.sp_LayMaChuyenMon(TenChuyenMon, MaChuyenMon)
    Tes = DE.sp_LayMaDonVi(TenDonVi, MaDonVi)
    '----------- Nhap them nhan vien -----------------------------
    NgaySinh = Format(NgayTam, "dd / mm / yyyy") ' Ngay sinh nhan vien
    If CoLuu = "Moi" Then
        
        If HoTenNhanVien <> "" Then
            Tes = DE.sp_NhapNhanVien(MaNhanVien, HoTenNhanVien, _
                                            NgaySinh, GioiTinh, SoNha, DienThoai, _
                                            MaXa, MaDonVi, MaChuyenMon, _
                                            MaChucVu)
            disPlayListView
            SetNull
        Else ' else kiem tra ten nhan vien
            MsgBox "Ban chu nhap ten nhan vien", vbInformation
        End If 'if kiem tra ten nhan vien
    Else
        If CoLuu = "Sua" Then
            Msg = MsgBox("Ban co chac chan sua nhan vien nay khong", vbYesNo + vbQuestion)
            If Msg = vbYes Then
                Tes = DE.sp_SuaNhanVien(MaNhanVien, HoTenNhanVien, _
                            NgaySinh, GioiTinh, SoNha, DienThoai, _
                            MaXa, MaDonVi, MaChuyenMon, MaChucVu)
                disPlayListView
            End If
        End If
    End If 'if kiem tra co luu
End Sub

Private Sub cmdMoi_Click()
    txtChucVu.Enabled = True
    txtTinh.Enabled = True
    txtDonVi.Enabled = True
    txtChuyenMon.Enabled = True
    txtHuyen.Enabled = True
    txtXa.Enabled = True
    txtSoNha.Enabled = True
    txtMaNhanVien.Enabled = True
    txtHoTenNhanVien.Enabled = True
    marNgaySinh.Enabled = True
    txtDienThoai.Enabled = True
    cmdLuu.Enabled = True
    OpNam.Enabled = True
    OpNu.Enabled = True
    '=======================
    DisPlaycbTinh
    disPlaycbChucVu
    disPlayDonVi
    disPlaycbChuyenMon
    SetNull
    CoLuu = "Moi"
End Sub

Private Sub cmdSua_Click()
    CoLuu = "Sua"
    txtMaNhanVien.Enabled = False
    txtHoTenNhanVien.Enabled = True
    marNgaySinh.Enabled = True
    txtSoNha.Enabled = True
    txtDienThoai.Enabled = True
    txtXa.Enabled = True
    txtTinh.Enabled = True
    txtHuyen.Enabled = True
    txtChuyenMon.Enabled = True
    txtChucVu.Enabled = True
    txtDonVi.Enabled = True
    cmdLuu.Enabled = True
    OpNam.Enabled = True
    OpNu.Enabled = True
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    Dim Msg%, MaNhanVien$
    MaNhanVien = Trim(txtMaNhanVien.Text)
    Msg = MsgBox("Ban co chac chan xoa nhan vien nay khong", vbYesNo + vbQuestion)
    If Msg = vbYes Then
        DE.sp_XoaNhanvien (MaNhanVien)
        disPlayListView
    End If
End Sub

Private Sub Form_Load()
    cbTinh.Visible = False
    cbHuyen.Visible = False
    cbXa.Visible = False
    cbDonVi.Visible = False
    cbChuyenMon.Visible = False
    cbChucVu.Visible = False
    '-------------------------------
    txtMaNhanVien.Enabled = False
    txtHoTenNhanVien.Enabled = False
    txtSoNha.Enabled = False
    marNgaySinh.Enabled = False
    txtDienThoai.Enabled = False
    txtTinh.Enabled = False
    txtHuyen.Enabled = False
    txtXa.Enabled = False
    txtDonVi.Enabled = False
    txtChuyenMon.Enabled = False
    txtChucVu.Enabled = False
    cmdLuu.Enabled = False
    '-----------------------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    disPlayListView
End Sub

Private Sub disPlayListView()
    Dim mItem As listItem
    Dim rs As New ADODB.Recordset
    Dim Str$, TenNhanVien$
    lstNhanVien.ListItems.Clear
    Str = "select * from vwHoSoNhanVien order by MaNhanVien asc"
    Set rs = cn.Execute(Str) 'Thuc Hien Mot Lenh SQL duoc chi ra boi str
    If rs.EOF = False Then
         Do While Not rs.EOF
               Set mItem = lstNhanVien.ListItems.Add(, , rs!MaNhanVien)
               mItem.SubItems(1) = Trim(rs!HoTenNhanVien)
               mItem.SubItems(2) = rs!NgaySinhNhanVien
               mItem.SubItems(3) = rs!DienThoaiNhanVien
               mItem.SubItems(4) = rs!SoNhaNhanVien
               mItem.SubItems(5) = rs!TenHuyen
               mItem.SubItems(6) = rs!TenTinh
               mItem.SubItems(7) = rs!TenXa
               mItem.SubItems(9) = rs!TenChucVu
               mItem.SubItems(8) = rs!TenChuyenMon
               mItem.SubItems(10) = rs!TenDonVi
               mItem.SubItems(11) = rs!GioiTinhNhanVien
               rs.MoveNext
        Loop 'Wend
    End If
End Sub

Private Sub lstNhanVien_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaNhanVien.Text = Item.Text
    txtHoTenNhanVien.Text = Item.SubItems(1)
    marNgaySinh.Text = Item.SubItems(2)
    txtDienThoai.Text = Item.SubItems(3)
    txtSoNha.Text = Item.SubItems(4)
    txtHuyen.Text = Item.SubItems(5)
    txtTinh.Text = Item.SubItems(6)
    txtXa.Text = Item.SubItems(7)
    txtChucVu.Text = Item.SubItems(9)
    txtChuyenMon.Text = Item.SubItems(8)
    txtDonVi.Text = Item.SubItems(10)
    txtMaNhanVien.Enabled = False
    If Item.SubItems(11) = True Then
        OpNam.Value = True
    Else
        OpNu.Value = True
    End If
End Sub

Private Sub txtChucVu_Click()
    cbChucVu.Visible = True
    cbChucVu.Enabled = True
    txtChucVu.Visible = False
    txtChucVu.Text = ""
End Sub
Private Sub DisPlaycbTinh()
    Dim SQL$
    Dim rs As ADODB.Recordset
    SQL = "Select TenTinh From tblTinh"
    cbTinh.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            cbTinh.AddItem rs.Fields("TenTinh")
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub txtChuyenMon_Click()
    txtChuyenMon.Visible = False
    cbChuyenMon.Visible = True
    txtChuyenMon.Text = ""
End Sub



Private Sub txtDienThoai_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtDonVi_Click()
    txtDonVi.Visible = False
    cbDonVi.Visible = True
    txtDonVi.Text = ""
End Sub

Private Sub txtHuyen_Click()
    txtHuyen.Visible = False
    cbHuyen.Visible = True
    txtHuyen.Text = ""
End Sub

Private Sub txtMaNhanVien_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtTinh_Click()
    cbTinh.Visible = True
    cbTinh.Enabled = True
    txtTinh.Visible = True
    txtTinh.Text = ""
End Sub
Private Sub disPlaycbChucVu()
    Dim SQL$
    Dim rs As ADODB.Recordset
    SQL = "Select TenChucVu From tblChucVu"
    cbChucVu.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            cbChucVu.AddItem rs.Fields("TenChucVu")
            rs.MoveNext
        Loop
    End If
End Sub
Private Sub disPlayDonVi()
    Dim SQL$
    Dim rs As ADODB.Recordset
    SQL = "Select TenDonVi From tblDonVi"
    cbDonVi.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            cbDonVi.AddItem rs.Fields("TenDonVi")
            rs.MoveNext
        Loop
    End If
End Sub
Private Sub disPlaycbChuyenMon()
    Dim SQL$
    Dim rs As ADODB.Recordset
    SQL = "Select TenChuyenMon From tblChuyenMon"
    cbChuyenMon.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            cbChuyenMon.AddItem rs.Fields("TenChuyenMon")
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

Private Sub txtXa_Click()
    cbXa.Visible = True
    txtXa.Visible = False
    txtXa.Text = ""
End Sub
Private Sub SetNull()
    txtChucVu.Text = ""
    txtTinh.Text = ""
    txtDonVi.Text = ""
    txtChuyenMon.Text = ""
    txtHuyen.Text = ""
    txtXa.Text = ""
    txtSoNha.Text = ""
    txtMaNhanVien.Text = ""
    txtHoTenNhanVien.Text = ""
    marNgaySinh.Text = "__/__/____"
    txtDienThoai.Text = ""
End Sub
