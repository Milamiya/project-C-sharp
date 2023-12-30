VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clBenhNhan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private MaBenhNhan$
Private TenBenhNhan$
Private NgaySinh$
Private GioiTinh As Boolean
'-----------------------------------------
Private MaT$, TenT$, DonG As Currency, SoL%, LieuD$
'-------------------------------------------------------------
'Phuong thuc lay thong tin benh nhan
Public Sub LayThongTinTuDanhSachBenhNhan(MaBN$, HoTenBN$, NgaySinhBN$, GioiTinhBn As Boolean)
    MaBenhNhan = MaBN
    TenBenhNhan = HoTenBN
    NgaySinh = NgaySinhBN
    GioiTinh = GioiTinhBn
End Sub
' tra ve thonh ti benh nhan da lay
Public Sub TraThongTinVeTuDanhSachBenhNhan(MaBN$, HoTenBN$, NgaySinhBN$, GioiTinhBn As Boolean)
    MaBN = MaBenhNhan
    HoTenBN = TenBenhNhan
    NgaySinhBN = NgaySinh
    GioiTinh = GioiTinhBn
End Sub
' Lay thong tin thuoc
Public Sub TTThuocVao(MaThuoc$, TenThuoc$, DonGia As Currency, SoLuong%, LieuDung$)
    MaT = MaThuoc
    TenT = TenThuoc
    DonG = DonGia
    SoL = SoLuong
    LieuD = LieuDung
End Sub
'tra ve thong tin thuoc
Public Sub TTThuocRa(MaThuoc$, TenThuoc$, DonGia As Currency, SoLuong%, LieuDung$)
    MaThuoc = MaT
    TenThuoc = TenT
    DonGia = DonG
    SoLuong = SoL
    LieuDung = LieuD
End Sub
 
 Public Sub SetNullThuoc()
    MaT = ""
    TenT = ""
    DonG = 0
    SoL = 0
    LieuDung = ""
 End Sub

Public Sub SetNullBenhNhan()
    MaBenhNhan = ""
    TenBenhNhan = ""
    NgaySinh = "__/__/____"
    GioiTinh = True
End Sub
