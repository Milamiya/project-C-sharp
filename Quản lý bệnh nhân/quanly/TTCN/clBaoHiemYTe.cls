VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clBaoHiemYTe"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private MaCQ As String
Private SoTheBH As String
Private NgayBD As String
Private NgayKT As String
Private PhanT As Currency

Public Sub TTBaoHiemVao(SoTheBaoHiem As String, _
            NgayBatDau As String, NgayKetThuc As String, _
            PhanTram As Currency, MaCoQuan As String)
    SoTheBH = SoTheBaoHiem
    NgayBD = NgayBatDau
    NgayKT = NgayKetThuc
    PhanT = PhanTram
    MaCQ = MaCoQuan
End Sub

Public Sub TTBaoHiemRa(SoTheBaoHiem As String, _
              NgayBatDau As String, NgayKetThuc As String, _
              PhanTram As Currency, MaCoQuan As String)
    SoTheBaoHiem = SoTheBH
    NgayBatDau = NgayBD
    NgayKetThuc = NgayKT
    PhanTram = PhanT
    MaCoQuan = MaCQ
End Sub

Public Sub SetNull()
    SoTheBH = ""
    NgayBD = "__/__/____"
    NgayKT = "__/__/____"
    PhanT = 0
    MaCQ = ""
End Sub

