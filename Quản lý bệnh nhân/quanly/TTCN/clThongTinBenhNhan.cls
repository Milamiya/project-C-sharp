VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clThongTinBenhNhan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Private MaBN As String
Private HoTenBN As String

Public Sub TTBenhNhanVao(MaBenhNhan As String, HoTenBenhNhan As String)
    MaBN = MaBenhNhan
    HoTenBN = HoTenBenhNhan
End Sub

Public Sub TTBenhNhanRa(MaBenhNhan As String, HoTenBenhNhan As String)
    MaBenhNhan = MaBN
    HoTenBenhNhan = HoTenBN
End Sub
