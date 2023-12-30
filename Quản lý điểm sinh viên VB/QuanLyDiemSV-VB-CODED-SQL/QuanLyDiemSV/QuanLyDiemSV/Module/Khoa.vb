Imports System.Data
Imports System.Data.SqlClient

Module Khoa

    Public Sub loadkhoa()

        ds.Tables("khoa").Clear()

        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from khoa"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("khoa"))

    End Sub

    Public Sub addkhoa(ByVal makhoa As String, ByVal tenkhoa As String)

        Dim row As DataRow = ds.Tables("khoa").NewRow()

        row("MAKHOA") = makhoa
        row("TENKHOA") = tenkhoa

        ds.Tables("khoa").Rows.Add(row)

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = "insert into khoa values(@makhoa,@tenkhoa)"
        cmdi.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = makhoa
        cmdi.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = tenkhoa

        da.InsertCommand = cmdi

        da.Update(ds.Tables("khoa"))

    End Sub

    Public Sub updkhoa(ByVal makhoa As String, ByVal tenkhoa As String)

        Dim row As DataRow = ds.Tables("khoa").Select("MAKHOA='" & makhoa & "'")(0)

        row.BeginEdit()

        row("TENKHOA") = tenkhoa

        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " update khoa set TENKHOA=@tenkhoa where MAKHOA=@makhoa"

        cmdi.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = tenkhoa
        cmdi.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = makhoa

        da.UpdateCommand = cmdi
        da.Update(ds.Tables("khoa"))

    End Sub

    Public Sub delkhoa(ByVal makhoa As String)

        Dim row As DataRow = ds.Tables("khoa").Select("MAKHOA='" & makhoa & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New SqlCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from khoa where MAKHOA=@makhoa"
        cmdi.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = makhoa

        da.DeleteCommand = cmdi
        da.Update(ds.Tables("khoa"))

    End Sub

    Public Function checkkhoa(ByVal makhoa As String) As Integer

        Dim oledb As New SqlCommand("Select count(*) from khoa where MAKHOA='" & makhoa & "'", con)
        Return oledb.ExecuteScalar()

    End Function

    Public Function tenkhoa(ByVal makhoa As String) As String

        Dim oledb As New SqlCommand("Select TENKHOA from khoa where MAKHOA='" & makhoa & "'", con)
        Return oledb.ExecuteScalar()

    End Function

End Module
