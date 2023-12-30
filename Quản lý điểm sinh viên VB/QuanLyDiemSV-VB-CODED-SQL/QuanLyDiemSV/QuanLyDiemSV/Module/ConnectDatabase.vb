Imports System.Data
Imports System.Data.SqlClient

Module ConnectDatabase
    Public con As New SqlConnection
    Public da As New SqlDataAdapter
    Public ds As New DataSet

    Public Sub cnnt()
        Dim str As String = "Data Source=MYPC\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True"
        con = New SqlConnection(str)
        con.Open()
    End Sub

End Module