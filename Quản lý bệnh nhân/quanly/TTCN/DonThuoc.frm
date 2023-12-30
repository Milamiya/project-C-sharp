VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{C932BA88-4374-101B-A56C-00AA003668DC}#1.1#0"; "MSMASK32.OCX"
Begin VB.Form frmDonThuoc 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Don Thuoc"
   ClientHeight    =   7500
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   11355
   Icon            =   "DonThuoc.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7500
   ScaleWidth      =   11355
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame3 
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
      TabIndex        =   21
      Top             =   6360
      Width           =   11055
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
         Left            =   7080
         TabIndex        =   26
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
         Left            =   9360
         TabIndex        =   25
         Top             =   360
         Width           =   1215
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
         Left            =   4800
         TabIndex        =   24
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
         Left            =   2640
         TabIndex        =   23
         Top             =   360
         Width           =   1335
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
         Left            =   240
         TabIndex        =   22
         ToolTipText     =   "Them du lieu"
         Top             =   360
         Width           =   1335
      End
   End
   Begin MSComctlLib.ListView lstDonThuoc 
      Height          =   1815
      Left            =   120
      TabIndex        =   3
      Top             =   4560
      Width           =   11055
      _ExtentX        =   19500
      _ExtentY        =   3201
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
         Text            =   "Hoï teân beänh nhaân"
         Object.Width           =   4657
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Ngaøy keâ ñôn"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Teân beänh"
         Object.Width           =   4128
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Chi phí khaùm beänh"
         Object.Width           =   3600
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Hoï teân nhaân vieân"
         Object.Width           =   4657
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "MaDonThuoc"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   6
         Text            =   "MaBenhNhan"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   7
         Text            =   "MaViTri"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(9) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   8
         Text            =   "TenViTri"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(10) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   9
         Text            =   "MaNhanVien"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(11) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   10
         Text            =   "MABenh"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(12) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   11
         Text            =   "NoiDunhKhamBenh"
         Object.Width           =   0
      EndProperty
   End
   Begin VB.Frame Frame2 
      Caption         =   "Thuoác"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4335
      Left            =   6000
      TabIndex        =   1
      Top             =   120
      Width           =   5175
      Begin VB.TextBox txtSoLuong 
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
         Left            =   1320
         TabIndex        =   29
         Top             =   720
         Width           =   3615
      End
      Begin VB.CommandButton cmdBoBot 
         Caption         =   "Boû bôt"
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
         Left            =   3000
         TabIndex        =   20
         Top             =   3720
         Width           =   1575
      End
      Begin VB.CommandButton cmdThemThuoc 
         Caption         =   "Theâm thuoác"
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
         Left            =   720
         TabIndex        =   19
         Top             =   3720
         Width           =   1455
      End
      Begin VB.TextBox txtLieuDung 
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
         Left            =   1320
         TabIndex        =   17
         Top             =   1200
         Width           =   3615
      End
      Begin VB.TextBox txtTenThuoc 
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
         Left            =   1320
         TabIndex        =   15
         Top             =   240
         Width           =   3615
      End
      Begin MSComctlLib.ListView lstDungThuoc 
         Height          =   1935
         Left            =   120
         TabIndex        =   2
         Top             =   1680
         Width           =   4935
         _ExtentX        =   8705
         _ExtentY        =   3413
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
         NumItems        =   5
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "Teân thuoác"
            Object.Width           =   4057
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "Soá löôïng"
            Object.Width           =   2364
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   2
            Text            =   "Lieàu duøng"
            Object.Width           =   2364
         EndProperty
         BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   3
            Text            =   "Ñôn giaù"
            Object.Width           =   2540
         EndProperty
         BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   4
            Text            =   "MaThuoc"
            Object.Width           =   0
         EndProperty
      End
      Begin VB.Label Label8 
         Caption         =   "Lieàu duøng"
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
         TabIndex        =   18
         Top             =   1200
         Width           =   1335
      End
      Begin VB.Label Label7 
         Caption         =   "Soá löôïng"
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
         TabIndex        =   16
         Top             =   720
         Width           =   1335
      End
      Begin VB.Label Label6 
         Caption         =   "Teân thuoác"
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
         TabIndex        =   14
         Top             =   240
         Width           =   1455
      End
   End
   Begin VB.Frame Frame1 
      Height          =   4335
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   5775
      Begin VB.TextBox txtNoiDungKhamBenh 
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
         TabIndex        =   32
         Top             =   3720
         Width           =   3135
      End
      Begin VB.TextBox txtNoiKhamBenh 
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
         TabIndex        =   30
         Top             =   3240
         Width           =   3135
      End
      Begin VB.TextBox txtMaDonThuoc 
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
         MaxLength       =   10
         TabIndex        =   27
         Top             =   360
         Width           =   3135
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
         Height          =   375
         Left            =   2280
         TabIndex        =   12
         Top             =   2760
         Width           =   3135
      End
      Begin VB.TextBox txtChiphi 
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
         TabIndex        =   10
         Top             =   2280
         Width           =   3135
      End
      Begin VB.TextBox txtTenBenh 
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
         TabIndex        =   8
         Top             =   1800
         Width           =   3135
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
         Left            =   2280
         TabIndex        =   6
         Top             =   1320
         Width           =   3135
      End
      Begin MSMask.MaskEdBox marNgayKeDon 
         Height          =   375
         Left            =   2280
         TabIndex        =   4
         Top             =   840
         Width           =   3135
         _ExtentX        =   5530
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
      Begin VB.Label Label11 
         Caption         =   "Noäi dung khaùm beänh"
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
         TabIndex        =   33
         Top             =   3720
         Width           =   2055
      End
      Begin VB.Label Label10 
         Caption         =   "Nôi khaùm beänh"
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
         TabIndex        =   31
         Top             =   3240
         Width           =   2055
      End
      Begin VB.Label Label9 
         Caption         =   "Maõ ñôn thuoác"
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
         Top             =   360
         Width           =   2055
      End
      Begin VB.Label Label5 
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
         TabIndex        =   13
         Top             =   2760
         Width           =   2055
      End
      Begin VB.Label Label4 
         Caption         =   "Chi phí khaùm beänh"
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
         TabIndex        =   11
         Top             =   2280
         Width           =   1935
      End
      Begin VB.Label Label3 
         Caption         =   "Teân beänh"
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
         TabIndex        =   9
         Top             =   1800
         Width           =   1695
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
         TabIndex        =   7
         Top             =   1320
         Width           =   1815
      End
      Begin VB.Label Label1 
         Caption         =   "Ngaøy keâ ñôn"
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
         TabIndex        =   5
         Top             =   840
         Width           =   1815
      End
   End
End
Attribute VB_Name = "frmDonThuoc"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim CoLuu$
Dim arrThuoc(1 To 20) As ChonThuoc
Dim MaDonThuoclst$, i As Long
Dim MaNhanVienlst$, MaBenhNhanLst$, MaBenhlst$, MaViTrilst$, MaThuoclst$, MaThuoc$

Private Sub cmdBoBot_Click()
    Dim dem As Long, TenThuoc$, SQL$, MaDonThuoc$
    Dim rs As ADODB.Recordset
    Dim them As Long, SQLCo$
    TenThuoc = Trim(txtTenThuoc.Text)
    MaDonThuoc = Trim(txtMaDonThuoc)
    SQL = "Select * From vwDungThuoc Where MaDonThuoc=" & MaDonThuoc
    If TenThuoc = "" Then
        MsgBox "Ban chua chon thuoc can bo"
    Else
        dem = 1
        Do While (arrThuoc(dem).TenThuoc <> TenThuoc) And (dem < i)
            dem = dem + 1
        Loop
        If dem < i Then
            For them = dem To i - 2
                arrThuoc(them) = arrThuoc(them + 1)
            Next them
                        arrThuoc(i - 1).MaThuoc = ""
            MaDonThuoc = Trim(txtMaDonThuoc.Text)
            If i > 1 Then i = i - 1
            disPlayDungThuoc (SQL)
        Else
            MaThuoc = Trim(MaThuoc)
            
            SQLCo = "Select * From tblDungThuoc Where MaDonThuoc = " & MaDonThuoc & _
                        " and MaThuoc=" & MaThuoc
            If Kt_Text(SQLCo) = False Then
                DE.sp_XoaDungThuoc MaDonThuoc, MaThuoc
                disPlayDungThuoc (SQL)
            End If
        End If
    End If
End Sub

Private Sub cmdLuu_Click()
    Dim MaNhanVien$, MaBenhNhan$, MaBenh$, MaViTri$, MaThuoc$
    Dim MaDonThuoc$, NoiDung$, ChiPhi As Currency
    Dim SoLuong%, LieuDung$, NgayKeDon As Date
    Dim SQL$, Msg%, HoTenBenhNhan$, NgaySinh As Date
    Dim TenBenh$, TenViTri$, TenNhanVien$, GioiTinh As Boolean
    Dim TenThuoc$, DonGia As Currency, NgayKD$, t As Long
    Dim NgaySinhBenhNhan$, Tes As Long
    '-------------------------------------------------------------
    '------  Lau ma
    If Trim(txtChiphi.Text) <> "" Then
        ChiPhi = Str(Trim(txtChiphi.Text))
    End If
    NoiDung = Trim(txtNoiDungKhamBenh.Text)
    If ChiPhi < 0 Then
        MsgBox "Chi phi khong duoc nho hon khong", vbCritical
        Exit Sub
    End If
    MaDonThuoc = Trim(txtMaDonThuoc.Text)
    NgayKD = marNgayKeDon.Text
    If SuLiNgay(NgayKD) = "NotOK" Then 'kiem tra ngay thang
        MsgBox "Ban vui long kiem tra lai ngay thang, ngay nay khong hop le", vbCritical
        Exit Sub
    End If 'kiem tra ngay thang
    NgayKeDon = Format(NgayKD, "dd/mm/yyyy")
    '-------------------------------------------------------
    frmDanhSachThuoc.clThuoc.TTThuocRa MaThuoc, TenThuoc, DonGia, SoLuong, LieuDung
    frmDanhSachBenh.clBenh.ThongTTRa MaBenh, TenBenh
    If CoLuu = "Moi" Then
        frmDanhSachBenhNhan.clThongTinBenhNhan.TraThongTinVeTuDanhSachBenhNhan _
                    MaBenhNhan, HoTenBenhNhan, NgaySinhBenhNhan, GioiTinh
        frmDanhSachNhanVien.clNhanVien.TraTTNhanVien MaNhanVien, TenNhanVien
        frmDanhSachViTriKhamBenh.clViTri.TraTTNoiDT MaViTri, TenViTri
        If Trim(MaBenhNhan) = "" Then
            MsgBox "Don thuoc cua ban chua co ten benh nhan", vbInformation
            Exit Sub
        End If
        If Trim(MaViTri) = "" Then
            MsgBox "Ban chua co noi kham benh", vbInformation
            Exit Sub
        End If
        If Trim(MaNhanVien) = "" Then
            MsgBox "Thieu ten nhan vien kham benh", vbInformation
            Exit Sub
        End If
        If Trim(MaBenh) = "" Then
            MsgBox "Don thuoc cua ban chua co benh", vbInformation
            Exit Sub
        End If
    End If
    If MaDonThuoc = "" Then
        MsgBox "Ban chua nhap ma don thuoc", vbInformation
        Exit Sub
    Else 'Else su li don thuoc
        SQL = "Select MaDonThuoc From tblDonThuoc Where MaDonThuoc=" & _
                        MaDonThuoc
        If (CoLuu = "Moi") And (Kt_Text(SQL) = False) Then 'Kiem tra ma don thuoc da co chua
            MsgBox "Ma Don Thuoc nay da co trong co so du lieu", vbCritical
            Exit Sub
        End If ' Ma da co
    End If 'End If DonThuoc=""
    If CoLuu = "Moi" Then
        DE.sp_NhapDonThuoc MaDonThuoc, MaNhanVien, MaBenhNhan, _
                    MaViTri, MaBenh, NgayKeDon
        DE.sp_NhapKhamBenh MaNhanVien, MaBenhNhan, MaViTri, _
                MaDonThuoc, MaBenh, NgayKeDon, NoiDung, ChiPhi
        t = 1
        Do While (Trim(arrThuoc(t).MaThuoc) <> "") And (t <= i)
            DE.sp_NhapDungThuoc MaDonThuoc, arrThuoc(t).MaThuoc, _
                            arrThuoc(t).SoLuong, arrThuoc(t).LieuDung
            t = t + 1
        Loop
        KhoiTaoMang 'set null lai mang
        i = 1 ' khoitao bo dem
        disPlaylistDonThuoc
        SQL = "Select * From vwDungThuoc Where MaDonThuoc=" & MaDonThuoc
        disPlayDungThuoc (SQL)
        SetNull
    Else 'Coluu=Sua
        If CoLuu = "Sua" Then
            Msg = MsgBox("Ban co chac chan sua don thuoc nay khong", vbYesNo + vbQuestion)
            If Msg = vbYes Then
                If Trim(MaBenh) = "" Then
                    DE.sp_SuaDonThuoc MaDonThuoclst, MaNhanVienlst, MaBenhNhanLst, _
                            Trim(MaBenhlst), NgayKeDon
                    DE.sp_SuaKhamBenh MaDonThuoc, MaBenhlst, NgayKeDon, _
                                        NoiDung, ChiPhi
                Else
                    DE.sp_SuaDonThuoc MaDonThuoclst, MaNhanVienlst, MaBenhNhanLst, _
                            Trim(MaBenhlst), NgayKeDon
                    DE.sp_SuaKhamBenh MaDonThuoc, MaBenh, NgayKeDon, NoiDung, ChiPhi
                End If
                t = 1
                Do While (Trim(arrThuoc(t).MaThuoc) <> "") And (t <= i)
                    DE.sp_NhapDungThuoc MaDonThuoc, arrThuoc(t).MaThuoc, _
                            arrThuoc(t).SoLuong, arrThuoc(t).LieuDung
                    t = t + 1
                Loop
                KhoiTaoMang 'Khoi tao lai mang
                i = 1 'Kho tao bo dem
                disPlaylistDonThuoc
                SQL = "Select * From vwDungThuoc Where MaDonThuoc=" & MaDonThuoc
                disPlayDungThuoc (SQL)
            End If 'Kiem tra cau tra loi
        End If
        SetNull
    End If 'Luu du lieu moi
End Sub

Private Sub cmdMoi_Click()
    txtMaDonThuoc.Enabled = True
    marNgayKeDon.Enabled = True
    txtHoTenBenhNhan.Enabled = True
    txtChiphi.Enabled = True
    txtHoTenNhanVien.Enabled = True
    txtChiphi.Enabled = True
    txtTenBenh.Enabled = True
    txtSoLuong.Enabled = False
    txtLieuDung.Enabled = False
    txtNoiKhamBenh.Enabled = True
    '---------------------------------------
    cmdThemThuoc.Enabled = True
    cmdBoBot.Enabled = True
    cmdLuu.Enabled = True
    SetNull
    CoLuu = "Moi"
    i = 1
    KhoiTaoMang
    lstDungThuoc.ListItems.Clear
End Sub

Private Sub cmdSua_Click()
    cmdLuu.Enabled = True
    cmdThemThuoc.Enabled = True
    cmdBoBot.Enabled = True
    marNgayKeDon.Enabled = True
    txtHoTenNhanVien.Enabled = False
    txtMaDonThuoc.Enabled = False
    txtChiphi.Enabled = True
    txtHoTenBenhNhan.Enabled = False
    txtHoTenNhanVien.Enabled = False
    txtNoiKhamBenh.Enabled = False
    txtTenBenh.Enabled = True
    KhoiTaoMang
    i = 1
    CoLuu = "Sua"
End Sub

Private Sub cmdThemThuoc_Click()
    Dim MaThuoc$, TenThuoc$, DonGia As Currency
    Dim SoLuong%, LieuDung$, SQL$, MaDonThuoc$
    Dim SQLThuoc$, Tam As Long, tam1 As Long, KT As Long
    Static Co As Boolean
    frmDanhSachThuoc.Show 1
    frmDanhSachThuoc.clThuoc.TTThuocRa MaThuoc, TenThuoc, DonGia, SoLuong, LieuDung
    MaDonThuoc = Trim(txtMaDonThuoc.Text)
    If Trim(MaThuoc) <> "" Then
        KT = 1
        Do While (arrThuoc(KT).MaThuoc <> MaThuoc) And (KT <= i)
            KT = KT + 1
        Loop
        If KT < i Then
            arrThuoc(KT).SoLuong = arrThuoc(KT).SoLuong + SoLuong
            SQL = "Select * From vwDungThuoc Where MaDonThuoc=" & MaDonThuoc
            disPlayDungThuoc (SQL)
            Exit Sub
        End If
        arrThuoc(i).MaThuoc = MaThuoc
        arrThuoc(i).SoLuong = SoLuong
        arrThuoc(i).DonGia = DonGia
        arrThuoc(i).LieuDung = LieuDung
        arrThuoc(i).TenThuoc = TenThuoc
        i = i + 1
    End If
     SQL = "Select * From vwDungThuoc Where MaDonThuoc=" & MaDonThuoc
    If Co = False Then
        If MaDonThuoc <> "" Then
            If CoLuu = "Moi" Then
                SQLThuoc = "Select MaDonThuoc From tblDonThuoc Where MaDonThuoc=" & _
                            MaDonThuoc
                If Kt_Text(SQLThuoc) = True Then
                    Co = True
                    txtMaDonThuoc.Enabled = False
                Else
                    Co = False
                    MsgBox "Ma don thuoc nay da co trong co so du lieu", vbInformation
                    i = i - 1
                    arrThuoc(i).MaThuoc = ""
                    Exit Sub
                End If
            Else 'Else coluu= moi
                If CoLuu = "Sua" Then
                    SQLThuoc = "Select MaDonThuoc From tblDonThuoc Where MaDonThuoc=" & _
                            MaDonThuoc
                    If Kt_Text(SQLThuoc) = False Then
                        SQL = "Select * From vwDungThuoc Where MaDonThuoc=" & MaDonThuoc
                        disPlayDungThuoc (SQL)
                    Else
                        MsgBox "Ban chua chon don thuoc can sua", vbInformation
                        i = i - 1
                        arrThuoc(i).MaThuoc = ""
                    End If
                End If 'End If Coluu= sua
            End If 'end coluu=moi
            SQL = "Select * From vwDungThuoc Where MaDonThuoc=" & MaDonThuoc
            disPlayDungThuoc (SQL)
        Else 'MaDonThuoc = True
            MsgBox "Ban chua nhap ma don thuoc", vbInformation
            If i > 1 Then i = i - 1
            arrThuoc(i).MaThuoc = ""
        End If 'end madonthuoc<>""
    Else 'co true
        disPlayDungThuoc (SQL)
    End If
    cmdBoBot.Enabled = True
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    Dim Msg As Long, MaDonThuoc$
    Msg = MsgBox("Ban co chac chan xoa don thuoc nay khong ", vbYesNo + vbQuestion)
    MaDonThuoc = Trim(txtMaDonThuoc.Text)
    If Msg = vbYes Then
        DE.sp_XoaKhamBenh MaDonThuoc
        DE.sp_XoaDonThuoc MaDonThuoc
        SetNull
        cmdXoa.Enabled = False
        disPlaylistDonThuoc
    End If
End Sub

Private Sub Form_Load()
    txtMaDonThuoc.Enabled = False
    cmdLuu.Enabled = False
    cmdThemThuoc.Enabled = False
    cmdBoBot.Enabled = False
    marNgayKeDon.Enabled = False
    txtHoTenBenhNhan.Enabled = False
    txtTenBenh.Enabled = False
    txtChiphi.Enabled = False
    txtHoTenNhanVien.Enabled = False
    txtTenThuoc.Enabled = False
    txtSoLuong.Enabled = False
    txtLieuDung.Enabled = False
    txtNoiKhamBenh.Enabled = False
    '==========================
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    disPlaylistDonThuoc
    i = 1
End Sub

Private Sub disPlayDungThuoc(SQL$)
    Dim rs As ADODB.Recordset
    Dim mItemDungT As listItem
    Dim dem As Long
    lstDungThuoc.ListItems.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItemDungT = lstDungThuoc.ListItems.Add(, , Trim(rs!TenThuoc))
                mItemDungT.SubItems(1) = rs!SoLuongDung
                mItemDungT.SubItems(2) = rs!LieuDung
                mItemDungT.SubItems(3) = rs!DonGia
                mItemDungT.SubItems(4) = rs!MaThuoc
            rs.MoveNext
        Loop
    End If
    For dem = 1 To i - 1
        Set mItemDungT = lstDungThuoc.ListItems.Add(, , Trim(arrThuoc(dem).TenThuoc))
            mItemDungT.SubItems(1) = arrThuoc(dem).SoLuong
            mItemDungT.SubItems(2) = arrThuoc(dem).LieuDung
            mItemDungT.SubItems(3) = arrThuoc(dem).DonGia
            mItemDungT.SubItems(4) = arrThuoc(dem).MaThuoc
    Next dem
End Sub

Private Sub disPlaylistDonThuoc()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItemDonT As listItem
    lstDonThuoc.ListItems.Clear
    SQL = "Select * From vwDonThuoc"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItemDonT = lstDonThuoc.ListItems.Add(, , Trim(rs!HoBenhNhan) & " " & Trim(rs!TenBenhNhan))
                   mItemDonT.SubItems(1) = rs!NgayKeDon
                   mItemDonT.SubItems(2) = rs!TenBenh
                   mItemDonT.SubItems(3) = rs!ChiPhiKhamBenh
                   mItemDonT.SubItems(4) = rs!HoTenNhanVien
                   mItemDonT.SubItems(5) = rs!MaDonThuoc
                   mItemDonT.SubItems(6) = rs!MaBenhNhan
                   mItemDonT.SubItems(7) = rs!TenViTriKB
                   mItemDonT.SubItems(8) = rs!MaViTriKB
                   mItemDonT.SubItems(9) = rs!MaNhanVien
                   mItemDonT.SubItems(10) = rs!MaBenh
                   mItemDonT.SubItems(11) = rs!NoiDungKhamBenh
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub lstDonThuoc_ItemClick(ByVal Item As MSComctlLib.listItem)
    Dim MaDonThuoc$, SQL$
    txtMaDonThuoc.Enabled = False
    txtHoTenBenhNhan.Text = Item.Text
    marNgayKeDon.Text = Item.SubItems(1)
    txtTenBenh.Text = Item.SubItems(2)
    txtChiphi.Text = Item.SubItems(3)
    txtHoTenNhanVien.Text = Item.SubItems(4)
    txtMaDonThuoc.Text = Item.SubItems(5)
    txtNoiKhamBenh.Text = Item.SubItems(7)
    MaDonThuoc = Trim(txtMaDonThuoc.Text)
    MaDonThuoclst = MaDonThuoc
    txtNoiDungKhamBenh.Text = Trim(Item.SubItems(11))
    '-------------------------------------------------------
    MaBenhNhanLst = Item.SubItems(6)
    MaViTrilst = Item.SubItems(8)
    MaNhanVienlst = Item.SubItems(9)
    MaBenhlst = Item.SubItems(10)
    '----------------------------------------
    txtHoTenNhanVien.Enabled = False
    txtHoTenBenhNhan.Enabled = False
    txtHoTenNhanVien.Enabled = False
    txtNoiKhamBenh.Enabled = False
    txtTenBenh.Enabled = False
    cmdXoa.Enabled = True
    '------------------------------------------------------------
    'MaBenhNhanLst = Item.SubItems(6)
    'MaNhanVienlst = Item.SubItems(9)
    'MaViTrilst = Item.SubItems(8)
    'MaBenhlst = Item.SubItems(10)
    '-----------------------------------------
    KhoiTaoMang
    cmdThemThuoc.Enabled = False
    cmdBoBot.Enabled = False
    SQL = "Select * From vwDungThuoc Where MaDonThuoc=" & MaDonThuoc
    disPlayDungThuoc (SQL)
End Sub

Private Sub lstDungThuoc_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtTenThuoc.Text = Item.Text
    txtSoLuong.Text = Item.SubItems(1)
    txtLieuDung.Text = Item.SubItems(2)
    MaThuoc = Item.SubItems(4)
    '----------------------------------------------
    'MaThuoclst = Item.SubItems(4)
End Sub

Private Sub txtChiphi_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, True
End Sub

Private Sub txtHoTenBenhNhan_Click()
    Dim MaBenhNhan$, HoTenBenhNhan$, NgaySinh$, GioiTinh As Boolean
    frmDanhSachBenhNhan.Show 1
    frmDanhSachBenhNhan.clThongTinBenhNhan.TraThongTinVeTuDanhSachBenhNhan _
                MaBenhNhan, HoTenBenhNhan, NgaySinh, GioiTinh
    txtHoTenBenhNhan.Text = HoTenBenhNhan
End Sub

Private Sub txtHoTenBenhNhan_KeyPress(KeyAscii As Integer)
    KeyAscii = 0
End Sub

Private Sub txtHoTenNhanVien_Click()
    Dim MaNhanVien$, TenNhanVien$
    frmDanhSachNhanVien.Show 1
    frmDanhSachNhanVien.clNhanVien.TraTTNhanVien MaNhanVien, TenNhanVien
    txtHoTenNhanVien.Text = TenNhanVien
End Sub

Private Sub txtHoTenNhanVien_KeyPress(KeyAscii As Integer)
    KeyAscii = 0
End Sub

Private Sub txtMaDonThuoc_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub txtNoiKhamBenh_Click()
    Dim MaNoiKhamBenh$, TenNoiKhamBenh$
    frmDanhSachViTriKhamBenh.Show 1
    frmDanhSachViTriKhamBenh.clViTri.TraTTNoiDT MaNoiKhamBenh, TenNoiKhamBenh
    txtNoiKhamBenh.Text = TenNoiKhamBenh
End Sub

Private Sub txtTenBenh_Click()
    Dim MaBenh$, TenBenh$
    frmDanhSachBenh.Show 1
    frmDanhSachBenh.clBenh.ThongTTRa MaBenh, TenBenh
    txtTenBenh.Text = TenBenh
End Sub

Private Sub SetNull()
    txtMaDonThuoc.Text = ""
    marNgayKeDon.Text = "__/__/____"
    txtHoTenBenhNhan.Text = ""
    txtHoTenNhanVien.Text = ""
    txtTenBenh.Text = ""
    txtChiphi.Text = ""
    txtTenThuoc.Text = ""
    txtSoLuong.Text = ""
    txtLieuDung.Text = ""
    txtNoiKhamBenh.Text = ""
    txtNoiDungKhamBenh.Text = ""
    lstDungThuoc.ListItems.Clear
    cmdBoBot.Enabled = False
End Sub

Private Sub txtTenBenh_KeyPress(KeyAscii As Integer)
    KeyAscii = 0
End Sub


Private Sub KhoiTaoMang()
    Dim i As Long
    For i = 1 To 20
        arrThuoc(i).DonGia = 0
        arrThuoc(i).LieuDung = ""
        arrThuoc(i).MaDonThuoc = ""
        arrThuoc(i).MaThuoc = ""
        arrThuoc(i).SoLuong = 0
        arrThuoc(i).TenThuoc = ""
    Next i
End Sub
