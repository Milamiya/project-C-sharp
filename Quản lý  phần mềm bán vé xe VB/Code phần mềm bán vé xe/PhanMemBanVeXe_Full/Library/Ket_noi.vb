Imports System.Data.SqlClient

Module Ket_noi
    Public connect As SqlConnection

    Public Sub Tao_ket_noi()
        If connect Is Nothing Then
            Dim chuoi_ket_noi As String = "Data Source=.\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuanLyBenXe"
            connect = New SqlConnection(chuoi_ket_noi)
        End If
    End Sub

    Public Function Doc_bang(ByVal lenh As String) As DataTable
        Tao_ket_noi()
        Dim bang As New Data.DataTable()
        Dim bo_doc_ghi As New SqlDataAdapter(lenh, connect)
        bo_doc_ghi.FillSchema(bang, SchemaType.Source)
        bo_doc_ghi.Fill(bang)
        Return bang
    End Function

    
End Module
