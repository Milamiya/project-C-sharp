Attribute VB_Name = "connection"
Option Explicit
Public cn As ADODB.connection
Public rs As ADODB.Recordset
Public sql As String

Public Sub ConnectDataBase()
    Set cn = New ADODB.connection
    cn.Provider = "Microsoft.Jet.OLEDB.4.0"
    'cn.CursorLocation = adUseClient
    cn.Open (App.Path + "\QLBH.mdb")
End Sub

Public Sub OpenData(st As String)
    ConnectDataBase
    Set rs = New ADODB.Recordset
    rs.Open st, cn
End Sub

Public Sub Closedata()
    rs.Close
    cn.Close
    Set rs = Nothing
    Set cn = Nothing
End Sub

Public Sub HightLight()
    If (Not Screen.ActiveForm Is Nothing) Then
        With Screen.ActiveForm
        If (TypeOf .ActiveControl Is TextBox) Then
            .ActiveControl.SelStart = 0
            .ActiveControl.SelLength = Len(.ActiveControl)
        End If
        End With
    End If
End Sub

