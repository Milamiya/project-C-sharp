Imports System.Data
Imports System.Data.SqlClient

Module MonHoc

    Public Sub loadmh()

        ds.Tables("monhoc").Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from monhoc"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("monhoc"))
    End Sub

    Public Sub addmh(ByVal mamh As String, ByVal tenmh As String, ByVal sotiet As Integer)

        Dim row As DataRow = ds.Tables("monhoc").NewRow()

        row("MAMH") = mamh
        row("TENMH") = tenmh
        row("SOTIET") = sotiet

        ds.Tables("monhoc").Rows.Add(row)

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = "insert into monhoc values(@mamh,@tenmh,@sotiet)"
        cmdi.Parameters.Add("@mamh", SqlDbType.NVarChar).Value = mamh
        cmdi.Parameters.Add("@tenmh", SqlDbType.NVarChar).Value = tenmh
        cmdi.Parameters.Add("@sotiet", SqlDbType.Int).Value = sotiet

        da.InsertCommand = cmdi

        da.Update(ds.Tables("monhoc"))

    End Sub

    Public Sub updmh(ByVal mamh As String, ByVal tenmh As String, ByVal sotiet As Integer)

        Dim row As DataRow = ds.Tables("monhoc").Select("MAMH='" & mamh & "'")(0)

        row.BeginEdit()

        row("TENMH") = tenmh
        row("SOTIET") = sotiet

        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " update monhoc set TENMH=@tenmh,SOTIET=@sotiet where MAMH=@mamh"

        cmdi.Parameters.Add("@tenmh", SqlDbType.NVarChar).Value = tenmh
        cmdi.Parameters.Add("@sotiet", SqlDbType.Int).Value = sotiet
        cmdi.Parameters.Add("@mamh", SqlDbType.NVarChar).Value = mamh

        da.UpdateCommand = cmdi
        da.Update(ds.Tables("monhoc"))

    End Sub
    Public Sub delmh(ByVal mamh As String)

        Dim row As DataRow = ds.Tables("monhoc").Select("MAMH='" & mamh & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from monhoc where MAMH=@mamh"
        cmdi.Parameters.Add("@mamh", SqlDbType.NVarChar).Value = mamh
        da.DeleteCommand = cmdi
        da.Update(ds.Tables("monhoc"))

    End Sub

    Public Function checkmh(ByVal mamh As String) As Integer

        Dim oledb As New SqlCommand("Select count(*) from monhoc where MAMH='" & mamh & "'", con)
        Return oledb.ExecuteScalar()

    End Function

    Public Function tenmh(ByVal mamh As String) As String

        Dim oledb As New SqlCommand("Select TENMH from monhoc where MAMH='" & mamh & "'", con)
        Return oledb.ExecuteScalar()

    End Function

End Module
