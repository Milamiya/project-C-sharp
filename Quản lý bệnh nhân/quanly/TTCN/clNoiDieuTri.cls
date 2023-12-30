VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clNoiDieuTri"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Private MaNDT$, TenNDT$

Public Sub LayTTNoiDT(MaNoiDieuTri$, TenNoiDieuTri$)
    MaNDT = MaNoiDieuTri
    TenNDT = TenNoiDieuTri
End Sub

Public Sub TraTTNoiDT(MaNoiDieuTri$, TenNoiDieuTri$)
     MaNoiDieuTri = MaNDT
     TenNoiDieuTri = TenNDT
End Sub

Public Sub SetNull()
    MaNDT = ""
    TenNDT = ""
End Sub

