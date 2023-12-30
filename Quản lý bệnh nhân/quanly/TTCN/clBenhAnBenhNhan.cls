VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clBenhAnBenhNhan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Private MaBA As String
Private MaNV As String
Private MaB As String
Private MaNDT As String
Private NgayV As String
Private NgayR As String

Public Sub TTBenhAnVao(MaBenhAn As String, MaNhanVien As String, _
                                            MaBenh As String, MaNoiDieuTri As String, _
                                            NgayVao As String, NgayRa As String)
    MaBA = MaBenhAn
    MaNV = MaNhanVien
    MaB = MaBenh
    MaNDT = MaNoiDieuTri
    NgayV = NgayVao
    NgayR = NgayRa
End Sub
                                        
Public Sub TTBenhAnRa(MaBenhAn As String, MaNhanVien As String, _
                                        MaBenh As String, MaNoiDieuTri As String, _
                                        NgayVao As String, NgayRa As String)
    MaBenhAn = MaBA
    MaNhanVien = MaNV
    MaBenh = MaB
    MaNoiDieuTri = MaNDT
    NgayVao = NgayV
    NgayRa = NgayR
End Sub

Public Sub SetNull()
    MaBA = ""
    MaNV = ""
    MaB = ""
    MaNDT = ""
    NgayV = "__/__/____"
    NgayR = "__/__/____"
End Sub
    

