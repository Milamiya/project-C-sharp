VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clTTBenh"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Private MaB$
Private TenB$

Public Sub ThongTTVao(MaBenh$, TenBenh$)
    MaB = MaBenh
    TenB = TenBenh
End Sub

Public Sub ThongTTRa(MaBenh$, TenBenh$)
    MaBenh = MaB
    TenBenh = TenB
End Sub

Public Sub SetNull()
    MaB = ""
    TenB = ""
End Sub
