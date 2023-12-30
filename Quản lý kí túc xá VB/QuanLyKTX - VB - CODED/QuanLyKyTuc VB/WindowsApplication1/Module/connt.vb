Imports System.Data
Imports System.Data.OleDb

Module connt

    Public con As OleDbConnection
    Public da As New OleDbDataAdapter
    Public ds As New DataSet

    Public Sub cnnt()

        Dim str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\qlkytucxa.mdb;"
        con = New OleDbConnection(str)
        con.Open()

    End Sub

End Module
