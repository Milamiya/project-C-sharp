VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clTachDiaChi"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Private TenT As String
Private TehH As String
Private TenX As String
Private DiaC As String

Public Sub DiaChiVao(DiaChi As String)
    DiaC = "/" & Trim(DiaChi)
End Sub

Public Sub TachDiaChi(TenXa As String, TenHuyen As String, _
                                            TenTinh As String)
    Dim i As Long
    Dim Tam As String
    i = InStrRev(DiaC, "/")
    If i > 1 Then
        TenTinh = Mid(DiaC, i + 1)
        TenTinh = SuLiChuoi(TenTinh)
        Tam = Mid(DiaC, 1, i - 1)
        i = InStrRev(Tam, "/")
        If i > 1 Then
            TenHuyen = Mid(Tam, i + 1)
            TenXa = Mid(Tam, 2, i - 2)
            TenXa = SuLiChuoi(TenXa)
            TenHuyen = SuLiChuoi(TenHuyen)
        Else
            TenHuyen = Mid(Tam, 2, Len(Tam) - 1)
            TenHuyen = SuLiChuoi(TenHuyen)
        End If
    Else
        TenTinh = Mid(DiaC, 2)
        TenTinh = SuLiChuoi(TenTinh)
    End If
End Sub

