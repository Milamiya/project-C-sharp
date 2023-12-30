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
      Caption         =   "SVTH : Nguye�n Va�n H�ng"
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
      Caption         =   "GVHD : Nguye�n H��u Tro�ng"
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
      Caption         =   "                             CH��NG TR�NH QUA�N LY� BE�NH NHA�N                               TA�I BE�NH VIE�N T�NH KHA�NH HOA�"
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
      Caption         =   "Ta�p Tin"
      Begin VB.Menu mnuThoat 
         Caption         =   "Thoa�t"
      End
      Begin VB.Menu mnuGiupDo 
         Caption         =   "Gi��i Thie�u"
      End
   End
   Begin VB.Menu mnuNhapLieu 
      Caption         =   "Ca�p Nha�t"
      Begin VB.Menu mnuTinh 
         Caption         =   "T�nh"
      End
      Begin VB.Menu mnuHuyen 
         Caption         =   "Huye�n"
      End
      Begin VB.Menu mnuXa 
         Caption         =   "Xa�"
      End
      Begin VB.Menu mnuBenhNhan 
         Caption         =   "Tho�ng Tin Be�nh Nha�n"
      End
      Begin VB.Menu mnuBaoHiemYTe 
         Caption         =   "Ba�o Hie�m Y Te�"
      End
      Begin VB.Menu mnuBenhAn 
         Caption         =   "Be�nh A�n"
      End
      Begin VB.Menu mnuViTri 
         Caption         =   "V� Tr�"
      End
      Begin VB.Menu mnuBenh 
         Caption         =   "Be�nh"
      End
      Begin VB.Menu mnuNoiDieuTri 
         Caption         =   "N�i �ie�u Tr�"
      End
      Begin VB.Menu mnuDichVu 
         Caption         =   "D�ch Vu�"
      End
      Begin VB.Menu mnuThuoc 
         Caption         =   "Thuo�c "
      End
      Begin VB.Menu mnuHoSoNhanVien 
         Caption         =   "Ho� s� Nha�n Vie�n "
      End
      Begin VB.Menu mnuCTNV 
         Caption         =   "Co�ng Ta�c Nha�n Vie�n"
      End
      Begin VB.Menu mnuCoQuan 
         Caption         =   "C� Quan"
      End
      Begin VB.Menu mnuDonThuoc 
         Caption         =   "��n Thuo�c"
      End
      Begin VB.Menu mnuTamUng 
         Caption         =   "Ta�m ��ng"
      End
   End
   Begin VB.Menu mnuTimKiem 
      Caption         =   "T�m Kie�m - Tho�ng Ke�"
      Begin VB.Menu mnuTimBenhNhan 
         Caption         =   "T�m Be�nh Nha�n"
      End
      Begin VB.Menu mnuThongKe 
         Caption         =   "Tho�ng Ke�"
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



