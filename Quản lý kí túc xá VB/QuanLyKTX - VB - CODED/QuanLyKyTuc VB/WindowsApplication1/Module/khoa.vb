Imports System.Data
Imports System.Data.OleDb

Module khoa

    Public Sub loadkhoa()

        ds.Tables("khoa").Clear()

        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from khoa"
        da.SelectCommand = cmd
        da.Fill(ds.Tables("khoa"))

    End Sub

    Public Sub addkhoa(ByVal mak As String, ByVal ten As String)

        Dim row As DataRow = ds.Tables("khoa").NewRow()

        row("makhoa") = mak
        row("tenkhoa") = ten


        ds.Tables("khoa").Rows.Add(row)

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = "insert into khoa values(@makhoa,@tenkhoa)"
        cmdi.Parameters.Add("@makhoa", OleDbType.VarChar).Value = mak
        cmdi.Parameters.Add("@tenkhoa", OleDbType.VarChar).Value = ten

        da.InsertCommand = cmdi

        da.Update(ds.Tables("khoa"))
    End Sub

    Public Sub updkhoa(ByVal mak As String, ByVal ten As String)

        Dim row As DataRow = ds.Tables("khoa").Select("makhoa='" & mak & "'")(0)

        row.BeginEdit()
        row("tenkhoa") = ten
        row.EndEdit()

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " update khoa set tenkhoa=@tenkhoa where makhoa=@makhoa"

        cmdi.Parameters.Add("@tenkhoa", OleDbType.VarChar).Value = ten
        cmdi.Parameters.Add("@makhoa", OleDbType.VarChar).Value = mak

        da.UpdateCommand = cmdi
        da.Update(ds.Tables("khoa"))

    End Sub

    Public Sub delkhoa(ByVal a As String)

        Dim row As DataRow = ds.Tables("khoa").Select("makhoa='" & a & "'")(0)

        row.BeginEdit()
        row.Delete()
        row.EndEdit()

        Dim cmdi As New OleDbCommand
        cmdi.Connection = con
        cmdi.CommandType = CommandType.Text
        cmdi.CommandText = " delete from khoa where makhoa=@makhoa"
        cmdi.Parameters.Add("@makhoa", OleDbType.VarChar).Value = a

        da.DeleteCommand = cmdi
        da.Update(ds.Tables("khoa"))

    End Sub

    Public Function checkmkhoa(ByVal a As String) As Integer

        Dim oledbcom As New OleDbCommand("select count(*) from khoa where makhoa='" & a & "'", con)

        Return oledbcom.ExecuteScalar()

    End Function
End Module
