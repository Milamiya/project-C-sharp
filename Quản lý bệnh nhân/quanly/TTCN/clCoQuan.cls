VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clCoQuan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private MaCQ As String
Private TenCQ As String
Private DienThoai As String
Private Fax As String

Public Sub TTcoQuanVao(MaCoQuan As String, TenCoQuan As String, _
                                DienThoaiCoQuan As String, FaxCoQuan As String)
    MaCQ = MaCoQuan
    TenCQ = TenCoQuan
    DienThoai = DienThoaiCoQuan
    Fax = FaxCoQuan
End Sub

 Public Sub TTcoQuanRa(MaCoQuan As String, TenCoQuan As String, _
                                DienThoaiCoQuan As String, FaxCoQuan As String)
    MaCoQuan = MaCQ
    TenCoQuan = TenCQ
    DienThoaiCoQuan = DienThoai
    FaxCoQuan = Fax
End Sub

Public Sub SetNull()
    MaCQ = ""
    TenCQ = ""
    DienThoai = ""
    Fax = ""
End Sub

