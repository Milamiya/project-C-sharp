VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "CHUONG TRINH QUAN LY BENH VIEN KHANH HOA"
   ClientHeight    =   5595
   ClientLeft      =   165
   ClientTop       =   780
   ClientWidth     =   6405
   FillColor       =   &H00800080&
   BeginProperty Font 
      Name            =   "VNI-Times"
      Size            =   11.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H000000FF&
   Icon            =   "Main.frx":0000
   LinkTopic       =   "Form1"
   Picture         =   "Main.frx":0442
   ScaleHeight     =   5595
   ScaleWidth      =   6405
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Image Image1 
      Height          =   2700
      Left            =   0
      Picture         =   "Main.frx":F81F
      Top             =   5040
      Width           =   2865
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "SVTH : Nguyeãn Vaên Höng"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   495
      Left            =   8280
      TabIndex        =   2
      Top             =   7320
      Width           =   3495
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "GVHD : Nguyeãn Höõu Troïng"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   14.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   495
      Left            =   8280
      TabIndex        =   1
      Top             =   6840
      Width           =   3495
   End
   Begin VB.Label lblGioiThieu 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BackStyle       =   0  'Transparent
      Caption         =   "                             CHÖÔNG TRÌNH QUAÛN LYÙ BEÄNH NHAÂN                               TAÏI BEÄNH VIEÄN TÆNH KHAÙNH HOAØ"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   1095
      Left            =   0
      TabIndex        =   0
      Top             =   1080
      Width           =   11655
   End
   Begin VB.Menu mnuTapTin 
      Caption         =   "Taäp Tin"
      Begin VB.Menu mnuThoat 
         Caption         =   "Thoaùt"
      End
      Begin VB.Menu mnuGiupDo 
         Caption         =   "Giôùi Thieäu"
      End
   End
   Begin VB.Menu mnuNhapLieu 
      Caption         =   "Caäp Nhaät"
      Begin VB.Menu mnuTinh 
         Caption         =   "Tænh"
      End
      Begin VB.Menu mnuHuyen 
         Caption         =   "Huyeän"
      End
      Begin VB.Menu mnuXa 
         Caption         =   "Xaõ"
      End
      Begin VB.Menu mnuBenhNhan 
         Caption         =   "Thoâng Tin Beänh Nhaân"
      End
      Begin VB.Menu mnuBaoHiemYTe 
         Caption         =   "Baûo Hieåm Y Teá"
      End
      Begin VB.Menu mnuBenhAn 
         Caption         =   "Beänh AÙn"
      End
      Begin VB.Menu mnuViTri 
         Caption         =   "Vò Trí"
      End
      Begin VB.Menu mnuBenh 
         Caption         =   "Beänh"
      End
      Begin VB.Menu mnuNoiDieuTri 
         Caption         =   "Nôi Ñieàu Trò"
      End
      Begin VB.Menu mnuDichVu 
         Caption         =   "Dòch Vuï"
      End
      Begin VB.Menu mnuThuoc 
         Caption         =   "Thuoác "
      End
      Begin VB.Menu mnuHoSoNhanVien 
         Caption         =   "Hoà sô Nhaân Vieân "
      End
      Begin VB.Menu mnuCTNV 
         Caption         =   "Coâng Taùc Nhaân Vieân"
      End
      Begin VB.Menu mnuCoQuan 
         Caption         =   "Cô Quan"
      End
      Begin VB.Menu mnuDonThuoc 
         Caption         =   "Ñôn Thuoác"
      End
      Begin VB.Menu mnuTamUng 
         Caption         =   "Taïm ÖÙng"
      End
   End
   Begin VB.Menu mnuTimKiem 
      Caption         =   "Tìm Kieám - Thoáng Keâ"
      Begin VB.Menu mnuTimBenhNhan 
         Caption         =   "Tìm Beänh Nhaân"
      End
      Begin VB.Menu mnuThongKe 
         Caption         =   "Thoáng Keâ"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
    
Private Sub Form_Load()
    Flag = True
    OpenConnection
End Sub

Private Sub Form_Unload(Cancel As Integer)
    cn.Close
    Set cn = Nothing
End Sub

Private Sub mnuBaoHiemYTe_Click()
    frmBaoHiemYTe.Show 1
End Sub

Private Sub mnuBenh_Click()
    frmBenh.Show 1
End Sub

Private Sub mnuBenhAn_Click()
    frmBenhAn.Show 1
End Sub

Private Sub mnuBenhNhan_Click()
    frmBenhNhan.Show 1
End Sub

Private Sub mnuCoQuan_Click()
    frmCoQuan.Show 1
End Sub

Private Sub mnuCTNV_Click()
    frmCongTac.Show 1
End Sub

Private Sub mnuDichVu_Click()
    frmDichVu.Show 1
End Sub



Private Sub mnuDonThuoc_Click()
    frmDonThuoc.Show 1
End Sub

Private Sub mnuGiupDo_Click()
frmgioithieu.Show 1
End Sub

Private Sub mnuHoSoNhanVien_Click()
    frmHoSoNHanVien.Show 1
End Sub

Private Sub mnuHuyen_Click()
    frmHuyen.Show 1
End Sub

Private Sub mnuNoiDieuTri_Click()
    frmNoiDieuTri.Show 1
End Sub

Private Sub mnuTamUng_Click()
    frmTamUng.Show 1
End Sub

Private Sub mnuThoat_Click()
    End
End Sub


Private Sub mnuThongKe_Click()
    frmThongKe.Show 1
End Sub

Private Sub mnuThuoc_Click()
    frmThuoc.Show 1
End Sub

Private Sub mnuTimBenhNhan_Click()
    frmTimKiemBenhNhan.Show 1
End Sub

Private Sub mnuTinh_Click()
    frmTinh.Show 1
End Sub

Private Sub mnuViTri_Click()
    frmViTri.Show 1
End Sub

Private Sub mnuXa_Click()
    frmXa.Show 1
End Sub



