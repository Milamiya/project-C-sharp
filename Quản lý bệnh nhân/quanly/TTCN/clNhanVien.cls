VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clNhanVien"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private MaNV$, HoTenNV$
Public Sub LayTTNhanVien(MaNhanVien$, HoTenNhanVien$)
    MaNV = MaNhanVien
    HoTenNV = HoTenNhanVien
End Sub

Public Sub TraTTNhanVien(MaNhanVien$, HoTenNhanVien$)
    MaNhanVien = MaNV
    HoTenNhanVien = HoTenNV
End Sub

Public Sub SetNull()
    MaNV = ""
    HoTenNV = ""
End Sub

